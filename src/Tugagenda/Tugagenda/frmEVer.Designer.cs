
namespace Tugagenda
{
    partial class frmEVer
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
            this.lblEver = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.lblEpisodio = new System.Windows.Forms.Label();
            this.txtTemporada = new System.Windows.Forms.TextBox();
            this.txtEpisodio = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEver
            // 
            this.lblEver.AutoSize = true;
            this.lblEver.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEver.Location = new System.Drawing.Point(13, 51);
            this.lblEver.Name = "lblEver";
            this.lblEver.Size = new System.Drawing.Size(69, 25);
            this.lblEver.TabIndex = 0;
            this.lblEver.Text = "Nome:";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.lblTemporada.Location = new System.Drawing.Point(13, 89);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(113, 25);
            this.lblTemporada.TabIndex = 1;
            this.lblTemporada.Text = "Temporada:";
            // 
            // lblEpisodio
            // 
            this.lblEpisodio.AutoSize = true;
            this.lblEpisodio.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.lblEpisodio.Location = new System.Drawing.Point(12, 126);
            this.lblEpisodio.Name = "lblEpisodio";
            this.lblEpisodio.Size = new System.Drawing.Size(89, 25);
            this.lblEpisodio.TabIndex = 2;
            this.lblEpisodio.Text = "Episodio:";
            // 
            // txtTemporada
            // 
            this.txtTemporada.Location = new System.Drawing.Point(132, 95);
            this.txtTemporada.Name = "txtTemporada";
            this.txtTemporada.Size = new System.Drawing.Size(161, 20);
            this.txtTemporada.TabIndex = 4;
            // 
            // txtEpisodio
            // 
            this.txtEpisodio.Location = new System.Drawing.Point(107, 132);
            this.txtEpisodio.Name = "txtEpisodio";
            this.txtEpisodio.Size = new System.Drawing.Size(186, 20);
            this.txtEpisodio.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.btnAdicionar.Location = new System.Drawing.Point(58, 232);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(186, 58);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(88, 57);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(205, 21);
            this.cbNome.TabIndex = 7;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // EVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 331);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtEpisodio);
            this.Controls.Add(this.txtTemporada);
            this.Controls.Add(this.lblEpisodio);
            this.Controls.Add(this.lblTemporada);
            this.Controls.Add(this.lblEver);
            this.Name = "EVer";
            this.Text = "EVer";
            this.Load += new System.EventHandler(this.EVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEver;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.Label lblEpisodio;
        private System.Windows.Forms.TextBox txtTemporada;
        private System.Windows.Forms.TextBox txtEpisodio;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cbNome;
    }
}