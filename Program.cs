using Squirrel;
using System.Threading.Tasks;

namespace ActViewer
{
    internal static class Program
    {
        static oobe splashscreen;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            SquirrelAwareApp.HandleEvents(
                             onInitialInstall: OnAppInstall,
                             onAppUninstall: OnAppUninstall,
                             onEveryRun: OnAppRun);

            /*splashscreen = new oobe();
            splashscreen.Show();*/

            Form1 mainform = new Form1();
            mainform.Shown += main_Shown;

            Application.Run(mainform);
        }

        static void main_Shown(object sender, EventArgs e)
        {
            // Hide the splashscreen. 
            splashscreen?.Hide();
        }

        private static void OnAppInstall(SemanticVersion version, IAppTools tools)
        {
            tools.CreateShortcutForThisExe(ShortcutLocation.StartMenu | ShortcutLocation.Desktop);
        }

        private static void OnAppUninstall(SemanticVersion version, IAppTools tools)
        {
            tools.RemoveShortcutForThisExe(ShortcutLocation.StartMenu | ShortcutLocation.Desktop);
        }

        private static void OnAppRun(SemanticVersion version, IAppTools tools, bool firstRun)
        {
            tools.SetProcessAppUserModelId();
        }
    }
}