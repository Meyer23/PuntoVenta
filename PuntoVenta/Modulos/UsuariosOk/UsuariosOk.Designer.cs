﻿
namespace PuntoVenta.Modulos
{
    partial class UsuariosOk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosOk));
            this.PanelBusqueda = new System.Windows.Forms.Panel();
            this.BtnAgregarUsuario = new System.Windows.Forms.Button();
            this.BtnBuscarUsuario = new System.Windows.Forms.Button();
            this.TxtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.DataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelAgregarUsuario = new System.Windows.Forms.Panel();
            this.txtidRol = new System.Windows.Forms.Label();
            this.Label_idUsuario = new System.Windows.Forms.Label();
            this.PanelUsuarioImagen = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtRol = new System.Windows.Forms.ComboBox();
            this.LabelRol = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LabelCorreo = new System.Windows.Forms.Label();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelNombres = new System.Windows.Forms.Label();
            this.BtnGuardarEditado = new System.Windows.Forms.Button();
            this.PanelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuarios)).BeginInit();
            this.PanelAgregarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBusqueda
            // 
            this.PanelBusqueda.BackColor = System.Drawing.Color.Silver;
            this.PanelBusqueda.Controls.Add(this.BtnAgregarUsuario);
            this.PanelBusqueda.Controls.Add(this.BtnBuscarUsuario);
            this.PanelBusqueda.Controls.Add(this.TxtBuscarUsuario);
            this.PanelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.PanelBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelBusqueda.Name = "PanelBusqueda";
            this.PanelBusqueda.Size = new System.Drawing.Size(1490, 105);
            this.PanelBusqueda.TabIndex = 1;
            // 
            // BtnAgregarUsuario
            // 
            this.BtnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarUsuario.Location = new System.Drawing.Point(594, 35);
            this.BtnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            this.BtnAgregarUsuario.Size = new System.Drawing.Size(107, 40);
            this.BtnAgregarUsuario.TabIndex = 2;
            this.BtnAgregarUsuario.Text = "Agregar";
            this.BtnAgregarUsuario.UseVisualStyleBackColor = true;
            this.BtnAgregarUsuario.Click += new System.EventHandler(this.BtnAgregarUsuario_Click);
            // 
            // BtnBuscarUsuario
            // 
            this.BtnBuscarUsuario.BackColor = System.Drawing.Color.White;
            this.BtnBuscarUsuario.Location = new System.Drawing.Point(479, 35);
            this.BtnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            this.BtnBuscarUsuario.Size = new System.Drawing.Size(107, 40);
            this.BtnBuscarUsuario.TabIndex = 1;
            this.BtnBuscarUsuario.Text = "Buscar";
            this.BtnBuscarUsuario.UseVisualStyleBackColor = false;
            this.BtnBuscarUsuario.Click += new System.EventHandler(this.BuscarUsuario);
            // 
            // TxtBuscarUsuario
            // 
            this.TxtBuscarUsuario.Location = new System.Drawing.Point(17, 35);
            this.TxtBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBuscarUsuario.Name = "TxtBuscarUsuario";
            this.TxtBuscarUsuario.Size = new System.Drawing.Size(451, 31);
            this.TxtBuscarUsuario.TabIndex = 0;
            // 
            // DataGridUsuarios
            // 
            this.DataGridUsuarios.AllowUserToAddRows = false;
            this.DataGridUsuarios.BackgroundColor = System.Drawing.Color.Gray;
            this.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.DataGridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridUsuarios.Location = new System.Drawing.Point(0, 105);
            this.DataGridUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridUsuarios.Name = "DataGridUsuarios";
            this.DataGridUsuarios.RowHeadersWidth = 62;
            this.DataGridUsuarios.RowTemplate.Height = 25;
            this.DataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridUsuarios.Size = new System.Drawing.Size(1490, 663);
            this.DataGridUsuarios.TabIndex = 2;
            this.DataGridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EliminarUsuario);
            this.DataGridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarUsuario);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 150;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Width = 150;
            // 
            // PanelAgregarUsuario
            // 
            this.PanelAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelAgregarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAgregarUsuario.Controls.Add(this.txtidRol);
            this.PanelAgregarUsuario.Controls.Add(this.Label_idUsuario);
            this.PanelAgregarUsuario.Controls.Add(this.PanelUsuarioImagen);
            this.PanelAgregarUsuario.Controls.Add(this.BtnCancelar);
            this.PanelAgregarUsuario.Controls.Add(this.BtnGuardar);
            this.PanelAgregarUsuario.Controls.Add(this.TxtRol);
            this.PanelAgregarUsuario.Controls.Add(this.LabelRol);
            this.PanelAgregarUsuario.Controls.Add(this.TxtCorreo);
            this.PanelAgregarUsuario.Controls.Add(this.TxtContraseña);
            this.PanelAgregarUsuario.Controls.Add(this.TxtLogin);
            this.PanelAgregarUsuario.Controls.Add(this.TxtNombres);
            this.PanelAgregarUsuario.Controls.Add(this.LabelCorreo);
            this.PanelAgregarUsuario.Controls.Add(this.LabelContraseña);
            this.PanelAgregarUsuario.Controls.Add(this.LabelLogin);
            this.PanelAgregarUsuario.Controls.Add(this.LabelNombres);
            this.PanelAgregarUsuario.Controls.Add(this.BtnGuardarEditado);
            this.PanelAgregarUsuario.Location = new System.Drawing.Point(4, 105);
            this.PanelAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelAgregarUsuario.Name = "PanelAgregarUsuario";
            this.PanelAgregarUsuario.Size = new System.Drawing.Size(1085, 537);
            this.PanelAgregarUsuario.TabIndex = 3;
            this.PanelAgregarUsuario.Visible = false;
            // 
            // txtidRol
            // 
            this.txtidRol.AutoSize = true;
            this.txtidRol.Location = new System.Drawing.Point(246, 332);
            this.txtidRol.Name = "txtidRol";
            this.txtidRol.Size = new System.Drawing.Size(59, 25);
            this.txtidRol.TabIndex = 610;
            this.txtidRol.Text = "label1";
            this.txtidRol.Visible = false;
            // 
            // Label_idUsuario
            // 
            this.Label_idUsuario.AutoSize = true;
            this.Label_idUsuario.Location = new System.Drawing.Point(964, 38);
            this.Label_idUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_idUsuario.Name = "Label_idUsuario";
            this.Label_idUsuario.Size = new System.Drawing.Size(59, 25);
            this.Label_idUsuario.TabIndex = 609;
            this.Label_idUsuario.Text = "label1";
            this.Label_idUsuario.Visible = false;
            // 
            // PanelUsuarioImagen
            // 
            this.PanelUsuarioImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUsuarioImagen.BackgroundImage")));
            this.PanelUsuarioImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelUsuarioImagen.Location = new System.Drawing.Point(703, 32);
            this.PanelUsuarioImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelUsuarioImagen.Name = "PanelUsuarioImagen";
            this.PanelUsuarioImagen.Size = new System.Drawing.Size(204, 177);
            this.PanelUsuarioImagen.TabIndex = 12;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(750, 372);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(157, 85);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(589, 372);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(157, 85);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardarUsuario_Click);
            // 
            // TxtRol
            // 
            this.TxtRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtRol.FormattingEnabled = true;
            this.TxtRol.Location = new System.Drawing.Point(246, 272);
            this.TxtRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRol.Name = "TxtRol";
            this.TxtRol.Size = new System.Drawing.Size(657, 33);
            this.TxtRol.TabIndex = 607;
            this.TxtRol.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRoles);
            // 
            // LabelRol
            // 
            this.LabelRol.AutoSize = true;
            this.LabelRol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRol.Location = new System.Drawing.Point(183, 277);
            this.LabelRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRol.Name = "LabelRol";
            this.LabelRol.Size = new System.Drawing.Size(48, 30);
            this.LabelRol.TabIndex = 8;
            this.LabelRol.Text = "Rol:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(246, 212);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(390, 31);
            this.TxtCorreo.TabIndex = 7;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(246, 153);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(390, 31);
            this.TxtContraseña.TabIndex = 6;
            this.TxtContraseña.UseSystemPasswordChar = true;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(246, 88);
            this.TxtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(390, 31);
            this.TxtLogin.TabIndex = 5;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(246, 35);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(390, 31);
            this.TxtNombres.TabIndex = 4;
            // 
            // LabelCorreo
            // 
            this.LabelCorreo.AutoSize = true;
            this.LabelCorreo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCorreo.Location = new System.Drawing.Point(44, 210);
            this.LabelCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCorreo.Name = "LabelCorreo";
            this.LabelCorreo.Size = new System.Drawing.Size(199, 30);
            this.LabelCorreo.TabIndex = 3;
            this.LabelCorreo.Text = "Correo electrónico:";
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelContraseña.Location = new System.Drawing.Point(114, 152);
            this.LabelContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(127, 30);
            this.LabelContraseña.TabIndex = 2;
            this.LabelContraseña.Text = "Contraseña:";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelLogin.Location = new System.Drawing.Point(169, 87);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(71, 30);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Login:";
            // 
            // LabelNombres
            // 
            this.LabelNombres.AutoSize = true;
            this.LabelNombres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNombres.Location = new System.Drawing.Point(21, 32);
            this.LabelNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNombres.Name = "LabelNombres";
            this.LabelNombres.Size = new System.Drawing.Size(220, 30);
            this.LabelNombres.TabIndex = 0;
            this.LabelNombres.Text = "Nombres y Apellidos:";
            // 
            // BtnGuardarEditado
            // 
            this.BtnGuardarEditado.BackColor = System.Drawing.Color.Green;
            this.BtnGuardarEditado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarEditado.Location = new System.Drawing.Point(589, 372);
            this.BtnGuardarEditado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuardarEditado.Name = "BtnGuardarEditado";
            this.BtnGuardarEditado.Size = new System.Drawing.Size(157, 85);
            this.BtnGuardarEditado.TabIndex = 608;
            this.BtnGuardarEditado.Text = "Guardar";
            this.BtnGuardarEditado.UseVisualStyleBackColor = false;
            this.BtnGuardarEditado.Click += new System.EventHandler(this.BtnGuardar2);
            // 
            // UsuariosOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1490, 768);
            this.Controls.Add(this.PanelAgregarUsuario);
            this.Controls.Add(this.DataGridUsuarios);
            this.Controls.Add(this.PanelBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UsuariosOk";
            this.Text = "Usuarios del Sistema";
            this.PanelBusqueda.ResumeLayout(false);
            this.PanelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuarios)).EndInit();
            this.PanelAgregarUsuario.ResumeLayout(false);
            this.PanelAgregarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBusqueda;
        private System.Windows.Forms.Button BtnBuscarUsuario;
        private System.Windows.Forms.TextBox TxtBuscarUsuario;
        private System.Windows.Forms.Button BtnAgregarUsuario;
        private System.Windows.Forms.DataGridView DataGridUsuarios;
        private System.Windows.Forms.Panel PanelAgregarUsuario;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelNombres;
        private System.Windows.Forms.Label LabelCorreo;
        private System.Windows.Forms.Label LabelContraseña;
        private System.Windows.Forms.ComboBox TxtRol;
        private System.Windows.Forms.Label LabelRol;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel PanelUsuarioImagen;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Button BtnGuardarEditado;
        private System.Windows.Forms.Label Label_idUsuario;
        private System.Windows.Forms.Label txtidRol;
    }
}