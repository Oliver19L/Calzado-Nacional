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
    public partial class Gestion_Compras : Form
    {

        private Conexion cone;
        public Gestion_Compras()
        {
            InitializeComponent();
        }
        public Gestion_Compras(Conexion con)
        {
            this.cone = con;
            InitializeComponent();
            ListarCompras();
            ListardetallesCompra();
        }



        private void ListarCompras()
        {
            cone.Listados(dgvCompras, "ListarCompra");
            
        }

        public void ListardetallesCompra()
        {
            cone.Listados(dgvDetalleCompra, "ListaDetalleCompra");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleCompras detalleCompras = new DetalleCompras(cone);
            detalleCompras.btnNuevaDC();
            detalleCompras.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras(cone);
            compras.btnNuevaC();
            compras.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras(cone);
            compras.btnEditarC();
            compras.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras(cone);
            compras.btnEliminarC();
            compras.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetalleCompras detalle = new DetalleCompras(cone);
            detalle.btnEditarDC();
            detalle.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleCompras detalle = new DetalleCompras(cone);
            detalle.btnEliminarDC();
            detalle.ShowDialog();
        }
    }
}
