using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace PuntoVenta.Modulos.Compras
{
    public partial class Proveedores : Form
    {
        int idProveedor;
        bool estadoProveedor;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            mostrarProveedores();
        }

        private void mostrarProveedores()
        {
            try
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
            foreach (DataGridViewRow row in datalistado.Rows)
            {
                estadoProveedor = (bool)row.Cells["Activo"].Value;
                if (estadoProveedor == false)
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void ocultar_columnas()
        {
            datalistado.Columns[1].Visible = false;
            datalistado.Columns[4].Visible = false;
            datalistado.Columns[7].Visible = false;
            datalistado.Columns[8].Visible = false;
            datalistado.Columns[10].Visible = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            BtnGuardarCambios.Visible = false;
            TxtRazonSocial.Focus();
            TxtRazonSocial.ReadOnly = false;
            TxtRuc.ReadOnly = false;
            checkBoxActivo.Checked = true;
            limpiar();
        }

        private void limpiar()
        {
            TxtContacto.Clear();
            TxtRazonSocial.Clear();
            TxtRuc.Clear();
            TxtDireccion.Clear();
            TxtTelefono1.Clear();
            TxtTelefono2.Clear();
            TxtCorreo.Clear();
            TxtContacto.Clear();
            BtnGuardar.Visible = true;
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
                if (TxtRazonSocial.Text != "" && TxtRuc.Text != "")
                {

                    if (TxtDireccion.Text == "")
                    {
                        TxtDireccion.Text = "Paraguay";
                    }
                    if (TxtTelefono1.Text == "")
                    {
                        TxtTelefono1.Text = "0";
                    }
                    if (TxtTelefono2.Text == "")
                    {
                        TxtTelefono2.Text = "0";
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
                        cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSocial.Text);
                        cmd.Parameters.AddWithValue("@Ruc", TxtRuc.Text);
                        cmd.Parameters.AddWithValue("@Contacto", TxtContacto.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono1", TxtTelefono1.Text);
                        cmd.Parameters.AddWithValue("@Telefono2", TxtTelefono2.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
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
                        mostrarProveedores();
                        PanelRegistro.Visible = false;
                        TxtBusqueda.Visible = true;
                        menuStrip1.Visible = true;
                        BtnNuevo.Visible = true;
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
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        
        
        private void BuscarProveedor(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_proveedor_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBusqueda.Text);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_eliminados();
        }       

        private void EditarProveedor(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                TxtRazonSocial.ReadOnly = true;
                TxtRuc.ReadOnly = true;
                ObtenerDatosProveedor();
            }
        }

        private void EditarProveedor2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            TxtRazonSocial.ReadOnly = true;
            TxtRuc.ReadOnly = true;
            ObtenerDatosProveedor();
        }

        private void ObtenerDatosProveedor()
        {
            try
            {              
                idProveedor = Convert.ToInt32(datalistado.SelectedCells[1].Value.ToString());
                TxtRazonSocial.Text = datalistado.SelectedCells[2].Value.ToString();
                TxtRuc.Text = datalistado.SelectedCells[3].Value.ToString();
                TxtContacto.Text = datalistado.SelectedCells[4].Value.ToString();
                TxtDireccion.Text = datalistado.SelectedCells[5].Value.ToString();
                TxtTelefono1.Text = datalistado.SelectedCells[6].Value.ToString();
                TxtTelefono2.Text = datalistado.SelectedCells[7].Value.ToString();
                TxtCorreo.Text = datalistado.SelectedCells[8].Value.ToString();
               
                TxtBusqueda.Visible = false;
                menuStrip1.Visible = false;
                BtnNuevo.Visible = false;
                PanelRegistro.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com, " + " por favor, seleccione un correo válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                if (TxtContacto.Text != "" && TxtRuc.Text != "")
                {

                    if (TxtDireccion.Text == "")
                    {
                        TxtDireccion.Text = "Paraguay";
                    }
                    if (TxtTelefono1.Text == "")
                    {
                        TxtTelefono1.Text = "0";
                    }
                    if (TxtTelefono2.Text == "")
                    {
                        TxtTelefono2.Text = "0";
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
                        cmd = new SqlCommand("sp_proveedor_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSocial.Text);
                        cmd.Parameters.AddWithValue("@Ruc", TxtRuc.Text);
                        cmd.Parameters.AddWithValue("@Contacto", TxtContacto.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono1", TxtTelefono1.Text);
                        cmd.Parameters.AddWithValue("@Telefono2", TxtTelefono2.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        if (checkBoxActivo.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Activo", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Activo", 0);
                        }
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarProveedores();
                        PanelRegistro.Visible = false;
                        TxtBusqueda.Visible = true;
                        menuStrip1.Visible = true;
                        BtnNuevo.Visible = true;
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

        private void TxtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtRazonSocial.Text))
            {
                e.Cancel = true;
                TxtRazonSocial.Focus();
                errorProvider1.SetError(TxtRazonSocial, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtRazonSocial, "");
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

        private void TxtTelefono1_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtTelefono1.Text))
            {
                e.Cancel = true;
                TxtTelefono1.Focus();
                errorProvider1.SetError(TxtTelefono1, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtTelefono1, "");
            }
        }
    }
}
