using System;
using System.Windows.Forms;
using WorkoutManager;

namespace WorkoutManagerGUI {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WorkoutApplication application = new WorkoutApplication();

            Application.Run(new Form1());
        }
    }
}
