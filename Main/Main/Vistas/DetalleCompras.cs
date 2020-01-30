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
    public partial class DetalleCompras : Form
    {
        private Conexion con;
        public DetalleCompras(Conexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNFactura.Text = "";
            txtConcepto.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtDescuento.Text = "";
            txtSub_Total.Text = "";
            txtIva.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void btnNuevaDC()
        {
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;
        }

        public void btnEliminarDC()
        {
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
        }

        public void btnEditarDC()
        {
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;
        }
    }
}
