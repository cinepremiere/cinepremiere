namespace WindowsFormsTest
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetaDeDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.películasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarOModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarOModificarSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.películasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.rHToolStripMenuItem,
            this.funcionesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.salasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeUsuarioToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cambioDeUsuarioToolStripMenuItem
            // 
            this.cambioDeUsuarioToolStripMenuItem.Name = "cambioDeUsuarioToolStripMenuItem";
            this.cambioDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.cambioDeUsuarioToolStripMenuItem.Text = "Cambio de Usuario";
            this.cambioDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambioDeUsuarioToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarVentaToolStripMenuItem,
            this.cancelarVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // generarVentaToolStripMenuItem
            // 
            this.generarVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletosToolStripMenuItem,
            this.membresíasToolStripMenuItem,
            this.tarjetaDeDescuentosToolStripMenuItem});
            this.generarVentaToolStripMenuItem.Name = "generarVentaToolStripMenuItem";
            this.generarVentaToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.generarVentaToolStripMenuItem.Text = "Generar Venta";
            // 
            // boletosToolStripMenuItem
            // 
            this.boletosToolStripMenuItem.Name = "boletosToolStripMenuItem";
            this.boletosToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.boletosToolStripMenuItem.Text = "Boletos";
            this.boletosToolStripMenuItem.Click += new System.EventHandler(this.boletosToolStripMenuItem_Click);
            // 
            // membresíasToolStripMenuItem
            // 
            this.membresíasToolStripMenuItem.Name = "membresíasToolStripMenuItem";
            this.membresíasToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.membresíasToolStripMenuItem.Text = "Membresías";
            this.membresíasToolStripMenuItem.Click += new System.EventHandler(this.membresíasToolStripMenuItem_Click);
            // 
            // tarjetaDeDescuentosToolStripMenuItem
            // 
            this.tarjetaDeDescuentosToolStripMenuItem.Name = "tarjetaDeDescuentosToolStripMenuItem";
            this.tarjetaDeDescuentosToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.tarjetaDeDescuentosToolStripMenuItem.Text = "Tarjeta de Descuentos";
            // 
            // cancelarVentaToolStripMenuItem
            // 
            this.cancelarVentaToolStripMenuItem.Name = "cancelarVentaToolStripMenuItem";
            this.cancelarVentaToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.cancelarVentaToolStripMenuItem.Text = "Cancelar Venta";
            this.cancelarVentaToolStripMenuItem.Click += new System.EventHandler(this.cancelarVentaToolStripMenuItem_Click);
            // 
            // películasToolStripMenuItem
            // 
            this.películasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.películasToolStripMenuItem.Name = "películasToolStripMenuItem";
            this.películasToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.películasToolStripMenuItem.Text = "Películas";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.agregarToolStripMenuItem.Text = "Agregar o Modificar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadísticasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.estadísticasToolStripMenuItem.Text = "Reportes de Ventas";
            this.estadísticasToolStripMenuItem.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click);
            // 
            // rHToolStripMenuItem
            // 
            this.rHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusariosToolStripMenuItem});
            this.rHToolStripMenuItem.Name = "rHToolStripMenuItem";
            this.rHToolStripMenuItem.Size = new System.Drawing.Size(48, 29);
            this.rHToolStripMenuItem.Text = "RH";
            // 
            // uusariosToolStripMenuItem
            // 
            this.uusariosToolStripMenuItem.Name = "uusariosToolStripMenuItem";
            this.uusariosToolStripMenuItem.Size = new System.Drawing.Size(335, 30);
            this.uusariosToolStripMenuItem.Text = "Registrar o modificar Usuarios";
            this.uusariosToolStripMenuItem.Click += new System.EventHandler(this.uusariosToolStripMenuItem_Click);
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOModificarToolStripMenuItem});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // agregarOModificarToolStripMenuItem
            // 
            this.agregarOModificarToolStripMenuItem.Name = "agregarOModificarToolStripMenuItem";
            this.agregarOModificarToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.agregarOModificarToolStripMenuItem.Text = "Agregar o Modificar";
            this.agregarOModificarToolStripMenuItem.Click += new System.EventHandler(this.agregarOModificarToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // pantallaToolStripMenuItem
            // 
            this.pantallaToolStripMenuItem.Name = "pantallaToolStripMenuItem";
            this.pantallaToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.pantallaToolStripMenuItem.Text = "Pantalla";
            this.pantallaToolStripMenuItem.Click += new System.EventHandler(this.pantallaToolStripMenuItem_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOModificarSalaToolStripMenuItem});
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.salasToolStripMenuItem.Text = "Salas";
            // 
            // agregarOModificarSalaToolStripMenuItem
            // 
            this.agregarOModificarSalaToolStripMenuItem.Name = "agregarOModificarSalaToolStripMenuItem";
            this.agregarOModificarSalaToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
            this.agregarOModificarSalaToolStripMenuItem.Text = "Agregar o Modificar Sala";
            this.agregarOModificarSalaToolStripMenuItem.Click += new System.EventHandler(this.agregarOModificarSalaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal CinePremier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem películasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uusariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarOModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetaDeDescuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarOModificarSalaToolStripMenuItem;
    }
}