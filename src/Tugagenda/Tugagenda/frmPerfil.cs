using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tugagenda
{
    public partial class frmPerfil : Form
    {
        public int idUser { get; set; }

        public string idNome { get; set; }

        public string idPassword { get; set; }

        public string idEmail { get; set; }

        int idF;
        
        int idS;

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

                var cmd = new SqlCommand("select HistoricoS.SerieID,Series.Nome,HistoricoS.AVer,HistoricoS.QuerVer,HistoricoS.Visto,HistoricoS.Temporada,HistoricoS.Episodio,Series.Genero,HistoricoS.Username from Series join HistoricoS on Series.IDSerie = HistoricoS.SerieID where IDRegisto = @ID", db);
                cmd.Parameters.AddWithValue("@ID", idUser);
                var rdr = cmd.ExecuteReader(); 
                var datatable = new DataTable("HistoricoS");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["HistoricoS"]);
                dgvSeries.DataSource = dataset.Tables["HistoricoS"];
                ApagarS();
                var cmda = new SqlCommand("select HistoricoF.FilmeID,Filmes.Nome,HistoricoF.QuerVer,HistoricoF.AVer,HistoricoF.Visto,HistoricoF.Username from Filmes join HistoricoF on Filmes.IDFilme = HistoricoF.FilmeID where IDRegisto = @ID", db);
                cmda.Parameters.AddWithValue("@ID", idUser);
                var rdra = cmda.ExecuteReader();
                var datatabl = new DataTable("HistoricoF");
                var datase = new DataSet();
                datase.Tables.Add(datatabl);
                datase.Load(rdra, LoadOption.PreserveChanges, datase.Tables["HistoricoF"]);
                dgvFilmes.DataSource = datase.Tables["HistoricoF"];
                ApagarF();
                txtNome.Text = idNome;
                txtEmail.Text = idEmail;
                txtPassword.Text = idPassword;
                

                db.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
            }
        }
        public void ApagarS()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Apagar";
            btn.Name = "Apagar";
            btn.Text = "Apagar";
            btn.UseColumnTextForButtonValue = true;
            dgvSeries.Columns.Add(btn);
        }
        public void ApagarF()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Apagar";
            btn.Name = "Apagar";
            btn.Text = "Apagar";
            btn.UseColumnTextForButtonValue = true;
            dgvFilmes.Columns.Add(btn);
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
                btnHidden.BringToFront();
            }
            
        }

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);
            db.Open();
            if (e.ColumnIndex == 0)
            {
                DialogResult verificar = MessageBox.Show("Pretende eliminar da lista?", "Eliminar?", MessageBoxButtons.OKCancel);

                if (verificar == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand();
                    DataGridViewRow row = this.dgvFilmes.Rows[e.RowIndex];
                    idF = int.Parse(row.Cells["FilmeID"].Value.ToString());
                    cmd.CommandText = "delete from HistoricoF where IDRegisto = @idUser and FilmeID = @IDFilme";
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.Parameters.AddWithValue("@IDFilme", idF);
                    cmd.Connection = db;
                    cmd.ExecuteNonQuery();
                    var frm = new frmPerfil();
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Location = this.Location;
                    frm.MdiParent = this.ParentForm;
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nada foi alterado!");
                }

            }
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                btnShow.BringToFront();
            }
        }

        private void dgvSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);
            db.Open();
            if (e.ColumnIndex == 0)
            {
                DialogResult verificar = MessageBox.Show("Pretende eliminar da lista?", "Eliminar?", MessageBoxButtons.OKCancel);

                if (verificar == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand();
                    DataGridViewRow row = this.dgvSeries.Rows[e.RowIndex];
                    idS = int.Parse(row.Cells["SerieID"].Value.ToString());
                    cmd.CommandText = "delete from HistoricoS where IDRegisto = @idUser and SerieID = @IDSerie";
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.Parameters.AddWithValue("@IDSerie", idS);
                    cmd.Connection = db;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Nada foi alterado!");
                }

            }
        }
    }
}
