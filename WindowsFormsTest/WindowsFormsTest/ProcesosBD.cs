using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WindowsFormsTest
{
    class ProcesosBD
    {
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet ds;
        private SqlTransaction transaction;

        public SqlConnection Conexion { get => conexion; set => conexion = value; }
        public SqlTransaction Transaction { get => transaction; set => transaction = value; }

        public void Conectar()
        {
            try
            {
                //conexion = new SqlConnection("Data Source=(local); Initial Catalog=DB_CinePremier; Integrated Security=SSPI");
                Conexion = new SqlConnection("Data Source=(local); Initial Catalog=DB_CinePremier; User Id=sa; Password=lara");
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos: " + e.ToString());
            }
        }

        public void abrirConexion()
        {
            Conexion.Open();
        }

        public void comenzarTransaccion()
        {
            Transaction = Conexion.BeginTransaction("SampleTransaction");
        }

        public void sqlUpdateTransaction(string sql)
        {
            comando = Conexion.CreateCommand();
            try
            {
                Console.WriteLine(sql);
                //Conexion.Open();
                comando.Connection = Conexion;
                comando.Transaction = Transaction; 
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                comando.Transaction.Rollback();
                MessageBox.Show("No se pudo realizar la inserción en la base de datos." +
                    " Inténtelo de nuevo");
                Console.WriteLine(error.Message);
            }
        }

        public void SqlUpdate(string sql)
        {
            comando = new SqlCommand();
            try
            {
                Console.WriteLine(sql);
                Conexion.Open();
                comando.Connection = Conexion;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                Conexion.Close();
            }
        }

        public DataSet SqlSelect(string sql)
        {
            ds = new DataSet();
            adaptador = new SqlDataAdapter();
            comando = new SqlCommand();
            try
            {
                Conexion.Open();
                comando.CommandText = sql;
                adaptador.SelectCommand = comando;
                adaptador.SelectCommand.Connection = Conexion;
                adaptador.Fill(ds);
            }
            catch (System.Data.SqlClient.SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            Conexion.Close();
            return ds;
        }
    }
}
