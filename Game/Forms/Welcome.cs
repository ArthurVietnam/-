namespace WinFormsApp1.Forms;

public partial class Welcome : Form
{
    public Welcome()
    {
        InitializeComponent();
    }
    private void startButton_Click(object sender, EventArgs e)
    {
        Hide();
        new UsernameInput().ShowDialog();
        Close();
    }
}