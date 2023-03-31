using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Permisos
{
    public partial class RolesPermisos : Form
    {
        public RolesPermisos()
        {
            InitializeComponent();
            LeerTextRol();
            LeerTextModulo();
        }

        private void LeerTextRol()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("SELECT nombre FROM DBO.ROL r " +
                "where r.Estado = 1", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sRol = dr.GetString("nombre");
                RolCombo.Items.Add(sRol);
            }
            con.Close();

        }

        private void LeerTextModulo()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("SELECT nombre FROM DBO.Modulo m " +
                "where m.Activo = 1", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sModulo = dr.GetString("nombre");
                ModulosCombo.Items.Add(sModulo);
            }
            con.Close();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (RolCombo.SelectedIndex >= 0)
            {

            }
            else
                MessageBox.Show("Debe elegir un Rol.");

            if (ModulosCombo.SelectedIndex >= 0)
            {

            }
            else
                MessageBox.Show("Debe elegir el Módulo.");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
