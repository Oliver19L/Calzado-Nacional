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
    public class Conexion
    {
        public SqlConnection connect = new SqlConnection();

       
            

        public Conexion()
        {
           
        }
        public Conexion(String user, String Pass)
        {
            try
            {
                

                connect = new SqlConnection("Server=OLIVERPC;Database=CalzadoNacionalPro;UID=" + user + ";PWD=" + Pass);
                                            
                connect.Open();


            }
            catch (Exception)
            {
                
            }
        }

       

        public void Listados(DataGridView GridView1, String Procedimiento)
        {
            SqlCommand cmdu = new SqlCommand();

            try
            {
                cmdu.CommandType = CommandType.StoredProcedure;
                cmdu.CommandText = Procedimiento;
                cmdu.Connection = connect;



                SqlDataAdapter daad = new SqlDataAdapter(cmdu);


                DataTable dt = new DataTable();
                daad.Fill(dt);

                GridView1.DataSource = dt;
            }
            catch (Exception ex)
           {
                 MessageBox.Show("Error Al Listar Los datos  " + ex.Message);
           }
           


        }

       // public void InsertarTrabajador(String Pnombre, String Snombre, String Papellido, String Sapellido, String Email, String tel, String celular, String Dire, int Id_Muni)
       public void Insertados(SqlParameter[] param,string proce)
        {

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = connect,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = proce
                };
                cmd.Parameters.AddRange(param);
               

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la insercion     " + ex.Message);
                return;
            }
        }


        public void editados(SqlParameter[] param, String proce)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();



                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = proce;
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);
                
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en el Editado     " + ex.Message);
                return;
            }




        }
        public void eliminar(int id, String Procedimiento, String Campo)
        {

            
          
            SqlCommand cmd = new SqlCommand();

           
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter(Campo, SqlDbType.Int);
                param[0].Value = id;
  

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Procedimiento;
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);
        }

        public void eliminarChar(String id, String Procedimiento, String Campo)
        {



            SqlCommand cmdi = new SqlCommand();
           

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter(Campo, SqlDbType.Char);
            param[0].Value = id;

            
            cmdi.CommandType = CommandType.StoredProcedure;
            cmdi.CommandText = Procedimiento;
            cmdi.Connection = connect;
            cmdi.Parameters.AddRange(param);
          
           


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmdi);

            da.Fill(ds);
        }

        public int Autentificacion(String Access,String Nombre)
        {
            int result=0;
            SqlCommand cmd = new SqlCommand();
           

          


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select IS_SRVROLEMEMBER ('"+Access+"','"+ Nombre+"')";
            cmd.Connection = connect;
            SqlDataReader leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                result = leer.GetInt32(0);
            }

            leer.Close();

           
            return result;
        }
      
    }
}
