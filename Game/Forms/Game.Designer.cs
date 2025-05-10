using System.ComponentModel;

namespace WinFormsApp1.Forms;

partial class Game
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;
    private ComboBox difficultySelector;
    private TextBox inputBox;
    private Button guessButton;
    private Button viewStatsButton;
    private Button viewRulesButton;
    private Label dificultyLabel;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        difficultySelector = new ComboBox();
        dificultyLabel = new Label();
        inputBox = new TextBox();
        guessButton = new Button();
        viewStatsButton = new Button();
        viewRulesButton = new Button();
        
        dificultyLabel.Text = "Выбор уровня сложности:";
        dificultyLabel.Dock = DockStyle.Top;
        dificultyLabel.Height = 40;
        dificultyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        
        difficultySelector.Items.AddRange(new string[] { "Easy(10)", "Medium(50)", "Hard(100)", "Insane(500)", "Imposible(1000)" });
        difficultySelector.SelectedIndex = 0;
        difficultySelector.Dock = DockStyle.Top;
        difficultySelector.SelectedIndexChanged += difficultySelector_SelectedIndexChanged;
        difficultySelector.Height = 40;
        difficultySelector.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        
        inputBox.Dock = DockStyle.Top;
        inputBox.PlaceholderText = "Введите предпологаемое число";
        inputBox.Height = 40;
        inputBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        
        guessButton.Text = "Угадать";
        guessButton.Dock = DockStyle.Top;
        guessButton.Height = 30;
        guessButton.Click += guessButton_Click;
        
        viewStatsButton.Text = "Статистика";
        viewStatsButton.Dock = DockStyle.Bottom;
        viewStatsButton.Height = 30;
        viewStatsButton.Click += viewStatsButton_Click;

        viewRulesButton.Text = "Правила";
        viewRulesButton.Dock = DockStyle.Bottom;
        viewRulesButton.Height = 30;
        viewRulesButton.Click += viewRulesButton_Click;
        
        Controls.Add(viewRulesButton);
        Controls.Add(viewStatsButton);
        Controls.Add(guessButton);
        Controls.Add(inputBox);
        Controls.Add(difficultySelector);
        Controls.Add(dificultyLabel);
        
        Text = "Игра";
        Width = 900; 
        Height = 600;
    }

    #endregion
}