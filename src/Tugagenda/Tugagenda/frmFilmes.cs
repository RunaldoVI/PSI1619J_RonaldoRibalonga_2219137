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
        private void frmFilmes_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();

                var cmd = new SqlCommand("Select * from Filmes", db);
                var rdr = cmd.ExecuteReader();

                var datatable = new DataTable("Filmes");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["Filmes"]);

                dgvFilmes.DataSource = dataset.Tables["Filmes"];
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
            db.Close();
        }

        private void txtFilmes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFilmescrum>().Count() > 0)
            {
                Application.OpenForms.OfType<frmFilmescrum>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var filmeadd = new frmFilmescrum();
                filmeadd.MdiParent = this.ParentForm;
                filmeadd.Show();
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();

                
                var cmd = new SqlCommand($"Select * from Filmes where nome like '%{txtFilmes.Text}%'", db);
                

                var rdr = cmd.ExecuteReader();

                var datatable = new DataTable("Filmes");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["Filmes"]);

                dgvFilmes.DataSource = dataset.Tables["Filmes"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não existe dados registados com este nome.");
            }
            db.Close();
        }

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFilmes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btnPesquisar_Click(this,EventArgs.Empty);
            }    
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFilmescrum>().Count() > 0)
            {
                Application.OpenForms.OfType<frmFilmescrum>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var filmeadd = new frmFilmescrum();
                filmeadd.MdiParent = this.ParentForm;
                filmeadd.Show();
               
            }
        }
    }
}
