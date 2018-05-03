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
    public partial class FrmVentasLugares : Form
    {
        private ISeleccionados seleccionados;
        private string filaImpresa = "";
        private int asiento = 1;
        private int fila = 1;
        private const int lugaresDispPorFila = 11;
        private FrmVentas frmVentas;
        private int cantAsientosPorVender;
        private Sala sala;
        private int cantAsientosSelec = 1;
        private int row;
        private Dictionary<int, Butaca> liButacas = new Dictionary<int, Butaca>();
        private Dictionary<int, string> filas = new Dictionary<int, string>()
        {
            { 0,"A" },
            { 1,"B" },
            { 2,"C" },
            { 3,"D" },
            { 4,"E" },
            { 5,"F" },
            { 6,"G" },
            { 7,"H" },
            { 8,"I" },
            { 9,"J" },
        };

        internal Dictionary<int, Butaca> LiButacas { get => liButacas; set => liButacas = value; }

        public FrmVentasLugares()
        {
            InitializeComponent();
        }

        public FrmVentasLugares(FrmVentas frmVentas, int cantAsientosPorVender, Sala sala, int row) : this()
        {
            this.frmVentas = frmVentas;
            seleccionados = (ISeleccionados)frmVentas;
            this.cantAsientosPorVender = cantAsientosPorVender;
            this.sala = sala;
            this.row = row;
        }

        private void FrmVentasLugares_Load(object sender, EventArgs e)
        {
            List<PictureBox> pictures = new List<PictureBox>();

            string ocupado = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine.png";
            string seleccionado = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible.png";
            string disponible = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada.png";
            string A = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\A.png";
            string B = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\B.png";
            string C = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\C.png";
            string D = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\D.png";
            string E = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\E.png";
            string F = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\F.png";
            string G = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\G.png";
            string H = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\H.png";
            string I = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\I.png";
            string J = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\J.png";
            string D1 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada1.png";
            string D2 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada2.png";
            string D3 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada3.png";
            string D4 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada4.png";
            string D5 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada5.png";
            string D6 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada6.png";
            string D7 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada7.png";
            string D8 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada8.png";
            string D9 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada9.png";
            string D10 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineSeleccionada10.png";
            string S1 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible1.png";
            string S2 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible2.png";
            string S3 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible3.png";
            string S4 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible4.png";
            string S5 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible5.png";
            string S6 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible6.png";
            string S7 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible7.png";
            string S8 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible8.png";
            string S9 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible9.png";
            string S10 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCineDisponible10.png";
            string N1 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine1.png";
            string N2 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine2.png";
            string N3 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine3.png";
            string N4 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine4.png";
            string N5 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine5.png";
            string N6 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine6.png";
            string N7 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine7.png";
            string N8 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine8.png";
            string N9 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine9.png";
            string N10 = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\cinepremiere\WindowsFormsTest\WindowsFormsTest\Resources\ButacaCine10.png";

            Dictionary<int, string> letras = new Dictionary<int, string>()
            {
                {0,A },
                {1,B },
                {2,C },
                {3,D },
                {4,E },
                {5,F },
                {6,G },
                {7,H },
                {8,I },
                {9,J },
            };

            Dictionary<int, string> asientosDisponibles = new Dictionary<int, string>()
            {
                {0,D1 },
                {1,D2 },
                {2,D3 },
                {3,D4 },
                {4,D5 },
                {5,D6 },
                {6,D7 },
                {7,D8 },
                {8,D9 },
                {9,D10 },
            };

            Dictionary<int, string> asientosNoDisponibles = new Dictionary<int, string>()
            {
                {0,N1 },
                {1,N2 },
                {2,N3 },
                {3,N4 },
                {4,N5 },
                {5,N6 },
                {6,N7 },
                {7,N8 },
                {8,N9 },
                {9,N10 },
            };

            Dictionary<int, string> asientosSleccionados = new Dictionary<int, string>()
            {
                {0,S1 },
                {1,S2 },
                {2,S3 },
                {3,S4 },
                {4,S5 },
                {5,S6 },
                {6,S7 },
                {7,S8 },
                {8,S9 },
                {9,S10 },
            };
            //MessageBox.Show("capacidad: "+sala.getSala().Count.ToString());

            int n = 1;
            int m = -1;
            bool esLetra;

            for (int i = 0; i < sala.getAsientos().Count; i++)
            {
                
                esLetra = false;
                PictureBox picture = new PictureBox();
                //1 para ocupado
                //2 para disponible
                //3 para seleccionado
                //4 para nombre de la fila
                if (sala.getAsientos()[i] == 1)
                {
                    m++;
                    picture.Image = Image.FromFile(asientosNoDisponibles[m]);
                    
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    flpButacas.Controls.Add(picture);
                }
                else if (sala.getAsientos()[i] == 2)
                {
                    m++;
                    picture.Image = Image.FromFile(asientosDisponibles[m]);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Name = (m+1).ToString();
                    int posicion = i+1;
                    picture.Click += new EventHandler((o, a) =>
                    {
                        //MessageBox.Show("porvender: "  + cantAsientosPorVender
                        //     + "   selecc: " + cantAsientosSelec);
                        //MessageBox.Show(picture.Name + "  posicion: " + posicion);
                        if (cantAsientosPorVender >= cantAsientosSelec
                        && !liButacas.ContainsKey(posicion))
                        {
                            picture.Image = Image.FromFile(
                                asientosSleccionados[int.Parse(picture.Name)-1]);
                            fila = ((posicion-1) / lugaresDispPorFila) + 1;
                            asiento = int.Parse(picture.Name);
                            filaImpresa = filas[(posicion-1) / lugaresDispPorFila];
                            //MessageBox.Show("fila: " + fila + "   asiento: " + asiento
                            //    + "   filaImpresa: " + filaImpresa);
                            Butaca butaca = new Butaca(fila, asiento, filaImpresa);
                            liButacas.Add(posicion, butaca);
                            cantAsientosSelec++;
                        }
                        else
                        {
                            if (liButacas.ContainsKey(posicion))
                            {
                                cantAsientosSelec--;
                                picture.Image = Image.FromFile(
                                    asientosDisponibles[int.Parse(picture.Name)-1]);
                                fila = 0;
                                asiento = 0;
                                liButacas.Remove(posicion);
                            }
                            else
                            {
                                MessageBox.Show("Ya ha seleccionado los boletos requeridos");
                            }
                        }
                    });

                    flpButacas.Controls.Add(picture);
                }
                else if (sala.getAsientos()[i] == 3)
                {
                    m++;
                    picture.Image = Image.FromFile(asientosSleccionados[m]);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    flpButacas.Controls.Add(picture);
                }
                else if (i > 0 && sala.getAsientos()[i] % 4 == 0)
                {
                    //MessageBox.Show("clave" + i/11);
                    picture.Image = Image.FromFile(letras[i / 11]);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    flpButacas.Controls.Add(picture);
                    esLetra = true;
                    m = -1;
                }
                else if (sala.getAsientos()[i] == 5)
                {
                    flpButacas.Controls.Add(picture);
                }
                if (sala.getAsientos()[i] != 5 && !esLetra)
                    n++;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cantAsientosPorVender <= cantAsientosSelec)
            {
                frmVentas.getAsientos(LiButacas, row);
                //frmVentas.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione los boletos requeridos o presione Cancelar" +
                    " para seleccionar la cantidad de boletos nuevamente");
            }
        }
    }
}
