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
    public partial class ReporteDetallePedidos : Form
    {
        public ReporteDetallePedidos()
        {
            InitializeComponent();
        }

        private void ReporteDetallePedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.ListaDetallePedidos' Puede moverla o quitarla según sea necesario.
            this.ListaDetallePedidosTableAdapter.Fill(this.DataSet.ListaDetallePedidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
