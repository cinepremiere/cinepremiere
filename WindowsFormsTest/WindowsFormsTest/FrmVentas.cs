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
    public partial class FrmVentas : Form
    {
        ProcesosBD pdb;
        Peliculas peliculas;
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            pdb = new ProcesosBD();
            pdb.Conectar();
            string sql = "select count(claveNombrePelicula) from Peliculas where disponible = 1";
            int cantidad = int.Parse(pdb.SqlSelect(sql).Tables[0].Rows[0][0].ToString());
            MessageBox.Show(cantidad.ToString());
            for (int i = 0; i < cantidad; i++)
            {
                string pelicula = "select claveNombrePelicula";
                string horario = "select claveNombrePelicula";
                string boletos = "select claveNombrePelicula";
                string asientos = "select claveNombrePelicula";
                string subtotal = "select claveNombrePelicula";
                string iva = "select claveNombrePelicula";
                string desc = "select claveNombrePelicula";
                string total = "select claveNombrePelicula";
                dgvVenta.Rows.Add(pelicula, horario, boletos, asientos, subtotal, iva, desc, total);
            }
        }

        private void dgvVentas(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Visible == false)
            {
                dgvVenta.Visible = true;
            }
            else
            { }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
