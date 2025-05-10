using System.ComponentModel;

namespace WinFormsApp1.Forms;

partial class Rules
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    private Panel scrollPanel;
    private Label rules;
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
        rules = new Label();
        scrollPanel = new Panel();
        scrollPanel.Dock = DockStyle.Fill;
        scrollPanel.AutoScroll = true;
        
        #region Rules
        
        rules.Text = 
            @"Правила игры ""Угадай число""

Цель игры:
Угадать загаданное число за наименьшее количество попыток.
 Как играть:

    Выберите уровень сложности из выпадающего списка:

        Easy (1–10)

        Medium (1–50)

        Hard (1–100)

        Insane (1–500)

        Impossible (1–1000)

    Введите предполагаемое число в поле ввода и нажмите кнопку ""Угадать"".

    Игра подскажет:

        ""Больше"", если загаданное число больше вашего;

        ""Меньше"", если загаданное число меньше вашего;

        ""Правильно!"", если вы угадали.

 Ограничения:

    На каждом уровне сложности можно сделать максимум N попыток, где N = максимальное число диапазона (например, 10 попыток для Easy).

    Превышение лимита попыток приводит к сбросу текущего числа и началу новой попытки.

 Очки:

    Easy — 1 очко

    Medium — 5 очков

    Hard — 10 очков

    Insane — 50 очков

    Impossible — специальные правила:

Если угадал за <= 9 попыток и твоя сумма очков < 100, ты получаешь 100 очков.
Если сумма очков >= 100, то получаешь ×2 от суммы.
Если не угадал — получаешь отрицательное количество очков (−1 × сумма).
 Статистика:

Нажми кнопку ""Статистика"", чтобы посмотреть свои достижения за последние 30 дней.";
        
         #endregion
        rules.AutoSize = true;
        
        scrollPanel.Controls.Add(rules);
        Controls.Add(scrollPanel);
        Text = "Правила";
        Width = 600;
        Height = 400;
    }

    #endregion
}