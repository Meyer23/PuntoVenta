using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Compras
{
    public partial class FacturaCompra : Form
    {
        private DataTable dt;
        bool estadoCompra;
        int idcompra;
        public FacturaCompra()
        {
            InitializeComponent();
            try
            {
                dt = new DataTable();
                dt.Columns.Add("Producto", typeof(String));
                dt.Columns.Add("Descripción", typeof(String));
                dt.Columns.Add("Cantidad", typeof(Int32));
                dt.Columns.Add("Precio", typeof(Decimal));
                dt.Columns.Add("Total Línea", typeof(Decimal));

                dataGridProductos.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Proveedores prov = new Proveedores();
        Sucursal suc = new Sucursal();
        public static int contador = 0;
        public static decimal total;

        private void FacturaCompra_Load(object sender, EventArgs e)
        {
            cmbSucursal.DataSource = suc.cargarComboSucursal();
            cmbSucursal.DisplayMember = "Descripcion";
            cmbSucursal.ValueMember = "idSucursal";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_proveedor_cargar", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            cmbProveedor.DataSource = dt;
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "idProveedor";

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach(DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["RazonSocial"]));
            }

            cmbProveedor.AutoCompleteCustomSource = coleccion;
            cmbProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;

            mostrarCompras();
        }

        private void mostrarCompras()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_compra_mostrar", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_anulados();
        }

        private void cambiar_color_anulados()
        {
            foreach (DataGridViewRow row in datalistado.Rows)
            {
                estadoCompra = (bool)row.Cells["Anulado"].Value;
                if (estadoCompra == false)
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void ocultar_columnas()
        {
            datalistado.Columns[1].Visible = false;
            datalistado.Columns[5].Visible = false;
            datalistado.Columns[6].Visible = false;
            datalistado.Columns[7].Visible = false;
            datalistado.Columns[8].Visible = false;
            datalistado.Columns[11].Visible = false;
            datalistado.Columns[12].Visible = false;
            datalistado.Columns[13].Visible = false;
            datalistado.Columns[14].Visible = false;
            datalistado.Columns[15].Visible = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            cmbSucursal.Focus();
            limpiar();
        }

        private void limpiar()
        {
            txtCodEst.Clear();
            txtPE.Clear();
            txtNroFact.Clear();
            txtCuotas.Clear();
            txtTimbrado.Clear();
            txtObs.Clear();
            dt.Rows.Clear();
            contador = 0;
            total = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int nroFila = 0;

            TxtProd.Clear();
            txtCant.Clear();
            txtPrecio.Clear();

            if (contador == 0)
            {
                //dataGridProductos.Rows.Add(TxtProd.Text, txtDescripcion.Text, txtCant, txtPrecio);
               // decimal totalLinea = int.Parse(dataGridProductos.Rows[contador].Cells[2].Value.ToString()) * decimal.Parse(dataGridProductos.Rows[contador].Cells[3].Value.ToString());
               // dataGridProductos.Rows[contador].Cells[4].Value = totalLinea;
                var result = ConsultarProducto(TxtProd.Text);
                DataRow row = dt.NewRow();
                row["Producto"] = TxtProd.Text;
                row["Descripción"] = result.Item1;
                row["Cantidad"] = Int32.Parse(txtCant.Text);
                row["Precio"] = decimal.Parse(txtPrecio.Text);
                row["Total Línea"] = Int32.Parse(txtCant.Text) * decimal.Parse(txtPrecio.Text);
                dt.Rows.Add(row);

                contador++;
            }
            else
            {
                foreach(DataGridViewRow fila in dataGridProductos.Rows)
                {
                    if(fila.Cells[0].Value.ToString() == TxtProd.Text)
                    {
                        existe = true;
                        nroFila = fila.Index;
                    }
                }

                if (existe == true)
                {
                    MessageBox.Show("Articulo ya ingresado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var result = ConsultarProducto(TxtProd.Text);
                    DataRow row = dt.NewRow();
                    row["Articulo"] = TxtProd.Text;
                    row["Descripcion"] = result.Item1;
                    row["Cantidad"] = txtCant.Text;
                    row["Precio"] = txtPrecio.Text;
                    row["TotalLinea"] = Int32.Parse(txtCant.Text) * decimal.Parse(txtPrecio.Text);
                    dt.Rows.Add(row);

                    contador++;
                }
            }

            total = 0;
            foreach (DataGridViewRow fila in dataGridProductos.Rows)
            {
                total += Convert.ToDecimal(fila.Cells[4].Value);
            }
            txtTotal.Text = total.ToString();
        }

        public Tuple<string> ConsultarProducto(string codigo)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            string query = "select Descripcion from dbo.Productos where Codigo = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return Tuple.Create(reg["Descripcion"].ToString());
            }
            else
            {
                return Tuple.Create("");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contador >= 1)
            {
                total = total - (Convert.ToDecimal(dataGridProductos.Rows[dataGridProductos.CurrentRow.Index].Cells[4].Value));

                dataGridProductos.Rows.RemoveAt(dataGridProductos.CurrentRow.Index);
                contador--;
            }

        }

        private void BuscarCompra(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_compra_buscar", con);
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
            cambiar_color_anulados();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (cmbSucursal.Text != "" && cmbProveedor.Text != "" && cmbTipoDoc.Text != "")
            {   
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("sp_compra_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Sucursal", Convert.ToInt32(cmbSucursal.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@Proveedor", Convert.ToInt32(cmbProveedor.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@TipoDocumento", Convert.ToInt32(cmbTipoDoc.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@CodEst", Convert.ToInt32(txtCodEst.Text));
                    cmd.Parameters.AddWithValue("@PuntoEmision", Convert.ToInt32(txtPE.Text));
                    cmd.Parameters.AddWithValue("@NroFact", txtNroFact.Text);
                    cmd.Parameters.AddWithValue("@Fecha", Fecha.Value);
                    cmd.Parameters.AddWithValue("@FechaRecep", FechaRec.Value);
                    cmd.Parameters.AddWithValue("@FechaVenc", FechaVenc.Value);
                    cmd.Parameters.AddWithValue("@Cuotas", Convert.ToInt32(txtCuotas.Text));
                    cmd.Parameters.AddWithValue("@Timbrado", Convert.ToInt32(txtTimbrado.Text));
                    cmd.Parameters.AddWithValue("@Obs", txtObs.Text);
                    cmd.Parameters.AddWithValue("@TotalCompra", Convert.ToInt32(txtTotal.Text));
                    cmd.Parameters.AddWithValue("@Procesado", 1);
                    cmd.Parameters.AddWithValue("@Anulado", 0);
                    
                    var result = ConsultarCompra(Convert.ToInt32(cmbSucursal.SelectedValue.ToString()), Convert.ToInt32(cmbProveedor.SelectedValue.ToString()), Convert.ToInt32(cmbTipoDoc.SelectedValue.ToString()), txtNroFact.Text, Convert.ToInt32(txtTimbrado.Text));
                    idcompra = Convert.ToInt32(result.Item1);
                    SqlCommand cmd1 = new SqlCommand();
                    foreach (DataGridViewRow fila in dataGridProductos.Rows)
                    {
                        int nroFila = fila.Index;
                        cmd1 = new SqlCommand("sp_compra_item_insertar", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Compra", idcompra);
                        cmd1.Parameters.AddWithValue("@Producto", Convert.ToInt32(dataGridProductos.Rows[nroFila].Cells[0].Value.ToString()));
                        cmd1.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(dataGridProductos.Rows[nroFila].Cells[2].Value.ToString()));
                        cmd1.Parameters.AddWithValue("@Precio", Convert.ToDecimal(dataGridProductos.Rows[nroFila].Cells[3].Value.ToString()));
                        cmd1.Parameters.AddWithValue("@TotalLinea", Convert.ToDecimal(dataGridProductos.Rows[nroFila].Cells[4].Value.ToString()));
                    }                   

                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrarCompras();
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

        public Tuple<string> ConsultarCompra(int Sucursal,int Proveedor, int TipoDocumento,string nroFactura, int timbrado)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            string query = "select Descripcion, Precio from dbo.Compras where Sucursal = " + Sucursal + "and Proveedor = " + Proveedor + "and TipoDocumento = " + TipoDocumento + "and NroFactura = '" + nroFactura + "' and Timbrado = " + timbrado + "and Anulado = 0";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return Tuple.Create(reg["Descripcion"].ToString());
            }
            else
            {
                return Tuple.Create("");
            }
        }
    }
}
