
namespace Tugagenda
{
    partial class frmFilmescrum
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblNomeAntigo = new System.Windows.Forms.Label();
            this.txtNomeAntigo = new System.Windows.Forms.TextBox();
            this.rdbAdicionar = new System.Windows.Forms.RadioButton();
            this.rbEditar = new System.Windows.Forms.RadioButton();
            this.rdbApagar = new System.Windows.Forms.RadioButton();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(91, 159);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(205, 20);
            this.txtGenero.TabIndex = 1;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(91, 133);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(205, 20);
            this.TxtDescricao.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(50, 107);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescricao.Location = new System.Drawing.Point(30, 136);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenero.Location = new System.Drawing.Point(43, 160);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Genero";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdicionar.Location = new System.Drawing.Point(64, 214);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(242, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Location = new System.Drawing.Point(64, 214);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(242, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApagar.Location = new System.Drawing.Point(64, 214);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(242, 23);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblNomeAntigo
            // 
            this.lblNomeAntigo.AutoSize = true;
            this.lblNomeAntigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNomeAntigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeAntigo.Location = new System.Drawing.Point(18, 84);
            this.lblNomeAntigo.Name = "lblNomeAntigo";
            this.lblNomeAntigo.Size = new System.Drawing.Size(68, 13);
            this.lblNomeAntigo.TabIndex = 9;
            this.lblNomeAntigo.Text = "Nome Antigo";
            this.lblNomeAntigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomeAntigo.Visible = false;
            // 
            // txtNomeAntigo
            // 
            this.txtNomeAntigo.Location = new System.Drawing.Point(91, 81);
            this.txtNomeAntigo.Name = "txtNomeAntigo";
            this.txtNomeAntigo.Size = new System.Drawing.Size(205, 20);
            this.txtNomeAntigo.TabIndex = 10;
            this.txtNomeAntigo.Visible = false;
            // 
            // rdbAdicionar
            // 
            this.rdbAdicionar.AutoSize = true;
            this.rdbAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbAdicionar.Location = new System.Drawing.Point(64, 243);
            this.rdbAdicionar.Name = "rdbAdicionar";
            this.rdbAdicionar.Size = new System.Drawing.Size(75, 18);
            this.rdbAdicionar.TabIndex = 11;
            this.rdbAdicionar.TabStop = true;
            this.rdbAdicionar.Text = "Adicionar";
            this.rdbAdicionar.UseVisualStyleBackColor = true;
            this.rdbAdicionar.CheckedChanged += new System.EventHandler(this.rdbAdicionar_CheckedChanged);
            // 
            // rbEditar
            // 
            this.rbEditar.AutoSize = true;
            this.rbEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbEditar.Location = new System.Drawing.Point(154, 243);
            this.rbEditar.Name = "rbEditar";
            this.rbEditar.Size = new System.Drawing.Size(58, 18);
            this.rbEditar.TabIndex = 12;
            this.rbEditar.TabStop = true;
            this.rbEditar.Text = "Editar";
            this.rbEditar.UseVisualStyleBackColor = true;
            this.rbEditar.CheckedChanged += new System.EventHandler(this.rbEditar_CheckedChanged);
            // 
            // rdbApagar
            // 
            this.rdbApagar.AutoSize = true;
            this.rdbApagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbApagar.Location = new System.Drawing.Point(231, 243);
            this.rdbApagar.Name = "rdbApagar";
            this.rdbApagar.Size = new System.Drawing.Size(65, 18);
            this.rdbApagar.TabIndex = 13;
            this.rdbApagar.TabStop = true;
            this.rdbApagar.Text = "Apagar";
            this.rdbApagar.UseVisualStyleBackColor = true;
            this.rdbApagar.CheckedChanged += new System.EventHandler(this.rdbApagar_CheckedChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(50, 81);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(205, 20);
            this.txtID.TabIndex = 14;
            this.txtID.Visible = false;
            // 
            // frmFilmescrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 319);
            this.Controls.Add(this.rdbApagar);
            this.Controls.Add(this.rbEditar);
            this.Controls.Add(this.rdbAdicionar);
            this.Controls.Add(this.txtNomeAntigo);
            this.Controls.Add(this.lblNomeAntigo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Name = "frmFilmescrum";
            this.Text = "frmFilmescrum";
            this.Load += new System.EventHandler(this.frmFilmescrum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblNomeAntigo;
        private System.Windows.Forms.TextBox txtNomeAntigo;
        private System.Windows.Forms.RadioButton rdbAdicionar;
        private System.Windows.Forms.RadioButton rbEditar;
        private System.Windows.Forms.RadioButton rdbApagar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}