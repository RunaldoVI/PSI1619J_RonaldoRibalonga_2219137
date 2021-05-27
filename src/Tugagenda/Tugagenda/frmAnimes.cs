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
    public partial class frmAnimes : Form
    {
        public frmAnimes()
        {
            InitializeComponent();
        }

        private void btnKY_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEstado>().Count() > 0)
            {
                Application.OpenForms.OfType<frmEstado>().First().Focus();
                MessageBox.Show("Já tem 1 janela estado aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmEstado estado = new frmEstado();
                estado.Show();
            }
        }

        private void frmAnimes_Load(object sender, EventArgs e)
        {

        }
    }
}
