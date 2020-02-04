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
    public partial class FrmDevolucionCompra : Form
    {
        private Conexion con;
        public FrmDevolucionCompra(Conexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void FrmDevolucionCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
