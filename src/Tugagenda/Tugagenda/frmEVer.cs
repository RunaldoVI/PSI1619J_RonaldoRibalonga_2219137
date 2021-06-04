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
    public partial class frmEVer : Form
    {
        public frmEVer()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = db;

                cmd.CommandText = "insert into EstouVer (Nome, Temporada, Episodio) values (@Nome, @Temporada, @Episodio)";
                cmd.Parameters.AddWithValue("@Nome", cbNome.Text);
                cmd.Parameters.AddWithValue("@Temporada", txtTemporada.Text);
                cmd.Parameters.AddWithValue("@Episodio", txtEpisodio.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Adicionado Com Sucesso");
                Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi adicionar a sua serie. ");
            }
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EVer_Load(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Nome from Series";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbNome.Items.Add(dr["Nome"].ToString());   
            }
            db.Close();
        }
    }
}
