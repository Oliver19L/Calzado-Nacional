using Main.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Vistas
{
    public partial class Gestion_Compras : Form
    {

        private Conexion cone;
        public Gestion_Compras()
        {
            InitializeComponent();
        }
        public Gestion_Compras(Conexion con)
        {
            this.cone = con;
            InitializeComponent();
            ListarCompras();
            ListardetallesCompra();
        }



        private void ListarCompras()
        {
            cone.Listados(dgvCompras, "ListarCompra");
            
        }

        public void ListardetallesCompra()
        {
            cone.Listados(dgvDetalleCompra, "ListaDetalleCompra");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleCompras detalleCompras = new DetalleCompras(cone);
            detalleCompras.btnNuevaDC();
            detalleCompras.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras(cone);
            compras.btnNuevaC();
            compras.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras(cone);
            compras.btnEditarC();
            compras.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras(cone);
            compras.btnEliminarC();
            compras.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetalleCompras detalle = new DetalleCompras(cone);
            detalle.btnEditarDC();
            detalle.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleCompras detalle = new DetalleCompras(cone);
            detalle.btnEliminarDC();
            detalle.ShowDialog();
        }

        private void Gestion_Compras_Load(object sender, EventArgs e)
        {
            String[] combo = { "N_Compra","Id_Proveedor","Fecha","Total" };
            cmbCompra.DataSource = combo;

            String[] comboDC = {"ID","N_Compra","Codigo_Producto","Concepto","Cantidad_Compra","Precio_Compra","Sub_Total"};
            cmbDetalleCompra.DataSource = comboDC;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                ListarCompras();
            }
            else
            {
                int result = cmbCompra.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("N_Compra", dgvCompras , "BuscaCompra");

                        break;
                    case 1:
                        BusquedaSQL("Id_Proveedor", dgvCompras, "BuscaCompra");
                        break;
                    case 2:
                        BusquedaSQL("Fecha", dgvCompras, "BuscaCompra");
                        break;
                    case 3:
                        BusquedaSQL("Total", dgvCompras, "BuscaCompra");
                        break;

                }
            }
        }


        public void BusquedaSQL(String Texto, DataGridView dataGrid,String proc)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@txtBuscar", SqlDbType.NVarChar);
            param[0].Value = textBox1.Text;
            param[1] = new SqlParameter("@Tipo", SqlDbType.VarChar);
            param[1].Value = Texto;

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = proc;
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
                ListardetallesCompra();
            }
            else
            {
                int result = cmbDetalleCompra.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("ID", dgvDetalleCompra,"BuscaDetalleCompra");

                        break;
                    case 1:
                        BusquedaSQL("N_Compra", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                    case 2:
                        BusquedaSQL("Codigo_Producto", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                    case 3:
                        BusquedaSQL("Concepto", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                    case 4:
                        BusquedaSQL("Cantidad_Compra", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                    case 5:
                        BusquedaSQL("Precio_Compra", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                    case 6:
                        BusquedaSQL("Sub_Total", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                        

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                ListardetallesCompra();
            }
            else
            {
                int result = cmbDetalleCompra.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("ID", dgvDetalleCompra, "BuscaDetalleCompra");

                        break;
                    case 1:
                        BusquedaSQL("N_Compra", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                    case 2:
                        BusquedaSQL("Codigo_Producto", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                    case 3:
                        BusquedaSQL("Concepto", dgvDetalleCompra, "BuscaDetalleCompra");
                        
                        break;
                    case 4:
                        BusquedaSQL("Cantidad_Compra", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                    case 5:
                        BusquedaSQL("Precio_Compra", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;
                    case 6:
                        BusquedaSQL("Sub_Total", dgvDetalleCompra, "BuscaDetalleCompra");
                        break;


                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                ListarCompras();
            }
            else
            {
                int result = cmbCompra.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("N_Compra", dgvCompras, "BuscaCompra");

                        break;
                    case 1:
                        BusquedaSQL("Id_Proveedor", dgvCompras, "BuscaCompra");
                        break;
                    case 2:
                        BusquedaSQL("Fecha", dgvCompras, "BuscaCompra");
                        break;
                    case 3:
                        BusquedaSQL("Total", dgvCompras, "BuscaCompra");
                        break;
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(dgvCompras);
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
            ExportarDatosExcel(dgvDetalleCompra);
        }
    }
}
