using System.ComponentModel;

namespace WinFormsApp1.Forms;

partial class Welcome
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    private Button startButton;

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
        
        this.startButton = new Button();
        this.SuspendLayout();

        this.startButton.Text = "Начать";
        this.startButton.Dock = DockStyle.Fill;
        this.startButton.Click += new System.EventHandler(this.startButton_Click);

        this.Controls.Add(this.startButton);
        this.Text = "Угадай число";
        this.Width = 900;
        this.Height = 600;
        this.ResumeLayout(false);
    }

    #endregion
}