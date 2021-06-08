
namespace Tugagenda
{
    partial class frmHistorico
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
            this.btnJaVi = new System.Windows.Forms.Button();
            this.btnEstouAVer = new System.Windows.Forms.Button();
            this.btnQueroVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJaVi
            // 
            this.btnJaVi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJaVi.Location = new System.Drawing.Point(125, 142);
            this.btnJaVi.Name = "btnJaVi";
            this.btnJaVi.Size = new System.Drawing.Size(95, 80);
            this.btnJaVi.TabIndex = 0;
            this.btnJaVi.Text = "Ja Vi";
            this.btnJaVi.UseVisualStyleBackColor = true;
            this.btnJaVi.Click += new System.EventHandler(this.btnJaVi_Click);
            // 
            // btnEstouAVer
            // 
            this.btnEstouAVer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEstouAVer.Location = new System.Drawing.Point(280, 142);
            this.btnEstouAVer.Name = "btnEstouAVer";
            this.btnEstouAVer.Size = new System.Drawing.Size(95, 80);
            this.btnEstouAVer.TabIndex = 1;
            this.btnEstouAVer.Text = "Estou a ver";
            this.btnEstouAVer.UseVisualStyleBackColor = true;
            // 
            // btnQueroVer
            // 
            this.btnQueroVer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQueroVer.Location = new System.Drawing.Point(432, 142);
            this.btnQueroVer.Name = "btnQueroVer";
            this.btnQueroVer.Size = new System.Drawing.Size(95, 80);
            this.btnQueroVer.TabIndex = 2;
            this.btnQueroVer.Text = "Quero Ver";
            this.btnQueroVer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQueroVer);
            this.Controls.Add(this.btnEstouAVer);
            this.Controls.Add(this.btnJaVi);
            this.Name = "frmHistorico";
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.frmHistorico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJaVi;
        private System.Windows.Forms.Button btnEstouAVer;
        private System.Windows.Forms.Button btnQueroVer;
        private System.Windows.Forms.Label label1;
    }
}