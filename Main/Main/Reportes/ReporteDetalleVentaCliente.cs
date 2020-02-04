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
    public partial class ReporteDetalleVentaCliente : Form
    {
        public ReporteDetalleVentaCliente()
        {
            InitializeComponent();
        }
        private int ID;

        public int ID1 { get => ID; set => ID = value; }

        private void ReporteDetalleVentaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetDetalleClientePedido.DetalleVentaCliente' Puede moverla o quitarla según sea necesario.
            this.DetalleVentaClienteTableAdapter.Fill(this.DataSetDetalleClientePedido.DetalleVentaCliente,ID);

            this.reportViewer1.RefreshReport();
        }
    }
}
