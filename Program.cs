using LaborStackApp.Toolkits;
using SQLite;
using System;
using System.IO;
using System.Windows.Forms;

namespace LaborStackApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LaborStackApp.db");
            SQLiteConnection db = new SQLiteConnection(databasePath);
            Common.DataTableInitExecute(db, "LaborStackApp.Model");

            Application.Run(new LoginForm(db));
        }
    }
}
