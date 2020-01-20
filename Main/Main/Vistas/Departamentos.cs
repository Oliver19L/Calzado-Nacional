using Main.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main.Vistas
{
    public partial class Departamentos : Form
    {

        private Conexion con;
        public Departamentos()
        {
            InitializeComponent();
        }
        public Departamentos(Conexion con)
        {
            this.con = con;
            InitializeComponent();
            ListarDepartamento();
        }

        public SqlParameter[] AgregarDepartamento()
        {

            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = textBox2.Text;
           

            return param;
        }
        public void ListarDepartamento()
        {
            con.Listados(dataGridView1,"ListarDepartamento");
        }
    }
}
