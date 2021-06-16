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
    public partial class frmHistoricoSeries : Form
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idUser { get; set; }

        public string idNome { get; set; }

        public string descricao { get; set; }

        int idT;

        
        public frmHistoricoSeries(int _id, string _nome, string _descricao)
        {
            id = _id;
            nome = _nome;
            descricao = _descricao;
            InitializeComponent();
            
        }
        
        SqlConnection db = new SqlConnection(Program.MyConnectionString);

        private void frmHistoricoSeries_Load(object sender, EventArgs e)
        {
            lblNome.Text = nome;
            lbldescricao.Text = descricao;
            idUser = Program.logUser.IDRegisto;
            idNome = Program.logUser.Username;
            try
            {             
                db.Open();
                var cmd = new SqlCommand("Select * from Temporada where SerieID = @ID", db);
                cmd.Parameters.AddWithValue("@ID", id);
                var rdr = cmd.ExecuteReader();
                var datatable = new DataTable("Temporada");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["Temporada"]);
                dgvSeries.DataSource = dataset.Tables["Temporada"];              
                
                EstouAVer();
                db.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

    
        public void EstouAVer()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Estou a Ver";
            btn.Name = "EstouaVer";
            btn.Text = "Estou a Ver";
            btn.UseColumnTextForButtonValue = true;
            dgvSeries.Columns.Add(btn);
        }
      

        private void dgvSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvSeries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 0)
            {
               

                var aVer = new frmSEstouAVer();
                    
                DialogResult m = aVer.ShowDialog();

                if (m == DialogResult.OK)
                {
                    SqlCommand cmdv = new SqlCommand();
                    db.Open();
                    cmdv.CommandText = "select Visto,AVer,QuerVer from HistoricoS where IDRegisto = @idUser and SerieID = @IDSerie";
                    cmdv.Parameters.AddWithValue("@idUser", idUser);
                    cmdv.Parameters.AddWithValue("@IDSerie", id);
                    cmdv.Connection = db;
                    DataTable dt = new DataTable();
                    dt.Load(cmdv.ExecuteReader());
                    if (dt.Rows.Count >= 1)
                    {
                        DialogResult check = MessageBox.Show("A serie ja se encontra ocupada deseja atualizar para ja visto?", "Atualizar?", MessageBoxButtons.OKCancel);
                        if (check == DialogResult.OK)
                        {
                            SqlCommand cmdC = new SqlCommand();
                            DataGridViewRow row = this.dgvSeries.Rows[e.RowIndex];
                            idT = int.Parse(row.Cells["Temporada"].Value.ToString());
                            cmdC.Connection = db;
                            cmdC.CommandText = "update HistoricoS set Visto = 0 , QuerVer = 0, AVer = 1,Episodio = @EP, Temporada = @Temporada where IDRegisto = @idUser and SerieID = @IDSerie";
                            cmdC.Parameters.AddWithValue("@idUser", idUser);
                            cmdC.Parameters.AddWithValue("@EP", aVer.Ep);
                            cmdC.Parameters.AddWithValue("@Temporada", idT);
                            cmdC.Parameters.AddWithValue("@IDSerie", id);
                            cmdC.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        aVer.Close();
                        SqlCommand cmd = new SqlCommand();
                        DataGridViewRow row = this.dgvSeries.Rows[e.RowIndex];
                        idT = int.Parse(row.Cells["Temporada"].Value.ToString());
                        cmd.Connection = db;
                        cmd.CommandText = "insert into HistoricoS (SerieID,IDRegisto,AVer,Temporada,Episodio,Username,SerieNome) values (@id,@idUser,1,@Temporada,@Episodio,@Username,@Nome)";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@idUser", idUser);
                        cmd.Parameters.AddWithValue("@Temporada", idT);
                        cmd.Parameters.AddWithValue("@Episodio", aVer.Ep);
                        cmd.Parameters.AddWithValue("@Username", idNome);
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.ExecuteNonQuery();
                        db.Close();
                    }
                }
                                            
            }
           
        }
    }
}
