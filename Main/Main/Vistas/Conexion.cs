using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main.DAO
{
     public  class Conexion
    {
        public SqlConnection connect = new SqlConnection();

        public Conexion(String user , String Pass)
        {
            try
            {
                connect = new SqlConnection("Server=OLIVERPC;Database=Cifrado;UID=" +user+";PWD="+Pass);
                connect.Open();
                
              
                
            }
            catch (Exception)
            {

            }
        }

        //public int Autentificacion(String Login , String Pass)
        //{
        //    int result;


        //    SqlCommand cmd = new SqlCommand("Select Is_Srvrolemember(" + "'sysadmin'" + "," + Login + ")", connect);
        //    cmd.CommandType = CommandType.Text;

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    result = Convert.ToInt32(dr.Read());

        //    return result;
        //}
        public void Listar(DataGridView GridView1)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "NuevoUsuario";
            cmd.Connection = connect;

            leer = cmd.ExecuteReader();

            while (leer.Read()) { 
            //GridView1.CurrentRow.CreateCells(0) = leer.GetString(0);

             }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
           
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            GridView1.DataSource = dt;
        }
    }
}
