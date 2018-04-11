namespace WindowsFormsTest
{
    partial class FrmVentas
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
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.dgvPeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHorario = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvBoletos = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvAsientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPeli,
            this.dgvHorario,
            this.dgvBoletos,
            this.dgvAsientos,
            this.dgvSubTotal,
            this.dgvIVA,
            this.dgvDescuento,
            this.dgvTotal});
            this.dgvVenta.Location = new System.Drawing.Point(-1, 0);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowTemplate.Height = 24;
            this.dgvVenta.Size = new System.Drawing.Size(1087, 300);
            this.dgvVenta.TabIndex = 0;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas);
            // 
            // dgvPeli
            // 
            this.dgvPeli.HeaderText = "Pelicula";
            this.dgvPeli.Name = "dgvPeli";
            // 
            // dgvHorario
            // 
            this.dgvHorario.HeaderText = "Horarios";
            this.dgvHorario.Name = "dgvHorario";
            // 
            // dgvBoletos
            // 
            this.dgvBoletos.HeaderText = "Boletos";
            this.dgvBoletos.Name = "dgvBoletos";
            // 
            // dgvAsientos
            // 
            this.dgvAsientos.HeaderText = "Asientos Seleccionados";
            this.dgvAsientos.Name = "dgvAsientos";
            // 
            // dgvSubTotal
            // 
            this.dgvSubTotal.HeaderText = "SubTotal";
            this.dgvSubTotal.Name = "dgvSubTotal";
            // 
            // dgvIVA
            // 
            this.dgvIVA.HeaderText = "IVA";
            this.dgvIVA.Name = "dgvIVA";
            // 
            // dgvDescuento
            // 
            this.dgvDescuento.HeaderText = "Descuentos";
            this.dgvDescuento.Name = "dgvDescuento";
            // 
            // dgvTotal
            // 
            this.dgvTotal.HeaderText = "Total";
            this.dgvTotal.Name = "dgvTotal";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 323);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1087, 300);
            this.dataGridView2.TabIndex = 1;
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsientos.Location = new System.Drawing.Point(12, 303);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(240, 37);
            this.lblAsientos.TabIndex = 2;
            this.lblAsientos.Text = "Asientos";
            this.lblAsientos.Visible = false;
            this.lblAsientos.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(15, 624);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(262, 39);
            this.BtnRegresar.TabIndex = 3;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(718, 624);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(262, 39);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Detalle de Venta";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 662);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.lblAsientos);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgvVenta);
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPeli;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvHorario;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvBoletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAsientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}