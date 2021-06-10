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
    public partial class frmSEstouAVer : Form
    {
        public int Ep { get; set; }

        
        public frmSEstouAVer()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Ep = int.Parse(txtEp.Text.ToString());
            Close();
        }

        private void frmSEstouAVer_Load(object sender, EventArgs e)
        {

        }
    }
}
