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
    public partial class Clientes : Form
    {

        private Conexion conex;

        private DataRow drCliente
            ;
        public Clientes(Conexion con)
        {
            this.conex = con;
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

        public DataRow DrCliente
        {
            set
            {
                drCliente = value;
                txtId.Text = drCliente["Id_Empleados"].ToString();
                txtPrimerNombre.Text = drCliente["Primer_Nombre"].ToString();
                txtSegundoNombre.Text = drCliente["Segundo_Nombre"].ToString();
                txtPrimerA.Text = drCliente["Primer_Apellido"].ToString();
                txtSegundoA.Text = drCliente["Segundo_Apellido"].ToString();
                txtEmail.Text = drCliente["Email"].ToString();
                mskCelular.Text = drCliente["Telefono"].ToString();
                mskTele.Text = drCliente["Celular"].ToString();
                txtDireccion.Text = drCliente["Direccion"].ToString();
                txtMunicipio.Text = drCliente["Id_Munic"].ToString();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
