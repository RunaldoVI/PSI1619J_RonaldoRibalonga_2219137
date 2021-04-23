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
    public partial class ResetarPass : Form
    {
        public ResetarPass()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["tugagenda"].ConnectionString;
            SqlConnection db = new SqlConnection(connString);

            try
            {
                db.Open();
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = db;

                cmdUpdate.CommandText = "update registro set Password = @Password where Username = @Username";
                cmdUpdate.Parameters.AddWithValue("@Username", textBox1.Text);
                cmdUpdate.Parameters.AddWithValue("@Password", textBox2.Text);

                
                //parametros

                DialogResult verificar = MessageBox.Show("Pretende editar?", "Editar?", MessageBoxButtons.OKCancel);

                if (verificar == DialogResult.OK)
                {
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("editado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível editar");
            }
        }
    }
}
