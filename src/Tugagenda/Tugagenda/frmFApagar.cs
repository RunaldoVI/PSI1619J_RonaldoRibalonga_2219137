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
    public partial class frmFApagar : Form
    {
        public frmFApagar()
        {
            InitializeComponent();
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
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível registar ");
            }
        }

        private void frmFApagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnApagar.PerformClick();
            }
        }

        private void frmFApagar_Load(object sender, EventArgs e)
        {

        }
    }
}
