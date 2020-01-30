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
    public partial class Detalle_Venta : Form
    {
        private Conexion con;
        public Detalle_Venta(Conexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Detalle_Venta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }



        public void btnNuevoD()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;
           
        }

        public void btnEliminarDP()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnNuevo.Enabled = false;
            btnNuevo.Visible = false;
          
            txtCantidad.Enabled = false;
            maskedTextBox2.Enabled = false;
            txtDescripcion.Enabled = false;
            maskedTextBox2.Enabled = false;
            txtPrecio.Enabled = false;
            txtSub_Total.Enabled = false;
            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
        }

        public void btnEditarDP()
        {
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;
           
            btnNuevo.Enabled = false;
            btnNuevo.Visible = false;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            //MessageBox.Show((txtCodigo_Producto.Text.Length).ToString());
            if (maskedTextBox2.Text.Length == 4)
            {


                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Codigo", SqlDbType.Char);
                param[0].Value = maskedTextBox2.Text;

                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "ObtenerPrecioInventario";
                cm.Connection = con.connect;
                cm.Parameters.AddRange(param);

                SqlDataReader lecto;

                lecto = cm.ExecuteReader();

                while (lecto.Read())
                {
                    // MessageBox.Show(lector.GetString(0));

                    txtPrecio.Text = Convert.ToString(lecto.GetDouble(0));

                }
                lecto.Close();
            }

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        Inventarios inv = new Inventarios();


        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidad.Text.Equals("") || inv.ValidarLetra(txtCantidad.Text)){
                errorProvider1.SetError(txtCantidad,"El campo esta Vacio o Ingreso una Letra");
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
                errorProvider1.SetError(txtDescripcion,"El campo esta Vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBox2.Text.Equals(""))
            {
                errorProvider1.SetError(maskedTextBox2,"El Campo esta Vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
