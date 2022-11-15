using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PuntoVenta.Modulos
{
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
            MostrarDataGridViewFactura();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarDataGridViewFactura()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Código", typeof(Int32));
                dt.Columns.Add("Descripción", typeof(String));
                dt.Columns.Add("Precio", typeof(Decimal));
                dt.Columns.Add("Cantidad", typeof(Int16));
                dt.Columns.Add("Total", typeof(Decimal));

                ItemsDataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
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
            con.Close();
        }

        private void ComboBoxChange(object sender, EventArgs e)
        {
            if(TxtCliente.Text.Contains("CLIENTES CASUALES"))
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
    }
}