using System.Text;

namespace OracleSqlWizard
{
    
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LogInWindow());
        }
        
    }
}