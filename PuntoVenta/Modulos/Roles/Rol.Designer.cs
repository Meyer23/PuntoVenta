﻿
namespace PuntoVenta.Modulos.Roles
{
    partial class Rol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rol));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            PanelEncabezado = new System.Windows.Forms.Panel();
            BtnNuevo = new System.Windows.Forms.Button();
            TxtBusqueda = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            datalistadoRoles = new System.Windows.Forms.DataGridView();
            Editar = new System.Windows.Forms.DataGridViewImageColumn();
            PanelRegistro = new System.Windows.Forms.Panel();
            TxtRolEditando = new System.Windows.Forms.TextBox();
            EditandoNombreRol = new System.Windows.Forms.Label();
            BtnGuardar = new System.Windows.Forms.Button();
            CheckRol = new System.Windows.Forms.CheckBox();
            TxtNombre = new System.Windows.Forms.TextBox();
            LblNombre = new System.Windows.Forms.TextBox();
            BtnCancelar = new System.Windows.Forms.Button();
            BtnGuardarCambios = new System.Windows.Forms.Button();
            PanelEncabezado.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalistadoRoles).BeginInit();
            PanelRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // PanelEncabezado
            // 
            PanelEncabezado.BackColor = System.Drawing.SystemColors.Control;
            PanelEncabezado.Controls.Add(BtnNuevo);
            PanelEncabezado.Controls.Add(TxtBusqueda);
            PanelEncabezado.Controls.Add(menuStrip1);
            PanelEncabezado.Location = new System.Drawing.Point(0, 0);
            PanelEncabezado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PanelEncabezado.Name = "PanelEncabezado";
            PanelEncabezado.Size = new System.Drawing.Size(958, 85);
            PanelEncabezado.TabIndex = 3;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = System.Drawing.Color.FromArgb(1, 97, 140);
            BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnNuevo.ForeColor = System.Drawing.Color.White;
            BtnNuevo.Location = new System.Drawing.Point(600, 8);
            BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new System.Drawing.Size(166, 62);
            BtnNuevo.TabIndex = 8;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += CrearRol;
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtBusqueda.Location = new System.Drawing.Point(56, 20);
            TxtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.PlaceholderText = "Texto a buscar...";
            TxtBusqueda.Size = new System.Drawing.Size(437, 34);
            TxtBusqueda.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(497, 20);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(61, 42);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Click += BuscarRol;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            toolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(40, 36);
            // 
            // datalistadoRoles
            // 
            datalistadoRoles.AllowUserToAddRows = false;
            datalistadoRoles.AllowUserToDeleteRows = false;
            datalistadoRoles.AllowUserToResizeRows = false;
            datalistadoRoles.BackgroundColor = System.Drawing.SystemColors.Control;
            datalistadoRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalistadoRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Editar });
            datalistadoRoles.Location = new System.Drawing.Point(0, 82);
            datalistadoRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            datalistadoRoles.Name = "datalistadoRoles";
            datalistadoRoles.ReadOnly = true;
            datalistadoRoles.RowHeadersWidth = 62;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            datalistadoRoles.RowsDefaultCellStyle = dataGridViewCellStyle1;
            datalistadoRoles.RowTemplate.Height = 25;
            datalistadoRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            datalistadoRoles.Size = new System.Drawing.Size(958, 312);
            datalistadoRoles.TabIndex = 7;
            datalistadoRoles.CellDoubleClick += EditarRol;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = (System.Drawing.Image)resources.GetObject("Editar.Image");
            Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Width = 150;
            // 
            // PanelRegistro
            // 
            PanelRegistro.Controls.Add(TxtRolEditando);
            PanelRegistro.Controls.Add(EditandoNombreRol);
            PanelRegistro.Controls.Add(BtnGuardar);
            PanelRegistro.Controls.Add(CheckRol);
            PanelRegistro.Controls.Add(TxtNombre);
            PanelRegistro.Controls.Add(LblNombre);
            PanelRegistro.Controls.Add(BtnCancelar);
            PanelRegistro.Controls.Add(BtnGuardarCambios);
            PanelRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelRegistro.Location = new System.Drawing.Point(0, 0);
            PanelRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PanelRegistro.Name = "PanelRegistro";
            PanelRegistro.Size = new System.Drawing.Size(962, 394);
            PanelRegistro.TabIndex = 8;
            PanelRegistro.Visible = false;
            // 
            // TxtRolEditando
            // 
            TxtRolEditando.Location = new System.Drawing.Point(531, 87);
            TxtRolEditando.Name = "TxtRolEditando";
            TxtRolEditando.ReadOnly = true;
            TxtRolEditando.Size = new System.Drawing.Size(150, 31);
            TxtRolEditando.TabIndex = 615;
            // 
            // EditandoNombreRol
            // 
            EditandoNombreRol.AutoSize = true;
            EditandoNombreRol.Location = new System.Drawing.Point(421, 90);
            EditandoNombreRol.Name = "EditandoNombreRol";
            EditandoNombreRol.Size = new System.Drawing.Size(91, 25);
            EditandoNombreRol.TabIndex = 614;
            EditandoNombreRol.Text = "Editar Rol:";
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = System.Drawing.Color.FromArgb(1, 97, 140);
            BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnGuardar.ForeColor = System.Drawing.Color.White;
            BtnGuardar.Location = new System.Drawing.Point(421, 162);
            BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new System.Drawing.Size(166, 62);
            BtnGuardar.TabIndex = 14;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += GuardarRol;
            // 
            // CheckRol
            // 
            CheckRol.AutoSize = true;
            CheckRol.Checked = true;
            CheckRol.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckRol.Location = new System.Drawing.Point(189, 85);
            CheckRol.Name = "CheckRol";
            CheckRol.Size = new System.Drawing.Size(88, 29);
            CheckRol.TabIndex = 613;
            CheckRol.Text = "Activo";
            CheckRol.UseVisualStyleBackColor = true;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new System.Drawing.Point(189, 10);
            TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new System.Drawing.Size(577, 31);
            TxtNombre.TabIndex = 612;
            // 
            // LblNombre
            // 
            LblNombre.BackColor = System.Drawing.SystemColors.Control;
            LblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblNombre.Location = new System.Drawing.Point(27, 14);
            LblNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new System.Drawing.Size(143, 27);
            LblNombre.TabIndex = 611;
            LblNombre.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = System.Drawing.Color.FromArgb(1, 97, 140);
            BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnCancelar.ForeColor = System.Drawing.Color.White;
            BtnCancelar.Location = new System.Drawing.Point(601, 162);
            BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(166, 62);
            BtnCancelar.TabIndex = 14;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardarCambios
            // 
            BtnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(1, 97, 140);
            BtnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnGuardarCambios.ForeColor = System.Drawing.Color.White;
            BtnGuardarCambios.Location = new System.Drawing.Point(421, 162);
            BtnGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnGuardarCambios.Name = "BtnGuardarCambios";
            BtnGuardarCambios.Size = new System.Drawing.Size(166, 62);
            BtnGuardarCambios.TabIndex = 14;
            BtnGuardarCambios.Text = "Actualizar";
            BtnGuardarCambios.UseVisualStyleBackColor = false;
            BtnGuardarCambios.Click += BtnGuardarCambios_Click;
            // 
            // Rol
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(962, 394);
            Controls.Add(PanelRegistro);
            Controls.Add(PanelEncabezado);
            Controls.Add(datalistadoRoles);
            Name = "Rol";
            Text = "Rol";
            PanelEncabezado.ResumeLayout(false);
            PanelEncabezado.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datalistadoRoles).EndInit();
            PanelRegistro.ResumeLayout(false);
            PanelRegistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelEncabezado;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView datalistadoRoles;
        private System.Windows.Forms.Panel PanelRegistro;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox LblNombre;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.CheckBox CheckRol;
        private System.Windows.Forms.Label EditandoNombreRol;
        private System.Windows.Forms.TextBox TxtRolEditando;
    }
}