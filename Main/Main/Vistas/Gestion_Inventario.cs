using Main.DAO;
using Main.Reportes;
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
    public partial class Gestion_Inventario : Form
    {

        private Conexion con;
        
        public Gestion_Inventario()
        {
            InitializeComponent();
        }

        public Gestion_Inventario(Conexion Con)
        {
            this.con = Con;
            InitializeComponent();
            ListarInventario();
            ListarInvProveedor();


        }
        public void ListarInventario()
        {
            con.Listados(dgvInventario, "ListarInventario");
        }

        public void ListarInvProveedor()
        {
            con.Listados(dgvInvProveedor, "ListarInventarioProveedor");
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Inventarios ET = new Inventarios(con);
            ET.BtnInsertar();
            ET.ShowDialog();
            ListarInventario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvInventario.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Inventarios fp = new Inventarios(con);
            fp.DrInventario = drow;
            fp.BtnEliminar();
            fp.ShowDialog();
            ListarInventario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvInventario.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Inventarios fp = new Inventarios(con);
            fp.DrInventario = drow;
            fp.BtnActualizar();
            fp.ShowDialog();
            ListarInventario();
        }

        public void acceso()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;
            btnNuevo.Enabled = false;
            btnNuevo.Visible = false;
        }

        private void btnReporteAll_Click(object sender, EventArgs e)
        {
            ReporteInventario ri = new ReporteInventario();
            ri.ShowDialog();
        }

        private void Gestion_Inventario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InventarioProveedor inventarioProveedor = new InventarioProveedor(con);

            inventarioProveedor.butnuevo();
            inventarioProveedor.ShowDialog();
            ListarInvProveedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvInvProveedor.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            InventarioProveedor inventarioProveedor = new InventarioProveedor(con);
            inventarioProveedor.DrInvP = drow;
            inventarioProveedor.butnEditar();
            inventarioProveedor.ShowDialog();
            ListarInvProveedor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvInvProveedor.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            InventarioProveedor inventarioProveedor = new InventarioProveedor(con);
            inventarioProveedor.DrInvP = drow;
            inventarioProveedor.ButnEliminar();
            inventarioProveedor.ShowDialog();
            ListarInvProveedor();
           
        }


        public void BusquedaSQLInv(String Texto)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@txtBuscar", SqlDbType.NVarChar);
            param[0].Value = textBox1.Text;
            param[1] = new SqlParameter("@Tipo", SqlDbType.NVarChar);
            param[1].Value = Texto;

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "BuscaInventario";
            comando.Connection = con.connect;
            comando.Parameters.AddRange(param);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);

            dgvInventario.DataSource = dt;

        }

        public void BusquedaSQLInvProveedor(String Texto)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@txtBuscar", SqlDbType.NVarChar);
            param[0].Value = textBox2.Text;
            param[1] = new SqlParameter("@Tipo", SqlDbType.NVarChar);
            param[1].Value = Texto;

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "BuscarInvProeedor";
            comando.Connection = con.connect;
            comando.Parameters.AddRange(param);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);

            dgvInvProveedor.DataSource = dt;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(dgvInventario);
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(dgvInvProveedor);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text.Equals(""))
            {
                ListarInvProveedor();
            }
            else
            {
                int result = comboBox2.SelectedIndex;

                switch (result)
                {
                    case 0:
                        BusquedaSQLInvProveedor("Codigo");
                        break;
                    case 1:
                        BusquedaSQLInvProveedor("Nombre");
                        break;
                    case 2:
                        BusquedaSQLInvProveedor("Cantidad");
                        break;
                    case 3:
                        BusquedaSQLInvProveedor("Precio");
                        break;


                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int result = comboBox1.SelectedIndex;

            if (textBox1.Text.Equals(""))
            {
                ListarInventario();
            }
            else
            {
                
                
                switch (result)
                {
                    case 0:
                        BusquedaSQLInv("Codigo");
                        break;
                    case 1:
                        BusquedaSQLInv("Nombre");
                        break;
                    case 2:
                        BusquedaSQLInv("Cantidad");
                        break;
                    case 3:
                        BusquedaSQLInv("Precio");
                        break;


                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporteListaProveedor ri = new ReporteListaProveedor();
            ri.ShowDialog();
        }
    }
}
