
namespace PuntoVenta.Modulos.Compras
{
    partial class FacturaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelRegistro = new System.Windows.Forms.Panel();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.LblFactura = new System.Windows.Forms.Label();
            this.facturanum1 = new System.Windows.Forms.NumericUpDown();
            this.facturanum2 = new System.Windows.Forms.NumericUpDown();
            this.txtNroFact = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblFechaRec = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblFechaVenc = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.LblCuotas = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LblTimbrado = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.LblObs = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelEncabezado.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.PanelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturanum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturanum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.PanelEncabezado.Size = new System.Drawing.Size(942, 49);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistado.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistado.RowTemplate.Height = 25;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(942, 441);
            this.datalistado.TabIndex = 5;
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
            this.PanelRegistro.Controls.Add(this.dataGridView1);
            this.PanelRegistro.Controls.Add(this.textBox1);
            this.PanelRegistro.Controls.Add(this.LblObs);
            this.PanelRegistro.Controls.Add(this.numericUpDown2);
            this.PanelRegistro.Controls.Add(this.LblTimbrado);
            this.PanelRegistro.Controls.Add(this.numericUpDown1);
            this.PanelRegistro.Controls.Add(this.LblCuotas);
            this.PanelRegistro.Controls.Add(this.dateTimePicker3);
            this.PanelRegistro.Controls.Add(this.LblFechaVenc);
            this.PanelRegistro.Controls.Add(this.dateTimePicker1);
            this.PanelRegistro.Controls.Add(this.dateTimePicker2);
            this.PanelRegistro.Controls.Add(this.LblFechaRec);
            this.PanelRegistro.Controls.Add(this.LblFecha);
            this.PanelRegistro.Controls.Add(this.txtNroFact);
            this.PanelRegistro.Controls.Add(this.facturanum2);
            this.PanelRegistro.Controls.Add(this.facturanum1);
            this.PanelRegistro.Controls.Add(this.LblFactura);
            this.PanelRegistro.Controls.Add(this.cmbTipoDoc);
            this.PanelRegistro.Controls.Add(this.LblTipoDoc);
            this.PanelRegistro.Controls.Add(this.cmbProveedor);
            this.PanelRegistro.Controls.Add(this.LblProveedor);
            this.PanelRegistro.Location = new System.Drawing.Point(0, 49);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(943, 441);
            this.PanelRegistro.TabIndex = 6;
            this.PanelRegistro.TabStop = true;
            this.PanelRegistro.Visible = false;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(144, 47);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(522, 23);
            this.cmbTipoDoc.TabIndex = 13;
            // 
            // LblTipoDoc
            // 
            this.LblTipoDoc.AutoSize = true;
            this.LblTipoDoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTipoDoc.Location = new System.Drawing.Point(12, 48);
            this.LblTipoDoc.Name = "LblTipoDoc";
            this.LblTipoDoc.Size = new System.Drawing.Size(114, 19);
            this.LblTipoDoc.TabIndex = 12;
            this.LblTipoDoc.Text = "Tipo Documento:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(144, 13);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(522, 23);
            this.cmbProveedor.TabIndex = 11;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProveedor.Location = new System.Drawing.Point(12, 13);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(75, 19);
            this.LblProveedor.TabIndex = 10;
            this.LblProveedor.Text = "Proveedor:";
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFactura.Location = new System.Drawing.Point(12, 85);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(57, 19);
            this.LblFactura.TabIndex = 14;
            this.LblFactura.Text = "Factura:";
            // 
            // facturanum1
            // 
            this.facturanum1.Location = new System.Drawing.Point(144, 81);
            this.facturanum1.Name = "facturanum1";
            this.facturanum1.Size = new System.Drawing.Size(73, 23);
            this.facturanum1.TabIndex = 31;
            // 
            // facturanum2
            // 
            this.facturanum2.Location = new System.Drawing.Point(244, 81);
            this.facturanum2.Name = "facturanum2";
            this.facturanum2.Size = new System.Drawing.Size(73, 23);
            this.facturanum2.TabIndex = 32;
            // 
            // txtNroFact
            // 
            this.txtNroFact.Location = new System.Drawing.Point(338, 81);
            this.txtNroFact.Name = "txtNroFact";
            this.txtNroFact.Size = new System.Drawing.Size(152, 23);
            this.txtNroFact.TabIndex = 33;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFecha.Location = new System.Drawing.Point(12, 120);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(47, 19);
            this.LblFecha.TabIndex = 34;
            this.LblFecha.Text = "Fecha:";
            // 
            // LblFechaRec
            // 
            this.LblFechaRec.AutoSize = true;
            this.LblFechaRec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaRec.Location = new System.Drawing.Point(363, 120);
            this.LblFechaRec.Name = "LblFechaRec";
            this.LblFechaRec.Size = new System.Drawing.Size(112, 19);
            this.LblFechaRec.TabIndex = 36;
            this.LblFechaRec.Text = "Fecha Recepción:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(481, 116);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(185, 23);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 23);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // LblFechaVenc
            // 
            this.LblFechaVenc.AutoSize = true;
            this.LblFechaVenc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaVenc.Location = new System.Drawing.Point(12, 152);
            this.LblFechaVenc.Name = "LblFechaVenc";
            this.LblFechaVenc.Size = new System.Drawing.Size(126, 19);
            this.LblFechaVenc.TabIndex = 39;
            this.LblFechaVenc.Text = "Fecha Vencimiento:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(144, 152);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(185, 23);
            this.dateTimePicker3.TabIndex = 40;
            // 
            // LblCuotas
            // 
            this.LblCuotas.AutoSize = true;
            this.LblCuotas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCuotas.Location = new System.Drawing.Point(364, 156);
            this.LblCuotas.Name = "LblCuotas";
            this.LblCuotas.Size = new System.Drawing.Size(55, 19);
            this.LblCuotas.TabIndex = 41;
            this.LblCuotas.Text = "Cuotas:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(481, 152);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 23);
            this.numericUpDown1.TabIndex = 42;
            // 
            // LblTimbrado
            // 
            this.LblTimbrado.AutoSize = true;
            this.LblTimbrado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTimbrado.Location = new System.Drawing.Point(12, 190);
            this.LblTimbrado.Name = "LblTimbrado";
            this.LblTimbrado.Size = new System.Drawing.Size(70, 19);
            this.LblTimbrado.TabIndex = 43;
            this.LblTimbrado.Text = "Timbrado:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(144, 190);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(185, 23);
            this.numericUpDown2.TabIndex = 44;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblObs.Location = new System.Drawing.Point(12, 227);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(88, 19);
            this.LblObs.TabIndex = 45;
            this.LblObs.Text = "Observación:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 23);
            this.textBox1.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Cantidad,
            this.Precio,
            this.TotalLinea});
            this.dataGridView1.Location = new System.Drawing.Point(12, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(654, 150);
            this.dataGridView1.TabIndex = 47;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // TotalLinea
            // 
            this.TotalLinea.HeaderText = "Total Linea";
            this.TotalLinea.Name = "TotalLinea";
            // 
            // FacturaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 490);
            this.Controls.Add(this.PanelRegistro);
            this.Controls.Add(this.datalistado);
            this.Controls.Add(this.PanelEncabezado);
            this.Name = "FacturaCompra";
            this.Text = "FacturaCompra";
            this.Load += new System.EventHandler(this.FacturaCompra_Load);
            this.PanelEncabezado.ResumeLayout(false);
            this.PanelEncabezado.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.PanelRegistro.ResumeLayout(false);
            this.PanelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturanum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturanum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label LblTipoDoc;
        private System.Windows.Forms.Label LblFactura;
        private System.Windows.Forms.NumericUpDown facturanum1;
        private System.Windows.Forms.NumericUpDown facturanum2;
        private System.Windows.Forms.TextBox txtNroFact;
        private System.Windows.Forms.Label LblCuotas;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label LblFechaVenc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LblFechaRec;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label LblTimbrado;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLinea;
    }
}