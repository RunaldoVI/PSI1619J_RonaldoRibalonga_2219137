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
        public int id { get; set; }
        public string nome { get; set; }
        public int idUser { get; set; }

        public string idNome { get; set; }


        public frmFilmes()
        {
            InitializeComponent();
        }
        private void frmFilmes_Load(object sender, EventArgs e)
        {
            
            idUser = Program.logUser.IDRegisto;
            idNome = Program.logUser.Username;

            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();

                var cmd = new SqlCommand("Select * from Filmes", db);
                var rdr = cmd.ExecuteReader();

                var datatable = new DataTable("Filmes");
                datatable.Load(rdr, LoadOption.PreserveChanges);

                dgvFilmes.DataSource = datatable;
                javi();
                EstouAVer();
                QueroVer();

            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
            db.Close();
        }
        public void javi()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Ja Vi";
            btn.Name = "JaVi";
            btn.Text = "Ja Vi";
            btn.UseColumnTextForButtonValue = true;
            dgvFilmes.Columns.Add(btn);

        }
        public void QueroVer()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Quero Ver";
            btn.Name = "QueroVer";
            btn.Text = "Quero Ver";
            btn.UseColumnTextForButtonValue = true;
            dgvFilmes.Columns.Add(btn);
        }
        public void EstouAVer()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Estou a Ver";
            btn.Name = "EstouaVer";
            btn.Text = "Estou a Ver";
            btn.UseColumnTextForButtonValue = true;
            dgvFilmes.Columns.Add(btn);
        }
        private void txtFilmes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnScrum_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFAdicionar>().Count() > 0)
            {
                Application.OpenForms.OfType<frmFAdicionar>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var adicionar = new frmFAdicionar();

                adicionar.ShowDialog();
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();


                var cmd = new SqlCommand($"Select * from Filmes where Nome like '%{txtFilmes.Text}%'", db);


                var rdr = cmd.ExecuteReader();

                var datatable = new DataTable("Filmes");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["Filmes"]);
                dgvFilmes.DataSource = dataset.Tables["Filmes"];

                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não existe dados registados com este nome.");
            }
        }




        private void txtFilmes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btnPesquisar_Click(this, EventArgs.Empty);
            }
        }

        private void dgvFilmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                DialogResult verificar = MessageBox.Show("Pretende adicionar a lista de ja visto?", "Adicionar?", MessageBoxButtons.OKCancel);
                db.Open();
                try
                {
                    if (verificar == DialogResult.OK)
                    {
                        int id = int.Parse(dgvFilmes.Rows[dgvFilmes.SelectedCells[0].RowIndex].Cells[3].Value.ToString());
                        string nome = dgvFilmes.Rows[dgvFilmes.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                        SqlCommand cmdV = new SqlCommand();
                        cmdV.CommandText = "select Visto,AVer,QuerVer from HistoricoF where IDRegisto = @idUser and FilmeID = @IDFilme";
                        cmdV.Parameters.AddWithValue("@idUser", idUser);
                        cmdV.Parameters.AddWithValue("@IDFilme", id);
                        cmdV.Connection = db;
                        DataTable dt = new DataTable();
                        dt.Load(cmdV.ExecuteReader());
                        if (dt.Rows.Count >= 1)
                        {
                            DialogResult check = MessageBox.Show("A serie ja se encontra ocupada deseja atualizar para ja visto?", "Atualizar?", MessageBoxButtons.OKCancel);
                            if (check == DialogResult.OK)
                            {
                                SqlCommand cmdC = new SqlCommand();
                                DataGridViewRow row = this.dgvFilmes.Rows[e.RowIndex];
                                cmdC.Connection = db;
                                cmdC.CommandText = "update HistoricoS set Visto = 1 , QuerVer = 0, AVer = 0, where IDRegisto = @idUser and FilmeID = @id";
                                cmdC.Parameters.AddWithValue("@idUser", idUser);
                                cmdC.Parameters.AddWithValue("@IDSerie", id);
                                cmdC.ExecuteNonQuery();
                            }

                        }
                        else
                        {

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = db;
                            cmd.CommandText = "insert into HistoricoF (FilmeID,IDRegisto,Visto,FilmeNome,Username) values (@id,@idUser,1,@Nome,@Username)";
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@idUser", idUser);
                            cmd.Parameters.AddWithValue("@Username", idNome);
                            cmd.Parameters.AddWithValue("@Nome", nome);
                            cmd.ExecuteNonQuery();
                            db.Close();




                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Não foi possível adicionar!");
                }

            }

            else if (e.ColumnIndex == 1)
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                DialogResult verificar = MessageBox.Show("Pretende adicionar a lista de a ver?", "Adicionar?", MessageBoxButtons.OKCancel);
                db.Open();
                try
                {
                    if (verificar == DialogResult.OK)
                    {
                        int id = int.Parse(dgvFilmes.Rows[dgvFilmes.SelectedCells[0].RowIndex].Cells[3].Value.ToString());
                        string nome = dgvFilmes.Rows[dgvFilmes.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                        SqlCommand cmdV = new SqlCommand();
                        cmdV.CommandText = "select Visto,AVer,QuerVer from HistoricoF where IDRegisto = @idUser and FilmeID = @IDFilme";
                        cmdV.Parameters.AddWithValue("@idUser", idUser);
                        cmdV.Parameters.AddWithValue("@IDFilme", id);
                        cmdV.Connection = db;
                        DataTable dt = new DataTable();
                        dt.Load(cmdV.ExecuteReader());
                        if (dt.Rows.Count >= 1)
                        {
                            DialogResult check = MessageBox.Show("A serie ja se encontra ocupada deseja atualizar para ja visto?", "Atualizar?", MessageBoxButtons.OKCancel);
                            if (check == DialogResult.OK)
                            {
                                SqlCommand cmdC = new SqlCommand();
                                DataGridViewRow row = this.dgvFilmes.Rows[e.RowIndex];
                                cmdC.Connection = db;
                                cmdC.CommandText = "update HistoricoS set Visto = 0 , QuerVer = 0, AVer = 1, where IDRegisto = @idUser and FilmeID = @id";
                                cmdC.Parameters.AddWithValue("@idUser", idUser);
                                cmdC.Parameters.AddWithValue("@IDSerie", id);
                                cmdC.ExecuteNonQuery();
                            }

                        }
                        else
                        {

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = db;
                            cmd.CommandText = "insert into HistoricoF (FilmeID,IDRegisto,AVer,FilmeNome,Username) values (@id,@idUser,1,@Nome,@Username)";
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@idUser", idUser);
                            cmd.Parameters.AddWithValue("@Username", idNome);
                            cmd.Parameters.AddWithValue("@Nome", nome);
                            cmd.ExecuteNonQuery();
                            db.Close();




                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Não foi possível adicionar!");
                }
            }
            else if(e.ColumnIndex == 2)
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                DialogResult verificar = MessageBox.Show("Pretende adicionar a lista de ja visto?", "Adicionar?", MessageBoxButtons.OKCancel);
                db.Open();
                try
                {
                    if (verificar == DialogResult.OK)
                    {
                        int id = int.Parse(dgvFilmes.Rows[dgvFilmes.SelectedCells[0].RowIndex].Cells[3].Value.ToString());
                        string nome = dgvFilmes.Rows[dgvFilmes.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                        SqlCommand cmdV = new SqlCommand();
                        cmdV.CommandText = "select Visto,AVer,QuerVer from HistoricoF where IDRegisto = @idUser and FilmeID = @IDFilme";
                        cmdV.Parameters.AddWithValue("@idUser", idUser);
                        cmdV.Parameters.AddWithValue("@IDFilme", id);
                        cmdV.Connection = db;
                        DataTable dt = new DataTable();
                        dt.Load(cmdV.ExecuteReader());
                        if (dt.Rows.Count >= 1)
                        {
                            DialogResult check = MessageBox.Show("A serie ja se encontra ocupada deseja atualizar para ja visto?", "Atualizar?", MessageBoxButtons.OKCancel);
                            if (check == DialogResult.OK)
                            {
                                SqlCommand cmdC = new SqlCommand();
                                DataGridViewRow row = this.dgvFilmes.Rows[e.RowIndex];
                                cmdC.Connection = db;
                                cmdC.CommandText = "update HistoricoS set Visto = 1 , QuerVer = 1, AVer = 0, where IDRegisto = @idUser and FilmeID = @id";
                                cmdC.Parameters.AddWithValue("@idUser", idUser);
                                cmdC.Parameters.AddWithValue("@IDSerie", id);
                                cmdC.ExecuteNonQuery();
                            }

                        }
                        else
                        {

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = db;
                            cmd.CommandText = "insert into HistoricoF (FilmeID,IDRegisto,QuerVer,FilmeNome,Username) values (@id,@idUser,1,@Nome,@Username)";
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@idUser", idUser);
                            cmd.Parameters.AddWithValue("@Username", idNome);
                            cmd.Parameters.AddWithValue("@Nome", nome);
                            cmd.ExecuteNonQuery();
                            db.Close();




                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Não foi possível adicionar!");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFEditar>().Count() > 0)
            {
                Application.OpenForms.OfType<frmFEditar>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var editar = new frmFEditar();

                editar.ShowDialog();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFApagar>().Count() > 0)
            {
                Application.OpenForms.OfType<frmFApagar>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var apagar = new frmFApagar();

                apagar.ShowDialog();
            }
        }
    }
}
