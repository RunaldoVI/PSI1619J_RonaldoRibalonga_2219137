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
    public partial class frmFilmescrum : Form
    {
        public frmFilmescrum()
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
                                cmd.CommandText = "insert into Filmes (Nome, Descricao, Genero) values (@Nome, @Descricao, @Genero)";
                                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                                cmd.Parameters.AddWithValue("@Descricao", TxtDescricao.Text);
                                cmd.Parameters.AddWithValue("@Genero", txtGenero.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Adicionado com sucesso");
                                db.Close();

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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            SqlConnection db = new SqlConnection(Program.MyConnectionString);

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();              
                cmd.Connection = db;           
                cmd.CommandText = "update Filmes set Nome = @Nome, Descricao=@Descricao, Genero=@Genero where Nome=@Nome";
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Descricao", TxtDescricao.Text);
                cmd.Parameters.AddWithValue("@Genero", txtGenero.Text);
                if(txtNomeAntigo.Text.Length ==0)
                {
                    MessageBox.Show("Nada foi alterado", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                if (txtNome.Text.Length == 0)
                {
                    MessageBox.Show("Nada foi alterado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (TxtDescricao.Text.Length == 0)
                    {
                        MessageBox.Show("Nada foi alterado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (TxtDescricao.Text.Length == 0)
                        {
                            MessageBox.Show("Nada foi alterado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Alterado com sucesso");
                            db.Close();
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

        private void rdbAdicionar_CheckedChanged(object sender, EventArgs e)
        {
            btnAdicionar.Visible = true;
            btnEditar.Visible = false;
            btnApagar.Visible = false;
            lblNomeAntigo.Visible = false;
            txtNomeAntigo.Visible = false;
            lblDescricao.Visible = true;
            lblGenero.Visible = true;
            lblNome.Visible = true;
            txtGenero.Visible = true;
            TxtDescricao.Visible = true;
            txtID.Visible = false;
            lblID.Visible = false;
        }

        private void rbEditar_CheckedChanged(object sender, EventArgs e)
        {
            btnEditar.Visible = true;
            btnAdicionar.Visible = false;
            btnApagar.Visible = false;
            lblNomeAntigo.Visible = true;
            txtNomeAntigo.Visible = true;
            lblDescricao.Visible = true;
            lblGenero.Visible = true;
            lblNome.Visible = true;
            txtGenero.Visible = true;
            TxtDescricao.Visible = true;
            txtID.Visible = false;
            lblID.Visible = false;
        }

        private void rdbApagar_CheckedChanged(object sender, EventArgs e)
        {
            btnApagar.Visible = true;
            btnEditar.Visible = false;
            btnAdicionar.Visible = false;
            lblNomeAntigo.Visible = false;
            txtNomeAntigo.Visible = false;
            TxtDescricao.Visible = false;
            txtGenero.Visible = false;
            lblDescricao.Visible = false;
            lblGenero.Visible = false;
            txtID.Visible = true;
            lblID.Visible = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);

            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                if (txtNome.Text.Length == 0)
                {
                    MessageBox.Show("Nada foi alterado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd.CommandText = "delete from Filmes where Nome = @Nome";
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.ExecuteNonQuery();
                    
                    
                }
                if (txtID.Text.Length == 0)
                {
                    MessageBox.Show("Nada foi alterado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd.CommandText = "delete from HistoricoF where FilmeID = @ID";
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Eliminado com sucesso");
                    db.Close();
                }





                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível registar ");
            }
        }
    }
}
