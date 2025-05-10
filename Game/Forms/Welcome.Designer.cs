using System.ComponentModel;

namespace WinFormsApp1.Forms;

partial class Welcome
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    private Button startButton;
    private Label startLabel;

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
        startLabel = new Label();
        startButton = new Button();
        SuspendLayout();

        startButton.Text = "Начать";
        startButton.Dock = DockStyle.Fill;
        startButton.Click += new System.EventHandler(startButton_Click);

        startLabel.Text = "Угадай число";
        startLabel.Dock = DockStyle.Top;
        startLabel.Height = 100;
        startLabel.TextAlign = ContentAlignment.MiddleCenter;
        startLabel.BackColor = Color.Crimson;
        startLabel.Font = new Font("Segoe UI", 32F, FontStyle.Bold);

        Controls.Add(startLabel);
        Controls.Add(startButton);
        Text = "Угадай число";
        Width = 900;
        Height = 600;
        ResumeLayout(false);
    }

    #endregion
}