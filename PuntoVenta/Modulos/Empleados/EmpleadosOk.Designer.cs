
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelRegistro = new System.Windows.Forms.Panel();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.dateTimeFechaNac = new System.Windows.Forms.DateTimePicker();
            this.LblFechaNac = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.groupBoxContacto = new System.Windows.Forms.GroupBox();
            this.TxtTelefono1 = new System.Windows.Forms.TextBox();
            this.LblTelefono1 = new System.Windows.Forms.Label();
            this.LblTelefono2 = new System.Windows.Forms.Label();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.PanelUsuarioImagen = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.PanelEncabezado.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.PanelRegistro.SuspendLayout();
            this.groupBoxContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEncabezado
            // 
            this.PanelEncabezado.BackColor = System.Drawing.SystemColors.Control;
            this.PanelEncabezado.Controls.Add(this.BtnNuevo);
            this.PanelEncabezado.Controls.Add(this.TxtBusqueda);
            this.PanelEncabezado.Controls.Add(this.menuStrip1);
            this.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.PanelEncabezado.Name = "PanelEncabezado";
            this.PanelEncabezado.Size = new System.Drawing.Size(913, 49);
            this.PanelEncabezado.TabIndex = 1;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(420, 5);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(116, 37);
            this.BtnNuevo.TabIndex = 8;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBusqueda.Location = new System.Drawing.Point(39, 12);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.PlaceholderText = "Texto a buscar...";
            this.TxtBusqueda.Size = new System.Drawing.Size(307, 25);
            this.TxtBusqueda.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(338, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(43, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BuscarEmpleado);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 21);
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToResizeRows = false;
            this.datalistado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.datalistado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistado.Location = new System.Drawing.Point(0, 49);
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datalistado.RowTemplate.Height = 25;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(913, 401);
            this.datalistado.TabIndex = 5;
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarEmpleado);
            this.datalistado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarEmpleado2);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // PanelRegistro
            // 
            this.PanelRegistro.Controls.Add(this.checkBoxActivo);
            this.PanelRegistro.Controls.Add(this.dateTimeFechaNac);
            this.PanelRegistro.Controls.Add(this.LblFechaNac);
            this.PanelRegistro.Controls.Add(this.TxtDireccion);
            this.PanelRegistro.Controls.Add(this.LblDireccion);
            this.PanelRegistro.Controls.Add(this.groupBoxContacto);
            this.PanelRegistro.Controls.Add(this.PanelUsuarioImagen);
            this.PanelRegistro.Controls.Add(this.BtnCancelar);
            this.PanelRegistro.Controls.Add(this.BtnGuardarCambios);
            this.PanelRegistro.Controls.Add(this.BtnGuardar);
            this.PanelRegistro.Controls.Add(this.TxtApellidos);
            this.PanelRegistro.Controls.Add(this.TxtNombres);
            this.PanelRegistro.Controls.Add(this.TxtDocumento);
            this.PanelRegistro.Controls.Add(this.LblApellidos);
            this.PanelRegistro.Controls.Add(this.LblNombres);
            this.PanelRegistro.Controls.Add(this.LblDocumento);
            this.PanelRegistro.Location = new System.Drawing.Point(0, 49);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(913, 401);
            this.PanelRegistro.TabIndex = 6;
            this.PanelRegistro.Visible = false;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxActivo.Checked = true;
            this.checkBoxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxActivo.Location = new System.Drawing.Point(741, 173);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(69, 19);
            this.checkBoxActivo.TabIndex = 22;
            this.checkBoxActivo.Text = "ACTIVO";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaNac
            // 
            this.dateTimeFechaNac.Location = new System.Drawing.Point(159, 101);
            this.dateTimeFechaNac.Name = "dateTimeFechaNac";
            this.dateTimeFechaNac.Size = new System.Drawing.Size(200, 23);
            this.dateTimeFechaNac.TabIndex = 20;
            this.dateTimeFechaNac.Value = new System.DateTime(2023, 3, 12, 14, 32, 37, 0);
            this.dateTimeFechaNac.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeFechaNac_Validating);
            // 
            // LblFechaNac
            // 
            this.LblFechaNac.AutoSize = true;
            this.LblFechaNac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaNac.Location = new System.Drawing.Point(11, 106);
            this.LblFechaNac.Name = "LblFechaNac";
            this.LblFechaNac.Size = new System.Drawing.Size(139, 19);
            this.LblFechaNac.TabIndex = 19;
            this.LblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDireccion.Location = new System.Drawing.Point(159, 133);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(562, 25);
            this.TxtDireccion.TabIndex = 18;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDireccion.Location = new System.Drawing.Point(12, 139);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(68, 19);
            this.LblDireccion.TabIndex = 17;
            this.LblDireccion.Text = "Dirección:";
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.Controls.Add(this.TxtTelefono1);
            this.groupBoxContacto.Controls.Add(this.LblTelefono1);
            this.groupBoxContacto.Controls.Add(this.LblTelefono2);
            this.groupBoxContacto.Controls.Add(this.TxtTelefono2);
            this.groupBoxContacto.Controls.Add(this.LblCorreo);
            this.groupBoxContacto.Controls.Add(this.TxtCorreo);
            this.groupBoxContacto.Location = new System.Drawing.Point(12, 182);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Size = new System.Drawing.Size(672, 138);
            this.groupBoxContacto.TabIndex = 16;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "Contacto";
            // 
            // TxtTelefono1
            // 
            this.TxtTelefono1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelefono1.Location = new System.Drawing.Point(102, 22);
            this.TxtTelefono1.Name = "TxtTelefono1";
            this.TxtTelefono1.Size = new System.Drawing.Size(552, 25);
            this.TxtTelefono1.TabIndex = 11;
            this.TxtTelefono1.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono1_Validating);
            // 
            // LblTelefono1
            // 
            this.LblTelefono1.AutoSize = true;
            this.LblTelefono1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTelefono1.Location = new System.Drawing.Point(9, 25);
            this.LblTelefono1.Name = "LblTelefono1";
            this.LblTelefono1.Size = new System.Drawing.Size(75, 19);
            this.LblTelefono1.TabIndex = 4;
            this.LblTelefono1.Text = "Teléfono 1:";
            // 
            // LblTelefono2
            // 
            this.LblTelefono2.AutoSize = true;
            this.LblTelefono2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTelefono2.Location = new System.Drawing.Point(10, 56);
            this.LblTelefono2.Name = "LblTelefono2";
            this.LblTelefono2.Size = new System.Drawing.Size(75, 19);
            this.LblTelefono2.TabIndex = 5;
            this.LblTelefono2.Text = "Teléfono 2:";
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelefono2.Location = new System.Drawing.Point(102, 53);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(552, 25);
            this.TxtTelefono2.TabIndex = 12;
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCorreo.Location = new System.Drawing.Point(9, 87);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(54, 19);
            this.LblCorreo.TabIndex = 6;
            this.LblCorreo.Text = "Correo:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCorreo.Location = new System.Drawing.Point(102, 84);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(552, 25);
            this.TxtCorreo.TabIndex = 13;
            this.TxtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCorreo_Validating);
            // 
            // PanelUsuarioImagen
            // 
            this.PanelUsuarioImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUsuarioImagen.BackgroundImage")));
            this.PanelUsuarioImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelUsuarioImagen.Location = new System.Drawing.Point(741, 40);
            this.PanelUsuarioImagen.Name = "PanelUsuarioImagen";
            this.PanelUsuarioImagen.Size = new System.Drawing.Size(143, 106);
            this.PanelUsuarioImagen.TabIndex = 15;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(542, 352);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 37);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCambios.Location = new System.Drawing.Point(420, 352);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(116, 37);
            this.BtnGuardarCambios.TabIndex = 14;
            this.BtnGuardarCambios.Text = "Guardar";
            this.BtnGuardarCambios.UseVisualStyleBackColor = false;
            this.BtnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(420, 352);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 37);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellidos.Location = new System.Drawing.Point(159, 39);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(562, 25);
            this.TxtApellidos.TabIndex = 9;
            this.TxtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellidos_Validating);
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombres.Location = new System.Drawing.Point(159, 9);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(562, 25);
            this.TxtNombres.TabIndex = 8;
            this.TxtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombres_Validating);
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDocumento.Location = new System.Drawing.Point(159, 69);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(562, 25);
            this.TxtDocumento.TabIndex = 7;
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblApellidos.Location = new System.Drawing.Point(11, 42);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(67, 19);
            this.LblApellidos.TabIndex = 2;
            this.LblApellidos.Text = "Apellidos:";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombres.Location = new System.Drawing.Point(11, 12);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(68, 19);
            this.LblNombres.TabIndex = 1;
            this.LblNombres.Text = "Nombres:";
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDocumento.Location = new System.Drawing.Point(11, 72);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(135, 19);
            this.LblDocumento.TabIndex = 0;
            this.LblDocumento.Text = "Cédula de Identidad:";
            // 
            // EmpleadosOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.PanelRegistro);
            this.Controls.Add(this.datalistado);
            this.Controls.Add(this.PanelEncabezado);
            this.Name = "EmpleadosOk";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.EmpleadosOk_Load);
            this.PanelEncabezado.ResumeLayout(false);
            this.PanelEncabezado.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.PanelRegistro.ResumeLayout(false);
            this.PanelRegistro.PerformLayout();
            this.groupBoxContacto.ResumeLayout(false);
            this.groupBoxContacto.PerformLayout();
            this.ResumeLayout(false);

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