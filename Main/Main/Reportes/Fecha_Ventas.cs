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
    public partial class Fecha_Ventas : Form
    {
        public Fecha_Ventas()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Parse("02/05/2000");
            dateTimePicker2.Value = DateTime.Now;
        }

        private void Fecha_Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Fechas.Rango_Fecha_Venta' Puede moverla o quitarla según sea necesario.
            this.Rango_Fecha_VentaTableAdapter.Fill(this.Fechas.Rango_Fecha_Venta,dateTimePicker1.Value,DateTime.Now.Date);

            this.reportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Rango_Fecha_VentaTableAdapter.Fill(this.Fechas.Rango_Fecha_Venta, dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
