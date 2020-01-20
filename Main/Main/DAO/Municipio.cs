using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Vistas;

namespace Main.DAO
{
    class Municipio
    {

        public String id_Municipio;
        public Conexion con;
        public Municipio(String id,Conexion con)
        {
            this.con = con;
            this.id_Municipio = id;
         
        }




      //  protected void  Id_Municipio(String id)  set => id_Municipio = value; 
    }
}
