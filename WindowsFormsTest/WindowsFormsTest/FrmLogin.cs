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
    public partial class FrmLogin : Form
    {
        private static string usuario = "";
        private static string contrasena = "";
        private static ushort intentos = 0;
        private static bool bloqueo = false;
        private ProcesosBD pbd;
        private DataTable dt;
        private DataSet ds;

        public FrmLogin()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Focus();
            usuario = "";
            contrasena = "";
            intentos = 0;
            bloqueo = false;
            TxtUsuario.Focus();

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            //ultima actualizacion de prueba 
            //comentarios prueba
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarUsuario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                validarUsuario();
            }
        }

        private void validarUsuario()
        {
            if (TxtUsuario.Text == "" && TxtContrasena.Text != "")
            {
                MessageBox.Show("Ingrese una clave de usuario.", "Campo vacio", MessageBoxButtons.OK);
                TxtUsuario.Focus();

            }
            else if (TxtUsuario.Text != "" && TxtContrasena.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña valida.", "Campo vacio", MessageBoxButtons.OK);
                TxtContrasena.Focus();
            }
            else if (TxtUsuario.Text == "" && TxtContrasena.Text == "")
            {
                MessageBox.Show("Ingrese las credenciales validas.", "Campos vacios", MessageBoxButtons.OK);
                TxtContrasena.Focus();
            }
            else if (TxtUsuario.Text != "" && TxtContrasena.Text != "")
            {
                string sql = "select claveTipoUsuario,claveUsuario,contrasena from Usuarios " +
                    "where claveUsuario='" + TxtUsuario.Text + "' and contrasena = '"
                    + TxtContrasena.Text + "'";

                Console.WriteLine(sql);

                pbd = new ProcesosBD();
                pbd.Conectar();
                dt = new DataTable();
                dt = pbd.SqlSelect(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    Program.ClaveUsario = int.Parse(dt.Rows[0][1].ToString());
                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    frmPrincipal.TipoUsuario = int.Parse(dt.Rows[0][0].ToString());
                    frmPrincipal.Show();
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm != frmPrincipal)    //Cerramos todos los formularios menos el formulario principal que contiene el menú
                            frm.Hide();
                    }
                    //this.Hide();
                }
                else
                {
                    intentos++;
                    if (intentos == 3)
                    {
                        MessageBox.Show("Revise sus credenciales.", "Contraseña Invalida", MessageBoxButtons.OK);
                        TxtContrasena.Focus();
                        intentos = 0;
                    }
                }
            }
        }
    }
}
