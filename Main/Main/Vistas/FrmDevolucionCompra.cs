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
    public partial class FrmDevolucionCompra : Form
    {
        private Conexion con;
        public FrmDevolucionCompra(Conexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        public SqlParameter[] Parametro()
        {

            SqlParameter[] param = new SqlParameter[3];


            
            param[0] = new SqlParameter("@Id_Devolucion", SqlDbType.Int);
            param[0].Value = int.Parse(txtID.Text);
            param[1] = new SqlParameter("@Id_Proveedor", SqlDbType.Char);
            param[1].Value = txtIDP.Text;
            param[3] = new SqlParameter("@Concepto", SqlDbType.Char);
            param[3].Value = txtConcepto.Text;
            param[4] = new SqlParameter("@Fecha", SqlDbType.Date);
            param[4].Value = DateTime.Parse(mskFecha.Text);
            param[5] = new SqlParameter("@Cantidad", SqlDbType.Int);
            param[5].Value = int.Parse( txtCantidad.Text);
            param[5] = new SqlParameter("@Monto", SqlDbType.Float);
            param[5].Value = float.Parse(txtMonto.Text);

            return param;

        }

        private void FrmDevolucionCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            con.Insertados(Parametro(), "NuevoDevProveedor");
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            con.eliminarChar(txtID.Text, "EliminarDevProveedor", "@ID");
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            con.editados(Parametro(),"ActualizacionDevProveedor");
            this.Hide();
        }
    }
}
