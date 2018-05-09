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
            Boolean err = false;

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
            clientes.TipoCliente = int.Parse(cmbTipoUsuario.Text);
            if (clientes.TipoCliente.Equals("Preferente")) tipoCliente = 1;
            else if (clientes.TipoCliente.Equals("Premier")) tipoCliente = 2;
            else if (clientes.TipoCliente.Equals("VIP")) tipoCliente = 3;
            clientes.Puntos = 0;

            string sql = "insert into Clientes(nombres,curp,paterno,materno,calle,numeroExterior," +
                "numeroInterior,cp,colonia,localidad, telefonoCasa, telefonoMovil, fechaRegistro, " +
                "mail, constrasena, puntos, disponible, tipoCliente)" +
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
                limpiarControles();
                CargarTabla();
            }
            catch(Exception error)
            {
                err = true;
                MessageBox.Show("No fue posible insertar en la base de datos, causa: " + error);
            }
            if (!err)
            {
                MessageBox.Show("Registro exitoso");
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
            txtPuntos.Text = "";
            txtPuntosUsados.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13 && !textBox1.Text.Equals(""))
            {
                long claveCliente = 0;
                bool esNumero = long.TryParse(textBox1.Text.ToString().Trim(),out claveCliente);
                if (esNumero)
                {
                    claveCliente = long.Parse(textBox1.Text.ToString().Trim());
                }



                //MessageBox.Show("se ha presionado enter");
                string sql = "select top 1 * from clientes " +
                " where claveCliente =" + claveCliente.ToString() + "" +
                " or curp  ='" + textBox1.Text.ToString().Trim() + "'" +
                " or paterno ='" + textBox1.Text.ToString().Trim() + "' " +
                " or Nombres ='" + textBox1.Text.ToString().Trim() + "'" +
                " or telefonoMovil = '" + textBox1.Text.ToString().Trim() + "'" +
                " or mail ='" + textBox1.Text.ToString().Trim() + "'";

                Console.WriteLine(sql);

                pbd.Conectar();
                DataTable dt = new DataTable();
                dt = pbd.SqlSelect(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    System.Object[] liTipoCliente =
                    {
                        "Preferente","Premier","VIP"
                    };
                    Clientes clientes = new Clientes();
                    if (dt.Rows.Count == 1)
                    {
                        limpiarControles();
                        int stat = 0;
                        clientes.Status = true;
                        bool s = true;

                        clientes.ClaveCliente = int.Parse(dt.Rows[0][0].ToString().Trim());
                        clientes.Nombres = dt.Rows[0][1].ToString().Trim();
                        txtNombreCliente.Text = clientes.Nombres;
                        clientes.Curp = dt.Rows[0][2].ToString().Trim();
                        txtCurp.Text = clientes.Curp;
                        clientes.Paterno = dt.Rows[0][3].ToString().Trim();
                        txtPaterno.Text = clientes.Paterno;
                        clientes.Materno = dt.Rows[0][4].ToString().Trim();
                        txtMaterno.Text = clientes.Materno;
                        clientes.Calle = dt.Rows[0][5].ToString().Trim();
                        txtCalle.Text = clientes.Calle;
                        clientes.NumExt = dt.Rows[0][6].ToString().Trim();
                        txtNumExt.Text = clientes.NumExt;
                        clientes.NumInt = dt.Rows[0][7].ToString().Trim();
                        txtNumInt.Text = clientes.NumInt;
                        clientes.Cp = dt.Rows[0][8].ToString().Trim();
                        txtCP.Text = clientes.Cp;
                        clientes.Colonia = dt.Rows[0][9].ToString().Trim();
                        txtColonia.Text = clientes.Colonia;
                        clientes.Localidad = dt.Rows[0][10].ToString().Trim();
                        txtLocalidad.Text = clientes.Localidad;
                        clientes.TelefonoCasa = dt.Rows[0][11].ToString().Trim();
                        txtTelFijo.Text = clientes.TelefonoCasa;
                        clientes.TelefonoMovil = dt.Rows[0][12].ToString().Trim();
                        txtTelMovil.Text = clientes.TelefonoMovil;
                        clientes.FechaRegistro = dt.Rows[0][13].ToString().Trim();
                        clientes.Mail = dt.Rows[0][14].ToString().Trim();
                        txtMail.Text = clientes.Mail;
                        clientes.Contrasena = dt.Rows[0][15].ToString().Trim();
                        clientes.Puntos = int.Parse(dt.Rows[0][16].ToString().Trim());
                        txtPuntos.Text = clientes.Puntos.ToString();
                        s= bool.Parse(dt.Rows[0][17].ToString().Trim());
                        if (!s)
                            clientes.Status = false;
                        chkStatusUser.Checked = clientes.Status;
                        clientes.TipoCliente = int.Parse(dt.Rows[0][18].ToString().Trim());
                        cmbTipoUsuario.ValueMember = clientes.TipoCliente.ToString();
                        cmbTipoUsuario.DisplayMember = (string)liTipoCliente[clientes.TipoCliente-1];
                        clientes.PuntosUsados = int.Parse(dt.Rows[0][19].ToString().Trim());
                        txtPuntosUsados.Text = clientes.PuntosUsados.ToString();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún usuario con el criterio especificado");
                }
            }
        }
    }
}
