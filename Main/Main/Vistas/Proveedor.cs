using Main.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Vistas
{
    public partial class Proveedor : Form
    {

        private Conexion cone;

        private DataRow Drproveedor;
        public Proveedor(Conexion con,Boolean boo)
        {
            this.cone = con;
            InitializeComponent();
            Combo(boo);
        }


        public DataRow DRPROVEEDOR
        {
            set
            {
                Drproveedor = value;
                txtID.Text = Drproveedor["Id_Proveedor"].ToString();
                txtNombre.Text = Drproveedor["Nombre_Proveedor"].ToString();
                mskCelular.Text = Drproveedor["Celular"].ToString();
                txtDireccion.Text = Drproveedor["Direccion"].ToString();
                mskTelefono.Text = Drproveedor["Telefono"].ToString();
                txtCorreo.Text = Drproveedor["Correo"].ToString();
                Obtener(Drproveedor["Id_Munic"].ToString());
            }
        }




        public SqlParameter[] parametroNuevo()
        {
            SqlParameter[] param = new SqlParameter[7];


            param[0] = new SqlParameter("@Id", SqlDbType.Char);
            param[0].Value = txtID.Text;
            param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            param[1].Value = txtNombre.Text;
            param[2] = new SqlParameter("@Celular", SqlDbType.Char);
            param[2].Value = mskCelular.Text;
            param[3] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
            param[3].Value = txtDireccion.Text;
            param[4] = new SqlParameter("@Telefono", SqlDbType.Char);
            param[4].Value = mskTelefono.Text;
            param[5] = new SqlParameter("@Correo", SqlDbType.NVarChar);
            param[5].Value = txtCorreo.Text;
            param[6] = new SqlParameter("@Id_Munic", SqlDbType.Int);
            param[6].Value = cmbMuni.SelectedValue;
            

            return param;
        }


        public void btnNuevaP()
        {
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;
        }

        public void btnEliminarP()
        {
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
        }

        public void btnEditarP()
        {
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            mskCelular.Text = "";
        }


        public void Combo(Boolean bolo)
        {


            if (bolo)
            {

                SqlCommand cmd = new SqlCommand
                {
                    Connection = cone.connect,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "ListarMunicipios"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);
                cmbMuni.DataSource = dataTable;
                cmbMuni.ValueMember = "Id_Munic";
                cmbMuni.DisplayMember = "NombreMun";

                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataTable.Rows)
                {
                    collection.Add(Convert.ToString(dr["NombreMun"]));
                }

                cmbMuni.AutoCompleteCustomSource = collection;
                cmbMuni.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbMuni.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            else { }




        }

        public void Obtener(String id)
        {



            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            SqlCommand cmdo = new SqlCommand();
            cmdo.CommandType = CommandType.StoredProcedure;
            cmdo.CommandText = "ObtenerMuni";
            cmdo.Connection = cone.connect;
            cmdo.Parameters.AddRange(param);
            SqlDataAdapter dat = new SqlDataAdapter(cmdo);
            DataTable dtable = new DataTable();
            dat.Fill(dtable);
            cmbMuni.DataSource = dtable;
            cmbMuni.ValueMember = "Id_Munic";
            cmbMuni.DisplayMember = "NombreMun";


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (email_bien_escrito(txtCorreo.Text))
            {
                cone.Insertados(parametroNuevo(), "NuevoProveedor");
                this.Hide();
            }
            else
                MessageBox.Show("Correo Mal escrito");
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            cone.eliminar(int.Parse(txtID.Text), "EliminarProveedor", "@ID");
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (email_bien_escrito(txtCorreo.Text))
            {
                cone.editados(parametroNuevo(), "ActualizacionProveedor");
                this.Hide();
            }
            else
                MessageBox.Show("Correo Mal escrito");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void cmbMuni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
