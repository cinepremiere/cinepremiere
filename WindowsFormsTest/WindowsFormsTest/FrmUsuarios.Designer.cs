namespace WindowsFormsTest
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.chkStatusUser = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelMovil = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelFijo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumExt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumInt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbSueldo = new System.Windows.Forms.ComboBox();
            this.dtmInicioContrato = new System.Windows.Forms.DateTimePicker();
            this.dtmInicioJornada = new System.Windows.Forms.DateTimePicker();
            this.dtmFinJornada = new System.Windows.Forms.DateTimePicker();
            this.btnRecargarTabla = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(1033, 149);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(249, 26);
            this.txtMaterno.TabIndex = 74;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(958, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 73;
            this.label17.Text = "Materno";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(184, 363);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(732, 26);
            this.txtBuscar.TabIndex = 72;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(114, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 71;
            this.label16.Text = "Buscar";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(116, 507);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(1162, 246);
            this.dgvUsuarios.TabIndex = 70;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(298, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 38);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(116, 427);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(176, 38);
            this.btnGuardarCliente.TabIndex = 68;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // chkStatusUser
            // 
            this.chkStatusUser.AutoSize = true;
            this.chkStatusUser.Location = new System.Drawing.Point(1176, 31);
            this.chkStatusUser.Name = "chkStatusUser";
            this.chkStatusUser.Size = new System.Drawing.Size(106, 24);
            this.chkStatusUser.TabIndex = 65;
            this.chkStatusUser.Text = "Habilitado";
            this.chkStatusUser.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(1103, 92);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(179, 26);
            this.txtPass.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1004, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = "Contraseña";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(675, 93);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(323, 26);
            this.txtMail.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(618, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 61;
            this.label13.Text = "mail";
            // 
            // txtTelMovil
            // 
            this.txtTelMovil.Location = new System.Drawing.Point(1056, 280);
            this.txtTelMovil.Name = "txtTelMovil";
            this.txtTelMovil.Size = new System.Drawing.Size(226, 26);
            this.txtTelMovil.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1018, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "Cel";
            // 
            // txtTelFijo
            // 
            this.txtTelFijo.Location = new System.Drawing.Point(832, 282);
            this.txtTelFijo.Name = "txtTelFijo";
            this.txtTelFijo.Size = new System.Drawing.Size(180, 26);
            this.txtTelFijo.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(795, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Tel";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(548, 283);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(241, 26);
            this.txtLocalidad.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Localidad";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(349, 283);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(100, 26);
            this.txtColonia.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Colonia";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(173, 283);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 26);
            this.txtCP.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "CP";
            // 
            // txtNumExt
            // 
            this.txtNumExt.Location = new System.Drawing.Point(922, 217);
            this.txtNumExt.Name = "txtNumExt";
            this.txtNumExt.Size = new System.Drawing.Size(139, 26);
            this.txtNumExt.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(856, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "No. Ext";
            // 
            // txtNumInt
            // 
            this.txtNumInt.Location = new System.Drawing.Point(1143, 215);
            this.txtNumInt.Name = "txtNumInt";
            this.txtNumInt.Size = new System.Drawing.Size(139, 26);
            this.txtNumInt.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1067, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "No. Int.";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(511, 215);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(332, 26);
            this.txtCalle.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Calle";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(173, 216);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(280, 26);
            this.txtCurp.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "CURP";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(675, 152);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(260, 26);
            this.txtPaterno.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Paterno";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(192, 151);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(396, 26);
            this.txtNombreUsuario.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Tipo Usuario";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(216, 29);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(201, 28);
            this.cmbTipoUsuario.TabIndex = 76;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(429, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 20);
            this.label18.TabIndex = 77;
            this.label18.Text = "Inicio de Contrato";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(837, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 20);
            this.label19.TabIndex = 79;
            this.label19.Text = "Inicio Jornada";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(117, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 20);
            this.label20.TabIndex = 81;
            this.label20.Text = "Fin Jornada";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(422, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 20);
            this.label21.TabIndex = 83;
            this.label21.Text = "Sueldo";
            // 
            // cmbSueldo
            // 
            this.cmbSueldo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSueldo.FormattingEnabled = true;
            this.cmbSueldo.Location = new System.Drawing.Point(487, 93);
            this.cmbSueldo.MaxDropDownItems = 20;
            this.cmbSueldo.Name = "cmbSueldo";
            this.cmbSueldo.Size = new System.Drawing.Size(121, 28);
            this.cmbSueldo.TabIndex = 84;
            // 
            // dtmInicioContrato
            // 
            this.dtmInicioContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmInicioContrato.Location = new System.Drawing.Point(569, 30);
            this.dtmInicioContrato.Name = "dtmInicioContrato";
            this.dtmInicioContrato.Size = new System.Drawing.Size(200, 26);
            this.dtmInicioContrato.TabIndex = 85;
            // 
            // dtmInicioJornada
            // 
            this.dtmInicioJornada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmInicioJornada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtmInicioJornada.Location = new System.Drawing.Point(951, 31);
            this.dtmInicioJornada.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtmInicioJornada.Name = "dtmInicioJornada";
            this.dtmInicioJornada.ShowUpDown = true;
            this.dtmInicioJornada.Size = new System.Drawing.Size(200, 26);
            this.dtmInicioJornada.TabIndex = 86;
            this.dtmInicioJornada.Value = new System.DateTime(2018, 4, 12, 23, 0, 0, 0);
            // 
            // dtmFinJornada
            // 
            this.dtmFinJornada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmFinJornada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtmFinJornada.Location = new System.Drawing.Point(217, 92);
            this.dtmFinJornada.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtmFinJornada.Name = "dtmFinJornada";
            this.dtmFinJornada.ShowUpDown = true;
            this.dtmFinJornada.Size = new System.Drawing.Size(200, 26);
            this.dtmFinJornada.TabIndex = 87;
            this.dtmFinJornada.Value = new System.DateTime(2018, 4, 12, 23, 0, 0, 0);
            // 
            // btnRecargarTabla
            // 
            this.btnRecargarTabla.Location = new System.Drawing.Point(481, 427);
            this.btnRecargarTabla.Name = "btnRecargarTabla";
            this.btnRecargarTabla.Size = new System.Drawing.Size(188, 38);
            this.btnRecargarTabla.TabIndex = 88;
            this.btnRecargarTabla.Text = "Recargar Tabla";
            this.btnRecargarTabla.UseVisualStyleBackColor = true;
            this.btnRecargarTabla.Click += new System.EventHandler(this.btnRecargarTabla_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(676, 427);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(167, 38);
            this.btnModificar.TabIndex = 89;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(850, 427);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 38);
            this.btnEliminar.TabIndex = 90;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(923, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 20);
            this.label15.TabIndex = 91;
            this.label15.Text = "Clave Usuario";
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Enabled = false;
            this.txtClaveUsuario.Location = new System.Drawing.Point(1037, 368);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(245, 26);
            this.txtClaveUsuario.TabIndex = 92;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 880);
            this.Controls.Add(this.txtClaveUsuario);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRecargarTabla);
            this.Controls.Add(this.dtmFinJornada);
            this.Controls.Add(this.dtmInicioJornada);
            this.Controls.Add(this.dtmInicioContrato);
            this.Controls.Add(this.cmbSueldo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.chkStatusUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTelMovil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTelFijo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumExt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumInt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.CheckBox chkStatusUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelMovil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelFijo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumExt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumInt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbSueldo;
        private System.Windows.Forms.DateTimePicker dtmInicioContrato;
        private System.Windows.Forms.DateTimePicker dtmInicioJornada;
        private System.Windows.Forms.DateTimePicker dtmFinJornada;
        private System.Windows.Forms.Button btnRecargarTabla;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtClaveUsuario;
    }
}