using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Reportes
{
    public partial class ReporteClienteDetallePedido : Form
    {
        public ReporteClienteDetallePedido()
        {
            InitializeComponent();
        }

        int ide;

        public int Ide { get => ide; set => ide = value; }

        private void ReporteClienteDetallePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.ListaDetallePedidos' Puede moverla o quitarla según sea necesario.
          //  this.ListaDetallePedidosTableAdapter.Fill(this.DataSet2.ListaDetallePedidos);
            // TODO: esta línea de código carga datos en la tabla 'DataSetDetalleClientePedido.DetallePedidoCliente' Puede moverla o quitarla según sea necesario.
            this.DetallePedidoClienteTableAdapter.Fill(this.DataSetDetalleClientePedido.DetallePedidoCliente,ide);

            this.reportViewer1.RefreshReport();
        }
    }
}
