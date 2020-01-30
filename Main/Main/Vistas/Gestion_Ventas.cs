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
    public partial class Gestion_Ventas : Form
    {

        private Conexion cone;

        public Gestion_Ventas()
        {
            InitializeComponent();
        }

        public Gestion_Ventas(Conexion cone)
        {
            this.cone = cone;
            InitializeComponent();
            ListaVenta();
            ListaDVenta();
        }

        public void ListaVenta()
        {
            cone.Listados(dgvInventario,"ListarVenta");

        }

        public void ListaDVenta()
        {
            cone.Listados(dgvDetalleVenta,"ListaDetalleVenta");
        }

        private void Gestion_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(cone);
            venta.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(cone);
            venta.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            Venta venta = new Venta(cone);
            venta.ShowDialog();
        }
    }
}
