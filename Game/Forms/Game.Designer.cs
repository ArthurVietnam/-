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
        inputBox = new TextBox();
        guessButton = new Button();
        viewStatsButton = new Button();
        
        difficultySelector.Items.AddRange(new string[] { "Easy(10)", "Medium(50)", "Hard(100)", "Insane(500)", "Imposible(1000)" });
        difficultySelector.SelectedIndex = 0;
        difficultySelector.Dock = DockStyle.Top;
        difficultySelector.SelectedIndexChanged += difficultySelector_SelectedIndexChanged;
        
        inputBox.Dock = DockStyle.Top;
        
        guessButton.Text = "Угадать";
        guessButton.Dock = DockStyle.Top;
        guessButton.Click += guessButton_Click;
        
        viewStatsButton.Text = "Статистика";
        viewStatsButton.Dock = DockStyle.Top;
        viewStatsButton.Click += viewStatsButton_Click;
        
        Controls.Add(viewStatsButton);
        Controls.Add(guessButton);
        Controls.Add(inputBox);
        Controls.Add(difficultySelector);
        Text = "Игра";
        this.Width = 900;
        this.Height = 600;
    }

    #endregion
}