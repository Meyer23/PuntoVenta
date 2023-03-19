namespace PuntoVenta.Modulos.Usuarios_Ok
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            PanelBusquedaUsuario = new System.Windows.Forms.Panel();
            BtnAgregarUsuario = new System.Windows.Forms.Button();
            BtnBuscarUsuario = new System.Windows.Forms.Button();
            TextBoxBusquedaUsuario = new System.Windows.Forms.TextBox();
            LabelBusquedaUsuario = new System.Windows.Forms.Label();
            DataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            EditarU = new System.Windows.Forms.DataGridViewImageColumn();
            PanelBuscarEmpleado = new System.Windows.Forms.Panel();
            TxtUsuarioEditando = new System.Windows.Forms.TextBox();
            LabelEditarUsuario = new System.Windows.Forms.Label();
            BtnGuardarEditado = new System.Windows.Forms.Button();
            CheckActivo = new System.Windows.Forms.CheckBox();
            BntCancelar = new System.Windows.Forms.Button();
            BtnAgregarNuevo = new System.Windows.Forms.Button();
            ComboBoxRol = new System.Windows.Forms.ComboBox();
            TxtRePassword = new System.Windows.Forms.TextBox();
            TxtPassword = new System.Windows.Forms.TextBox();
            LabelRol = new System.Windows.Forms.Label();
            LabelRePassword = new System.Windows.Forms.Label();
            LabelPassword = new System.Windows.Forms.Label();
            BtnBuscarEmpleado = new System.Windows.Forms.Button();
            LabelBuscarEmpleado = new System.Windows.Forms.Label();
            TextBoxBuscarEmpleado = new System.Windows.Forms.TextBox();
            DataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            AgregarNuevo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            PanelBusquedaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsuarios).BeginInit();
            PanelBuscarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmpleados).BeginInit();
            SuspendLayout();
            // 
            // PanelBusquedaUsuario
            // 
            PanelBusquedaUsuario.Controls.Add(BtnAgregarUsuario);
            PanelBusquedaUsuario.Controls.Add(BtnBuscarUsuario);
            PanelBusquedaUsuario.Controls.Add(TextBoxBusquedaUsuario);
            PanelBusquedaUsuario.Controls.Add(LabelBusquedaUsuario);
            PanelBusquedaUsuario.Controls.Add(DataGridViewUsuarios);
            PanelBusquedaUsuario.Location = new System.Drawing.Point(3, 12);
            PanelBusquedaUsuario.Name = "PanelBusquedaUsuario";
            PanelBusquedaUsuario.Size = new System.Drawing.Size(955, 562);
            PanelBusquedaUsuario.TabIndex = 0;
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.Location = new System.Drawing.Point(639, 27);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new System.Drawing.Size(107, 31);
            BtnAgregarUsuario.TabIndex = 3;
            BtnAgregarUsuario.Text = "Nuevo";
            BtnAgregarUsuario.UseVisualStyleBackColor = true;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            // 
            // BtnBuscarUsuario
            // 
            BtnBuscarUsuario.Location = new System.Drawing.Point(512, 27);
            BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            BtnBuscarUsuario.Size = new System.Drawing.Size(107, 31);
            BtnBuscarUsuario.TabIndex = 2;
            BtnBuscarUsuario.Text = "Buscar";
            BtnBuscarUsuario.UseVisualStyleBackColor = true;
            BtnBuscarUsuario.Click += BtnBuscarUsuario_Click;
            // 
            // TextBoxBusquedaUsuario
            // 
            TextBoxBusquedaUsuario.Location = new System.Drawing.Point(171, 27);
            TextBoxBusquedaUsuario.Name = "TextBoxBusquedaUsuario";
            TextBoxBusquedaUsuario.Size = new System.Drawing.Size(323, 31);
            TextBoxBusquedaUsuario.TabIndex = 1;
            // 
            // LabelBusquedaUsuario
            // 
            LabelBusquedaUsuario.AutoSize = true;
            LabelBusquedaUsuario.Location = new System.Drawing.Point(33, 33);
            LabelBusquedaUsuario.Name = "LabelBusquedaUsuario";
            LabelBusquedaUsuario.Size = new System.Drawing.Size(132, 25);
            LabelBusquedaUsuario.TabIndex = 0;
            LabelBusquedaUsuario.Text = "Buscar Usuario:";
            // 
            // DataGridViewUsuarios
            // 
            DataGridViewUsuarios.AllowUserToAddRows = false;
            DataGridViewUsuarios.AllowUserToDeleteRows = false;
            DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { EditarU });
            DataGridViewUsuarios.Location = new System.Drawing.Point(33, 61);
            DataGridViewUsuarios.Name = "DataGridViewUsuarios";
            DataGridViewUsuarios.ReadOnly = true;
            DataGridViewUsuarios.RowHeadersWidth = 62;
            DataGridViewUsuarios.RowTemplate.Height = 33;
            DataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DataGridViewUsuarios.Size = new System.Drawing.Size(831, 239);
            DataGridViewUsuarios.TabIndex = 1;
            DataGridViewUsuarios.CellContentDoubleClick += EditarUsuario;
            // 
            // EditarU
            // 
            EditarU.HeaderText = "Editar";
            EditarU.Image = (System.Drawing.Image)resources.GetObject("EditarU.Image");
            EditarU.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            EditarU.MinimumWidth = 8;
            EditarU.Name = "EditarU";
            EditarU.ReadOnly = true;
            EditarU.Width = 150;
            // 
            // PanelBuscarEmpleado
            // 
            PanelBuscarEmpleado.Controls.Add(TxtUsuarioEditando);
            PanelBuscarEmpleado.Controls.Add(LabelEditarUsuario);
            PanelBuscarEmpleado.Controls.Add(BtnGuardarEditado);
            PanelBuscarEmpleado.Controls.Add(CheckActivo);
            PanelBuscarEmpleado.Controls.Add(BntCancelar);
            PanelBuscarEmpleado.Controls.Add(BtnAgregarNuevo);
            PanelBuscarEmpleado.Controls.Add(ComboBoxRol);
            PanelBuscarEmpleado.Controls.Add(TxtRePassword);
            PanelBuscarEmpleado.Controls.Add(TxtPassword);
            PanelBuscarEmpleado.Controls.Add(LabelRol);
            PanelBuscarEmpleado.Controls.Add(LabelRePassword);
            PanelBuscarEmpleado.Controls.Add(LabelPassword);
            PanelBuscarEmpleado.Controls.Add(BtnBuscarEmpleado);
            PanelBuscarEmpleado.Controls.Add(LabelBuscarEmpleado);
            PanelBuscarEmpleado.Controls.Add(TextBoxBuscarEmpleado);
            PanelBuscarEmpleado.Controls.Add(DataGridViewEmpleados);
            PanelBuscarEmpleado.Location = new System.Drawing.Point(0, 12);
            PanelBuscarEmpleado.Name = "PanelBuscarEmpleado";
            PanelBuscarEmpleado.Size = new System.Drawing.Size(955, 562);
            PanelBuscarEmpleado.TabIndex = 2;
            // 
            // TxtUsuarioEditando
            // 
            TxtUsuarioEditando.Location = new System.Drawing.Point(174, 188);
            TxtUsuarioEditando.Name = "TxtUsuarioEditando";
            TxtUsuarioEditando.Size = new System.Drawing.Size(233, 31);
            TxtUsuarioEditando.TabIndex = 18;
            TxtUsuarioEditando.Visible = false;
            // 
            // LabelEditarUsuario
            // 
            LabelEditarUsuario.AutoSize = true;
            LabelEditarUsuario.Location = new System.Drawing.Point(33, 191);
            LabelEditarUsuario.Name = "LabelEditarUsuario";
            LabelEditarUsuario.Size = new System.Drawing.Size(122, 25);
            LabelEditarUsuario.TabIndex = 17;
            LabelEditarUsuario.Text = "Editar Usuario";
            LabelEditarUsuario.Visible = false;
            // 
            // BtnGuardarEditado
            // 
            BtnGuardarEditado.Location = new System.Drawing.Point(432, 479);
            BtnGuardarEditado.Name = "BtnGuardarEditado";
            BtnGuardarEditado.Size = new System.Drawing.Size(187, 31);
            BtnGuardarEditado.TabIndex = 16;
            BtnGuardarEditado.Text = "Guardar Cambios";
            BtnGuardarEditado.UseVisualStyleBackColor = true;
            BtnGuardarEditado.Click += BtnGuardarEditado_Click;
            // 
            // CheckActivo
            // 
            CheckActivo.AutoSize = true;
            CheckActivo.Checked = true;
            CheckActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckActivo.Location = new System.Drawing.Point(228, 443);
            CheckActivo.Name = "CheckActivo";
            CheckActivo.Size = new System.Drawing.Size(88, 29);
            CheckActivo.TabIndex = 15;
            CheckActivo.Text = "Activo";
            CheckActivo.UseVisualStyleBackColor = true;
            // 
            // BntCancelar
            // 
            BntCancelar.Location = new System.Drawing.Point(642, 479);
            BntCancelar.Name = "BntCancelar";
            BntCancelar.Size = new System.Drawing.Size(107, 31);
            BntCancelar.TabIndex = 14;
            BntCancelar.Text = "Cancelar";
            BntCancelar.UseVisualStyleBackColor = true;
            BntCancelar.Click += BntCancelar_Click;
            // 
            // BtnAgregarNuevo
            // 
            BtnAgregarNuevo.Location = new System.Drawing.Point(512, 479);
            BtnAgregarNuevo.Name = "BtnAgregarNuevo";
            BtnAgregarNuevo.Size = new System.Drawing.Size(107, 31);
            BtnAgregarNuevo.TabIndex = 13;
            BtnAgregarNuevo.Text = "Agregar";
            BtnAgregarNuevo.UseVisualStyleBackColor = true;
            BtnAgregarNuevo.Click += BtnAgregarNuevo_Click;
            // 
            // ComboBoxRol
            // 
            ComboBoxRol.FormattingEnabled = true;
            ComboBoxRol.Location = new System.Drawing.Point(228, 371);
            ComboBoxRol.Name = "ComboBoxRol";
            ComboBoxRol.Size = new System.Drawing.Size(258, 33);
            ComboBoxRol.TabIndex = 12;
            // 
            // TxtRePassword
            // 
            TxtRePassword.Location = new System.Drawing.Point(228, 318);
            TxtRePassword.Name = "TxtRePassword";
            TxtRePassword.Size = new System.Drawing.Size(258, 31);
            TxtRePassword.TabIndex = 11;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new System.Drawing.Point(228, 269);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new System.Drawing.Size(258, 31);
            TxtPassword.TabIndex = 10;
            TxtPassword.Validating += TxtPassword_Validating;
            // 
            // LabelRol
            // 
            LabelRol.AutoSize = true;
            LabelRol.Location = new System.Drawing.Point(181, 379);
            LabelRol.Name = "LabelRol";
            LabelRol.Size = new System.Drawing.Size(41, 25);
            LabelRol.TabIndex = 9;
            LabelRol.Text = "Rol:";
            // 
            // LabelRePassword
            // 
            LabelRePassword.AutoSize = true;
            LabelRePassword.Location = new System.Drawing.Point(33, 324);
            LabelRePassword.Name = "LabelRePassword";
            LabelRePassword.Size = new System.Drawing.Size(189, 25);
            LabelRePassword.TabIndex = 8;
            LabelRePassword.Text = "Confirmar Contraseña:";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new System.Drawing.Point(117, 275);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new System.Drawing.Size(105, 25);
            LabelPassword.TabIndex = 7;
            LabelPassword.Text = "Contraseña:";
            // 
            // BtnBuscarEmpleado
            // 
            BtnBuscarEmpleado.Location = new System.Drawing.Point(512, 44);
            BtnBuscarEmpleado.Name = "BtnBuscarEmpleado";
            BtnBuscarEmpleado.Size = new System.Drawing.Size(107, 31);
            BtnBuscarEmpleado.TabIndex = 4;
            BtnBuscarEmpleado.Text = "Buscar";
            BtnBuscarEmpleado.UseVisualStyleBackColor = true;
            BtnBuscarEmpleado.Click += BtnBuscarEmpleado_Click;
            // 
            // LabelBuscarEmpleado
            // 
            LabelBuscarEmpleado.AutoSize = true;
            LabelBuscarEmpleado.Location = new System.Drawing.Point(33, 50);
            LabelBuscarEmpleado.Name = "LabelBuscarEmpleado";
            LabelBuscarEmpleado.Size = new System.Drawing.Size(152, 25);
            LabelBuscarEmpleado.TabIndex = 3;
            LabelBuscarEmpleado.Text = "Buscar Empleado:";
            // 
            // TextBoxBuscarEmpleado
            // 
            TextBoxBuscarEmpleado.Location = new System.Drawing.Point(191, 44);
            TextBoxBuscarEmpleado.Name = "TextBoxBuscarEmpleado";
            TextBoxBuscarEmpleado.Size = new System.Drawing.Size(303, 31);
            TextBoxBuscarEmpleado.TabIndex = 2;
            // 
            // DataGridViewEmpleados
            // 
            DataGridViewEmpleados.AllowUserToAddRows = false;
            DataGridViewEmpleados.AllowUserToDeleteRows = false;
            DataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { AgregarNuevo });
            DataGridViewEmpleados.Location = new System.Drawing.Point(33, 99);
            DataGridViewEmpleados.Name = "DataGridViewEmpleados";
            DataGridViewEmpleados.RowHeadersWidth = 62;
            DataGridViewEmpleados.RowTemplate.Height = 33;
            DataGridViewEmpleados.Size = new System.Drawing.Size(666, 151);
            DataGridViewEmpleados.TabIndex = 5;
            // 
            // AgregarNuevo
            // 
            AgregarNuevo.HeaderText = "Agregar";
            AgregarNuevo.MinimumWidth = 8;
            AgregarNuevo.Name = "AgregarNuevo";
            AgregarNuevo.Width = 150;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(963, 647);
            Controls.Add(PanelBusquedaUsuario);
            Controls.Add(PanelBuscarEmpleado);
            Name = "Usuarios";
            Text = "Usuarios";
            PanelBusquedaUsuario.ResumeLayout(false);
            PanelBusquedaUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsuarios).EndInit();
            PanelBuscarEmpleado.ResumeLayout(false);
            PanelBuscarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelBusquedaUsuario;
        private System.Windows.Forms.Button BtnAgregarUsuario;
        private System.Windows.Forms.Button BtnBuscarUsuario;
        private System.Windows.Forms.TextBox TextBoxBusquedaUsuario;
        private System.Windows.Forms.Label LabelBusquedaUsuario;
        private System.Windows.Forms.DataGridView DataGridViewUsuarios;
        private System.Windows.Forms.Panel PanelBuscarEmpleado;
        private System.Windows.Forms.Label LabelBuscarEmpleado;
        private System.Windows.Forms.TextBox TextBoxBuscarEmpleado;
        private System.Windows.Forms.Button BtnBuscarEmpleado;
        private System.Windows.Forms.DataGridView DataGridViewEmpleados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AgregarNuevo;
        private System.Windows.Forms.ComboBox ComboBoxRol;
        private System.Windows.Forms.TextBox TxtRePassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LabelRol;
        private System.Windows.Forms.Label LabelRePassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BtnAgregarNuevo;
        private System.Windows.Forms.CheckBox CheckActivo;
        private System.Windows.Forms.Button BtnGuardarEditado;
        private System.Windows.Forms.Label LabelEditarUsuario;
        private System.Windows.Forms.DataGridViewImageColumn EditarU;
        private System.Windows.Forms.TextBox TxtUsuarioEditando;
    }
}