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
    public partial class Venta : Form
    {
        private Conexion con;
        private DataRow drVenta;
        public Venta(Conexion com)
        {
            this.con = com;
            InitializeComponent();
            txtID_Venta.Enabled = false;
            maskedTextBox2.Text = Convert.ToString(DateTime.Now.Date);
        }

        public SqlParameter[] Parametro()
        {
            textBox2.Text = "0";
            SqlParameter[] param = new SqlParameter[2];


            //param[0] = new SqlParameter("@Id_Venta", SqlDbType.Int);
            //param[0].Value = int.Parse( txtID_Venta.Text);
            param[0] = new SqlParameter("@Id_CC", SqlDbType.Int);
            param[0].Value = int.Parse(textBox1.Text);
            param[1] = new SqlParameter("@Total", SqlDbType.Float);
            param[1].Value = float.Parse(textBox2.Text);

            return param;

        }

        public SqlParameter[] ParametroEdi()
        {

            SqlParameter[] param = new SqlParameter[3];


            param[0] = new SqlParameter("@Id_Venta", SqlDbType.Int);
            param[0].Value = int.Parse( txtID_Venta.Text);
            param[1] = new SqlParameter("@Id_CC", SqlDbType.Int);
            param[1].Value = int.Parse(textBox1.Text);
            param[2] = new SqlParameter("@Fecha_v", SqlDbType.Date);
            param[2].Value = DateTime.Parse(maskedTextBox2.Text);

            return param;

        }

        public DataRow DrVenta
        {
            set
            {
                drVenta = value;
                txtID_Venta.Text = drVenta["Id_Venta"].ToString();
                textBox1.Text = drVenta["Id_Cliente"].ToString();
                maskedTextBox2.Text = drVenta["Fecha_Venta"].ToString();
                textBox2.Text = drVenta["Total"].ToString();
            }
        }



        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                errorProvider1.SetError(textBox1, "El campo esta vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void btnNuevaV()
        {
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;
            textBox2.Visible = false;
        }

        public void btnEliminarV()
        {
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
        }

        public void btnEditarV()
        {
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            con.Insertados(Parametro(),"NuevaVenta");
            this.Hide();
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            con.eliminar(int.Parse(txtID_Venta.Text),"EliminarVenta", "@ID");
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.editados(ParametroEdi(), "ActualizacionVenta");
            this.Hide();
        }
    }
}
