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
          
                
        }

        DataTable dt = new DataTable("Filmes");
        private void frmFilmes_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from filmes", db);
                da.Fill(dt);
                dgvFilmes.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não existe dados registados com este nome.");
            }
        }

        private void txtFilmes_TextChanged(object sender, EventArgs e)
        {

        }

        
        
       
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("nome like '%{0}%'", txtFilmes.Text);           
            dgvFilmes.DataSource = dv.ToTable();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select nome from Filmes where nome = '" + txtFilmes.Text + "' ", db);
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Não existe nenhum filme com essa correspondencia");
            }
        }

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFilmes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnPesquisar.PerformClick();
            }    
        }
    }
}
