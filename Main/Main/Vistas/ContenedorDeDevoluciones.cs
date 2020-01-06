using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.Vistas;
namespace Main.Vistas
{
    public partial class ContenedorDeDevoluciones : Form
    {
        public ContenedorDeDevoluciones()
        {
            InitializeComponent();
            
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.paneldeD.Controls.Count > 0)
                this.paneldeD.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.paneldeD.Controls.Add(fh);
            this.paneldeD.Tag = fh;
            fh.Show();
           
        }

        
       
       

       

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new DevolucionesCompra());
        }

        private void button2_Click(object sender, EventArgs e)
        {
                AbrirFormEnPanel(new DevolucionCliente());
            
        }
    }
}
