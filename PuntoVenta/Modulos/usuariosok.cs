using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PuntoVenta
{
    public partial class usuariosok : Form
    {
        public usuariosok()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("dbo.sp_usuario_insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombres", txtnombre.Text);
            cmd.Parameters.AddWithValue("@Login", txtlogin.Text);
            cmd.Parameters.AddWithValue("@Contraseña", txtpassword.Text);

            cmd.Parameters.AddWithValue("@Correo", txtcorreo.Text);
            cmd.Parameters.AddWithValue("@Rol", txtrol.Text);
            cmd.Parameters.AddWithValue("@ESTADO", "ACTIVO");

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}