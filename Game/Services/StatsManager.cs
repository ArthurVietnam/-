using System.Text.Json;
using WinFormsApp1.Entity;

namespace WinFormsApp1.Services;

public class StatsManager
{
    private static readonly string Path = "game_history.json";

    public static List<GameSession> Load()
    {
        if (!File.Exists(Path)) return new List<GameSession>();

        var json = File.ReadAllText(Path);
        var list = JsonSerializer.Deserialize<List<GameSession>>(json);
        return list ?? new();
    }

    public static void SaveSession(GameSession session)
    {
        var list = Load();

        list = list.Where(s => s.Date >= DateTime.Now.AddMonths(-1)).ToList();

        list.Add(session);
        File.WriteAllText(Path, JsonSerializer.Serialize(list));
    }

    public static List<GameSession> GetTopPlayers(int count = 10)
    {
        return Load()
            .Where(s => s.Date >= DateTime.Now.AddMonths(-1))
            .GroupBy(s => s.Username)
            .Select(g => new { Username = g.Key, Total = g.Sum(s => s.Score) })
            .OrderByDescending(g => g.Total)
            .Take(count)
            .Select(g => new GameSession { Username = g.Username, Score = g.Total })
            .ToList();
    }

    public static List<GameSession> GetUserSessions(string username)
    {
        return Load()
            .Where(s => s.Username == username && s.Date >= DateTime.Now.AddDays(-30))
            .OrderByDescending(s => s.Date)
            .ToList();
    }
}