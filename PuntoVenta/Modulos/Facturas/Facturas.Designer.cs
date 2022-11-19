
namespace PuntoVenta.Modulos
{
    partial class Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            this.PanelFactura = new System.Windows.Forms.Panel();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtCliente = new System.Windows.Forms.ComboBox();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.LabelCantidad = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.ProductoNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelProducto = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtTipo = new System.Windows.Forms.ComboBox();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LabelRuc = new System.Windows.Forms.Label();
            this.LabelClienteFactura = new System.Windows.Forms.Label();
            this.LabelFechaFactura = new System.Windows.Forms.Label();
            this.LabelRazonSocial = new System.Windows.Forms.Label();
            this.LabelTipoFactura = new System.Windows.Forms.Label();
            this.PanelTituloFactura = new System.Windows.Forms.Panel();
            this.LabelFactura = new System.Windows.Forms.Label();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemsLbl = new System.Windows.Forms.Label();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.Label_Total = new System.Windows.Forms.Label();
            this.ValorTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Caja = new System.Windows.Forms.Label();
            this.TxtCajaEstado = new System.Windows.Forms.TextBox();
            this.Label_idCaja = new System.Windows.Forms.Label();
            this.TxtIdCaja = new System.Windows.Forms.TextBox();
            this.PanelFactura.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelTituloFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFactura
            // 
            this.PanelFactura.Controls.Add(this.TxtCantidad);
            this.PanelFactura.Controls.Add(this.TxtCliente);
            this.PanelFactura.Controls.Add(this.BtnAgregarProducto);
            this.PanelFactura.Controls.Add(this.LabelCantidad);
            this.PanelFactura.Controls.Add(this.TxtCodigoProducto);
            this.PanelFactura.Controls.Add(this.LabelCodigo);
            this.PanelFactura.Controls.Add(this.TxtNombreProducto);
            this.PanelFactura.Controls.Add(this.ProductoNombre);
            this.PanelFactura.Controls.Add(this.panel1);
            this.PanelFactura.Controls.Add(this.TxtFecha);
            this.PanelFactura.Controls.Add(this.TxtTipo);
            this.PanelFactura.Controls.Add(this.TxtRUC);
            this.PanelFactura.Controls.Add(this.TxtRazonSocial);
            this.PanelFactura.Controls.Add(this.LabelRuc);
            this.PanelFactura.Controls.Add(this.LabelClienteFactura);
            this.PanelFactura.Controls.Add(this.LabelFechaFactura);
            this.PanelFactura.Controls.Add(this.LabelRazonSocial);
            this.PanelFactura.Controls.Add(this.LabelTipoFactura);
            this.PanelFactura.Controls.Add(this.PanelTituloFactura);
            this.PanelFactura.Location = new System.Drawing.Point(15, 12);
            this.PanelFactura.Name = "PanelFactura";
            this.PanelFactura.Size = new System.Drawing.Size(844, 194);
            this.PanelFactura.TabIndex = 0;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(663, 123);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(172, 23);
            this.TxtCantidad.TabIndex = 26;
            // 
            // TxtCliente
            // 
            this.TxtCliente.FormattingEnabled = true;
            this.TxtCliente.Items.AddRange(new object[] {
            "CLIENTES CASUALES",
            "CLIENTE EXISTENTE"});
            this.TxtCliente.Location = new System.Drawing.Point(67, 107);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(149, 23);
            this.TxtCliente.TabIndex = 25;
            this.TxtCliente.SelectedValueChanged += new System.EventHandler(this.ComboBoxChange);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(595, 156);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(240, 23);
            this.BtnAgregarProducto.TabIndex = 24;
            this.BtnAgregarProducto.Text = "Agregar";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // LabelCantidad
            // 
            this.LabelCantidad.AutoSize = true;
            this.LabelCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCantidad.Location = new System.Drawing.Point(595, 131);
            this.LabelCantidad.Name = "LabelCantidad";
            this.LabelCantidad.Size = new System.Drawing.Size(67, 19);
            this.LabelCantidad.TabIndex = 21;
            this.LabelCantidad.Text = "Cantidad:";
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtCodigoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtCodigoProducto.Location = new System.Drawing.Point(663, 94);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(172, 23);
            this.TxtCodigoProducto.TabIndex = 20;
            this.TxtCodigoProducto.Click += new System.EventHandler(this.LeerTxtCodigoProducto);
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCodigo.Location = new System.Drawing.Point(595, 95);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(56, 19);
            this.LabelCodigo.TabIndex = 19;
            this.LabelCodigo.Text = "Código:";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(663, 63);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(172, 23);
            this.TxtNombreProducto.TabIndex = 18;
            // 
            // ProductoNombre
            // 
            this.ProductoNombre.AutoSize = true;
            this.ProductoNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductoNombre.Location = new System.Drawing.Point(595, 67);
            this.ProductoNombre.Name = "ProductoNombre";
            this.ProductoNombre.Size = new System.Drawing.Size(62, 19);
            this.ProductoNombre.TabIndex = 17;
            this.ProductoNombre.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.LabelProducto);
            this.panel1.Location = new System.Drawing.Point(586, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 38);
            this.panel1.TabIndex = 16;
            // 
            // LabelProducto
            // 
            this.LabelProducto.AutoSize = true;
            this.LabelProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelProducto.Location = new System.Drawing.Point(0, 12);
            this.LabelProducto.Name = "LabelProducto";
            this.LabelProducto.Size = new System.Drawing.Size(73, 20);
            this.LabelProducto.TabIndex = 0;
            this.LabelProducto.Text = "Producto";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Location = new System.Drawing.Point(307, 71);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(165, 23);
            this.TxtFecha.TabIndex = 15;
            // 
            // TxtTipo
            // 
            this.TxtTipo.FormattingEnabled = true;
            this.TxtTipo.Items.AddRange(new object[] {
            "Contado",
            "Crédito"});
            this.TxtTipo.Location = new System.Drawing.Point(67, 70);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(149, 23);
            this.TxtTipo.TabIndex = 14;
            // 
            // TxtRUC
            // 
            this.TxtRUC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtRUC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtRUC.Location = new System.Drawing.Point(307, 147);
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.Size = new System.Drawing.Size(165, 23);
            this.TxtRUC.TabIndex = 11;
            this.TxtRUC.Click += new System.EventHandler(this.LeerTextBoxRUC);
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(307, 104);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(165, 23);
            this.TxtRazonSocial.TabIndex = 10;
            // 
            // LabelRuc
            // 
            this.LabelRuc.AutoSize = true;
            this.LabelRuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRuc.Location = new System.Drawing.Point(222, 148);
            this.LabelRuc.Name = "LabelRuc";
            this.LabelRuc.Size = new System.Drawing.Size(68, 19);
            this.LabelRuc.TabIndex = 6;
            this.LabelRuc.Text = "RUC o CI:";
            // 
            // LabelClienteFactura
            // 
            this.LabelClienteFactura.AutoSize = true;
            this.LabelClienteFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelClienteFactura.Location = new System.Drawing.Point(7, 112);
            this.LabelClienteFactura.Name = "LabelClienteFactura";
            this.LabelClienteFactura.Size = new System.Drawing.Size(54, 19);
            this.LabelClienteFactura.TabIndex = 5;
            this.LabelClienteFactura.Text = "Cliente:";
            // 
            // LabelFechaFactura
            // 
            this.LabelFechaFactura.AutoSize = true;
            this.LabelFechaFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelFechaFactura.Location = new System.Drawing.Point(222, 75);
            this.LabelFechaFactura.Name = "LabelFechaFactura";
            this.LabelFechaFactura.Size = new System.Drawing.Size(47, 19);
            this.LabelFechaFactura.TabIndex = 4;
            this.LabelFechaFactura.Text = "Fecha:";
            // 
            // LabelRazonSocial
            // 
            this.LabelRazonSocial.AutoSize = true;
            this.LabelRazonSocial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRazonSocial.Location = new System.Drawing.Point(222, 108);
            this.LabelRazonSocial.Name = "LabelRazonSocial";
            this.LabelRazonSocial.Size = new System.Drawing.Size(87, 19);
            this.LabelRazonSocial.TabIndex = 3;
            this.LabelRazonSocial.Text = "Razón Social:";
            // 
            // LabelTipoFactura
            // 
            this.LabelTipoFactura.AutoSize = true;
            this.LabelTipoFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTipoFactura.Location = new System.Drawing.Point(7, 75);
            this.LabelTipoFactura.Name = "LabelTipoFactura";
            this.LabelTipoFactura.Size = new System.Drawing.Size(38, 19);
            this.LabelTipoFactura.TabIndex = 2;
            this.LabelTipoFactura.Text = "Tipo:";
            // 
            // PanelTituloFactura
            // 
            this.PanelTituloFactura.BackColor = System.Drawing.Color.Silver;
            this.PanelTituloFactura.Controls.Add(this.LabelFactura);
            this.PanelTituloFactura.Location = new System.Drawing.Point(3, 16);
            this.PanelTituloFactura.Name = "PanelTituloFactura";
            this.PanelTituloFactura.Size = new System.Drawing.Size(469, 38);
            this.PanelTituloFactura.TabIndex = 1;
            // 
            // LabelFactura
            // 
            this.LabelFactura.AutoSize = true;
            this.LabelFactura.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelFactura.Location = new System.Drawing.Point(3, 12);
            this.LabelFactura.Name = "LabelFactura";
            this.LabelFactura.Size = new System.Drawing.Size(61, 20);
            this.LabelFactura.TabIndex = 0;
            this.LabelFactura.Text = "Factura";
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(12, 262);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowTemplate.Height = 25;
            this.ItemsDataGridView.Size = new System.Drawing.Size(563, 152);
            this.ItemsDataGridView.TabIndex = 1;
            this.ItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ItemsLbl
            // 
            this.ItemsLbl.AutoSize = true;
            this.ItemsLbl.Location = new System.Drawing.Point(12, 244);
            this.ItemsLbl.Name = "ItemsLbl";
            this.ItemsLbl.Size = new System.Drawing.Size(39, 15);
            this.ItemsLbl.TabIndex = 2;
            this.ItemsLbl.Text = "Ítems:";
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Location = new System.Drawing.Point(581, 457);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(131, 48);
            this.BtnFacturar.TabIndex = 7;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            // 
            // Label_Total
            // 
            this.Label_Total.AutoSize = true;
            this.Label_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Total.Location = new System.Drawing.Point(581, 367);
            this.Label_Total.Name = "Label_Total";
            this.Label_Total.Size = new System.Drawing.Size(52, 21);
            this.Label_Total.TabIndex = 10;
            this.Label_Total.Text = "Total:";
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSize = true;
            this.ValorTotal.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValorTotal.Location = new System.Drawing.Point(581, 388);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(76, 54);
            this.ValorTotal.TabIndex = 11;
            this.ValorTotal.Text = "0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(581, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Label_Caja
            // 
            this.Label_Caja.AutoSize = true;
            this.Label_Caja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Caja.Location = new System.Drawing.Point(718, 262);
            this.Label_Caja.Name = "Label_Caja";
            this.Label_Caja.Size = new System.Drawing.Size(47, 21);
            this.Label_Caja.TabIndex = 13;
            this.Label_Caja.Text = "Caja: ";
            // 
            // TxtCajaEstado
            // 
            this.TxtCajaEstado.Enabled = false;
            this.TxtCajaEstado.Location = new System.Drawing.Point(780, 260);
            this.TxtCajaEstado.Name = "TxtCajaEstado";
            this.TxtCajaEstado.Size = new System.Drawing.Size(100, 23);
            this.TxtCajaEstado.TabIndex = 14;
            // 
            // Label_idCaja
            // 
            this.Label_idCaja.AutoSize = true;
            this.Label_idCaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_idCaja.Location = new System.Drawing.Point(718, 302);
            this.Label_idCaja.Name = "Label_idCaja";
            this.Label_idCaja.Size = new System.Drawing.Size(60, 21);
            this.Label_idCaja.TabIndex = 15;
            this.Label_idCaja.Text = "Id Caja:";
            // 
            // TxtIdCaja
            // 
            this.TxtIdCaja.Enabled = false;
            this.TxtIdCaja.Location = new System.Drawing.Point(780, 300);
            this.TxtIdCaja.Name = "TxtIdCaja";
            this.TxtIdCaja.Size = new System.Drawing.Size(100, 23);
            this.TxtIdCaja.TabIndex = 16;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 580);
            this.Controls.Add(this.TxtIdCaja);
            this.Controls.Add(this.Label_idCaja);
            this.Controls.Add(this.TxtCajaEstado);
            this.Controls.Add(this.Label_Caja);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.Label_Total);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.ItemsLbl);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.PanelFactura);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.PanelFactura.ResumeLayout(false);
            this.PanelFactura.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelTituloFactura.ResumeLayout(false);
            this.PanelTituloFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelFactura;
        private System.Windows.Forms.Label LabelFactura;
        private System.Windows.Forms.Panel PanelTituloFactura;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LabelRuc;
        private System.Windows.Forms.Label LabelClienteFactura;
        private System.Windows.Forms.Label LabelFechaFactura;
        private System.Windows.Forms.Label LabelRazonSocial;
        private System.Windows.Forms.Label LabelTipoFactura;
        private System.Windows.Forms.ComboBox TxtTipo;
        private System.Windows.Forms.DateTimePicker TxtFecha;
        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelProducto;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label ProductoNombre;
        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LabelCantidad;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Label ItemsLbl;
        private System.Windows.Forms.ComboBox TxtCliente;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.Label Label_Total;
        private System.Windows.Forms.Label ValorTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label Label_Caja;
        private System.Windows.Forms.TextBox TxtCajaEstado;
        private System.Windows.Forms.Label Label_idCaja;
        private System.Windows.Forms.TextBox TxtIdCaja;
    }
}