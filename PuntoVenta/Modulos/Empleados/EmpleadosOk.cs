using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.Empleados
{
    public partial class EmpleadosOk : Form
    {
        bool estadoEmpleado;
        int idEmpleado;
        public EmpleadosOk()
        {
            InitializeComponent();
        }

        private void EmpleadosOk_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }

        private void mostrarEmpleados()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_empleado_mostrar", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_eliminados();
        }

        private void cambiar_color_eliminados()
        {
            foreach (DataGridViewRow row in datalistado.Rows)
            {
                estadoEmpleado = (bool)row.Cells["Activo"].Value;
                if (estadoEmpleado == false)
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void ocultar_columnas()
        {
            datalistado.Columns[1].Visible = false;
            datalistado.Columns[6].Visible = false;
            datalistado.Columns[7].Visible = false;
            datalistado.Columns[8].Visible = false;
            datalistado.Columns[9].Visible = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            BtnGuardarCambios.Visible = false;
            TxtNombres.ReadOnly = false;
            TxtApellidos.ReadOnly = false;
            TxtDocumento.ReadOnly = false;
            limpiar();
        }

        private void limpiar()
        {
            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtDocumento.Clear();
            TxtDireccion.Clear();
            TxtTelefono1.Clear();
            TxtTelefono2.Clear();
            TxtCorreo.Clear();
            BtnGuardar.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com, " + " por favor, seleccione un correo válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                if (TxtNombres.Text != "" && TxtApellidos.Text != "" && TxtDocumento.Text != "")
                {

                    if (TxtDireccion.Text == "")
                    {
                        TxtDireccion.Text = "Paraguay";
                    }
                    if (TxtTelefono1.Text == "")
                    {
                        TxtTelefono1.Text = "0";
                    }
                    if (TxtTelefono2.Text == "")
                    {
                        TxtTelefono2.Text = "0";
                    }
                    if (TxtCorreo.Text == "")
                    {
                        TxtCorreo.Text = "0";
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_empleado_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombres", TxtNombres.Text);
                        cmd.Parameters.AddWithValue("@Apellidos", TxtApellidos.Text);
                        cmd.Parameters.AddWithValue("@Documento", TxtDocumento.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                        cmd.Parameters.AddWithValue("@FechaNac", dateTimeFechaNac.Value);
                        cmd.Parameters.AddWithValue("@Telefono1", TxtTelefono1.Text);
                        cmd.Parameters.AddWithValue("@Telefono2", TxtTelefono2.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        if (checkBoxActivo.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Activo", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Activo", 0);
                        }
                        
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarEmpleados();
                        PanelRegistro.Visible = false;
                        TxtBusqueda.Visible = true;
                        menuStrip1.Visible = true;
                        BtnNuevo.Visible = true;
                        limpiar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Incompletos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool ValidarCorreo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        private void BuscarEmpleado(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_empleado_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBusqueda.Text);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_eliminados();
        }

        //private void EliminarEmpleado(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == this.datalistado.Columns["Eliminar"].Index)
        //    {
        //        DialogResult result;
        //        result = MessageBox.Show("¿Está seguro de eliminar este empleado del sistema?", "Eliminando registro...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        //        if (result == DialogResult.OK)
        //        {
        //            SqlCommand cmd;
        //            try
        //            {
        //                foreach (DataGridViewRow row in datalistado.SelectedRows)
        //                {
        //                    int onekey = Convert.ToInt32(row.Cells["idEmpleado"].Value);

        //                    try
        //                    {
        //                        try
        //                        {
        //                            SqlConnection con = new SqlConnection();
        //                            con.ConnectionString = Conexion.ConexionMaestra.conexion;
        //                            con.Open();
        //                            cmd = new SqlCommand("sp_empleado_eliminar", con);
        //                            cmd.CommandType = CommandType.StoredProcedure;

        //                            cmd.Parameters.AddWithValue("@idEmpleado", onekey);
        //                            cmd.ExecuteNonQuery();

        //                            con.Close();
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            MessageBox.Show(ex.Message);
        //                        }

        //                    }
        //                    catch (Exception ex)
        //                    {

        //                        MessageBox.Show(ex.Message);
        //                    }

        //                }
        //                mostrarEmpleados();
        //            }

        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }

        //        }
        //    }
        //}

        private void EditarEmpleado(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                TxtNombres.ReadOnly = true;
                TxtApellidos.ReadOnly = true;
                TxtDocumento.ReadOnly = true;
                ObtenerDatosEmpleado();
            }
        }

        private void EditarEmpleado2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            TxtNombres.ReadOnly = true;
            TxtApellidos.ReadOnly = true;
            TxtDocumento.ReadOnly = true;
            ObtenerDatosEmpleado();
        }

        private void ObtenerDatosEmpleado()
        {
            try
            {
                idEmpleado = Convert.ToInt32(datalistado.SelectedCells[1].Value.ToString());
                TxtNombres.Text = datalistado.SelectedCells[2].Value.ToString();
                TxtApellidos.Text = datalistado.SelectedCells[3].Value.ToString();
                TxtDocumento.Text = datalistado.SelectedCells[4].Value.ToString();
                TxtDireccion.Text = datalistado.SelectedCells[5].Value.ToString();
                dateTimeFechaNac.Value = (DateTime)datalistado.SelectedCells[6].Value;
                TxtTelefono1.Text = datalistado.SelectedCells[7].Value.ToString();
                TxtTelefono2.Text = datalistado.SelectedCells[8].Value.ToString();
                TxtCorreo.Text = datalistado.SelectedCells[9].Value.ToString();
                estadoEmpleado = (bool)datalistado.SelectedCells[10].Value;
                if(estadoEmpleado == true)
                {
                    checkBoxActivo.Checked = true;
                }
                else
                {
                    checkBoxActivo.Checked = false;
                }

                TxtBusqueda.Visible = false;
                menuStrip1.Visible = false;
                BtnNuevo.Visible = false;
                PanelRegistro.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

    //private void restaurarEmpleado()
    //    {
    //        DialogResult result;
    //        result = MessageBox.Show("Este empleado se encuentra eliminado, ¿Desea volver a Habilitarlo?", "Restauración de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
    //        if (result == DialogResult.OK)
    //        {
    //            foreach (DataGridViewRow row in datalistado.SelectedRows)
    //            {
    //                int idProveedor = Convert.ToInt32(row.Cells["idEmpleado"].Value);
    //                try
    //                {
    //                    SqlCommand cmd;
    //                    SqlConnection con = new SqlConnection();
    //                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
    //                    con.Open();
    //                    cmd = new SqlCommand("sp_empleado_restaurar", con);
    //                    cmd.CommandType = CommandType.StoredProcedure;
    //                    cmd.Parameters.AddWithValue("@idEmpleado", idProveedor);
    //                    cmd.ExecuteNonQuery();
    //                    con.Close();
    //                }
    //                catch (Exception ex)
    //                {
    //                    MessageBox.Show(ex.Message);
    //                }
    //                mostrarEmpleados();
    //            }
    //        }
    //    }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com, " + " por favor, seleccione un correo válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                if (TxtNombres.Text != "" && TxtApellidos.Text != "" && TxtDocumento.Text != "")
                {

                    if (TxtDireccion.Text == "")
                    {
                        TxtDireccion.Text = "Paraguay";
                    }
                    if (TxtTelefono1.Text == "")
                    {
                        TxtTelefono1.Text = "0";
                    }
                    if (TxtTelefono2.Text == "")
                    {
                        TxtTelefono2.Text = "0";
                    }
                    if (TxtCorreo.Text == "")
                    {
                        TxtCorreo.Text = "0";
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_empleado_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        cmd.Parameters.AddWithValue("@Nombres", TxtNombres.Text);
                        cmd.Parameters.AddWithValue("@Apellidos", TxtApellidos.Text);
                        cmd.Parameters.AddWithValue("@Documento", TxtDocumento.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                        cmd.Parameters.AddWithValue("@FechaNac", dateTimeFechaNac.Value);
                        cmd.Parameters.AddWithValue("@Telefono1", TxtTelefono1.Text);
                        cmd.Parameters.AddWithValue("@Telefono2", TxtTelefono2.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        if (checkBoxActivo.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Activo", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Activo", 0);
                        }
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarEmpleados();
                        PanelRegistro.Visible = false;
                        TxtBusqueda.Visible = true;
                        menuStrip1.Visible = true;
                        BtnNuevo.Visible = true;
                        limpiar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Incompletos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

