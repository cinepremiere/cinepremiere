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
    public partial class FrmCancelaciones : Form
    {
        private ProcesosBD pbd;
        private Dictionary<int, string> liButacas = new Dictionary<int, string>()
        {
            { 1, "A" },
            { 2, "B" },
            { 3, "C" },
            { 4, "D" },
            { 5, "E" },
            { 6, "F" },
            { 7, "G" },
            { 8, "H" },
            { 9, "I" },
            { 10, "J" },
            { 11, "K" },
            { 12, "L" },
            { 13, "M" },
            { 14, "N" },
            { 15, "O" },
            { 16, "P" },
            { 17, "Q" },
            { 18, "R" },
            { 19, "S" },
            { 20, "T" },
            { 21, "U" },
            { 22, "V" },
            { 23, "W" },
            { 24, "X" },
            { 25, "Y" },
            { 26, "Z" },
        };

        public FrmCancelaciones()
        {
            InitializeComponent();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

            }
        }

        private DataTable buscarPorId(string tabla)
        {
            DataTable dt = new DataTable();
            string sql = "";

            long clave = 0;
            bool esNumero = long.TryParse(txtBuscar.Text.ToString().Trim(), out clave);
            if (esNumero)
            {
                clave = long.Parse(txtBuscar.Text.ToString().Trim());
            }


            //MessageBox.Show("se ha presionado enter");
            if (tabla.Equals("Boletos"))
            {
                sql = "select clavePelicula,claveSala,hora,fila,asiento,boleto,b.claveVenta from " +
                    "Funciones f,Boletos b where f.claveFuncion = b.claveFuncion and " +
                    "boleto =" + clave;
            }
            else
            {
                sql = "select clavePelicula,claveSala,hora,fila,asiento,boleto,b.claveVenta from " +
                    "Funciones f,Boletos b where " +
                    "f.claveFuncion = b.claveFuncion and " +
                    "claveVenta =" + clave;
            }



            Console.WriteLine(sql);
            pbd = new ProcesosBD();
            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            return dt;
        }

        private void btnBuscarBoleto_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("Debe introducir uno de los siguientes datos " +
                " para realizar la busqueda:" +
                " Boleto, Clave de Venta. Luego presionar 'Buscar Boleto' o 'Buscar Clave Venta'");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = buscarPorId("Boletos");
                if (dt.Rows.Count > 0)
                {
                    limpiarControles();

                    lblPelicula.Text = dt.Rows[0][0].ToString();
                    lblSala.Text = dt.Rows[0][1].ToString();
                    lblHorario.Text = dt.Rows[0][2].ToString();
                    lblAsientos.Text = liButacas[int.Parse(dt.Rows[0][3].ToString())]
                        + dt.Rows[0][4].ToString(); ;
                    lblBoletos.Text = dt.Rows[0][5].ToString();
                    lblClaveVenta.Text = dt.Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún elemento con el criterio especificado");
                }
            }
        }

        private void limpiarControles()
        {
            lblPelicula.Text = "";
            lblSala.Text = "";
            lblHorario.Text = "";
            lblAsientos.Text = "";
            lblBoletos.Text = "";
            lblClaveVenta.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        private void btnBuscarClaveVenta_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("Debe introducir uno de los siguientes datos " +
                " para realizar la busqueda:" +
                " Boleto, Clave de Venta. Luego presionar 'Buscar Boleto' o 'Buscar Clave Venta'");
            }
            else
            {
                DataTable dt = new DataTable();
                string butacas = "";
                string boletos = "";

                dt = buscarPorId("Ventas");
                if (dt.Rows.Count > 0)
                {
                    limpiarControles();

                    lblPelicula.Text = dt.Rows[0][0].ToString();
                    lblSala.Text = dt.Rows[0][1].ToString();
                    lblHorario.Text = dt.Rows[0][2].ToString();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            butacas += liButacas[int.Parse(dt.Rows[i][3].ToString())]
                            + dt.Rows[i][4].ToString();
                            boletos += dt.Rows[i][5].ToString();
                        }
                        else
                        {
                            butacas += ", " + liButacas[int.Parse(dt.Rows[i][3].ToString())]
                            + dt.Rows[i][4].ToString();
                            boletos += "," + dt.Rows[i][5].ToString();
                        }
                    }
                    lblAsientos.Text = butacas;
                    lblBoletos.Text = boletos;
                    lblClaveVenta.Text = dt.Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún elemento con el criterio especificado");
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lblClaveVenta.Text.Equals(""))
            {
                MessageBox.Show("Debe obtener los datos por medio del buscador para proceder");
            }
            else
            {
                string[] arrBoletos = lblBoletos.Text.Split(',');
                string usuario = txtUsuario.Text;
                string pass = txtPass.Text;
                string motivo = txtMotivo.Text;
                DataTable dt;

                string sql = "select claveTipoUsuario,claveUsuario,contrasena from Usuarios " +
                        "where claveUsuario='" + usuario + "' and contrasena = '"
                        + pass + "' and disponible=1 and claveTipoUsuario in(1,2,4)";

                Console.WriteLine(sql);

                pbd = new ProcesosBD();
                pbd.Conectar();
                dt = new DataTable();
                dt = pbd.SqlSelect(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    sql = "insert into Cancelados values";
                    for (int i = 0; i < arrBoletos.Length; i++)
                    {
                        if (i == 0)
                        {
                            sql += "(" +
                            "" + lblClaveVenta.Text + "," +
                            "" + arrBoletos[0] + "," +
                            "getdate()," +
                            "'" + motivo + "'," +
                            "'" + usuario + "'," +
                            "'" + pass + "')";
                        }
                        else
                        {
                            sql += ",(" +
                            "" + lblClaveVenta.Text + "," +
                            "" + arrBoletos[i] + "," +
                            "getdate()," +
                            "'" + motivo + "'," +
                            "'" + usuario + "'," +
                            "'" + pass + "')";
                        }
                    }

                    Console.WriteLine(sql);
                    pbd.Conectar();
                    pbd.SqlUpdate(sql);

                    MessageBox.Show("Se ha realizado la cancelación");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sus credenciales no son válidas");
                }
            }
        }

        private void btnDeclinar_Click(object sender, EventArgs e)
        {
            limpiarControles();
            txtBuscar.Text = "";
        }
    }
}
