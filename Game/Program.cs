using WinFormsApp1.Entity;
using WinFormsApp1.Forms;

namespace WinFormsApp1;

static class Program
{
    public static string CurrentUsername { get; set; }
    
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Welcome());
    }
}