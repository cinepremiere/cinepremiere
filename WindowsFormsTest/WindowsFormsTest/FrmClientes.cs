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
        Validador validador = new Validador();
        string msjObtenerDatos = "Debe introducir uno de los siguientes datos " +
                    "para realizar la busqueda:" +
                    " ID del cliente, CURP, Apellido Paterno, email o teléfono móvil. " +
                    "Luego presione la tecla 'Enter' o 'Return'";
        public static string validarNombreCompleto = "validarNombreCompleto";
        public static string validarCurp = "validarCurp";
        public static string validarsoloNumeros = "validarsoloNumeros";
        public static string validarFormatoCorreo = "validarFormatoCorreo";
        public static string validarFormatoCURP = "validarFormatoCURP";
        Dictionary<string, string> liValidaciones = new Dictionary<string, string>
        {
            {validarNombreCompleto,validarNombreCompleto},
            {validarCurp,validarCurp},
            {validarsoloNumeros,validarsoloNumeros},
            {validarFormatoCorreo,validarFormatoCorreo},
            {validarFormatoCURP,validarFormatoCURP},
        };


        public int ClaveCli { get => claveCli; set => claveCli = value; }

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

            CargarTabla();

            liTIpoCli = new Dictionary<int, string>();
            liTIpoCli.Add(1, "Preferente");
            liTIpoCli.Add(2, "Premier");
            liTIpoCli.Add(3, "VIP");

            cmbTipoUsuario.DataSource = new BindingSource(liTIpoCli, null);
            cmbTipoUsuario.DisplayMember = "Value";
            cmbTipoUsuario.ValueMember = "Key";

            chkStatusUser.Checked = true;

            txtPuntos.Text = 0 + "";
            txtPuntosUsados.Text = 0 + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int status = 1;
            clientes = new Clientes();
            bool datosValidos = true;
            Boolean err = false;

            if (chkStatusUser.Checked == false)
            {
                status = 0;
            }

            vaciarFormAClientes();
            datosValidos = validarDatosEntrada();

            //MessageBox.Show(cmbTipoUsuario.SelectedValue +  "   "
            //    +((KeyValuePair<int,string>)cmbTipoUsuario.SelectedItem).Value);

            if (datosValidos)
            {
                string sql = "";
                DataTable dt = new DataTable();

                sql = "select curp from clientes where curp='" + txtCurp.Text + "'" +
                    " or telefonoMovil = '" + clientes.TelefonoMovil + "'" +
                    " or mail = '" + clientes.Mail + "'";
                pbd.Conectar();
                dt = pbd.SqlSelect(sql).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un registro con esos datos, no se pueden duplicar," +
                        " verifique curp, claveCliente, telefono movil o correo.");
                }
                else
                {
                    try
                    {
                        sql = "select next value for SCH_Ventas.AI_Ventas";

                        pbd.Conectar();
                        int claveVenta = int.Parse(pbd.SqlSelect(sql).Tables[0].Rows[0][0]
                            .ToString());

                        sql = "select precio from ListaDePrecios l,TipoCliente t " +
                            "where l.claveListaDePrecios = t.claveListaDePrecios " +
                            "and t.claveTipoCliente = "+ cmbTipoUsuario.SelectedValue.ToString() + "";
                        pbd.Conectar();
                        float importeTotal = float.Parse(pbd.SqlSelect(sql).Tables[0].Rows[0][0]
                            .ToString());

                        DialogResult d = MessageBox.Show("Confirmar Pago\n"
                            + "Precio Unitario:  \t\t$" + importeTotal + ".00\n"
                            + "Importe Total: \t\t$" + importeTotal + ".00\n"
                            , "Aceptar", MessageBoxButtons.OKCancel);

                        int i = 0;
                        if (d.Equals(DialogResult.OK))
                        {
                            sql = "insert into Clientes(nombres,curp,paterno,materno,calle,numeroExterior," +
                        "numeroInterior,cp,colonia,localidad, telefonoCasa, telefonoMovil, fechaRegistro, " +
                        "mail, contrasena, puntos, disponible, tipoCliente)" +
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

                            Console.WriteLine(sql);

                            pbd.Conectar();
                            pbd.abrirConexion();
                            pbd.comenzarTransaccion();
                            pbd.sqlUpdateTransaction(sql);

                            sql = "insert into ventas(claveVenta,claveCliente,claveUsuario" +
                                        ",horaFechaVenta,importeTotal) values " +
                                        "(" + claveVenta + "," +
                                        "NULL" +
                                        "," + Program.ClaveUsario + "" +
                                        ",CONVERT(datetime, GETDATE(),103)" +
                                        "," + importeTotal + ")";

                            Console.WriteLine(sql);
                            pbd.sqlUpdateTransaction(sql);

                            sql = "insert into DetallesVentas(claveVenta,boleto,claveTipoVenta" +
                                        ",descuento,iva,precioUnitario,importeParcial" +
                                        ",fechaHoraRegistro,sumaPuntos) values";
                            sql +=
                                            "(" +
                                            "" + claveVenta +
                                            ",NULL" +
                                            ",2" +//tipoventa 2 solo para venta de membresías
                                            ",0" +
                                            ",0" +
                                            "," + importeTotal +
                                            "," + importeTotal + "" +
                                            ",CONVERT(datetime, GETDATE(),103)" +
                                            ",0)";

                            Console.WriteLine(sql);
                            pbd.sqlUpdateTransaction(sql);

                            pbd.Transaction.Commit();
                        }
                    }
                    catch
                    {
                        try
                        {
                            pbd.Transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred
                            // on the server that would cause the rollback to fail, such as
                            // a closed connection.
                            Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                            Console.WriteLine("  Message: {0}", ex2.Message);
                        }
                    }
                    finally
                    {
                        limpiarControles();
                        pbd.Conexion.Close();
                    }

                    Console.Write(sql);
                    if (!err)
                    {
                        MessageBox.Show("Registro exitoso");
                        CargarTabla();
                    }
                }
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
            txtNombreCliente.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtCurp.Text = "";
            txtCalle.Text = "";
            txtNumExt.Text = "";
            txtNumInt.Text = "";
            txtCP.Text = "";
            txtColonia.Text = "";
            txtLocalidad.Text = "";
            txtTelFijo.Text = "";
            txtTelMovil.Text = "";
            txtMail.Text = "";
            txtPass.Text = "";
            chkStatusUser.Checked = true;
            cmbTipoUsuario.Text = "Seleccionar";
            txtPuntos.Text = 0 + "";
            txtPuntosUsados.Text = 0 + "";
            ClaveCli = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show(msjObtenerDatos);
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = buscarPorId();
                    if (dt.Rows.Count > 0)
                    {
                        clientes = new Clientes();
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
            if (ClaveCli == 0)
            {
                MessageBox.Show(msjObtenerDatos);
            }
            else
            {
                bool datosValidos = true;
                vaciarFormAClientes();
                datosValidos = validarDatosEntrada();
                int disponible = 1;

                if (!clientes.Status)
                {
                    disponible = 0;
                }
                if (datosValidos)
                {
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
                    " contrasena ='" + clientes.Contrasena + "'," +
                    " puntos =" + clientes.Puntos + "," +
                    " disponible =" + disponible + "," +
                    " tipoCliente =" + clientes.TipoCliente + "," +
                    " puntosUsados =" + clientes.PuntosUsados + "" +
                    " where claveCliente=" + claveCli;

                    ProcesosBD pbd = new ProcesosBD();
                    pbd.Conectar();
                    pbd.SqlUpdate(sql);
                    MessageBox.Show("Modificación exitosa");
                    DataTable dt = new DataTable();
                    dt = buscarPorId();
                    if (dt.Rows.Count > 0)
                    {
                        dgvClientes.DataSource = dt.DefaultView;
                    }
                }
            }
        }

        private void vaciarFormAClientes()
        {
            clientes = new Clientes();
            //MessageBox.Show(txtNombreCliente.Text);
            
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

        private bool validarDatosEntrada()
        {
            bool datosValidos = true;
            bool correoValido = true;
            bool curpValido = true;
            string msjerrores = "Error:\n";

            if (txtNombreCliente.Text == null || txtNombreCliente.Text.Equals(""))
            {
                msjerrores += "El nombre no puede estar vacío\n";
                datosValidos = false;
            }
            if(txtPaterno.Text == null || txtPaterno.Text.Equals(""))
            {
                msjerrores += "El apellido paterno no puede estar vacío\n";
                datosValidos = false;
            }
            if (txtCurp.Text == null || txtCurp.Text.Equals(""))
            {
                msjerrores += "El curp no puede estar vacío\n";
                datosValidos = false;
            }
            else
            {
                curpValido = validador.validarFormatoCURP(txtCurp.Text);
                if (!curpValido)
                {
                    datosValidos = false;
                    msjerrores += "El formato del CURP es: 4 letras,6 digitos (yymmdd)," +
                        "6 letras,2 digitos\n";
                }
            }
            if (txtCalle.Text == null || txtCalle.Text.Equals(""))
            {
                msjerrores += "La calle no puede estar vacía\n";
                datosValidos = false;
            }
            if (txtNumExt.Text == null || txtNumExt.Text.Equals(""))
            {
                msjerrores += "El número exterior no puede estar vacío\n";
                datosValidos = false;
            }
            if (txtCP.Text == null || txtCP.Text.Equals(""))
            {
                msjerrores += "El CP no puede estar vacío\n";
                datosValidos = false;
            }
            else
            {
                if (txtCP.Text.Length < 5)
                {
                    msjerrores += "El CP no puede tener menos de 5 dígitos\n";
                    datosValidos = false;
                }
            }
            if (txtColonia.Text == null || txtColonia.Text.Equals(""))
            {
                msjerrores += "La colonia no puede estar vacía\n";
                datosValidos = false;
            }
            if (txtLocalidad.Text == null || txtLocalidad.Text.Equals(""))
            {
                msjerrores += "La localidad no puede estar vacía\n";
                datosValidos = false;
            }
            if (txtTelMovil.Text == null || txtTelMovil.Text.Equals(""))
            {
                msjerrores += "El número telefónico móvil no puede estar vacío\n";
                datosValidos = false;
            }
            else
            {
                if (txtTelMovil.Text.Length < 10)
                {
                    msjerrores += "El móvil no puede tener menos de 10 dígitos\n";
                    datosValidos = false;
                }
            }
            if (txtMail.Text == null || txtMail.Text.Equals(""))
            {
                msjerrores += "El correo no puede estar vacío\n";
                datosValidos = false;
            }
            else
            {
                //MessageBox.Show("se esta validando el correo");
                correoValido = validador.validarFormatoCorreo(txtMail.Text);
                if (!correoValido)
                {
                    datosValidos = false;
                    msjerrores += "El formato del correo ingresado no es válido." +
                        "Debe aproximarse al patrón: nombrecuenta@dominio.ext" +
                        "y se aceptan . - _ y uno o más dígitos y más de un subdominio.\n";
                }
            }
            if (txtPass.Text == null || txtPass.Text.Equals(""))
            {
                msjerrores += "El password no puede estar vacío\n";
                datosValidos = false;
            }
            if(int.Parse(txtPuntosUsados.Text) > int.Parse(txtPuntos.Text))
            {
                msjerrores += "Puntos usados no puede ser mayor que puntos\n";
                datosValidos = false;
            }
            if (txtTelFijo.Text.Length > 0 && txtTelFijo.Text.Length < 10)
            {
                msjerrores += "El tel. fijo no puede tener menos de 10 dígitos\n";
                datosValidos = false;
            }
            if (!datosValidos)
            {
                MessageBox.Show(msjerrores);
            }

            return datosValidos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
            this.ClaveCli = 0;
            txtClave.Text = "";
            textBox1.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ClaveCli == 0)
            {
                MessageBox.Show("Debe obtener datos a partir de la búsqueda por medio del" +
                    " buscador");
            }
            else
            {
                bool isInt = false;
                int clave = 0;
                if (txtClave != null && txtClave.Text != "")
                    isInt = int.TryParse(txtClave.Text, out clave);

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

        private void FrmClientes_Leave(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_Leave(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntrada(e,liValidaciones[validarNombreCompleto]);
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntrada(e, liValidaciones[validarNombreCompleto]);
        }


        private void validarEntrada(KeyPressEventArgs e,string tipoValidacion)
        {
            bool esValido = true;

            if (tipoValidacion.Equals(validarNombreCompleto))
            {
                esValido = validador.validarNombreCompleto(e.KeyChar.ToString());
                if (!esValido)
                {
                    MessageBox.Show("No puede contener números ni los siguientes caracteres:\n" +
                        "\\ / . ? ¡ ! * % $ ' # . ");
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else if(tipoValidacion.Equals(validarCurp))
            {
                esValido = validador.validarCurp(e.KeyChar.ToString());
                if (!esValido)
                {
                    MessageBox.Show("Este campo solo puede contener letras mayúsculas y números");
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else if (tipoValidacion.Equals(validarsoloNumeros))
            {
                esValido = validador.validarsoloNumeros(e.KeyChar.ToString());
                if (!esValido)
                {
                    MessageBox.Show("Este campo solo puede contener y números");
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntrada(e,liValidaciones[validarNombreCompleto]);
        }

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntrada(e, liValidaciones[validarCurp]);
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntrada(e, liValidaciones[validarsoloNumeros]);
        }

        private void txtTelFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntrada(e, liValidaciones[validarsoloNumeros]);
        }

        private void txtTelMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntrada(e, liValidaciones[validarsoloNumeros]);
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPuntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntrada(e, liValidaciones[validarsoloNumeros]);
        }

        private void txtPuntosUsados_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntrada(e, liValidaciones[validarsoloNumeros]);
        }

        private void txtPuntos_Leave(object sender, EventArgs e)
        {
            if(txtPuntos.Text == null || txtPuntos.Text.Equals(""))
            {
                txtPuntos.Text = 0 + "";
            }
        }

        private void txtPuntosUsados_Leave(object sender, EventArgs e)
        {
            if (txtPuntosUsados.Text == null || txtPuntosUsados.Text.Equals(""))
            {
                txtPuntosUsados.Text = 0 + "";
            }
        }
    }
}
