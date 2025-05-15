using WinFormsApp1.Entity;
using WinFormsApp1.Services;

namespace WinFormsApp1.Forms;

public partial class Game : Form
{
    private int target;
    private int attempts;
    private string difficulty;
    private Random rnd = new();

    public Game()
    {
        InitializeComponent();
        difficulty = "Easy(10)";
        GenerateNumber();
    }

    private void GenerateNumber()
    {
        (int min, int max) = difficulty switch
        {
            "Easy(10)" => (1, 10),
            "Medium(50)" => (1, 50),
            "Hard(100)" => (1, 100),
            "Insane(500)" => (1, 500),
            "Imposible(1000)" => (1,1000),
            _ => (1, 10)
        };
        target = rnd.Next(min, max + 1);
        attempts = 0;
    }

    private void guessButton_Click(object sender, EventArgs e)
    {
        if (int.TryParse(inputBox.Text, out int guess))
        {
            attempts++;

            if (difficulty switch
                {
                    "Easy(10)" => 10,
                    "Medium(50)" => 50,
                    "Hard(100)" => 100,
                    "Insane(500)" => 500,
                    "Imposible(1000)" => 1000,
                    _ => 10
                }
                <= attempts)
            {
                MessageBox.Show("Превышен лимит попыток для данного уровня, число сгенерированно заново");
                GenerateNumber();
            }
            
            else if (guess == target)
            {
                int score = difficulty switch
                {
                    "Easy(10)" => 1,
                    "Medium(50)" => 5,
                    "Hard(100)" => 10,
                    "Insane(500)" => 50,
                    "Imposible(1000)" => -1,
                    _ => 1
                };

                if (score == -1)
                {
                    var gameSession = StatsManager.GetUserSessions(Program.CurrentUsername);
                    var sum = gameSession.Sum(g => g.Score);
                    score = attempts <= 9 ? (sum < 100 ? 100 : sum * 2) : (sum == 0 ? 0 : sum * -1);
                }

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
        inputBox.Text = "";
    }

    private void difficultySelector_SelectedIndexChanged(object sender, EventArgs e)
    {
        difficulty = difficultySelector.SelectedItem?.ToString() ?? "" ;
        GenerateNumber();
    }
    
    private void viewStatsButton_Click(object sender, EventArgs e)
    {
        new StatsViewer().ShowDialog();
    }

    private void viewRulesButton_Click(object sender, EventArgs e)
    {
        new Rules().ShowDialog();
    }

}
