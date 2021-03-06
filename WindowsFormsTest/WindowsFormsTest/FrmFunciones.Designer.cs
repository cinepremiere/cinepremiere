﻿namespace WindowsFormsTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFunciones));
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
            this.dtmHoraIni = new System.Windows.Forms.DateTimePicker();
            this.chkPeliDisp = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPeliculas
            // 
            this.cmbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeliculas.FormattingEnabled = true;
            this.cmbPeliculas.Location = new System.Drawing.Point(90, 4);
            this.cmbPeliculas.Name = "cmbPeliculas";
            this.cmbPeliculas.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.cmbSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalas.FormattingEnabled = true;
            this.cmbSalas.Location = new System.Drawing.Point(571, 5);
            this.cmbSalas.Name = "cmbSalas";
            this.cmbSalas.Size = new System.Drawing.Size(80, 28);
            this.cmbSalas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Función";
            // 
            // cmbTipoFuncion
            // 
            this.cmbTipoFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFuncion.FormattingEnabled = true;
            this.cmbTipoFuncion.Location = new System.Drawing.Point(768, 5);
            this.cmbTipoFuncion.Name = "cmbTipoFuncion";
            this.cmbTipoFuncion.Size = new System.Drawing.Size(128, 28);
            this.cmbTipoFuncion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(952, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idioma";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(1029, 5);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 28);
            this.cmbIdioma.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subtítulos";
            // 
            // cmbSubtitulos
            // 
            this.cmbSubtitulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubtitulos.FormattingEnabled = true;
            this.cmbSubtitulos.Location = new System.Drawing.Point(422, 70);
            this.cmbSubtitulos.Name = "cmbSubtitulos";
            this.cmbSubtitulos.Size = new System.Drawing.Size(121, 28);
            this.cmbSubtitulos.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha Inicio";
            // 
            // dtmFechaProy
            // 
            this.dtmFechaProy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaProy.Location = new System.Drawing.Point(658, 72);
            this.dtmFechaProy.Name = "dtmFechaProy";
            this.dtmFechaProy.Size = new System.Drawing.Size(200, 26);
            this.dtmFechaProy.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hora Inicio";
            // 
            // dtmHoraIni
            // 
            this.dtmHoraIni.CustomFormat = "hh:mm";
            this.dtmHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmHoraIni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtmHoraIni.Location = new System.Drawing.Point(115, 72);
            this.dtmHoraIni.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtmHoraIni.Name = "dtmHoraIni";
            this.dtmHoraIni.ShowUpDown = true;
            this.dtmHoraIni.Size = new System.Drawing.Size(200, 26);
            this.dtmHoraIni.TabIndex = 13;
            this.dtmHoraIni.Value = new System.DateTime(2018, 4, 12, 23, 0, 0, 0);
            // 
            // chkPeliDisp
            // 
            this.chkPeliDisp.AutoSize = true;
            this.chkPeliDisp.Location = new System.Drawing.Point(915, 75);
            this.chkPeliDisp.Name = "chkPeliDisp";
            this.chkPeliDisp.Size = new System.Drawing.Size(109, 24);
            this.chkPeliDisp.TabIndex = 14;
            this.chkPeliDisp.Text = "Disponible";
            this.chkPeliDisp.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Image Path";
            // 
            // txtImgPath
            // 
            this.txtImgPath.Location = new System.Drawing.Point(169, 149);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.Size = new System.Drawing.Size(427, 26);
            this.txtImgPath.TabIndex = 16;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(602, 144);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(131, 39);
            this.btnExaminar.TabIndex = 17;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(9, 293);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 55);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 55);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.AllowUserToOrderColumns = true;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Location = new System.Drawing.Point(17, 383);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowTemplate.Height = 28;
            this.dgvFunciones.Size = new System.Drawing.Size(1133, 250);
            this.dgvFunciones.TabIndex = 20;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(378, 293);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(172, 55);
            this.btnRecargar.TabIndex = 21;
            this.btnRecargar.Text = "Recargar Tabla";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(557, 293);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(176, 55);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(739, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(193, 55);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar Por Id";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(99, 241);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(720, 26);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(791, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Clave Función";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(907, 152);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(221, 26);
            this.txtClave.TabIndex = 27;
            // 
            // FrmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 684);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtImgPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkPeliDisp);
            this.Controls.Add(this.dtmHoraIni);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DateTimePicker dtmHoraIni;
        private System.Windows.Forms.CheckBox chkPeliDisp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClave;
    }
}