namespace WindowsFormsTest
{
    partial class FrmFunciones
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
            this.cmbPeliculas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSalas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoFuncion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSubtitulos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmFechaProy = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtmHoraProy = new System.Windows.Forms.DateTimePicker();
            this.chkPeliDisp = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPeliculas
            // 
            this.cmbPeliculas.FormattingEnabled = true;
            this.cmbPeliculas.Location = new System.Drawing.Point(90, 4);
            this.cmbPeliculas.Name = "cmbPeliculas";
            this.cmbPeliculas.Size = new System.Drawing.Size(420, 28);
            this.cmbPeliculas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peliculas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salas";
            // 
            // cmbSalas
            // 
            this.cmbSalas.FormattingEnabled = true;
            this.cmbSalas.Location = new System.Drawing.Point(573, 4);
            this.cmbSalas.Name = "cmbSalas";
            this.cmbSalas.Size = new System.Drawing.Size(230, 28);
            this.cmbSalas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(809, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Función";
            // 
            // cmbTipoFuncion
            // 
            this.cmbTipoFuncion.FormattingEnabled = true;
            this.cmbTipoFuncion.Location = new System.Drawing.Point(915, 4);
            this.cmbTipoFuncion.Name = "cmbTipoFuncion";
            this.cmbTipoFuncion.Size = new System.Drawing.Size(235, 28);
            this.cmbTipoFuncion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idioma";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(90, 71);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 28);
            this.cmbIdioma.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subtítulos";
            // 
            // cmbSubtitulos
            // 
            this.cmbSubtitulos.FormattingEnabled = true;
            this.cmbSubtitulos.Location = new System.Drawing.Point(309, 71);
            this.cmbSubtitulos.Name = "cmbSubtitulos";
            this.cmbSubtitulos.Size = new System.Drawing.Size(121, 28);
            this.cmbSubtitulos.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha Proyección";
            // 
            // dtmFechaProy
            // 
            this.dtmFechaProy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaProy.Location = new System.Drawing.Point(590, 74);
            this.dtmFechaProy.Name = "dtmFechaProy";
            this.dtmFechaProy.Size = new System.Drawing.Size(200, 26);
            this.dtmFechaProy.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(809, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hora Proyección";
            // 
            // dtmHoraProy
            // 
            this.dtmHoraProy.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmHoraProy.Location = new System.Drawing.Point(950, 76);
            this.dtmHoraProy.Name = "dtmHoraProy";
            this.dtmHoraProy.Size = new System.Drawing.Size(200, 26);
            this.dtmHoraProy.TabIndex = 13;
            // 
            // chkPeliDisp
            // 
            this.chkPeliDisp.AutoSize = true;
            this.chkPeliDisp.Location = new System.Drawing.Point(185, 162);
            this.chkPeliDisp.Name = "chkPeliDisp";
            this.chkPeliDisp.Size = new System.Drawing.Size(109, 24);
            this.chkPeliDisp.TabIndex = 14;
            this.chkPeliDisp.Text = "Disponible";
            this.chkPeliDisp.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Image Path";
            // 
            // txtImgPath
            // 
            this.txtImgPath.Location = new System.Drawing.Point(399, 159);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.Size = new System.Drawing.Size(427, 26);
            this.txtImgPath.TabIndex = 16;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(833, 159);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(125, 26);
            this.btnExaminar.TabIndex = 17;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(358, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 37);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(601, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 37);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.AllowUserToOrderColumns = true;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Location = new System.Drawing.Point(17, 290);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowTemplate.Height = 28;
            this.dgvFunciones.Size = new System.Drawing.Size(1133, 250);
            this.dgvFunciones.TabIndex = 20;
            // 
            // FrmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 684);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtImgPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkPeliDisp);
            this.Controls.Add(this.dtmHoraProy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtmFechaProy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSubtitulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoFuncion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSalas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPeliculas);
            this.Name = "FrmFunciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFunciones";
            this.Load += new System.EventHandler(this.FrmFunciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPeliculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSalas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoFuncion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSubtitulos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtmFechaProy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtmHoraProy;
        private System.Windows.Forms.CheckBox chkPeliDisp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvFunciones;
    }
}