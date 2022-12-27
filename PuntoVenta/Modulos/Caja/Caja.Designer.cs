
namespace PuntoVenta.Modulos
{
    partial class Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            this.PanelCaja = new System.Windows.Forms.Panel();
            this.BtnIniciarCaja = new System.Windows.Forms.Button();
            this.TxtFechaHora = new System.Windows.Forms.DateTimePicker();
            this.LabelGuaranies = new System.Windows.Forms.Label();
            this.TxtMontoInicial = new System.Windows.Forms.TextBox();
            this.LabelHoraApertura = new System.Windows.Forms.Label();
            this.LabelMontoInicial = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCaja
            // 
            this.PanelCaja.Controls.Add(this.BtnIniciarCaja);
            this.PanelCaja.Controls.Add(this.TxtFechaHora);
            this.PanelCaja.Controls.Add(this.LabelGuaranies);
            this.PanelCaja.Controls.Add(this.TxtMontoInicial);
            this.PanelCaja.Controls.Add(this.LabelHoraApertura);
            this.PanelCaja.Controls.Add(this.LabelMontoInicial);
            this.PanelCaja.Location = new System.Drawing.Point(12, 12);
            this.PanelCaja.Name = "PanelCaja";
            this.PanelCaja.Size = new System.Drawing.Size(348, 188);
            this.PanelCaja.TabIndex = 0;
            // 
            // BtnIniciarCaja
            // 
            this.BtnIniciarCaja.Location = new System.Drawing.Point(116, 130);
            this.BtnIniciarCaja.Name = "BtnIniciarCaja";
            this.BtnIniciarCaja.Size = new System.Drawing.Size(135, 23);
            this.BtnIniciarCaja.TabIndex = 8;
            this.BtnIniciarCaja.Text = "Iniciar Caja";
            this.BtnIniciarCaja.UseVisualStyleBackColor = true;
            this.BtnIniciarCaja.Click += new System.EventHandler(this.BtnIniciarCaja_Click);
            // 
            // TxtFechaHora
            // 
            this.TxtFechaHora.Enabled = false;
            this.TxtFechaHora.Location = new System.Drawing.Point(116, 76);
            this.TxtFechaHora.Name = "TxtFechaHora";
            this.TxtFechaHora.Size = new System.Drawing.Size(135, 23);
            this.TxtFechaHora.TabIndex = 7;
            // 
            // LabelGuaranies
            // 
            this.LabelGuaranies.AutoSize = true;
            this.LabelGuaranies.Location = new System.Drawing.Point(257, 28);
            this.LabelGuaranies.Name = "LabelGuaranies";
            this.LabelGuaranies.Size = new System.Drawing.Size(23, 15);
            this.LabelGuaranies.TabIndex = 6;
            this.LabelGuaranies.Text = "Gs.";
            // 
            // TxtMontoInicial
            // 
            this.TxtMontoInicial.Location = new System.Drawing.Point(116, 20);
            this.TxtMontoInicial.Name = "TxtMontoInicial";
            this.TxtMontoInicial.Size = new System.Drawing.Size(135, 23);
            this.TxtMontoInicial.TabIndex = 5;
            // 
            // LabelHoraApertura
            // 
            this.LabelHoraApertura.AutoSize = true;
            this.LabelHoraApertura.Location = new System.Drawing.Point(74, 82);
            this.LabelHoraApertura.Name = "LabelHoraApertura";
            this.LabelHoraApertura.Size = new System.Drawing.Size(36, 15);
            this.LabelHoraApertura.TabIndex = 4;
            this.LabelHoraApertura.Text = "Hora:";
            // 
            // LabelMontoInicial
            // 
            this.LabelMontoInicial.AutoSize = true;
            this.LabelMontoInicial.Location = new System.Drawing.Point(30, 28);
            this.LabelMontoInicial.Name = "LabelMontoInicial";
            this.LabelMontoInicial.Size = new System.Drawing.Size(80, 15);
            this.LabelMontoInicial.TabIndex = 0;
            this.LabelMontoInicial.Text = "Monto Inicial:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 214);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelCaja);
            this.Name = "Caja";
            this.Text = "Apertura de Caja";
            this.PanelCaja.ResumeLayout(false);
            this.PanelCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCaja;
        private System.Windows.Forms.Button BtnIniciarCaja;
        private System.Windows.Forms.DateTimePicker TxtFechaHora;
        private System.Windows.Forms.Label LabelGuaranies;
        private System.Windows.Forms.TextBox TxtMontoInicial;
        private System.Windows.Forms.Label LabelHoraApertura;
        private System.Windows.Forms.Label LabelMontoInicial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}