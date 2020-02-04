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
    public partial class ReporteListaProveedores : Form
    {
        public ReporteListaProveedores()
        {
            InitializeComponent();
        }

        private void ReporteListaProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.ListaProveedor' Puede moverla o quitarla según sea necesario.
            this.ListaProveedorTableAdapter.Fill(this.DataSet.ListaProveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
