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
    public partial class DevolucionesCompra : Form
    {
        public DevolucionesCompra()
        {
            InitializeComponent();
        }
        private Conexion con;

        public DevolucionesCompra(Conexion con)
        {
            this.con = con;
            InitializeComponent();
            ListaDevoCom(con);
        }
        public void ListaDevoCom(Conexion con)
        {
            con.Listados(dgvDevolucionesCompra, "ListarDvCompra");
        }

    }
}
