namespace PuntoVenta.Modulos.Permisos
{
    partial class RolesPermisos
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
            PanelPermisos = new System.Windows.Forms.Panel();
            Descripcion = new System.Windows.Forms.RichTextBox();
            BtnGuardar = new System.Windows.Forms.Button();
            BtnSalir = new System.Windows.Forms.Button();
            ChkVer = new System.Windows.Forms.CheckBox();
            ChkEditar = new System.Windows.Forms.CheckBox();
            ChkInactivar = new System.Windows.Forms.CheckBox();
            ChkAgregar = new System.Windows.Forms.CheckBox();
            LbLModulo = new System.Windows.Forms.Label();
            ModulosCombo = new System.Windows.Forms.ComboBox();
            LbLModulos = new System.Windows.Forms.Label();
            LbLTitulo = new System.Windows.Forms.Label();
            LbLRol = new System.Windows.Forms.Label();
            RolCombo = new System.Windows.Forms.ComboBox();
            PanelPermisos.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPermisos
            // 
            PanelPermisos.Controls.Add(Descripcion);
            PanelPermisos.Controls.Add(BtnGuardar);
            PanelPermisos.Controls.Add(BtnSalir);
            PanelPermisos.Controls.Add(ChkVer);
            PanelPermisos.Controls.Add(ChkEditar);
            PanelPermisos.Controls.Add(ChkInactivar);
            PanelPermisos.Controls.Add(ChkAgregar);
            PanelPermisos.Controls.Add(LbLModulo);
            PanelPermisos.Controls.Add(ModulosCombo);
            PanelPermisos.Controls.Add(LbLModulos);
            PanelPermisos.Controls.Add(LbLTitulo);
            PanelPermisos.Controls.Add(LbLRol);
            PanelPermisos.Controls.Add(RolCombo);
            PanelPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelPermisos.Location = new System.Drawing.Point(0, 0);
            PanelPermisos.Name = "PanelPermisos";
            PanelPermisos.Size = new System.Drawing.Size(920, 397);
            PanelPermisos.TabIndex = 0;
            // 
            // Descripcion
            // 
            Descripcion.BackColor = System.Drawing.SystemColors.Menu;
            Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Descripcion.Location = new System.Drawing.Point(12, 121);
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Size = new System.Drawing.Size(391, 71);
            Descripcion.TabIndex = 12;
            Descripcion.Text = "Configure los tipos de operaciones que podra hacer el usuario segun su rol dentro del sistema";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new System.Drawing.Point(650, 351);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new System.Drawing.Size(112, 34);
            BtnGuardar.TabIndex = 11;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new System.Drawing.Point(783, 351);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new System.Drawing.Size(112, 34);
            BtnSalir.TabIndex = 10;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // ChkVer
            // 
            ChkVer.AutoSize = true;
            ChkVer.Location = new System.Drawing.Point(604, 287);
            ChkVer.Name = "ChkVer";
            ChkVer.Size = new System.Drawing.Size(63, 29);
            ChkVer.TabIndex = 9;
            ChkVer.Text = "Ver";
            ChkVer.UseVisualStyleBackColor = true;
            // 
            // ChkEditar
            // 
            ChkEditar.AutoSize = true;
            ChkEditar.Location = new System.Drawing.Point(604, 176);
            ChkEditar.Name = "ChkEditar";
            ChkEditar.Size = new System.Drawing.Size(83, 29);
            ChkEditar.TabIndex = 8;
            ChkEditar.Text = "Editar";
            ChkEditar.UseVisualStyleBackColor = true;
            // 
            // ChkInactivar
            // 
            ChkInactivar.AutoSize = true;
            ChkInactivar.Location = new System.Drawing.Point(604, 235);
            ChkInactivar.Name = "ChkInactivar";
            ChkInactivar.Size = new System.Drawing.Size(173, 29);
            ChkInactivar.TabIndex = 7;
            ChkInactivar.Text = "Eliminar/Inactivar";
            ChkInactivar.UseVisualStyleBackColor = true;
            // 
            // ChkAgregar
            // 
            ChkAgregar.AutoSize = true;
            ChkAgregar.Location = new System.Drawing.Point(604, 121);
            ChkAgregar.Name = "ChkAgregar";
            ChkAgregar.Size = new System.Drawing.Size(102, 29);
            ChkAgregar.TabIndex = 6;
            ChkAgregar.Text = "Agregar";
            ChkAgregar.UseVisualStyleBackColor = true;
            // 
            // LbLModulo
            // 
            LbLModulo.AutoSize = true;
            LbLModulo.Location = new System.Drawing.Point(604, 61);
            LbLModulo.Name = "LbLModulo";
            LbLModulo.Size = new System.Drawing.Size(79, 25);
            LbLModulo.TabIndex = 5;
            LbLModulo.Text = "Modulo:";
            // 
            // ModulosCombo
            // 
            ModulosCombo.FormattingEnabled = true;
            ModulosCombo.Location = new System.Drawing.Point(689, 53);
            ModulosCombo.Name = "ModulosCombo";
            ModulosCombo.Size = new System.Drawing.Size(182, 33);
            ModulosCombo.TabIndex = 4;
            // 
            // LbLModulos
            // 
            LbLModulos.AutoSize = true;
            LbLModulos.Location = new System.Drawing.Point(604, 9);
            LbLModulos.Name = "LbLModulos";
            LbLModulos.Size = new System.Drawing.Size(183, 25);
            LbLModulos.TabIndex = 3;
            LbLModulos.Text = "Modulos del Sistema:";
            // 
            // LbLTitulo
            // 
            LbLTitulo.AutoSize = true;
            LbLTitulo.Location = new System.Drawing.Point(12, 9);
            LbLTitulo.Name = "LbLTitulo";
            LbLTitulo.Size = new System.Drawing.Size(391, 25);
            LbLTitulo.TabIndex = 2;
            LbLTitulo.Text = "Asignacion de permisos segun el rol del usuario";
            // 
            // LbLRol
            // 
            LbLRol.AutoSize = true;
            LbLRol.Location = new System.Drawing.Point(12, 56);
            LbLRol.Name = "LbLRol";
            LbLRol.Size = new System.Drawing.Size(41, 25);
            LbLRol.TabIndex = 1;
            LbLRol.Text = "Rol:";
            // 
            // RolCombo
            // 
            RolCombo.FormattingEnabled = true;
            RolCombo.Location = new System.Drawing.Point(59, 48);
            RolCombo.Name = "RolCombo";
            RolCombo.Size = new System.Drawing.Size(182, 33);
            RolCombo.TabIndex = 0;
            // 
            // RolesPermisos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(920, 397);
            Controls.Add(PanelPermisos);
            Name = "RolesPermisos";
            Text = "Permisos ";
            PanelPermisos.ResumeLayout(false);
            PanelPermisos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelPermisos;
        private System.Windows.Forms.ComboBox RolCombo;
        private System.Windows.Forms.Label LbLRol;
        private System.Windows.Forms.Label LbLTitulo;
        private System.Windows.Forms.Label LbLModulos;
        private System.Windows.Forms.ComboBox ModulosCombo;
        private System.Windows.Forms.CheckBox ChkEditar;
        private System.Windows.Forms.CheckBox ChkInactivar;
        private System.Windows.Forms.CheckBox ChkAgregar;
        private System.Windows.Forms.Label LbLModulo;
        private System.Windows.Forms.CheckBox ChkVer;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.RichTextBox Descripcion;
    }
}