using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Usuarios_Ok
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            MostrarUsuarios();
            LeerTextRol();
        }

        private void MostrarUsuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Conexion.ConexionMaestra.conexion;
                conn.Open();
                da = new SqlDataAdapter("sp_usuario_mostrarV2", conn);
                da.Fill(dt);
                DataGridViewUsuarios.DataSource = dt;

                conn.Close();
                OcultarColumnas();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void OcultarColumnas()
        {
            DataGridViewUsuarios.Columns[1].Visible = false;
        }

        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_usuario_buscarV2", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TextBoxBusquedaUsuario.Text);
                da.Fill(dt);
                DataGridViewUsuarios.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeerTextRol()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("SELECT nombre FROM DBO.ROL", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sRol = dr.GetString("nombre");
                ComboBoxRol.Items.Add(sRol);
            }
            con.Close();

        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            PanelBusquedaUsuario.Hide();
            PanelBuscarEmpleado.Show();
            BtnGuardarEditado.Hide();
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                e.Cancel = true;
                TxtRePassword.Focus();
                errorProvider.SetError(TxtPassword, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(TxtPassword, "");
            }
        }

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("dbo.sp_empleado_buscarV2", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TextBoxBuscarEmpleado.Text);
                da.Fill(dt);
                AgregarNuevo.Visible = true;
                DataGridViewEmpleados.DataSource = dt;
                con.Close();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("El empleado buscado no se encuentra activo, verifique.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAgregarNuevo_Click(object sender, EventArgs e)
        {
            {
                string password = TxtPassword.Text;
                string repassword = TxtRePassword.Text;
                string nombres = string.Empty;
                string apellidos = string.Empty;
                string cedula = string.Empty;
                string login = string.Empty;

                if(DataGridViewEmpleados.Rows.Count == 0)
                {
                    MessageBox.Show("Busque al menos un empleado para continuar.");
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in DataGridViewEmpleados.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        {
                            nombres = row.Cells[1].Value.ToString();
                            apellidos = row.Cells[2].Value.ToString();
                            cedula = row.Cells[3].Value.ToString();
                            login = row.Cells[4].Value.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un empleado");
                            return;
                        }

                    }

                    if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repassword))
                    {
                        MessageBox.Show("Por favor, ingresa la contraseña.");
                        return;
                    }

                    if (password != repassword)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.");
                        TxtRePassword.Focus();
                        return;
                    }
                    else
                    {
                        if (ComboBoxRol.SelectedIndex >= 0)
                        {
                            try
                            {
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                                con.Open();
                                SqlCommand cmd = new SqlCommand();
                                cmd = new SqlCommand("dbo.sp_usuario_insertarV2", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@nombres", nombres);
                                cmd.Parameters.AddWithValue("@apellidos", apellidos);
                                cmd.Parameters.AddWithValue("@cedula", cedula);
                                cmd.Parameters.AddWithValue("@login", login);
                                cmd.Parameters.AddWithValue("@password", password);
                                cmd.Parameters.AddWithValue("@Rol", ComboBoxRol.Text.ToString());
                                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                                if (CheckActivo.Checked)
                                    cmd.Parameters.AddWithValue("@Activo", 1);
                                else
                                    cmd.Parameters.AddWithValue("@Activo", 0);

                                cmd.ExecuteNonQuery();
                                con.Close();
                                PanelBuscarEmpleado.Hide();
                                PanelBusquedaUsuario.Show();
                                MostrarUsuarios();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }

                        }
                        else
                            MessageBox.Show("Elegir un rol");
                    }
                }
            }
        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            PanelBuscarEmpleado.Hide();
            PanelBusquedaUsuario.Show();
            BtnAgregarUsuario.Show();
        }

        private void EditarUsuario(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.DataGridViewUsuarios.Columns["EditarU"].Index)
            {
                PanelBuscarEmpleado.Show();
                PanelBusquedaUsuario.Hide();
                TextBoxBuscarEmpleado.Hide();
                DataGridViewEmpleados.Hide();
                BtnAgregarNuevo.Hide();
                BtnAgregarUsuario.Hide();
                LabelBuscarEmpleado.Hide();
                BtnGuardarEditado.Show();
                BtnBuscarEmpleado.Hide();
                LabelEditarUsuario.Show();
                TxtUsuarioEditando.Show();
                TxtUsuarioEditando.ReadOnly = true;
                TxtUsuarioEditando.Text = DataGridViewUsuarios.SelectedCells[4].Value.ToString();
            }
        }

        private void BtnGuardarEditado_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(DataGridViewUsuarios.SelectedCells[1].Value);
            string password = TxtPassword.Text;
            string repassword = TxtRePassword.Text;
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repassword))
            {
                MessageBox.Show("Por favor, ingresa la contraseña.");
                return;
            }

            else if (password != repassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                TxtRePassword.Focus();
                return;
            }

            else if(ComboBoxRol.SelectedIndex == -1)
            {
                MessageBox.Show("Elija un Rol");
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                    con.Open();

                    da = new SqlDataAdapter("dbo.sp_usuario_editarV2", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                    da.SelectCommand.Parameters.AddWithValue("@password", TxtPassword.Text);
                    da.SelectCommand.Parameters.AddWithValue("@rol", ComboBoxRol.Text);
                    if (CheckActivo.Checked)
                    {
                        da.SelectCommand.Parameters.AddWithValue("@activo", 1);
                    }
                    else
                        da.SelectCommand.Parameters.AddWithValue("@activo", 0);
                    da.Fill(dt);
                    AgregarNuevo.Visible = true;
                    DataGridViewEmpleados.DataSource = dt;
                    con.Close();
                    PanelBusquedaUsuario.Show();
                    MostrarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}