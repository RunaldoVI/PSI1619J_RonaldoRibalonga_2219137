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
    public partial class frmEpTemp : Form
    {

        public string tempo { get; set; }

        public int temporada { get; set; }
        public frmEpTemp(string _tempo, int _temporada)
        {
            tempo = $"Temporada:{_tempo}";
            temporada = _temporada;
            
            InitializeComponent();
        }

        private void frmEpTemp_Load(object sender, EventArgs e)
        {
            lblTemp.Text = tempo;    
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            SqlConnection db = new SqlConnection(Program.MyConnectionString);
            string TempID = "";
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "Select MAX(IDSerie) as 'IDSerie' from Series";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TempID = dr["IDSerie"].ToString();
                    }
                }
                cmd.Dispose();
                cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "insert into Temporada (Temporada,Episodios,SerieID) values (@Temporada, @Ep, @IDSerie);";
                cmd.Parameters.AddWithValue("@Temporada", temporada);
                cmd.Parameters.AddWithValue("@Ep", txtEp.Text);
                cmd.Parameters.AddWithValue("@IDSerie", TempID);
                cmd.ExecuteReader();


                MessageBox.Show("Adicionado com sucesso");
                db.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível registar ");
            }

        }
    }
}
