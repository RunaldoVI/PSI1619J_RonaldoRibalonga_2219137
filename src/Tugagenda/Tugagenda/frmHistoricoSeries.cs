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

        string idT;

        string idE;
        public frmHistoricoSeries(int _id, string _nome)
        {
            id = _id;
            nome = _nome;
            InitializeComponent();
            
        }
        
        SqlConnection db = new SqlConnection(Program.MyConnectionString);

        private void frmHistoricoSeries_Load(object sender, EventArgs e)
        {
            lblNome.Text = nome;
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
                javi();
                EstouAVer();
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
        public void EstouAVer()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Estou a Ver";
            btn.Name = "EstouaVer";
            btn.Text = "Estou a Ver";
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

        private void dgvSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvSeries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult verificar = MessageBox.Show("Pretende adicionar a lista ja visto?", "Adicionar?", MessageBoxButtons.OKCancel);

                if (verificar == DialogResult.OK)
                {
                    DataGridViewRow row = this.dgvSeries.Rows[e.RowIndex];
                    idT = row.Cells["Temporada"].Value.ToString();
                    idE = row.Cells["Episodios"].Value.ToString();
                    db.Open();
                    SqlCommand cmd = new SqlCommand();                 
                    cmd.CommandText = "insert into HistoricoS (SerieID,IDRegisto,Visto,Temporada,Episodio,Username,SerieNome) values (@id,@idUser,1,@Temporada,@Episodio,@Username,@Nome)";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.Parameters.AddWithValue("@Temporada", idT);
                    cmd.Parameters.AddWithValue("@Episodio", idE);
                    cmd.Parameters.AddWithValue("@Username", idNome);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.ExecuteNonQuery();
                }
            }
            if (e.ColumnIndex == 1)
            {            
                    DialogResult verificar = MessageBox.Show("Pretende adicionar a lista Estou a ver?", "Adicionar?", MessageBoxButtons.OKCancel);

                    if (verificar == DialogResult.OK)
                    {
                    DataGridViewRow row = this.dgvSeries.Rows[e.RowIndex];
                    idT = row.Cells["Temporada"].Value.ToString();
                    idE = row.Cells["Episodios"].Value.ToString();
                    db.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "insert into HistoricoS (SerieID,IDRegisto,Visto,Temporada,Episodio,Username,SerieNome) values (@id,@idUser,1,@Temporada,@Episodio,@Username,@Nome)";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.Parameters.AddWithValue("@Temporada", idT);
                    cmd.Parameters.AddWithValue("@Episodio", idE);
                    cmd.Parameters.AddWithValue("@Username", idNome);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    var aVer = new frmSEstouAVer();
                    aVer.MdiParent = this.ParentForm;
                    aVer.Show();
                    cmd.ExecuteNonQuery();
                }
                
            }
            if (e.ColumnIndex == 2)
            {

            }
        }
    }
}
