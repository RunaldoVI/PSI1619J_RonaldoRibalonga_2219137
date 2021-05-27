
namespace Tugagenda
{
    partial class frmRagE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRagE));
            this.lblResumo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVi = new System.Windows.Forms.Button();
            this.btnQuero = new System.Windows.Forms.Button();
            this.btnEVer = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.PicRag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicRag)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.Location = new System.Drawing.Point(257, 82);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(426, 588);
            this.lblResumo.TabIndex = 16;
            this.lblResumo.Text = resources.GetString("lblResumo.Text");
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(255, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 39);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Ragnarok";
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
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(71, 390);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(98, 34);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado";
            // 
            // PicRag
            // 
            this.PicRag.BackgroundImage = global::Tugagenda.Properties.Resources._2395172;
            this.PicRag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicRag.Location = new System.Drawing.Point(12, 12);
            this.PicRag.Name = "PicRag";
            this.PicRag.Size = new System.Drawing.Size(237, 356);
            this.PicRag.TabIndex = 11;
            this.PicRag.TabStop = false;
            // 
            // frmRagE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 694);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVi);
            this.Controls.Add(this.btnQuero);
            this.Controls.Add(this.btnEVer);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.PicRag);
            this.Name = "frmRagE";
            this.Text = "frmRagE";
            ((System.ComponentModel.ISupportInitialize)(this.PicRag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVi;
        private System.Windows.Forms.Button btnQuero;
        private System.Windows.Forms.Button btnEVer;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.PictureBox PicRag;
    }
}