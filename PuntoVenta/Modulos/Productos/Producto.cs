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
        bool estadoProducto;
        bool admInv;
        public Producto()
        {
            InitializeComponent();
        }

        Categoria cat = new Categoria();
        UnidadesMedidas uni = new UnidadesMedidas();
        Impuestos imp = new Impuestos();

        private void Productos_Load(object sender, EventArgs e)
        {
            TxtCategoria.DataSource = cat.cargarComboCategorias();
            TxtUMedida.DataSource = uni.cargarComboUnidadesMedidas();
            TxtImpuesto.DataSource = imp.cargarComboImpuestos();
            TxtCategoria.DisplayMember = "Nombre";
            TxtCategoria.ValueMember = "idCategoria";
            TxtUMedida.DisplayMember = "Abreviacion";
            TxtUMedida.ValueMember = "idUMedida";
            TxtImpuesto.DisplayMember = "Descripcion";
            TxtImpuesto.ValueMember = "idImpuesto";
            mostrarProductos();
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
                estadoProducto = (bool)row.Cells["Activo"].Value;
                if (estadoProducto == false)
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Strikeout);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void ocultar_columnas()
        {
            datalistadoProductos.Columns[1].Visible = false;
            datalistadoProductos.Columns[2].Visible = false;
            datalistadoProductos.Columns[4].Visible = false;
            datalistadoProductos.Columns[5].Visible = false;
            datalistadoProductos.Columns[6].Visible = false;
            datalistadoProductos.Columns[7].Visible = false;
            datalistadoProductos.Columns[9].Visible = false;
            datalistadoProductos.Columns[10].Visible = false;
            datalistadoProductos.Columns[11].Visible = false;
            datalistadoProductos.Columns[12].Visible = false;
            datalistadoProductos.Columns[13].Visible = false;
            datalistadoProductos.Columns[15].Visible = false;
            datalistadoProductos.Columns[16].Visible = false;
            datalistadoProductos.Columns[17].Visible = false;
        }

        private void CrearProducto(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            BtnGuardarCambios.Visible = false;
            TxtCodigoBarras.Focus();
            TxtCodigoBarras.ReadOnly = false;
            TxtDescripcion.ReadOnly = false;
            checkBoxActivo.Checked = true;
            limpiar();
        }

        private void limpiar()
        {
            TxtCodigoBarras.Clear();
            TxtDescripcion.Clear();
            TxtCosto.Clear();
            TxtPrecio.Clear();
            TxtPrecioMayorista.Clear();
            TxtCantMayorista.Clear();
            TxtExistenciaMinima.Clear();
            TxtEstante.Clear();
            TxtFila.Clear();
            TxtColumna.Clear();
            //TxtImpuesto.Items.Clear();
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
                        cmd.Parameters.AddWithValue("@Costo", Convert.ToDecimal(TxtCosto.Text));
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(TxtPrecio.Text));
                        cmd.Parameters.AddWithValue("@PrecioMayorista", Convert.ToDecimal(TxtPrecioMayorista.Text));
                        cmd.Parameters.AddWithValue("@AdministraInventario", Convert.ToInt32(CheckAdmInv.CheckState));
                        cmd.Parameters.AddWithValue("@Existencia", 0);
                        cmd.Parameters.AddWithValue("@ExistenciaMinima", Convert.ToDecimal(TxtExistenciaMinima.Text));
                        cmd.Parameters.AddWithValue("@Impuesto", Convert.ToInt32(TxtImpuesto.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(TxtCategoria.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@idUMedida", Convert.ToInt32(TxtUMedida.SelectedValue.ToString()));
                        if (checkBoxActivo.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Activo", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Activo", 0);
                        }
                        cmd.Parameters.AddWithValue("@CantidadMayorista", Convert.ToDecimal(TxtCantMayorista.Text));
                        cmd.Parameters.AddWithValue("@Estante", Convert.ToInt32(TxtEstante.Text));
                        cmd.Parameters.AddWithValue("@Fila", Convert.ToInt32(TxtFila.Text));
                        cmd.Parameters.AddWithValue("@Columna", Convert.ToInt32(TxtColumna.Text));

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
                else
                {
                    MessageBox.Show("Datos Incompletos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void EditarProducto(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistadoProductos.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                TxtCodigoBarras.ReadOnly = true;
                TxtDescripcion.ReadOnly = true;
                ObtenerDatosProductos();
            }
        }

        private void EditarProducto2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            TxtCodigoBarras.ReadOnly = true;
            TxtDescripcion.ReadOnly = true;
            ObtenerDatosProductos();
        }

        private void ObtenerDatosProductos()
        {
            try
            {
                idProducto = Convert.ToInt32(datalistadoProductos.SelectedCells[1].Value.ToString());
                TxtCodigoBarras.Text = datalistadoProductos.SelectedCells[2].Value.ToString();
                TxtDescripcion.Text = datalistadoProductos.SelectedCells[3].Value.ToString();
                TxtCosto.Text = datalistadoProductos.SelectedCells[4].Value.ToString();
                TxtPrecio.Text = datalistadoProductos.SelectedCells[5].Value.ToString();
                TxtPrecioMayorista.Text = datalistadoProductos.SelectedCells[6].Value.ToString();
                admInv = (bool)datalistadoProductos.SelectedCells[7].Value;
                if (admInv == true)
                {
                    CheckAdmInv.Checked = true;
                }
                else
                {
                    CheckAdmInv.Checked = false;
                }
                TxtExistencia.Text = datalistadoProductos.SelectedCells[8].Value.ToString();
                TxtExistenciaMinima.Text = datalistadoProductos.SelectedCells[9].Value.ToString();
                TxtImpuesto.Text = datalistadoProductos.SelectedCells[10].Selected.ToString();                   
                TxtCategoria.Text = datalistadoProductos.SelectedCells[11].Selected.ToString();
                TxtUMedida.Text = datalistadoProductos.SelectedCells[12].Selected.ToString();
                TxtCantMayorista.Text = datalistadoProductos.SelectedCells[13].Value.ToString();
                estadoProducto = (bool)datalistadoProductos.SelectedCells[14].Value;
                if (estadoProducto == true)
                {
                    checkBoxActivo.Checked = true;
                }
                else
                {
                    checkBoxActivo.Checked = false;
                }
                TxtEstante.Text = datalistadoProductos.SelectedCells[15].Value.ToString();
                TxtFila.Text = datalistadoProductos.SelectedCells[16].Value.ToString();
                TxtColumna.Text = datalistadoProductos.SelectedCells[17].Value.ToString();
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
                        cmd.Parameters.AddWithValue("@Costo", Convert.ToDecimal(TxtCosto.Text));
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(TxtPrecio.Text));
                        cmd.Parameters.AddWithValue("@PrecioMayorista", Convert.ToDecimal(TxtPrecioMayorista.Text));
                        if (CheckAdmInv.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@AdministraInventario", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@AdministraInventario", 0);
                        }
                        cmd.Parameters.AddWithValue("@ExistenciaMinima", Convert.ToDecimal(TxtExistenciaMinima.Text));
                        cmd.Parameters.AddWithValue("@Impuesto", Convert.ToInt32(TxtImpuesto.Text));
                        cmd.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(TxtCategoria.Text));
                        cmd.Parameters.AddWithValue("@idUMedida", Convert.ToInt32(TxtUMedida.Text));
                        cmd.Parameters.AddWithValue("@CantidadMayorista", Convert.ToDecimal(TxtCantMayorista.Text));
                        if (checkBoxActivo.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Activo", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Activo", 0);
                        }
                        cmd.Parameters.AddWithValue("@Estante", Convert.ToInt32(TxtEstante.Text));
                        cmd.Parameters.AddWithValue("@Fila", Convert.ToInt32(TxtFila.Text));
                        cmd.Parameters.AddWithValue("@Columna", Convert.ToInt32(TxtColumna.Text));
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

        private void CrearImpuesto(object sender, EventArgs e)
        {
            Impuestos frm_impuestos = new Impuestos();

            frm_impuestos.ShowDialog();
        }
    }
}