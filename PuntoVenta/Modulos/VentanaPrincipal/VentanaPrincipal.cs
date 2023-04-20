using PuntoVenta.Modulos.Compras;
using PuntoVenta.Modulos.Productos;
using PuntoVenta.Modulos.Empleados;
using PuntoVenta.Modulos.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PuntoVenta.Modulos.Roles;
using PuntoVenta.Modulos.Usuarios_Ok;
using PuntoVenta.Modulos.Timbrado_Ok;
using PuntoVenta.Modulos.GrupoDocumento_Ok;

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
            if (estadoCaja == "ACTIVO")
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

        private void MenuEmpleados_Click(object sender, EventArgs e)
        {
            EmpleadosOk frm_empleados = new EmpleadosOk();

            frm_empleados.ShowDialog();
        }

        private void MenuRoles_Click(object sender, EventArgs e)
        {
            Rol frm_roles = new Rol();

            frm_roles.ShowDialog();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios frm_usuarios = new Usuarios();

            frm_usuarios.ShowDialog();
        }

        private void MenuImpuestos_Click(object sender, EventArgs e)
        {
            Impuestos frm_impuestos = new Impuestos();

            frm_impuestos.ShowDialog();
        }

        private void MenuValores(object sender, EventArgs e)
        {
            TiposValores frm_valores = new TiposValores();

            frm_valores.ShowDialog();
        }

        private void MenuTimbrado_Click(object sender, EventArgs e)
        {
            Timbrado frm_timbrado = new Timbrado();

            frm_timbrado.ShowDialog();
        }

        private void grupoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrupoDocumento frm_grupoDocumento = new GrupoDocumento();

            frm_grupoDocumento.ShowDialog();
        }
    }
}