using Main.DAO;
using Main.Reportes;
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

        
        private Conexion conex;
        public DataRow dr;
         public Gestion_Trabajador()
         {

         }

        public Gestion_Trabajador(Conexion cone)
        {
            this.conex = cone;
            InitializeComponent();
            ListarUsuarios();
            //  this.textBox1.Text = Svr(con);
        }

        private void Trabajador_Load(object sender, EventArgs e)
        {



        }

        public void ListarUsuarios()
        {
            
            conex.Listados(dgvEmpleados,"ListaEmpleados");
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
            SqlDataReader leere;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select IS_SRVROLEMEMBER ('sysadmin','Prueba12')";
            cmd.Connection = con.connect;

            leere = cmd.ExecuteReader();
            sert = Convert.ToString(leere.Read());


            return sert;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EditarTrabajador ET = new EditarTrabajador(conex,true);
            ET.BtnInsertar();
            ET.ShowDialog();
            ListarUsuarios();
            
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

            EditarTrabajador fp = new EditarTrabajador(conex,false);
            fp.DrEmpleados = drow;
            fp.Combo(false);
            fp.BtnActualizar();
            fp.ShowDialog();
            ListarUsuarios();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          ReporteEmpleados ri = new ReporteEmpleados();
          ri.ShowDialog();
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgvEmpleados.SelectedRows;

            if (rowCollection.Count == 0)
            {
                MessageBox.Show(this, "ERROR, debe seleccionar una fila de la tabla para poder editar", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow gridRow = rowCollection[0];
            DataRow drow = ((DataRowView)gridRow.DataBoundItem).Row;

            EditarTrabajador fp = new EditarTrabajador(conex,false);
            fp.DrEmpleados = drow;
            fp.Combo(false);
            fp.BtnEliminar();
            fp.ShowDialog();
            ListarUsuarios();
        }

        public void buttonsAccesoLector()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;
            btnNuevo.Enabled = false;
            btnNuevo.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text!= "")
            //{
            //    foreach(DataGridViewRow ro in dgvEmpleados.Rows)
            //    {
            //        ro.Visible = false;
            //    }

            //    foreach (DataGridViewRow row in dgvEmpleados.Rows)
            //    {

            //        foreach (DataGridViewCell c in row.Cells)
            //        {
            //            if((c.Value.ToString().ToUpper()).IndexOf(textBox1.Text.ToUpper()) == 0){
            //                row.Visible = true;
            //                break;
            //            }
            //        }


            //    }
            //}
            //else
            //{
            //    ListarUsuarios();
            //}


        }
    }
}
