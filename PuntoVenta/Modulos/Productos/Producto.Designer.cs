
namespace PuntoVenta.Modulos.Productos
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datalistadoProductos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelRegistro = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.groupBoxUbi = new System.Windows.Forms.GroupBox();
            this.TxtColumna = new System.Windows.Forms.TextBox();
            this.TxtFila = new System.Windows.Forms.TextBox();
            this.LblColumna = new System.Windows.Forms.Label();
            this.LblFila = new System.Windows.Forms.Label();
            this.LblEstante = new System.Windows.Forms.Label();
            this.TxtEstante = new System.Windows.Forms.TextBox();
            this.TxtCantMayorista = new System.Windows.Forms.TextBox();
            this.LblCantMayorista = new System.Windows.Forms.Label();
            this.TxtExistenciaMinima = new System.Windows.Forms.TextBox();
            this.LblExistenciaMinima = new System.Windows.Forms.Label();
            this.CheckAdmInv = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtImpuesto = new System.Windows.Forms.ComboBox();
            this.LblImpuesto = new System.Windows.Forms.Label();
            this.TxtCodigoBarras = new System.Windows.Forms.TextBox();
            this.LblCodigoBarras = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.ComboBox();
            this.TxtUMedida = new System.Windows.Forms.ComboBox();
            this.LblUMedida = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.PanelProductoImagen = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtExistencia = new System.Windows.Forms.TextBox();
            this.TxtPrecioMayorista = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblExistencia = new System.Windows.Forms.Label();
            this.LblPrecioMayorista = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCosto = new System.Windows.Forms.Label();
            this.LblDescripción = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelEncabezado.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoProductos)).BeginInit();
            this.PanelRegistro.SuspendLayout();
            this.groupBoxUbi.SuspendLayout();
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
            this.PanelEncabezado.Size = new System.Drawing.Size(1041, 49);
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
            this.BtnNuevo.Click += new System.EventHandler(this.CrearProducto);
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
            this.menuStrip1.Click += new System.EventHandler(this.BuscarProducto);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 21);
            // 
            // datalistadoProductos
            // 
            this.datalistadoProductos.AllowUserToAddRows = false;
            this.datalistadoProductos.AllowUserToResizeRows = false;
            this.datalistadoProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datalistadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.datalistadoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistadoProductos.Location = new System.Drawing.Point(0, 49);
            this.datalistadoProductos.Name = "datalistadoProductos";
            this.datalistadoProductos.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistadoProductos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistadoProductos.RowTemplate.Height = 25;
            this.datalistadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoProductos.Size = new System.Drawing.Size(1041, 541);
            this.datalistadoProductos.TabIndex = 5;
            this.datalistadoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarProducto);
            this.datalistadoProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarProducto2);
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
            this.PanelRegistro.Controls.Add(this.panel3);
            this.PanelRegistro.Controls.Add(this.checkBoxActivo);
            this.PanelRegistro.Controls.Add(this.groupBoxUbi);
            this.PanelRegistro.Controls.Add(this.TxtCantMayorista);
            this.PanelRegistro.Controls.Add(this.LblCantMayorista);
            this.PanelRegistro.Controls.Add(this.TxtExistenciaMinima);
            this.PanelRegistro.Controls.Add(this.LblExistenciaMinima);
            this.PanelRegistro.Controls.Add(this.CheckAdmInv);
            this.PanelRegistro.Controls.Add(this.panel2);
            this.PanelRegistro.Controls.Add(this.panel1);
            this.PanelRegistro.Controls.Add(this.TxtImpuesto);
            this.PanelRegistro.Controls.Add(this.LblImpuesto);
            this.PanelRegistro.Controls.Add(this.TxtCodigoBarras);
            this.PanelRegistro.Controls.Add(this.LblCodigoBarras);
            this.PanelRegistro.Controls.Add(this.TxtCategoria);
            this.PanelRegistro.Controls.Add(this.TxtUMedida);
            this.PanelRegistro.Controls.Add(this.LblUMedida);
            this.PanelRegistro.Controls.Add(this.LblCategoria);
            this.PanelRegistro.Controls.Add(this.PanelProductoImagen);
            this.PanelRegistro.Controls.Add(this.BtnCancelar);
            this.PanelRegistro.Controls.Add(this.BtnGuardarCambios);
            this.PanelRegistro.Controls.Add(this.BtnGuardar);
            this.PanelRegistro.Controls.Add(this.TxtExistencia);
            this.PanelRegistro.Controls.Add(this.TxtPrecioMayorista);
            this.PanelRegistro.Controls.Add(this.TxtPrecio);
            this.PanelRegistro.Controls.Add(this.TxtCosto);
            this.PanelRegistro.Controls.Add(this.TxtDescripcion);
            this.PanelRegistro.Controls.Add(this.LblExistencia);
            this.PanelRegistro.Controls.Add(this.LblPrecioMayorista);
            this.PanelRegistro.Controls.Add(this.LblPrecio);
            this.PanelRegistro.Controls.Add(this.LblCosto);
            this.PanelRegistro.Controls.Add(this.LblDescripción);
            this.PanelRegistro.Location = new System.Drawing.Point(0, 48);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(1041, 542);
            this.PanelRegistro.TabIndex = 6;
            this.PanelRegistro.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(720, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 23);
            this.panel3.TabIndex = 627;
            this.panel3.Click += new System.EventHandler(this.CrearImpuesto);
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxActivo.Checked = true;
            this.checkBoxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxActivo.Location = new System.Drawing.Point(821, 163);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(69, 19);
            this.checkBoxActivo.TabIndex = 626;
            this.checkBoxActivo.Text = "ACTIVO";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // groupBoxUbi
            // 
            this.groupBoxUbi.Controls.Add(this.TxtColumna);
            this.groupBoxUbi.Controls.Add(this.TxtFila);
            this.groupBoxUbi.Controls.Add(this.LblColumna);
            this.groupBoxUbi.Controls.Add(this.LblFila);
            this.groupBoxUbi.Controls.Add(this.LblEstante);
            this.groupBoxUbi.Controls.Add(this.TxtEstante);
            this.groupBoxUbi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxUbi.Location = new System.Drawing.Point(14, 346);
            this.groupBoxUbi.Name = "groupBoxUbi";
            this.groupBoxUbi.Size = new System.Drawing.Size(380, 127);
            this.groupBoxUbi.TabIndex = 625;
            this.groupBoxUbi.TabStop = false;
            this.groupBoxUbi.Text = "Ubicación";
            // 
            // TxtColumna
            // 
            this.TxtColumna.Location = new System.Drawing.Point(142, 81);
            this.TxtColumna.Name = "TxtColumna";
            this.TxtColumna.Size = new System.Drawing.Size(224, 25);
            this.TxtColumna.TabIndex = 10;
            // 
            // TxtFila
            // 
            this.TxtFila.Location = new System.Drawing.Point(142, 52);
            this.TxtFila.Name = "TxtFila";
            this.TxtFila.Size = new System.Drawing.Size(225, 25);
            this.TxtFila.TabIndex = 9;
            // 
            // LblColumna
            // 
            this.LblColumna.AutoSize = true;
            this.LblColumna.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblColumna.Location = new System.Drawing.Point(6, 82);
            this.LblColumna.Name = "LblColumna";
            this.LblColumna.Size = new System.Drawing.Size(67, 19);
            this.LblColumna.TabIndex = 8;
            this.LblColumna.Text = "Columna:";
            // 
            // LblFila
            // 
            this.LblFila.AutoSize = true;
            this.LblFila.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFila.Location = new System.Drawing.Point(6, 53);
            this.LblFila.Name = "LblFila";
            this.LblFila.Size = new System.Drawing.Size(32, 19);
            this.LblFila.TabIndex = 7;
            this.LblFila.Text = "Fila:";
            // 
            // LblEstante
            // 
            this.LblEstante.AutoSize = true;
            this.LblEstante.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEstante.Location = new System.Drawing.Point(6, 23);
            this.LblEstante.Name = "LblEstante";
            this.LblEstante.Size = new System.Drawing.Size(57, 19);
            this.LblEstante.TabIndex = 6;
            this.LblEstante.Text = "Estante:";
            // 
            // TxtEstante
            // 
            this.TxtEstante.Location = new System.Drawing.Point(142, 22);
            this.TxtEstante.Name = "TxtEstante";
            this.TxtEstante.Size = new System.Drawing.Size(225, 25);
            this.TxtEstante.TabIndex = 0;
            // 
            // TxtCantMayorista
            // 
            this.TxtCantMayorista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCantMayorista.Location = new System.Drawing.Point(529, 220);
            this.TxtCantMayorista.Name = "TxtCantMayorista";
            this.TxtCantMayorista.Size = new System.Drawing.Size(190, 25);
            this.TxtCantMayorista.TabIndex = 624;
            // 
            // LblCantMayorista
            // 
            this.LblCantMayorista.AutoSize = true;
            this.LblCantMayorista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCantMayorista.Location = new System.Drawing.Point(391, 222);
            this.LblCantMayorista.Name = "LblCantMayorista";
            this.LblCantMayorista.Size = new System.Drawing.Size(132, 19);
            this.LblCantMayorista.TabIndex = 623;
            this.LblCantMayorista.Text = "Cantidad Mayorista:";
            // 
            // TxtExistenciaMinima
            // 
            this.TxtExistenciaMinima.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtExistenciaMinima.Location = new System.Drawing.Point(156, 315);
            this.TxtExistenciaMinima.Name = "TxtExistenciaMinima";
            this.TxtExistenciaMinima.Size = new System.Drawing.Size(562, 25);
            this.TxtExistenciaMinima.TabIndex = 622;
            // 
            // LblExistenciaMinima
            // 
            this.LblExistenciaMinima.AutoSize = true;
            this.LblExistenciaMinima.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblExistenciaMinima.Location = new System.Drawing.Point(14, 314);
            this.LblExistenciaMinima.Name = "LblExistenciaMinima";
            this.LblExistenciaMinima.Size = new System.Drawing.Size(120, 19);
            this.LblExistenciaMinima.TabIndex = 621;
            this.LblExistenciaMinima.Text = "Existencia Mínima:";
            // 
            // CheckAdmInv
            // 
            this.CheckAdmInv.AutoSize = true;
            this.CheckAdmInv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckAdmInv.Location = new System.Drawing.Point(156, 256);
            this.CheckAdmInv.Name = "CheckAdmInv";
            this.CheckAdmInv.Size = new System.Drawing.Size(150, 21);
            this.CheckAdmInv.TabIndex = 620;
            this.CheckAdmInv.Text = "Administra Inventario";
            this.CheckAdmInv.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(720, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 23);
            this.panel2.TabIndex = 619;
            this.panel2.Click += new System.EventHandler(this.CrearCategoria);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(720, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 23);
            this.panel1.TabIndex = 618;
            this.panel1.Click += new System.EventHandler(this.CrearUMedida);
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.FormattingEnabled = true;
            this.TxtImpuesto.Location = new System.Drawing.Point(156, 128);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(562, 23);
            this.TxtImpuesto.TabIndex = 616;
            // 
            // LblImpuesto
            // 
            this.LblImpuesto.AutoSize = true;
            this.LblImpuesto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblImpuesto.Location = new System.Drawing.Point(14, 129);
            this.LblImpuesto.Name = "LblImpuesto";
            this.LblImpuesto.Size = new System.Drawing.Size(70, 19);
            this.LblImpuesto.TabIndex = 615;
            this.LblImpuesto.Text = "Impuesto:";
            // 
            // TxtCodigoBarras
            // 
            this.TxtCodigoBarras.Location = new System.Drawing.Point(156, 7);
            this.TxtCodigoBarras.Name = "TxtCodigoBarras";
            this.TxtCodigoBarras.Size = new System.Drawing.Size(562, 23);
            this.TxtCodigoBarras.TabIndex = 612;
            // 
            // LblCodigoBarras
            // 
            this.LblCodigoBarras.BackColor = System.Drawing.SystemColors.Control;
            this.LblCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LblCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCodigoBarras.Location = new System.Drawing.Point(19, 8);
            this.LblCodigoBarras.Name = "LblCodigoBarras";
            this.LblCodigoBarras.Size = new System.Drawing.Size(112, 18);
            this.LblCodigoBarras.TabIndex = 611;
            this.LblCodigoBarras.Text = "Código de Barras:";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.FormattingEnabled = true;
            this.TxtCategoria.Location = new System.Drawing.Point(156, 69);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(562, 23);
            this.TxtCategoria.TabIndex = 610;
            // 
            // TxtUMedida
            // 
            this.TxtUMedida.FormattingEnabled = true;
            this.TxtUMedida.Location = new System.Drawing.Point(156, 98);
            this.TxtUMedida.Name = "TxtUMedida";
            this.TxtUMedida.Size = new System.Drawing.Size(562, 23);
            this.TxtUMedida.TabIndex = 609;
            // 
            // LblUMedida
            // 
            this.LblUMedida.AutoSize = true;
            this.LblUMedida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUMedida.Location = new System.Drawing.Point(14, 98);
            this.LblUMedida.Name = "LblUMedida";
            this.LblUMedida.Size = new System.Drawing.Size(106, 19);
            this.LblUMedida.TabIndex = 17;
            this.LblUMedida.Text = "Unidad Medida:";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCategoria.Location = new System.Drawing.Point(14, 70);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(71, 19);
            this.LblCategoria.TabIndex = 16;
            this.LblCategoria.Text = "Categoria:";
            // 
            // PanelProductoImagen
            // 
            this.PanelProductoImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelProductoImagen.BackgroundImage")));
            this.PanelProductoImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelProductoImagen.Location = new System.Drawing.Point(821, 38);
            this.PanelProductoImagen.Name = "PanelProductoImagen";
            this.PanelProductoImagen.Size = new System.Drawing.Size(143, 106);
            this.PanelProductoImagen.TabIndex = 15;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(622, 492);
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
            this.BtnGuardarCambios.Location = new System.Drawing.Point(500, 492);
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
            this.BtnGuardar.Location = new System.Drawing.Point(500, 492);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 37);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.GuardarProducto);
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtExistencia.Location = new System.Drawing.Point(156, 283);
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.ReadOnly = true;
            this.TxtExistencia.Size = new System.Drawing.Size(562, 25);
            this.TxtExistencia.TabIndex = 12;
            // 
            // TxtPrecioMayorista
            // 
            this.TxtPrecioMayorista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrecioMayorista.Location = new System.Drawing.Point(157, 219);
            this.TxtPrecioMayorista.Name = "TxtPrecioMayorista";
            this.TxtPrecioMayorista.Size = new System.Drawing.Size(190, 25);
            this.TxtPrecioMayorista.TabIndex = 10;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrecio.Location = new System.Drawing.Point(157, 188);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(562, 25);
            this.TxtPrecio.TabIndex = 9;
            // 
            // TxtCosto
            // 
            this.TxtCosto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCosto.Location = new System.Drawing.Point(157, 157);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(562, 25);
            this.TxtCosto.TabIndex = 8;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescripcion.Location = new System.Drawing.Point(156, 36);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(562, 25);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // LblExistencia
            // 
            this.LblExistencia.AutoSize = true;
            this.LblExistencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblExistencia.Location = new System.Drawing.Point(14, 286);
            this.LblExistencia.Name = "LblExistencia";
            this.LblExistencia.Size = new System.Drawing.Size(70, 19);
            this.LblExistencia.TabIndex = 5;
            this.LblExistencia.Text = "Existencia:";
            // 
            // LblPrecioMayorista
            // 
            this.LblPrecioMayorista.AutoSize = true;
            this.LblPrecioMayorista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrecioMayorista.Location = new System.Drawing.Point(14, 222);
            this.LblPrecioMayorista.Name = "LblPrecioMayorista";
            this.LblPrecioMayorista.Size = new System.Drawing.Size(114, 19);
            this.LblPrecioMayorista.TabIndex = 3;
            this.LblPrecioMayorista.Text = "Precio Mayorista:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrecio.Location = new System.Drawing.Point(15, 191);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(49, 19);
            this.LblPrecio.TabIndex = 2;
            this.LblPrecio.Text = "Precio:";
            // 
            // LblCosto
            // 
            this.LblCosto.AutoSize = true;
            this.LblCosto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCosto.Location = new System.Drawing.Point(14, 160);
            this.LblCosto.Name = "LblCosto";
            this.LblCosto.Size = new System.Drawing.Size(111, 19);
            this.LblCosto.TabIndex = 1;
            this.LblCosto.Text = "Costo Promedio:";
            // 
            // LblDescripción
            // 
            this.LblDescripción.AutoSize = true;
            this.LblDescripción.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescripción.Location = new System.Drawing.Point(14, 39);
            this.LblDescripción.Name = "LblDescripción";
            this.LblDescripción.Size = new System.Drawing.Size(82, 19);
            this.LblDescripción.TabIndex = 0;
            this.LblDescripción.Text = "Descripción:";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 590);
            this.Controls.Add(this.PanelRegistro);
            this.Controls.Add(this.datalistadoProductos);
            this.Controls.Add(this.PanelEncabezado);
            this.Name = "Producto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.PanelEncabezado.ResumeLayout(false);
            this.PanelEncabezado.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoProductos)).EndInit();
            this.PanelRegistro.ResumeLayout(false);
            this.PanelRegistro.PerformLayout();
            this.groupBoxUbi.ResumeLayout(false);
            this.groupBoxUbi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEncabezado;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView datalistadoProductos;
        private System.Windows.Forms.Panel PanelRegistro;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtExistencia;
        private System.Windows.Forms.TextBox TxtPrecioMayorista;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblExistencia;
        private System.Windows.Forms.Label LblPrecioMayorista;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCosto;
        private System.Windows.Forms.Label LblDescripción;
        private System.Windows.Forms.Label LblUMedida;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox TxtCategoria;
        private System.Windows.Forms.ComboBox TxtUMedida;
        private System.Windows.Forms.Panel PanelProductoImagen;
        private System.Windows.Forms.TextBox TxtCodigoBarras;
        private System.Windows.Forms.TextBox LblCodigoBarras;
        private System.Windows.Forms.Label LblImpuesto;
        private System.Windows.Forms.ComboBox TxtImpuesto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckAdmInv;
        private System.Windows.Forms.TextBox TxtCantMayorista;
        private System.Windows.Forms.Label LblCantMayorista;
        private System.Windows.Forms.TextBox TxtExistenciaMinima;
        private System.Windows.Forms.Label LblExistenciaMinima;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxUbi;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtColumna;
        private System.Windows.Forms.TextBox TxtFila;
        private System.Windows.Forms.Label LblColumna;
        private System.Windows.Forms.Label LblFila;
        private System.Windows.Forms.Label LblEstante;
        private System.Windows.Forms.TextBox TxtEstante;
    }
}