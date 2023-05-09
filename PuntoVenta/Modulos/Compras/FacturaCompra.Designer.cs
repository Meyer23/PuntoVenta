
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelRegistro = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTimbrado = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.LblProd = new System.Windows.Forms.Label();
            this.TxtProd = new System.Windows.Forms.TextBox();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.LblTimbrado = new System.Windows.Forms.Label();
            this.LblCuotas = new System.Windows.Forms.Label();
            this.FechaVenc = new System.Windows.Forms.DateTimePicker();
            this.LblFechaVenc = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.FechaRec = new System.Windows.Forms.DateTimePicker();
            this.LblFechaRec = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.txtNroFact = new System.Windows.Forms.TextBox();
            this.LblFactura = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.txtPE = new System.Windows.Forms.TextBox();
            this.txtCodEst = new System.Windows.Forms.TextBox();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.PanelEncabezado.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.PanelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
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
            this.menuStrip1.Click += new System.EventHandler(this.BuscarCompra);
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
            this.datalistado.Size = new System.Drawing.Size(942, 570);
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
            this.PanelRegistro.Controls.Add(this.BtnCancelar);
            this.PanelRegistro.Controls.Add(this.txtCuotas);
            this.PanelRegistro.Controls.Add(this.txtCodEst);
            this.PanelRegistro.Controls.Add(this.txtPE);
            this.PanelRegistro.Controls.Add(this.cmbSucursal);
            this.PanelRegistro.Controls.Add(this.lblSucursal);
            this.PanelRegistro.Controls.Add(this.btnProcesar);
            this.PanelRegistro.Controls.Add(this.btnEliminar);
            this.PanelRegistro.Controls.Add(this.lblTotal);
            this.PanelRegistro.Controls.Add(this.txtTotal);
            this.PanelRegistro.Controls.Add(this.txtTimbrado);
            this.PanelRegistro.Controls.Add(this.txtPrecio);
            this.PanelRegistro.Controls.Add(this.txtCant);
            this.PanelRegistro.Controls.Add(this.btnAgregar);
            this.PanelRegistro.Controls.Add(this.LblProd);
            this.PanelRegistro.Controls.Add(this.TxtProd);
            this.PanelRegistro.Controls.Add(this.dataGridProductos);
            this.PanelRegistro.Controls.Add(this.txtObs);
            this.PanelRegistro.Controls.Add(this.LblObs);
            this.PanelRegistro.Controls.Add(this.LblTimbrado);
            this.PanelRegistro.Controls.Add(this.LblCuotas);
            this.PanelRegistro.Controls.Add(this.FechaVenc);
            this.PanelRegistro.Controls.Add(this.LblFechaVenc);
            this.PanelRegistro.Controls.Add(this.Fecha);
            this.PanelRegistro.Controls.Add(this.FechaRec);
            this.PanelRegistro.Controls.Add(this.LblFechaRec);
            this.PanelRegistro.Controls.Add(this.LblFecha);
            this.PanelRegistro.Controls.Add(this.txtNroFact);
            this.PanelRegistro.Controls.Add(this.LblFactura);
            this.PanelRegistro.Controls.Add(this.cmbTipoDoc);
            this.PanelRegistro.Controls.Add(this.LblTipoDoc);
            this.PanelRegistro.Controls.Add(this.cmbProveedor);
            this.PanelRegistro.Controls.Add(this.LblProveedor);
            this.PanelRegistro.Location = new System.Drawing.Point(0, 49);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(943, 570);
            this.PanelRegistro.TabIndex = 6;
            this.PanelRegistro.TabStop = true;
            this.PanelRegistro.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(790, 345);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 37);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(556, 528);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 19);
            this.lblTotal.TabIndex = 58;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(621, 527);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(114, 23);
            this.txtTotal.TabIndex = 57;
            // 
            // txtTimbrado
            // 
            this.txtTimbrado.Location = new System.Drawing.Point(144, 211);
            this.txtTimbrado.Name = "txtTimbrado";
            this.txtTimbrado.Size = new System.Drawing.Size(185, 23);
            this.txtTimbrado.TabIndex = 56;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(352, 306);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(114, 23);
            this.txtPrecio.TabIndex = 55;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(273, 306);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(73, 23);
            this.txtCant.TabIndex = 54;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(481, 300);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 37);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // LblProd
            // 
            this.LblProd.AutoSize = true;
            this.LblProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProd.Location = new System.Drawing.Point(12, 306);
            this.LblProd.Name = "LblProd";
            this.LblProd.Size = new System.Drawing.Size(68, 19);
            this.LblProd.TabIndex = 49;
            this.LblProd.Text = "Producto:";
            // 
            // TxtProd
            // 
            this.TxtProd.Location = new System.Drawing.Point(144, 306);
            this.TxtProd.Name = "TxtProd";
            this.TxtProd.Size = new System.Drawing.Size(120, 23);
            this.TxtProd.TabIndex = 48;
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToAddRows = false;
            this.dataGridProductos.AllowUserToDeleteRows = false;
            this.dataGridProductos.AllowUserToResizeColumns = false;
            this.dataGridProductos.AllowUserToResizeRows = false;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(12, 345);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.ReadOnly = true;
            this.dataGridProductos.RowTemplate.Height = 25;
            this.dataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProductos.Size = new System.Drawing.Size(723, 150);
            this.dataGridProductos.TabIndex = 47;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(144, 252);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(522, 23);
            this.txtObs.TabIndex = 46;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblObs.Location = new System.Drawing.Point(12, 252);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(88, 19);
            this.LblObs.TabIndex = 45;
            this.LblObs.Text = "Observación:";
            // 
            // LblTimbrado
            // 
            this.LblTimbrado.AutoSize = true;
            this.LblTimbrado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTimbrado.Location = new System.Drawing.Point(12, 215);
            this.LblTimbrado.Name = "LblTimbrado";
            this.LblTimbrado.Size = new System.Drawing.Size(70, 19);
            this.LblTimbrado.TabIndex = 43;
            this.LblTimbrado.Text = "Timbrado:";
            // 
            // LblCuotas
            // 
            this.LblCuotas.AutoSize = true;
            this.LblCuotas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCuotas.Location = new System.Drawing.Point(364, 181);
            this.LblCuotas.Name = "LblCuotas";
            this.LblCuotas.Size = new System.Drawing.Size(55, 19);
            this.LblCuotas.TabIndex = 41;
            this.LblCuotas.Text = "Cuotas:";
            // 
            // FechaVenc
            // 
            this.FechaVenc.Location = new System.Drawing.Point(144, 177);
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.Size = new System.Drawing.Size(185, 23);
            this.FechaVenc.TabIndex = 40;
            // 
            // LblFechaVenc
            // 
            this.LblFechaVenc.AutoSize = true;
            this.LblFechaVenc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaVenc.Location = new System.Drawing.Point(12, 177);
            this.LblFechaVenc.Name = "LblFechaVenc";
            this.LblFechaVenc.Size = new System.Drawing.Size(126, 19);
            this.LblFechaVenc.TabIndex = 39;
            this.LblFechaVenc.Text = "Fecha Vencimiento:";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(144, 141);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(185, 23);
            this.Fecha.TabIndex = 38;
            // 
            // FechaRec
            // 
            this.FechaRec.Location = new System.Drawing.Point(481, 141);
            this.FechaRec.Name = "FechaRec";
            this.FechaRec.Size = new System.Drawing.Size(185, 23);
            this.FechaRec.TabIndex = 37;
            // 
            // LblFechaRec
            // 
            this.LblFechaRec.AutoSize = true;
            this.LblFechaRec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaRec.Location = new System.Drawing.Point(363, 145);
            this.LblFechaRec.Name = "LblFechaRec";
            this.LblFechaRec.Size = new System.Drawing.Size(112, 19);
            this.LblFechaRec.TabIndex = 36;
            this.LblFechaRec.Text = "Fecha Recepción:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFecha.Location = new System.Drawing.Point(12, 145);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(47, 19);
            this.LblFecha.TabIndex = 34;
            this.LblFecha.Text = "Fecha:";
            // 
            // txtNroFact
            // 
            this.txtNroFact.Location = new System.Drawing.Point(338, 106);
            this.txtNroFact.Name = "txtNroFact";
            this.txtNroFact.Size = new System.Drawing.Size(152, 23);
            this.txtNroFact.TabIndex = 33;
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFactura.Location = new System.Drawing.Point(12, 110);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(57, 19);
            this.LblFactura.TabIndex = 14;
            this.LblFactura.Text = "Factura:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(144, 72);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(522, 23);
            this.cmbTipoDoc.TabIndex = 13;
            // 
            // LblTipoDoc
            // 
            this.LblTipoDoc.AutoSize = true;
            this.LblTipoDoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTipoDoc.Location = new System.Drawing.Point(12, 73);
            this.LblTipoDoc.Name = "LblTipoDoc";
            this.LblTipoDoc.Size = new System.Drawing.Size(114, 19);
            this.LblTipoDoc.TabIndex = 12;
            this.LblTipoDoc.Text = "Tipo Documento:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(144, 38);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(522, 23);
            this.cmbProveedor.TabIndex = 11;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProveedor.Location = new System.Drawing.Point(12, 38);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(75, 19);
            this.LblProveedor.TabIndex = 10;
            this.LblProveedor.Text = "Proveedor:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(790, 403);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(116, 37);
            this.btnProcesar.TabIndex = 60;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSucursal.Location = new System.Drawing.Point(12, 3);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(62, 19);
            this.lblSucursal.TabIndex = 61;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(144, 6);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(522, 23);
            this.cmbSucursal.TabIndex = 62;
            // 
            // txtPE
            // 
            this.txtPE.Location = new System.Drawing.Point(238, 106);
            this.txtPE.Name = "txtPE";
            this.txtPE.Size = new System.Drawing.Size(79, 23);
            this.txtPE.TabIndex = 63;
            // 
            // txtCodEst
            // 
            this.txtCodEst.Location = new System.Drawing.Point(144, 106);
            this.txtCodEst.Name = "txtCodEst";
            this.txtCodEst.Size = new System.Drawing.Size(73, 23);
            this.txtCodEst.TabIndex = 64;
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(481, 181);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(79, 23);
            this.txtCuotas.TabIndex = 65;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(790, 518);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 37);
            this.BtnCancelar.TabIndex = 66;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FacturaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 619);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
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
        private System.Windows.Forms.TextBox txtNroFact;
        private System.Windows.Forms.Label LblCuotas;
        private System.Windows.Forms.DateTimePicker FechaVenc;
        private System.Windows.Forms.Label LblFechaVenc;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.DateTimePicker FechaRec;
        private System.Windows.Forms.Label LblFechaRec;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.Label LblTimbrado;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.Label LblProd;
        private System.Windows.Forms.TextBox TxtProd;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtTimbrado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtCodEst;
        private System.Windows.Forms.TextBox txtPE;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Button BtnCancelar;
    }
}