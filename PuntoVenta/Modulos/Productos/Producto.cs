using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PuntoVenta.Modulos.Productos;

namespace PuntoVenta.Modulos.Productos 
{
    public partial class Producto : Form
    {
        int idProducto;
        string estadoProducto;
        public Producto()
        {
            InitializeComponent();
        }

        Categoria cat = new Categoria();
        UnidadesMedidas uni = new UnidadesMedidas();

        private void Productos_Load(object sender, EventArgs e)
        {
            TxtCategoria.DataSource = cat.cargarComboCategorias();
            TxtUMedida.DataSource = uni.cargarComboUnidadesMedidas();
            TxtCategoria.DisplayMember = "Nombre";
            TxtCategoria.ValueMember = "idCategoria";
            TxtUMedida.DisplayMember = "Abreviacion";
            TxtUMedida.ValueMember = "idUMedida";
            mostrarProductos();
        }

        private void CrearProducto(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            BtnGuardarCambios.Visible = false;
            limpiar();
        }

        private void limpiar()
        {
            TxtCodigoBarras.Clear();
            TxtDescripcion.Clear();
            TxtCosto.Clear();
            TxtPrecio.Clear();
            TxtPrecioMayorista.Clear();
            TxtPorcUtilidad.Clear();
            //TxtImpuesto.Items.Clear();
            //TxtExistencia.Clear();
            //TxtCategoria.Items.Clear();
            //TxtUMedida.Items.Clear();
            BtnGuardar.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        private void GuardarProducto(object sender, EventArgs e)
        {
            try
            {
                if (TxtDescripcion.Text != "")
                {

                    if (TxtCodigoBarras.Text == "")
                    {
                        TxtCodigoBarras.Text = "0";
                    }
                    if (TxtCosto.Text == "")
                    {
                        TxtCosto.Text = "0";
                    }
                    if (TxtPrecio.Text == "")
                    {
                        TxtPrecio.Text = "0";
                    }
                    if (TxtPrecioMayorista.Text == "")
                    {
                        TxtPrecioMayorista.Text = "0";
                    }
                    if (TxtPorcUtilidad.Text == "")
                    {
                        TxtPorcUtilidad.Text = "0";
                    }
                    if (TxtExistenciaMinima.Text == "")
                    {
                        TxtExistenciaMinima.Text = "0";
                    }
                    if (TxtCantMayorista.Text == "")
                    {
                        TxtCantMayorista.Text = "0";
                    }
                    if (CheckAdmInv.Text == "")
                    {
                        CheckAdmInv.Text = "0";
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_producto_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;                       
                        cmd.Parameters.AddWithValue("@Codigo", TxtCodigoBarras.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Costo", Convert.ToInt32(TxtCosto.Text));
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToInt32(TxtPrecio.Text));
                        cmd.Parameters.AddWithValue("@PrecioMayorista", Convert.ToInt32(TxtPrecioMayorista.Text));
                        cmd.Parameters.AddWithValue("@PorcUtilidad", Convert.ToInt32(TxtPorcUtilidad.Text));
                        cmd.Parameters.AddWithValue("@AdministraInventario", Convert.ToInt32(CheckAdmInv.CheckState));
                        cmd.Parameters.AddWithValue("@Existencia", 0);
                        cmd.Parameters.AddWithValue("@ExistenciaMinima", Convert.ToInt32(TxtExistenciaMinima.Text));
                        cmd.Parameters.AddWithValue("@Impuesto", Convert.ToInt32(TxtImpuesto.Text));
                        cmd.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(TxtCategoria.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@idUMedida", Convert.ToInt32(TxtUMedida.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                        cmd.Parameters.AddWithValue("@CantidadMayorista", Convert.ToInt32(TxtCantMayorista.Text));

                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarProductos();
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

        private void mostrarProductos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_producto_mostrar", con);
                da.Fill(dt);
                datalistadoProductos.DataSource = dt;
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
            foreach (DataGridViewRow row in datalistadoProductos.Rows)
            {
                if (row.Cells["Estado"].Value.ToString() == "ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Strikeout);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void ocultar_columnas()
        {
            datalistadoProductos.Columns[2].Visible = false;
        }

        private void BuscarProducto(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_producto_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBusqueda.Text);
                da.Fill(dt);
                datalistadoProductos.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_eliminados();
        }

        private void EliminarProducto(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoProductos.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Está seguro de eliminar este producto del sistema?", "Eliminando registro...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in datalistadoProductos.SelectedRows)
                        {
                            int onekey = Convert.ToInt32(row.Cells["idProducto"].Value);

                            try
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("sp_producto_eliminar", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@idProducto", onekey);
                                    cmd.ExecuteNonQuery();

                                    con.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                        }
                        mostrarProductos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void EditarProducto(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoProductos.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                ObtenerDatosProductos();
            }
        }

        private void EditarProducto2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            ObtenerDatosProductos();
        }

        private void ObtenerDatosProductos()
        {
            try
            {
                estadoProducto = datalistadoProductos.SelectedCells[16].Value.ToString();
                if (estadoProducto == "ELIMINADO")
                {
                    restaurarProducto();
                }
                else
                {
                    idProducto = Convert.ToInt32(datalistadoProductos.SelectedCells[2].Value.ToString());
                    TxtCodigoBarras.Text = datalistadoProductos.SelectedCells[3].Value.ToString();
                    TxtDescripcion.Text = datalistadoProductos.SelectedCells[4].Value.ToString();
                    TxtCosto.Text = datalistadoProductos.SelectedCells[5].Value.ToString();
                    TxtPrecio.Text = datalistadoProductos.SelectedCells[6].Value.ToString();
                    TxtPrecioMayorista.Text = datalistadoProductos.SelectedCells[7].Value.ToString();
                    TxtPorcUtilidad.Text = datalistadoProductos.SelectedCells[8].Value.ToString();
                    CheckAdmInv.Text = datalistadoProductos.SelectedCells[9].Value.ToString();
                    TxtExistencia.Text = datalistadoProductos.SelectedCells[10].Value.ToString();
                    TxtExistenciaMinima.Text = datalistadoProductos.SelectedCells[11].Value.ToString();
                    TxtImpuesto.Text = datalistadoProductos.SelectedCells[12].Value.ToString();                   
                    TxtCategoria.Text = datalistadoProductos.SelectedCells[13].Value.ToString();
                    TxtUMedida.Text = datalistadoProductos.SelectedCells[14].Value.ToString();
                    TxtCantMayorista.Text = datalistadoProductos.SelectedCells[15].Value.ToString();

                    TxtBusqueda.Visible = false;
                    menuStrip1.Visible = false;
                    BtnNuevo.Visible = false;
                    PanelRegistro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void restaurarProducto()
        {
            DialogResult result;
            result = MessageBox.Show("Este producto se encuentra eliminado, ¿Desea volver a Habilitarlo?", "Restauración de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datalistadoProductos.SelectedRows)
                {
                    int idProveedor = Convert.ToInt32(row.Cells["idProducto"].Value);
                    try
                    {
                        SqlCommand cmd;
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        cmd = new SqlCommand("sp_producto_restaurar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    mostrarProductos();
                }
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtDescripcion.Text != "")
                {

                    if (TxtCodigoBarras.Text == "")
                    {
                        TxtCodigoBarras.Text = "0";
                    }
                    if (TxtCosto.Text == "")
                    {
                        TxtCosto.Text = "0";
                    }
                    if (TxtPrecio.Text == "")
                    {
                        TxtPrecio.Text = "0";
                    }
                    if (TxtPrecioMayorista.Text == "")
                    {
                        TxtPrecioMayorista.Text = "0";
                    }
                    if (TxtPorcUtilidad.Text == "")
                    {
                        TxtPorcUtilidad.Text = "0";
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_producto_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);
                        cmd.Parameters.AddWithValue("@Codigo", TxtCodigoBarras.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Costo", Convert.ToInt32(TxtCosto.Text));
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(TxtPrecio.Text));
                        cmd.Parameters.AddWithValue("@PrecioMayorista", Convert.ToDecimal(TxtPrecioMayorista.Text));
                        cmd.Parameters.AddWithValue("@PorcUtilidad", Convert.ToInt32(TxtPorcUtilidad.Text));
                        cmd.Parameters.AddWithValue("@AdministraInventario", Convert.ToInt32(CheckAdmInv.CheckState));
                        cmd.Parameters.AddWithValue("@ExistenciaMinima", Convert.ToInt32(TxtExistenciaMinima.Text));
                        cmd.Parameters.AddWithValue("@Impuesto", Convert.ToInt32(TxtImpuesto.Text));
                        cmd.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(TxtCategoria.Text));
                        cmd.Parameters.AddWithValue("@idUMedida", Convert.ToInt32(TxtUMedida.Text));
                        cmd.Parameters.AddWithValue("@CantidadMayorista", Convert.ToInt32(TxtCantMayorista.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarProductos();
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

        private void CrearCategoria(object sender, EventArgs e)
        {
            Categoria frm_categorias = new Categoria();

            frm_categorias.ShowDialog();
        }

        private void CrearUMedida(object sender, EventArgs e)
        {
            UnidadesMedidas frm_umedidas = new UnidadesMedidas();

            frm_umedidas.ShowDialog();
        }

        private void GenerarPrecios(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("sp_producto_generar_precios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
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