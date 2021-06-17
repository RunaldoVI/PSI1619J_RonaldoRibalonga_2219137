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
    public partial class frmSApagar : Form
    {
        public frmSApagar()
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
                    if (txtID.Text.Length == 0)
                    {
                        MessageBox.Show("Nada foi alterado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cmd.CommandText = "delete from Temporada where SerieID = @IDE";
                        cmd.Parameters.AddWithValue("@IDE", txtID.Text);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "delete from HistoricoS where SerieID = @ID";
                        cmd.Parameters.AddWithValue("@ID", txtID.Text);
                        cmd.CommandText = "delete from Series where Nome = @Nome";
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Eliminado com sucesso");
                    }


                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não foi possível registar ");
            }
        }

        private void frmSApagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnApagar.PerformClick();
            }
        }

        private void frmSApagar_Load(object sender, EventArgs e)
        {

        }
    }
}
