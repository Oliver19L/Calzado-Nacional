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
    public partial class Gestion_Proveedores : Form
    {
        private Conexion con;
        public Gestion_Proveedores(Conexion con)
        {
            this.con = con;
            InitializeComponent();
            ListarProveedor();
          
        }

        public void ListarProveedor()
        {
            con.Listados(dgvProveedores, "ListaProveedor");
            
        }
       
        private void Gestion_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
