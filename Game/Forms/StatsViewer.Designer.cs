using System.ComponentModel;

namespace WinFormsApp1.Forms;

partial class StatsViewer
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;
    private DataGridView statsGrid;
    private ComboBox viewSelector;
    private Button refreshButton;

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
        statsGrid = new DataGridView
        {
            Dock = DockStyle.Fill,
            Height = 40,
            Font = new Font("Segoe UI", 12F, FontStyle.Bold),
            ReadOnly = true,
            ColumnHeadersHeight = 40,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        };

        viewSelector = new ComboBox
        {
            Dock = DockStyle.Top,
            Height = 40,
            Font = new Font("Segoe UI", 12F, FontStyle.Bold),
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        viewSelector.Items.AddRange(new[] { "Топ игроков", "Моя статистика" });
        viewSelector.SelectedIndex = 0;
        viewSelector.SelectedIndexChanged += ViewSelector_SelectedIndexChanged;

        refreshButton = new Button
        {
            Text = "Обновить",
            Dock = DockStyle.Top
        };
        refreshButton.Height = 30;
        refreshButton.Click += (s, e) => RefreshStats();

        Controls.Add(statsGrid);
        Controls.Add(refreshButton);
        Controls.Add(viewSelector);

        Text = "Статистика";
        Width = 600;
        Height = 400;
    }

    #endregion
}