
namespace PuntoVenta.Modulos.Empleados
{
    partial class EmpleadosOk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosOk));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            PanelEncabezado = new System.Windows.Forms.Panel();
            BtnNuevo = new System.Windows.Forms.Button();
            TxtBusqueda = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            datalistado = new System.Windows.Forms.DataGridView();
            Editar = new System.Windows.Forms.DataGridViewImageColumn();
            PanelRegistro = new System.Windows.Forms.Panel();
            checkBoxActivo = new System.Windows.Forms.CheckBox();
            dateTimeFechaNac = new System.Windows.Forms.DateTimePicker();
            LblFechaNac = new System.Windows.Forms.Label();
            TxtDireccion = new System.Windows.Forms.TextBox();
            LblDireccion = new System.Windows.Forms.Label();
            groupBoxContacto = new System.Windows.Forms.GroupBox();
            TxtTelefono1 = new System.Windows.Forms.TextBox();
            LblTelefono1 = new System.Windows.Forms.Label();
            LblTelefono2 = new System.Windows.Forms.Label();
            TxtTelefono2 = new System.Windows.Forms.TextBox();
            LblCorreo = new System.Windows.Forms.Label();
            TxtCorreo = new System.Windows.Forms.TextBox();
            PanelUsuarioImagen = new System.Windows.Forms.Panel();
            BtnCancelar = new System.Windows.Forms.Button();
            BtnGuardarCambios = new System.Windows.Forms.Button();
            BtnGuardar = new System.Windows.Forms.Button();
            TxtApellidos = new System.Windows.Forms.TextBox();
            TxtNombres = new System.Windows.Forms.TextBox();
            TxtDocumento = new System.Windows.Forms.TextBox();
            LblApellidos = new System.Windows.Forms.Label();
            LblNombres = new System.Windows.Forms.Label();
            LblDocumento = new System.Windows.Forms.Label();
            PanelEncabezado.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalistado).BeginInit();
            PanelRegistro.SuspendLayout();
            groupBoxContacto.SuspendLayout();
            SuspendLayout();
            // 
            // PanelEncabezado
            // 
            PanelEncabezado.BackColor = System.Drawing.SystemColors.Control;
            PanelEncabezado.Controls.Add(BtnNuevo);
            PanelEncabezado.Controls.Add(TxtBusqueda);
            PanelEncabezado.Controls.Add(menuStrip1);
            PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            PanelEncabezado.Location = new System.Drawing.Point(0, 0);
            PanelEncabezado.Name = "PanelEncabezado";
            PanelEncabezado.Size = new System.Drawing.Size(913, 49);
            PanelEncabezado.TabIndex = 1;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = System.Drawing.Color.FromArgb(1, 97, 140);
            BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnNuevo.ForeColor = System.Drawing.Color.White;
            BtnNuevo.Location = new System.Drawing.Point(420, 5);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new System.Drawing.Size(116, 37);
            BtnNuevo.TabIndex = 8;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtBusqueda.Location = new System.Drawing.Point(39, 12);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.PlaceholderText = "Texto a buscar...";
            TxtBusqueda.Size = new System.Drawing.Size(307, 25);
            TxtBusqueda.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(338, 12);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(43, 25);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += BuscarEmpleado;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            toolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(28, 21);
            // 
            // datalistado
            // 
            datalistado.AllowUserToAddRows = false;
            datalistado.AllowUserToResizeRows = false;
            datalistado.BackgroundColor = System.Drawing.SystemColors.Control;
            datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Editar });
            datalistado.Dock = System.Windows.Forms.DockStyle.Fill;
            datalistado.Location = new System.Drawing.Point(0, 49);
            datalistado.Name = "datalistado";
            datalistado.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            datalistado.RowsDefaultCellStyle = dataGridViewCellStyle1;
            datalistado.RowTemplate.Height = 25;
            datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            datalistado.Size = new System.Drawing.Size(913, 401);
            datalistado.TabIndex = 5;
            datalistado.CellContentClick += EditarEmpleado;
            datalistado.CellDoubleClick += EditarEmpleado2;
            // 
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.Image = (System.Drawing.Image)resources.GetObject("Editar.Image");
            Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // PanelRegistro
            // 
            PanelRegistro.Controls.Add(checkBoxActivo);
            PanelRegistro.Controls.Add(dateTimeFechaNac);
            PanelRegistro.Controls.Add(LblFechaNac);
            PanelRegistro.Controls.Add(TxtDireccion);
            PanelRegistro.Controls.Add(LblDireccion);
            PanelRegistro.Controls.Add(groupBoxContacto);
            PanelRegistro.Controls.Add(PanelUsuarioImagen);
            PanelRegistro.Controls.Add(BtnCancelar);
            PanelRegistro.Controls.Add(BtnGuardarCambios);
            PanelRegistro.Controls.Add(BtnGuardar);
            PanelRegistro.Controls.Add(TxtApellidos);
            PanelRegistro.Controls.Add(TxtNombres);
            PanelRegistro.Controls.Add(TxtDocumento);
            PanelRegistro.Controls.Add(LblApellidos);
            PanelRegistro.Controls.Add(LblNombres);
            PanelRegistro.Controls.Add(LblDocumento);
            PanelRegistro.Location = new System.Drawing.Point(0, 49);
            PanelRegistro.Name = "PanelRegistro";
            PanelRegistro.Size = new System.Drawing.Size(913, 401);
            PanelRegistro.TabIndex = 6;
            PanelRegistro.Visible = false;
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            checkBoxActivo.Checked = true;
            checkBoxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            checkBoxActivo.Location = new System.Drawing.Point(741, 173);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new System.Drawing.Size(69, 19);
            checkBoxActivo.TabIndex = 22;
            checkBoxActivo.Text = "ACTIVO";
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaNac
            // 
            dateTimeFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimeFechaNac.Location = new System.Drawing.Point(159, 101);
            dateTimeFechaNac.Name = "dateTimeFechaNac";
            dateTimeFechaNac.Size = new System.Drawing.Size(200, 23);
            dateTimeFechaNac.TabIndex = 20;
            dateTimeFechaNac.Value = new System.DateTime(2023, 3, 12, 14, 32, 37, 0);
            dateTimeFechaNac.Validating += dateTimeFechaNac_Validating;
            // 
            // LblFechaNac
            // 
            LblFechaNac.AutoSize = true;
            LblFechaNac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblFechaNac.Location = new System.Drawing.Point(11, 106);
            LblFechaNac.Name = "LblFechaNac";
            LblFechaNac.Size = new System.Drawing.Size(139, 19);
            LblFechaNac.TabIndex = 19;
            LblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // TxtDireccion
            // 
            TxtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtDireccion.Location = new System.Drawing.Point(159, 133);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new System.Drawing.Size(562, 25);
            TxtDireccion.TabIndex = 18;
            // 
            // LblDireccion
            // 
            LblDireccion.AutoSize = true;
            LblDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblDireccion.Location = new System.Drawing.Point(12, 139);
            LblDireccion.Name = "LblDireccion";
            LblDireccion.Size = new System.Drawing.Size(68, 19);
            LblDireccion.TabIndex = 17;
            LblDireccion.Text = "Dirección:";
            // 
            // groupBoxContacto
            // 
            groupBoxContacto.Controls.Add(TxtTelefono1);
            groupBoxContacto.Controls.Add(LblTelefono1);
            groupBoxContacto.Controls.Add(LblTelefono2);
            groupBoxContacto.Controls.Add(TxtTelefono2);
            groupBoxContacto.Controls.Add(LblCorreo);
            groupBoxContacto.Controls.Add(TxtCorreo);
            groupBoxContacto.Location = new System.Drawing.Point(12, 182);
            groupBoxContacto.Name = "groupBoxContacto";
            groupBoxContacto.Size = new System.Drawing.Size(672, 138);
            groupBoxContacto.TabIndex = 16;
            groupBoxContacto.TabStop = false;
            groupBoxContacto.Text = "Contacto";
            // 
            // TxtTelefono1
            // 
            TxtTelefono1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtTelefono1.Location = new System.Drawing.Point(102, 22);
            TxtTelefono1.Name = "TxtTelefono1";
            TxtTelefono1.Size = new System.Drawing.Size(552, 25);
            TxtTelefono1.TabIndex = 11;
            TxtTelefono1.Validating += TxtTelefono1_Validating;
            // 
            // LblTelefono1
            // 
            LblTelefono1.AutoSize = true;
            LblTelefono1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblTelefono1.Location = new System.Drawing.Point(9, 25);
            LblTelefono1.Name = "LblTelefono1";
            LblTelefono1.Size = new System.Drawing.Size(75, 19);
            LblTelefono1.TabIndex = 4;
            LblTelefono1.Text = "Teléfono 1:";
            // 
            // LblTelefono2
            // 
            LblTelefono2.AutoSize = true;
            LblTelefono2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblTelefono2.Location = new System.Drawing.Point(10, 56);
            LblTelefono2.Name = "LblTelefono2";
            LblTelefono2.Size = new System.Drawing.Size(75, 19);
            LblTelefono2.TabIndex = 5;
            LblTelefono2.Text = "Teléfono 2:";
            // 
            // TxtTelefono2
            // 
            TxtTelefono2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtTelefono2.Location = new System.Drawing.Point(102, 53);
            TxtTelefono2.Name = "TxtTelefono2";
            TxtTelefono2.Size = new System.Drawing.Size(552, 25);
            TxtTelefono2.TabIndex = 12;
            // 
            // LblCorreo
            // 
            LblCorreo.AutoSize = true;
            LblCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblCorreo.Location = new System.Drawing.Point(9, 87);
            LblCorreo.Name = "LblCorreo";
            LblCorreo.Size = new System.Drawing.Size(54, 19);
            LblCorreo.TabIndex = 6;
            LblCorreo.Text = "Correo:";
            // 
            // TxtCorreo
            // 
            TxtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtCorreo.Location = new System.Drawing.Point(102, 84);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new System.Drawing.Size(552, 25);
            TxtCorreo.TabIndex = 13;
            TxtCorreo.Validating += TxtCorreo_Validating;
            // 
            // PanelUsuarioImagen
            // 
            PanelUsuarioImagen.BackgroundImage = (System.Drawing.Image)resources.GetObject("PanelUsuarioImagen.BackgroundImage");
            PanelUsuarioImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            PanelUsuarioImagen.Location = new System.Drawing.Point(741, 40);
            PanelUsuarioImagen.Name = "PanelUsuarioImagen";
            PanelUsuarioImagen.Size = new System.Drawing.Size(143, 106);
            PanelUsuarioImagen.TabIndex = 15;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = System.Drawing.Color.FromArgb(1, 97, 140);
            BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnCancelar.ForeColor = System.Drawing.Color.White;
            BtnCancelar.Location = new System.Drawing.Point(542, 352);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(116, 37);
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
            BtnGuardarCambios.Location = new System.Drawing.Point(420, 352);
            BtnGuardarCambios.Name = "BtnGuardarCambios";
            BtnGuardarCambios.Size = new System.Drawing.Size(116, 37);
            BtnGuardarCambios.TabIndex = 14;
            BtnGuardarCambios.Text = "Guardar";
            BtnGuardarCambios.UseVisualStyleBackColor = false;
            BtnGuardarCambios.Click += BtnGuardarCambios_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = System.Drawing.Color.FromArgb(1, 97, 140);
            BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnGuardar.ForeColor = System.Drawing.Color.White;
            BtnGuardar.Location = new System.Drawing.Point(420, 352);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new System.Drawing.Size(116, 37);
            BtnGuardar.TabIndex = 14;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // TxtApellidos
            // 
            TxtApellidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtApellidos.Location = new System.Drawing.Point(159, 39);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new System.Drawing.Size(562, 25);
            TxtApellidos.TabIndex = 9;
            TxtApellidos.Validating += TxtApellidos_Validating;
            // 
            // TxtNombres
            // 
            TxtNombres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtNombres.Location = new System.Drawing.Point(159, 9);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new System.Drawing.Size(562, 25);
            TxtNombres.TabIndex = 8;
            TxtNombres.Validating += TxtNombres_Validating;
            // 
            // TxtDocumento
            // 
            TxtDocumento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtDocumento.Location = new System.Drawing.Point(159, 69);
            TxtDocumento.Name = "TxtDocumento";
            TxtDocumento.Size = new System.Drawing.Size(562, 25);
            TxtDocumento.TabIndex = 7;
            // 
            // LblApellidos
            // 
            LblApellidos.AutoSize = true;
            LblApellidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblApellidos.Location = new System.Drawing.Point(11, 42);
            LblApellidos.Name = "LblApellidos";
            LblApellidos.Size = new System.Drawing.Size(67, 19);
            LblApellidos.TabIndex = 2;
            LblApellidos.Text = "Apellidos:";
            // 
            // LblNombres
            // 
            LblNombres.AutoSize = true;
            LblNombres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblNombres.Location = new System.Drawing.Point(11, 12);
            LblNombres.Name = "LblNombres";
            LblNombres.Size = new System.Drawing.Size(68, 19);
            LblNombres.TabIndex = 1;
            LblNombres.Text = "Nombres:";
            // 
            // LblDocumento
            // 
            LblDocumento.AutoSize = true;
            LblDocumento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblDocumento.Location = new System.Drawing.Point(11, 72);
            LblDocumento.Name = "LblDocumento";
            LblDocumento.Size = new System.Drawing.Size(135, 19);
            LblDocumento.TabIndex = 0;
            LblDocumento.Text = "Cédula de Identidad:";
            // 
            // EmpleadosOk
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(913, 450);
            Controls.Add(PanelRegistro);
            Controls.Add(datalistado);
            Controls.Add(PanelEncabezado);
            Name = "EmpleadosOk";
            Text = "Empleados";
            Load += EmpleadosOk_Load;
            PanelEncabezado.ResumeLayout(false);
            PanelEncabezado.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datalistado).EndInit();
            PanelRegistro.ResumeLayout(false);
            PanelRegistro.PerformLayout();
            groupBoxContacto.ResumeLayout(false);
            groupBoxContacto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelEncabezado;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.Panel PanelRegistro;
        private System.Windows.Forms.Panel PanelUsuarioImagen;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono2;
        private System.Windows.Forms.TextBox TxtTelefono1;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTelefono2;
        private System.Windows.Forms.Label LblTelefono1;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.GroupBox groupBoxContacto;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNac;
        private System.Windows.Forms.Label LblFechaNac;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}