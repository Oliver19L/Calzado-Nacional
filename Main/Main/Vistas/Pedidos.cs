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
    public partial class Pedidos : Form
    {
        private Conexion con;
        protected DataRow drPedidos;
        public Pedidos(Conexion con)
        {
            this.con = con;
            InitializeComponent();
            mskFecha_Pedido.Text = DateTime.Now.ToString();

        }

        public DataRow DrPedidis
        {
            set
            {
                drPedidos = value;
                mskId.Text = drPedidos["Id_Pedidos"].ToString();
                txtID_Cliente.Text = drPedidos["Id_Cliente"].ToString();
                mskFecha_Pedido.Text = drPedidos["Fecha_Pedido"].ToString();
                dtpFechaF.Value = DateTime.Parse(drPedidos["Fecha_Finalizado"].ToString());
            }
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            con.Insertados(Parametro(),"NuevoPedido");
            this.Hide();
        }

        public SqlParameter[] Parametro()
        {

            SqlParameter[] param = new SqlParameter[3];


            param[0] = new SqlParameter("@Id_Pedid", SqlDbType.Char);
            param[0].Value = mskId.Text;
            param[1] = new SqlParameter("@Id_Clien", SqlDbType.Int);
            param[1].Value = int .Parse(txtID_Cliente.Text);
            param[2] = new SqlParameter("@Fecha_Finaliza", SqlDbType.Date);
            param[2].Value = dtpFechaF.Text;

            return param;

        }

        public SqlParameter[] ParametroAc()
        {

            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@Id_Pedid", SqlDbType.Char);
            param[0].Value = mskId.Text;
            param[1] = new SqlParameter("@Id_Clien", SqlDbType.Int);
            param[1].Value = int.Parse(txtID_Cliente.Text);
            param[2] = new SqlParameter("@Id_Clien", SqlDbType.Date);
            param[2].Value = mskFecha_Pedido.Text;
            param[3] = new SqlParameter("@Fecha_Finaliza", SqlDbType.Date);
            param[3].Value = Convert.ToDateTime(dtpFechaF.Text);

            return param;

        }

        public void btnNuevo()
        {
            btnEditar.Visible = false;
            btnEditar.Enabled = false;
            btnEliminar.Visible = false;
            btnEliminar.Enabled = false;
           
        }

        public void btnesEliminar()
        {
            btnEditar.Visible = false;
            btnEditar.Enabled = false;
            txtID_Cliente.Enabled = false;
           // mskId.Enabled = false;
            mskFecha_Pedido.Enabled = false;
            dtpFechaF.Enabled = false;
        }
        
        public void btnesEditar()
        {
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;
            mskId.Enabled = false;
            mskFecha_Pedido.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            con.editados(ParametroAc(),"ActualizarPedido");
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarChar(mskId.Text,"EliminarPedidos","@ID");
            
        }
    }

}
