﻿using System;
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
    public partial class frmFas : Form
    {
        public frmFas()
        {
            InitializeComponent();     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmFas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tslSeries_Click(object sender, EventArgs e)
        {
            frmSeries series = new frmSeries();
            series.MdiParent = this;
            series.Show();
        }

        private void tslAnimes_Click(object sender, EventArgs e)
        {
            frmAnimes animes = new frmAnimes();
            animes.MdiParent = this;
            animes.Show();
        }

        private void tslFilmes_Click(object sender, EventArgs e)
        {

        }
    }
}
