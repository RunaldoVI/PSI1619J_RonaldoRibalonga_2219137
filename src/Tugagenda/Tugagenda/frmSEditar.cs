using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugagenda
{
    public partial class frmSEditar : Form
    {
        public frmSEditar()
        {
            InitializeComponent();
        }

      
        private void btnEditar_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);               
            
            
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "update Series set Nome = @Nome, Descricao=@Descricao, Genero=@Genero, Temporada=@Temporada,Imagem=@Imagem where Nome=@Nome";
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Descricao", TxtDescricao.Text);
                cmd.Parameters.AddWithValue("@Genero", txtGenero.Text);
                cmd.Parameters.AddWithValue("@Temporada", txtTemp.Text);
                cmd.Parameters.AddWithValue("@Imagem", txtImagem.Text);

                if (txtNomeAntigo.Text.Length == 0)
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
                                if (txtTemp.Text.Length == 0)
                                {
                                    MessageBox.Show("Nada foi alterado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Alterado com sucesso");
                                    db.Close();
                                    Close();
                                }
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

        private void frmSEditar_Load(object sender, EventArgs e)
        {

        }

        private void frmSEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnEditar.PerformClick();
            }
        }

        private void txtImagem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
