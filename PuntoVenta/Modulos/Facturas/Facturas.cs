using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PuntoVenta.Modulos
{
    public partial class Facturas : Form
    {
        private DataTable dt;
        private decimal total = 0;

        public Facturas()
        {
            InitializeComponent();
            LeerTextTipoFactura();
            LABELCAJANUMERO.Visible = false;

            try
            {
                dt = new DataTable();
                dt.Columns.Add("Código", typeof(Int32));
                dt.Columns.Add("Producto", typeof(String));
                dt.Columns.Add("Precio", typeof(Decimal));
                dt.Columns.Add("Cantidad", typeof(Decimal));
                dt.Columns.Add("Total", typeof(Decimal));

                ItemsDataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeerTextTipoFactura()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("SELECT descripcion FROM DBO.TipoDocumentoVenta t " +
                "where t.Activo = 1", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sTipo = dr.GetString("descripcion");
                TxtTipo.Items.Add(sTipo);
            }
            con.Close();

            TxtTipo.SelectedIndex = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void MostrarNroCaja(string CajaNumero)
        {
            int caja = Int32.Parse(CajaNumero);

            LABELCAJANUMERO.Text = caja.ToString();

            ComboNroCaja.Text = caja.ToString();
        }

        public Tuple<string> ObtenerCliente(string ruc)
        {
            string resultado = "";
            ruc = TxtRUC.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            string query = "select Nombre from dbo.Clientes where RUC_CI = '" + ruc + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                resultado = reg["Nombre"].ToString();
            }
            con.Close();
            return Tuple.Create(resultado);
        }

        private void LeerTextBoxRUC(object sender, EventArgs e)
        {
            TxtRazonSocial.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("SELECT RUC_CI FROM DBO.CLIENTES", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                myCollection.Add(dr.GetString(0));
            }
            TxtRUC.AutoCompleteCustomSource = myCollection;
            var completarNombre = ObtenerCliente(TxtRUC.Text);
            TxtRazonSocial.Text = completarNombre.Item1;
            con.Close();
        }

        private void ComboBoxChange(object sender, EventArgs e)
        {
            TxtRazonSocial.Clear();
            if (TxtCliente.Text.Contains("CLIENTES CASUALES"))
            {
                LabelRuc.Hide();
                TxtRUC.Hide();
                TxtRazonSocial.AppendText("CLIENTES CASUALES");
            }
            else
            {
                LabelRuc.Show();
                TxtRUC.Show();
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ConsultarProducto(TxtCodigoProducto.Text);
                DataRow row = dt.NewRow();
                row["Total"] = Int32.Parse(TxtCantidad.Text) * decimal.Parse(result.Item2);
                row["Producto"] = result.Item1;
                row["Código"] = TxtCodigoProducto.Text;
                row["Cantidad"] = TxtCantidad.Text;
                row["Precio"] = decimal.Parse(result.Item2);
                dt.Rows.Add(row);

                total += Int32.Parse(TxtCantidad.Text) * decimal.Parse(result.Item2);
                ValorTotal.Text = total.ToString() + " Gs.";
            }
            catch (Exception)
            {
                MessageBox.Show("Debe agregar al menos 1 producto.");
            }
        }

        public Tuple<string, string> ConsultarProducto(string codigo)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            string query = "select Descripcion, Precio from dbo.Productos where Codigo = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return Tuple.Create(reg["Descripcion"].ToString(), (reg["Precio"].ToString()));
            }
            else
            {
                return Tuple.Create("", "");
            }
        }

        private void LeerTxtCodigoProducto(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("SELECT Codigo FROM DBO.PRODUCTOS where Existencia > 0 and  Activo = 1", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                myCollection.Add(dr.GetString(0));
            }
            TxtCodigoProducto.AutoCompleteCustomSource = myCollection;
            var NombreProducto = ConsultarProducto(TxtCodigoProducto.Text);
            TxtNombreProducto.Text = NombreProducto.Item1;

            con.Close();
        }

        public Tuple<string, string, string> ConsultarCaja()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            string query = "SELECT Estado, idCaja, montocierre from dbo.Caja where Estado = 'ACTIVO'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return Tuple.Create(reg["Estado"].ToString(), reg["idCaja"].ToString(), reg["montoCierre"].ToString());

            }
            else
            {
                return Tuple.Create("", "", "");
            }
        }
        public void MostrarEstadoCaja()
        {
            var EstadoCaja = ConsultarCaja().Item1;
            var idCaja = ConsultarCaja().Item2;
        }
    }
}