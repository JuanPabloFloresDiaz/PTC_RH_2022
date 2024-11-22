using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC_Oficial
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (Usuario.Verificar() == true)
            {
                Application.Run(new Login());
            }
            else
            {
                Application.Run(new Primer_Uso());
            }
            //Application.Run(new TipoRC());
        }
    }
}
