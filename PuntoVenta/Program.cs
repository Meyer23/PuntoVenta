using PuntoVenta.Modulos;
<<<<<<< HEAD
using PuntoVenta.Modulos.Compras;
using PuntoVenta.Modulos.VentanaPrincipal;
=======
using PuntoVenta.Modulos.Productos;
>>>>>>> 9dd42d44278243e425760ad7b9c38169819d50dc
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
<<<<<<< HEAD
            Application.Run(new VentanaPrincipal());
=======
            Application.Run(new Productos());
>>>>>>> 9dd42d44278243e425760ad7b9c38169819d50dc
        }
    }
}