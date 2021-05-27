
namespace Tugagenda
{
    partial class frmTWDE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTWDE));
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnEVer = new System.Windows.Forms.Button();
            this.btnQuero = new System.Windows.Forms.Button();
            this.btnVi = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(71, 390);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(98, 34);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // btnEVer
            // 
            this.btnEVer.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEVer.Location = new System.Drawing.Point(12, 443);
            this.btnEVer.Name = "btnEVer";
            this.btnEVer.Size = new System.Drawing.Size(237, 52);
            this.btnEVer.TabIndex = 1;
            this.btnEVer.Text = "Estou a ver";
            this.btnEVer.UseVisualStyleBackColor = true;
            // 
            // btnQuero
            // 
            this.btnQuero.Font = new System.Drawing.Font("Poor Richard", 15.75F);
            this.btnQuero.Location = new System.Drawing.Point(12, 532);
            this.btnQuero.Name = "btnQuero";
            this.btnQuero.Size = new System.Drawing.Size(237, 52);
            this.btnQuero.TabIndex = 2;
            this.btnQuero.Text = "Quero Ver";
            this.btnQuero.UseVisualStyleBackColor = true;
            // 
            // btnVi
            // 
            this.btnVi.Font = new System.Drawing.Font("Poor Richard", 15.75F);
            this.btnVi.Location = new System.Drawing.Point(12, 618);
            this.btnVi.Name = "btnVi";
            this.btnVi.Size = new System.Drawing.Size(237, 52);
            this.btnVi.TabIndex = 3;
            this.btnVi.Text = "Já Vi";
            this.btnVi.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(255, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 39);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "The Walking Dead";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 504);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tugagenda.Properties.Resources._20303823;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 356);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmTWDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVi);
            this.Controls.Add(this.btnQuero);
            this.Controls.Add(this.btnEVer);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTWDE";
            this.Text = "frmTWDE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnEVer;
        private System.Windows.Forms.Button btnQuero;
        private System.Windows.Forms.Button btnVi;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
    }
}