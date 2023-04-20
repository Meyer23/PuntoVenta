namespace PuntoVenta.Modulos.Timbrado_Ok
{
    partial class Timbrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timbrado));
            PanelTimbrado = new System.Windows.Forms.Panel();
            ChkActivo = new System.Windows.Forms.CheckBox();
            BtnGuardar = new System.Windows.Forms.Button();
            BtnCancelar = new System.Windows.Forms.Button();
            NroHastaUpDown = new System.Windows.Forms.NumericUpDown();
            NroDesdeUpDown = new System.Windows.Forms.NumericUpDown();
            DateTimeFinVigencia = new System.Windows.Forms.DateTimePicker();
            DateTimeInicioVigencia = new System.Windows.Forms.DateTimePicker();
            TimbradoUpDown = new System.Windows.Forms.NumericUpDown();
            ComboBoxGrupoDocumento = new System.Windows.Forms.ComboBox();
            LblGrupoDocumento = new System.Windows.Forms.Label();
            LblNroHasta = new System.Windows.Forms.Label();
            LblVigenciaFin = new System.Windows.Forms.Label();
            LblNroDesde = new System.Windows.Forms.Label();
            LblVigenciaInicio = new System.Windows.Forms.Label();
            LblTimbrado = new System.Windows.Forms.Label();
            BtnGuardarEditado = new System.Windows.Forms.Button();
            PanelVerTimbrado = new System.Windows.Forms.Panel();
            BtnCancelarAgregar = new System.Windows.Forms.Button();
            BtnNuevo = new System.Windows.Forms.Button();
            DataGridViewTimbrado = new System.Windows.Forms.DataGridView();
            EditarTimbrado = new System.Windows.Forms.DataGridViewImageColumn();
            PanelTimbrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NroHastaUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NroDesdeUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TimbradoUpDown).BeginInit();
            PanelVerTimbrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTimbrado).BeginInit();
            SuspendLayout();
            // 
            // PanelTimbrado
            // 
            PanelTimbrado.Controls.Add(ChkActivo);
            PanelTimbrado.Controls.Add(BtnGuardar);
            PanelTimbrado.Controls.Add(BtnCancelar);
            PanelTimbrado.Controls.Add(NroHastaUpDown);
            PanelTimbrado.Controls.Add(NroDesdeUpDown);
            PanelTimbrado.Controls.Add(DateTimeFinVigencia);
            PanelTimbrado.Controls.Add(DateTimeInicioVigencia);
            PanelTimbrado.Controls.Add(TimbradoUpDown);
            PanelTimbrado.Controls.Add(ComboBoxGrupoDocumento);
            PanelTimbrado.Controls.Add(LblGrupoDocumento);
            PanelTimbrado.Controls.Add(LblNroHasta);
            PanelTimbrado.Controls.Add(LblVigenciaFin);
            PanelTimbrado.Controls.Add(LblNroDesde);
            PanelTimbrado.Controls.Add(LblVigenciaInicio);
            PanelTimbrado.Controls.Add(LblTimbrado);
            PanelTimbrado.Controls.Add(BtnGuardarEditado);
            PanelTimbrado.Location = new System.Drawing.Point(12, 12);
            PanelTimbrado.Name = "PanelTimbrado";
            PanelTimbrado.Size = new System.Drawing.Size(1062, 435);
            PanelTimbrado.TabIndex = 0;
            // 
            // ChkActivo
            // 
            ChkActivo.AutoSize = true;
            ChkActivo.Checked = true;
            ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            ChkActivo.Location = new System.Drawing.Point(203, 349);
            ChkActivo.Name = "ChkActivo";
            ChkActivo.Size = new System.Drawing.Size(88, 29);
            ChkActivo.TabIndex = 14;
            ChkActivo.Text = "Activo";
            ChkActivo.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new System.Drawing.Point(531, 389);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new System.Drawing.Size(112, 34);
            BtnGuardar.TabIndex = 13;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new System.Drawing.Point(661, 389);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(112, 34);
            BtnCancelar.TabIndex = 12;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // NroHastaUpDown
            // 
            NroHastaUpDown.Location = new System.Drawing.Point(203, 296);
            NroHastaUpDown.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            NroHastaUpDown.Name = "NroHastaUpDown";
            NroHastaUpDown.Size = new System.Drawing.Size(570, 31);
            NroHastaUpDown.TabIndex = 11;
            // 
            // NroDesdeUpDown
            // 
            NroDesdeUpDown.Location = new System.Drawing.Point(203, 239);
            NroDesdeUpDown.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            NroDesdeUpDown.Name = "NroDesdeUpDown";
            NroDesdeUpDown.Size = new System.Drawing.Size(570, 31);
            NroDesdeUpDown.TabIndex = 10;
            // 
            // DateTimeFinVigencia
            // 
            DateTimeFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DateTimeFinVigencia.Location = new System.Drawing.Point(203, 183);
            DateTimeFinVigencia.Name = "DateTimeFinVigencia";
            DateTimeFinVigencia.Size = new System.Drawing.Size(570, 31);
            DateTimeFinVigencia.TabIndex = 9;
            // 
            // DateTimeInicioVigencia
            // 
            DateTimeInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DateTimeInicioVigencia.Location = new System.Drawing.Point(203, 125);
            DateTimeInicioVigencia.Name = "DateTimeInicioVigencia";
            DateTimeInicioVigencia.Size = new System.Drawing.Size(570, 31);
            DateTimeInicioVigencia.TabIndex = 8;
            // 
            // TimbradoUpDown
            // 
            TimbradoUpDown.Location = new System.Drawing.Point(203, 76);
            TimbradoUpDown.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            TimbradoUpDown.Name = "TimbradoUpDown";
            TimbradoUpDown.Size = new System.Drawing.Size(570, 31);
            TimbradoUpDown.TabIndex = 7;
            // 
            // ComboBoxGrupoDocumento
            // 
            ComboBoxGrupoDocumento.FormattingEnabled = true;
            ComboBoxGrupoDocumento.Location = new System.Drawing.Point(203, 24);
            ComboBoxGrupoDocumento.Name = "ComboBoxGrupoDocumento";
            ComboBoxGrupoDocumento.Size = new System.Drawing.Size(570, 33);
            ComboBoxGrupoDocumento.TabIndex = 6;
            // 
            // LblGrupoDocumento
            // 
            LblGrupoDocumento.AutoSize = true;
            LblGrupoDocumento.Location = new System.Drawing.Point(18, 32);
            LblGrupoDocumento.Name = "LblGrupoDocumento";
            LblGrupoDocumento.Size = new System.Drawing.Size(165, 25);
            LblGrupoDocumento.TabIndex = 5;
            LblGrupoDocumento.Text = "Grupo Documento:";
            // 
            // LblNroHasta
            // 
            LblNroHasta.AutoSize = true;
            LblNroHasta.Location = new System.Drawing.Point(18, 302);
            LblNroHasta.Name = "LblNroHasta";
            LblNroHasta.Size = new System.Drawing.Size(100, 25);
            LblNroHasta.TabIndex = 4;
            LblNroHasta.Text = "Nro. Hasta:";
            // 
            // LblVigenciaFin
            // 
            LblVigenciaFin.AutoSize = true;
            LblVigenciaFin.Location = new System.Drawing.Point(18, 183);
            LblVigenciaFin.Name = "LblVigenciaFin";
            LblVigenciaFin.Size = new System.Drawing.Size(110, 25);
            LblVigenciaFin.TabIndex = 3;
            LblVigenciaFin.Text = "Fin Vigencia:";
            // 
            // LblNroDesde
            // 
            LblNroDesde.AutoSize = true;
            LblNroDesde.Location = new System.Drawing.Point(18, 245);
            LblNroDesde.Name = "LblNroDesde";
            LblNroDesde.Size = new System.Drawing.Size(101, 25);
            LblNroDesde.TabIndex = 2;
            LblNroDesde.Text = "Nro Desde:";
            // 
            // LblVigenciaInicio
            // 
            LblVigenciaInicio.AutoSize = true;
            LblVigenciaInicio.Location = new System.Drawing.Point(18, 125);
            LblVigenciaInicio.Name = "LblVigenciaInicio";
            LblVigenciaInicio.Size = new System.Drawing.Size(129, 25);
            LblVigenciaInicio.TabIndex = 1;
            LblVigenciaInicio.Text = "Inicio Vigencia:";
            // 
            // LblTimbrado
            // 
            LblTimbrado.AutoSize = true;
            LblTimbrado.Location = new System.Drawing.Point(18, 76);
            LblTimbrado.Name = "LblTimbrado";
            LblTimbrado.Size = new System.Drawing.Size(132, 25);
            LblTimbrado.TabIndex = 0;
            LblTimbrado.Text = "Nro. Timbrado:";
            // 
            // BtnGuardarEditado
            // 
            BtnGuardarEditado.Location = new System.Drawing.Point(531, 389);
            BtnGuardarEditado.Name = "BtnGuardarEditado";
            BtnGuardarEditado.Size = new System.Drawing.Size(112, 34);
            BtnGuardarEditado.TabIndex = 15;
            BtnGuardarEditado.Text = "Guardar";
            BtnGuardarEditado.UseVisualStyleBackColor = true;
            BtnGuardarEditado.Click += BtnGuardarEditado_Click;
            // 
            // PanelVerTimbrado
            // 
            PanelVerTimbrado.Controls.Add(BtnCancelarAgregar);
            PanelVerTimbrado.Controls.Add(BtnNuevo);
            PanelVerTimbrado.Controls.Add(DataGridViewTimbrado);
            PanelVerTimbrado.Location = new System.Drawing.Point(12, 9);
            PanelVerTimbrado.Name = "PanelVerTimbrado";
            PanelVerTimbrado.Size = new System.Drawing.Size(1062, 426);
            PanelVerTimbrado.TabIndex = 1;
            // 
            // BtnCancelarAgregar
            // 
            BtnCancelarAgregar.Location = new System.Drawing.Point(802, 280);
            BtnCancelarAgregar.Name = "BtnCancelarAgregar";
            BtnCancelarAgregar.Size = new System.Drawing.Size(112, 34);
            BtnCancelarAgregar.TabIndex = 2;
            BtnCancelarAgregar.Text = "Cancelar";
            BtnCancelarAgregar.UseVisualStyleBackColor = true;
            BtnCancelarAgregar.Click += BtnCancelarAgregar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new System.Drawing.Point(932, 280);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new System.Drawing.Size(112, 34);
            BtnNuevo.TabIndex = 1;
            BtnNuevo.Text = "Agregar";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // DataGridViewTimbrado
            // 
            DataGridViewTimbrado.AllowUserToAddRows = false;
            DataGridViewTimbrado.AllowUserToDeleteRows = false;
            DataGridViewTimbrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTimbrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { EditarTimbrado });
            DataGridViewTimbrado.Location = new System.Drawing.Point(3, 24);
            DataGridViewTimbrado.Name = "DataGridViewTimbrado";
            DataGridViewTimbrado.RowHeadersWidth = 62;
            DataGridViewTimbrado.RowTemplate.Height = 33;
            DataGridViewTimbrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DataGridViewTimbrado.Size = new System.Drawing.Size(1039, 225);
            DataGridViewTimbrado.TabIndex = 0;
            DataGridViewTimbrado.CellClick += EditarT;
            // 
            // EditarTimbrado
            // 
            EditarTimbrado.HeaderText = "Editar";
            EditarTimbrado.Image = (System.Drawing.Image)resources.GetObject("EditarTimbrado.Image");
            EditarTimbrado.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            EditarTimbrado.MinimumWidth = 8;
            EditarTimbrado.Name = "EditarTimbrado";
            EditarTimbrado.Width = 150;
            // 
            // Timbrado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 492);
            Controls.Add(PanelVerTimbrado);
            Controls.Add(PanelTimbrado);
            Name = "Timbrado";
            Text = "Timbrado";
            PanelTimbrado.ResumeLayout(false);
            PanelTimbrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NroHastaUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)NroDesdeUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)TimbradoUpDown).EndInit();
            PanelVerTimbrado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewTimbrado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelTimbrado;
        private System.Windows.Forms.Label LblGrupoDocumento;
        private System.Windows.Forms.Label LblNroHasta;
        private System.Windows.Forms.Label LblVigenciaFin;
        private System.Windows.Forms.Label LblNroDesde;
        private System.Windows.Forms.Label LblVigenciaInicio;
        private System.Windows.Forms.Label LblTimbrado;
        private System.Windows.Forms.ComboBox ComboBoxGrupoDocumento;
        private System.Windows.Forms.DateTimePicker DateTimeInicioVigencia;
        private System.Windows.Forms.NumericUpDown TimbradoUpDown;
        private System.Windows.Forms.NumericUpDown NroHastaUpDown;
        private System.Windows.Forms.NumericUpDown NroDesdeUpDown;
        private System.Windows.Forms.DateTimePicker DateTimeFinVigencia;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel PanelVerTimbrado;
        private System.Windows.Forms.DataGridView DataGridViewTimbrado;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridViewImageColumn EditarTimbrado;
        private System.Windows.Forms.Button BtnCancelarAgregar;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.Button BtnGuardarEditado;
    }
}