using System.Text.RegularExpressions;

namespace WinFormsApp1.Forms;

public partial class UsernameInput : Form
{
    public UsernameInput()
    {
        InitializeComponent();
    }
    
    private void continueButton_Click(object sender, EventArgs e)
    {
        var name = usernameBox.Text.ToUpper();
        if (Regex.IsMatch(name, "^[A-Z]{3}$"))
        {
            Program.CurrentUsername = name;
            Hide();
            new Game().ShowDialog();
            Close();
        }
        else
            MessageBox.Show("Введите ровно 3 заглавные буквы");
    }
}