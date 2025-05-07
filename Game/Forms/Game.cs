using WinFormsApp1.Entity;
using WinFormsApp1.Services;

namespace WinFormsApp1.Forms;

public partial class Game : Form
{
    private int target;
    private int attempts;
    private string difficulty;
    private Random rng = new();

    public Game()
    {
        InitializeComponent();
        difficulty = "Easy";
        GenerateNumber();
    }

    private void GenerateNumber()
    {
        (int min, int max) = difficulty switch
        {
            "Easy" => (1, 10),
            "Medium" => (1, 50),
            "Hard" => (1, 100),
            "Insane" => (1, 500),
            _ => (1, 10)
        };
        target = rng.Next(min, max + 1);
        attempts = 0;
    }

    private void guessButton_Click(object sender, EventArgs e)
    {
        if (int.TryParse(inputBox.Text, out int guess))
        {
            attempts++;
            if (guess == target)
            {
                int score = difficulty switch
                {
                    "Easy" => 1,
                    "Medium" => 3,
                    "Hard" => 5,
                    "Insane" => 10,
                    _ => 1
                };

                StatsManager.SaveSession(new GameSession
                {
                    Username = Program.CurrentUsername,
                    Difficulty = difficulty,
                    Date = DateTime.Now,
                    Score = score
                });

                MessageBox.Show($"Правильно! Число было {target}. Очки: {score}");
                GenerateNumber();
            }
            else
                MessageBox.Show(guess < target ? "Больше" : "Меньше");
        }
        else
            MessageBox.Show("Введите число!");
    }

    private void difficultySelector_SelectedIndexChanged(object sender, EventArgs e)
    {
        difficulty = difficultySelector.SelectedItem.ToString();
        GenerateNumber();
    }
    
    private void viewStatsButton_Click(object sender, EventArgs e)
    {
        new StatsViewer().ShowDialog();
    }

}
