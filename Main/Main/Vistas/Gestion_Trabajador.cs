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
    public partial class Gestion_Trabajador : Form
    {
        private Conexion cone;

        public DataRow dr;
        // public Trabajador()
        // {
        //    InitializeComponent();
        //  


        // }

        public Gestion_Trabajador(Conexion con)
        {
            this.cone = con;
            InitializeComponent();
            ListarUsuarios(cone,"ListaEmpleados");
            //  this.textBox1.Text = Svr(con);
        }

        private void Trabajador_Load(object sender, EventArgs e)
        {



        }

        public void ListarUsuarios(Conexion con, String procedimiento)
        {
            con.ListarEmpleados(dgvEmpleados,procedimiento);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader leer;

            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "NuevoUsuario";
            //cmd.Connection = con.connect;

            //leer = cmd.ExecuteReader();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            ////while (leer.Read())
            ////{
            ////    DataGridViewRow filas = new DataGridViewRow();
            ////    filas.CreateCells(dgvEmpleados);
            ////    filas.Cells[0].Value = leer.GetString(0);
            ////    filas.Cells[1].Value = leer.GetString(1);
            ////    filas.Cells[2].Value = leer.GetString(2);
            ////    filas.Cells[3].Value = leer.GetString(3);

            ////    dgvEmpleados.Rows.Add(filas);

            ////}


            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //dgvEmpleados.DataSource = dt;
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public string Svr(Conexion con)
        {
            String sert;

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select IS_SRVROLEMEMBER ('sysadmin','Prueba12')";
            cmd.Connection = con.connect;

            leer = cmd.ExecuteReader();
            sert = Convert.ToString(leer.Read());


            return sert;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EditarTrabajador ET = new EditarTrabajador(cone);
            ET.BtnInsertar();
            ET.ShowDialog();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection rowCollection = dgvEmpleados.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            EditarTrabajador fp = new EditarTrabajador(cone);
            fp.DrEmpleados = drow;
            fp.BtnActualizar();
            fp.ShowDialog();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
