
namespace PuntoVenta.Modulos.VentanaPrincipal
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUnidadesMedidas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.MeuCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrarCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LabelRol = new System.Windows.Forms.Label();
            this.ImagenPanel = new System.Windows.Forms.Panel();
            this.TxtUsuario = new System.Windows.Forms.Label();
            this.MenuRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuarios,
            this.MenuRoles});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(270, 34);
            this.MenuUsuarios.Text = "Usuarios";
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuarios_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUnidadesMedidas,
            this.MenuProductos,
            this.MenuCategorias,
            this.MenuEmpleados});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // MenuUnidadesMedidas
            // 
            this.MenuUnidadesMedidas.Name = "MenuUnidadesMedidas";
            this.MenuUnidadesMedidas.Size = new System.Drawing.Size(278, 34);
            this.MenuUnidadesMedidas.Text = "Unidades de medida";
            this.MenuUnidadesMedidas.Click += new System.EventHandler(this.MenuUnidadesMedidas_Click);
            // 
            // MenuProductos
            // 
            this.MenuProductos.Name = "MenuProductos";
            this.MenuProductos.Size = new System.Drawing.Size(278, 34);
            this.MenuProductos.Text = "Productos";
            this.MenuProductos.Click += new System.EventHandler(this.MenuProductos_Click);
            // 
            // MenuCategorias
            // 
            this.MenuCategorias.Name = "MenuCategorias";
            this.MenuCategorias.Size = new System.Drawing.Size(278, 34);
            this.MenuCategorias.Text = "Categorías";
            this.MenuCategorias.Click += new System.EventHandler(this.MenuCategorias_Click);
            // 
            // MenuEmpleados
            // 
            this.MenuEmpleados.Name = "MenuEmpleados";
            this.MenuEmpleados.Size = new System.Drawing.Size(278, 34);
            this.MenuEmpleados.Text = "Empleados";
            this.MenuEmpleados.Click += new System.EventHandler(this.MenuEmpleados_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuClientes,
            this.MenuFacturas,
            this.MeuCaja});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // MenuClientes
            // 
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(178, 34);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.Click += new System.EventHandler(this.MenuClientes_Click);
            // 
            // MenuFacturas
            // 
            this.MenuFacturas.Name = "MenuFacturas";
            this.MenuFacturas.Size = new System.Drawing.Size(178, 34);
            this.MenuFacturas.Text = "Facturas";
            this.MenuFacturas.Click += new System.EventHandler(this.MenuFacuras_Click);
            // 
            // MeuCaja
            // 
            this.MeuCaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdministrarCaja});
            this.MeuCaja.Name = "MeuCaja";
            this.MeuCaja.Size = new System.Drawing.Size(178, 34);
            this.MeuCaja.Text = "Caja";
            this.MeuCaja.Click += new System.EventHandler(this.MeuCaja_Click);
            // 
            // AdministrarCaja
            // 
            this.AdministrarCaja.Name = "AdministrarCaja";
            this.AdministrarCaja.Size = new System.Drawing.Size(206, 34);
            this.AdministrarCaja.Text = "Administrar";
            this.AdministrarCaja.Click += new System.EventHandler(this.AdministrarCaja_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProveedores});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // MenuProveedores
            // 
            this.MenuProveedores.Name = "MenuProveedores";
            this.MenuProveedores.Size = new System.Drawing.Size(213, 34);
            this.MenuProveedores.Text = "Proveedores";
            this.MenuProveedores.Click += new System.EventHandler(this.MenuProveedores_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LabelRol);
            this.LoginPanel.Controls.Add(this.ImagenPanel);
            this.LoginPanel.Controls.Add(this.TxtUsuario);
            this.LoginPanel.Location = new System.Drawing.Point(834, 622);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(309, 117);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Visible = false;
            // 
            // LabelRol
            // 
            this.LabelRol.AutoSize = true;
            this.LabelRol.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRol.Location = new System.Drawing.Point(3, 58);
            this.LabelRol.Name = "LabelRol";
            this.LabelRol.Size = new System.Drawing.Size(48, 26);
            this.LabelRol.TabIndex = 2;
            this.LabelRol.Text = "Rol";
            // 
            // ImagenPanel
            // 
            this.ImagenPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagenPanel.BackgroundImage")));
            this.ImagenPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagenPanel.Location = new System.Drawing.Point(201, 12);
            this.ImagenPanel.Name = "ImagenPanel";
            this.ImagenPanel.Size = new System.Drawing.Size(94, 98);
            this.ImagenPanel.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.AutoSize = true;
            this.TxtUsuario.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtUsuario.Location = new System.Drawing.Point(3, 12);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(96, 26);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.Text = "Usuario";
            // 
            // MenuRoles
            // 
            this.MenuRoles.Name = "MenuRoles";
            this.MenuRoles.Size = new System.Drawing.Size(270, 34);
            this.MenuRoles.Text = "Roles";
            this.MenuRoles.Click += new System.EventHandler(this.MenuRoles_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 748);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaPrincipal";
            this.Text = "Sistema de Gestión Ferretería Portillo";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuProveedores;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuUnidadesMedidas;
        private System.Windows.Forms.ToolStripMenuItem MenuProductos;
        private System.Windows.Forms.ToolStripMenuItem MenuCategorias;
        private System.Windows.Forms.ToolStripMenuItem MenuFacturas;
        private System.Windows.Forms.ToolStripMenuItem MeuCaja;
        private System.Windows.Forms.ToolStripMenuItem AdministrarCaja;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label TxtUsuario;
        private System.Windows.Forms.Panel ImagenPanel;
        private System.Windows.Forms.Label LabelRol;
        private System.Windows.Forms.ToolStripMenuItem MenuEmpleados;
        private System.Windows.Forms.ToolStripMenuItem MenuRoles;
    }
}