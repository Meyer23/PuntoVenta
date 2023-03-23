using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Roles
{
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
            mostrarRoles();
            OcultarColumnas();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            mostrarRoles();
        }

        public DataTable cargarComboRoles()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_roles_cargar", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        private void mostrarRoles()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_roles_mostrar", con);
                da.Fill(dt);
                datalistadoRoles.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscarRol(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_roles_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBusqueda.Text);
                da.Fill(dt);
                datalistadoRoles.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OcultarColumnas()
        {
            datalistadoRoles.Columns[1].Visible = false;
        }

        private void EditarRol(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoRoles.Columns["Editar"].Index)
            {
                PanelEncabezado.Hide();
                datalistadoRoles.Hide();
                PanelRegistro.Show();
                TxtNombre.Hide();
                LblNombre.Hide();
                TxtRolEditando.Text = datalistadoRoles.SelectedCells[2].Value.ToString();
                EditandoNombreRol.Show();
                BtnGuardarCambios.Show();
                BtnGuardar.Hide();
                TxtRolEditando.Show();
                
            }
        }

        private void ObtenerDatosRoles()
        {
            try
            {
                int idRol = Convert.ToInt32(datalistadoRoles.SelectedCells[2].Value.ToString());
                TxtNombre.Text = datalistadoRoles.SelectedCells[3].Value.ToString();


                TxtBusqueda.Visible = false;
                menuStrip1.Visible = false;
                BtnNuevo.Visible = false;
                PanelRegistro.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CrearRol(object sender, EventArgs e)
        {
            PanelEncabezado.Hide();
            datalistadoRoles.Hide();
            PanelRegistro.Show();
            EditandoNombreRol.Hide();
            TxtRolEditando.Hide();
        }

        private void limpiar()
        {
            TxtNombre.Clear();
            BtnGuardar.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Hide();
            PanelEncabezado.Show();
            TxtBusqueda.Show();
            menuStrip1.Show();
            BtnNuevo.Show();
            datalistadoRoles.Show();
        }

        private void GuardarRol(object sender, EventArgs e)
        {
            try
            {
                if (TxtNombre.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_roles_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                        if (CheckRol.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Estado", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@Estado", 0);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarRoles();
                        PanelEncabezado.Show();
                        datalistadoRoles.Show();
                        PanelRegistro.Hide();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            int idRol = Convert.ToInt32(datalistadoRoles.SelectedCells[1].Value);
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("sp_roles_editar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idRol);
                if (CheckRol.Checked)
                {
                    cmd.Parameters.AddWithValue("@Estado", 1);
                }
                else
                    cmd.Parameters.AddWithValue("@Estado", 0);
                cmd.ExecuteNonQuery();
                con.Close();
                mostrarRoles();
                PanelRegistro.Hide();
                TxtBusqueda.Show();
                menuStrip1.Show();
                BtnNuevo.Show();
                datalistadoRoles.Show();

                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
