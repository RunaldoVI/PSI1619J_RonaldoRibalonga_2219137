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
    public partial class frmGOT : Form
    {
        public frmGOT()
        {
            InitializeComponent();
        }

        private void btnEVer_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEVer>().Count() > 0)
            {
                Application.OpenForms.OfType<frmEVer>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                frmEVer ver = new frmEVer();
                ver.Show();
            }
        }

        private void frmGOT_Load(object sender, EventArgs e)
        {

        }
    }
}
