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
            UsuariosOk frm_usuarios = new UsuariosOk();

            frm_usuarios.ShowDialog();
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            Proveedores frm_proveedores = new Proveedores();

            frm_proveedores.ShowDialog();
        }

        private void MenuClientes_Click(Object sender, EventArgs e)
        {
            Clientes frm_clientes = new Clientes();

            frm_clientes.ShowDialog();
        }

        private void MenuFacturas_Click(object sender, EventArgs e)
        {
            Facturas frm_factura = new Facturas();

            frm_factura.ShowDialog();
        }
    }
}