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
    public partial class EditarTrabajador : Form
    {



        private Conexion conex;

        private DataRow drEmpleados;

        public EditarTrabajador(Conexion cone, Boolean obt)
        {
            this.conex = cone;
            InitializeComponent();
            Combo(obt);




        }

        public EditarTrabajador()
        {

        }
        public SqlParameter[] parametro()
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

        public SqlParameter[] EditarEmpleadosParam()
        {

            SqlParameter[] param = new SqlParameter[10];


            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = txtId.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {    
                    conex.Insertados(parametro(), "NuevoEmpleado");
                    this.Hide();
        }







        public DataRow DrEmpleados
        {
            set
            {
                drEmpleados = value;
                txtId.Text = drEmpleados["Id_Empleados"].ToString();
                txtPrimerNombre.Text = drEmpleados["Primer_Nombre"].ToString();
                txtSegundoNombre.Text = drEmpleados["Segundo_Nombre"].ToString();
                txtPrimerA.Text = drEmpleados["Primer_Apellido"].ToString();
                txtSegundoA.Text = drEmpleados["Segundo_Apellido"].ToString();
                txtEmail.Text = drEmpleados["Email"].ToString();
                mskCelular.Text = drEmpleados["Celular"].ToString();
                mskTele.Text = drEmpleados["Telefono"].ToString();
                txtDireccion.Text = drEmpleados["Direccion"].ToString();
                Obtener(drEmpleados["Id_Munic"].ToString());
            }
        }

        public void DrEmpleadosMuni(string Muni)
        {

            comboBox1.Text = Muni;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
          
             conex.editados(EditarEmpleadosParam(), "ActualizacionEmpleado");
                this.Hide();
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
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
            comboBox1.Enabled = false;

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

        private void EditarTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Municipios muni = new Municipios(conex);

            muni.ShowDialog();
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            if (email_bien_escrito(txtEmail.Text))
            {
                conex.eliminar(int.Parse(txtId.Text), "EliminarEmpleado", "@ID");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email mal Escrito");
                txtEmail.Text = string.Empty;
            }


        }

        public void Combo(Boolean bolo)
        {


            if (bolo) {

                SqlCommand cmd = new SqlCommand
                {
                    Connection = conex.connect,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "ListarMunicipios"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
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
            cmdo.Connection = conex.connect;
            cmdo.Parameters.AddRange(param);
            SqlDataAdapter dat = new SqlDataAdapter(cmdo);
            DataTable dtable = new DataTable();
            dat.Fill(dtable);
            comboBox1.DataSource = dtable;
            comboBox1.ValueMember = "Id_Munic";
            comboBox1.DisplayMember = "NombreMun";


        }


        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public bool ValidarCamposvacios(string Cadena)
        {
            bool flag = false;

            foreach (Char caracter in Cadena)
            {
                if (char.IsDigit(caracter))
                {
                    flag = true;
                    break;
                }

            }
            return flag;

        }
        public bool ValidarCadenaNumeros(String Cadena)
        {
            bool flag2 = false;

            foreach (Char caracter in Cadena)
            {
                if (char.IsLetter(caracter))
                {
                    flag2 = true;
                    break;
                }

            }
            return flag2;
        }

       
        
        

        private void txtPrimerNombre_Validating(object sender, CancelEventArgs e)
        {



            if (txtPrimerNombre.Text.Equals("") || ValidarCamposvacios(txtPrimerNombre.Text))
            {
                errorProvider1.SetError(txtPrimerNombre, "El campo esta vacio o Ingreso un numero");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void EditarTrabajador_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtSegundoNombre_Validating(object sender, CancelEventArgs e)
        {
            if (ValidarCamposvacios(txtSegundoNombre.Text))
            {
                errorProvider1.SetError(txtSegundoNombre, "Ingreso un numero");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPrimerA_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrimerA.Text.Equals("") || ValidarCamposvacios(txtPrimerA.Text))
            {
                errorProvider1.SetError(txtPrimerA, "El campo esta vacio o Ingreso un numero");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSegundoA_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (email_bien_escrito(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "El campo esta vacio o El Email no es correcto");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void mskCelular_Validating(object sender, CancelEventArgs e)
        {
            if (mskCelular.Text.Equals("") )
            {
                errorProvider1.SetError(mskCelular, "El campo esta vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {

            if (txtDireccion.Text.Equals("")  )
            {
                errorProvider1.SetError(txtDireccion, "El campo esta vacio ");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSegundoA_Validating(object sender, CancelEventArgs e)
        {
            if (ValidarCamposvacios(txtSegundoA.Text))
            {
                errorProvider1.SetError(txtSegundoA, "Ingreso un numero");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
