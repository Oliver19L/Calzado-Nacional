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
    public partial class Ventas : Form
    {

        private Conexion cone;

        public Ventas()
        {
            InitializeComponent();
        }

        public Ventas(Conexion cone)
        {
            this.cone = cone;
            InitializeComponent();
            ListaVenta(cone);
        }

        public void ListaVenta(Conexion cone)
        {
            cone.Listados(dgvInventario,"ListarVenta");

        }



    }
}
