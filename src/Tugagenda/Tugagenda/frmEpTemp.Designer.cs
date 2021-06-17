
namespace Tugagenda
{
    partial class frmEpTemp
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEp = new System.Windows.Forms.Label();
            this.txtEp = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(16, 170);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(316, 1);
            this.flowLayoutPanel2.TabIndex = 80;
            // 
            // lblEp
            // 
            this.lblEp.AutoSize = true;
            this.lblEp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEp.ForeColor = System.Drawing.Color.White;
            this.lblEp.Location = new System.Drawing.Point(12, 143);
            this.lblEp.Name = "lblEp";
            this.lblEp.Size = new System.Drawing.Size(98, 24);
            this.lblEp.TabIndex = 79;
            this.lblEp.Text = "Episodios:";
            // 
            // txtEp
            // 
            this.txtEp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtEp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtEp.ForeColor = System.Drawing.Color.White;
            this.txtEp.Location = new System.Drawing.Point(116, 143);
            this.txtEp.Multiline = true;
            this.txtEp.Name = "txtEp";
            this.txtEp.Size = new System.Drawing.Size(216, 24);
            this.txtEp.TabIndex = 74;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(116, 239);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(242, 56);
            this.btnAdicionar.TabIndex = 75;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTemp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(205, 43);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(70, 25);
            this.lblTemp.TabIndex = 82;
            this.lblTemp.Text = "label1";
            // 
            // frmEpTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(499, 338);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.lblEp);
            this.Controls.Add(this.txtEp);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "frmEpTemp";
            this.Text = "frmEpTemp";
            this.Load += new System.EventHandler(this.frmEpTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblEp;
        private System.Windows.Forms.TextBox txtEp;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblTemp;
    }
}