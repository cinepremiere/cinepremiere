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
    public partial class FrmPeliculas : Form
    {
        ProcesosBD pdb;
        Peliculas peliculas;

        public FrmPeliculas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            CargarTabla();

            System.Object[] liDistribuidoras = {"DISNEY", "FOX", "SONY-COLUMBIA",
                "WARNER", "UNIVERSAL", "PARAMOUNT", "VIDEOCINE", "CORAZÓN", "GUSSI", "ZIMA"};
            cmbDistrib.Items.AddRange(liDistribuidoras);

            System.Object[] liClasificaciones = {"A", "AA", "B-15",
                "C", "D", "R", "18-A", "14-A", "PG", "G"};
            cmbClasifica.Items.AddRange(liClasificaciones);

            chbDisponible.Checked = true;

            dtmEstreno.Format = DateTimePickerFormat.Custom;
            dtmEstreno.CustomFormat = "yyyy/MM/dd";

            dtmRetiro.Format = DateTimePickerFormat.Custom;
            dtmRetiro.CustomFormat = "yyyy/MM/dd";
            dtmRetiro.Value = dtmEstreno.Value.AddDays(15);
        }

        private void CargarTabla()
        {
            pdb = new ProcesosBD();
            pdb.Conectar();
            string sql = "select claveNombrePelicula,clasificacion,distribuidor,fechaEstreno," +
                "fechaRetiro,duracion, disponible from peliculas order by indice desc";
            dgvPeliculas.DataSource = pdb.SqlSelect(sql).Tables[0];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            peliculas = new Peliculas();
            int disponible = 1;
            bool PermisoInsert = true;

            if (txtNombrePeli != null && !txtNombrePeli.Text.Equals(""))
            {
                peliculas.ClaveNombrePelicula = txtNombrePeli.Text.ToUpper();
            }
            else { MessageBox.Show("Elnombre no puede estar vacío"); PermisoInsert = false; }

            if (cmbClasifica != null && cmbClasifica.Text != "Seleccionar")
            {
                peliculas.Clasificacion = cmbClasifica.Text;
            }
            else { MessageBox.Show("Debe seleccionar una clasificacion"); PermisoInsert = false; }
            if (cmbDistrib != null && cmbDistrib.Text != "Seleccionar")
            {
                peliculas.Distribuidor = cmbDistrib.Text;
            }
            else { MessageBox.Show("Debe seleccionar un distribuidor"); PermisoInsert = false; }
            if (numDuracion != null && numDuracion.Value > 0)
            {
                peliculas.Duracion = parseDuracion(numDuracion.Value);

            }
            else { MessageBox.Show("La duración de la Pelícua no puede ser 0"); PermisoInsert = false; }
            if (dtmEstreno != null)
            {
                peliculas.FechaEstreno = dtmEstreno.Text;
            }
            else PermisoInsert = false;
            if (dtmRetiro != null)
            {
                peliculas.FechaRetiro = dtmRetiro.Text;
            }
            else PermisoInsert = false;
            if (chbDisponible != null)
            {
                peliculas.Disponible = chbDisponible.Checked;
                if (!peliculas.Disponible)
                {
                    disponible = 0;
                }
            }
            else PermisoInsert = false;

            string sql = "select claveNombrePelicula from peliculas where " +
                "claveNombrePelicula = '" + peliculas.ClaveNombrePelicula.Trim() + "'";

            pdb = new ProcesosBD();
            pdb.Conectar();
            if (pdb.SqlSelect(sql).Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("El registro ya existe en la base de datos");
            }
            else
            {
                if (PermisoInsert)
                {
                    try
                    {
                        sql = "insert into Peliculas(claveNombrePelicula,clasificacion,distribuidor," +
                            "fechaEstreno,fechaRetiro,duracion, disponible)" +
                            "values("
                            + "'" + peliculas.ClaveNombrePelicula + "',"
                            + "'" + peliculas.Clasificacion + "',"
                            + "'" + peliculas.Distribuidor + "',"
                            + "'" + peliculas.FechaEstreno + "',"
                            + "'" + peliculas.FechaRetiro + "',"
                            + "'" + peliculas.Duracion + "',"
                            + disponible
                            + ")";
                        pdb.SqlUpdate(sql);
                        MessageBox.Show("Registro exitoso");
                        LimpiarControles();
                        CargarTabla();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("No fue posible insertar en la base de datos, causa: " + e1);
                    }
                }
            }
        }

        private void LimpiarControles()
        {
            txtNombrePeli.Text = "";
            cmbClasifica.Text = "Seleccionar";
            cmbDistrib.Text = "Seleccionar";
            numDuracion.Value = 0;
            dtmEstreno.Value = DateTime.Today.Date;
            chbDisponible.Checked = true;
        }

        private string parseDuracion(decimal value)
        {
            int horas = 0;
            int minutos = 0;

            horas = Decimal.ToInt32(value) / 60;
            minutos = Decimal.ToInt32(value) % 60;

            return "0" + horas.ToString() + ":" + minutos.ToString() + ":" + "00";
        }

        private void dtmEstreno_ValueChanged(object sender, EventArgs e)
        {
            dtmRetiro.Value = dtmEstreno.Value.AddDays(15);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void dgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }


    }
}
