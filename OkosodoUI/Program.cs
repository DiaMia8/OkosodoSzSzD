using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkosodoUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Adatbázis kapcsolat inicializálása
            OkosodoLibrary.GlobalConfig.InitializeConnections(true);


            Application.Run(new MainMenuForm());
            
        }
    }
}
