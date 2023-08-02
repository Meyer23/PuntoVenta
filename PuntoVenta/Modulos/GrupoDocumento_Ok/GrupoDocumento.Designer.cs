namespace PuntoVenta.Modulos.GrupoDocumento_Ok
{
    partial class GrupoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupoDocumento));
            PanelVerDocumentos = new System.Windows.Forms.Panel();
            BtnAgregar = new System.Windows.Forms.Button();
            BtnSalir = new System.Windows.Forms.Button();
            DataGridViewDocumentos = new System.Windows.Forms.DataGridView();
            EditarGrupo = new System.Windows.Forms.DataGridViewImageColumn();
            PanelAgregarDocumento = new System.Windows.Forms.Panel();
            ChkGrupoActivo = new System.Windows.Forms.CheckBox();
            TxTGrupoDocumento = new System.Windows.Forms.TextBox();
            LblDescripcionGrupo = new System.Windows.Forms.Label();
            BtnGuardarGrupo = new System.Windows.Forms.Button();
            BtnSalirDocumento = new System.Windows.Forms.Button();
            GuardarEditado = new System.Windows.Forms.Button();
            PanelVerDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDocumentos).BeginInit();
            PanelAgregarDocumento.SuspendLayout();
            SuspendLayout();
            // 
            // PanelVerDocumentos
            // 
            PanelVerDocumentos.BackColor = System.Drawing.SystemColors.HighlightText;
            PanelVerDocumentos.Controls.Add(BtnAgregar);
            PanelVerDocumentos.Controls.Add(BtnSalir);
            PanelVerDocumentos.Controls.Add(DataGridViewDocumentos);
            PanelVerDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelVerDocumentos.Location = new System.Drawing.Point(0, 0);
            PanelVerDocumentos.Name = "PanelVerDocumentos";
            PanelVerDocumentos.Size = new System.Drawing.Size(749, 360);
            PanelVerDocumentos.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new System.Drawing.Point(332, 233);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new System.Drawing.Size(104, 32);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new System.Drawing.Point(492, 233);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new System.Drawing.Size(104, 32);
            BtnSalir.TabIndex = 2;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // DataGridViewDocumentos
            // 
            DataGridViewDocumentos.AllowUserToAddRows = false;
            DataGridViewDocumentos.AllowUserToDeleteRows = false;
            DataGridViewDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { EditarGrupo });
            DataGridViewDocumentos.Location = new System.Drawing.Point(11, 50);
            DataGridViewDocumentos.Name = "DataGridViewDocumentos";
            DataGridViewDocumentos.RowHeadersWidth = 62;
            DataGridViewDocumentos.RowTemplate.Height = 33;
            DataGridViewDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DataGridViewDocumentos.Size = new System.Drawing.Size(585, 164);
            DataGridViewDocumentos.TabIndex = 0;
            DataGridViewDocumentos.CellContentClick += EditarGrupoDocumento;
            // 
            // EditarGrupo
            // 
            EditarGrupo.HeaderText = "Editar";
            EditarGrupo.Image = (System.Drawing.Image)resources.GetObject("EditarGrupo.Image");
            EditarGrupo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            EditarGrupo.MinimumWidth = 8;
            EditarGrupo.Name = "EditarGrupo";
            EditarGrupo.Width = 150;
            // 
            // PanelAgregarDocumento
            // 
            PanelAgregarDocumento.BackColor = System.Drawing.SystemColors.HighlightText;
            PanelAgregarDocumento.Controls.Add(ChkGrupoActivo);
            PanelAgregarDocumento.Controls.Add(TxTGrupoDocumento);
            PanelAgregarDocumento.Controls.Add(LblDescripcionGrupo);
            PanelAgregarDocumento.Controls.Add(BtnGuardarGrupo);
            PanelAgregarDocumento.Controls.Add(BtnSalirDocumento);
            PanelAgregarDocumento.Controls.Add(GuardarEditado);
            PanelAgregarDocumento.Location = new System.Drawing.Point(152, 21);
            PanelAgregarDocumento.Name = "PanelAgregarDocumento";
            PanelAgregarDocumento.Size = new System.Drawing.Size(642, 214);
            PanelAgregarDocumento.TabIndex = 1;
            // 
            // ChkGrupoActivo
            // 
            ChkGrupoActivo.AutoSize = true;
            ChkGrupoActivo.Checked = true;
            ChkGrupoActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            ChkGrupoActivo.Location = new System.Drawing.Point(145, 108);
            ChkGrupoActivo.Name = "ChkGrupoActivo";
            ChkGrupoActivo.Size = new System.Drawing.Size(88, 29);
            ChkGrupoActivo.TabIndex = 2;
            ChkGrupoActivo.Text = "Activo";
            ChkGrupoActivo.UseVisualStyleBackColor = true;
            // 
            // TxTGrupoDocumento
            // 
            TxTGrupoDocumento.Location = new System.Drawing.Point(145, 44);
            TxTGrupoDocumento.Name = "TxTGrupoDocumento";
            TxTGrupoDocumento.Size = new System.Drawing.Size(480, 31);
            TxTGrupoDocumento.TabIndex = 1;
            // 
            // LblDescripcionGrupo
            // 
            LblDescripcionGrupo.AutoSize = true;
            LblDescripcionGrupo.Location = new System.Drawing.Point(31, 50);
            LblDescripcionGrupo.Name = "LblDescripcionGrupo";
            LblDescripcionGrupo.Size = new System.Drawing.Size(108, 25);
            LblDescripcionGrupo.TabIndex = 0;
            LblDescripcionGrupo.Text = "Descripcion:";
            // 
            // BtnGuardarGrupo
            // 
            BtnGuardarGrupo.Location = new System.Drawing.Point(145, 154);
            BtnGuardarGrupo.Name = "BtnGuardarGrupo";
            BtnGuardarGrupo.Size = new System.Drawing.Size(112, 34);
            BtnGuardarGrupo.TabIndex = 3;
            BtnGuardarGrupo.Text = "Guardar";
            BtnGuardarGrupo.UseVisualStyleBackColor = true;
            BtnGuardarGrupo.Click += BtnGuardarGrupo_Click;
            // 
            // BtnSalirDocumento
            // 
            BtnSalirDocumento.Location = new System.Drawing.Point(281, 154);
            BtnSalirDocumento.Name = "BtnSalirDocumento";
            BtnSalirDocumento.Size = new System.Drawing.Size(112, 34);
            BtnSalirDocumento.TabIndex = 4;
            BtnSalirDocumento.Text = "Salir";
            BtnSalirDocumento.UseVisualStyleBackColor = true;
            BtnSalirDocumento.Click += BtnSalirDocumento_Click;
            // 
            // GuardarEditado
            // 
            GuardarEditado.Location = new System.Drawing.Point(145, 154);
            GuardarEditado.Name = "GuardarEditado";
            GuardarEditado.Size = new System.Drawing.Size(112, 34);
            GuardarEditado.TabIndex = 5;
            GuardarEditado.Text = "Guardar";
            GuardarEditado.UseVisualStyleBackColor = true;
            GuardarEditado.Click += GuardarEditado_Click;
            // 
            // GrupoDocumento
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(749, 360);
            Controls.Add(PanelVerDocumentos);
            Controls.Add(PanelAgregarDocumento);
            Name = "GrupoDocumento";
            Text = "Grupo de Documentos";
            PanelVerDocumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewDocumentos).EndInit();
            PanelAgregarDocumento.ResumeLayout(false);
            PanelAgregarDocumento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelVerDocumentos;
        private System.Windows.Forms.DataGridView DataGridViewDocumentos;
        private System.Windows.Forms.DataGridViewImageColumn EditarGrupo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Panel PanelAgregarDocumento;
        private System.Windows.Forms.Button BtnSalirDocumento;
        private System.Windows.Forms.Button BtnGuardarGrupo;
        private System.Windows.Forms.CheckBox ChkGrupoActivo;
        private System.Windows.Forms.TextBox TxTGrupoDocumento;
        private System.Windows.Forms.Label LblDescripcionGrupo;
        private System.Windows.Forms.Button GuardarEditado;
    }
}