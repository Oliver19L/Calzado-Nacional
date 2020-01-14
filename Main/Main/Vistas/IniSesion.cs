using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Main.DAO;
using System.Data.SqlClient;

namespace Main
{
    public partial class IniSesion : Form
    {
        
        int cont = 3;
        
        Conexion con;
        Principal princi;
        BackgroundWorker bg = new BackgroundWorker();
        
       
        public IniSesion()
        {
            
            InitializeComponent();
         
        
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Blue;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text =="")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Blue;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void IniSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IniSesion_Load(object sender, EventArgs e)
        {
          
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int progreso = 0;
            progressBar1.ForeColor = Color.SkyBlue;
            for (int i = 0; i <= 100; i++)
            {
                progreso++;
                Thread.Sleep(50);
                bg.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Style = ProgressBarStyle.Continuous;

            if (e.ProgressPercentage > 100)
            {
                label2.Text = "100%";
                progressBar1.Value = progressBar1.Maximum;
            }
            else
            {
                label2.Text = Convert.ToString(e.ProgressPercentage) + "%";
                progressBar1.Value = e.ProgressPercentage;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            
            princi = new Principal(con);
            
            princi.Show();
            this.Hide();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

           
            Cursor.Current = Cursors.WaitCursor;
            this.progressBar1.ForeColor = Color.SkyBlue;

            con = new Conexion(txtUsuario.Text, txtPass.Text);
           // int result = con.Autentificacion(txtUsuario.Text,txtPass.Text);
            //MessageBox.Show(result.ToString());


            if (this.con.connect.State == ConnectionState.Open)
            {
                
                bg.WorkerReportsProgress = true;
                bg.ProgressChanged += backgroundWorker1_ProgressChanged;
                bg.DoWork += backgroundWorker1_DoWork;
                bg.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
                bg.RunWorkerAsync();
                label2.Visible = true;
                progressBar1.Visible = true;
               


            }
            else
            {
                Cursor.Current = Cursors.Default;
                --cont;
                MessageBox.Show("Error:Usuario o Contraseña incorrecta", cont + "Intentos Restantes");
                if (cont == 0)
                {
                    cont = 3;
                    btnAcceder.Enabled = false;
                    Thread.Sleep(3000);
                    btnAcceder.Enabled = true;
                }
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Cursor.Current = Cursors.WaitCursor;
                this.progressBar1.ForeColor = Color.SkyBlue;

                con = new Conexion(txtUsuario.Text, txtPass.Text);
                // int result = con.Autentificacion(txtUsuario.Text,txtPass.Text);
                //MessageBox.Show(result.ToString());


                if (this.con.connect.State == ConnectionState.Open)
                {

                    bg.WorkerReportsProgress = true;
                    bg.ProgressChanged += backgroundWorker1_ProgressChanged;
                    bg.DoWork += backgroundWorker1_DoWork;
                    bg.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
                    bg.RunWorkerAsync();
                    label2.Visible = true;
                    progressBar1.Visible = true;



                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    --cont;
                    MessageBox.Show("Error:Usuario o Contraseña incorrecta", cont + "Intentos Restantes");
                    if (cont == 0)
                    {
                        cont = 3;
                        btnAcceder.Enabled = false;
                        Thread.Sleep(3000);
                        btnAcceder.Enabled = true;
                    }
                }
            }
        
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPass.Focus();
            }
        }
    }


}

