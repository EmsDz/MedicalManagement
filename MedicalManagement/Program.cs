using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement
{
    internal static class Program
    {


        public static Form FrmLogin = null;
        public static Form FrmMain = null;
        public static Form FrmReport = null;
        public static String MyMacAdress = null;
      


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Compartidos.Form_.Frm_Lgin());
        }

  
    }
}
