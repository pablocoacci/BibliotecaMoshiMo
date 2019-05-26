using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Se setean los parametros de configuracion obtenidos desde el archivo XML. Si el archivo no existe se crea
            DominioClases.Clases.ParametrosConfiguracion pConfig = new DominioClases.Clases.ParametrosConfiguracion();
            pConfig.SetStaticParameters();

            bool loginResult = false;
            using (var frmLogin = new frmLogin())
            {
                frmLogin.ShowDialog();
                loginResult = frmLogin._loginResult;
            }

            if (loginResult)
                Application.Run(new frmMain());
        }
    }
}
