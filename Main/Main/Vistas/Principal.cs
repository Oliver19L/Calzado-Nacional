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
            lbTiempo.Text = DateTime.Now.ToString();
            

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Compras(Con));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
            if (lbAcceso.Text == "Administrador")
            {
                AbrirFormEnPanel(new Gestion_Trabajador(Con));

            }
            if (lbAcceso.Text =="Lector")
            {

                Gestion_Trabajador gt = new Gestion_Trabajador(Con);
                AbrirFormEnPanel(gt);
                gt.buttonsAccesoLector();
            }

        }
    

        
           

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lbAcceso.Text == "Administrador")
            {
                AbrirFormEnPanel(new Gestion_Inventario(Con));

            }
            if (lbAcceso.Text == "Lector")
            {

                Gestion_Inventario Inv = new Gestion_Inventario(Con);
                AbrirFormEnPanel(Inv);
                Inv.acceso();
            }
            
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
            AbrirFormEnPanel(new Gestion_Pedidos(Con));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Gestion_Ventas(Con));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ContenedorDeDevoluciones(Con));
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
              AbrirFormEnPanel(new  Gestion_Clientes(Con));
            
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=50584422254");
        }

        public void Usuarios(string user,String Nombre)
        {
            lbNombre.Text = Nombre;
            lbAcceso.Text = user;
            
        }
        
        public string Acesso(String Acc)
        {
            String persona="";

            switch (Acc)
            {
                case "Prueba": 
                    persona="Administrador";
                    break;

            }
            return persona;
        }

        private void label17_Click(object sender, EventArgs e)
        {

            DialogResult Dresult;
           Dresult= MessageBox.Show(this, "Esta seguro que desea Salir", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dresult == DialogResult.Yes)
            {
                Con.connect.Close();
                IniSesion ini = new IniSesion();
                this.Hide();
                ini.Show();
            }
          
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel( new Gestion_Proveedores(Con));

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Dresult;
            Dresult = MessageBox.Show(this, "Por su seguridad ''CERRAREMOS'' el Inicio de Sesion", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dresult == DialogResult.Yes)
            {
                Con.connect.Close();
                IniSesion ini = new IniSesion();
                this.Hide();
                ini.Show();
            }
            else
            {
                e.Cancel=true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTiempo.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbTiempo.Text = DateTime.Now.ToString();
        }








    }


   
    
}
