using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tugagenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmResetarPass reset = new frmResetarPass();
            reset.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            frmcomeco bemvindo = new frmcomeco();
            bemvindo.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            SqlConnection db = new SqlConnection(Program.MyConnectionString);
            SqlDataReader reader;

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                cmd.CommandText = "select * from Registo where Username=@Username and Password=@Password ";
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    reader = cmd.ExecuteReader();
                    if (reader.HasRows) 
                    {
                    reader.Read();
                        MessageBox.Show($"Login Com Sucesso\nBem Vindo de Volta {reader["Username"].ToString()}");
                        
                        Close();
                        frmFas fas = new frmFas();
                        fas.Show();
                    }
                    else
                    {
                        MessageBox.Show("Não Foi encontrado Username Ou Password no login", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                   
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível fazer o login");
            }
           
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
                      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHidePassword.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnPassword.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
