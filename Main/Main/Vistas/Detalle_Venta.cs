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
        private DataRow drDetalleVenta;
        public Detalle_Venta(Conexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        public SqlParameter[] parametroDetalleVenta()
        {
            SqlParameter[] param = new SqlParameter[7];
            
            param[0] = new SqlParameter("@Id_Venta", SqlDbType.Int);
            param[0].Value = int.Parse(txtId_Venta.Text);
            param[1] = new SqlParameter("@Cod_Producto", SqlDbType.Char);
            param[1].Value = maskedTextBox2.Text;
            param[2] = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
            param[2].Value = txtDescripcion.Text;
            param[3] = new SqlParameter("@Cantidad", SqlDbType.Int);
            param[3].Value = float.Parse(txtCantidad.Text);
            param[4] = new SqlParameter("@Precio", SqlDbType.Float);
            param[4].Value = float.Parse(txtPrecio.Text);
            if (txtDescuento.Text.Equals(""))
            {
                param[5] = new SqlParameter("@Descuento", SqlDbType.Float);
                param[5].Value = 0;
            }
            else
            {
                param[5] = new SqlParameter("@Descuento", SqlDbType.Float);
                param[5].Value = float.Parse(txtDescuento.Text);
            }
                
            
            param[6] = new SqlParameter("@SubTotal", SqlDbType.Float);
            param[6].Value = int.Parse(txtSub_Total.Text);
            return param;
        }

        public SqlParameter[] parametroDetalleVenta2()
        {
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Id_DVenta", SqlDbType.Int);
            param[0].Value = int.Parse(txtId.Text);
            param[1] = new SqlParameter("@Id_Venta", SqlDbType.Int);
            param[1].Value = int.Parse(txtId_Venta.Text);
            param[2] = new SqlParameter("@Cod_Producto", SqlDbType.Char);
            param[2].Value = maskedTextBox2.Text;
            param[3] = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
            param[3].Value = txtDescripcion.Text;
            param[4] = new SqlParameter("@Cantidad", SqlDbType.Int);
            param[4].Value = float.Parse(txtCantidad.Text);
            param[5] = new SqlParameter("@Precio", SqlDbType.Float);
            param[5].Value = float.Parse(txtPrecio.Text);
            param[6] = new SqlParameter("@Descuento", SqlDbType.Float);
            param[6].Value = float.Parse(txtDescuento.Text);
            param[7] = new SqlParameter("@SubTotal", SqlDbType.Float);
            param[7].Value = int.Parse(txtSub_Total.Text);
            return param;
        }
        public DataRow DrDetalleVenta
        {
            set
            {
                drDetalleVenta = value;
                txtId.Text = drDetalleVenta["Id_DetalleV"].ToString();
                txtId_Venta.Text = drDetalleVenta["Id_Venta"].ToString();
                maskedTextBox2.Text = drDetalleVenta["Cod_Prod"].ToString();
                txtDescripcion.Text = drDetalleVenta["Descripcion"].ToString();
                txtCantidad.Text = drDetalleVenta["Cantidad"].ToString();
                txtPrecio.Text = drDetalleVenta["Precio"].ToString();
                txtDescuento.Text = drDetalleVenta["Descuento"].ToString();
                txtSub_Total.Text = drDetalleVenta["SubTotal"].ToString();
            }
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
            txtId.Enabled = false;
           
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
            

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            int result1  = 0;

            result = int.Parse(txtPrecio.Text);
            if (txtCantidad.Text.Equals(""))
            {
              
            }
            else
            {
                if (txtCantidad.Text.Equals("0"))
                {

                }
                else
                {
                    result1 = int.Parse(txtCantidad.Text);
                    txtSub_Total.Text = (result * result1).ToString();
                }
                
            }

            if (txtDescuento.Text != "")
            {
                float result2 = 0;
                int result3 = 0;
                result2 = float.Parse(txtCantidad.Text)*float.Parse(txtPrecio.Text);
                result3 = int.Parse(txtDescuento.Text);

                txtSub_Total.Text = (result2 - (result2 * (result3 / 100))).ToString();
            }
           
           

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            con.Insertados(parametroDetalleVenta(), "NuevoDetalleVenta");
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            con.editados(parametroDetalleVenta2(), "ActualizacionDetalleVenta");
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarChar(txtId.Text, "EliminarDetalleVenta","@ID");
            this.Hide();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
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

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            
                if (txtDescuento.Text.Equals("") || txtDescuento.Text.Length == 1 || txtDescuento.Text.Length >= 3)
                {
                    txtSub_Total.Text = (int.Parse(txtPrecio.Text) * int.Parse(txtCantidad.Text)).ToString();
                }
                else
                {
                    if (txtDescuento.Text == "0")
                    {
                        txtSub_Total.Text = (int.Parse(txtPrecio.Text) * int.Parse(txtCantidad.Text)).ToString();
                    }
                    else if(txtDescuento.Text.Length == 2)
                    {
                        float result = 0;
                        float result1 = 0;
                        result = float.Parse(txtSub_Total.Text);
                        result1 = float.Parse(txtDescuento.Text);

                        txtSub_Total.Text = (result - (result * (result1 / 100))).ToString();
                    }
                }
            
            
        }
    }
}
