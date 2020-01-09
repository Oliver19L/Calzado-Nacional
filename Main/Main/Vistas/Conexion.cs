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

        public void ListarEmpleados(DataGridView GridView1, String Procedimiento)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Procedimiento;
                cmd.Connection = connect;



                SqlDataAdapter da = new SqlDataAdapter(cmd);


                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
            }
            catch (Exception)
            {

            }
           


        }

       // public void InsertarTrabajador(String Pnombre, String Snombre, String Papellido, String Sapellido, String Email, String tel, String celular, String Dire, int Id_Muni)
       public void InsertarTrabajador(SqlParameter[] param)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NuevoEmpleado";

               

               

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


        public void editarEmpleado(int Id,String Email, String tel, String celular, String Dire, int Id_Muni)
        {

            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[6];
            

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            param[1] = new SqlParameter("@Email", SqlDbType.NVarChar);
            param[1].Value = Email;
            param[2] = new SqlParameter("@Telefono", SqlDbType.Char);
            param[2].Value = tel;
            param[3] = new SqlParameter("@Celular", SqlDbType.Char);
            param[3].Value = celular;
            param[4] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
            param[4].Value = Dire;
            param[5] = new SqlParameter("@IdMunic", SqlDbType.Int);
            param[5].Value = Id_Muni;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ActualizacionEmpleados";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }
        public void eliminarCliente(int id, String Procedimiento, String Campo)
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



    }
}
