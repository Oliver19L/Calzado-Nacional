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
using Main.Reportes;

namespace Main.Vistas
{
    public partial class Gestion_Pedidos : Form
    {
        private Conexion cone;
        public Gestion_Pedidos(Conexion cone)
        {
            this.cone = cone;
            InitializeComponent();
            ListarPedido();
            ListarDetallePedido();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void ListarPedido()
        {
            cone.Listados(dgvPedidos,"ListarPedidos");
        }

        private void ListarDetallePedido()
        {
            cone.Listados(dgvDetalle,"ListaDetallePedidos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteDetallePedidos rdp = new ReporteDetallePedidos();
            rdp.ShowDialog();
        }
    }
}
