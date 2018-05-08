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
    public partial class FrmVentas : Form, ISeleccionados
    {
        ProcesosBD pdb;
        bool ready = false;
        int claveFuncion = -1;
        string claveCli = "NULL";
        DataSet ds;
        DataTable dt;
        int puntos = 0;
        float iva = 0.0f;
        Dictionary<int, Butaca> liButacas = new Dictionary<int, Butaca>();
        private float precioUnitario = 0.0f;
        private float descuento = 0.0f;
        private string root = @"F:\UVM\Tareas UVM\07 Septimo Semestre\Ing. de Software I\Parcial 1\";
        Dictionary<string, int> dgvCols = new Dictionary<string, int>
        {
            {"NombrePelicula",0 },
            {"Horario",1 },
            {"TipoFuncion",2 },
            {"Idioma",3 },
            {"Sala",4 },
            {"CantidadAsientos",5 },
            {"SeleccionAsientos",6 },
            {"AsientosSeleccionados",7 },
            {"PrecioUnitario",8 },
            {"Descuento",9 },
            {"IdCliente",10 },
            {"NombreCliente",11 },
            {"CerrarVenta",12 },
        };

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            pdb = new ProcesosBD();

            pdb.Conectar();

            //consulta para producción
            string sql = "select distinct TRIM(clavenombrePelicula) peliculas from peliculas p, " +
                "Funciones f where p.claveNombrePelicula = f.clavePelicula and " +
                "hora>=DATEADD(minute,-20,CONVERT(time,getdate(),108)) order by 1";

            //consulta para desarrollo 
            sql = "select distinct TRIM(clavenombrePelicula) peliculas from peliculas p, " +
                "Funciones f where p.claveNombrePelicula = f.clavePelicula";

            ds = pdb.SqlSelect(sql);
            //dgvVentas.DataSource = ds.Tables[0].DefaultView;
            dt = ds.Tables[0];
            
            foreach(DataRow row in dt.Rows)
            {
                var cmb = new DataGridViewComboBoxCell();
                //var img = new DataGridViewImageCell();
                //Bitmap bitmap;

                //produccion
                sql = "select hora from Funciones where clavePelicula = '" + row["peliculas"] 
                    +"' and hora >=DATEADD(minute,-20,CONVERT(time,getdate(),108))";

                //desarrollo
                sql = "select hora from Funciones where clavePelicula = '"
                    + row["peliculas"] + "'";

                cmb.DataSource = pdb.SqlSelect(sql).Tables[0].DefaultView;
                cmb.ValueMember = "hora";
                cmb.DisplayMember = "hora";

                //sql = "select top 1 (imgPath) from Funciones where clavePelicula = " +
                //    "'"+ row["peliculas"] + "'";

                //img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                
                //MessageBox.Show(root + pdb.SqlSelect(sql).Tables[0].Rows[0][0]);
                //bitmap = new Bitmap(root + pdb.SqlSelect(sql).Tables[0].Rows[0][0]);
                //img.Value = bitmap;

                int n = dgvVentas.Rows.Add();
                dgvVentas.Rows[n].Cells[dgvCols["NombrePelicula"]].Value = 
                    row["peliculas"].ToString();
                //dgvVentas.Rows[n].Cells[dgvCols["ImgPelicula"]] = img;
                dgvVentas.Rows[n].Cells[dgvCols["Horario"]] = cmb;
                dgvVentas.Rows[n].Cells[dgvCols["Descuento"]].Value = "$" 
                    + descuento.ToString() + ".00";
                //MessageBox.Show(Program.ClaveUsario.ToString());
            }
            ready = true;
        }

        private void dgvVentas_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }

        private void dgvVentas_Leave(object sender, EventArgs e)
        {
            
        }

        private void dgvVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ready)
            {
                var cmb = new DataGridViewComboBoxCell();
                if (e.ColumnIndex == dgvCols["Horario"])
                {
                    //MessageBox.Show("se ha cambiado el estatus");
                    string sql = "select claveTipoFuncion, descripcion from TipoFuncion " +
                        "where claveTipoFuncion " +
                        "in(select claveTipoFuncion from Funciones where clavePelicula = " +
                        "'" + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["NombrePelicula"]].Value.ToString().Trim() + "'" +
                        " and hora =" +
                        "'"+ dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Horario"]].Value.ToString().Trim() + "')";

                    Console.WriteLine(sql);

                    pdb.Conectar();
                    cmb.DataSource = pdb.SqlSelect(sql).Tables[0].DefaultView;
                    cmb.ValueMember = "claveTipoFuncion";
                    cmb.DisplayMember = "descripcion";

                    

                    dgvVentas.Rows[e.RowIndex].Cells[dgvCols["TipoFuncion"]] = cmb;
                }
                else if (e.ColumnIndex == dgvCols["TipoFuncion"])
                {
                    string sql = "select claveIdioma, idioma from idioma where claveIdioma in(select " +
                        "claveIdioma from Funciones where clavePelicula =" +
                        "'" + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["NombrePelicula"]].Value.ToString().Trim() + "' " +
                        " and hora =" +
                        "'" + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Horario"]].Value.ToString().Trim() + "'" +
                        " and claveTipoFuncion = " + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["TipoFuncion"]].Value.ToString().Trim() + ")";

                    pdb.Conectar();
                    cmb.DataSource = pdb.SqlSelect(sql).Tables[0].DefaultView;
                    cmb.ValueMember = "claveIdioma";
                    cmb.DisplayMember = "idioma";

                    dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Idioma"]] = cmb;
                }
                else if(e.ColumnIndex == dgvCols["Idioma"])
                {
                    string sql = "select clavesala from Salas where claveSala " +
                        "in(select claveSala from Funciones where clavePelicula =" +
                        "'" + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["NombrePelicula"]].Value.ToString().Trim() + "' " +
                        " and hora =" +
                        "'" + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Horario"]].Value.ToString().Trim() + "'" +
                        " and claveTipoFuncion = " 
                        + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["TipoFuncion"]].Value.ToString().Trim() + "" +
                        " and claveIdioma = "
                        + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Idioma"]].Value.ToString().Trim() + "" +
                        ")";

                    pdb.Conectar();
                    cmb.DataSource = pdb.SqlSelect(sql).Tables[0].DefaultView;
                    cmb.ValueMember = "claveSala";
                    cmb.DisplayMember = "clavesala";

                    dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Sala"]] = cmb;
                }
                else if (e.ColumnIndex == dgvCols["Sala"])
                {
                    string sql = "select clavefuncion from Funciones where clavePelicula = '" +
                         dgvVentas.Rows[e.RowIndex].Cells[dgvCols["NombrePelicula"]].Value.ToString().Trim()+
                         "' and hora = '"
                        + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Horario"]].Value.ToString().Trim() + "'" +
                        " and claveTipoFuncion = "
                        + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["TipoFuncion"]].Value.ToString().Trim() + "" +
                        " and claveIdioma = "
                        + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Idioma"]].Value.ToString().Trim() + "" +
                        " and claveSala = "
                        + dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Sala"]].Value.ToString().Trim();

                    Console.WriteLine(sql);
                    pdb.Conectar();
                    claveFuncion = int.Parse(pdb.SqlSelect(sql).Tables[0].Rows[0][0].ToString());

                    string[] cantidadAsientos = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                        "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };

                    cmb.Items.AddRange(cantidadAsientos);
                    dgvVentas.Rows[e.RowIndex].Cells[dgvCols["CantidadAsientos"]] = cmb;

                }
                else if (e.ColumnIndex == dgvCols["IdCliente"])
                {
                    if (precioUnitario > 0)
                    {
                        string nombre = "";
                        claveCli = dgvVentas.Rows[e.RowIndex]
                            .Cells[dgvCols["IdCliente"]].Value.ToString().Trim();
                        int claveCliente = int.Parse(claveCli);
                        DataTable dt = new DataTable();

                        pdb.Conectar();

                        string sql = "select puntos-puntosUsados puntos, " +
                            "Nombres + ' ' + paterno + ' ' + materno nombre from Clientes where " +
                            "claveCliente = " + claveCliente;
                        dt = pdb.SqlSelect(sql).Tables[0];
                        if (pdb.SqlSelect(sql).Tables[0].Rows.Count > 0)
                        {
                            puntos = int.Parse(dt.Rows[0][0].ToString());
                            nombre = dt.Rows[0][1].ToString();
                            //MessageBox.Show(puntos + " " + precioUnitario + " " + nombre);
                        }

                        descuento = puntos * precioUnitario;

                        dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Descuento"]].Value =
                            "$" + descuento + ".00";

                        dgvVentas.Rows[e.RowIndex].Cells[dgvCols["NombreCliente"]].Value =
                            nombre;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una funcion para aplicar el descuento");
                        dgvVentas.Rows[e.RowIndex].Cells[dgvCols["IdCliente"]].Value = "";
                        claveCli = "NULL";
                    }
                }
            }
        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ready)
            {
                string sql = "";
                if (e.ColumnIndex == dgvCols["CerrarVenta"])
                {
                    //MessageBox.Show("se ha presionado el boton");
                    float precioBoletos =
                        precioUnitario * 
                        float.Parse(dgvVentas.Rows[e.RowIndex]
                        .Cells[dgvCols["CantidadAsientos"]].Value.ToString());

                    float importeTotal = precioBoletos - descuento;

                    DialogResult d = MessageBox.Show("Confirmar Pago: $" 
                        + importeTotal + ".00"
                        , "Aceptar", MessageBoxButtons.OKCancel);

                    int i = 0;
                    if (d.Equals(DialogResult.OK))
                    {
                        int p = 0;
                        int sumaPuntos = 0;//solo puede ser 0 o 1
                        ProcesosBD pbd = new ProcesosBD();
                        pbd.Conectar();
                        List<long> liClaveBoletos = new List<long>();

                        sql = "select NEXT VALUE FOR SCH_Boletos.AI_Boletos";
                        for (int n = 0; n < liButacas.Count; n++)
                        {
                            liClaveBoletos.Add(long.Parse(pbd.SqlSelect(sql).Tables[0]
                                .Rows[0][0].ToString()));
                        }

                        sql = "select next value for SCH_Ventas.AI_Ventas";

                        int claveVenta = int.Parse(pbd.SqlSelect(sql).Tables[0].Rows[0][0]
                            .ToString());

                        pbd.Conectar();
                        pbd.abrirConexion();
                        pbd.comenzarTransaccion();
                        
                        try
                        {
                            if (!claveCli.Equals("NULL"))
                            {
                                sumaPuntos = 1;//el cliente es válido por lo que la compra suma puntos
                                                //este valor se usa en otro punto del código
                                sql = "update Clientes " +
                                "set puntosUsados = (select puntosUsados " +
                                "from Clientes where claveCliente ="+
                                "" + claveCli + ") + " + puntos + ", " +
                                "puntos = (select puntos from Clientes where claveCliente = " +
                                "" + claveCli + ") + " + p + " " +
                                "where claveCliente = " +
                                "" + claveCli + "";

                                pbd.sqlUpdateTransaction(sql);
                            }

                            sql = "insert into ventas(claveVenta,claveCliente,claveUsuario" +
                                ",horaFechaVenta,importeTotal) values " +
                                "(" + claveVenta + "," +
                                ""+ claveCli +"" +
                                ","+ Program.ClaveUsario +"" +
                                ",CONVERT(datetime, GETDATE(),103)" +
                                "," + importeTotal + ")";

                            pbd.sqlUpdateTransaction(sql);

                            sql = "insert into Boletos(boleto,claveFuncion, asiento,fila" +
                                ",fechaHoraImpresion,claveVenta)" +
                            " values";
                            foreach (KeyValuePair<int, Butaca> butaca in liButacas)
                            {
                                if (i == 0)
                                {
                                    sql += "(" +
                                    ""+ liClaveBoletos[i++] +"," +
                                    "" + claveFuncion + "," +
                                    "" + butaca.Value.Asiento + "," +
                                    "" + butaca.Value.Fila + "," +
                                    "CONVERT(datetime,getdate(),103)" + "," +
                                    "" + claveVenta +")";
                                }
                                else
                                {
                                    sql += ",(" +
                                    "" + liClaveBoletos[i++] + "," +
                                    "" + claveFuncion + "," +
                                    "" + butaca.Value.Asiento + "," +
                                    "" + butaca.Value.Fila + "," +
                                    "CONVERT(datetime,getdate(),103)" + "," +
                                    "" + claveVenta + ")";
                                }
                            }
                            i = 0;
                            pbd.sqlUpdateTransaction(sql);

                            sql = "insert into DetallesVentas(claveVenta,boleto,claveTipoVenta" +
                                ",descuento,iva,precioUnitario,importeParcial" +
                                ",fechaHoraRegistro,sumaPuntos) values";
                            for (int n = 0; n < liButacas.Count; n++)
                            {
                                if (puntos <= 0)
                                    descuento = 0;
                                if (n == 0)
                                {
                                    sql +=
                                    "(" +
                                    "" + claveVenta + 
                                    "," + liClaveBoletos[i++] + 
                                    ",1" +//tipoventa 1 solo para venta de boletos
                                    "," + descuento + "" +
                                    ",0" +
                                    "," + precioUnitario +
                                    "," + (precioUnitario + precioUnitario * iva - descuento) + "" +
                                    ",CONVERT(datetime, GETDATE(),103)" +
                                    ","+ sumaPuntos +")";
                                }
                                else
                                {
                                    sql +=
                                    ",(" +
                                    "" + claveVenta + "" +
                                    "," + liClaveBoletos[i++] + "" +
                                    ",1" +//tipoventa 1 solo para venta de boletos
                                    "," + descuento + "" +
                                    ",0" +
                                    "," + precioUnitario +
                                    "," + (precioUnitario + precioUnitario * iva - descuento) + "" +
                                    ",CONVERT(datetime, GETDATE(),103)" +
                                    "," + sumaPuntos + ")";
                                }

                                puntos--;
                            }

                            pbd.sqlUpdateTransaction(sql);
                            // Attempt to commit the transaction.
                            pbd.Transaction.Commit();
                            
                            Console.WriteLine("Both records are written to database.");
                            MessageBox.Show("Venta registrada");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                            Console.WriteLine("  Message: {0}", ex.Message);
                            MessageBox.Show("Venta no registrada");
                            // Attempt to roll back the transaction.
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
                            pbd.Conexion.Close();
                            if (!claveCli.Equals("NULL"))
                            {
                                sql = "select count(boleto)puntos from DetallesVentas d " +
                                    "where fechaHoraRegistro >= GETDATE()-90  and fechaPuntosUsados is null " +
                                    "and boleto not in (select boleto from Cancelados)  " +
                                    "and d.claveVenta not in (select d.claveVenta  from Cancelados) " +
                                    "and sumaPuntos = 1  and claveVenta in (select claveVenta  " +
                                    "from Ventas where claveCliente = " + claveCli + ")";

                                Console.WriteLine(sql);

                                dt = pbd.SqlSelect(sql).Tables[0];

                                if (dt.Rows.Count > 0)
                                {
                                    if (int.Parse(dt.Rows[0][0].ToString()) >= 5)
                                    {
                                        p = int.Parse(dt.Rows[0][0].ToString()) / 5;

                                        //MessageBox.Show("puntos" + p);

                                        sql = "update DetallesVentas set fechaPuntosUsados=GETDATE() " +
                                            "where claveVenta in(select claveVenta from Ventas where " +
                                            "claveCliente = " + claveCli + ")  " +
                                            "and sumaPuntos = 1 " +//sumaPuntos=1 habilita la suma de los puntos 
                                            "and fechaPuntosUsados is null";

                                        pbd.SqlUpdate(sql);

                                        sql = "update Clientes " +
                                        "set puntos = (select puntos from Clientes where claveCliente = " +
                                        "" + claveCli + ") + " + p + " " +
                                        "where claveCliente = " +
                                        "" + claveCli + "";

                                        pbd.SqlUpdate(sql);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else if (e.ColumnIndex == dgvCols["SeleccionAsientos"])
                {
                    if(dgvVentas.Rows[e.RowIndex].Cells[dgvCols["Sala"]].Value != null)
                    {
                        sql = "select capacidad from TipoSala t,Salas s,Funciones f " +
                            " where f.claveSala = s.claveSala and s.claveTipoSala = t.claveTipoSala" +
                            " and claveFuncion ="
                        + claveFuncion;

                        Console.WriteLine("consulta para capacidad:"+sql);

                        int capacidad = int.Parse(pdb.SqlSelect(sql).Tables[0].Rows[0][0]
                            .ToString());
                        Console.WriteLine("capacidad:"+capacidad);

                        sql = "select fila,asiento from Boletos where claveFuncion = "
                            + claveFuncion + " order by 1,2 asc";

                        Console.WriteLine("consulta para boletos: " + sql);

                        ds = pdb.SqlSelect(sql);
                        dt = ds.Tables[0];
                        Sala sala = null;
                        if (capacidad == 20)
                        {
                            sala = new SalaTipo2();
                        }else if (capacidad == 50)
                        {
                            sala = new SalaTipo1();
                        }

                        sala.ObtenerAcomodamiento(dt,capacidad);
                        Console.Write(sala);
                        sala.imprimirAcomodamiento();

                        int cantAsientosPorVender = 
                            int.Parse(dgvVentas.Rows[e.RowIndex].Cells[dgvCols["CantidadAsientos"]].Value.ToString());

                        int row = e.RowIndex;

                        FrmVentasLugares frmVentasLugares = 
                            new FrmVentasLugares(this, cantAsientosPorVender, sala, row);
                        frmVentasLugares.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Debe elegir la cantidad de boletos");
                    }
                }
            }
        }

        #region ISeleccionados
        public void asientosSeleccionados(Dictionary<int, Butaca> liButacas)
        {
               
        }
        #endregion

        public void getAsientos(Dictionary<int, Butaca> liButacas, int row)
        {
            ProcesosBD pbd = new ProcesosBD();
            string butacasMostradas = "";
            string butacasInsertQuery = "";
            this.liButacas = liButacas;
            int i = 0;
            foreach(KeyValuePair<int,Butaca> butaca in liButacas)
            {
                if (i == 0)
                {
                    butacasMostradas += butaca.Value.FilaLetra + butaca.Value.Asiento;
                    butacasInsertQuery += butaca.Value.Fila + "," + butaca.Value.Asiento;
                }
                else
                {
                    butacasMostradas += ", " + butaca.Value.FilaLetra + butaca.Value.Asiento;
                    butacasInsertQuery += "|" + butaca.Value.Fila + "," + butaca.Value.Asiento;
                }
                i++;
            }
            dgvVentas.Rows[row].Cells[dgvCols["AsientosSeleccionados"]].Value = butacasMostradas;

            pbd.Conectar();
            
            string sql = "select precio from TipoFuncion where claveTipoFuncion=" 
                + dgvVentas.Rows[row].Cells[dgvCols["TipoFuncion"]].Value.ToString();

            string precio = pbd.SqlSelect(sql).Tables[0].Rows[0][0].ToString();
            //MessageBox.Show(precio);

            precioUnitario = float.Parse(pbd.SqlSelect(sql).Tables[0]
                .Rows[0][0].ToString());

            dgvVentas.Rows[row].Cells[dgvCols["PrecioUnitario"]].Value = "$" + precioUnitario + ".00";
        }

        private void dgvVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
