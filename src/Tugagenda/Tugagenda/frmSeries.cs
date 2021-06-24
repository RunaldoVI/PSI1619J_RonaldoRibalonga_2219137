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
        public int idUser { get; set; }

        public string idNome { get; set; }

        int idT;


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
                javi();
                QueroVer();
                db.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

        }
        public void javi()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Ja Vi";
            btn.Name = "JaVi";
            btn.Text = "Ja Vi";
            btn.UseColumnTextForButtonValue = true;
            dgvSeries.Columns.Add(btn);

        }
        public void QueroVer()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Quero Ver";
            btn.Name = "QueroVer";
            btn.Text = "Quero Ver";
            btn.UseColumnTextForButtonValue = true;
            dgvSeries.Columns.Add(btn);
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
            if (Application.OpenForms.OfType<frmSAdicionar>().Count() > 0)
            {
                Application.OpenForms.OfType<frmSAdicionar>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var adicionar = new frmSAdicionar();

                adicionar.ShowDialog();
            }
        }


        private void dgvSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
            SqlConnection db = new SqlConnection(Program.MyConnectionString);
            if (Application.OpenForms.OfType<frmHistoricoSeries>().Count() > 0)
            {
                Application.OpenForms.OfType<frmHistoricoSeries>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                idUser = Program.logUser.IDRegisto;
                idNome = Program.logUser.Username;
                int id = int.Parse(dgvSeries.Rows[dgvSeries.SelectedCells[0].RowIndex].Cells[2].Value.ToString());
                string nome = dgvSeries.Rows[dgvSeries.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                string descricao = dgvSeries.Rows[dgvSeries.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                string imagem = dgvSeries.Rows[dgvSeries.SelectedCells[0].RowIndex].Cells[7].Value.ToString();
   
                db.Open();
                if (e.ColumnIndex == 0)
                {
                    DialogResult verificar = MessageBox.Show("Pretende adicionar a lista ja visto?", "Adicionar?", MessageBoxButtons.OKCancel);

                    if (verificar == DialogResult.OK)
                    {
                        SqlCommand cmdV = new SqlCommand();
                        cmdV.CommandText = "select Visto,AVer,QuerVer from HistoricoS where IDRegisto = @idUser and SerieID = @IDSerie";
                        cmdV.Parameters.AddWithValue("@idUser", idUser);
                        cmdV.Parameters.AddWithValue("@IDSerie", id);
                        cmdV.Connection = db;
                        DataTable dt = new DataTable();
                        dt.Load(cmdV.ExecuteReader());
                        if (dt.Rows.Count >= 1)
                        {
                            DialogResult check = MessageBox.Show("A serie ja se encontra ocupada deseja atualizar para ja visto?", "Atualizar?", MessageBoxButtons.OKCancel);
                            if(check == DialogResult.OK)
                            {
                                SqlCommand cmdC = new SqlCommand();
                                cmdC.Connection = db;                             
                                cmdC.CommandText = "update HistoricoS set Visto = 1 , QuerVer = 0, AVer = 0, Temporada = @Temporada where IDRegisto = @idUser and SerieID = @IDSerie";
                                cmdC.Parameters.AddWithValue("@idUser", idUser);
                                cmdC.Parameters.AddWithValue("@Temporada", idT);
                                cmdC.Parameters.AddWithValue("@IDSerie", id);
                                cmdC.ExecuteNonQuery();
                                db.Close();
                            }
                            else
                            {
                                Close();
                            }
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand();
                            DataGridViewRow row = this.dgvSeries.Rows[e.RowIndex];                         
                            cmd.Connection = db;
                            idT = int.Parse(row.Cells["Temporada"].Value.ToString());
                            cmd.CommandText = "insert into HistoricoS (SerieID,IDRegisto,Visto,Temporada,Username,SerieNome) values (@id,@idUser,1,@Temporada,@Username,@Nome)";
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@idUser", idUser);
                            cmd.Parameters.AddWithValue("@Temporada", idT);
                            cmd.Parameters.AddWithValue("@Username", idNome);
                            cmd.Parameters.AddWithValue("@Nome", nome);
                            cmd.ExecuteNonQuery();
                            db.Close();
                        }
                    }
                    
                }
                else if(e.ColumnIndex == 1)
                {
                    DialogResult verificar = MessageBox.Show("Pretende adicionar a lista quer ver?", "Adicionar?", MessageBoxButtons.OKCancel);

                    if (verificar == DialogResult.OK)
                    {
                        SqlCommand cmdV = new SqlCommand();
                        cmdV.CommandText = "select Visto,AVer,QuerVer from HistoricoS where IDRegisto = @idUser and SerieID = @IDSerie";
                        cmdV.Parameters.AddWithValue("@idUser", idUser);
                        cmdV.Parameters.AddWithValue("@IDSerie", id);
                        cmdV.Connection = db;
                        DataTable dt = new DataTable();
                        dt.Load(cmdV.ExecuteReader());
                        if (dt.Rows.Count >= 1)
                        {
                            DialogResult check = MessageBox.Show("A serie ja se encontra ocupada deseja atualizar para quer ver?", "Atualizar?", MessageBoxButtons.OKCancel);
                            if (check == DialogResult.OK)
                            {
                                SqlCommand cmdC = new SqlCommand();
                                cmdC.Connection = db;
                                cmdC.CommandText = "update HistoricoS set Visto = 0 , QuerVer = 1, AVer = 0, Temporada = NULL, Episodio = NULL where IDRegisto = @idUser and SerieID = @IDSerie";
                                cmdC.Parameters.AddWithValue("@idUser", idUser);
                                cmdC.Parameters.AddWithValue("@IDSerie", id);
                                cmdC.ExecuteNonQuery();
                                db.Close();
                            }
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand();
                            DataGridViewRow row = this.dgvSeries.Rows[e.RowIndex];
                            cmd.Connection = db;
                            cmd.CommandText = "insert into HistoricoS (SerieID,IDRegisto,QuerVer,Username,SerieNome) values (@id,@idUser,1,@Username,@Nome)";
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@idUser", idUser);
                            cmd.Parameters.AddWithValue("@Username", idNome);
                            cmd.Parameters.AddWithValue("@Nome", nome);
                            cmd.ExecuteNonQuery();
                            db.Close();                            
                        }
                    }
                   
                }
                else
                {
                    var historico = new frmHistoricoSeries(id, nome,descricao, imagem);
                    historico.MdiParent = this.ParentForm;
                    historico.Show();
                }
                
               

            }
        }

        private void txtSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btnPesquisar_Click(this, EventArgs.Empty);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSEditar>().Count() > 0)
            {
                Application.OpenForms.OfType<frmSEditar>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var editar = new frmSEditar();

                editar.ShowDialog();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSApagar>().Count() > 0)
            {
                Application.OpenForms.OfType<frmSApagar>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
               var apagar = new frmSApagar();

                apagar.ShowDialog();
            }
        }
    }
}
