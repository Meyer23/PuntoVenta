
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            MenuRoles = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { administraciónToolStripMenuItem, configuraciónToolStripMenuItem, stockToolStripMenuItem, ventasToolStripMenuItem, comprasToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuUsuarios, MenuRoles });
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            administraciónToolStripMenuItem.Text = "Administración";
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new System.Drawing.Size(270, 34);
            MenuUsuarios.Text = "Usuarios";
            MenuUsuarios.Click += MenuUsuarios_Click;
            // 
            // MenuRoles
            // 
            MenuRoles.Name = "MenuRoles";
            MenuRoles.Size = new System.Drawing.Size(270, 34);
            MenuRoles.Text = "Roles";
            MenuRoles.Click += MenuRoles_Click;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuUnidadesMedidas, MenuProductos, MenuCategorias, MenuEmpleados });
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // MenuUnidadesMedidas
            // 
            MenuUnidadesMedidas.Name = "MenuUnidadesMedidas";
            MenuUnidadesMedidas.Size = new System.Drawing.Size(278, 34);
            MenuUnidadesMedidas.Text = "Unidades de medida";
            MenuUnidadesMedidas.Click += MenuUnidadesMedidas_Click;
            // 
            // MenuProductos
            // 
            MenuProductos.Name = "MenuProductos";
            MenuProductos.Size = new System.Drawing.Size(278, 34);
            MenuProductos.Text = "Productos";
            MenuProductos.Click += MenuProductos_Click;
            // 
            // MenuCategorias
            // 
            MenuCategorias.Name = "MenuCategorias";
            MenuCategorias.Size = new System.Drawing.Size(278, 34);
            MenuCategorias.Text = "Categorías";
            MenuCategorias.Click += MenuCategorias_Click;
            // 
            // MenuEmpleados
            // 
            MenuEmpleados.Name = "MenuEmpleados";
            MenuEmpleados.Size = new System.Drawing.Size(278, 34);
            MenuEmpleados.Text = "Empleados";
            MenuEmpleados.Click += MenuEmpleados_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuClientes, MenuFacturas, MeuCaja });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // MenuClientes
            // 
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new System.Drawing.Size(178, 34);
            MenuClientes.Text = "Clientes";
            MenuClientes.Click += MenuClientes_Click;
            // 
            // MenuFacturas
            // 
            MenuFacturas.Name = "MenuFacturas";
            MenuFacturas.Size = new System.Drawing.Size(178, 34);
            MenuFacturas.Text = "Facturas";
            MenuFacturas.Click += MenuFacuras_Click;
            // 
            // MeuCaja
            // 
            MeuCaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { AdministrarCaja });
            MeuCaja.Name = "MeuCaja";
            MeuCaja.Size = new System.Drawing.Size(178, 34);
            MeuCaja.Text = "Caja";
            MeuCaja.Click += MeuCaja_Click;
            // 
            // AdministrarCaja
            // 
            AdministrarCaja.Name = "AdministrarCaja";
            AdministrarCaja.Size = new System.Drawing.Size(206, 34);
            AdministrarCaja.Text = "Administrar";
            AdministrarCaja.Click += AdministrarCaja_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuProveedores });
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // MenuProveedores
            // 
            MenuProveedores.Name = "MenuProveedores";
            MenuProveedores.Size = new System.Drawing.Size(213, 34);
            MenuProveedores.Text = "Proveedores";
            MenuProveedores.Click += MenuProveedores_Click;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(LabelRol);
            LoginPanel.Controls.Add(ImagenPanel);
            LoginPanel.Controls.Add(TxtUsuario);
            LoginPanel.Location = new System.Drawing.Point(834, 622);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new System.Drawing.Size(309, 117);
            LoginPanel.TabIndex = 1;
            LoginPanel.Visible = false;
            // 
            // LabelRol
            // 
            LabelRol.AutoSize = true;
            LabelRol.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LabelRol.Location = new System.Drawing.Point(3, 58);
            LabelRol.Name = "LabelRol";
            LabelRol.Size = new System.Drawing.Size(48, 26);
            LabelRol.TabIndex = 2;
            LabelRol.Text = "Rol";
            // 
            // ImagenPanel
            // 
            ImagenPanel.BackgroundImage = (System.Drawing.Image)resources.GetObject("ImagenPanel.BackgroundImage");
            ImagenPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ImagenPanel.Location = new System.Drawing.Point(201, 12);
            ImagenPanel.Name = "ImagenPanel";
            ImagenPanel.Size = new System.Drawing.Size(94, 98);
            ImagenPanel.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            TxtUsuario.AutoSize = true;
            TxtUsuario.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtUsuario.Location = new System.Drawing.Point(3, 12);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new System.Drawing.Size(96, 26);
            TxtUsuario.TabIndex = 0;
            TxtUsuario.Text = "Usuario";
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 748);
            Controls.Add(LoginPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "VentanaPrincipal";
            Text = "Sistema de Gestión Ferretería Portillo";
            Load += VentanaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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