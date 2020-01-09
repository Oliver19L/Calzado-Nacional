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
    public partial class Pedidos : Form
    {
        private Conexion cone;
        public Pedidos(Conexion cone)
        {
            this.cone = cone;
            InitializeComponent();
            ListarPedido(cone);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void ListarPedido(Conexion cone)
        {
            cone.Listados(dgvPedidos,"ListarPedidos");
        }
    }
}
