using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Main.DAO
{
    class Conexion
    {
        protected SqlConnection connect = new SqlConnection();

        public Conectar(String user , String Pass)
        {
            try
            {
                connect = new SqlConnection("Server=OLIVERPC\\SQLSERVER2019;Database=Cifrado;UID=" +user+";PWD="+Pass);
                connect.Open();
            }
            catch (Exception)
            {

            }
        }
        

        public void Listar(DataGridView GridView1)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarUsuarios";
            cmd.Connection = connect;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
        }
    }
}
