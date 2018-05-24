using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
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
        int claveFunciones = 0;
        string clavePelicula = "";
        string defaultPelicula = "";
        Dictionary<int, string> peliDuracion;
        int h = 0;

        public FrmFunciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            funciones = new Funciones();
            int status = 1;
            bool datosValidos = true;
            bool dispon = true;

            dispon = validarDisponibilidad();
            datosValidos =  validarDatosEntrada();

            if (datosValidos && dispon)
            {
                funciones.ClaveSala = int.Parse(cmbSalas.SelectedValue.ToString());
                funciones.ClavePelicula = cmbPeliculas.SelectedValue.ToString();
                funciones.ClaveTipoFuncion = int.Parse(cmbTipoFuncion.SelectedValue.ToString());
                funciones.ClaveIdioma = int.Parse(cmbIdioma.SelectedValue.ToString());
                funciones.ClaveSubtitulos = int.Parse(cmbSubtitulos.SelectedValue.ToString());
                funciones.Fecha = dtmFechaProy.Value;
                funciones.Hora = dtmHoraIni.Value;
                funciones.Disponible = chkPeliDisp.Checked;
                if (!funciones.Disponible) status = 0;
                funciones.ImgPath = txtImgPath.Text;

                string sql = "insert into Funciones(claveSala,clavePelicula,claveTipoFuncion," +
                    "claveIdioma,claveSubtitulos,fecha,hora,disponible, imgPath)" +
                    "values("
                    + funciones.ClaveSala + ","
                    + "'" + funciones.ClavePelicula.ToString().Trim() + "',"
                    + funciones.ClaveTipoFuncion + ","
                    + funciones.ClaveIdioma + ","
                    + funciones.ClaveSubtitulos + ","
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

            dtmHoraIni.Format = DateTimePickerFormat.Custom;
            dtmHoraIni.CustomFormat = "HH:mm";

            string sql = "select TRIM(clavenombrepelicula)clavenombrepelicula " +
                "from Peliculas";
            ds = pbd.SqlSelect(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbPeliculas.DataSource = ds.Tables[0].DefaultView;
                cmbPeliculas.ValueMember = "clavenombrepelicula";
                cmbPeliculas.DisplayMember = "clavenombrepelicula";
                defaultPelicula = ds.Tables[0].Rows[0][0].ToString();
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
                cmbIdioma.SelectedValue = 1;
            }

            sql = "select subtitulos,claveSubtitulos from Subtitulos";
            ds = pbd.SqlSelect(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbSubtitulos.DataSource = ds.Tables[0].DefaultView;
                cmbSubtitulos.ValueMember = "claveSubtitulos";
                cmbSubtitulos.DisplayMember = "subtitulos";
                cmbSubtitulos.SelectedValue = 6;
            }
        }

        public void CargarTabla()
        {
            DataTable dt = new DataTable();
            peliDuracion = new Dictionary<int, string>();
            pbd = new ProcesosBD();
            pbd.Conectar();
            string sql = "select *,duracion from funciones f,peliculas p " +
                "where f.clavepelicula = p.clavenombrepelicula order by clavefuncion desc";
            dt = pbd.SqlSelect(sql).Tables[0];

            if (dt.Rows.Count > 0)
            {
                dgvFunciones.DataSource = dt.DefaultView;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    peliDuracion.Add(int.Parse(dt.Rows[i][0].ToString()),
                        dt.Rows[i][18].ToString().Substring(0, 5));
                    //MessageBox.Show(int.Parse(dt.Rows[i][0].ToString()) + "   " +
                    //    dt.Rows[i][18].ToString().Substring(0, 5));
                }
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            var directory = AppDomain.CurrentDomain.BaseDirectory;
            MessageBox.Show(directory);


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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtBuscar.Text.Equals(""))
                {
                    MessageBox.Show("Debe introducir uno de los siguientes datos " +
                    "para relaizar la busqueda:" +
                    "Id de la función o nombre de la pelicula. " +
                    "Luego presione la tecla 'Enter' o 'Return'");
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = buscarPorId();
                    if (dt.Rows.Count > 0)
                    {
                        dgvFunciones.DataSource = dt.DefaultView;

                        limpiarControles();

                        txtClave.Text = dt.Rows[0][0].ToString().Trim();
                        claveFunciones = int.Parse(txtClave.Text);
                        cmbSalas.SelectedValue = dt.Rows[0][1].ToString().Trim();
                        MessageBox.Show(dt.Rows[0][1].ToString().Trim());
                        cmbPeliculas.SelectedValue = dt.Rows[0][2].ToString().Trim();
                        clavePelicula = cmbPeliculas.SelectedValue.ToString();
                        cmbTipoFuncion.SelectedValue = dt.Rows[0][3].ToString().Trim();
                        cmbIdioma.SelectedValue = dt.Rows[0][4].ToString().Trim();
                        cmbSubtitulos.SelectedValue = dt.Rows[0][5].ToString().Trim();
                        dtmFechaProy.Value = DateTime.Parse(dt.Rows[0][6].ToString().Trim());
                        dtmHoraIni.Value = DateTime.Parse(dt.Rows[0][7].ToString().Trim());
                        chkPeliDisp.Checked = bool.Parse(dt.Rows[0][8].ToString().Trim());
                        txtImgPath.Text = dt.Rows[0][9].ToString().Trim();

                        //MessageBox.Show(dt.Rows[0][18].ToString().Trim());
                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna función con el criterio especificado");
                    }
                }
            }
        }

        private void limpiarControles()
        {
            cmbPeliculas.SelectedValue = defaultPelicula;
            cmbSalas.SelectedValue = 1;
            cmbTipoFuncion.SelectedValue = 1;
            cmbIdioma.SelectedValue = 1;
            cmbSubtitulos.SelectedValue = 1;
            dtmFechaProy.Value = DateTime.Today;
            dtmHoraIni.Value = DateTime.Today;
            chkPeliDisp.Checked = true;
            txtImgPath.Text = "";
            claveFunciones = 0;
            clavePelicula = "";
        }

        private DataTable buscarPorId()
        {
            DataTable dt = new DataTable();

            long clave = 0;
            bool esNumero = long.TryParse(txtBuscar.Text.ToString().Trim(), out clave);
            if (esNumero)
            {
                clave = long.Parse(txtBuscar.Text.ToString().Trim());
            }


            //MessageBox.Show("se ha presionado enter");
            string sql = "select * from Funciones " +
            " where clavePelicula ='" + txtBuscar.Text.ToString().Trim() + "'" +
            " or claveFuncion  =" + clave + "";

            Console.WriteLine(sql);

            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            return dt;
        }

        private void vaciarFormAFunciones()
        {
            funciones = new Funciones();

            funciones.ClaveSala = int.Parse( cmbSalas.SelectedValue.ToString());
            funciones.ClavePelicula = cmbPeliculas.SelectedValue.ToString();
            funciones.ClaveTipoFuncion = int.Parse(cmbTipoFuncion.SelectedValue.ToString());
            funciones.ClaveIdioma = int.Parse(cmbIdioma.SelectedValue.ToString());
            funciones.ClaveSubtitulos = int.Parse(cmbSubtitulos.SelectedValue.ToString());
            funciones.Fecha = DateTime.Parse( dtmFechaProy.Text);
            funciones.Hora = DateTime.Parse(dtmHoraIni.Text);
            funciones.Disponible = chkPeliDisp.Checked;
            funciones.ImgPath = txtImgPath.Text;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (claveFunciones!=0)
            {
                vaciarFormAFunciones();
                int disponible = 1;
                if (!funciones.Disponible)
                    disponible = 0;

                string sql = "update Funciones set " +
                    " claveSala='" + funciones.ClaveSala + "'," +
                    " clavePelicula='" + funciones.ClavePelicula + "'," +
                    " claveTipoFuncion='" + funciones.ClaveTipoFuncion + "'," +
                    " claveIdioma='" + funciones.ClaveIdioma + "'," +
                    " claveSubtitulos='" + funciones.ClaveSubtitulos + "'," +
                    " fecha='" + funciones.Fecha.ToString("yyyy/MM/dd") + "'," +
                    " hora='" + funciones.Hora.ToString("HH:mm") + "'," +
                    " disponible='" + disponible + "'," +
                    " imgPath='" + funciones.ImgPath + "'" +
                    " where clavePelicula = '" + funciones.ClavePelicula + "'";

                Console.WriteLine(sql);

                if(validarDisponibilidad() && validarDatosEntrada())
                {
                    ProcesosBD pbd = new ProcesosBD();
                    DataTable dt = new DataTable();
                    pbd.Conectar();
                    pbd.SqlUpdate(sql);
                    dt = buscarPorId();
                    dgvFunciones.DataSource = dt.DefaultView;
                    MessageBox.Show("Actualización correcta");
                    limpiarControles();
                }

                //validarDatos();
                //ProcesosBD pbd = new ProcesosBD();
                //DataTable dt = new DataTable();
                //pbd.Conectar();
                //pbd.SqlUpdate(sql);
                //dt = buscarPorId();
                //dgvFunciones.DataSource = dt.DefaultView;
                //MessageBox.Show("Actualización correcta");
                //limpiarControles();
            }
            else
            {
                MessageBox.Show("Debe traer los datos por medio de la barra buscar. " +
                    "Coloque cualquiera de los siguientes datos: " +
                    "clave de Pelicula o nombre de pelicula " +
                    "y luego presione 'Enter' o 'Return'");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (claveFunciones != 0)
            {

                DialogResult d = MessageBox.Show("Se eliminará la funcion con id="+ claveFunciones
                    + ". ¿Desea continuar?\n"
                            , "Aceptar", MessageBoxButtons.OKCancel);

                int i = 0;
                if (d.Equals(DialogResult.OK))
                {
                    string sql = "delete from funciones where clavefuncion = " + txtBuscar.Text;
                    pbd.Conectar();
                    pbd.SqlSelect(sql);

                    pbd.SqlUpdate(sql);

                    limpiarControles();
                    MessageBox.Show("Se ha eliminado el registro correctamente.");
                    CargarTabla();
                }
            }
            else
            {
                MessageBox.Show("Debe realizar la busqueda del Id por medio del buscador");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool validarDatosEntrada()
        {
            bool datosValidos = true;
            string msjerrores = "Error:\n";


           
            if (txtImgPath.Text.Equals(""))
            {
                msjerrores += "Debe seleccionar una imagen para la pelicula\n";
                datosValidos = false;
            }
            if (!datosValidos)
            {
                MessageBox.Show(msjerrores);
            }

            return datosValidos;
        }

        private bool validarDisponibilidad()
        {
            DataTable dt = new DataTable();
            bool valido = true;

            string sql = "select top 1 clavefuncion from funciones " +
                "where clavesala = " + cmbSalas.SelectedValue +
                " and clavePELICULA !='"+cmbPeliculas.SelectedValue+"' ";

            ProcesosBD pdb = new ProcesosBD();
            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            if (getHorarioIni() < 11 || getHorarioIni() > 23)
            {
                MessageBox.Show("Las funciones no pueden empezar " +
                    "antes de las 11:00 am ni despues de las 23:00");
                valido = false;
            }
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Esta sala ya esta reservada para una función.Seleccione otra.");
                valido = false;
            }
            //else
            //{
            //    MessageBox.Show("l HORA:" + dtmHoraIni.Value.ToString().Substring(10, 14));
            //    sql = "select * from funciones where hora > '"+ dtmHoraIni.Value.ToString().Substring(10,14)+ "' " +
            //        "and hora<'11:00'";
            //    pbd.Conectar();
            //    dt = pbd.SqlSelect(sql).Tables[0];
            //    if (dt.Rows.Count > 0)
            //    {
            //        MessageBox.Show("No se pueden empalmar los horarios seleccione otro");
            //        valido = false;
            //    }
                
            //}

            return valido;
        }

        private string horaFin()
        {
            string horaFinal = "";
            string cadenaHora = dtmHoraIni.Value.ToString();
            int horasIni = 0;
            int minutosIni = 0;
            string duracionCadena = "";
            int duracion = 0;
            h = 0;
            int m = 0;

            duracionCadena = peliDuracion[int.Parse(txtClave.Text)];
            string[] arraux = duracionCadena.Split(':');
            string[] arr = cadenaHora.Split(':');
            duracion = int.Parse(arraux[0])*60;
            duracion = duracion + int.Parse(arraux[1]);
            

            horasIni = int.Parse(arr[0]);
            minutosIni = int.Parse(arr[1]);

            h = duracion / 60;
            m = duracion % 60;

            if ((minutosIni + m) >= 60)
            {
                h++;
                m = (minutosIni + m) % 60;
            }

            if (h < 10)
            {
                horaFinal = "0" + h;
            }
            else
            {
                horaFinal = "" + h;
            }
            if (m < 10)
            {
                horaFinal += ":0" + m;
            }
            else
            {
                horaFinal += ":" + m;
            }

            MessageBox.Show(horaFinal);
            return horaFinal;
        }


        private int getHorarioIni()
        {
            string cadenaHora = dtmHoraIni.Value.ToString().Substring(10,15);

            MessageBox.Show(cadenaHora);
            int horasIni = 0;
            
            string[] arr = cadenaHora.Split(':');

            horasIni = int.Parse(arr[0]);
            
            return horasIni;
        }

        private int getHorarioFin()
        {
            return 0;
        }
    }
}
