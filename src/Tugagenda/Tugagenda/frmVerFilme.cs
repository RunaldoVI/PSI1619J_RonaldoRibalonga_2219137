using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugagenda
{
    public partial class frmVerFilme : Form
    {
        public string nome { get; set; }

        public string descricao { get; set; }
        public string imagem { get; set; }

        private Image GetFromURL(string url)
        {
            WebRequest req = WebRequest.Create(url);

            WebResponse res = req.GetResponse();

            Stream imgStream = res.GetResponseStream();

            Image img1 = Image.FromStream(imgStream);

            imgStream.Close();
            return img1;
        }
        public frmVerFilme(string _nome, string _descricao ,string _imagem)
        {
           
            nome = _nome;
            descricao = _descricao;
            imagem = _imagem;
            InitializeComponent();
        }

        private void frmVerFilme_Load(object sender, EventArgs e)
        {
            
            pboxImagem.Image = GetFromURL(imagem);
            lblNome.Text = nome;
            txtdescricao.Text = descricao;
        }
    }
}
