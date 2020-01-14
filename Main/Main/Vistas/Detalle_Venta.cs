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
    public partial class Detalle_Venta : Form
    {
        private Conexion con;
        public Detalle_Venta(Conexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Detalle_Venta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
