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
            frmEstado estado = new frmEstado();
            estado.Show();
        }
    }
}
