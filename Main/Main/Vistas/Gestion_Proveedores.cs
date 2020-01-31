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
            fp.Combo(false);
            fp.btnEditarP();
            fp.ShowDialog();
            ListarProveedor();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor(con,true);
            prov.btnNuevaP();
            prov.ShowDialog();
            ListarProveedor();
        }
    }
}
