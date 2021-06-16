
namespace Tugagenda
{
    partial class frmFas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsl = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tslSeries = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslFilmes = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslPerfil = new System.Windows.Forms.ToolStripLabel();
            this.tsl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsl
            // 
            this.tsl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tslSeries,
            this.toolStripSeparator2,
            this.tslFilmes,
            this.toolStripSeparator1,
            this.tslPerfil});
            this.tsl.Location = new System.Drawing.Point(0, 0);
            this.tsl.Name = "tsl";
            this.tsl.Size = new System.Drawing.Size(1416, 25);
            this.tsl.TabIndex = 1;
            this.tsl.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // tslSeries
            // 
            this.tslSeries.BackColor = System.Drawing.Color.White;
            this.tslSeries.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F);
            this.tslSeries.ForeColor = System.Drawing.Color.White;
            this.tslSeries.Name = "tslSeries";
            this.tslSeries.Size = new System.Drawing.Size(63, 22);
            this.tslSeries.Text = "Series";
            this.tslSeries.Click += new System.EventHandler(this.tslSeries_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslFilmes
            // 
            this.tslFilmes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F);
            this.tslFilmes.ForeColor = System.Drawing.Color.White;
            this.tslFilmes.Name = "tslFilmes";
            this.tslFilmes.Size = new System.Drawing.Size(66, 22);
            this.tslFilmes.Text = "Filmes";
            this.tslFilmes.Click += new System.EventHandler(this.tslFilmes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslPerfil
            // 
            this.tslPerfil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslPerfil.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F);
            this.tslPerfil.ForeColor = System.Drawing.Color.White;
            this.tslPerfil.Name = "tslPerfil";
            this.tslPerfil.Size = new System.Drawing.Size(53, 22);
            this.tslPerfil.Text = "Perfil";
            this.tslPerfil.Click += new System.EventHandler(this.tslPerfil_Click);
            // 
            // frmFas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1416, 644);
            this.Controls.Add(this.tsl);
            this.ForeColor = System.Drawing.Color.Bisque;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmFas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFas_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsl.ResumeLayout(false);
            this.tsl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsl;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tslSeries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslFilmes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslPerfil;
    }
}

