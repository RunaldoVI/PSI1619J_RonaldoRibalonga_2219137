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
            DialogResult verificar = MessageBox.Show("Pretende adicionar a lista de ja visto?", "Adicionar?", MessageBoxButtons.OKCancel);

            if (verificar == DialogResult.OK)
            {
                try
                {

                    db.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = "insert into HistoricoF (FilmeID,IDRegisto,Visto) values (@id,@idUser,1)"; 
                    cmd.Parameters.AddWithValue("@id",id);
                    cmd.Parameters.AddWithValue("@idUser",idUser);
                    cmd.ExecuteNonQuery();
                    db.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Não foi possível adicionar!");
                }
            }

            Close();
        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            label1.Text = nome;
            idUser = Program.logUser.IDRegisto;
        }

        private void btnEstouAVer_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);
            DialogResult verificar = MessageBox.Show("Prentede adicionar a lista que esta a ver?", "Adicionar?", MessageBoxButtons.OKCancel);

            if (verificar == DialogResult.OK)
            {
                try
                {

                    db.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = "insert into HistoricoF (FilmeID,IDRegisto,AVer) values (@id,@idUser,1)";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.ExecuteNonQuery();
                    db.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Não foi possível adicionar!");
                }
            }
            Close();
        }

        private void btnQueroVer_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(Program.MyConnectionString);
            DialogResult verificar = MessageBox.Show("Pretende adicionar a lista de quer ver?", "Adicionar?", MessageBoxButtons.OKCancel);

            if (verificar == DialogResult.OK)
            {
                try
                {

                    db.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = "insert into HistoricoF (FilmeID,IDRegisto,QuerVer) values (@id,@idUser,1)";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.ExecuteNonQuery();
                    db.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message, "Não foi possível adicionar!");
                }
            }
            Close();
        }
    }
}