using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tugagenda
{
    public partial class frmFilmes : Form
    {
        SqlConnection db = new SqlConnection(Program.MyConnectionString);
       

        public frmFilmes()
        {
            InitializeComponent();
            dados();
                
        }

        private void frmFilmes_Load(object sender, EventArgs e)
        {
        }

        private void txtFilmes_TextChanged(object sender, EventArgs e)
        {

        }

        public void dados()
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("select * from Filmes", db);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível registar ");
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
        }

    }
}
