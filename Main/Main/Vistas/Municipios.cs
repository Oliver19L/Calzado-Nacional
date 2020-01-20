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
    public partial class Municipios : Form
    {
      
        private Conexion con;
        public Municipios(Conexion con)
        {
            this.con = con;
            InitializeComponent();
            ListarMunicipios();
        }

        public void ListarMunicipios()
        {
            con.Listados(dgvMunicipios, "ListarMunicipios");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        
            
          
        }
    }
}
