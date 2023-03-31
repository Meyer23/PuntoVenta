
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
            this.MenuRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUnidadesMedidas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeImpuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tiposDeValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 

            menuStrip1 = new System.Windows.Forms.MenuStrip();
            administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            MenuRoles = new System.Windows.Forms.ToolStripMenuItem();
            permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuUnidadesMedidas = new System.Windows.Forms.ToolStripMenuItem();
            MenuProductos = new System.Windows.Forms.ToolStripMenuItem();
            MenuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            MenuEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            MenuFacturas = new System.Windows.Forms.ToolStripMenuItem();
            MeuCaja = new System.Windows.Forms.ToolStripMenuItem();
            AdministrarCaja = new System.Windows.Forms.ToolStripMenuItem();
            comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            LoginPanel = new System.Windows.Forms.Panel();
            LabelRol = new System.Windows.Forms.Label();
            ImagenPanel = new System.Windows.Forms.Panel();
            TxtUsuario = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            //
            administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuUsuarios, MenuRoles, permisosToolStripMenuItem });
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            administraciónToolStripMenuItem.Text = "Administración";
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuarios,
            this.MenuRoles});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(119, 22);
            this.MenuUsuarios.Text = "Usuarios";
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuarios_Click);
            // 
            // MenuRoles
            // 
            this.MenuRoles.Name = "MenuRoles";
            this.MenuRoles.Size = new System.Drawing.Size(119, 22);
            this.MenuRoles.Text = "Roles";
            this.MenuRoles.Click += new System.EventHandler(this.MenuRoles_Click);
            // 
            // permisosToolStripMenuItem
            // 
            permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            permisosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            permisosToolStripMenuItem.Text = "Permisos";
            permisosToolStripMenuItem.Click += MenuPermisos_Click;
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUnidadesMedidas,
            this.MenuProductos,
            this.MenuCategorias,
            this.MenuEmpleados,
            this.tiposDeImpuestoToolStripMenuItem,
            this.tiposDeValoresToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // MenuUnidadesMedidas
            // 
            this.MenuUnidadesMedidas.Name = "MenuUnidadesMedidas";
            this.MenuUnidadesMedidas.Size = new System.Drawing.Size(182, 22);
            this.MenuUnidadesMedidas.Text = "Unidades de medida";
            this.MenuUnidadesMedidas.Click += new System.EventHandler(this.MenuUnidadesMedidas_Click);
            // 
            // MenuProductos
            // 
            this.MenuProductos.Name = "MenuProductos";
            this.MenuProductos.Size = new System.Drawing.Size(182, 22);
            this.MenuProductos.Text = "Productos";
            this.MenuProductos.Click += new System.EventHandler(this.MenuProductos_Click);
            // 
            // MenuCategorias
            // 
            this.MenuCategorias.Name = "MenuCategorias";
            this.MenuCategorias.Size = new System.Drawing.Size(182, 22);
            this.MenuCategorias.Text = "Categorías";
            this.MenuCategorias.Click += new System.EventHandler(this.MenuCategorias_Click);
            // 
            // MenuEmpleados
            // 
            this.MenuEmpleados.Name = "MenuEmpleados";
            this.MenuEmpleados.Size = new System.Drawing.Size(182, 22);
            this.MenuEmpleados.Text = "Empleados";
            this.MenuEmpleados.Click += new System.EventHandler(this.MenuEmpleados_Click);
            // 
            // tiposDeImpuestoToolStripMenuItem
            // 
            this.tiposDeImpuestoToolStripMenuItem.Name = "tiposDeImpuestoToolStripMenuItem";
            this.tiposDeImpuestoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tiposDeImpuestoToolStripMenuItem.Text = "Tipos de Impuesto";
            this.tiposDeImpuestoToolStripMenuItem.Click += new System.EventHandler(this.MenuImpuestos_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuClientes,
            this.MenuFacturas,
            this.MeuCaja});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // MenuClientes
            // 
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(118, 22);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.Click += new System.EventHandler(this.MenuClientes_Click);
            // 
            // MenuFacturas
            // 
            this.MenuFacturas.Name = "MenuFacturas";
            this.MenuFacturas.Size = new System.Drawing.Size(118, 22);
            this.MenuFacturas.Text = "Facturas";
            this.MenuFacturas.Click += new System.EventHandler(this.MenuFacuras_Click);
            // 
            // MeuCaja
            // 
            this.MeuCaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdministrarCaja});
            this.MeuCaja.Name = "MeuCaja";
            this.MeuCaja.Size = new System.Drawing.Size(118, 22);
            this.MeuCaja.Text = "Caja";
            this.MeuCaja.Click += new System.EventHandler(this.MeuCaja_Click);
            // 
            // AdministrarCaja
            // 
            this.AdministrarCaja.Name = "AdministrarCaja";
            this.AdministrarCaja.Size = new System.Drawing.Size(136, 22);
            this.AdministrarCaja.Text = "Administrar";
            this.AdministrarCaja.Click += new System.EventHandler(this.AdministrarCaja_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProveedores});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // MenuProveedores
            // 
            this.MenuProveedores.Name = "MenuProveedores";
            this.MenuProveedores.Size = new System.Drawing.Size(139, 22);
            this.MenuProveedores.Text = "Proveedores";
            this.MenuProveedores.Click += new System.EventHandler(this.MenuProveedores_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LabelRol);
            this.LoginPanel.Controls.Add(this.ImagenPanel);
            this.LoginPanel.Controls.Add(this.TxtUsuario);
            this.LoginPanel.Location = new System.Drawing.Point(584, 373);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(216, 70);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Visible = false;
            // 
            // LabelRol
            // 
            this.LabelRol.AutoSize = true;
            this.LabelRol.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRol.Location = new System.Drawing.Point(2, 35);
            this.LabelRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelRol.Name = "LabelRol";
            this.LabelRol.Size = new System.Drawing.Size(32, 18);
            this.LabelRol.TabIndex = 2;
            this.LabelRol.Text = "Rol";
            // 
            // ImagenPanel
            // 
            this.ImagenPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagenPanel.BackgroundImage")));
            this.ImagenPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagenPanel.Location = new System.Drawing.Point(141, 7);
            this.ImagenPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ImagenPanel.Name = "ImagenPanel";
            this.ImagenPanel.Size = new System.Drawing.Size(66, 59);
            this.ImagenPanel.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.AutoSize = true;
            this.TxtUsuario.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtUsuario.Location = new System.Drawing.Point(2, 7);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(64, 18);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.Text = "Usuario";
            // 
            // tiposDeValoresToolStripMenuItem
            // 
            this.tiposDeValoresToolStripMenuItem.Name = "tiposDeValoresToolStripMenuItem";
            this.tiposDeValoresToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tiposDeValoresToolStripMenuItem.Text = "Tipos de Valores";
            this.tiposDeValoresToolStripMenuItem.Click += new System.EventHandler(this.MenuValores);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "Sistema de Gestión Ferretería Portillo";
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
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeImpuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeValoresToolStripMenuItem;
    }
}