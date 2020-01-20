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
    public partial class Gestion_Clientes : Form {




        private Conexion cone;
        public Gestion_Clientes()
        {
            InitializeComponent();
        }

        public Gestion_Clientes(Conexion con)

        {
            this.cone = con;
            InitializeComponent();
            this.ListaC();

        }

        public void ListaC()
        {
            cone.Listados(dgvClientes, "ListarClientes");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvClientes.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Clientes fp = new Clientes(cone,false);
            fp.DrCliente = drow;
            fp.BtnActualizar();
            fp.ShowDialog();
            ListaC();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvClientes.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            Clientes fp = new Clientes(cone,false);
            fp.DrCliente = drow;
            fp.BtnEliminar();
            fp.ShowDialog();
            ListaC();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clientes ET = new Clientes(cone,true);
            ET.BtnInsertar();
            ET.ShowDialog();
            ListaC();
        }
    }
}
