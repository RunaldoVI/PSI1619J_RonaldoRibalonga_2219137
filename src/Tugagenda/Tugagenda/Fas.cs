using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tugagenda
{
    public partial class Fas : Form
    {
        public Fas()
        {
            InitializeComponent();     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Series serie = new Series();
            serie.MdiParent = this;
            serie.Show();

        }
 
    }
}
