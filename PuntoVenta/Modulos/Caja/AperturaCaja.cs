using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos
{
    public partial class AperturaCaja : Form
    {
        public AperturaCaja()
        {
            InitializeComponent();
        }

        private void BtnIniciarCaja_Click(object sender, EventArgs e)
        {
            if (TxtMontoInicial.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("dbo.sp_iniciar_caja", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@montoInicial", decimal.Parse(TxtMontoInicial.Text));
                    cmd.Parameters.AddWithValue("@fecha_apertura", TxtFechaHora.Value);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("La caja se inició correctamente.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
