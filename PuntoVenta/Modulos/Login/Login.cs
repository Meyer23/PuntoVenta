﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos
{
    public partial class Login : Form
    {
        int contador;
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            iniciar_sesion();
        }

        private void iniciar_sesion()
        {
            cargar_usuario();
            contar();


            if (contador > 0)
            {
                VentanaPrincipal.VentanaPrincipal frm_ventana_principal = new VentanaPrincipal.VentanaPrincipal();



                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                var obtenerRol = @"SELECT r.Nombre, c.SucursalCaja from dbo.Usuarios c inner join dbo.Rol r 
								    on c.idRol = r.id
									where c.Login = @Login
                                    and r.id = c.idRol
									and c.Activo = 1";
                SqlCommand command = new SqlCommand(obtenerRol, con);
                command.Parameters.AddWithValue("@Login", txtUsuario.Text.Trim());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int NumeroCaja = reader.GetInt32(1);
                    string NombreRol = reader.GetString(0);

                    frm_ventana_principal.MostrarUsuarioPanel(txtUsuario.Text);
                    frm_ventana_principal.MostrarRol(NombreRol);
                    frm_ventana_principal.ValidarRolUsuario(NombreRol);
                    frm_ventana_principal.MostrarSucursalCaja(NumeroCaja);
                }
                //string result = (string)command.ExecuteScalar();
                con.Close();



                this.Hide();
                frm_ventana_principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, verifique.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void contar()
        {
            int x;
            x = datalistado.Rows.Count;
            contador = (x);
        }

        private void cargar_usuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_usuario_validar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@contraseña", txtContrasena.Text);
                da.SelectCommand.Parameters.AddWithValue("@login", txtUsuario.Text);


                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            datalistado.Visible = false;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciar_sesion();
            }
        }
    }
}
