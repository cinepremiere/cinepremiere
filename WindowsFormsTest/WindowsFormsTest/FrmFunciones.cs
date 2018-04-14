using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 falta controlar excepciones para cuando no existe el valor en los cmb
     */

namespace WindowsFormsTest
{
    public partial class FrmFunciones : Form
    {
        ProcesosBD pbd;
        Funciones funciones;
        DataSet ds;

        public FrmFunciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            funciones = new Funciones();
            int status = 1;

            funciones.ClaveSala = int.Parse(cmbSalas.SelectedValue.ToString());
            funciones.ClavePelicula = cmbPeliculas.SelectedValue.ToString();
            funciones.ClaveTipoFuncion = int.Parse(cmbTipoFuncion.SelectedValue.ToString());
            funciones.ClaveIdioma = int.Parse(cmbIdioma.SelectedValue.ToString());
            funciones.ClaveSubtitulos = int.Parse(cmbSubtitulos.SelectedValue.ToString());
            funciones.Fecha = dtmFechaProy.Value;
            funciones.Hora = dtmHoraProy.Value;
            funciones.Disponible = chkPeliDisp.Checked;
            if (!funciones.Disponible) status =0;
            funciones.ImgPath = txtImgPath.Text;

            string sql = "insert into Funciones(claveSala,clavePelicula,claveTipoFuncion," +
                "claveIdioma,claveSubtitulos,fecha,hora,disponible, imgPath)" +
                "values("
                + funciones.ClaveSala+ ","
                + "'" + funciones.ClavePelicula.ToString().Trim()+ "',"
                + funciones.ClaveTipoFuncion+ ","
                + funciones.ClaveIdioma+ ","
                + funciones.ClaveSubtitulos+ ","
                + "'" + funciones.Fecha.ToString("yyyy/MM/dd") + "',"
                + "'" + funciones.Hora.ToString("hh:mm") + "',"
                + status + ","
                + "'" + funciones.ImgPath + "'"
                + ")";
            Console.Write(sql);
            pbd = new ProcesosBD();
            pbd.Conectar();

            pbd.SqlUpdate(sql);

            MessageBox.Show("Se ha insertado el registro exitosamente");

            CargarTabla();
        }

        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            CargarTabla();

            ds = new DataSet();
            pbd = new ProcesosBD();
            pbd.Conectar();

            chkPeliDisp.Checked = true;

            dtmFechaProy.Format = DateTimePickerFormat.Custom;
            dtmFechaProy.CustomFormat = "yyyy/MM/dd";

            dtmHoraProy.Format = DateTimePickerFormat.Custom;
            dtmHoraProy.CustomFormat = "HH:mm";

            string sql = "select TRIM(clavenombrepelicula)clavenombrepelicula from Peliculas";
            ds = pbd.SqlSelect(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbPeliculas.DataSource = ds.Tables[0].DefaultView;
                cmbPeliculas.ValueMember = "clavenombrepelicula";
                cmbPeliculas.DisplayMember = "clavenombrepelicula";
            }

            sql = "select clavesala from Salas";
            ds = pbd.SqlSelect(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbSalas.DataSource = ds.Tables[0].DefaultView;
                cmbSalas.ValueMember = "clavesala";
                cmbSalas.DisplayMember = "clavesala";
            }

            sql = "select descripcion,claveTipoFuncion from TipoFuncion";
            ds = pbd.SqlSelect(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbTipoFuncion.DataSource = ds.Tables[0].DefaultView;
                cmbTipoFuncion.ValueMember = "claveTipoFuncion";
                cmbTipoFuncion.DisplayMember = "descripcion";
            }

            sql = "select idioma,claveIdioma from Idioma";
            ds = pbd.SqlSelect(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbIdioma.DataSource = ds.Tables[0].DefaultView;
                cmbIdioma.ValueMember = "claveIdioma";
                cmbIdioma.DisplayMember = "idioma";
            }

            sql = "select subtitulos,claveSubtitulos from Subtitulos";
            ds = pbd.SqlSelect(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbSubtitulos.DataSource = ds.Tables[0].DefaultView;
                cmbSubtitulos.ValueMember = "claveSubtitulos";
                cmbSubtitulos.DisplayMember = "subtitulos";
            }
        }

        public void CargarTabla()
        {
            pbd = new ProcesosBD();
            pbd.Conectar();
            string sql = "select * from funciones order by clavefuncion desc";
            dgvFunciones.DataSource = pbd.SqlSelect(sql).Tables[0];
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "F:\\UVM\\Tareas UVM\\07 Septimo Semestre\\" +
                "Ing. de Software I\\Parcial 1\\cinepremiere\\Imgs\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string path = openFileDialog1.FileName;
                            string[] pathArr = path.Split('\\');
                            string fileName = pathArr[pathArr.Length - 1];
                            txtImgPath.Text = fileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
