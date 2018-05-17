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

        public FrmSalas()
        {
            InitializeComponent();
        }

        private void FrmSalas_Load(object sender, EventArgs e)
        {
            string sql = "select  claveSala from Salas";

            pbd = new ProcesosBD();
            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            if (dt.Rows.Count > 0)
            {
                cmbSalas.DataSource = dt.DefaultView;
                cmbSalas.DisplayMember = "claveSala";
                cmbSalas.ValueMember = "claveSala";
            }

            sql = "select  distinct(s.claveTipoSala)claveTipoSala,descripcion from Salas s," +
                "TipoSala t where s.claveTipoSala = t.claveTipoSala";

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


    }
}
