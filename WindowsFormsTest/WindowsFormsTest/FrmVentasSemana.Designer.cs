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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(11, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 811);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(992, 782);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Película";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartPeliYear);
            this.groupBox1.Controls.Add(this.dgvPeli);
            this.groupBox1.Controls.Add(this.chartPeliMonth);
            this.groupBox1.Location = new System.Drawing.Point(3, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(988, 680);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Película";
            // 
            // chartPeliYear
            // 
            chartArea5.Name = "ChartArea1";
            this.chartPeliYear.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartPeliYear.Legends.Add(legend5);
            this.chartPeliYear.Location = new System.Drawing.Point(33, 277);
            this.chartPeliYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartPeliYear.Name = "chartPeliYear";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartPeliYear.Series.Add(series5);
            this.chartPeliYear.Size = new System.Drawing.Size(937, 210);
            this.chartPeliYear.TabIndex = 4;
            this.chartPeliYear.Text = "chart3";
            // 
            // dgvPeli
            // 
            this.dgvPeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeli.Location = new System.Drawing.Point(23, 506);
            this.dgvPeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPeli.Name = "dgvPeli";
            this.dgvPeli.RowTemplate.Height = 28;
            this.dgvPeli.Size = new System.Drawing.Size(947, 170);
            this.dgvPeli.TabIndex = 3;
            this.dgvPeli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeli_CellContentClick);
            // 
            // chartPeliMonth
            // 
            chartArea6.Name = "ChartArea1";
            this.chartPeliMonth.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPeliMonth.Legends.Add(legend6);
            this.chartPeliMonth.Location = new System.Drawing.Point(33, 47);
            this.chartPeliMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartPeliMonth.Name = "chartPeliMonth";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartPeliMonth.Series.Add(series6);
            this.chartPeliMonth.Size = new System.Drawing.Size(937, 210);
            this.chartPeliMonth.TabIndex = 2;
            this.chartPeliMonth.Text = "chart2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cmbYearPeli);
            this.groupBox3.Controls.Add(this.cmbMonthPeli);
            this.groupBox3.Controls.Add(this.btnPeliBuscar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbSucursalPeli);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(5, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(982, 85);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Periodo";
            // 
            // cmbYearPeli
            // 
            this.cmbYearPeli.FormattingEnabled = true;
            this.cmbYearPeli.Location = new System.Drawing.Point(237, 47);
            this.cmbYearPeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYearPeli.Name = "cmbYearPeli";
            this.cmbYearPeli.Size = new System.Drawing.Size(174, 24);
            this.cmbYearPeli.TabIndex = 15;
            // 
            // cmbMonthPeli
            // 
            this.cmbMonthPeli.FormattingEnabled = true;
            this.cmbMonthPeli.Location = new System.Drawing.Point(10, 48);
            this.cmbMonthPeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMonthPeli.Name = "cmbMonthPeli";
            this.cmbMonthPeli.Size = new System.Drawing.Size(160, 24);
            this.cmbMonthPeli.TabIndex = 14;
            // 
            // btnPeliBuscar
            // 
            this.btnPeliBuscar.Location = new System.Drawing.Point(645, 42);
            this.btnPeliBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPeliBuscar.Name = "btnPeliBuscar";
            this.btnPeliBuscar.Size = new System.Drawing.Size(160, 31);
            this.btnPeliBuscar.TabIndex = 13;
            this.btnPeliBuscar.Text = "Buscar";
            this.btnPeliBuscar.UseVisualStyleBackColor = true;
            this.btnPeliBuscar.Click += new System.EventHandler(this.btnPeliBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sucursal";
            // 
            // cmbSucursalPeli
            // 
            this.cmbSucursalPeli.FormattingEnabled = true;
            this.cmbSucursalPeli.Location = new System.Drawing.Point(464, 49);
            this.cmbSucursalPeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSucursalPeli.Name = "cmbSucursalPeli";
            this.cmbSucursalPeli.Size = new System.Drawing.Size(176, 24);
            this.cmbSucursalPeli.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mes";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(992, 782);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Sala";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartSalaYear);
            this.groupBox2.Controls.Add(this.dgvSala);
            this.groupBox2.Controls.Add(this.chartSalaMonth);
            this.groupBox2.Location = new System.Drawing.Point(3, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(988, 680);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por Sala";
            // 
            // chartSalaYear
            // 
            chartArea7.Name = "ChartArea1";
            this.chartSalaYear.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartSalaYear.Legends.Add(legend7);
            this.chartSalaYear.Location = new System.Drawing.Point(33, 277);
            this.chartSalaYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartSalaYear.Name = "chartSalaYear";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartSalaYear.Series.Add(series7);
            this.chartSalaYear.Size = new System.Drawing.Size(937, 210);
            this.chartSalaYear.TabIndex = 4;
            this.chartSalaYear.Text = "chart1";
            // 
            // dgvSala
            // 
            this.dgvSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSala.Location = new System.Drawing.Point(33, 506);
            this.dgvSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSala.Name = "dgvSala";
            this.dgvSala.RowTemplate.Height = 28;
            this.dgvSala.Size = new System.Drawing.Size(937, 170);
            this.dgvSala.TabIndex = 3;
            // 
            // chartSalaMonth
            // 
            chartArea8.Name = "ChartArea1";
            this.chartSalaMonth.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartSalaMonth.Legends.Add(legend8);
            this.chartSalaMonth.Location = new System.Drawing.Point(33, 47);
            this.chartSalaMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartSalaMonth.Name = "chartSalaMonth";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartSalaMonth.Series.Add(series8);
            this.chartSalaMonth.Size = new System.Drawing.Size(937, 210);
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
            this.groupBox4.Location = new System.Drawing.Point(5, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(982, 85);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Periodo";
            // 
            // cmbYearSala
            // 
            this.cmbYearSala.FormattingEnabled = true;
            this.cmbYearSala.Location = new System.Drawing.Point(237, 47);
            this.cmbYearSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYearSala.Name = "cmbYearSala";
            this.cmbYearSala.Size = new System.Drawing.Size(174, 24);
            this.cmbYearSala.TabIndex = 15;
            // 
            // cmbMonthSala
            // 
            this.cmbMonthSala.FormattingEnabled = true;
            this.cmbMonthSala.Location = new System.Drawing.Point(10, 48);
            this.cmbMonthSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMonthSala.Name = "cmbMonthSala";
            this.cmbMonthSala.Size = new System.Drawing.Size(160, 24);
            this.cmbMonthSala.TabIndex = 14;
            // 
            // btnSalaBuscar
            // 
            this.btnSalaBuscar.Location = new System.Drawing.Point(724, 40);
            this.btnSalaBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalaBuscar.Name = "btnSalaBuscar";
            this.btnSalaBuscar.Size = new System.Drawing.Size(160, 31);
            this.btnSalaBuscar.TabIndex = 13;
            this.btnSalaBuscar.Text = "Buscar";
            this.btnSalaBuscar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sucursal";
            // 
            // cmbSucursalSala
            // 
            this.cmbSucursalSala.FormattingEnabled = true;
            this.cmbSucursalSala.Location = new System.Drawing.Point(464, 49);
            this.cmbSucursalSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSucursalSala.Name = "cmbSucursalSala";
            this.cmbSucursalSala.Size = new System.Drawing.Size(176, 24);
            this.cmbSucursalSala.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exportar a Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVentasSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1021, 822);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
    }
}