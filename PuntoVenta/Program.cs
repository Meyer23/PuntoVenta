using PuntoVenta.Modulos;
using PuntoVenta.Modulos.ClientesOk;
using PuntoVenta.Modulos.Compras;
using PuntoVenta.Modulos.VentanaPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
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
            Application.Run(new ClientesOk());
        }
    }
}