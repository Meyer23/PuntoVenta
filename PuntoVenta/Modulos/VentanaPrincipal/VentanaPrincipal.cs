using PuntoVenta.Modulos.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.VentanaPrincipal
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            usuariosok frm_usuarios = new usuariosok();

            frm_usuarios.ShowDialog();
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            Proveedores frm_proveedores = new Proveedores();

            frm_proveedores.ShowDialog();
        }
    }
}
