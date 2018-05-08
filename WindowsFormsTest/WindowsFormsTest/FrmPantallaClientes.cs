using System;
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
    public partial class FrmPantallaClientes : Form
    {
        public FrmPantallaClientes()
        {
            InitializeComponent();
        }

        private void FrmPantallaClientes_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        public void CargarTabla()
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            ProcesosBD pbd = new ProcesosBD();
            
            string root = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\";

            string sql = "select distinct(clavePelicula)pelicula," +
                "imgPath from Funciones";

            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i=0;i< dt.Rows.Count;i++)
                {
                    sql = "select hora,Idioma,descripcion " +
                        "from Funciones f,Idioma i,TipoFuncion t where " +
                        "clavePelicula = '" + dt.Rows[i][0].ToString() + "' " +
                        "and t.claveTipoFuncion = f.claveTipoFuncion " +
                        "and i.claveIdioma = f.claveIdioma";

                    Funciones funciones = new Funciones();
                    

                    pbd.Conectar();
                    dt2 = pbd.SqlSelect(sql).Tables[0];
                    string horarios = "\n\rHorarios: ";
                    string idioma = "\n\rIdioma: ";
                    string tipoFuncion = "\n\r";
                    if (dt2.Rows.Count > 0)
                    {
                        for(int j=0; j < dt2.Rows.Count; j++)
                        {
                            funciones.Hora = Convert.ToDateTime( dt2.Rows[j][0].ToString());
                            horarios += funciones.Hora.ToString("hh:mm") + " ";
                        }
                        
                        idioma += dt2.Rows[0][1] + " ";
                        tipoFuncion += dt2.Rows[0][2] + " ";
                    }

                    TableLayoutPanel panel = new TableLayoutPanel();
                    panel.Size = new Size(200,500);
                    PictureBox picture = new PictureBox();
                    picture.Image = Image.FromFile(root + dt.Rows[i][1].ToString());
                    picture.Size = new Size(200,250);
                    picture.SizeMode = PictureBoxSizeMode.CenterImage;
                    //Contenedor.Controls.Add(picture);
                    Label DatosPelicula = new Label();
                    DatosPelicula.Size = new Size(200,250);
                    Console.Write(dt.Rows[i][0].ToString() + horarios + idioma + tipoFuncion);
                    DatosPelicula.Text = dt.Rows[i][0].ToString() + horarios + idioma + tipoFuncion;
                    //Contenedor.Controls.Add(descripcion);
                    panel.Controls.Add(picture);
                    panel.Controls.Add(DatosPelicula);
                    Contenedor.Controls.Add(panel);
                }
            }
            
        }
    }
}
