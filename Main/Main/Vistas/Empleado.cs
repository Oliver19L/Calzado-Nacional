using Main.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Vistas
{
    public partial class EditarTrabajador : Form
    {



        private Conexion conex;

        private DataRow drEmpleados;

        public EditarTrabajador(Conexion cone)
        {
            this.conex = cone;
            InitializeComponent();
           
        }
        public SqlParameter[] parametro()
        {
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@PrimNombre", SqlDbType.NVarChar);
            param[0].Value = txtPrimerNombre.Text;
            param[1] = new SqlParameter("@SegundNombre", SqlDbType.NVarChar);
            param[1].Value = txtSegundoNombre.Text;
            param[2] = new SqlParameter("@PrimApellid", SqlDbType.NVarChar);
            param[2].Value = txtPrimerA.Text;
            param[3] = new SqlParameter("@SegundApellid", SqlDbType.NVarChar);
            param[3].Value = txtSegundoA.Text;
            param[4] = new SqlParameter("@Email", SqlDbType.NVarChar);
            param[4].Value = txtEmail.Text;
            param[5] = new SqlParameter("@Telefono", SqlDbType.Char);
            param[5].Value = mskTele.Text;
            param[6] = new SqlParameter("@Celular", SqlDbType.Char);
            param[6].Value = mskCelular.Text;
            param[7] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
            param[7].Value = txtDireccion.Text;
            param[8] = new SqlParameter("@IdMunic", SqlDbType.Int);
            param[8].Value = int.Parse(txtMunicipio.Text);

            return param;
           
        }

        public SqlParameter[] EditarEmpleadosParam()
        {

            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value =txtId.Text;
            param[1] = new SqlParameter("@Email", SqlDbType.NVarChar);
            param[1].Value = txtEmail.Text;
            param[2] = new SqlParameter("@Telefono", SqlDbType.Char);
            param[2].Value = mskTele.Text;
            param[3] = new SqlParameter("@Celular", SqlDbType.Char);
            param[3].Value = mskCelular.Text;
            param[4] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
            param[4].Value = txtDireccion.Text;
            param[5] = new SqlParameter("@IdMunic", SqlDbType.Int);
            param[5].Value = txtMunicipio.Text;

            return param;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            conex.InsertarTrabajador(parametro(),"NuevoEmpleado");
            this.Hide();
            
        }

       



       

        public DataRow DrEmpleados
        {
            set
            {
                drEmpleados = value;
                txtId.Text = drEmpleados["Id_Empleados"].ToString();
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


            conex.editarEmpleado(EditarEmpleadosParam(),"ActualizacionEmpleados");
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void BtnActualizar()
        {
            txtId.Enabled = false;
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;

        }

        public void BtnEliminar()
        {
            txtId.Enabled = false;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
            txtPrimerNombre.Enabled = false;
            txtSegundoNombre.Enabled = false;
            txtPrimerA.Enabled = false;
            txtSegundoA.Enabled = false;
            txtEmail.Enabled = false;
            mskCelular.Enabled = false;
            mskTele.Enabled = false;
            txtDireccion.Enabled = false;
            txtMunicipio.Enabled = false;
          
        }
            
        public void BtnInsertar()
        {
            txtId.Enabled = false;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            conex.eliminar(int.Parse(txtId.Text), "EliminarEmpleado", "@ID");
            this.Hide();
            
        }
    }
}
