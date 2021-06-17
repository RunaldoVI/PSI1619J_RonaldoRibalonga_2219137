using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugagenda
{
    public partial class frmComeco : Form
    {
        public frmComeco()
        {
            InitializeComponent();
        }

        private void btnRegisto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisto registro = new frmRegisto();
            registro.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comeco_Load(object sender, EventArgs e)
        {

        }
    }
}
