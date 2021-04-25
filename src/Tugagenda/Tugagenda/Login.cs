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
            Close();
            /*
            string connString = ConfigurationManager.ConnectionStrings["tugagenda"].ConnectionString;
            SqlConnection db = new SqlConnection(connString);

            try
            {
                db.Open();
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = db;

                cmdUpdate.CommandText = "select * from registro where Username=@Username and Password=@Password ";
                cmdUpdate.Parameters.AddWithValue("@Username", textBox1.Text);
                cmdUpdate.Parameters.AddWithValue("@Password", textBox2.Text);
                //parametros

                DialogResult verificar = MessageBox.Show("Pretende fazer o login?", "Login", MessageBoxButtons.OKCancel);

                if (verificar == DialogResult.OK)
                {
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Login Com Sucesso");
                    Anime anime = new Anime();
                    anime.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível fazer o login");
            }
           
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
