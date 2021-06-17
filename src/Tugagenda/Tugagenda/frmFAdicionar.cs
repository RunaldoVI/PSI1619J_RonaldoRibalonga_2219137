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
    public partial class frmFAdicionar : Form
    {
        public frmFAdicionar()
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
                SqlDataAdapter da;
                cmd.Connection = db;               
                if (txtNome.Text.Length == 0)
                {
                    MessageBox.Show($"O filme precisa de Nome", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    da = new SqlDataAdapter("select nome from Filmes where nome = '" + txtNome.Text + "' ", db);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("O nome ja está ser usado!");
                    }
                    else
                    {
                        if (TxtDescricao.Text.Length == 0)
                        {
                            MessageBox.Show("O filme precisa de uma descrição", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (txtGenero.Text.Length == 0)
                            {
                                MessageBox.Show("O filme precisa de um genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                cmd.CommandText = "insert into Filmes (Nome, Descricao, Genero, Imagem) values (@Nome, @Descricao, @Genero, @Imagem)";
                                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                                cmd.Parameters.AddWithValue("@Descricao", TxtDescricao.Text);
                                cmd.Parameters.AddWithValue("@Genero", txtGenero.Text);
                                cmd.Parameters.AddWithValue("@Imagem", txtImagem.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Adicionado com sucesso");
                                db.Close();
                                Close();

                            }
                        }
                    }
                }
          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível registar ");
            }
        }
        private void frmFilmescrum_Load(object sender, EventArgs e)
        {
           
        }

        private void frmFAdicionar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAdicionar.PerformClick();
            }
        }
    }
}
