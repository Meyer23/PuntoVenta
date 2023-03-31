using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PuntoVenta.Modulos
{
    public partial class Clientes : Form
    {
        int idCliente;
        bool estadoCliente;
        public Clientes()
        {
            InitializeComponent();         
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
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
                da = new SqlDataAdapter("sp_clientes_mostrar", con);
                da.Fill(dt);
                DataGridViewClientes.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_eliminados();
        }

        private void cambiar_color_eliminados()
        {
            foreach (DataGridViewRow row in DataGridViewClientes.Rows)
            {
                estadoCliente = (bool)row.Cells["Activo"].Value;
                if (estadoCliente == false)
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void ocultar_columnas()
        {
            DataGridViewClientes.Columns[1].Visible = false;
            DataGridViewClientes.Columns[5].Visible = false;
            DataGridViewClientes.Columns[6].Visible = false;
            DataGridViewClientes.Columns[7].Visible = false;
            DataGridViewClientes.Columns[9].Visible = false;
        }

        private void Btn_NuevoCliente(object sender, EventArgs e)
        {
            PanelCliente.Hide();
            PanelNuevoCliente.Show();
            DataGridViewClientes.Hide();
            TxtNombresCliente.Focus();
            TxtNombresCliente.ReadOnly = false;
            TxtRuc.ReadOnly = false;
            checkBoxActivo.Checked = true;
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
                if (TxtNombresCliente.Text != "" && TxtRuc.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("dbo.sp_clientes_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TipoPersona", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombresCliente.Text);
                        cmd.Parameters.AddWithValue("@RUC_CI", TxtRuc.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Celular", TxtCelular.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        if (checkBoxActivo.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Activo", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Activo", 0);
                        }
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
                else
                {
                   MessageBox.Show("Datos Incompletos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool ValidarCorreo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");
        }      

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelCliente.Show();
            PanelNuevoCliente.Hide();
            DataGridViewClientes.Show();
            MostrarClientes();
            limpiar();
        }
      
        private void BuscarCliente()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("dbo.sp_cliente_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBuscarCliente.Text);
                da.Fill(dt);
                DataGridViewClientes.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_eliminados();
        }

        private void Buscar_Cliente(object sender, EventArgs e)
        {
            BuscarCliente();
        }       

        private void EditarCliente(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.DataGridViewClientes.Columns["Editar"].Index)
            {
                BtnGuardarCliente.Visible = false;
                BtnGuardarEditado.Visible = true;
                TxtNombresCliente.ReadOnly = true;
                TxtRuc.ReadOnly = true;
                ObtenerDatosCliente();
            }
        }

        private void EditarCliente2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardarCliente.Visible = false;
            BtnGuardarEditado.Visible = true;
            TxtNombresCliente.ReadOnly = true;
            TxtRuc.ReadOnly = true;
            ObtenerDatosCliente();
        }

        private void ObtenerDatosCliente()
        {
            try
            {
                idCliente = Convert.ToInt32(DataGridViewClientes.SelectedCells[1].Value.ToString());
                TxtNombresCliente.Text = DataGridViewClientes.SelectedCells[2].Value.ToString();
                TxtRuc.Text = DataGridViewClientes.SelectedCells[3].Value.ToString();
                TxtDireccion.Text = DataGridViewClientes.SelectedCells[4].Value.ToString();
                TxtTelefono.Text = DataGridViewClientes.SelectedCells[5].Value.ToString();
                TxtCelular.Text = DataGridViewClientes.SelectedCells[6].Value.ToString();
                TxtCorreo.Text = DataGridViewClientes.SelectedCells[7].Value.ToString();                
                estadoCliente = (bool)DataGridViewClientes.SelectedCells[8].Value;
                if (estadoCliente == true)
                {
                    checkBoxActivo.Checked = true;
                }
                else
                {
                    checkBoxActivo.Checked = false;
                }
                comboBox1.Text = DataGridViewClientes.SelectedCells[10].Value.ToString();

                PanelCliente.Hide();
                DataGridViewClientes.Hide();
                PanelNuevoCliente.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardar_Editado(object sender, EventArgs e)
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
                        cmd = new SqlCommand("dbo.sp_clientes_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TipoPersona", comboBox1.Text); 
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombresCliente.Text);
                        cmd.Parameters.AddWithValue("@RUC_CI", TxtRuc.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Celular", TxtCelular.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        if (checkBoxActivo.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Activo", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Activo", 0);
                        }
                        //System.IO.MemoryStream ms = new System.IO.MemoryStream();
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
                else
                {
                    MessageBox.Show("Datos Incompletos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void TxtNombresCliente_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtNombresCliente.Text))
            {
                e.Cancel = true;
                TxtNombresCliente.Focus();
                errorProvider1.SetError(TxtNombresCliente, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNombresCliente, "");
            }
        }

        private void TxtRuc_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtRuc.Text))
            {
                e.Cancel = true;
                TxtRuc.Focus();
                errorProvider1.SetError(TxtRuc, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtRuc, "");
            }
        }

        private void TxtDireccion_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtDireccion.Text))
            {
                e.Cancel = true;
                TxtDireccion.Focus();
                errorProvider1.SetError(TxtDireccion, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtDireccion, "");
            }
        }

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtTelefono.Text))
            {
                e.Cancel = true;
                TxtTelefono.Focus();
                errorProvider1.SetError(TxtTelefono, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtTelefono, "");
            }
        }
    }
}