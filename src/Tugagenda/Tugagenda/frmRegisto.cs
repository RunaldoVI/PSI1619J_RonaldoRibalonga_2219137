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
using System.Text.RegularExpressions;

namespace Tugagenda
{
    public partial class frmRegisto : Form
    {
        public frmRegisto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {

            SqlConnection db = new SqlConnection(Program.MyConnectionString);

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();
               
                cmd.Connection = db;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string cpassword = txtCPassword.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);

                if (match.Success)
                {
                    if(password.Length >= 8)
                      {
                        if (password.Where(char.IsUpper).Count() >= 1 && cpassword.Where(char.IsUpper).Count() >= 1)
                        {
                            if (password.Where(char.IsLower).Count() >= 1 && cpassword.Where(char.IsLower).Count() >= 1)
                            {
                                if (password.Where(char.IsDigit).Count() >= 1 && cpassword.Where(char.IsDigit).Count() >= 1)
                                {
                                    if (password.Length <= 16 && cpassword.Length <= 16)
                                    {
                                        if (txtPassword.Text == txtCPassword.Text)
                                        {
                                            cmd.CommandText = "insert into Registo (Username, Password, Email) values (@Username, @Password, @Email)";
                                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                                            cmd.ExecuteNonQuery();
                                            MessageBox.Show("Registado com sucesso");
                                            Close();
                                            frmLogin login = new frmLogin();
                                            login.Show();
                                        }

                                        else
                                        {
                                            MessageBox.Show("Password não coincide!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("A sua password tem mais que 16 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("A sua password tem de ter 1 numero pelo menos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("A sua password deve conter pelo menos 1 caracter e letra pequena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("A sua password tem de ter pelo menos 1 caracter em letra grande", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("A sua password não tem os minimos 8 caraceteres ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível registar ");
            }
            
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Close();
            frmcomeco bemvindo = new frmcomeco();
            bemvindo.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
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

        private void btn1Password_Click(object sender, EventArgs e)
        {
            if (txtCPassword.PasswordChar == '*')
            {
                btn1HidePassword.BringToFront();
                txtCPassword.PasswordChar = '\0';
            }
        }

        private void btn1HidePassword_Click(object sender, EventArgs e)
        {
            if (txtCPassword.PasswordChar == '\0')
            {
                btn1Password.BringToFront();
                txtCPassword.PasswordChar = '*';
            }
        }

        private void frmRegisto_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
