using PuntoVenta.Modulos.Compras;
using PuntoVenta.Modulos.Productos;
using PuntoVenta.Modulos.Utils;
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

        public void MostrarUsuarioPanel(string usuarioNombre)
        {
            LoginPanel.Visible = true;
            TxtUsuario.Text = usuarioNombre;
        }

        public void MostrarRol(string rolUsuario)
        {
            LabelRol.Text = rolUsuario;
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosOk frm_usuarios = new UsuariosOk();

            if(LabelRol.Text != Roles.Administrador.ToString())
            {
                MessageBox.Show("Usted no tiene acceso a este nivel del sistema.");
            }
            else
            {
                frm_usuarios.ShowDialog();
            }
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            Proveedores frm_proveedores = new Proveedores();

            frm_proveedores.ShowDialog();
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            Clientes frm_clientes = new Clientes();

            frm_clientes.ShowDialog();
        }

        private void MenuProductos_Click(object sender, EventArgs e)
        {
            Producto frm_productos = new Producto();

            frm_productos.ShowDialog();
        }

        private void MenuCategorias_Click(object sender, EventArgs e)
        {
            Categoria frm_categorias = new Categoria();

            frm_categorias.ShowDialog();
        }

        private void MenuUnidadesMedidas_Click(object sender, EventArgs e)
        {
            UnidadesMedidas frm_umedidas = new UnidadesMedidas();

            frm_umedidas.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuFacuras_Click(object sender, EventArgs e)
        {
            Facturas frm_facturas = new Facturas();

            var estadoCaja = frm_facturas.ConsultarCaja().Item1;
            if(estadoCaja == "ACTIVO")
            {
                frm_facturas.Show();
                frm_facturas.MostrarEstadoCaja();
            }
            else
            {
                MessageBox.Show("Debe iniciar la caja para efectuar ventas.");
            }
        }

        private void MeuCaja_Click(object sender, EventArgs e)
        {
            Facturas frm_facturas = new Facturas();

            var estadoCaja = frm_facturas.ConsultarCaja().Item1;
            if (estadoCaja == "ACTIVO")
            {
                MessageBox.Show("Ya existe una caja activa actualmente, debe cerrarla para abrir otra."); 
            }
            else
            {
                Caja frm_caja = new Caja();
                frm_caja.ShowDialog();
            }
        }

        private void AdministrarCaja_Click(object sender, EventArgs e)
        {
            Facturas frm_facturas = new Facturas();

            var estadoCaja = frm_facturas.ConsultarCaja().Item1;
            if (estadoCaja == "ACTIVO")
            {
                AdministrarCaja form_administrarCaja = new AdministrarCaja();
                form_administrarCaja.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("No existe una caja activa ahora mismo.");
            }
        }
    }
}