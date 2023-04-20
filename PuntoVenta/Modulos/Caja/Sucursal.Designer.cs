
namespace PuntoVenta.Modulos.Caja
{
    partial class Sucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelRegistro = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripción = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.TextBox();
            this.PanelEncabezado.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.PanelRegistro.SuspendLayout();
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
            this.PanelEncabezado.Size = new System.Drawing.Size(731, 49);
            this.PanelEncabezado.TabIndex = 2;
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
            this.menuStrip1.Click += new System.EventHandler(this.BuscarSucursal);
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
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datalistado.RowTemplate.Height = 25;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(731, 205);
            this.datalistado.TabIndex = 6;
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarSucursal);
            this.datalistado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarSucursal2);
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
            this.PanelRegistro.Controls.Add(this.LblTelefono);
            this.PanelRegistro.Controls.Add(this.TxtTelefono);
            this.PanelRegistro.Controls.Add(this.TxtDireccion);
            this.PanelRegistro.Controls.Add(this.LblDireccion);
            this.PanelRegistro.Controls.Add(this.TxtDescripcion);
            this.PanelRegistro.Controls.Add(this.LblDescripción);
            this.PanelRegistro.Controls.Add(this.TxtCodigo);
            this.PanelRegistro.Controls.Add(this.LblCodigo);
            this.PanelRegistro.Controls.Add(this.BtnCancelar);
            this.PanelRegistro.Controls.Add(this.BtnGuardarCambios);
            this.PanelRegistro.Controls.Add(this.BtnGuardar);
            this.PanelRegistro.Location = new System.Drawing.Point(0, 49);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(731, 205);
            this.PanelRegistro.TabIndex = 8;
            this.PanelRegistro.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(555, 144);
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
            this.BtnGuardarCambios.Location = new System.Drawing.Point(433, 143);
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
            this.BtnGuardar.Location = new System.Drawing.Point(433, 144);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 37);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxActivo.Checked = true;
            this.checkBoxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxActivo.Location = new System.Drawing.Point(110, 128);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(69, 19);
            this.checkBoxActivo.TabIndex = 641;
            this.checkBoxActivo.Text = "ACTIVO";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTelefono.Location = new System.Drawing.Point(11, 100);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(63, 19);
            this.LblTelefono.TabIndex = 640;
            this.LblTelefono.Text = "Teléfono:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelefono.Location = new System.Drawing.Point(110, 97);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(562, 25);
            this.TxtTelefono.TabIndex = 639;
            this.TxtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono_Validating);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDireccion.Location = new System.Drawing.Point(110, 66);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(562, 25);
            this.TxtDireccion.TabIndex = 638;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDireccion_Validating);
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDireccion.Location = new System.Drawing.Point(11, 69);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(68, 19);
            this.LblDireccion.TabIndex = 637;
            this.LblDireccion.Text = "Dirección:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescripcion.Location = new System.Drawing.Point(110, 35);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(562, 25);
            this.TxtDescripcion.TabIndex = 636;
            this.TxtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescripcion_Validating);
            // 
            // LblDescripción
            // 
            this.LblDescripción.AutoSize = true;
            this.LblDescripción.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescripción.Location = new System.Drawing.Point(11, 38);
            this.LblDescripción.Name = "LblDescripción";
            this.LblDescripción.Size = new System.Drawing.Size(82, 19);
            this.LblDescripción.TabIndex = 635;
            this.LblDescripción.Text = "Descripción:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(110, 6);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(562, 23);
            this.TxtCodigo.TabIndex = 634;
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            // 
            // LblCodigo
            // 
            this.LblCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LblCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCodigo.Location = new System.Drawing.Point(15, 6);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(78, 18);
            this.LblCodigo.TabIndex = 633;
            this.LblCodigo.Text = "Código:";
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 254);
            this.Controls.Add(this.PanelRegistro);
            this.Controls.Add(this.datalistado);
            this.Controls.Add(this.PanelEncabezado);
            this.Name = "Sucursal";
            this.Text = "Sucursal";
            this.Load += new System.EventHandler(this.Sucursal_Load);
            this.PanelEncabezado.ResumeLayout(false);
            this.PanelEncabezado.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.PanelRegistro.ResumeLayout(false);
            this.PanelRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEncabezado;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Panel PanelRegistro;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripción;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox LblCodigo;
    }
}