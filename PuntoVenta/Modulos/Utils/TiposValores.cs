using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Utils
{
    public partial class TiposValores : Form
    {

        int idValor;
        bool estadoValor;
        bool validaDoc;
        public TiposValores()
        {
            InitializeComponent();
        }

        public DataTable cargarComboUnidadesMedidas()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_valor_cargar", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        private void TiposValores_Load(object sender, EventArgs e)
        {
            mostrarValores();
        }

        private void mostrarValores()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_valor_mostrar", con);
                da.Fill(dt);
                datalistadoMedidas.DataSource = dt;
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
            foreach (DataGridViewRow row in datalistadoMedidas.Rows)
            {
                estadoValor = (bool)row.Cells["Activo"].Value;
                if (estadoValor == false)
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void ocultar_columnas()
        {
            datalistadoMedidas.Columns[1].Visible = false;
            datalistadoMedidas.Columns[3].Visible = false;
        }

        private void BuscarValor(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_valor_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBusqueda.Text);
                da.Fill(dt);
                datalistadoMedidas.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditarValor(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoMedidas.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                TxtDescripcion.ReadOnly = true;
                ObtenerDatosValores();
            }
        }       

        private void EditarValor2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            TxtDescripcion.ReadOnly = true;
            ObtenerDatosValores();
        }

        private void ObtenerDatosValores()
        {
            try
            {
                idValor = Convert.ToInt32(datalistadoMedidas.SelectedCells[1].Value.ToString());
                TxtDescripcion.Text = datalistadoMedidas.SelectedCells[2].Value.ToString();
                validaDoc = (bool)datalistadoMedidas.SelectedCells[3].Value;
                if (validaDoc == true)
                {
                    checkBoxDoc.Checked = true;
                }
                else
                {
                    checkBoxDoc.Checked = false;
                }
                estadoValor = (bool)datalistadoMedidas.SelectedCells[4].Value;
                if (estadoValor == true)
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
            TxtDescripcion.Focus();
            TxtDescripcion.ReadOnly = false;
            checkBoxActivo.Checked = true;
            limpiar();
        }

        private void limpiar()
        {
            TxtDescripcion.Clear();
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
                if (TxtDescripcion.Text != "")
                {

                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_valor_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        if (checkBoxDoc.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@ValidaDoc", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ValidaDoc", 0);
                        }
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
                        mostrarValores();
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
                if (TxtDescripcion.Text != "")
                { 

                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_valor_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idValor", idValor);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        if (checkBoxDoc.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@ValidaDoc", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ValidaDoc", 0);
                        }
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
                        mostrarValores();
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
