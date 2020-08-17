using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    static class Program
    {
        public static StartForm  startForm;
        public static SelectForm selectForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startForm = new StartForm();
            selectForm = new SelectForm();


            Application.Run(startForm);
        }
    }
}
