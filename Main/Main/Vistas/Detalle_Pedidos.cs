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
    public partial class Detalle_Pedidos : Form
    {
        private Conexion con;
        private DataRow drDetallePedido;
        public Detalle_Pedidos(Conexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        public DataRow DrDetallePedido
        {
            set
            {
                drDetallePedido = value;
                txtDetallePedido.Text = drDetallePedido["Id_DetalleP"].ToString();
                maskedTextBox1.Text = drDetallePedido["Id_Pedidos"].ToString();
                txtDescripcion.Text = drDetallePedido["DescripcionProd"].ToString();
                txtCantidad.Text = drDetallePedido["Cantidad"].ToString();
                maskedTextBox2.Text = drDetallePedido["CodProd"].ToString();
                txtPrecio.Text = drDetallePedido["Precio"].ToString();
                txtSub_Total.Text = drDetallePedido["SubTotal"].ToString();
            }
        }


        public SqlParameter[] Parametro()
        {

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Id_DPedido", SqlDbType.Int);
            param[0].Value = int.Parse(txtDetallePedido.Text);
            param[1] = new SqlParameter("@Id_Pedidos", SqlDbType.Char);
            param[1].Value = maskedTextBox1.Text;
            param[2] = new SqlParameter("@Cod_Producto", SqlDbType.Char);
            param[2].Value = maskedTextBox2.Text;
            param[3] = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
            param[3].Value = txtDescripcion.Text;
            param[4] = new SqlParameter("@Cantidad", SqlDbType.Int);
            param[4].Value = txtCantidad.Text;
            param[5] = new SqlParameter("@Precio", SqlDbType.Float);
            param[5].Value = float.Parse(txtPrecio.Text);
            param[6] = new SqlParameter("@SubTotal", SqlDbType.Float);
            param[6].Value = float.Parse(txtSub_Total.Text);


            return param;
        }
        public SqlParameter[] ParametroNuevo()
        {

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Id_Pedidos", SqlDbType.Char);
            param[0].Value = maskedTextBox1.Text;
            param[1] = new SqlParameter("@Cod_Producto", SqlDbType.Char);
            param[1].Value = maskedTextBox2.Text;
            param[2] = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
            param[2].Value = txtDescripcion.Text;
            param[3] = new SqlParameter("@Cantidad", SqlDbType.Int);
            param[3].Value = txtCantidad.Text;
            param[4] = new SqlParameter("@Precio", SqlDbType.Float);
            param[4].Value = float.Parse(txtPrecio.Text);
            param[5] = new SqlParameter("@SubTotal", SqlDbType.Float);
            param[5].Value = float.Parse(txtSub_Total.Text);


            return param;
        }



        private void Detalle_Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            con.Insertados(ParametroNuevo(), "NuevoDetallePedido");
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarChar(txtDetallePedido.Text, "EliminarDetallePedido","@ID");
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            con.editados(Parametro(), "ActualizarDetallePedido");
        }

        public void btnNuevoD()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;
            txtDetallePedido.Enabled = false;
        }

        public void btnEliminarDP()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnNuevo.Enabled = false;
            btnNuevo.Visible = false;
            txtDetallePedido.Enabled = false;
            txtCantidad.Enabled = false;
            maskedTextBox2.Enabled = false;
            txtDescripcion.Enabled = false;
            maskedTextBox1.Enabled = false;
            txtPrecio.Enabled = false;
            txtSub_Total.Enabled = false;
            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
        }

        public void btnEditarDP()
        {
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;
            txtDetallePedido.Enabled = false;
            btnNuevo.Enabled = false;
            btnNuevo.Visible = false;
        }

        private void txtCodigo_Producto_TextChanged(object sender, EventArgs e)
        {
            

           
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
           

            if (txtCantidad.Text.Length>0)
            {
                int cant;
                double prec;

                double result;

                cant = int.Parse(txtPrecio.Text);
                prec = double.Parse(txtCantidad.Text);

                result = cant * prec;

                txtSub_Total.Text = result.ToString();
            }

           
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox2_MaskChanged(object sender, EventArgs e)
        {
            

          
    }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

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

                SqlDataReader lector;

                lector = cm.ExecuteReader();

                while (lector.Read())
                {
                    // MessageBox.Show(lector.GetString(0));

                    txtPrecio.Text = Convert.ToString(lector.GetDouble(0));

                }
                lector.Close();
            }
        }
    }
}
