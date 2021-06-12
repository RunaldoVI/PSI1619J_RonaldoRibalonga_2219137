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

        int idT;

        
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
                SqlCommand cmd = new SqlCommand();

                var aVer = new frmSEstouAVer();
                    
                    DialogResult m = aVer.ShowDialog();

                if (m == DialogResult.OK)
                {
                    SqlDataAdapter da;
                    da = new SqlDataAdapter("select IDSerie from HistoricoS where IDRegisto = @idUser", db);
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("A serie ja esta a ser ocupada!");
                    }
                    else
                    {
                        aVer.Close();
                        DataGridViewRow row = this.dgvSeries.Rows[e.RowIndex];
                        idT = int.Parse(row.Cells["Temporada"].Value.ToString());
                        db.Open();                                             
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
