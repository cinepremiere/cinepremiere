using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class FrmUsuarios : Form
    {
        ProcesosBD pbd;
        DataSet ds;

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

            string[] liSalarios = { "3590", "4575", "5000", "6500", "8000"
                    , "12000", "15000", "23000", "35000", "45000" };

            cmbSueldo.Items.AddRange(liSalarios);

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
                ", telefonoMovil, inicioContrato, inicioTurno, finTurno, mail, suledo, constrasena" +
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

            CargarTabla();
        }

        private void CargarTabla()
        {
            pbd = new ProcesosBD();
            pbd.Conectar();
            string sql = "select * from usuarios order by claveusuario desc";
            dgvUsuarios.DataSource = pbd.SqlSelect(sql).Tables[0];
        }

    }
}
