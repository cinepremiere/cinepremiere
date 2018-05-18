namespace WindowsFormsTest
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblCuenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsTest.Properties.Resources.logoCP3;
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(111, 522);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Reestablecer Contraseña";
            this.linkLabel1.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(241, 571);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(150, 35);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "&Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(39, 571);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 35);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(39, 469);
            this.TxtContrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(349, 26);
            this.TxtContrasena.TabIndex = 10;
            this.TxtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContrasena_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(39, 380);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(349, 26);
            this.TxtUsuario.TabIndex = 8;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCuenta
            // 
            this.LblCuenta.AutoSize = true;
            this.LblCuenta.Location = new System.Drawing.Point(181, 340);
            this.LblCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCuenta.Name = "LblCuenta";
            this.LblCuenta.Size = new System.Drawing.Size(64, 20);
            this.LblCuenta.TabIndex = 7;
            this.LblCuenta.Text = "Usuario";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(432, 800);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblCuenta);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblCuenta;
    }
}

