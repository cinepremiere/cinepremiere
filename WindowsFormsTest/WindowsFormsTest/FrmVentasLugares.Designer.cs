namespace WindowsFormsTest
{
    partial class FrmVentasLugares
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
            this.label1 = new System.Windows.Forms.Label();
            this.flpButacas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxPantalla = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(844, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANTALLA";
            // 
            // flpButacas
            // 
            this.flpButacas.Location = new System.Drawing.Point(13, 263);
            this.flpButacas.Name = "flpButacas";
            this.flpButacas.Size = new System.Drawing.Size(1793, 645);
            this.flpButacas.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(436, 914);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(462, 86);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(925, 914);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(461, 86);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pbxPantalla
            // 
            this.pbxPantalla.Image = global::WindowsFormsTest.Properties.Resources.PantallaCine;
            this.pbxPantalla.Location = new System.Drawing.Point(13, 28);
            this.pbxPantalla.Name = "pbxPantalla";
            this.pbxPantalla.Size = new System.Drawing.Size(1600, 50);
            this.pbxPantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPantalla.TabIndex = 1;
            this.pbxPantalla.TabStop = false;
            // 
            // FrmVentasLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1012);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.flpButacas);
            this.Controls.Add(this.pbxPantalla);
            this.Controls.Add(this.label1);
            this.Name = "FrmVentasLugares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecciona los Asientos";
            this.Load += new System.EventHandler(this.FrmVentasLugares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPantalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxPantalla;
        private System.Windows.Forms.FlowLayoutPanel flpButacas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}