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
    public partial class Compras : Form
    {

        private Conexion cone;
        public Compras()
        {
            InitializeComponent();
        }
        public Compras(Conexion con)
        {
            this.cone = con;
            InitializeComponent();
            ListarCompras(cone);
        }



        private void ListarCompras(Conexion cone)
        {
            cone.Listados(dgvCompras, "ListarCompra");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
