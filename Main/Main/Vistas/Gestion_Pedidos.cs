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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Pedidos p = new Pedidos(cone);
            p.btnNuevo();
            p.ShowDialog();
            ListarPedido();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvPedidos.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Pedidos p = new Pedidos(cone);
            p.DrPedidis = drow;
            p.btnesEliminar();
            p.ShowDialog();
            ListarPedido();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection rowCollection = dgvPedidos.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Pedidos p = new Pedidos(cone);
            p.DrPedidis = drow;
            p.btnesEditar();
            p.ShowDialog();
            ListarPedido();
        }

        private void btnNuevoDetalle_Click(object sender, EventArgs e)
        {
            Detalle_Pedidos dp = new Detalle_Pedidos(cone);
            dp.btnNuevoD();
            dp.ShowDialog();
            ListarDetallePedido();

        }

        private void btnElimDetalle_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvDetalle.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;


            Detalle_Pedidos dp = new Detalle_Pedidos(cone);
            dp.DrDetallePedido = drow;
            dp.btnEliminarDP();
            dp.ShowDialog();
            ListarDetallePedido();
        }

        private void btnEditarDetalle_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection rowCollection = dgvDetalle.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;


            Detalle_Pedidos dp = new Detalle_Pedidos(cone);
            dp.DrDetallePedido = drow;
            dp.btnEditarDP();
            dp.ShowDialog();
            ListarDetallePedido();
        }
    }
}
