using Main.DAO;
using MetroFramework.Forms;
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
    public partial class Clientes : Form
            
    {

        private Conexion conex;

        private DataRow drCliente
            ;
        public Clientes(Conexion con,Boolean obj)
        {
            this.conex = con;
            InitializeComponent();
            ComboCliente(obj);
        }


        public SqlParameter[] parametro()
        {
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@Id_Cliente", SqlDbType.Int);
            param[0].Value = int.Parse(txtId.Text);
            param[1] = new SqlParameter("@PrimNombre", SqlDbType.NVarChar);
            param[1].Value = txtPrimerNombre.Text;
            param[2] = new SqlParameter("@SegundNombre", SqlDbType.NVarChar);
            param[2].Value = txtSegundoNombre.Text;
            param[3] = new SqlParameter("@PrimApellid", SqlDbType.NVarChar);
            param[3].Value = txtPrimerA.Text;
            param[4] = new SqlParameter("@SegundApellid", SqlDbType.NVarChar);
            param[4].Value = txtSegundoA.Text;
            param[5] = new SqlParameter("@Email", SqlDbType.NVarChar);
            param[5].Value = txtEmail.Text;
            param[6] = new SqlParameter("@Telefono", SqlDbType.Char);
            param[6].Value = mskTele.Text;
            param[7] = new SqlParameter("@Celular", SqlDbType.Char);
            param[7].Value = mskCelular.Text;
            param[8] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
            param[8].Value = txtDireccion.Text;
            param[9] = new SqlParameter("@IdMunic", SqlDbType.Int);
            param[9].Value = comboBox1.SelectedValue;
            
            return param;
        }

        public SqlParameter[] parametroNuevo()
        {
            SqlParameter[] param = new SqlParameter[9];

            
            param[0] = new SqlParameter("@PrimNombre", SqlDbType.NVarChar);
            param[0].Value = txtPrimerNombre.Text;
            param[1] = new SqlParameter("@SegundNombre", SqlDbType.NVarChar);
            param[1].Value = txtSegundoNombre.Text;
            param[2] = new SqlParameter("@PrimApellid", SqlDbType.NVarChar);
            param[2].Value = txtPrimerA.Text;
            param[3] = new SqlParameter("@SegundApellid", SqlDbType.NVarChar);
            param[3].Value = txtSegundoA.Text;
            param[4] = new SqlParameter("@Email", SqlDbType.NVarChar);
            param[4].Value = txtEmail.Text;
            param[5] = new SqlParameter("@Telefono", SqlDbType.Char);
            param[5].Value = mskTele.Text;
            param[6] = new SqlParameter("@Celular", SqlDbType.Char);
            param[6].Value = mskCelular.Text;
            param[7] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
            param[7].Value = txtDireccion.Text;
            param[8] = new SqlParameter("@IdMunic", SqlDbType.Int);
            param[8].Value = comboBox1.SelectedValue;

            return param;
        }

        public DataRow DrCliente
        {
            set
            {
                drCliente = value;
                txtId.Text = drCliente["Id_Cliente"].ToString();
                txtPrimerNombre.Text = drCliente["Primer_NombreC"].ToString();
                txtSegundoNombre.Text = drCliente["Segundo_NombreC"].ToString();
                txtPrimerA.Text = drCliente["Primer_Apellido"].ToString();
                txtSegundoA.Text = drCliente["Segundo_Apellido"].ToString();
                txtEmail.Text = drCliente["Email"].ToString();
                mskTele.Text = drCliente["Telefono"].ToString();
                mskCelular.Text = drCliente["Celular"].ToString();
                txtDireccion.Text = drCliente["Direccion"].ToString();
                ObtenerCliente(drCliente["Id_Munic"].ToString()); 
            }
        }


        public void BtnActualizar()
        {
            txtId.Enabled = false;
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;

        }

        public void BtnEliminar()
        {
            txtId.Enabled = false;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnInsertar.Enabled = false;
            btnInsertar.Visible = false;
            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
            txtPrimerNombre.Enabled = false;
            txtSegundoNombre.Enabled = false;
            txtPrimerA.Enabled = false;
            txtSegundoA.Enabled = false;
            txtEmail.Enabled = false;
            mskCelular.Enabled = false;
            mskTele.Enabled = false;
            txtDireccion.Enabled = false;
           

        }

        public void BtnInsertar()
        {
            txtId.Enabled = false;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnelim.Enabled = false;
            btnelim.Visible = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerNombre.Text = String.Empty;
            txtSegundoNombre.Text = String.Empty;
            txtPrimerA.Text = String.Empty;
            txtSegundoA.Text = String.Empty;
            txtEmail.Text = String.Empty;
            mskCelular.Text = String.Empty;
            mskTele.Text = String.Empty;
            txtDireccion.Text = String.Empty;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void ComboCliente(Boolean bolo)
        {


            if (bolo)
            {

                SqlCommand cmdn = new SqlCommand
                {
                    Connection = conex.connect,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "ListarMunicipios"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdn);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);
                comboBox1.DataSource = dataTable;
                comboBox1.ValueMember = "Id_Munic";
                comboBox1.DisplayMember = "NombreMun";

                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataTable.Rows)
                {
                    collection.Add(Convert.ToString(dr["NombreMun"]));
                }

                comboBox1.AutoCompleteCustomSource = collection;
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            




        }

        public void ObtenerCliente(String id)
        {



            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            SqlCommand cmdo = new SqlCommand();
            cmdo.CommandType = CommandType.StoredProcedure;
            cmdo.CommandText = "ObtenerMuni";
            cmdo.Connection = conex.connect;
            cmdo.Parameters.AddRange(param);
            SqlDataAdapter dat = new SqlDataAdapter(cmdo);
            DataTable dtable = new DataTable();
            dat.Fill(dtable);
            comboBox1.DataSource = dtable;
            comboBox1.ValueMember = "Id_Munic";
            comboBox1.DisplayMember = "NombreMun";

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (email_bien_escrito(txtEmail.Text)) {
                conex.editados(parametro(), "ActualizacionCliente"); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email mal Escrito");
                txtEmail.Text = string.Empty;
            }
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (email_bien_escrito(txtEmail.Text))
            {
                conex.Insertados(parametroNuevo(), "NuevoCliente");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email mal escrito");
                txtEmail.Text = string.Empty;
            }
           
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            conex.eliminar(int.Parse(txtId.Text), "EliminarCliente", "@ID");
            this.Hide();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtPrimerNombre.Text = string.Empty;
            txtSegundoNombre.Text = string.Empty;
            txtPrimerA.Text = string.Empty;
            txtSegundoA.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mskTele.Text = string.Empty;
            mskCelular.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            
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

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
