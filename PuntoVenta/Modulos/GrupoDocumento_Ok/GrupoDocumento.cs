using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.GrupoDocumento_Ok
{
    public partial class GrupoDocumento : Form
    {
        public GrupoDocumento()
        {
            InitializeComponent();
            MostrarGrupoDocumentos();
            OcultarColumnas();
        }

        private void MostrarGrupoDocumentos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Conexion.ConexionMaestra.conexion;
                conn.Open();
                da = new SqlDataAdapter("sp_GrupoDocumento_mostrar", conn);
                da.Fill(dt);
                DataGridViewDocumentos.DataSource = dt;

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void OcultarColumnas()
        {
            DataGridViewDocumentos.Columns[1].Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PanelAgregarDocumento.Show();
            PanelVerDocumentos.Hide();
        }

        private void BtnSalirDocumento_Click(object sender, EventArgs e)
        {
            PanelAgregarDocumento.Hide();
            PanelVerDocumentos.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.sp_GrupoDocumento_insertar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", TxTGrupoDocumento.Text);
                if (ChkGrupoActivo.Checked)
                    cmd.Parameters.AddWithValue("@Activo", 1);
                else
                    cmd.Parameters.AddWithValue("@Activo", 0);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Grupo agregado.");
                PanelAgregarDocumento.Hide();
                PanelVerDocumentos.Show();
                MostrarGrupoDocumentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void EditarGrupoDocumento(object sender, DataGridViewCellEventArgs e)
        {
            GuardarEditado.Show();
            BtnGuardarGrupo.Hide();
            PanelVerDocumentos.Hide();
            PanelAgregarDocumento.Show();
            TxTGrupoDocumento.Text = DataGridViewDocumentos.SelectedCells[2].Value.ToString();
        }

        private void GuardarEditado_Click(object sender, EventArgs e)
        {
            int idGrupoDocumento = Convert.ToInt32(DataGridViewDocumentos.SelectedCells[1].Value);
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("dbo.sp_grupoDocumento_editar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idGrupoDocumento", idGrupoDocumento);
                da.SelectCommand.Parameters.AddWithValue("@Descripcion", TxTGrupoDocumento.Text);

                if (ChkGrupoActivo.Checked)
                {
                    da.SelectCommand.Parameters.AddWithValue("@Activo", 1);
                }
                else
                    da.SelectCommand.Parameters.AddWithValue("@Activo", 0);
                da.Fill(dt);
                DataGridViewDocumentos.DataSource = dt;
                con.Close();
                MessageBox.Show("Registro editado.");
                PanelAgregarDocumento.Hide();
                PanelVerDocumentos.Show();
                MostrarGrupoDocumentos();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
