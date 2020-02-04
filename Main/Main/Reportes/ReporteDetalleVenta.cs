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
    public partial class ReporteDetalleVenta : Form
    {
        public ReporteDetalleVenta()
        {
            InitializeComponent();
        }

        private void ReporteDetalleVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.ListaDetalleVenta' Puede moverla o quitarla según sea necesario.
            this.ListaDetalleVentaTableAdapter.Fill(this.DataSet.ListaDetalleVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
