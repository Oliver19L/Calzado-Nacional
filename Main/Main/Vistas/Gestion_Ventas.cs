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
using System.Data.SqlClient;

namespace Main.Vistas
{
    public partial class Gestion_Ventas : Form
    {

        private Conexion cone;

        public Gestion_Ventas()
        {
            InitializeComponent();
        }

        public Gestion_Ventas(Conexion cone)
        {
            this.cone = cone;
            InitializeComponent();
            ListaVenta();
            ListaDVenta();
        }

        public void ListaVenta()
        {
            cone.Listados(dgvVenta,"ListarVenta");


        }

        public void ListaDVenta()
        {
            cone.Listados(dgvDetalleVenta,"ListaDetalleVenta");
        }

        private void Gestion_Ventas_Load(object sender, EventArgs e)
        {
            string[] cmb = { "ID Detalle Venta", "ID Venta", "Codigo", "Producto", "Descripcion", "Cantidad", "PrecioSubtotal" };
            comboBox2.DataSource = cmb;

            string[] cmb1 = { "Id_Venta", "Id_Cliente", "Fecha" };
            comboBox1.DataSource = cmb1;
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(cone);
            venta.btnNuevaV();
            venta.ShowDialog();
            ListaVenta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvVenta.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder Editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Venta venta = new Venta(cone);
            venta.DrVenta = drow;
            venta.btnEditarV();
            venta.ShowDialog();
            ListaVenta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvVenta.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder Eliminar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Venta venta = new Venta(cone);
            venta.DrVenta = drow;
            venta.btnEliminarV();
            venta.ShowDialog();
            ListaVenta();
            ListaDVenta();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(dgvVenta);
        }

        public void ExportarDatosExcel(DataGridView dataGrid)
        {
            Microsoft.Office.Interop.Excel.Application exportarE = new Microsoft.Office.Interop.Excel.Application();

            exportarE.Application.Workbooks.Add(true);

            int indicecolumna = 0;

            foreach (DataGridViewColumn columna in dataGrid.Columns)
            {
                indicecolumna++;
                exportarE.Cells[1, indicecolumna] = columna.Name;
            }

            int indiceFila = 0;

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                indiceFila++;
                indicecolumna = 0;
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    indicecolumna++;
                    exportarE.Cells[indiceFila + 1, indicecolumna] = row.Cells[column.Name].Value;
                }
            }

            exportarE.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(dgvDetalleVenta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteListaVenta reporteListaVenta = new ReporteListaVenta();
            reporteListaVenta.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporteDetalleVenta reporteDetalleVenta = new ReporteDetalleVenta();
            reporteDetalleVenta.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                ListaVenta();
            }
            else
            {
                int result = comboBox1.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("Id_Venta", dgvVenta);

                        break;
                    case 1:
                        BusquedaSQL("Id_Cliente", dgvVenta);
                        break;
                    case 2:
                        BusquedaSQL("Fecha", dgvVenta);
                        break;

                }
            }
                
        }

        public void BusquedaSQL(String Texto,DataGridView dataGrid)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@txtBuscar", SqlDbType.NVarChar);
            param[0].Value = textBox1.Text;
            param[1] = new SqlParameter("@Tipo", SqlDbType.VarChar);
            param[1].Value = Texto;

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "BuscarEmpleado";
            comando.Connection = cone.connect;
            comando.Parameters.AddRange(param);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);

            dataGrid.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                ListaDVenta();
            }
            else
            {
                int result = comboBox2.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("Id_DetalleV",dgvDetalleVenta);

                        break;
                    case 1:
                        BusquedaSQL("Id_Venta", dgvDetalleVenta);
                        break;
                    case 2:
                        BusquedaSQL("Cod_Prod", dgvDetalleVenta);
                        break;
                    case 3:

                        BusquedaSQL("Descripcion", dgvDetalleVenta);
                        break;
                    case 4:
                        BusquedaSQL("Cantidad", dgvDetalleVenta);
                        break;
                    case 5:
                        BusquedaSQL("Precio", dgvDetalleVenta);
                        break;
                    case 6:
                        BusquedaSQL("SubTotal", dgvDetalleVenta);
                        break;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                ListaVenta();
            }
            else
            {
                int result = comboBox1.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("Id_Venta",dgvVenta);

                        break;
                    case 1:
                        BusquedaSQL("Id_Cliente", dgvVenta);
                        break;
                    case 2:
                        BusquedaSQL("Fecha", dgvVenta);
                        break;

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                ListaDVenta();
            }
            else
            {
                int result = comboBox2.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("Id_DetalleV",dgvDetalleVenta);

                        break;
                    case 1:
                        BusquedaSQL("Id_Venta", dgvDetalleVenta);
                        break;
                    case 2:
                        BusquedaSQL("Cod_Prod", dgvDetalleVenta);
                        break;
                    case 3:

                        BusquedaSQL("Descripcion", dgvDetalleVenta);
                        break;
                    case 4:
                        BusquedaSQL("Cantidad", dgvDetalleVenta);
                        break;
                    case 5:
                        BusquedaSQL("Precio", dgvDetalleVenta);
                        break;
                    case 6:
                        BusquedaSQL("SubTotal", dgvDetalleVenta);
                        break;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Detalle_Venta venta = new Detalle_Venta(cone);
            venta.btnNuevoD();
            venta.ShowDialog();
            ListaDVenta();
            ListaVenta();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvVenta.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para Generar el  Reporte", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            ReporteDetalleVentaCliente ventaCliente = new ReporteDetalleVentaCliente();
            ventaCliente.ID1 = int.Parse(drow["Id_Venta"].ToString());
            ventaCliente.ShowDialog();   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvDetalleVenta.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder Eliminar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Detalle_Venta venta = new Detalle_Venta(cone);
            venta.DrDetalleVenta = drow;
            venta.btnEliminarDP();
            venta.ShowDialog();
            ListaDVenta();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvDetalleVenta.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder Editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;


            Detalle_Venta venta = new Detalle_Venta(cone);
            venta.DrDetalleVenta = drow;
            venta.btnEditarDP();
            venta.ShowDialog();
            ListaDVenta();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Fecha_Ventas fecha = new Fecha_Ventas();
            fecha.Show();
        }
    }
}
