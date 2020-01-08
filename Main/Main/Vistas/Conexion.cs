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
                connect = new SqlConnection("Server=OLIVERPC;Database=CalzadoNacionalPro;UID=" +user+";PWD="+Pass);
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
        public void ListarEmpleados(DataGridView GridView1,String Procedimiento)
        {
            SqlCommand cmd = new SqlCommand();
            

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Procedimiento;
            cmd.Connection = connect;

           
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
           
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            GridView1.DataSource = dt;
        }

        public void InsertarTrabajador(String Pnombre, String Snombre, String Papellido, String Sapellido, String Email, String tel, String celular, String Dire,int Id_Muni)
        {

           
            

            
        try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[9];
                param[0] = new SqlParameter("@PrimNombre", SqlDbType.NVarChar);
                param[0].Value = Pnombre;
                param[1] = new SqlParameter("@SegundNombre", SqlDbType.NVarChar);
                param[1].Value = Snombre;
                param[2] = new SqlParameter("@PrimApellid", SqlDbType.NVarChar);
                param[2].Value = Papellido;
                param[3] = new SqlParameter("@SegundApellid", SqlDbType.NVarChar);
                param[3].Value = Sapellido;
                param[4] = new SqlParameter("@Email", SqlDbType.NVarChar);
                param[4].Value = Email;
                param[5] = new SqlParameter("@Telefono", SqlDbType.Char);
                param[5].Value = tel;
                param[6] = new SqlParameter("@Celular", SqlDbType.Char);
                param[6].Value = celular;
                param[7] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
                param[7].Value = Dire;
                param[8] = new SqlParameter("@IdMunic", SqlDbType.Int);
                param[8].Value = Id_Muni;

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
        
        public void insertarClientes()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[4];

                //param[0] = new SqlParameter("@PrimNombre", SqlDbType.VarChar);
                //param[0].Value = Pnombre;
                //param[1] = new SqlParameter("@SegundNombre", SqlDbType.VarChar);
                //param[1].Value = Snombre;
                //param[2] = new SqlParameter("@PrimApellid", SqlDbType.VarChar);
                //param[2].Value = Papellido;
                //param[3] = new SqlParameter("@SegundApellid", SqlDbType.VarChar);
                //param[3].Value = Sapellido;
                //param[4] = new SqlParameter("@Email", SqlDbType.VarChar);
                //param[4].Value = Email;
                //param[5] = new SqlParameter("@Telefono", SqlDbType.Char);
                //param[5].Value = tel;
                //param[6] = new SqlParameter("@Celular", SqlDbType.Char);
                //param[6].Value = celular;
                //param[7] = new SqlParameter("@Direccion", SqlDbType.VarChar);
                //param[7].Value = Dire;
                //param[8] = new SqlParameter("@IdMunic", SqlDbType.Int);
                //param[8].Value = munic;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NuevoEmpleado";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);


                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);


            }
            catch (Exception )
            {
                
            }
        }

        public void editarCliente(DataGridView GridView1, String Pnombre, String Snombre, String Papellido, String Sapellido, String Email, String tel, String celular, String Dire, int Id_Muni)
        {

            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@PrimNombre", SqlDbType.NVarChar);
            param[0].Value = Pnombre;
            param[1] = new SqlParameter("@SegundNombre", SqlDbType.NVarChar);
            param[1].Value = Snombre;
            param[2] = new SqlParameter("@PrimApellid", SqlDbType.NVarChar);
            param[2].Value = Papellido;
            param[3] = new SqlParameter("@SegundApellid", SqlDbType.NVarChar);
            param[3].Value = Sapellido;
            param[4] = new SqlParameter("@Email", SqlDbType.NVarChar);
            param[4].Value = Email;
            param[5] = new SqlParameter("@Telefono", SqlDbType.Char);
            param[5].Value = tel;
            param[6] = new SqlParameter("@Celular", SqlDbType.Char);
            param[6].Value = celular;
            param[7] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
            param[7].Value = Dire;
            param[8] = new SqlParameter("@IdMunic", SqlDbType.Int);
            param[8].Value = Id_Muni;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EditarEmpleado";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }


        public void eliminarCliente(int id,String Procedimiento,String Campo)
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
