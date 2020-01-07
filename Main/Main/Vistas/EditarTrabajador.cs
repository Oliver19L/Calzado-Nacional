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
    public partial class EditarTrabajador : Form
    {


        private Conexion con;
        public EditarTrabajador(Conexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.insertarTrabajador(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerA.Text, txtSegundoA.Text, txtEmail.Text, mskTele.Text, mskCelular.Text, txtDireccion.Text,txtMunicipio.Text);
            this.Hide();
            
        }

      
    }
}
