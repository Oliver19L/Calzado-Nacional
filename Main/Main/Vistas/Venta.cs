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
    public partial class Venta : Form
    {
        private Conexion con;
        public Venta(Conexion com)
        {
            this.con = com;
            InitializeComponent();
            txtID_Venta.Enabled = false;
            maskedTextBox2.Text = Convert.ToString(DateTime.Now.Date);
        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                errorProvider1.SetError(textBox1, "El campo esta vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void btnNuevaV()
        {
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;
        }

        public void btnEliminarV()
        {
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
        }

        public void btnEditarV()
        {
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
