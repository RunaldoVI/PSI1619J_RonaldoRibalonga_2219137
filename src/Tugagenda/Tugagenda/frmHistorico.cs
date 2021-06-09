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
    public partial class frmHistorico : Form
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idUser { get; set; }
        public frmHistorico(int _id,string _nome)
        {
            id = _id;
            nome = _nome;
            InitializeComponent();
        }
        private void btnJaVi_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);           
            DialogResult verificar = MessageBox.Show("Pretende editar a password?", "Editar?", MessageBoxButtons.OKCancel);

            if (verificar == DialogResult.OK)
            {
                try
                {

                    db.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = "insert into HistoricoF (FilmeID,IDRegisto,Visto,QuerVer,AVer) values (@id,@idUser,1,0,0)"; 
                    cmd.Parameters.AddWithValue("@id",id);
                    cmd.Parameters.AddWithValue("@idUser",idUser);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Não foi possível fazer o login");
                }
            }
          
           
        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            label1.Text = nome;
            idUser = Program.logUser.IDRegisto;
        }
    }
}
