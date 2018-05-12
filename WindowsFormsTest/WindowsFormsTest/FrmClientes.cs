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
        int claveCli = 0;
        Dictionary<int, string> liTIpoCli;

        public int ClaveCli { get => claveCli; set => claveCli = value; }

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

            CargarTabla();

            liTIpoCli = new Dictionary<int, string>();
            liTIpoCli.Add(1,"Preferente");
            liTIpoCli.Add(2, "Premier");
            liTIpoCli.Add(3, "VIP");

            cmbTipoUsuario.DataSource = new BindingSource(liTIpoCli, null);
            cmbTipoUsuario.DisplayMember = "Value";
            cmbTipoUsuario.ValueMember = "Key";
            
            chkStatusUser.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int status = 1;
            clientes = new Clientes();
            Boolean err = false;

            if (chkStatusUser.Checked == false)
            {
                status = 0;
            }

            vaciarFormAClientes();
            //MessageBox.Show(cmbTipoUsuario.SelectedValue +  "   "
            //    +((KeyValuePair<int,string>)cmbTipoUsuario.SelectedItem).Value);

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
                + "" + cmbTipoUsuario.SelectedValue.ToString() + ""
                + ")";

            
            Console.Write(sql);
            try
            {
                pbd.Conectar();
                validarDatos();
                if (txtNombreCliente.Text != "")
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
            if (e.KeyChar==13)
            {
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("Debe introducir uno de los siguientes datos " +
                    "para relaizar la busqueda:" +
                    " ID del cliente, CURP, Apellido Paterno, email o teléfono móvil. " +
                    "Luego presione la tecla 'Enter' o 'Return'");
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
                            dgvClientes.DataSource = dt.DefaultView;

                            limpiarControles();

                            clientes.ClaveCliente = int.Parse(dt.Rows[0][0].ToString().Trim());
                            txtClave.Text = clientes.ClaveCliente.ToString();
                            claveCli = clientes.ClaveCliente;
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
                            txtPass.Text = clientes.Contrasena;
                            clientes.Puntos = int.Parse(dt.Rows[0][16].ToString().Trim());
                            txtPuntos.Text = clientes.Puntos.ToString();
                            chkStatusUser.Checked = bool.Parse(dt.Rows[0][17].ToString().Trim());
                            clientes.TipoCliente = int.Parse(dt.Rows[0][18].ToString().Trim());
                            cmbTipoUsuario.SelectedValue = clientes.TipoCliente;
                            clientes.PuntosUsados = int.Parse(dt.Rows[0][19].ToString().Trim());
                            txtPuntosUsados.Text = clientes.PuntosUsados.ToString();
                        }
                        else
                        {
                            dgvClientes.DataSource = dt.DefaultView;
                            MessageBox.Show("De 'click' en la fila para realizar las operaciones.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario con el criterio especificado");
                    }
                }   
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            vaciarFormAClientes();
            int disponible = 1;

            if (!clientes.Status)
            {
                disponible = 0;
            }
            
            string sql = "update Clientes " +
                " set Nombres='" + clientes.Nombres + "'," +
                " curp ='" + clientes.Curp + "'," +
                " paterno ='" + clientes.Paterno + "'," +
                " materno ='" + clientes.Materno + "'," +
                " calle ='" + clientes.Calle + "'," +
                " numeroExterior ='" + clientes.NumExt + "'," +
                " numeroInterior ='" + clientes.NumInt + "'," +
                " cp ='" + clientes.Cp + "'," +
                " colonia ='" + clientes.Colonia + "'," +
                " localidad ='" + clientes.Localidad + "'," +
                " telefonoCasa ='" + clientes.TelefonoCasa + "'," +
                " telefonoMovil ='" + clientes.TelefonoMovil + "'," +
                " fechaRegistro ='" + clientes.FechaRegistro + "'," +
                " mail ='" + clientes.Mail + "'," +
                " constrasena ='" + clientes.Contrasena + "'," +
                " puntos =" + clientes.Puntos + "," +
                " disponible =" + disponible + "," +
                " tipoCliente =" + clientes.TipoCliente + "," +
                " puntosUsados =" + clientes.PuntosUsados + "" +
                " where claveCliente=" + claveCli;

            ProcesosBD pbd = new ProcesosBD();
            pbd.Conectar();
            pbd.SqlUpdate(sql);
            validarDatos();
            MessageBox.Show("Modificación exitosa");
            DataTable dt = new DataTable();
            dt = buscarPorId();
            if (dt.Rows.Count > 0)
            {
                dgvClientes.DataSource = dt.DefaultView;
            }
        }

        private void vaciarFormAClientes()
        {
            clientes = new Clientes();
            //MessageBox.Show(txtNombreCliente.Text);
            if (txtNombreCliente.Text != "")
            {
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
                clientes.TipoCliente = int.Parse(cmbTipoUsuario.SelectedValue.ToString());
                clientes.Puntos = int.Parse(txtPuntos.Text);
                clientes.PuntosUsados = int.Parse(txtPuntosUsados.Text);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
            this.ClaveCli = 0;
            txtClave.Text = "";
            textBox1.Text = "";
        }

        private string validarDatos()
        {


            return "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool isInt = false;
            int clave = 0;
            if (txtClave!=null && txtClave.Text!="")
                isInt = int.TryParse(txtClave.Text,out clave);

            string sql = "delete from clientes where clavecliente=" + clave;
            pbd.Conectar();

            if (clave != 0)
            {
                DialogResult d = MessageBox.Show(
                    "Seguro que desea eliminar al cliente con clave"
                    + clave
                        , "Aceptar", MessageBoxButtons.OKCancel);

                if (d.Equals(DialogResult.OK))
                {
                    pbd.SqlUpdate(sql);
                    MessageBox.Show("Se ha eliminado el registro exitosamente");
                    txtClave.Text = "";
                }

                CargarTabla();
            }
        }

        private DataTable buscarPorId()
        {
            DataTable dt = new DataTable();

            long claveCliente = 0;
            bool esNumero = long.TryParse(textBox1.Text.ToString().Trim(), out claveCliente);
            if (esNumero)
            {
                claveCliente = long.Parse(textBox1.Text.ToString().Trim());
            }

            //MessageBox.Show("se ha presionado enter");
            string sql = "select * from clientes " +
            " where claveCliente =" + claveCliente.ToString() + "" +
            " or curp  ='" + textBox1.Text.ToString().Trim() + "'" +
            " or paterno ='" + textBox1.Text.ToString().Trim() + "' " +
            " or Nombres ='" + textBox1.Text.ToString().Trim() + "'" +
            " or telefonoMovil = '" + textBox1.Text.ToString().Trim() + "'" +
            " or mail ='" + textBox1.Text.ToString().Trim() + "'";

            Console.WriteLine(sql);

            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            return dt;
        }

        private void btnRecargarTabla_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
