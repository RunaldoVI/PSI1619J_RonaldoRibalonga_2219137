﻿using System;
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
    public partial class frmSeries : Form
    {
        public int idUser { get; set; }

        public string idNome { get; set; }

        int idT;


        public frmSeries()
        {
            InitializeComponent();
        }      
        private void frmSeries_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();

                var cmd = new SqlCommand("Select * from Series", db);
                var rdr = cmd.ExecuteReader();

                var datatable = new DataTable("Series");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["Series"]);
                dgvSeries.DataSource = dataset.Tables["Series"];
                javi();
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
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection(Program.MyConnectionString);
                db.Open();


                var cmd = new SqlCommand($"Select * from Series where nome like '%{txtSeries.Text}%'", db);


                var rdr = cmd.ExecuteReader();

                var datatable = new DataTable("Series");
                var dataset = new DataSet();
                dataset.Tables.Add(datatable);
                dataset.Load(rdr, LoadOption.PreserveChanges, dataset.Tables["Series"]);

                dgvSeries.DataSource = dataset.Tables["Series"];

                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Não existe dados registados com este nome.");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }


        private void dgvSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
            SqlConnection db = new SqlConnection(Program.MyConnectionString);
            if (Application.OpenForms.OfType<frmHistoricoSeries>().Count() > 0)
            {
                Application.OpenForms.OfType<frmHistoricoSeries>().First().Focus();
                MessageBox.Show("Já tem 1 janela filmes aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                idUser = Program.logUser.IDRegisto;
                idNome = Program.logUser.Username;
                int id = int.Parse(dgvSeries.Rows[dgvSeries.SelectedCells[0].RowIndex].Cells[1].Value.ToString());
                string nome = dgvSeries.Rows[dgvSeries.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    DialogResult verificar = MessageBox.Show("Pretende adicionar a lista ja visto?", "Adicionar?", MessageBoxButtons.OKCancel);

                    if (verificar == DialogResult.OK)
                    {

                        DataGridViewRow row = this.dgvSeries.Rows[e.RowIndex];
                        db.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = db;
                        idT = int.Parse(row.Cells["Temporada"].Value.ToString());
                        cmd.CommandText = "insert into HistoricoS (SerieID,IDRegisto,Visto,Temporada,Username,SerieNome) values (@id,@idUser,1,@Temporada,@Username,@Nome)";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@idUser", idUser);
                        cmd.Parameters.AddWithValue("@Temporada", idT);
                        cmd.Parameters.AddWithValue("@Username", idNome);
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    var historico = new frmHistoricoSeries(id, nome);
                    historico.MdiParent = this.ParentForm;
                    historico.Show();
                }
                
               

            }
        }

        private void txtSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btnPesquisar_Click(this, EventArgs.Empty);
            }
        }
    }
}
