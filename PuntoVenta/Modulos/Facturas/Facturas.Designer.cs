
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
            this.PanelFactura = new System.Windows.Forms.Panel();
            this.TxtCliente = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LabelCantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.LBL_TotalFactura = new System.Windows.Forms.Label();
            this.LBL_Vuelto = new System.Windows.Forms.Label();
            this.TxtTotalFactura = new System.Windows.Forms.TextBox();
            this.TxtVuelto = new System.Windows.Forms.TextBox();
            this.PanelFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelTituloFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFactura
            // 
            this.PanelFactura.Controls.Add(this.TxtCliente);
            this.PanelFactura.Controls.Add(this.BtnAgregar);
            this.PanelFactura.Controls.Add(this.numericUpDown1);
            this.PanelFactura.Controls.Add(this.LabelCantidad);
            this.PanelFactura.Controls.Add(this.textBox1);
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
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(595, 156);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(240, 23);
            this.BtnAgregar.TabIndex = 24;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(663, 127);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(172, 23);
            this.numericUpDown1.TabIndex = 23;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(663, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 23);
            this.textBox1.TabIndex = 20;
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
            this.panel1.Location = new System.Drawing.Point(595, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 38);
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
            this.ItemsDataGridView.Location = new System.Drawing.Point(15, 262);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowTemplate.Height = 25;
            this.ItemsDataGridView.Size = new System.Drawing.Size(847, 189);
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
            // LBL_TotalFactura
            // 
            this.LBL_TotalFactura.AutoSize = true;
            this.LBL_TotalFactura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_TotalFactura.Location = new System.Drawing.Point(563, 481);
            this.LBL_TotalFactura.Name = "LBL_TotalFactura";
            this.LBL_TotalFactura.Size = new System.Drawing.Size(112, 21);
            this.LBL_TotalFactura.TabIndex = 3;
            this.LBL_TotalFactura.Text = "Total Factura:";
            // 
            // LBL_Vuelto
            // 
            this.LBL_Vuelto.AutoSize = true;
            this.LBL_Vuelto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Vuelto.Location = new System.Drawing.Point(607, 512);
            this.LBL_Vuelto.Name = "LBL_Vuelto";
            this.LBL_Vuelto.Size = new System.Drawing.Size(65, 21);
            this.LBL_Vuelto.TabIndex = 4;
            this.LBL_Vuelto.Text = "Vuelto:";
            // 
            // TxtTotalFactura
            // 
            this.TxtTotalFactura.Location = new System.Drawing.Point(678, 479);
            this.TxtTotalFactura.Name = "TxtTotalFactura";
            this.TxtTotalFactura.Size = new System.Drawing.Size(184, 23);
            this.TxtTotalFactura.TabIndex = 5;
            // 
            // TxtVuelto
            // 
            this.TxtVuelto.Location = new System.Drawing.Point(678, 510);
            this.TxtVuelto.Name = "TxtVuelto";
            this.TxtVuelto.Size = new System.Drawing.Size(184, 23);
            this.TxtVuelto.TabIndex = 6;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 580);
            this.Controls.Add(this.TxtVuelto);
            this.Controls.Add(this.TxtTotalFactura);
            this.Controls.Add(this.LBL_Vuelto);
            this.Controls.Add(this.LBL_TotalFactura);
            this.Controls.Add(this.ItemsLbl);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.PanelFactura);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.PanelFactura.ResumeLayout(false);
            this.PanelFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelTituloFactura.ResumeLayout(false);
            this.PanelTituloFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LabelCantidad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label ItemsLbl;
        private System.Windows.Forms.ComboBox TxtCliente;
        private System.Windows.Forms.Label LBL_TotalFactura;
        private System.Windows.Forms.Label LBL_Vuelto;
        private System.Windows.Forms.TextBox TxtTotalFactura;
        private System.Windows.Forms.TextBox TxtVuelto;
    }
}