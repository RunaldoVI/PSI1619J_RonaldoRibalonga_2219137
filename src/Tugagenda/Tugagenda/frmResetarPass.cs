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
    public partial class frmResetarPass : Form
    {
        public frmResetarPass()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            SqlConnection db = new SqlConnection(Program.MyConnectionString);

            try
            {
                db.Open();
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = db;

                cmdUpdate.CommandText = "update Registo set Password = @Password where Username = @Username";
                cmdUpdate.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmdUpdate.Parameters.AddWithValue("@Password", txtPassword.Text);
                string password = txtPassword.Text;
                string cpassword = txtCPassword.Text;

                if (password.Length >= 8)
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
                                        DialogResult verificar = MessageBox.Show("Pretende editar a password?", "Editar?", MessageBoxButtons.OKCancel);

                                        if (verificar == DialogResult.OK)
                                        {
                                            cmdUpdate.ExecuteNonQuery();
                                            MessageBox.Show("editado com sucesso");
                                            Application.Restart();
                                        }
                                    }

                                    else
                                    {
                                        MessageBox.Show("Password não coincide!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("A sua password tem mais que 16 caracteres","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("A sua password não tem os minimos 8 caraceteres ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível editar");
            }
        }

        private void ResetarPass_Load(object sender, EventArgs e)
        {

        }

        private void btnHideNovaPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnNovaPassword.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnNovaPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHideNovaPassword.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnNCHidePassword_Click(object sender, EventArgs e)
        {
            if (txtCPassword.PasswordChar == '\0')
            {
                btnNCPassword.BringToFront();
                txtCPassword.PasswordChar = '*';
            }
        }

        private void btnNCPassword_Click(object sender, EventArgs e)
        {
            if (txtCPassword.PasswordChar == '*')
            {
                btnNCHidePassword.BringToFront();
                txtCPassword.PasswordChar = '\0';
            }
        }

        private void lblReset_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
