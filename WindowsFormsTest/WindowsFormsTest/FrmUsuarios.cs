using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class FrmUsuarios : Form
    {
        ProcesosBD pbd;
        int claveUsuario = 0;
        Usuario usuario;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            dtmInicioContrato.Format = DateTimePickerFormat.Custom;
            dtmInicioContrato.CustomFormat = "yyyy/MM/dd";

            dtmInicioJornada.Format = DateTimePickerFormat.Custom;
            dtmInicioJornada.CustomFormat = "HH:mm";

            dtmFinJornada.Format = DateTimePickerFormat.Custom;
            dtmFinJornada.CustomFormat = "HH:mm";

            string sql = "select claveTipoUsuario,tipoUsuario from TipoUsuario";

            pbd = new ProcesosBD();
            pbd.Conectar();
            cmbTipoUsuario.DataSource = pbd.SqlSelect(sql).Tables[0].DefaultView;
            cmbTipoUsuario.ValueMember = "claveTipoUsuario";
            cmbTipoUsuario.DisplayMember = "tipoUsuario";
            cmbTipoUsuario.SelectedValue = 3;

            string[] liSalarios = { "3590.0000", "4575.0000", "5000.0000", "6500.0000", "8000.0000"
                    , "12000.0000", "15000.0000", "23000.0000", "35000.0000", "45000.0000" };

            Dictionary<string, string> liSalario = new Dictionary<string, string>();

            liSalario.Add("3590.0000", "3590.0000");
            liSalario.Add("4575.0000", "4575.0000");
            liSalario.Add("5000.0000", "5000.0000");
            liSalario.Add("6500.0000", "6500.0000");
            liSalario.Add("8000.0000", "8000.0000");
            liSalario.Add("12000.0000", "12000.0000");
            liSalario.Add("15000.0000", "15000.0000");
            liSalario.Add("23000.0000", "23000.0000");
            liSalario.Add("35000.0000", "35000.0000");
            liSalario.Add("45000.0000", "45000.0000");

            //cmbSueldo.Items.AddRange(liSalarios);
            cmbSueldo.DataSource = new BindingSource(liSalario,null);
            cmbSueldo.DisplayMember = "Value";
            cmbSueldo.ValueMember = "Key";

            chkStatusUser.Checked = true;

            CargarTabla();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            int disponible = 1;
            if (!chkStatusUser.Checked)
                disponible = 0;

            string sql = "";

            sql = "insert into Usuarios(curp,  Nombres, paterno, materno, claveTipoUsuario" +
                ", calle, numeroExterior, numeroInterior, cp, colonia, localidad, telefonoCasa" +
                ", telefonoMovil, inicioContrato, inicioTurno, finTurno, mail, suledo, contrasena" +
                ", disponible)" +
                "values(" +
                "'" + txtCurp.Text + "'," +
                "'" + txtNombreUsuario.Text + "'," +
                "'" + txtPaterno.Text + "'," +
                "'" + txtMaterno.Text + "'," +
                "'" + cmbTipoUsuario.SelectedValue.ToString() + "'," +
                "'" + txtCalle.Text + "'," +
                "'" + txtNumExt.Text + "'," +
                "'" + txtNumInt.Text + "'," +
                "'" + txtCP.Text + "'," +
                "'" + txtColonia.Text + "'," +
                "'" + txtLocalidad.Text + "'," +
                "'" + txtTelFijo.Text + "'," +
                "'" + txtTelMovil.Text + "'," +
                "'" + dtmInicioContrato.Value.ToString("yyyy/MM/dd") + "'," +
                "'" + dtmInicioJornada.Value.ToString("hh:mm") + "'," +
                "'" + dtmFinJornada.Value.ToString("hh:mm") + "'," +
                "'" + txtMail.Text + "'," +
                "'" + cmbSueldo.Text+ "'," +
                "'" + txtPass.Text + "'," +
                disponible +
                ")";

            Console.WriteLine(sql);

            pbd = new ProcesosBD();
            pbd.Conectar();
            pbd.SqlUpdate(sql);
            MessageBox.Show("Se ha insertado el registro correctamente");

            limpiarControles();
            CargarTabla();
        }

        private void CargarTabla()
        {
            pbd = new ProcesosBD();
            pbd.Conectar();
            string sql = "select * from usuarios order by claveusuario desc";
            dgvUsuarios.DataSource = pbd.SqlSelect(sql).Tables[0];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            cmbTipoUsuario.SelectedValue = 3;
            claveUsuario = 0;
            dtmInicioJornada.Format = DateTimePickerFormat.Custom;
            dtmInicioJornada.CustomFormat = "HH:mm";
            dtmInicioJornada.Value = DateTime.Today;

            dtmFinJornada.Format = DateTimePickerFormat.Custom;
            dtmFinJornada.CustomFormat = "HH:mm";
            dtmFinJornada.Value = DateTime.Today;

            dtmInicioContrato.Format = DateTimePickerFormat.Custom;
            dtmInicioContrato.CustomFormat = "yyyy/MM/dd";
            dtmInicioContrato.Value = DateTime.Today;

            chkStatusUser.Checked = true;
            cmbSueldo.SelectedValue = "3590.0000";
            txtMail.Text = "";
            txtPass.Text = "";
            txtNombreUsuario.Text = "";
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
            txtClaveUsuario.Text = "";
        }

        private void btnRecargarTabla_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (claveUsuario!=0)
            {
                vaciarFormAUsuario();

                string sql = "update Usuarios set " +
                    "curp = '" + usuario.Curp + "'," +
                    "Nombres = '" + usuario.Nombres + "'," +
                    "paterno = '" + usuario.Paterno + "'," +
                    "materno='" + usuario.Materno + "'," +
                    "claveTipoUsuario='" + usuario.ClaveTipoUsuario + "'," +
                    "calle='" + usuario.Calle + "'," +
                    "numeroExterior='" + usuario.NumExt + "'," +
                    "numeroInterior='" + usuario.NumInt + "',cp='" + usuario.Cp + "'," +
                    "colonia='" + usuario.Colonia + "',localidad='" + usuario.Localidad + "'," +
                    "telefonoCasa='" + usuario.TelCasa + "'," +
                    "telefonoMovil='" + usuario.TelMovil + "'," +
                    "inicioContrato='" + usuario.InicioContrato + "'," +
                    "inicioTurno='" + usuario.InicioTurno + "'," +
                    "finTurno='" + usuario.FinTurno + "'," +
                    "mail='" + usuario.Mail + "'," +
                    "suledo='" + usuario.Sueldo + "'," +
                    "contrasena='" + usuario.Password + "'," +
                    "disponible='" + usuario.Disponible + "' " +
                    "where claveUsuario = '" + claveUsuario + "'";

                Console.WriteLine(sql);

                //validarDatos();
                ProcesosBD pbd = new ProcesosBD();
                DataTable dt = new DataTable();
                pbd.Conectar();
                pbd.SqlUpdate(sql);
                dt = buscarPorId();
                dgvUsuarios.DataSource = dt.DefaultView;
                MessageBox.Show("Actualización correcta");
                limpiarControles();
            }
            else
            {
                MessageBox.Show("Debe traer los datos por medio de la barra buscar. " +
                    "Coloque cualquiera de los siguientes datos: " +
                    "clave de Usuario, nombre del usuario, Paterno, Teléfono Móvil, mail" +
                    "y luego presione 'Enter' o 'Return'");
            }
        }

        private void validarDatos()
        {
            throw new NotImplementedException();
        }

        private void vaciarFormAUsuario()
        {
            usuario = new Usuario();
            bool disponible = true;

            usuario.Curp = txtCurp.Text;
            usuario.Nombres = txtNombreUsuario.Text;
            usuario.Paterno = txtPaterno.Text;
            usuario.Materno = txtMaterno.Text;
            usuario.ClaveTipoUsuario = int.Parse(cmbTipoUsuario.SelectedValue.ToString());
            usuario.Calle = txtCalle.Text;
            usuario.NumExt = txtNumExt.Text;
            usuario.NumInt = txtNumInt.Text;
            usuario.Cp = txtCP.Text;
            usuario.Colonia = txtColonia.Text;
            usuario.Localidad = txtLocalidad.Text;
            usuario.TelCasa = txtTelFijo.Text;
            usuario.TelMovil = txtTelMovil.Text;
            usuario.InicioContrato = dtmInicioContrato.Text;
            usuario.InicioTurno = dtmInicioJornada.Text;
            usuario.FinTurno = dtmFinJornada.Text;
            usuario.Mail = txtMail.Text;
            usuario.Sueldo = float.Parse(cmbSueldo.SelectedValue.ToString());
            usuario.Password = txtPass.Text;
            disponible = chkStatusUser.Checked;
            if (disponible)
                usuario.Disponible = 1;
            else
                usuario.Disponible = 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtBuscar.Text.Equals(""))
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
                        if (dt.Rows.Count == 1)
                        {
                            dgvUsuarios.DataSource = dt.DefaultView;

                            limpiarControles();

                            
                            txtClaveUsuario.Text = dt.Rows[0][0].ToString().Trim();
                            claveUsuario = int.Parse(txtClaveUsuario.Text);
                            txtCurp.Text = dt.Rows[0][1].ToString().Trim();
                            txtNombreUsuario.Text = dt.Rows[0][2].ToString().Trim();
                            txtPaterno.Text = dt.Rows[0][3].ToString().Trim();
                            txtMaterno.Text = dt.Rows[0][4].ToString().Trim();
                            cmbTipoUsuario.SelectedValue = dt.Rows[0][5].ToString().Trim();
                            txtCalle.Text = dt.Rows[0][6].ToString().Trim();
                            txtNumExt.Text = dt.Rows[0][7].ToString().Trim();
                            txtNumInt.Text = dt.Rows[0][8].ToString().Trim();
                            txtCP.Text = dt.Rows[0][9].ToString().Trim();
                            txtColonia.Text = dt.Rows[0][10].ToString().Trim();
                            txtLocalidad.Text = dt.Rows[0][11].ToString().Trim();
                            txtTelFijo.Text = dt.Rows[0][12].ToString().Trim();
                            txtTelMovil.Text = dt.Rows[0][13].ToString().Trim();
                            dtmInicioContrato.Value = DateTime.Parse( dt.Rows[0][14].ToString().Trim());
                            dtmInicioJornada.Value = DateTime.Parse(dt.Rows[0][15].ToString().Trim());
                            dtmFinJornada.Value = DateTime.Parse(dt.Rows[0][16].ToString().Trim());
                            txtMail.Text = dt.Rows[0][17].ToString().Trim();
                            cmbSueldo.SelectedValue = dt.Rows[0][18].ToString().Trim();
                            txtPass.Text = dt.Rows[0][19].ToString().Trim();
                            chkStatusUser.Checked = bool.Parse(dt.Rows[0][20].ToString().Trim());

                            //MessageBox.Show(dt.Rows[0][18].ToString().Trim());
                        }
                        else
                        {
                            dgvUsuarios.DataSource = dt.DefaultView;
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

        private DataTable buscarPorId()
        {
            DataTable dt = new DataTable();

            long clave = 0;
            bool esNumero = long.TryParse(txtBuscar.Text.ToString().Trim(), out clave);
            if (esNumero)
            {
                clave = long.Parse(txtBuscar.Text.ToString().Trim());
            }

            //MessageBox.Show("se ha presionado enter");
            string sql = "select * from Usuarios " +
            " where claveUsuario =" + clave.ToString() + "" +
            " or curp  ='" + txtBuscar.Text.ToString().Trim() + "'" +
            " or paterno ='" + txtBuscar.Text.ToString().Trim() + "' " +
            " or Nombres ='" + txtBuscar.Text.ToString().Trim() + "'" +
            " or telefonoMovil = '" + txtBuscar.Text.ToString().Trim() + "'" +
            " or mail ='" + txtBuscar.Text.ToString().Trim() + "'";

            Console.WriteLine(sql);

            pbd.Conectar();
            dt = pbd.SqlSelect(sql).Tables[0];

            return dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool isInt = false;
            int clave = 0;
            if (txtClaveUsuario != null && txtClaveUsuario.Text != "")
                isInt = int.TryParse(txtClaveUsuario.Text, out clave);

            string sql = "delete from usuarios where claveUsuario=" + clave;
            pbd.Conectar();

            if (clave != 0)
            {
                DialogResult d = MessageBox.Show(
                    "Seguro que desea eliminar al usuario con clave"
                    + clave
                        , "Aceptar", MessageBoxButtons.OKCancel);

                if (d.Equals(DialogResult.OK))
                {
                    pbd.SqlUpdate(sql);
                    MessageBox.Show("Se ha eliminado el registro exitosamente");
                    txtClaveUsuario.Text = "";
                }

                CargarTabla();
            }
            else
            {
                MessageBox.Show("Debe obtener datos a partir de la búsqueda por medio de " +
                    "la barra buscar. Coloque cualquiera de los siguientes datos: clave de Usuario," +
                    " Nombres, Paterno, Móvil, mail. Luego presione 'Enter' o 'Return'");
            }
        }
    }
}
