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
        String claveNombrePelicula = "";

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

            
            Dictionary<string, string> liDist = new Dictionary<string, string>();
            liDist.Add("DISNEY", "DISNEY");
            liDist.Add("FOX", "FOX");
            liDist.Add("SONY-COLUMBIA", "SONY-COLUMBIA");
            liDist.Add("WARNER", "WARNER");
            liDist.Add("UNIVERSAL", "UNIVERSAL");
            liDist.Add("PARAMOUNT", "PARAMOUNT");
            liDist.Add("VIDEOCINE", "VIDEOCINE");
            liDist.Add("CORAZÓN", "CORAZÓN");
            liDist.Add("GUSSI", "GUSSI");
            liDist.Add("ZIMA", "ZIMA");
            liDist.Add("BANDAI", "BANDAI");
            //cmbDistrib.Items.AddRange(liDistribuidoras);
            cmbDistrib.DataSource = new BindingSource(liDist,null);
            cmbDistrib.DisplayMember = "Value";
            cmbDistrib.ValueMember = "Key";
            
            Dictionary<string, string> liClasif = new Dictionary<string, string>();
            liClasif.Add("A", "A");
            liClasif.Add("AA", "AA");
            liClasif.Add("B-15", "B-15");
            liClasif.Add("C", "C");
            liClasif.Add("D", "D");
            liClasif.Add("R", "R");
            liClasif.Add("18-A", "18-A");
            liClasif.Add("14-A", "14-A");
            liClasif.Add("PG", "PG");
            liClasif.Add("G", "G");

            cmbClasifica.DataSource = new BindingSource(liClasif,null);
            cmbClasifica.DisplayMember = "Value";
            cmbClasifica.ValueMember = "Key";
            //cmbClasifica.Items.AddRange(liClasificaciones);

            chkDisponible.Checked = true;

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
            string sql = "select TRIM(claveNombrePelicula),clasificacion,distribuidor,fechaEstreno," +
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
            if (chkDisponible != null)
            {
                if (chkDisponible.Checked)
                {
                    peliculas.Disponible = true;
                    disponible = 1;
                }
                else
                {
                    peliculas.Disponible = false;
                    disponible = 0;
                }
            }
            else PermisoInsert = false;

            if(peliculas.ClaveNombrePelicula!=null && PermisoInsert)
            {
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
        }

        private void LimpiarControles()
        {
            txtNombrePeli.Text = "";
            cmbClasifica.SelectedValue = "A";
            cmbDistrib.SelectedValue = "BANDAI";
            numDuracion.Value = 0;
            dtmEstreno.Value = DateTime.Today.Date;
            chkDisponible.Checked = true;
            claveNombrePelicula = "";
            txtBuscar.Text = "";
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

        private string validarDatos()
        {
            
            return "";
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtBuscar.Text.Equals(""))
                {
                    MessageBox.Show("Debe introducir el Nombre de la pelicula para realizar " +
                    "la búsqueda. Luego presione la tecla 'Enter' o 'Return'");
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = buscarPorId();
                    if (dt.Rows.Count > 0)
                    {
                        Clientes clientes = new Clientes();
                        if (dt.Rows.Count == 1)
                        {
                            dgvPeliculas.DataSource = dt.DefaultView;

                            LimpiarControles();
                            string duracion = "";
                            int minutos = 0;

                            txtNombrePeli.Text = dt.Rows[0][0].ToString().Trim();
                            claveNombrePelicula = txtNombrePeli.Text.Trim();
                            //MessageBox.Show(dt.Rows[0][1].ToString());
                            cmbClasifica.SelectedValue = dt.Rows[0][1].ToString().Trim();
                            cmbDistrib.SelectedValue = dt.Rows[0][2].ToString().Trim();
                            dtmEstreno.Value = DateTime.Parse(dt.Rows[0][3].ToString());
                            dtmRetiro.Value = DateTime.Parse(dt.Rows[0][4].ToString());
                            duracion = dt.Rows[0][5].ToString();
                            minutos = horaAMinutos(duracion);
                            //MessageBox.Show(duracion + "     " + minutos);
                            numDuracion.Value = minutos;
                            chkDisponible.Checked = bool.Parse(dt.Rows[0][6].ToString());

                        }
                        else
                        {

                            MessageBox.Show("De 'click' en la fila para realizar las " +
                                "operaciones.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario con el criterio " +
                            "especificado");
                    }
                }
            }
        }

        private int horaAMinutos(string duracion)
        {
            int minutos = 0;

            string[] arrTiempo;
            arrTiempo = duracion.Split(':');
            minutos = int.Parse(arrTiempo[0]) * 60 + int.Parse(arrTiempo[1]);
            
            return minutos;
        }

        private DataTable buscarPorId()
        {
            DataTable dt = new DataTable();

            claveNombrePelicula = txtBuscar.Text;

            string sql = "select top 1 * from Peliculas " +
            " where claveNombrePelicula like '%" + claveNombrePelicula + "%'";

            Console.WriteLine(sql);

            ProcesosBD pbd = new ProcesosBD();
            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            return dt;
        }

        private void btnRecargarTabla_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            vaciarFormAPeliculas();
            int disponible=1;
            if (!peliculas.Disponible)
            {
                disponible = 0;
            }
            peliculas.Duracion = parseDuracion(numDuracion.Value);

            string sql = "update peliculas " +
                " set claveNombrePelicula=UPPER('" + peliculas.ClaveNombrePelicula + "')," +
                " clasificacion='" + peliculas.Clasificacion + "'," +
                " distribuidor='" + peliculas.Distribuidor + "'," +
                " fechaEstreno='" + peliculas.FechaEstreno + "'," +
                " fechaRetiro='" + peliculas.FechaRetiro + "'," +
                " duracion='" + peliculas.Duracion + "'," +
                " disponible=" + disponible + "" +
                " where claveNombrePelicula = '" + claveNombrePelicula + "'";

            Console.WriteLine(sql);

            if (!claveNombrePelicula.Equals("") && !peliculas.ClaveNombrePelicula.Equals(""))
            {
                ProcesosBD pbd = new ProcesosBD();
                DataTable dt = new DataTable();
                pbd.Conectar();
                pbd.SqlUpdate(sql);
                txtBuscar.Text = txtNombrePeli.Text;
                dt = buscarPorId();
                dgvPeliculas.DataSource = dt.DefaultView;
                MessageBox.Show("Actualización correcta");
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("Debe traer los datos por medio de la barra buscar. " +
                    "Coloque el nombre de la película y luego presione 'Enter' o 'Return'");
            }
        }

        private void vaciarFormAPeliculas()
        {
            peliculas = new Peliculas();

            peliculas.ClaveNombrePelicula = txtNombrePeli.Text;
            peliculas.Clasificacion = cmbClasifica.SelectedValue.ToString();
            peliculas.Distribuidor = cmbDistrib.SelectedValue.ToString();
            peliculas.FechaEstreno = dtmEstreno.Text;
            peliculas.FechaRetiro = dtmRetiro.Text;
            peliculas.Duracion = numDuracion.Value.ToString();
            peliculas.Disponible = chkDisponible.Checked;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "delete from peliculas where claveNombrePelicula='" 
                + claveNombrePelicula + "'";

            if (!claveNombrePelicula.Equals(""))
            {
                    DialogResult d = MessageBox.Show(
                        "Seguro que desea eliminar la Película: "
                        + claveNombrePelicula
                            , "Aceptar", MessageBoxButtons.OKCancel);

                    if (d.Equals(DialogResult.OK))
                    {
                    ProcesosBD pbd = new ProcesosBD();
                    pbd.Conectar();
                    pbd.SqlUpdate(sql);
                    MessageBox.Show("Eliminación exitosa");
                    LimpiarControles();
                    CargarTabla();
                }
                
            }
            else
            {
                MessageBox.Show("Debe traer los datos por medio de la barra buscar. " +
                    "Coloque el nombre de la película y luego presione 'Enter' o 'Return'");
            }
        }
    }
}
