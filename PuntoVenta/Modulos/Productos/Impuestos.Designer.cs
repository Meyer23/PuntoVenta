
namespace PuntoVenta.Modulos.Productos
{
    partial class Impuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impuestos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelRegistro = new System.Windows.Forms.Panel();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtPorcIva = new System.Windows.Forms.TextBox();
            this.LblPorcIva = new System.Windows.Forms.Label();
            this.TxtFactGrav = new System.Windows.Forms.TextBox();
            this.LblFactGrav = new System.Windows.Forms.Label();
            this.LblFactIva = new System.Windows.Forms.Label();
            this.TxtFactIva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
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
            this.PanelEncabezado.Size = new System.Drawing.Size(738, 49);
            this.PanelEncabezado.TabIndex = 3;
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
            this.menuStrip1.Location = new System.Drawing.Point(355, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(43, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BuscarImpuesto);
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
            this.datalistado.Size = new System.Drawing.Size(738, 180);
            this.datalistado.TabIndex = 7;
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarImpuesto);
            this.datalistado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarImpuesto2);
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
            this.PanelRegistro.Controls.Add(this.TxtImpuesto);
            this.PanelRegistro.Controls.Add(this.label1);
            this.PanelRegistro.Controls.Add(this.TxtFactIva);
            this.PanelRegistro.Controls.Add(this.LblFactIva);
            this.PanelRegistro.Controls.Add(this.LblFactGrav);
            this.PanelRegistro.Controls.Add(this.TxtFactGrav);
            this.PanelRegistro.Controls.Add(this.LblPorcIva);
            this.PanelRegistro.Controls.Add(this.TxtPorcIva);
            this.PanelRegistro.Controls.Add(this.checkBoxActivo);
            this.PanelRegistro.Controls.Add(this.BtnCancelar);
            this.PanelRegistro.Controls.Add(this.BtnGuardarCambios);
            this.PanelRegistro.Controls.Add(this.BtnGuardar);
            this.PanelRegistro.Controls.Add(this.TxtDescripcion);
            this.PanelRegistro.Controls.Add(this.LblDescripcion);
            this.PanelRegistro.Location = new System.Drawing.Point(3, 49);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(733, 180);
            this.PanelRegistro.TabIndex = 8;
            this.PanelRegistro.Visible = false;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxActivo.Checked = true;
            this.checkBoxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxActivo.Location = new System.Drawing.Point(487, 73);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(69, 19);
            this.checkBoxActivo.TabIndex = 23;
            this.checkBoxActivo.Text = "ACTIVO";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(562, 131);
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
            this.BtnGuardarCambios.Location = new System.Drawing.Point(440, 131);
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
            this.BtnGuardar.Location = new System.Drawing.Point(440, 131);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 37);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescripcion.Location = new System.Drawing.Point(140, 36);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(227, 25);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescripcion.Location = new System.Drawing.Point(44, 42);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(82, 19);
            this.LblDescripcion.TabIndex = 0;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // TxtPorcIva
            // 
            this.TxtPorcIva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPorcIva.Location = new System.Drawing.Point(140, 70);
            this.TxtPorcIva.Name = "TxtPorcIva";
            this.TxtPorcIva.Size = new System.Drawing.Size(227, 25);
            this.TxtPorcIva.TabIndex = 24;
            // 
            // LblPorcIva
            // 
            this.LblPorcIva.AutoSize = true;
            this.LblPorcIva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPorcIva.Location = new System.Drawing.Point(41, 73);
            this.LblPorcIva.Name = "LblPorcIva";
            this.LblPorcIva.Size = new System.Drawing.Size(89, 19);
            this.LblPorcIva.TabIndex = 25;
            this.LblPorcIva.Text = "Porc. (%) IVA:";
            // 
            // TxtFactGrav
            // 
            this.TxtFactGrav.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFactGrav.Location = new System.Drawing.Point(487, 5);
            this.TxtFactGrav.Name = "TxtFactGrav";
            this.TxtFactGrav.Size = new System.Drawing.Size(227, 25);
            this.TxtFactGrav.TabIndex = 26;
            // 
            // LblFactGrav
            // 
            this.LblFactGrav.AutoSize = true;
            this.LblFactGrav.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFactGrav.Location = new System.Drawing.Point(376, 8);
            this.LblFactGrav.Name = "LblFactGrav";
            this.LblFactGrav.Size = new System.Drawing.Size(105, 19);
            this.LblFactGrav.TabIndex = 27;
            this.LblFactGrav.Text = "Factor Gravada:";
            // 
            // LblFactIva
            // 
            this.LblFactIva.AutoSize = true;
            this.LblFactIva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFactIva.Location = new System.Drawing.Point(406, 42);
            this.LblFactIva.Name = "LblFactIva";
            this.LblFactIva.Size = new System.Drawing.Size(75, 19);
            this.LblFactIva.TabIndex = 28;
            this.LblFactIva.Text = "Factor IVA:";
            // 
            // TxtFactIva
            // 
            this.TxtFactIva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFactIva.Location = new System.Drawing.Point(487, 36);
            this.TxtFactIva.Name = "TxtFactIva";
            this.TxtFactIva.Size = new System.Drawing.Size(227, 25);
            this.TxtFactIva.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tipo Impuesto (%):";
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtImpuesto.Location = new System.Drawing.Point(140, 5);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(227, 25);
            this.TxtImpuesto.TabIndex = 31;
            this.TxtImpuesto.Validating += new System.ComponentModel.CancelEventHandler(this.TxtImpuesto_Validating);
            // 
            // Impuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 229);
            this.Controls.Add(this.PanelRegistro);
            this.Controls.Add(this.datalistado);
            this.Controls.Add(this.PanelEncabezado);
            this.Name = "Impuestos";
            this.Text = "Impuestos";
            this.Load += new System.EventHandler(this.Impuestos_Load);
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
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtFactIva;
        private System.Windows.Forms.Label LblFactIva;
        private System.Windows.Forms.Label LblFactGrav;
        private System.Windows.Forms.TextBox TxtFactGrav;
        private System.Windows.Forms.Label LblPorcIva;
        private System.Windows.Forms.TextBox TxtPorcIva;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.Label label1;
    }
}