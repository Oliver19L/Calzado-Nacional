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
    public partial class Inventarios : Form
    {

        private Conexion cone;
        private DataRow drInventario;
        public Inventarios(Conexion con)
        {
            this.cone = con;
            InitializeComponent();
        }

        public Inventarios()
        {
            
        }

        public DataRow DrInventario
        {
            set
            {
                drInventario = value;
                txtId.Text = drInventario["Cod_Prod"].ToString();
                txtNombre.Text = drInventario["NombreProd"].ToString();
                txtDescripcion.Text = drInventario["Descripcion"].ToString();
                txtCantidad.Text = drInventario["CantidadInv"].ToString();
                txtPrecio.Text = drInventario["PrecioVenta"].ToString();
               
               
            }
        }

        public void BtnActualizar()
        {
            txtId.Enabled = false;
            btnInsert.Enabled = false;
            btnInsert.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;

        }

        public void BtnEliminar()
        {
            txtId.Enabled = false;
            btnActu.Enabled = false;
            btnActu.Visible = false;
            btnInsert.Enabled = false;
            btnInsert.Visible = false;
            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            txtCantidad.Enabled = false;
           

        }

        public void BtnInsertar()
        {
            
            btnActu.Enabled = false;
            btnActu.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();


            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Char);
            param[0].Value = txtId.Text;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarInventario";
            cmd.Connection = cone.connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);

            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Validaciones();
            cone.Insertados(parametroInv(), "NuevoProducto");
            this.Dispose();
        }

        public SqlParameter[] parametroInv()
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Codigo", SqlDbType.Char);
            param[0].Value =txtId.Text;
            param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            param[1].Value =txtNombre.Text;
            param[2] = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
            param[2].Value =txtDescripcion.Text;
            param[3] = new SqlParameter("@Cantidad", SqlDbType.Int);
            param[3].Value = int.Parse(txtCantidad.Text);
            param[4] = new SqlParameter("@PrecioVenta", SqlDbType.Float);
            param[4].Value = float.Parse(txtPrecio.Text);
            return param;
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            cone.editados(parametroInv(),"ActualizarInventario");
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        public void Validaciones()
        {
            


        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                errorProvider1.SetError(txtId, "Campo Vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                errorProvider1.SetError(txtNombre, "Campo Vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescripcion.Text.Equals(""))
            {
                errorProvider1.SetError(txtDescripcion, "Campo Vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public bool ValidarLetra(String Texto)
        {
            bool flag = false;
            foreach(char cadena in Texto)
            {
                if (char.IsLetter(cadena))
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if(txtCantidad.Text.Equals("") || ValidarLetra(txtCantidad.Text))
            {
                errorProvider1.SetError(txtCantidad, "El campo vacio o Ingreso Una letra");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrecio.Text.Equals("") || ValidarLetra(txtPrecio.Text))
            {
                errorProvider1.SetError(txtPrecio, "El campo vacio o Ingreso Una letra");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
