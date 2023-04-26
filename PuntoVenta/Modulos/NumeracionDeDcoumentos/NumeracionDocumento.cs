using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.NumeracionDeDcoumentos
{
    public partial class NumeracionDocumento : Form
    {
        public NumeracionDocumento()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            LeerTextGrupoDocumento();
            LeerTextSucursalCaja();
            LeerTextTimbrado();
        }

        private void BtnAgregarNumeracion_Click(object sender, EventArgs e)
        {
            PanelVerNumeraciones.Hide();
            PanelAgregar.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeerTextGrupoDocumento()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("SELECT descripcion FROM DBO.GrupoDocumento g " +
                "where g.Activo = 1", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sGrupoDocumento = dr.GetString("descripcion");
                ComboBoxGrupoDocumento.Items.Add(sGrupoDocumento);
            }
            con.Close();

        }

        private void LeerTextSucursalCaja()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("SELECT descripcion FROM DBO.Sucursal s " +
                "where s.Activo = 1", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sucursal = dr.GetString("descripcion");
                ComboBoxSucursalCaja.Items.Add(sucursal);
            }
            con.Close();

        }

        private void LeerTextTimbrado()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                SqlCommand cmd = new SqlCommand("SELECT NroTimbrado FROM DBO.Timbrado t " +
                    "where t.Activo = 1", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Int32 timbrado = dr.GetInt32(0);
                    ComboBoxTimbrado.Items.Add(timbrado);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnGuardarNumeracion_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelarAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
