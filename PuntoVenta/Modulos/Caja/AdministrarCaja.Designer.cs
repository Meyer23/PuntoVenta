
namespace PuntoVenta.Modulos
{
    partial class AdministrarCaja
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
            this.PabelEstadoCaja = new System.Windows.Forms.Panel();
            this.TxtAdmEstadoCaja = new System.Windows.Forms.TextBox();
            this.LabelEstadoCaja = new System.Windows.Forms.Label();
            this.Lbl_SaldoActual = new System.Windows.Forms.Label();
            this.TxtSaldoIngresante = new System.Windows.Forms.TextBox();
            this.LblGuaranies = new System.Windows.Forms.Label();
            this.SaldoSistema = new System.Windows.Forms.Label();
            this.TxtTotalEnSistema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrarCaja = new System.Windows.Forms.Button();
            this.Label_idCaja = new System.Windows.Forms.Label();
            this.Txt_idCajaCierre = new System.Windows.Forms.TextBox();
            this.HoraCierrePicker = new System.Windows.Forms.DateTimePicker();
            this.LabelHoraCierre = new System.Windows.Forms.Label();
            this.PabelEstadoCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // PabelEstadoCaja
            // 
            this.PabelEstadoCaja.Controls.Add(this.TxtAdmEstadoCaja);
            this.PabelEstadoCaja.Controls.Add(this.LabelEstadoCaja);
            this.PabelEstadoCaja.Location = new System.Drawing.Point(10, 27);
            this.PabelEstadoCaja.Name = "PabelEstadoCaja";
            this.PabelEstadoCaja.Size = new System.Drawing.Size(387, 69);
            this.PabelEstadoCaja.TabIndex = 0;
            // 
            // TxtAdmEstadoCaja
            // 
            this.TxtAdmEstadoCaja.Enabled = false;
            this.TxtAdmEstadoCaja.Location = new System.Drawing.Point(106, 12);
            this.TxtAdmEstadoCaja.Name = "TxtAdmEstadoCaja";
            this.TxtAdmEstadoCaja.Size = new System.Drawing.Size(84, 23);
            this.TxtAdmEstadoCaja.TabIndex = 1;
            // 
            // LabelEstadoCaja
            // 
            this.LabelEstadoCaja.AutoSize = true;
            this.LabelEstadoCaja.Location = new System.Drawing.Point(15, 20);
            this.LabelEstadoCaja.Name = "LabelEstadoCaja";
            this.LabelEstadoCaja.Size = new System.Drawing.Size(85, 15);
            this.LabelEstadoCaja.TabIndex = 0;
            this.LabelEstadoCaja.Text = "Estado Actual: ";
            // 
            // Lbl_SaldoActual
            // 
            this.Lbl_SaldoActual.AutoSize = true;
            this.Lbl_SaldoActual.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SaldoActual.Location = new System.Drawing.Point(47, 105);
            this.Lbl_SaldoActual.Name = "Lbl_SaldoActual";
            this.Lbl_SaldoActual.Size = new System.Drawing.Size(100, 20);
            this.Lbl_SaldoActual.TabIndex = 1;
            this.Lbl_SaldoActual.Text = "Saldo Actual: ";
            // 
            // TxtSaldoIngresante
            // 
            this.TxtSaldoIngresante.Location = new System.Drawing.Point(176, 102);
            this.TxtSaldoIngresante.Name = "TxtSaldoIngresante";
            this.TxtSaldoIngresante.Size = new System.Drawing.Size(192, 23);
            this.TxtSaldoIngresante.TabIndex = 2;
            // 
            // LblGuaranies
            // 
            this.LblGuaranies.AutoSize = true;
            this.LblGuaranies.Location = new System.Drawing.Point(374, 110);
            this.LblGuaranies.Name = "LblGuaranies";
            this.LblGuaranies.Size = new System.Drawing.Size(23, 15);
            this.LblGuaranies.TabIndex = 3;
            this.LblGuaranies.Text = "Gs.";
            // 
            // SaldoSistema
            // 
            this.SaldoSistema.AutoSize = true;
            this.SaldoSistema.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaldoSistema.Location = new System.Drawing.Point(10, 155);
            this.SaldoSistema.Name = "SaldoSistema";
            this.SaldoSistema.Size = new System.Drawing.Size(137, 20);
            this.SaldoSistema.TabIndex = 4;
            this.SaldoSistema.Text = "Total en el Sistema:";
            // 
            // TxtTotalEnSistema
            // 
            this.TxtTotalEnSistema.Enabled = false;
            this.TxtTotalEnSistema.Location = new System.Drawing.Point(176, 152);
            this.TxtTotalEnSistema.Name = "TxtTotalEnSistema";
            this.TxtTotalEnSistema.Size = new System.Drawing.Size(192, 23);
            this.TxtTotalEnSistema.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gs.";
            // 
            // BtnCerrarCaja
            // 
            this.BtnCerrarCaja.Location = new System.Drawing.Point(176, 196);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(192, 48);
            this.BtnCerrarCaja.TabIndex = 7;
            this.BtnCerrarCaja.Text = "Cerrar Caja";
            this.BtnCerrarCaja.UseVisualStyleBackColor = true;
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
            // 
            // Label_idCaja
            // 
            this.Label_idCaja.AutoSize = true;
            this.Label_idCaja.Location = new System.Drawing.Point(12, 282);
            this.Label_idCaja.Name = "Label_idCaja";
            this.Label_idCaja.Size = new System.Drawing.Size(46, 15);
            this.Label_idCaja.TabIndex = 2;
            this.Label_idCaja.Text = "Id Caja:";
            // 
            // Txt_idCajaCierre
            // 
            this.Txt_idCajaCierre.Enabled = false;
            this.Txt_idCajaCierre.Location = new System.Drawing.Point(64, 274);
            this.Txt_idCajaCierre.Name = "Txt_idCajaCierre";
            this.Txt_idCajaCierre.Size = new System.Drawing.Size(47, 23);
            this.Txt_idCajaCierre.TabIndex = 3;
            // 
            // HoraCierrePicker
            // 
            this.HoraCierrePicker.Enabled = false;
            this.HoraCierrePicker.Location = new System.Drawing.Point(168, 274);
            this.HoraCierrePicker.Name = "HoraCierrePicker";
            this.HoraCierrePicker.Size = new System.Drawing.Size(200, 23);
            this.HoraCierrePicker.TabIndex = 2;
            // 
            // LabelHoraCierre
            // 
            this.LabelHoraCierre.AutoSize = true;
            this.LabelHoraCierre.Location = new System.Drawing.Point(168, 256);
            this.LabelHoraCierre.Name = "LabelHoraCierre";
            this.LabelHoraCierre.Size = new System.Drawing.Size(86, 15);
            this.LabelHoraCierre.TabIndex = 8;
            this.LabelHoraCierre.Text = "Hora de Cierre:";
            // 
            // AdministrarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 309);
            this.Controls.Add(this.LabelHoraCierre);
            this.Controls.Add(this.HoraCierrePicker);
            this.Controls.Add(this.Label_idCaja);
            this.Controls.Add(this.Txt_idCajaCierre);
            this.Controls.Add(this.BtnCerrarCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotalEnSistema);
            this.Controls.Add(this.SaldoSistema);
            this.Controls.Add(this.LblGuaranies);
            this.Controls.Add(this.TxtSaldoIngresante);
            this.Controls.Add(this.Lbl_SaldoActual);
            this.Controls.Add(this.PabelEstadoCaja);
            this.Name = "AdministrarCaja";
            this.Text = "Administración de Cajas";
            this.Load += new System.EventHandler(this.AdministrarCaja_Load);
            this.PabelEstadoCaja.ResumeLayout(false);
            this.PabelEstadoCaja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PabelEstadoCaja;
        private System.Windows.Forms.TextBox TxtAdmEstadoCaja;
        private System.Windows.Forms.Label LabelEstadoCaja;
        private System.Windows.Forms.Label Lbl_SaldoActual;
        private System.Windows.Forms.TextBox TxtSaldoIngresante;
        private System.Windows.Forms.Label LblGuaranies;
        private System.Windows.Forms.Label SaldoSistema;
        private System.Windows.Forms.TextBox TxtTotalEnSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrarCaja;
        private System.Windows.Forms.Label Label_idCaja;
        private System.Windows.Forms.TextBox Txt_idCajaCierre;
        private System.Windows.Forms.DateTimePicker HoraCierrePicker;
        private System.Windows.Forms.Label LabelHoraCierre;
    }
}