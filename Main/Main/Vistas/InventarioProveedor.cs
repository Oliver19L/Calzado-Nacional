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
    public partial class InventarioProveedor : Form
    {
        private Conexion con;
        private DataRow drInvP;
        public InventarioProveedor(Conexion Con)
        {
            this.con = Con;
            InitializeComponent();
        }

        public DataRow DrInvP
        {
            set
            {
                drInvP = value;
                mskCodigo.Text = drInvP["Codigo_Producto"].ToString();
                txtNombre.Text = drInvP["Nombre"].ToString();
                txtDescrip.Text = drInvP["Descripcion"].ToString();
                txtCantidad.Text = drInvP["Cantidad"].ToString();
                txtPrecio.Text = drInvP["Precio"].ToString();
                
            }
        }

        public SqlParameter[] parametroInv()
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Codigo", SqlDbType.Char);
            param[0].Value = mskCodigo.Text;
            param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            param[1].Value = txtNombre.Text;
            param[2] = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
            param[2].Value = txtDescrip.Text;
            param[3] = new SqlParameter("@Cantidad", SqlDbType.Int);
            param[3].Value = int.Parse(txtCantidad.Text);
            param[4] = new SqlParameter("@Precio", SqlDbType.Float);
            param[4].Value = float.Parse(txtPrecio.Text);
            return param;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void butnuevo()
        {
            btnelim.Visible = false;
            btnActu.Visible = false;
        }

        public void butnEditar()
        {
            btnInsert.Visible = false;
            btnelim.Visible = false;
            mskCodigo.Enabled = false;
        }

        public void ButnEliminar()
        {
            btnInsert.Visible = false;
            btnLimpiar.Visible = false;
            btnActu.Visible = false;
            mskCodigo.Enabled = false;
            txtPrecio.Enabled = false;
            txtNombre.Enabled = false;
            txtDescrip.Enabled = false;
            txtCantidad.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtDescrip.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Insertados(parametroInv(), "NuevoInvProeedor");
            this.Hide();
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            con.editados(parametroInv(), "ActualizarInvProeedor");
            this.Hide();
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            con.eliminarChar(mskCodigo.Text, "EliminarInvProveedor", "@ID");
            this.Hide();
        }
    }
}
