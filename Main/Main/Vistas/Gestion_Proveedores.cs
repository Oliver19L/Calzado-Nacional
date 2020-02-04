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
    public partial class Gestion_Proveedores : Form
    {
        private Conexion con;
        public Gestion_Proveedores(Conexion con)
        {
            this.con = con;
            InitializeComponent();
            ListarProveedor();

        }



        public void ListarProveedor()
        {
            con.Listados(dgvProveedores, "ListaProveedor");

        }

        private void Gestion_Proveedores_Load(object sender, EventArgs e)
        {
            string[] comb = { "Id_Proveedor", "Nombre_Proveedor", "Celular", "Telefono", "Direccion", "Correo" };
            comboBox1.DataSource = comb;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvProveedores.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Proveedor pro = new Proveedor(con, false);
            pro.DRPROVEEDOR = drow;
            pro.Combo(false);
            pro.btnEliminarP();
            pro.ShowDialog();
            ListarProveedor();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvProveedores.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Proveedor fp = new Proveedor(con, false);
            fp.DRPROVEEDOR = drow;
            fp.Combo(true);
            fp.btnEditarP();
            fp.ShowDialog();
            ListarProveedor();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor(con, true);
            prov.Combo(true);
            prov.btnNuevaP();
            prov.ShowDialog();
            ListarProveedor();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(dgvProveedores);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteListaProveedores reporteLista = new ReporteListaProveedores();
            reporteLista.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                ListarProveedor();
            }
            else
            {
                int result = comboBox1.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("Id_Proveedor", dgvProveedores);

                        break;
                    case 1:
                        BusquedaSQL("Nombre_Proveedor", dgvProveedores);
                        break;
                    case 2:
                        BusquedaSQL("Celular", dgvProveedores);
                        break;
                    case 3:

                        BusquedaSQL("Telefono", dgvProveedores);
                        break;
                    case 4:
                        BusquedaSQL("Direccion", dgvProveedores);
                        break;
                    case 5:
                        BusquedaSQL("Correo", dgvProveedores);
                        break;

                }
            }

        }

        public void BusquedaSQL(String Texto, DataGridView dataGrid)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@txtBuscar", SqlDbType.NVarChar);
            param[0].Value = textBox1.Text;
            param[1] = new SqlParameter("@Tipo", SqlDbType.VarChar);
            param[1].Value = Texto;

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "BuscaProveedor";
            comando.Connection = con.connect;
            comando.Parameters.AddRange(param);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);

            dataGrid.DataSource = dt;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                ListarProveedor();
            }
            else
            {
                int result = comboBox1.SelectedIndex;

                switch (result)
                {

                    case 0:
                        BusquedaSQL("Id_Proveedor", dgvProveedores);

                        break;
                    case 1:
                        BusquedaSQL("Nombre_Proveedor", dgvProveedores);
                        break;
                    case 2:
                        BusquedaSQL("Celular", dgvProveedores);
                        break;
                    case 3:

                        BusquedaSQL("Telefono", dgvProveedores);
                        break;
                    case 4:
                        BusquedaSQL("Direccion", dgvProveedores);
                        break;
                    case 5:
                        BusquedaSQL("Correo", dgvProveedores);
                        break;

                }
            }
        }
    }
}