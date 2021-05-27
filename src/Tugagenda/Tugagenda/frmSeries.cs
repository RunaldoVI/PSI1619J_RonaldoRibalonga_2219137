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
    public partial class frmSeries : Form
    {
        public frmSeries()
        {
            InitializeComponent();
        }

        private void btnTWD_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmTWDE>().Count() > 0)
            {
                Application.OpenForms.OfType<frmTWDE>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmTWDE estado = new frmTWDE();
                estado.Show();
            }
        }

        private void btnCZ_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCZE>().Count() > 0)
            {
                Application.OpenForms.OfType<frmCZE>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmCZE estado = new frmCZE();
                estado.Show();
            }
        }

        private void btnRagnarok_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRagE>().Count() > 0)
            {
                Application.OpenForms.OfType<frmRagE>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmRagE estado = new frmRagE();
                estado.Show();
            }
        }

        private void btnCasaPapel_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmLCP>().Count() > 0)
            {
                Application.OpenForms.OfType<frmLCP>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmLCP estado = new frmLCP();
                estado.Show();
            }
        }

        private void btnVis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmVisE>().Count() > 0)
            {
                Application.OpenForms.OfType<frmVisE>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmVisE estado = new frmVisE();
                estado.Show();
            }
        }

        private void btnSimp_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSimp>().Count() > 0)
            {
                Application.OpenForms.OfType<frmSimp>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmSimp estado = new frmSimp();
                estado.Show();
            }
        }

        private void btnGOT_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmGOT>().Count() > 0)
            {
                Application.OpenForms.OfType<frmGOT>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmGOT estado = new frmGOT();
                estado.Show();
            }
        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmTBL>().Count() > 0)
            {
                Application.OpenForms.OfType<frmTBL>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmTBL estado = new frmTBL();
                estado.Show();
            }
        }

        private void btnVikings_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmVikings>().Count() > 0)
            {
                Application.OpenForms.OfType<frmVikings>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmVikings estado = new frmVikings();
                estado.Show();
            }
        }

        private void frmSeries_Load(object sender, EventArgs e)
        {

        }

        private void btnST_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmST>().Count() > 0)
            {
                Application.OpenForms.OfType<frmST>().First().Focus();
                MessageBox.Show("Já tem 1 janela series aberta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                frmST estado = new frmST();
                estado.Show();
            }
        }
    }
}
