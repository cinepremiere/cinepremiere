﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class FrmVentasSemana : Form
    {
        public FrmVentasSemana()
        {
            InitializeComponent();
        }

        private void FrmVentasSemana_Load(object sender, EventArgs e)
        {
            Dictionary<int,string> liMeses = new Dictionary<int,string>()
            {
                {1,"Enero" },
                {2,"Febrero" },
                {3,"Marzo" },
                {4,"Abril" },
                {5,"Mayo" },
                {6,"Junio" },
                {7,"Julio" },
                {8,"Agosto" },
                {9,"Septiembre" },
                {10,"Octubre" },
                {11,"Noviembre" },
                {12,"Diciembre" },
            };

            cmbMonthPeli.DataSource = new BindingSource(liMeses,null);
            cmbMonthPeli.DisplayMember = "Value";
            cmbMonthPeli.ValueMember = "Key";

            cmbMonthSala.DataSource = new BindingSource(liMeses, null);
            cmbMonthSala.DisplayMember = "Value";
            cmbMonthSala.ValueMember = "Key";

            DateTime fechaInicioOperaciones = new DateTime(2017,1, 1, 6, 32, 0);
            string fechaIni = fechaInicioOperaciones.Year.ToString();

            DateTime fechaActual = DateTime.Today;
            string year = fechaActual.Year.ToString().Trim();
            MessageBox.Show(year + "  " + fechaIni);

            Dictionary<int, int> liYears = new Dictionary<int, int>();
            for(int i = int.Parse(year); i >= int.Parse(fechaIni); i--)
            {
                liYears.Add(i,i);
            }

            cmbYearPeli.DataSource = new BindingSource(liYears,null);
            cmbYearPeli.DisplayMember = "Value";
            cmbYearPeli.ValueMember = "Key";
            cmbYearPeli.SelectedValue = int.Parse(year);

            cmbYearSala.DataSource = new BindingSource(liYears, null);
            cmbYearSala.DisplayMember = "Value";
            cmbYearSala.ValueMember = "Key";
            cmbYearSala.SelectedValue = int.Parse(year);

            Dictionary<string, string> liSucursales = new Dictionary<string, string>()
            {
                {"San Rafael","San Rafael" },
                {"Polanco","Polanco" },
                {"Antara","Antara" },
                {"Huixquilucan","Huixquilucan" },
                {"Ecatepec","Ecatepec" },
            };

            cmbSucursalPeli.DataSource = new BindingSource(liSucursales,null);
            cmbSucursalPeli.DisplayMember = "Value";
            cmbSucursalPeli.ValueMember = "Key";

            cmbSucursalSala.DataSource = new BindingSource(liSucursales, null);
            cmbSucursalSala.DisplayMember = "Value";
            cmbSucursalSala.ValueMember = "Key";
        }

        private void btnPeliBuscar_Click(object sender, EventArgs e)
        {
            string sql = "select SUM(importeTotal)ventaMensual, " +
                "DATENAME(MONTH,horaFechaVenta)mes  from Ventas  " +
                "where YEAR(horaFechaVenta) = '"+ cmbYearPeli.SelectedValue.ToString() +"' " +
                "group by DATENAME(MONTH,horaFechaVenta)";

            ProcesosBD pbd = new ProcesosBD();
            DataTable dt = new DataTable();
            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            if (dt.Rows.Count > 0)
            {

            }
        }
    }
}