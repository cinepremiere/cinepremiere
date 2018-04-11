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
    public partial class FrmFunciones : Form
    {
        ProcesosBD pbd;
        Funciones funciones;

        public FrmFunciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            funciones = new Funciones();

            

        }

        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            CargarTabla();


        }

        public void CargarTabla()
        {
            pbd = new ProcesosBD();
            pbd.Conectar();
            string sql = "select * from funciones";
            dgvFunciones.DataSource = pbd.SqlSelect(sql).Tables[0];
        }
    }
}
