using WinFormsApp1.Services;

namespace WinFormsApp1.Forms;

public partial class StatsViewer : Form
{
    public StatsViewer()
    {
        InitializeComponent();
    }
    private void RefreshStats()
    {
        if (viewSelector.SelectedIndex == 0)
            LoadTopPlayers();
        else
            LoadUserSessions();
    }

    private void ViewSelector_SelectedIndexChanged(object sender, EventArgs e)
    {
        RefreshStats();
    }

    private void LoadTopPlayers()
    {
        statsGrid.Columns.Clear();
        statsGrid.Columns.Add("Username", "Имя");
        statsGrid.Columns.Add("Score", "Сумма очков");

        statsGrid.Rows.Clear();
        foreach (var session in StatsManager.GetTopPlayers())
        {
            statsGrid.Rows.Add(session.Username, session.Score);
        }
    }

    private void LoadUserSessions()
    {
        statsGrid.Columns.Clear();
        statsGrid.Columns.Add("Date", "Дата");
        statsGrid.Columns.Add("Difficulty", "Сложность");
        statsGrid.Columns.Add("Score", "Очки");

        statsGrid.Rows.Clear();
        foreach (var session in StatsManager.GetUserSessions(Program.CurrentUsername))
        {
            statsGrid.Rows.Add(session.Date.ToString("g"), session.Difficulty, session.Score);
        }
    }
}