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

namespace Main.Vistas
{
    public partial class Inventario : Form
    {

        private Conexion con;
        public Inventario()
        {
            InitializeComponent();
        }

        public Inventario(Conexion Con)
        {
            this.con = Con;
            InitializeComponent();
            ListarInventario(Con,"ListarInventario");
        }


        public void ListarInventario(Conexion Con,String Procedimiento)
        {
            Con.ListarEmpleados(dataGridView1, Procedimiento);
        }
    }
}
