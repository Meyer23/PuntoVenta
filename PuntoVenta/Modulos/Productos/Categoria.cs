using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System;

namespace PuntoVenta.Modulos.Productos
{
    public partial class Categoria : Form
    {
        int idCategoria;
        bool estadoCategoria;
        public Categoria()
        {
            InitializeComponent();
        }

        public DataTable cargarComboCategorias()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_categoria_cargar", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
        }

        private void mostrarCategorias()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_categoria_mostrar", con);
                da.Fill(dt);
                datalistadoCategorias.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_eliminados();
        }

        private void ocultar_columnas()
        {
            datalistadoCategorias.Columns[1].Visible = false;
            datalistadoCategorias.Columns[3].Visible = false;
            datalistadoCategorias.Columns[4].Visible = false;
        }

        private void BuscarCategoria(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_categoria_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBusqueda.Text);
                da.Fill(dt);
                datalistadoCategorias.DataSource = dt;
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
            try
            {
                foreach (DataGridViewRow row in datalistadoCategorias.Rows)
                {
                    estadoCategoria = (bool)row.Cells["Activo"].Value;
                    if (estadoCategoria == false)
                    {
                        row.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            
           
        }

        private void EditarCategoria(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoCategorias.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                TxtNombre.ReadOnly = true;
                ObtenerDatosCategorias();
            }
        }

        private void EditarCategoria2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            TxtNombre.ReadOnly = true;
            ObtenerDatosCategorias();
        }

        private void ObtenerDatosCategorias()
        {
            try
            {
                idCategoria = Convert.ToInt32(datalistadoCategorias.SelectedCells[1].Value.ToString());
                TxtNombre.Text = datalistadoCategorias.SelectedCells[2].Value.ToString();
                TxtDescripcion.Text = datalistadoCategorias.SelectedCells[3].Value.ToString();
                TxtPorcUtilidad.Text = datalistadoCategorias.SelectedCells[4].Value.ToString();
                estadoCategoria = (bool)datalistadoCategorias.SelectedCells[5].Value;
                if (estadoCategoria == true)
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

        private void CrearCategoria(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            BtnGuardarCambios.Visible = false;
            TxtNombre.Focus();
            TxtNombre.ReadOnly = false;
            checkBoxActivo.Checked = true;
            limpiar();
        }

        private void limpiar()
        {
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtPorcUtilidad.Clear();
            BtnGuardar.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        private void GuardarCategoria(object sender, EventArgs e)
        {
            try
            {
                if (TxtNombre.Text != "")
                {

                    if (TxtDescripcion.Text == "")
                    {
                        TxtDescripcion.Text = "Categoria " + TxtNombre.Text;
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_categoria_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@PorcUtilidad", Convert.ToDecimal(TxtPorcUtilidad.Text));
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
                        mostrarCategorias();
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
                if (TxtNombre.Text != "")
                {
                    if (TxtDescripcion.Text == "")
                    {
                        TxtDescripcion.Text = "Categoria " + TxtNombre.Text;
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_categoria_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@PorcUtilidad", Convert.ToDecimal(TxtPorcUtilidad.Text));
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
                        mostrarCategorias();
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

        private void TxtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                e.Cancel = true;
                TxtNombre.Focus();
                errorProvider1.SetError(TxtNombre, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNombre, "");
            }
        }

        private void GenerarPrecios(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("sp_categoria_generar_precios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                cmd.Parameters.AddWithValue("@PorcUtilidad", Convert.ToDecimal(TxtPorcUtilidad.Text));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}