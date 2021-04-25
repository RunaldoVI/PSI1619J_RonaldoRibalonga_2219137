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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();

            /*
            string connString = ConfigurationManager.ConnectionStrings["tugagenda"].ConnectionString;
            SqlConnection db = new SqlConnection(connString);

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;

                cmd.CommandText = "insert into registro (Username, Password, Email) values (@Username, @Password, @Email)";
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.Parameters.AddWithValue("@Email", textBox3.Text);

                DialogResult verificar = MessageBox.Show("Pretende se Registrar?", "Registrar?", MessageBoxButtons.OKCancel);

                if (verificar == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adicionado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível adicionar ");
            }
            Close();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
