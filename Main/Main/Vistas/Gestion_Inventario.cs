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


        }
        public void ListarInventario()
        {
            con.Listados(dgvInventario, "ListarInventario");
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
    }
}
