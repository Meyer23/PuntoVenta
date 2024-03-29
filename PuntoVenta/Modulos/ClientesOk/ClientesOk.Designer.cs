﻿
namespace PuntoVenta.Modulos
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.TxtBuscarCliente = new System.Windows.Forms.TextBox();
            this.DataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelNuevoCliente = new System.Windows.Forms.Panel();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.TipoPersona_LBL = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idUsuario_Label = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardarCliente = new System.Windows.Forms.Button();
            this.PanelClientesImagen = new System.Windows.Forms.Panel();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtRuc = new System.Windows.Forms.TextBox();
            this.TxtNombresCliente = new System.Windows.Forms.TextBox();
            this.LabelCorreo = new System.Windows.Forms.Label();
            this.LabelCelular = new System.Windows.Forms.Label();
            this.LabelTelefono = new System.Windows.Forms.Label();
            this.LabelDireccion = new System.Windows.Forms.Label();
            this.LabelRuc = new System.Windows.Forms.Label();
            this.LabelNombreCliente = new System.Windows.Forms.Label();
            this.BtnGuardarEditado = new System.Windows.Forms.Button();
            this.PanelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).BeginInit();
            this.PanelNuevoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCliente
            // 
            this.PanelCliente.Controls.Add(this.BtnAgregarCliente);
            this.PanelCliente.Controls.Add(this.BtnBuscarCliente);
            this.PanelCliente.Controls.Add(this.TxtBuscarCliente);
            this.PanelCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCliente.Location = new System.Drawing.Point(0, 0);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(914, 57);
            this.PanelCliente.TabIndex = 0;
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.Location = new System.Drawing.Point(392, 17);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarCliente.TabIndex = 2;
            this.BtnAgregarCliente.Text = "Agregar";
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.Btn_NuevoCliente);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Location = new System.Drawing.Point(298, 17);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarCliente.TabIndex = 1;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.Buscar_Cliente);
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Location = new System.Drawing.Point(23, 17);
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.PlaceholderText = "Buscar cliente";
            this.TxtBuscarCliente.Size = new System.Drawing.Size(253, 23);
            this.TxtBuscarCliente.TabIndex = 0;
            // 
            // DataGridViewClientes
            // 
            this.DataGridViewClientes.AllowUserToAddRows = false;
            this.DataGridViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewClientes.Location = new System.Drawing.Point(0, 57);
            this.DataGridViewClientes.Name = "DataGridViewClientes";
            this.DataGridViewClientes.ReadOnly = true;
            this.DataGridViewClientes.RowTemplate.Height = 25;
            this.DataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewClientes.Size = new System.Drawing.Size(914, 465);
            this.DataGridViewClientes.TabIndex = 1;
            this.DataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarCliente);
            this.DataGridViewClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarCliente2);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PanelNuevoCliente
            // 
            this.PanelNuevoCliente.Controls.Add(this.checkBoxActivo);
            this.PanelNuevoCliente.Controls.Add(this.TipoPersona_LBL);
            this.PanelNuevoCliente.Controls.Add(this.comboBox1);
            this.PanelNuevoCliente.Controls.Add(this.idUsuario_Label);
            this.PanelNuevoCliente.Controls.Add(this.BtnCancelar);
            this.PanelNuevoCliente.Controls.Add(this.BtnGuardarCliente);
            this.PanelNuevoCliente.Controls.Add(this.PanelClientesImagen);
            this.PanelNuevoCliente.Controls.Add(this.TxtCorreo);
            this.PanelNuevoCliente.Controls.Add(this.TxtCelular);
            this.PanelNuevoCliente.Controls.Add(this.TxtTelefono);
            this.PanelNuevoCliente.Controls.Add(this.TxtDireccion);
            this.PanelNuevoCliente.Controls.Add(this.TxtRuc);
            this.PanelNuevoCliente.Controls.Add(this.TxtNombresCliente);
            this.PanelNuevoCliente.Controls.Add(this.LabelCorreo);
            this.PanelNuevoCliente.Controls.Add(this.LabelCelular);
            this.PanelNuevoCliente.Controls.Add(this.LabelTelefono);
            this.PanelNuevoCliente.Controls.Add(this.LabelDireccion);
            this.PanelNuevoCliente.Controls.Add(this.LabelRuc);
            this.PanelNuevoCliente.Controls.Add(this.LabelNombreCliente);
            this.PanelNuevoCliente.Controls.Add(this.BtnGuardarEditado);
            this.PanelNuevoCliente.Location = new System.Drawing.Point(0, 57);
            this.PanelNuevoCliente.Name = "PanelNuevoCliente";
            this.PanelNuevoCliente.Size = new System.Drawing.Size(914, 465);
            this.PanelNuevoCliente.TabIndex = 2;
            this.PanelNuevoCliente.Visible = false;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxActivo.Checked = true;
            this.checkBoxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxActivo.Location = new System.Drawing.Point(520, 59);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(69, 19);
            this.checkBoxActivo.TabIndex = 24;
            this.checkBoxActivo.Text = "ACTIVO";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // TipoPersona_LBL
            // 
            this.TipoPersona_LBL.AutoSize = true;
            this.TipoPersona_LBL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TipoPersona_LBL.Location = new System.Drawing.Point(417, 23);
            this.TipoPersona_LBL.Name = "TipoPersona_LBL";
            this.TipoPersona_LBL.Size = new System.Drawing.Size(97, 20);
            this.TipoPersona_LBL.TabIndex = 19;
            this.TipoPersona_LBL.Text = "Tipo Persona:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.comboBox1.Location = new System.Drawing.Point(520, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 23);
            this.comboBox1.TabIndex = 18;
            // 
            // idUsuario_Label
            // 
            this.idUsuario_Label.AutoSize = true;
            this.idUsuario_Label.Location = new System.Drawing.Point(11, 3);
            this.idUsuario_Label.Name = "idUsuario_Label";
            this.idUsuario_Label.Size = new System.Drawing.Size(38, 15);
            this.idUsuario_Label.TabIndex = 17;
            this.idUsuario_Label.Text = "label1";
            this.idUsuario_Label.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(304, 255);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(107, 44);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardarCliente
            // 
            this.BtnGuardarCliente.BackColor = System.Drawing.Color.Green;
            this.BtnGuardarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarCliente.Location = new System.Drawing.Point(169, 255);
            this.BtnGuardarCliente.Name = "BtnGuardarCliente";
            this.BtnGuardarCliente.Size = new System.Drawing.Size(107, 44);
            this.BtnGuardarCliente.TabIndex = 14;
            this.BtnGuardarCliente.Text = "Guardar";
            this.BtnGuardarCliente.UseVisualStyleBackColor = false;
            this.BtnGuardarCliente.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PanelClientesImagen
            // 
            this.PanelClientesImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelClientesImagen.BackgroundImage")));
            this.PanelClientesImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelClientesImagen.Location = new System.Drawing.Point(691, 20);
            this.PanelClientesImagen.Name = "PanelClientesImagen";
            this.PanelClientesImagen.Size = new System.Drawing.Size(143, 106);
            this.PanelClientesImagen.TabIndex = 13;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(85, 218);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(326, 23);
            this.TxtCorreo.TabIndex = 11;
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(85, 175);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(326, 23);
            this.TxtCelular.TabIndex = 10;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(85, 134);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(326, 23);
            this.TxtTelefono.TabIndex = 9;
            this.TxtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono_Validating);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(85, 94);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(326, 23);
            this.TxtDireccion.TabIndex = 8;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDireccion_Validating);
            // 
            // TxtRuc
            // 
            this.TxtRuc.Location = new System.Drawing.Point(85, 57);
            this.TxtRuc.Name = "TxtRuc";
            this.TxtRuc.Size = new System.Drawing.Size(326, 23);
            this.TxtRuc.TabIndex = 7;
            this.TxtRuc.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRuc_Validating);
            // 
            // TxtNombresCliente
            // 
            this.TxtNombresCliente.Location = new System.Drawing.Point(85, 23);
            this.TxtNombresCliente.Name = "TxtNombresCliente";
            this.TxtNombresCliente.Size = new System.Drawing.Size(326, 23);
            this.TxtNombresCliente.TabIndex = 6;
            this.TxtNombresCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombresCliente_Validating);
            // 
            // LabelCorreo
            // 
            this.LabelCorreo.AutoSize = true;
            this.LabelCorreo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCorreo.Location = new System.Drawing.Point(12, 221);
            this.LabelCorreo.Name = "LabelCorreo";
            this.LabelCorreo.Size = new System.Drawing.Size(57, 20);
            this.LabelCorreo.TabIndex = 5;
            this.LabelCorreo.Text = "Correo:";
            // 
            // LabelCelular
            // 
            this.LabelCelular.AutoSize = true;
            this.LabelCelular.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCelular.Location = new System.Drawing.Point(11, 174);
            this.LabelCelular.Name = "LabelCelular";
            this.LabelCelular.Size = new System.Drawing.Size(58, 20);
            this.LabelCelular.TabIndex = 4;
            this.LabelCelular.Text = "Celular:";
            // 
            // LabelTelefono
            // 
            this.LabelTelefono.AutoSize = true;
            this.LabelTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTelefono.Location = new System.Drawing.Point(6, 137);
            this.LabelTelefono.Name = "LabelTelefono";
            this.LabelTelefono.Size = new System.Drawing.Size(70, 20);
            this.LabelTelefono.TabIndex = 3;
            this.LabelTelefono.Text = "Teléfono:";
            // 
            // LabelDireccion
            // 
            this.LabelDireccion.AutoSize = true;
            this.LabelDireccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDireccion.Location = new System.Drawing.Point(6, 97);
            this.LabelDireccion.Name = "LabelDireccion";
            this.LabelDireccion.Size = new System.Drawing.Size(75, 20);
            this.LabelDireccion.TabIndex = 2;
            this.LabelDireccion.Text = "Dirección:";
            // 
            // LabelRuc
            // 
            this.LabelRuc.AutoSize = true;
            this.LabelRuc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRuc.Location = new System.Drawing.Point(11, 57);
            this.LabelRuc.Name = "LabelRuc";
            this.LabelRuc.Size = new System.Drawing.Size(59, 20);
            this.LabelRuc.TabIndex = 1;
            this.LabelRuc.Text = "RUC/CI:";
            // 
            // LabelNombreCliente
            // 
            this.LabelNombreCliente.AutoSize = true;
            this.LabelNombreCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNombreCliente.Location = new System.Drawing.Point(11, 26);
            this.LabelNombreCliente.Name = "LabelNombreCliente";
            this.LabelNombreCliente.Size = new System.Drawing.Size(77, 20);
            this.LabelNombreCliente.TabIndex = 0;
            this.LabelNombreCliente.Text = "Nombres: ";
            // 
            // BtnGuardarEditado
            // 
            this.BtnGuardarEditado.BackColor = System.Drawing.Color.Green;
            this.BtnGuardarEditado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarEditado.Location = new System.Drawing.Point(169, 255);
            this.BtnGuardarEditado.Name = "BtnGuardarEditado";
            this.BtnGuardarEditado.Size = new System.Drawing.Size(107, 44);
            this.BtnGuardarEditado.TabIndex = 16;
            this.BtnGuardarEditado.Text = "Guardar";
            this.BtnGuardarEditado.UseVisualStyleBackColor = false;
            this.BtnGuardarEditado.Visible = false;
            this.BtnGuardarEditado.Click += new System.EventHandler(this.BtnGuardar_Editado);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 522);
            this.Controls.Add(this.PanelNuevoCliente);
            this.Controls.Add(this.DataGridViewClientes);
            this.Controls.Add(this.PanelCliente);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.PanelCliente.ResumeLayout(false);
            this.PanelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).EndInit();
            this.PanelNuevoCliente.ResumeLayout(false);
            this.PanelNuevoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCliente;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.TextBox TxtBuscarCliente;
        private System.Windows.Forms.DataGridView DataGridViewClientes;
        private System.Windows.Forms.Panel PanelNuevoCliente;
        private System.Windows.Forms.Label LabelNombreCliente;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtRuc;
        private System.Windows.Forms.TextBox TxtNombresCliente;
        private System.Windows.Forms.Label LabelCorreo;
        private System.Windows.Forms.Label LabelCelular;
        private System.Windows.Forms.Label LabelTelefono;
        private System.Windows.Forms.Label LabelDireccion;
        private System.Windows.Forms.Label LabelRuc;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardarCliente;
        private System.Windows.Forms.Panel PanelClientesImagen;
        private System.Windows.Forms.Button BtnGuardarEditado;
        private System.Windows.Forms.Label idUsuario_Label;
        private System.Windows.Forms.Label TipoPersona_LBL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}