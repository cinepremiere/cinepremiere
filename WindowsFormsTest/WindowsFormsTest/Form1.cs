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
        public FrmLogin()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
                intentos++;
                if (intentos == 3)
                {
                    MessageBox.Show("Revise sus credenciales.", "Contraseña Invalida", MessageBoxButtons.OK);
                    TxtContrasena.Focus();
                }
            }

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
    }
}
