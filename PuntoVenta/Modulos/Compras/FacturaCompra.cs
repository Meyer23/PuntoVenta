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
        public FacturaCompra()
        {
            InitializeComponent();
        }

        Proveedores prov = new Proveedores();

        private void FacturaCompra_Load(object sender, EventArgs e)
        {

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
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
        }

    }
}
