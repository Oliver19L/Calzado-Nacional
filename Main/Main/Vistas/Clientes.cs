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
    public partial class Clientes : Form {



       

        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes(Conexion con)

        {
           
            InitializeComponent();
            this.ListaC(con,"ListarClientes");

        }

        public void ListaC(Conexion con, String Proce)
        {
            con.Listados(dgvClientes, Proce);

        }
   
    }
}
