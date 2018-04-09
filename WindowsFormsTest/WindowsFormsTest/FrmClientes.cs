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
    public partial class FrmClientes : Form
    {
        ProcesosBD pbd;
        Clientes clientes;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CargarTabla()
        {
            pbd = new ProcesosBD();
            pbd.Conectar();

            string sql = "select * from clientes order by clavecliente desc";
            dgvClientes.DataSource = pbd.SqlSelect(sql).Tables[0];
        }
    }
}
