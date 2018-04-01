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
        private SqlDataReader lector;
        private SqlDataAdapter adaptador;
        private DataSet ds;

        public void Conectar()
        {
            try
            {
                //conexion = new SqlConnection("Data Source=(local); Initial Catalog=DB_CinePremier; Integrated Security=SSPI");
                conexion = new SqlConnection("Data Source=(local); Initial Catalog=DB_CinePremier; User Id=sa; Password=lara");
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos: " + e.ToString());
            }
        }

        public void SqlUpdate(string sql)
        {
            comando = new SqlCommand();
            try
            {
                Console.WriteLine(sql);
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public DataSet SqlSelect(string sql)
        {
            ds = new DataSet();
            adaptador = new SqlDataAdapter();
            comando = new SqlCommand();
            try
            {
                conexion.Open();
                comando.CommandText = sql;
                adaptador.SelectCommand = comando;
                adaptador.SelectCommand.Connection = conexion;
                adaptador.Fill(ds);
            }
            catch (System.Data.SqlClient.SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            conexion.Close();
            return ds;
        }
    }
}
