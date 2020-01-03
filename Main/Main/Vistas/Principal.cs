using Main.DAO;
using Main.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Principal : Form
    {
         public Conexion Con;

       

        public Principal()
        {
           
            InitializeComponent();
        }
        

        public Principal(Conexion Con)
        {
            this.Con = Con;
            InitializeComponent();
            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Compras());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Trabajador());
        }
    

        
           

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            AbrirFormEnPanel(new Inventario());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
        
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Calzado-Nacional-289577175142834/");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/calzado_nacional_23/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Calzado+Nacional+Sharon/@11.963495,-86.0938846,20.7z/data=!4m5!3m4!1s0x8f7407fbcfa131ff:0x16321c9e7099d8d3!8m2!3d11.9636643!4d-86.0936455");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pedidos());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ventas());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new DevolucionesCompra());
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new  Clientes());
        }
    }
}
