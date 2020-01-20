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
    public partial class FrmDevolucionCliente : Form
    {

        private Conexion con;
        public FrmDevolucionCliente()
        {
            InitializeComponent();
        }
        public FrmDevolucionCliente(Conexion con)
        {
            this.con = con;
            InitializeComponent();

        }
    }
}
