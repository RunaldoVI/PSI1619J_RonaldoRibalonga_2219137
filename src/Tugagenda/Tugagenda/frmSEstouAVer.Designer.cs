
namespace Tugagenda
{
    partial class frmSEstouAVer
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
            this.lblEp = new System.Windows.Forms.Label();
            this.txtEp = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEp
            // 
            this.lblEp.AutoSize = true;
            this.lblEp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblEp.Location = new System.Drawing.Point(30, 18);
            this.lblEp.Name = "lblEp";
            this.lblEp.Size = new System.Drawing.Size(167, 18);
            this.lblEp.TabIndex = 0;
            this.lblEp.Text = "Em que episodio estás?";
            // 
            // txtEp
            // 
            this.txtEp.Location = new System.Drawing.Point(53, 74);
            this.txtEp.Name = "txtEp";
            this.txtEp.Size = new System.Drawing.Size(167, 20);
            this.txtEp.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(113, 130);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(244, 130);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmSEstouAVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 174);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtEp);
            this.Controls.Add(this.lblEp);
            this.Name = "frmSEstouAVer";
            this.Text = "frmSEstouAVer";
            this.Load += new System.EventHandler(this.frmSEstouAVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEp;
        private System.Windows.Forms.TextBox txtEp;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSair;
    }
}