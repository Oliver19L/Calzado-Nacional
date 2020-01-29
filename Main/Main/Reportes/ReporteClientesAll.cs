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
    public partial class ReporteClientesAll : Form
    {
        public ReporteClientesAll()
        {
            InitializeComponent();
        }

        private void ReporteClientesAll_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.ListarClientes' Puede moverla o quitarla según sea necesario.
            this.ListarClientesTableAdapter.Fill(this.DataSet.ListarClientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
