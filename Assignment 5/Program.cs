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
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static SplashForm splashForm;
        public static InfoClass infoClass;
        public static AboutBoxForm aboutBoxForm;
        public static ConfirmBox confirmBox;
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
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            splashForm = new SplashForm();
            infoClass = new InfoClass();
            aboutBoxForm = new AboutBoxForm();
            confirmBox = new ConfirmBox();


            Application.Run(splashForm);
        }
    }
}
