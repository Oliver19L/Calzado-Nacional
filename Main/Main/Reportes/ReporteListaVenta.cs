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
    public partial class ReporteListaVenta : Form
    {
        public ReporteListaVenta()
        {
            InitializeComponent();
        }

        private void ReporteListaVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.ListarVenta' Puede moverla o quitarla según sea necesario.
            this.ListarVentaTableAdapter.Fill(this.DataSet.ListarVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
