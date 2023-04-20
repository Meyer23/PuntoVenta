using PuntoVenta.Modulos.GrupoDocumento_Ok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Timbrado_Ok
{
    public partial class Timbrado : Form
    {
        public Timbrado()
        {
            InitializeComponent();
            LeerGrupoDocumento();
            MostrarTimbrado();
            OcultarColumnas();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeerGrupoDocumento()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("SELECT descripcion FROM DBO.GrupoDocumento d", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sDescripcion = dr.GetString("descripcion");
                ComboBoxGrupoDocumento.Items.Add(sDescripcion);
            }
            con.Close();
        }

        private void MostrarTimbrado()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Conexion.ConexionMaestra.conexion;
                conn.Open();
                da = new SqlDataAdapter("sp_timbrado_mostrar", conn);
                da.Fill(dt);
                DataGridViewTimbrado.DataSource = dt;

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void OcultarColumnas()
        {
            DataGridViewTimbrado.Columns[1].Visible = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            PanelVerTimbrado.Hide();
            PanelTimbrado.Show();
        }

        private void BtnCancelarAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("dbo.sp_timbrado_insertar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GrupoDocumentoDesc", ComboBoxGrupoDocumento.Text);
                cmd.Parameters.AddWithValue("@NroTimbrado", TimbradoUpDown.Value);
                cmd.Parameters.AddWithValue("@InicioVigencia", DateTimeInicioVigencia.Value);
                cmd.Parameters.AddWithValue("@FinVigencia", DateTimeFinVigencia.Value);
                cmd.Parameters.AddWithValue("@NroDesde", NroDesdeUpDown.Value);
                cmd.Parameters.AddWithValue("@NroHasta", NroHastaUpDown.Value);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                if (ChkActivo.Checked)
                {
                    cmd.Parameters.AddWithValue("@Activo", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Activo", 0);
                }

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Timbrado agregado.");
                PanelVerTimbrado.Show();
                PanelTimbrado.Hide();
                MostrarTimbrado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void EditarT(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Hide();
            if (e.ColumnIndex == this.DataGridViewTimbrado.Columns["EditarTimbrado"].Index)
            {
                ComboBoxGrupoDocumento.Text = DataGridViewTimbrado.SelectedCells[2].Value.ToString();
                TimbradoUpDown.Value = Convert.ToInt64(DataGridViewTimbrado.SelectedCells[3].Value);
                DateTimeInicioVigencia.Value = (DateTime)DataGridViewTimbrado.SelectedCells[4].Value;
                DateTimeFinVigencia.Value = (DateTime)DataGridViewTimbrado.SelectedCells[5].Value;
                NroDesdeUpDown.Value = Convert.ToInt64(DataGridViewTimbrado.SelectedCells[6].Value);
                NroHastaUpDown.Value = Convert.ToInt64(DataGridViewTimbrado.SelectedCells[7].Value);
                PanelTimbrado.Show();
                PanelVerTimbrado.Hide();
                BtnGuardarEditado.Show();
            }
        }

        private void BtnGuardarEditado_Click(object sender, EventArgs e)
        {
            int idTimbrado = Convert.ToInt32(DataGridViewTimbrado.SelectedCells[1].Value);
            string GrupoDocumentoDesc = ComboBoxGrupoDocumento.Text;
            var NroTimbrado = Convert.ToInt64(TimbradoUpDown.Value);
            var InicioVigencia = Convert.ToDateTime(DateTimeInicioVigencia.Value);
            var FinVigencia = Convert.ToDateTime(DateTimeFinVigencia.Value);
            var NroDesde = Convert.ToInt64(NroDesdeUpDown.Value);
            var NroHasta = Convert.ToInt64(NroHastaUpDown.Value);

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("dbo.sp_timbrado_editar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idTimbrado", idTimbrado);
                da.SelectCommand.Parameters.AddWithValue("@GrupoDocumentoDesc", GrupoDocumentoDesc);
                da.SelectCommand.Parameters.AddWithValue("@NroTimbrado", NroTimbrado);
                da.SelectCommand.Parameters.AddWithValue("@InicioVigencia", InicioVigencia);
                da.SelectCommand.Parameters.AddWithValue("@FinVigencia", FinVigencia);
                da.SelectCommand.Parameters.AddWithValue("@NroDesde", NroDesde);
                da.SelectCommand.Parameters.AddWithValue("@NroHasta", NroHasta);
                if (ChkActivo.Checked)
                {
                    da.SelectCommand.Parameters.AddWithValue("@Activo", 1);
                }
                else
                    da.SelectCommand.Parameters.AddWithValue("@Activo", 0);
                da.Fill(dt);
                DataGridViewTimbrado.DataSource = dt;
                con.Close();
                MessageBox.Show("Registro editado.");
                PanelTimbrado.Hide();
                PanelVerTimbrado.Show();
                MostrarTimbrado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
