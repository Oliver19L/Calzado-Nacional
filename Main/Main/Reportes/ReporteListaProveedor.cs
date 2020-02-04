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
    public partial class ReporteListaProveedor : Form
    {
        public ReporteListaProveedor()
        {
            InitializeComponent();
        }

        private void ReporteListaProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.ListarInventarioProveedor' Puede moverla o quitarla según sea necesario.
            this.ListarInventarioProveedorTableAdapter.Fill(this.DataSet.ListarInventarioProveedor);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
