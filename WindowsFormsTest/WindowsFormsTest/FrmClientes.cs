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

            System.Object[] liTipoCliente =
            {
                "Preferente","Premier","VIP"
            };

            cmbTipoUsuario.Items.AddRange(liTipoCliente);
            
            chkStatusUser.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int status = 1;
            int tipoCliente=0;
            clientes = new Clientes();

            clientes.Nombres = txtNombreCliente.Text;
            clientes.Paterno = txtPaterno.Text;
            clientes.Materno = txtMaterno.Text;
            clientes.Curp = txtCurp.Text;
            clientes.Calle = txtCalle.Text;
            clientes.NumExt = txtNumExt.Text;
            clientes.NumInt = txtNumInt.Text;
            clientes.Cp = txtCP.Text;
            clientes.Colonia = txtColonia.Text;
            clientes.Localidad = txtLocalidad.Text;
            clientes.TelefonoCasa = txtTelFijo.Text;
            clientes.TelefonoMovil = txtTelMovil.Text;
            clientes.Mail = txtMail.Text;
            clientes.Contrasena = txtPass.Text;
            clientes.Status = chkStatusUser.Checked;
            if (!clientes.Status) status = 0;
            clientes.TipoCliente = cmbTipoUsuario.Text;
            if (clientes.TipoCliente.Equals("Preferente")) tipoCliente = 1;
            else if (clientes.TipoCliente.Equals("Premier")) tipoCliente = 2;
            else if (clientes.TipoCliente.Equals("VIP")) tipoCliente = 3;
            clientes.Puntos = 0;

            string sql = "insert into Clientes(nombres,curp,paterno,materno,calle,numeroExterior," +
                "numeroInterior,cp,colonia,localidad, telefonoCasa, telefonoMovil, fechaRegistro, " +
                "mail, constrasena, puntos, status, tipoCliente)" +
                "values(" 
                + "'" + clientes.Nombres + "',"
                + "'" + clientes.Curp + "',"
                + "'" + clientes.Paterno + "',"
                + "'" + clientes.Materno + "',"
                + "'" + clientes.Calle + "',"
                + "'" + clientes.NumExt + "',"
                + "'" + clientes.NumInt + "',"
                + "'" + clientes.Cp + "',"
                + "'" + clientes.Colonia + "',"
                + "'" + clientes.Localidad + "',"
                + "'" + clientes.TelefonoCasa + "',"
                + "'" + clientes.TelefonoMovil + "',"
                + "getdate(),"
                + "'" + clientes.Mail + "',"
                + "'" + clientes.Contrasena + "',"
                + "'" + clientes.Puntos + "',"
                + "" + status + ","
                + "" + tipoCliente + ""
                + ")";

            Console.Write(sql);
            try
            {
                pbd.Conectar();
                pbd.SqlUpdate(sql);
                MessageBox.Show("Registro exitoso");
                limpiarControles();
                CargarTabla();
            }
            catch(System.Data.SqlClient.SqlException error)
            {
                MessageBox.Show("No fue posible insertar en la base de datos, causa: " + error);
            }
            
        }

        private void CargarTabla()
        {
            pbd = new ProcesosBD();
            pbd.Conectar();

            string sql = "select * from clientes order by clavecliente desc";
            dgvClientes.DataSource = pbd.SqlSelect(sql).Tables[0];
        }

        private void limpiarControles()
        {
            txtNombreCliente.Text="";
            txtPaterno.Text="";
            txtMaterno.Text="";
            txtCurp.Text="";
            txtCalle.Text="";
            txtNumExt.Text="";
            txtNumInt.Text="";
            txtCP.Text="";
            txtColonia.Text="";
            txtLocalidad.Text="";
            txtTelFijo.Text="";
            txtTelMovil.Text="";
            txtMail.Text="";
            txtPass.Text="";
            chkStatusUser.Checked = true;
            cmbTipoUsuario.Text = "Seleccionar";
        }
    }
}
