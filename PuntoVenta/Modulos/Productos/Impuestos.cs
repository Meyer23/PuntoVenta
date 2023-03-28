using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Productos
{
    public partial class Impuestos : Form
    {
        int idImpuesto;
        bool estadoImpuesto;
        public Impuestos()
        {
            InitializeComponent();
        }

        public DataTable cargarComboImpuestos()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_impuesto_cargar", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        private void Impuestos_Load(object sender, EventArgs e)
        {
            mostrarImpuestos();
        }

        private void mostrarImpuestos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_impuesto_mostrar", con);
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
                estadoImpuesto = (bool)row.Cells["Activo"].Value;
                if (estadoImpuesto == false)
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
            datalistado.Columns[5].Visible = false;
            datalistado.Columns[6].Visible = false;
        }

        private void BuscarImpuesto(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_impuesto_buscar", con);
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

        private void EditarImpuesto(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                TxtImpuesto.ReadOnly = true;
                ObtenerDatosImpuestos();
            }
        }

        private void EditarImpuesto2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            TxtImpuesto.ReadOnly = true;
            ObtenerDatosImpuestos();
        }

        private void ObtenerDatosImpuestos()
        {
            try
            {
                idImpuesto = Convert.ToInt32(datalistado.SelectedCells[1].Value.ToString());
                TxtImpuesto.Text = datalistado.SelectedCells[2].Value.ToString();
                TxtDescripcion.Text = datalistado.SelectedCells[3].Value.ToString();
                TxtPorcIva.Text = datalistado.SelectedCells[4].Value.ToString();
                TxtFactGrav.Text = datalistado.SelectedCells[5].Value.ToString();
                TxtFactIva.Text = datalistado.SelectedCells[6].Value.ToString();
                estadoImpuesto = (bool)datalistado.SelectedCells[7].Value;
                if (estadoImpuesto == true)
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            BtnGuardarCambios.Visible = false;
            TxtImpuesto.Focus();
            TxtImpuesto.ReadOnly = false;
            checkBoxActivo.Checked = true;
            limpiar();
        }

        private void limpiar()
        {
            TxtImpuesto.Clear();
            TxtDescripcion.Clear();
            TxtPorcIva.Clear();
            TxtFactGrav.Clear();
            TxtFactIva.Clear();
            BtnGuardar.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtImpuesto.Text != "")
                {

                    if (TxtDescripcion.Text == "")
                    {
                        TxtDescripcion.Text = "Impuesto " + TxtDescripcion.Text;
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_impuesto_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TipoImpuesto", Convert.ToInt32(TxtImpuesto.Text));
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@PorcIva", Convert.ToDecimal(TxtPorcIva.Text));
                        cmd.Parameters.AddWithValue("@FactorGravada", Convert.ToDecimal(TxtFactGrav.Text));
                        cmd.Parameters.AddWithValue("@FactorIva", Convert.ToDecimal(TxtFactIva.Text));
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
                        mostrarImpuestos();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtImpuesto.Text != "")
                {

                    if (TxtDescripcion.Text == "")
                    {
                        TxtDescripcion.Text = "Impuesto " + TxtDescripcion.Text;
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_impuesto_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idImpuesto", idImpuesto);
                        cmd.Parameters.AddWithValue("@TipoImpuesto", Convert.ToInt32(TxtImpuesto.Text));
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@PorcIva", Convert.ToDecimal(TxtPorcIva.Text));
                        cmd.Parameters.AddWithValue("@FactorGravada", Convert.ToDecimal(TxtFactGrav.Text));
                        cmd.Parameters.AddWithValue("@FactorIva", Convert.ToDecimal(TxtFactIva.Text));
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
                        mostrarImpuestos();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtImpuesto_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtImpuesto.Text))
            {
                e.Cancel = true;
                TxtImpuesto.Focus();
                errorProvider1.SetError(TxtImpuesto, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtImpuesto, "");
            }
        }
    }

    
}
