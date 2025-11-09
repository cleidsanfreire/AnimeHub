namespace AnimeHub
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            btnLogin = new Button();
            lblMensagem = new Label();
            btnSairLogin = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            picImagem = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            linkForgotPassword = new LinkLabel();
            linkRegister = new LinkLabel();
            pnlLogin = new Panel();
            label1 = new Label();
            pnlSombra = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(79, 164);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 29);
            txtUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(122, 295);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = Color.Transparent;
            lblMensagem.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(79, 344);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(196, 22);
            lblMensagem.TabIndex = 6;
            lblMensagem.Text = "Usuário ou senha incorretos.";
            // 
            // btnSairLogin
            // 
            btnSairLogin.AutoSize = true;
            btnSairLogin.Location = new Point(160, 417);
            btnSairLogin.Name = "btnSairLogin";
            btnSairLogin.Size = new Size(34, 20);
            btnSairLogin.TabIndex = 8;
            btnSairLogin.Text = "Sair";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 451);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 9;
            label3.Text = "Nao tem conta?";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(79, 220);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 25);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // picImagem
            // 
            picImagem.BackColor = Color.White;
            picImagem.Dock = DockStyle.Right;
            picImagem.Image = Properties.Resources._152fb4ace5ee77532a590497ed417a90;
            picImagem.Location = new Point(328, 0);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(389, 480);
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            picImagem.TabIndex = 13;
            picImagem.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 140);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 14;
            label5.Text = "Login";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 198);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 15;
            label6.Text = "Senha";
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkForgotPassword.Location = new Point(158, 249);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(121, 19);
            linkForgotPassword.TabIndex = 16;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password?";
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Location = new Point(192, 451);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(83, 20);
            linkRegister.TabIndex = 17;
            linkRegister.TabStop = true;
            linkRegister.Text = "Registre-se";
            linkRegister.Click += linkRegister_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(linkForgotPassword);
            pnlLogin.Controls.Add(linkRegister);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(label6);
            pnlLogin.Controls.Add(lblMensagem);
            pnlLogin.Controls.Add(label5);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(btnSairLogin);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Dock = DockStyle.Left;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(330, 480);
            pnlLogin.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 58);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 18;
            label1.Text = "Entre na sua conta";
            // 
            // pnlSombra
            // 
            pnlSombra.BackColor = Color.LightGray;
            pnlSombra.Location = new Point(382, -6);
            pnlSombra.Name = "pnlSombra";
            pnlSombra.Size = new Size(8, 494);
            pnlSombra.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(657, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 494);
            panel1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 28);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 19;
            label2.Text = "ANIMES HUB";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 480);
            Controls.Add(panel1);
            Controls.Add(pnlSombra);
            Controls.Add(pnlLogin);
            Controls.Add(picImagem);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUsername;
        private Button btnLogin;
        private Label lblMensagem;
        private Label btnSairLogin;
        private Label label3;
        private TextBox txtPassword;
        private PictureBox picImagem;
        private Label label5;
        private Label label6;
        private LinkLabel linkForgotPassword;
        private LinkLabel linkRegister;
        private Panel pnlLogin;
        private Panel pnlSombra;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}