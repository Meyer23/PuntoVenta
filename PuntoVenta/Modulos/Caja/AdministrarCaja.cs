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
    public partial class AdministrarCaja : Form
    {
        public AdministrarCaja()
        {
            InitializeComponent();
            LlenarValoresDeCaja();
        }

        private void AdministrarCaja_Load(object sender, EventArgs e)
        {

        }

        private Tuple<string, string, string> ObtenerDetalleCierre()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            string query = "select c.idCaja, c.montoActual, c.estado from dbo.Caja c where c.estado = 'ACTIVO'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return Tuple.Create(reg["idCaja"].ToString(), (reg["montoActual"].ToString()), reg["Estado"].ToString());
            }
            else
            {
                return Tuple.Create("", "", "");
            }
        }

        private void LlenarValoresDeCaja()
        {
            var idCaja = ObtenerDetalleCierre().Item1;
            var saldoSistema = ObtenerDetalleCierre().Item2;
            var estadoCaja = ObtenerDetalleCierre().Item3;
            TxtAdmEstadoCaja.Text = estadoCaja;
            TxtTotalEnSistema.Text = saldoSistema;
            Txt_idCajaCierre.Text = idCaja; 
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            LlenarValoresDeCaja();
            if (TxtSaldoIngresante.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("dbo.sp_caja_cerrar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCaja", Int16.Parse(Txt_idCajaCierre.Text));
                    cmd.Parameters.AddWithValue("@montoCierre", decimal.Parse(TxtSaldoIngresante.Text));
                    cmd.Parameters.AddWithValue("@fechaCierre", HoraCierrePicker.Value);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                   
                    cmd.ExecuteNonQuery();
                    con.Close();
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