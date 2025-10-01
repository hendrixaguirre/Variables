using System;
using System.Windows.Forms;

namespace Variables
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (FrmLogin Login = new FrmLogin())
            {
                if (Login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmPrincipal());
                }

            }
        }
    }
}
