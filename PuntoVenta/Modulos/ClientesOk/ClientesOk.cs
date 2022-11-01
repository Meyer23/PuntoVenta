using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.ClientesOk
{
    public partial class ClientesOk : Form
    {
        public ClientesOk()
        {
            InitializeComponent();
            MostrarClientes();
        }

        private void Btn_NuevoCliente(object sender, EventArgs e)
        {
            PanelCliente.Hide();
            PanelNuevoCliente.Show();
            DataGridViewClientes.Hide();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com, " + " por favor, seleccione un correo válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {



                if (TxtNombresCliente.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("dbo.sp_clientes_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombresCliente.Text);
                        cmd.Parameters.AddWithValue("@RUC_CI", TxtRuc.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);

                        cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Celular", TxtCelular.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();

                        cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                        cmd.Parameters.AddWithValue("@Saldo", 0);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        PanelNuevoCliente.Hide();
                        PanelCliente.Show();
                        DataGridViewClientes.Show();
                        MostrarClientes();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
        }

        public bool ValidarCorreo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");

        }

        private void MostrarClientes()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("dbo.sp_clientes_mostrar", con);




                da.Fill(dt);
                DataGridViewClientes.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelCliente.Show();
            PanelNuevoCliente.Hide();
            DataGridViewClientes.Show();
            MostrarClientes();
            limpiar();
        }

        private void limpiar()
        {
            TxtNombresCliente.Clear();
            TxtRuc.Clear();
            TxtCorreo.Clear();
            TxtRuc.Clear();
            TxtCelular.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            BtnGuardarCliente.Visible = true;
        }
    }
}