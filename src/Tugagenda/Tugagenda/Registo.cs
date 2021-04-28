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
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            string connString = ConfigurationManager.ConnectionStrings["tugagenda"].ConnectionString;
            SqlConnection db = new SqlConnection(connString);

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                cmd.CommandText = "insert into Registo (Username, Password, Email) values (@Username, @Password, @Email)";
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.Parameters.AddWithValue("@Email", textBox3.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registado com sucesso");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível registar ");
            }
            Close();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
            comeco bemvindo = new comeco();
            bemvindo.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
