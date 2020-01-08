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
       

        private DataRow drEmpleados;

        public EditarTrabajador(Conexion con)
        {
            this.con = con;
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = true;
            btnActualizar.Visible = false;
            con.InsertarTrabajador(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerA.Text, txtSegundoA.Text, txtEmail.Text, mskTele.Text, mskCelular.Text, txtDireccion.Text,int.Parse(txtMunicipio.Text));
            this.Hide();
            
        }

       



       

        public DataRow DrEmpleados
        {
            set
            {
                drEmpleados = value;
                textBox1.Text = drEmpleados["Id_Empleados"].ToString();
                txtPrimerNombre.Text = drEmpleados["Primer_Nombre"].ToString();
                txtSegundoNombre.Text = drEmpleados["Segundo_Nombre"].ToString();
                txtPrimerA.Text = drEmpleados["Primer_Apellido"].ToString();
                txtSegundoA.Text = drEmpleados["Segundo_Apellido"].ToString();
                txtEmail.Text = drEmpleados["Email"].ToString();
                mskCelular.Text = drEmpleados["Telefono"].ToString();
                mskTele.Text = drEmpleados["Celular"].ToString();
                txtDireccion.Text = drEmpleados["Direccion"].ToString();
                txtMunicipio.Text= drEmpleados["Id_Munic"].ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void BtnActualizar()
        {
            textBox1.Enabled = false;
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;

        }
            
        public void BtnInsertar()
        {
            textBox1.Enabled = false;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerNombre.Text = String.Empty;
            txtSegundoNombre.Text = String.Empty;
            txtPrimerA.Text = String.Empty;
            txtSegundoA.Text = String.Empty;
            txtEmail.Text = String.Empty;
            mskCelular.Text = String.Empty;
            mskTele.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtMunicipio.Text = String.Empty;
        }

        private void EditarTrabajador_Load(object sender, EventArgs e)
        {

        }
    }
}
