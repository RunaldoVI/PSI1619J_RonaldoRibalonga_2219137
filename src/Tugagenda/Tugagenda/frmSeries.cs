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
    public partial class frmSeries : Form
    {
        public frmSeries()
        {
            InitializeComponent();
        }      
        private void frmSeries_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();

                var cmd = new SqlCommand("Select * from Series", db);
                var rdr = cmd.ExecuteReader();

                var datatable = new DataTable("Series");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["Series"]);
                dgvSeries.DataSource = dataset.Tables["Series"];
                db.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

        }    

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();


                var cmd = new SqlCommand($"Select * from Series where nome like '%{txtSeries.Text}%'", db);


                var rdr = cmd.ExecuteReader();

                var datatable = new DataTable("Series");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["Series"]);

                dgvSeries.DataSource = dataset.Tables["Series"];

                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não existe dados registados com este nome.");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void dgvSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btnPesquisar_Click(this, EventArgs.Empty);
            }
        }
    }
}
