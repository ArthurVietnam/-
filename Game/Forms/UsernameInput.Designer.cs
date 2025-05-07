using System.ComponentModel;

namespace WinFormsApp1.Forms;

partial class UsernameInput
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;
    private TextBox usernameBox;
    private Button continueButton;

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
        this.usernameBox = new TextBox();
        this.continueButton = new Button();
            
        this.usernameBox.Dock = DockStyle.Top;
        this.usernameBox.PlaceholderText = "Введите имя пользователя состоящее из 3ёх букв";
        this.usernameBox.MaxLength = 3;

        this.continueButton.Text = "Продолжить";
        this.continueButton.Dock = DockStyle.Top;
        this.continueButton.Click += continueButton_Click;

        this.Controls.Add(continueButton);
        this.Controls.Add(usernameBox);
        this.Text = "Имя игрока";
        this.Width = 900;
        this.Height = 600;
    }

    #endregion
}