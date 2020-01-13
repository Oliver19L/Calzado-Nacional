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

        }

        public SqlParameter[] parametroInv()
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@PrimNombre", SqlDbType.NVarChar);
            param[0].Value = txtNombre.Text;
            param[1] = new SqlParameter("@SegundNombre", SqlDbType.NVarChar);
            param[1].Value = txtDescripcion.Text;
            param[2] = new SqlParameter("@PrimApellid", SqlDbType.Int);
            param[2].Value = txtCantidad;
            param[3] = new SqlParameter("@SegundApellid", SqlDbType.Float);
            param[3].Value = txtPrecio.Text;

            return param;
        }
    }
}
