
namespace Tugagenda
{
    partial class frmVerFilme
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
            this.pboxImagem = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxImagem
            // 
            this.pboxImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxImagem.Location = new System.Drawing.Point(668, 74);
            this.pboxImagem.Name = "pboxImagem";
            this.pboxImagem.Size = new System.Drawing.Size(170, 262);
            this.pboxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagem.TabIndex = 14;
            this.pboxImagem.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(39, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 25);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "label1";
            // 
            // txtdescricao
            // 
            this.txtdescricao.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtdescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtdescricao.ForeColor = System.Drawing.Color.White;
            this.txtdescricao.Location = new System.Drawing.Point(0, 56);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(610, 304);
            this.txtdescricao.TabIndex = 13;
            // 
            // frmVerFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(914, 615);
            this.Controls.Add(this.pboxImagem);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtdescricao);
            this.Name = "frmVerFilme";
            this.Text = "frmVerFilme";
            this.Load += new System.EventHandler(this.frmVerFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxImagem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtdescricao;
    }
}