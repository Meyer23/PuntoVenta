using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PuntoVenta.Modulos.Compras
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            TxtNombre.Clear();
            TxtRazonSocial.Clear();
            TxtRuc.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtCelular.Clear();
            TxtCorreo.Clear();
            TxtNombre.Focus();
            BtnGuardar.Visible = true;
            BtnGuardarCambios.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text != "" && TxtRuc.Text != "")
            {

                if (TxtDireccion.Text == "")
                {
                    TxtDireccion.Text = "Paraguay";
                }
                if (TxtTelefono.Text == "")
                {
                    TxtTelefono.Text = "0";
                }
                if (TxtCelular.Text == "")
                {
                    TxtCelular.Text = "0";
                }
                if (TxtCorreo.Text == "")
                {
                    TxtCorreo.Text = "0";
                }
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("sp_proveedor_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                    cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSocial.Text);
                    cmd.Parameters.AddWithValue("@Ruc", TxtRuc.Text);
                    cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Celular", TxtCelular.Text);
                    cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                    cmd.Parameters.AddWithValue("@Saldo", 0);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrar();
                    PanelRegistro.Visible = false;
                    limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Datos Incompletos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureNuevo_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            pictureNuevo.Visible = false;
            TxtNuevo.Visible = false;
            PanelRegistro.Visible = true;
            limpiar();
        }

        private void mostrar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            da = new SqlDataAdapter("sp_proveedor_mostrar", con);
            da.Fill(dt);
            datalistado.DataSource = dt;
            con.Close();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            pictureNuevo.Visible = true;
            TxtNuevo.Visible = true;
        }
    }
}
