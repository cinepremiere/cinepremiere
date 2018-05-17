namespace WindowsFormsTest
{
    partial class FrmVentasSemana
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartPeliYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvPeli = new System.Windows.Forms.DataGridView();
            this.chartPeliMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbYearPeli = new System.Windows.Forms.ComboBox();
            this.cmbMonthPeli = new System.Windows.Forms.ComboBox();
            this.btnPeliBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSucursalPeli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartSalaYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvSala = new System.Windows.Forms.DataGridView();
            this.chartSalaMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbYearSala = new System.Windows.Forms.ComboBox();
            this.cmbMonthSala = new System.Windows.Forms.ComboBox();
            this.btnSalaBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSucursalSala = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeliYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeliMonth)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalaYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalaMonth)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1125, 1014);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1117, 981);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Película";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartPeliYear);
            this.groupBox1.Controls.Add(this.dgvPeli);
            this.groupBox1.Controls.Add(this.chartPeliMonth);
            this.groupBox1.Location = new System.Drawing.Point(3, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1111, 850);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Película";
            // 
            // chartPeliYear
            // 
            chartArea11.Name = "ChartArea1";
            this.chartPeliYear.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartPeliYear.Legends.Add(legend11);
            this.chartPeliYear.Location = new System.Drawing.Point(37, 346);
            this.chartPeliYear.Name = "chartPeliYear";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartPeliYear.Series.Add(series11);
            this.chartPeliYear.Size = new System.Drawing.Size(1054, 263);
            this.chartPeliYear.TabIndex = 4;
            this.chartPeliYear.Text = "chart3";
            // 
            // dgvPeli
            // 
            this.dgvPeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeli.Location = new System.Drawing.Point(26, 632);
            this.dgvPeli.Name = "dgvPeli";
            this.dgvPeli.RowTemplate.Height = 28;
            this.dgvPeli.Size = new System.Drawing.Size(1065, 212);
            this.dgvPeli.TabIndex = 3;
            // 
            // chartPeliMonth
            // 
            chartArea12.Name = "ChartArea1";
            this.chartPeliMonth.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartPeliMonth.Legends.Add(legend12);
            this.chartPeliMonth.Location = new System.Drawing.Point(37, 59);
            this.chartPeliMonth.Name = "chartPeliMonth";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartPeliMonth.Series.Add(series12);
            this.chartPeliMonth.Size = new System.Drawing.Size(1054, 263);
            this.chartPeliMonth.TabIndex = 2;
            this.chartPeliMonth.Text = "chart2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbYearPeli);
            this.groupBox3.Controls.Add(this.cmbMonthPeli);
            this.groupBox3.Controls.Add(this.btnPeliBuscar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbSucursalPeli);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1105, 106);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Periodo";
            // 
            // cmbYearPeli
            // 
            this.cmbYearPeli.FormattingEnabled = true;
            this.cmbYearPeli.Location = new System.Drawing.Point(267, 59);
            this.cmbYearPeli.Name = "cmbYearPeli";
            this.cmbYearPeli.Size = new System.Drawing.Size(195, 28);
            this.cmbYearPeli.TabIndex = 15;
            // 
            // cmbMonthPeli
            // 
            this.cmbMonthPeli.FormattingEnabled = true;
            this.cmbMonthPeli.Location = new System.Drawing.Point(11, 60);
            this.cmbMonthPeli.Name = "cmbMonthPeli";
            this.cmbMonthPeli.Size = new System.Drawing.Size(179, 28);
            this.cmbMonthPeli.TabIndex = 14;
            // 
            // btnPeliBuscar
            // 
            this.btnPeliBuscar.Location = new System.Drawing.Point(814, 50);
            this.btnPeliBuscar.Name = "btnPeliBuscar";
            this.btnPeliBuscar.Size = new System.Drawing.Size(180, 39);
            this.btnPeliBuscar.TabIndex = 13;
            this.btnPeliBuscar.Text = "Buscar";
            this.btnPeliBuscar.UseVisualStyleBackColor = true;
            this.btnPeliBuscar.Click += new System.EventHandler(this.btnPeliBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sucursal";
            // 
            // cmbSucursalPeli
            // 
            this.cmbSucursalPeli.FormattingEnabled = true;
            this.cmbSucursalPeli.Location = new System.Drawing.Point(522, 61);
            this.cmbSucursalPeli.Name = "cmbSucursalPeli";
            this.cmbSucursalPeli.Size = new System.Drawing.Size(198, 28);
            this.cmbSucursalPeli.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mes";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1117, 981);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Sala";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartSalaYear);
            this.groupBox2.Controls.Add(this.dgvSala);
            this.groupBox2.Controls.Add(this.chartSalaMonth);
            this.groupBox2.Location = new System.Drawing.Point(3, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1111, 850);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por Sala";
            // 
            // chartSalaYear
            // 
            chartArea9.Name = "ChartArea1";
            this.chartSalaYear.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartSalaYear.Legends.Add(legend9);
            this.chartSalaYear.Location = new System.Drawing.Point(37, 346);
            this.chartSalaYear.Name = "chartSalaYear";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartSalaYear.Series.Add(series9);
            this.chartSalaYear.Size = new System.Drawing.Size(1054, 263);
            this.chartSalaYear.TabIndex = 4;
            this.chartSalaYear.Text = "chart1";
            // 
            // dgvSala
            // 
            this.dgvSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSala.Location = new System.Drawing.Point(37, 632);
            this.dgvSala.Name = "dgvSala";
            this.dgvSala.RowTemplate.Height = 28;
            this.dgvSala.Size = new System.Drawing.Size(1054, 212);
            this.dgvSala.TabIndex = 3;
            // 
            // chartSalaMonth
            // 
            chartArea10.Name = "ChartArea1";
            this.chartSalaMonth.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartSalaMonth.Legends.Add(legend10);
            this.chartSalaMonth.Location = new System.Drawing.Point(37, 59);
            this.chartSalaMonth.Name = "chartSalaMonth";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartSalaMonth.Series.Add(series10);
            this.chartSalaMonth.Size = new System.Drawing.Size(1054, 263);
            this.chartSalaMonth.TabIndex = 2;
            this.chartSalaMonth.Text = "chart4";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbYearSala);
            this.groupBox4.Controls.Add(this.cmbMonthSala);
            this.groupBox4.Controls.Add(this.btnSalaBuscar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbSucursalSala);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1105, 106);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Periodo";
            // 
            // cmbYearSala
            // 
            this.cmbYearSala.FormattingEnabled = true;
            this.cmbYearSala.Location = new System.Drawing.Point(267, 59);
            this.cmbYearSala.Name = "cmbYearSala";
            this.cmbYearSala.Size = new System.Drawing.Size(195, 28);
            this.cmbYearSala.TabIndex = 15;
            // 
            // cmbMonthSala
            // 
            this.cmbMonthSala.FormattingEnabled = true;
            this.cmbMonthSala.Location = new System.Drawing.Point(11, 60);
            this.cmbMonthSala.Name = "cmbMonthSala";
            this.cmbMonthSala.Size = new System.Drawing.Size(179, 28);
            this.cmbMonthSala.TabIndex = 14;
            // 
            // btnSalaBuscar
            // 
            this.btnSalaBuscar.Location = new System.Drawing.Point(814, 50);
            this.btnSalaBuscar.Name = "btnSalaBuscar";
            this.btnSalaBuscar.Size = new System.Drawing.Size(180, 39);
            this.btnSalaBuscar.TabIndex = 13;
            this.btnSalaBuscar.Text = "Buscar";
            this.btnSalaBuscar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sucursal";
            // 
            // cmbSucursalSala
            // 
            this.cmbSucursalSala.FormattingEnabled = true;
            this.cmbSucursalSala.Location = new System.Drawing.Point(522, 61);
            this.cmbSucursalSala.Name = "cmbSucursalSala";
            this.cmbSucursalSala.Size = new System.Drawing.Size(198, 28);
            this.cmbSucursalSala.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mes";
            // 
            // FrmVentasSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1149, 1028);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmVentasSemana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Ventas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmVentasSemana_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPeliYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeliMonth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSalaYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalaMonth)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPeliYear;
        private System.Windows.Forms.DataGridView dgvPeli;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPeliMonth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbYearPeli;
        private System.Windows.Forms.ComboBox cmbMonthPeli;
        private System.Windows.Forms.Button btnPeliBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSucursalPeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalaYear;
        private System.Windows.Forms.DataGridView dgvSala;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalaMonth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbYearSala;
        private System.Windows.Forms.ComboBox cmbMonthSala;
        private System.Windows.Forms.Button btnSalaBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSucursalSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}