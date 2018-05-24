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
    public partial class FrmSalas : Form
    {
        private ProcesosBD pbd;
        private DataTable dt;
        private Dictionary<int, int> liSalaTipoSala = new Dictionary<int, int>();

        public FrmSalas()
        {
            InitializeComponent();
        }

        private void FrmSalas_Load(object sender, EventArgs e)
        {
            cargarForm();
        }

        private void cmbSalas_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int disp = 1;
            if (!chkDisponibleMod.Checked)
                disp = 0;

            string sql = "update salas set" +
                " claveTipoSala = " + cmbTipoSalaMod.SelectedValue +
                ", disponible = " + disp +
                " where claveSala = " + cmbSalas.SelectedValue;

            pbd.Conectar();
            pbd.SqlUpdate(sql);

            liSalaTipoSala.Remove(int.Parse(cmbSalas.SelectedValue.ToString()));
            liSalaTipoSala.Add(int.Parse(cmbSalas.SelectedValue.ToString()),
                int.Parse(cmbTipoSalaMod.SelectedValue.ToString()));
            MessageBox.Show("Se ha actualizado el registro correctamente.");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int disp = 1;
            if (!chkDisponibleMod.Checked)
                disp = 0;

            string sql = "insert into salas(claveTipoSala,disponible) " +
                "values(" + cmbTipoSalaMod.SelectedValue + "," + disp + ")";
            
            pbd.Conectar();
            pbd.SqlUpdate(sql);
            cmbTipoSalaMod.Refresh();
            cargarForm();
            MessageBox.Show("Se ha agregado una nueva sala.");
        }

        private void cargarForm()
        {
            string sql = "select  * from Salas";


            pbd = new ProcesosBD();
            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];
            liSalaTipoSala.Clear();

            if (dt.Rows.Count > 0)
            {
                cmbSalas.DataSource = dt.DefaultView;
                cmbSalas.DisplayMember = "claveSala";
                cmbSalas.ValueMember = "claveSala";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    liSalaTipoSala.Add(int.Parse(dt.Rows[i][0].ToString()),
                        int.Parse(dt.Rows[i][1].ToString()));
                    //MessageBox.Show(dt.Rows[i][0].ToString() + "  " + dt.Rows[i][1].ToString());
                }
            }

            sql = "select claveTipoSala, descripcion + ' ' + " +
                "convert(nvarchar,capacidad,103)descripcion from TipoSala";

            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            if (dt.Rows.Count > 0)
            {
                cmbTipoSalaMod.DataSource = dt.DefaultView;
                cmbTipoSalaMod.DisplayMember = "descripcion";
                cmbTipoSalaMod.ValueMember = "claveTipoSala";
            }

            chkDisponibleMod.Checked = true;
        }

        private void cmbSalas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTipoSalaMod.SelectedValue != null && cmbSalas.SelectedValue != null)
            {
                //MessageBox.Show(cmbSalas.SelectedValue.ToString());

                cmbTipoSalaMod.SelectedValue = liSalaTipoSala[int.Parse(
                    cmbSalas.SelectedValue.ToString())];
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "select max(clavesala)maxSala from salas";

            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            if (dt.Rows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Se eliminará el último registro de la sala" +
                    "en la base de datos: " +dt.Rows[0][0].ToString()+ ". ¿Desea continuar?\n"
                            , "Aceptar", MessageBoxButtons.OKCancel);

                int i = 0;
                if (d.Equals(DialogResult.OK))
                {
                    sql = "delete from salas where clavesala=" + dt.Rows[0][0].ToString();

                    pbd.Conectar();
                    pbd.SqlUpdate(sql);

                    cmbTipoSalaMod.Refresh();
                    cargarForm();
                    MessageBox.Show("Se ha actualizado el registro correctamente.");
                }       
            }
        }
    }
}
