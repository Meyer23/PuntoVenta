
namespace PuntoVenta.Modulos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsuario = new System.Windows.Forms.TextBox();
            txtContrasena = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            BtnLogin = new System.Windows.Forms.Button();
            BtnCancelar = new System.Windows.Forms.Button();
            datalistado = new System.Windows.Forms.DataGridView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)datalistado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(187, 45);
            txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(283, 31);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new System.Drawing.Point(187, 143);
            txtContrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new System.Drawing.Size(283, 31);
            txtContrasena.TabIndex = 1;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(187, 15);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 25);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(187, 113);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 25);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new System.Drawing.Point(187, 213);
            BtnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new System.Drawing.Size(121, 38);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += btnLogin_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new System.Drawing.Point(359, 213);
            BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(113, 38);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += btnCancelar_Click;
            // 
            // datalistado
            // 
            datalistado.AllowUserToAddRows = false;
            datalistado.AllowUserToResizeRows = false;
            datalistado.BackgroundColor = System.Drawing.Color.White;
            datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalistado.Location = new System.Drawing.Point(351, 93);
            datalistado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            datalistado.Name = "datalistado";
            datalistado.RowHeadersWidth = 62;
            datalistado.RowTemplate.Height = 25;
            datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            datalistado.Size = new System.Drawing.Size(70, 22);
            datalistado.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(17, 45);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(150, 148);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(504, 280);
            Controls.Add(pictureBox1);
            Controls.Add(datalistado);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "SGFP";
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            ((System.ComponentModel.ISupportInitialize)datalistado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}