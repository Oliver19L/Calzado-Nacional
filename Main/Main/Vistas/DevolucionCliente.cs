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
    public partial class DevolucionCliente : Form
    {

        private Conexion cone;
        public DevolucionCliente(Conexion con)
        {
            this.cone = con;
            InitializeComponent();
            ListarDevoC(con);
        }

        private void ListarDevoC(Conexion con)
        {
            con.Listados(dgvDevoCliente, "ListarDvCliente");
        }


        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
