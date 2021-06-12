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
    public partial class frmPerfil : Form
    {
        public int idUser { get; set; }

        public string idNome { get; set; }

        public string idPassword { get; set; }

        public string idEmail { get; set; }
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            idUser = Program.logUser.IDRegisto;
            idNome = Program.logUser.Username;
            idPassword = Program.logUser.Password;
            idEmail = Program.logUser.Email;
            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();

                var cmd = new SqlCommand("select Series.Nome,HistoricoS.AVer,HistoricoS.QuerVer,HistoricoS.Visto,HistoricoS.Temporada,HistoricoS.Episodio,Series.Genero,HistoricoS.Username from Series join HistoricoS on Series.IDSerie = HistoricoS.SerieID where IDRegisto = @ID", db);
                cmd.Parameters.AddWithValue("@ID", idUser);
                var rdr = cmd.ExecuteReader(); 
                var datatable = new DataTable("HistoricoS");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["HistoricoS"]);
                dgvSeries.DataSource = dataset.Tables["HistoricoS"];

                var cmda = new SqlCommand("select Filmes.Nome,HistoricoF.QuerVer,HistoricoF.AVer,HistoricoF.Visto,HistoricoF.Username from Filmes join HistoricoF on Filmes.IDFilme = HistoricoF.FilmeID where IDRegisto = @ID", db);
                cmda.Parameters.AddWithValue("@ID", idUser);
                var rdra = cmda.ExecuteReader();
                var datatabl = new DataTable("HistoricoF");
                var datase = new DataSet();
                datase.Tables.Add(datatabl);
                datase.Load(rdra, LoadOption.PreserveChanges, datase.Tables["HistoricoF"]);
                dgvFilmes.DataSource = datase.Tables["HistoricoF"];
               
                txtNome.Text = idNome;
                txtEmail.Text = idEmail;
                txtPassword.Text = idPassword;
                

                db.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else if(txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
