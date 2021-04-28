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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetarPass reset = new ResetarPass();
            reset.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            comeco bemvindo = new comeco();
            bemvindo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string connString = ConfigurationManager.ConnectionStrings["tugagenda"].ConnectionString;
            SqlConnection db = new SqlConnection(connString);
            SqlDataReader reader;

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
               

                cmd.CommandText = "select * from Registo where Username=@Username and Password=@Password ";
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {        
                        MessageBox.Show("Login Com Sucesso");
                        Close();
                        Fas fas = new Fas();
                        fas.Show();
                    }
                    else
                    {
                        MessageBox.Show("Erro: Não Foi encontrado Username Ou Password no login"); 
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível fazer o login");
            }
           
            
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
