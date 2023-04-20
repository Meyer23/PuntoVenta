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
    public partial class Cajas : Form
    {
        int idCaja;
        bool estadoCaja;
        public Cajas()
        {
            InitializeComponent();
        }

        Sucursal suc = new Sucursal();

        private void Cajas_Load(object sender, EventArgs e)
        {
            TxtSucursal.DataSource = suc.cargarComboSucursal();
            TxtSucursal.DisplayMember = "Descripcion";
            TxtSucursal.ValueMember = "idSucursal";
            mostrarCajas();
        }

        private void mostrarCajas()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_caja_mostrar", con);
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
                estadoCaja = (bool)row.Cells["Activo"].Value;
                if (estadoCaja == false)
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
            TxtSucursal.Focus();
            TxtSucursal.Enabled = true;
            TxtNroCaja.ReadOnly = false;
            checkBoxActivo.Checked = true;
            limpiar();
        }

        private void limpiar()
        {
            TxtNroCaja.Clear();
            TxtDescripcion.Clear();
            BtnGuardar.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtSucursal.Text != "" && TxtNroCaja.Text != "" && TxtDescripcion.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("sp_caja_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Sucursal", Convert.ToInt32(TxtSucursal.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@NroCaja", Convert.ToInt32(TxtNroCaja.Text));
                    cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
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
                    mostrarCajas();
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

        private void BuscarCaja(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_caja_buscar", con);
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

        private void EditarCaja(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                TxtSucursal.Enabled = false;
                TxtNroCaja.ReadOnly = true;
                ObtenerDatosCaja();
            }
        }

        private void EditarCaja2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            TxtSucursal.Enabled = false;
            TxtNroCaja.ReadOnly = true;
            ObtenerDatosCaja();
        }

        private void ObtenerDatosCaja()
        {
            try
            {
                idCaja = Convert.ToInt32(datalistado.SelectedCells[1].Value.ToString());
                TxtSucursal.Text = datalistado.SelectedCells[2].Selected.ToString();
                TxtNroCaja.Text = datalistado.SelectedCells[3].Value.ToString();
                TxtDescripcion.Text = datalistado.SelectedCells[4].Value.ToString();
                estadoCaja = (bool)datalistado.SelectedCells[5].Value;
                if (estadoCaja == true)
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
            if (TxtSucursal.Text != "" && TxtNroCaja.Text != "" && TxtDescripcion.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("sp_caja_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCaja", idCaja);
                    cmd.Parameters.AddWithValue("@Sucursal", Convert.ToInt32(TxtSucursal.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@NroCaja", Convert.ToInt32(TxtNroCaja.Text));
                    cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
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
                    mostrarCajas();
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

        private void TxtSucursal_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtSucursal.Text))
            {
                e.Cancel = true;
                TxtSucursal.Focus();
                errorProvider1.SetError(TxtSucursal, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtSucursal, "");
            }
        }

        private void TxtNroCaja_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtNroCaja.Text))
            {
                e.Cancel = true;
                TxtNroCaja.Focus();
                errorProvider1.SetError(TxtNroCaja, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNroCaja, "");
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
    }
}
