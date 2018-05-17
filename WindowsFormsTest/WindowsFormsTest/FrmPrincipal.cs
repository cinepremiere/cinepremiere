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
    public partial class FrmPrincipal : Form
    {

        private int tipoUsuario;

        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeliculas frmPeliculas = new FrmPeliculas();
            frmPeliculas.Show();
        }

        private void membresíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        private void agregarOModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFunciones frmFunciones = new FrmFunciones();
            frmFunciones.Show();
        }

        private void boletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.Show();
        }

        private void uusariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (TipoUsuario == 1)
            {

            }
            else if (TipoUsuario == 2)
            {
                reportesToolStripMenuItem.Available = false;
            }
            else if (TipoUsuario == 3)
            {
                películasToolStripMenuItem.Available = false;
                reportesToolStripMenuItem.Available = false;
                rHToolStripMenuItem.Available = false;
                funcionesToolStripMenuItem.Available = false;
                salasToolStripMenuItem.Available = false;
            }
            else if (TipoUsuario == 4)
            {

            }
        }

        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPantallaClientes frmPantallaClientes = new FrmPantallaClientes();
            frmPantallaClientes.Show();
        }

        private void agregarOModificarSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalas frmSalas = new FrmSalas();
            frmSalas.Show();
        }

        private void cancelarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCancelaciones frmCancelaciones = new FrmCancelaciones();
            frmCancelaciones.Show();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentasSemana frmEstadisticas = new FrmVentasSemana();

            frmEstadisticas.Show();
        }
    }
}
