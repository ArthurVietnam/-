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
        usernameBox = new TextBox();
        continueButton = new Button();
            
        usernameBox.Dock = DockStyle.Top;
        usernameBox.Height = 40;
        usernameBox.PlaceholderText = "Введите имя пользователя состоящее из 3ёх букв";
        usernameBox.MaxLength = 3;
        usernameBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        
        continueButton.Text = "Продолжить";
        continueButton.Dock = DockStyle.Top;
        continueButton.Height = 30;
        continueButton.Click += continueButton_Click;

        
        Controls.Add(continueButton);
        Controls.Add(usernameBox);
        Text = "Имя игрока";
        Width = 900;
        Height = 600;
    }

    #endregion
}