namespace WindowsFormsTest
{
    partial class FrmPeliculas
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
            this.txtNombrePeli = new System.Windows.Forms.TextBox();
            this.cmbClasifica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDistrib = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtmEstreno = new System.Windows.Forms.DateTimePicker();
            this.dtmRetiro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.chbDisponible = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtArchivoBD = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Película";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombrePeli
            // 
            this.txtNombrePeli.Location = new System.Drawing.Point(33, 52);
            this.txtNombrePeli.MaxLength = 100;
            this.txtNombrePeli.Name = "txtNombrePeli";
            this.txtNombrePeli.Size = new System.Drawing.Size(783, 26);
            this.txtNombrePeli.TabIndex = 1;
            // 
            // cmbClasifica
            // 
            this.cmbClasifica.FormattingEnabled = true;
            this.cmbClasifica.Location = new System.Drawing.Point(840, 52);
            this.cmbClasifica.Name = "cmbClasifica";
            this.cmbClasifica.Size = new System.Drawing.Size(200, 28);
            this.cmbClasifica.TabIndex = 2;
            this.cmbClasifica.Text = "Seleccionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clasificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distribuidor";
            // 
            // cmbDistrib
            // 
            this.cmbDistrib.FormattingEnabled = true;
            this.cmbDistrib.Location = new System.Drawing.Point(33, 142);
            this.cmbDistrib.Name = "cmbDistrib";
            this.cmbDistrib.Size = new System.Drawing.Size(288, 28);
            this.cmbDistrib.TabIndex = 5;
            this.cmbDistrib.Text = "Seleccionar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(482, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 39);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Estreno";
            // 
            // dtmEstreno
            // 
            this.dtmEstreno.Location = new System.Drawing.Point(616, 142);
            this.dtmEstreno.Name = "dtmEstreno";
            this.dtmEstreno.Size = new System.Drawing.Size(200, 26);
            this.dtmEstreno.TabIndex = 8;
            this.dtmEstreno.ValueChanged += new System.EventHandler(this.dtmEstreno_ValueChanged);
            // 
            // dtmRetiro
            // 
            this.dtmRetiro.Location = new System.Drawing.Point(840, 142);
            this.dtmRetiro.Name = "dtmRetiro";
            this.dtmRetiro.Size = new System.Drawing.Size(200, 26);
            this.dtmRetiro.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(836, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Retiro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Duración";
            // 
            // numDuracion
            // 
            this.numDuracion.Location = new System.Drawing.Point(338, 142);
            this.numDuracion.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(256, 26);
            this.numDuracion.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.AllowUserToOrderColumns = true;
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPeliculas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(33, 346);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.RowTemplate.Height = 28;
            this.dgvPeliculas.Size = new System.Drawing.Size(1040, 237);
            this.dgvPeliculas.TabIndex = 15;
            this.dgvPeliculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellClick);
            // 
            // chbDisponible
            // 
            this.chbDisponible.AutoSize = true;
            this.chbDisponible.Location = new System.Drawing.Point(850, 222);
            this.chbDisponible.Name = "chbDisponible";
            this.chbDisponible.Size = new System.Drawing.Size(109, 24);
            this.chbDisponible.TabIndex = 16;
            this.chbDisponible.Text = "Disponible";
            this.chbDisponible.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Archivo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtArchivoBD
            // 
            this.txtArchivoBD.Location = new System.Drawing.Point(163, 222);
            this.txtArchivoBD.Name = "txtArchivoBD";
            this.txtArchivoBD.Size = new System.Drawing.Size(652, 26);
            this.txtArchivoBD.TabIndex = 18;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(638, 283);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 39);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 839);
            this.Controls.Add(this.txtArchivoBD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbDisponible);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.numDuracion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtmRetiro);
            this.Controls.Add(this.dtmEstreno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbDistrib);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClasifica);
            this.Controls.Add(this.txtNombrePeli);
            this.Controls.Add(this.label1);
            this.Name = "FrmPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Películas";
            this.Load += new System.EventHandler(this.FrmPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePeli;
        private System.Windows.Forms.ComboBox cmbClasifica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDistrib;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtmEstreno;
        private System.Windows.Forms.DateTimePicker dtmRetiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.CheckBox chbDisponible;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArchivoBD;
        private System.Windows.Forms.Button btnModificar;
    }
}