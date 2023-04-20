using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Caja
{
    public partial class Sucursal : Form
    {
        bool estadoSucursal;
        int idSucursal;
        public Sucursal()
        {
            InitializeComponent();
        }

        private void Sucursal_Load(object sender, EventArgs e)
        {
            mostrarSucursales();
        }

        private void mostrarSucursales()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_sucursal_mostrar", con);
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
                estadoSucursal = (bool)row.Cells["Activo"].Value;
                if (estadoSucursal == false)
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void ocultar_columnas()
        {
            datalistado.Columns[1].Visible = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            BtnGuardarCambios.Visible = false;
            TxtCodigo.Focus();
            TxtCodigo.ReadOnly = false;
            checkBoxActivo.Checked = true;
            limpiar();
        }

        private void limpiar()
        {
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            TxtDireccion.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            BtnGuardar.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtDescripcion.Text != "")
            {

                if (TxtDireccion.Text == "")
                {
                    TxtDireccion.Text = "Paraguay";
                }
                if (TxtTelefono.Text == "")
                {
                    TxtTelefono.Text = "0";
                }
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("sp_sucursal_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", TxtCodigo.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
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
                    mostrarSucursales();
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        private void BuscarSucursal(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_sucursal_buscar", con);
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

        private void EditarSucursal(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                TxtCodigo.ReadOnly = true;
                ObtenerDatosEmpleado();
            }
        }

        private void EditarSucursal2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            TxtCodigo.ReadOnly = true;
            ObtenerDatosEmpleado();
        }

        private void ObtenerDatosEmpleado()
        {
            try
            {
                idSucursal = Convert.ToInt32(datalistado.SelectedCells[1].Value.ToString());
                TxtCodigo.Text = datalistado.SelectedCells[2].Value.ToString();
                TxtDescripcion.Text = datalistado.SelectedCells[3].Value.ToString();
                TxtDireccion.Text = datalistado.SelectedCells[4].Value.ToString();
                TxtTelefono.Text = datalistado.SelectedCells[5].Value.ToString();
                estadoSucursal = (bool)datalistado.SelectedCells[6].Value;
                if (estadoSucursal == true)
                {
                    checkBoxActivo.Checked = true;
                }
                else
                {
                    checkBoxActivo.Checked = false;
                }

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

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtDescripcion.Text != "")
            {

                if (TxtDireccion.Text == "")
                {
                    TxtDireccion.Text = "Paraguay";
                }
                if (TxtTelefono.Text == "")
                {
                    TxtTelefono.Text = "0";
                }
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("sp_sucursal_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    cmd.Parameters.AddWithValue("@Codigo", TxtCodigo.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
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
                    mostrarSucursales();
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

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                e.Cancel = true;
                TxtCodigo.Focus();
                errorProvider1.SetError(TxtCodigo, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtCodigo, "");
            }
        }

        private void TxtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtDescripcion.Text))
            {
                e.Cancel = true;
                TxtDescripcion.Focus();
                errorProvider1.SetError(TxtDescripcion, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtDescripcion, "");
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
