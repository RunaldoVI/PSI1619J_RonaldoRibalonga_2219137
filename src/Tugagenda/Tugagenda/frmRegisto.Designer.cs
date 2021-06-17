
namespace Tugagenda
{
    partial class frmRegisto
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.lblRegisto = new System.Windows.Forms.Label();
            this.lblTugagenda = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSair = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.lblCPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btn1HidePassword = new System.Windows.Forms.Button();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btn1Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPassword.Location = new System.Drawing.Point(109, 225);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(209, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtEmail.Location = new System.Drawing.Point(79, 335);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 25);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistar.Font = new System.Drawing.Font("MV Boli", 15.75F);
            this.btnRegistar.ForeColor = System.Drawing.Color.White;
            this.btnRegistar.Location = new System.Drawing.Point(70, 416);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(200, 39);
            this.btnRegistar.TabIndex = 5;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = false;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // lblRegisto
            // 
            this.lblRegisto.AutoSize = true;
            this.lblRegisto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblRegisto.Font = new System.Drawing.Font("MV Boli", 45F);
            this.lblRegisto.ForeColor = System.Drawing.Color.White;
            this.lblRegisto.Location = new System.Drawing.Point(80, 9);
            this.lblRegisto.Name = "lblRegisto";
            this.lblRegisto.Size = new System.Drawing.Size(238, 79);
            this.lblRegisto.TabIndex = 9;
            this.lblRegisto.Text = "Registo";
            // 
            // lblTugagenda
            // 
            this.lblTugagenda.AutoSize = true;
            this.lblTugagenda.BackColor = System.Drawing.Color.Transparent;
            this.lblTugagenda.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTugagenda.ForeColor = System.Drawing.Color.White;
            this.lblTugagenda.Location = new System.Drawing.Point(112, 88);
            this.lblTugagenda.Name = "lblTugagenda";
            this.lblTugagenda.Size = new System.Drawing.Size(170, 41);
            this.lblTugagenda.TabIndex = 10;
            this.lblTugagenda.Text = "Tugagenda";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 159);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 25);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 221);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 25);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(12, 336);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("MV Boli", 15.75F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(70, 478);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(200, 39);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 359);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 1);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(104, 244);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(216, 1);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(107, 182);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(213, 1);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("MV Boli", 15.75F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(107, 542);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 39);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(107, 304);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(216, 1);
            this.flowLayoutPanel4.TabIndex = 22;
            // 
            // txtCPassword
            // 
            this.txtCPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtCPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCPassword.ForeColor = System.Drawing.Color.White;
            this.txtCPassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtCPassword.Location = new System.Drawing.Point(177, 282);
            this.txtCPassword.Multiline = true;
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.Size = new System.Drawing.Size(140, 23);
            this.txtCPassword.TabIndex = 3;
            this.txtCPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPassword_KeyPress);
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCPassword.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Underline);
            this.lblCPassword.ForeColor = System.Drawing.Color.White;
            this.lblCPassword.Location = new System.Drawing.Point(12, 286);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(165, 20);
            this.lblCPassword.TabIndex = 21;
            this.lblCPassword.Text = "Confirmação Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUsername.Location = new System.Drawing.Point(114, 164);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(209, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // btn1HidePassword
            // 
            this.btn1HidePassword.BackgroundImage = global::Tugagenda.Properties.Resources.Background_1;
            this.btn1HidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1HidePassword.FlatAppearance.BorderSize = 0;
            this.btn1HidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1HidePassword.Location = new System.Drawing.Point(323, 264);
            this.btn1HidePassword.Name = "btn1HidePassword";
            this.btn1HidePassword.Size = new System.Drawing.Size(47, 42);
            this.btn1HidePassword.TabIndex = 26;
            this.btn1HidePassword.UseVisualStyleBackColor = true;
            this.btn1HidePassword.Click += new System.EventHandler(this.btn1HidePassword_Click);
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackgroundImage = global::Tugagenda.Properties.Resources.Background_1;
            this.btnHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.Location = new System.Drawing.Point(323, 205);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(47, 42);
            this.btnHidePassword.TabIndex = 24;
            this.btnHidePassword.UseVisualStyleBackColor = true;
            this.btnHidePassword.Click += new System.EventHandler(this.btnHidePassword_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.BackgroundImage = global::Tugagenda.Properties.Resources.Background__1_;
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(323, 205);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(47, 42);
            this.btnPassword.TabIndex = 23;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btn1Password
            // 
            this.btn1Password.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn1Password.BackgroundImage = global::Tugagenda.Properties.Resources.Background__1_;
            this.btn1Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1Password.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1Password.FlatAppearance.BorderSize = 0;
            this.btn1Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Password.Location = new System.Drawing.Point(323, 264);
            this.btn1Password.Name = "btn1Password";
            this.btn1Password.Size = new System.Drawing.Size(47, 42);
            this.btn1Password.TabIndex = 25;
            this.btn1Password.UseVisualStyleBackColor = false;
            this.btn1Password.Click += new System.EventHandler(this.btn1Password_Click);
            // 
            // frmRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(381, 621);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.lblCPassword);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblRegisto);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTugagenda);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btn1Password);
            this.Controls.Add(this.btn1HidePassword);
            this.Controls.Add(this.btnHidePassword);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRegisto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registo";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label lblRegisto;
        private System.Windows.Forms.Label lblTugagenda;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.Label lblCPassword;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Button btn1Password;
        private System.Windows.Forms.Button btn1HidePassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}