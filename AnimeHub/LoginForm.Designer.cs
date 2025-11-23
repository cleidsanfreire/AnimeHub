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
            picImagem2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            linkForgotPassword = new LinkLabel();
            linkRegister = new LinkLabel();
            pnlLogin = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlRegister = new Panel();
            txtConfirmPasswordRg = new TextBox();
            label13 = new Label();
            txtPasswordRg = new TextBox();
            label14 = new Label();
            label4 = new Label();
            label7 = new Label();
            lblEntrarContaRg = new LinkLabel();
            txtUsernameRg = new TextBox();
            txtEmailRg = new TextBox();
            label8 = new Label();
            lblMensagemRg = new Label();
            label10 = new Label();
            CriarConta = new Button();
            btnSairRegister = new Label();
            label12 = new Label();
            pnlSombra = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picImagem2).BeginInit();
            pnlLogin.SuspendLayout();
            pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lblMensagem.Size = new Size(0, 22);
            lblMensagem.TabIndex = 6;
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
            // picImagem2
            // 
            picImagem2.BackColor = Color.White;
            picImagem2.Image = Properties.Resources.bee87ad223ccdfb3591f617229aa2fb3;
            picImagem2.Location = new Point(328, 0);
            picImagem2.Name = "picImagem2";
            picImagem2.Size = new Size(389, 480);
            picImagem2.SizeMode = PictureBoxSizeMode.Zoom;
            picImagem2.TabIndex = 13;
            picImagem2.TabStop = false;
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
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.White;
            pnlRegister.BorderStyle = BorderStyle.FixedSingle;
            pnlRegister.Controls.Add(txtConfirmPasswordRg);
            pnlRegister.Controls.Add(label13);
            pnlRegister.Controls.Add(txtPasswordRg);
            pnlRegister.Controls.Add(label14);
            pnlRegister.Controls.Add(label4);
            pnlRegister.Controls.Add(label7);
            pnlRegister.Controls.Add(lblEntrarContaRg);
            pnlRegister.Controls.Add(txtUsernameRg);
            pnlRegister.Controls.Add(txtEmailRg);
            pnlRegister.Controls.Add(label8);
            pnlRegister.Controls.Add(lblMensagemRg);
            pnlRegister.Controls.Add(label10);
            pnlRegister.Controls.Add(CriarConta);
            pnlRegister.Controls.Add(btnSairRegister);
            pnlRegister.Controls.Add(label12);
            pnlRegister.Location = new Point(0, 0);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(330, 480);
            pnlRegister.TabIndex = 20;
            // 
            // txtConfirmPasswordRg
            // 
            txtConfirmPasswordRg.BackColor = Color.White;
            txtConfirmPasswordRg.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPasswordRg.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPasswordRg.Location = new Point(79, 282);
            txtConfirmPasswordRg.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPasswordRg.Name = "txtConfirmPasswordRg";
            txtConfirmPasswordRg.Size = new Size(200, 25);
            txtConfirmPasswordRg.TabIndex = 24;
            txtConfirmPasswordRg.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(79, 256);
            label13.Name = "label13";
            label13.Size = new Size(117, 20);
            label13.TabIndex = 23;
            label13.Text = "Confirmar senha";
            // 
            // txtPasswordRg
            // 
            txtPasswordRg.BackColor = Color.White;
            txtPasswordRg.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordRg.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordRg.Location = new Point(79, 223);
            txtPasswordRg.Margin = new Padding(3, 4, 3, 4);
            txtPasswordRg.Name = "txtPasswordRg";
            txtPasswordRg.Size = new Size(200, 25);
            txtPasswordRg.TabIndex = 22;
            txtPasswordRg.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(79, 201);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 21;
            label14.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(102, 28);
            label4.Name = "label4";
            label4.Size = new Size(145, 30);
            label4.TabIndex = 19;
            label4.Text = "ANIMES HUB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(93, 58);
            label7.Name = "label7";
            label7.Size = new Size(161, 30);
            label7.TabIndex = 18;
            label7.Text = "Crie uma conta";
            // 
            // lblEntrarContaRg
            // 
            lblEntrarContaRg.AutoSize = true;
            lblEntrarContaRg.Location = new Point(201, 451);
            lblEntrarContaRg.Name = "lblEntrarContaRg";
            lblEntrarContaRg.Size = new Size(48, 20);
            lblEntrarContaRg.TabIndex = 17;
            lblEntrarContaRg.TabStop = true;
            lblEntrarContaRg.Text = "Entrar";
            lblEntrarContaRg.Click += lblEntrarContaRg_Click;
            // 
            // txtUsernameRg
            // 
            txtUsernameRg.BackColor = Color.White;
            txtUsernameRg.BorderStyle = BorderStyle.FixedSingle;
            txtUsernameRg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsernameRg.ForeColor = Color.Black;
            txtUsernameRg.Location = new Point(79, 116);
            txtUsernameRg.Margin = new Padding(3, 4, 3, 4);
            txtUsernameRg.Name = "txtUsernameRg";
            txtUsernameRg.Size = new Size(200, 29);
            txtUsernameRg.TabIndex = 1;
            // 
            // txtEmailRg
            // 
            txtEmailRg.BackColor = Color.White;
            txtEmailRg.BorderStyle = BorderStyle.FixedSingle;
            txtEmailRg.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailRg.Location = new Point(79, 173);
            txtEmailRg.Margin = new Padding(3, 4, 3, 4);
            txtEmailRg.Name = "txtEmailRg";
            txtEmailRg.Size = new Size(200, 25);
            txtEmailRg.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 149);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 15;
            label8.Text = "Email";
            // 
            // lblMensagemRg
            // 
            lblMensagemRg.AutoSize = true;
            lblMensagemRg.BackColor = Color.Transparent;
            lblMensagemRg.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagemRg.Location = new Point(81, 318);
            lblMensagemRg.Name = "lblMensagemRg";
            lblMensagemRg.Size = new Size(0, 22);
            lblMensagemRg.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(76, 92);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 14;
            label10.Text = "Login";
            // 
            // CriarConta
            // 
            CriarConta.BackColor = Color.White;
            CriarConta.FlatStyle = FlatStyle.Flat;
            CriarConta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CriarConta.Location = new Point(114, 356);
            CriarConta.Margin = new Padding(3, 4, 3, 4);
            CriarConta.Name = "CriarConta";
            CriarConta.Size = new Size(125, 36);
            CriarConta.TabIndex = 4;
            CriarConta.Text = "Criar Conta";
            CriarConta.UseVisualStyleBackColor = false;
            CriarConta.Click += CriarConta_Click;
            // 
            // btnSairRegister
            // 
            btnSairRegister.AutoSize = true;
            btnSairRegister.Location = new Point(160, 417);
            btnSairRegister.Name = "btnSairRegister";
            btnSairRegister.Size = new Size(34, 20);
            btnSairRegister.TabIndex = 8;
            btnSairRegister.Text = "Sair";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(88, 451);
            label12.Name = "label12";
            label12.Size = new Size(116, 20);
            label12.TabIndex = 9;
            label12.Text = "Ja possui conta?";
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources._152fb4ace5ee77532a590497ed417a90;
            pictureBox1.Location = new Point(328, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
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
            Controls.Add(picImagem2);
            Controls.Add(pictureBox1);
            Controls.Add(pnlRegister);
            Controls.Add(pnlLogin);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)picImagem2).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUsername;
        private Button btnLogin;
        private Label lblMensagem;
        private Label btnSairLogin;
        private Label label3;
        private TextBox txtPassword;
        private PictureBox picImagem2;
        private Label label5;
        private Label label6;
        private LinkLabel linkForgotPassword;
        private LinkLabel linkRegister;
        private Panel pnlLogin;
        private Panel pnlSombra;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel pnlRegister;
        private Label label4;
        private Label label7;
        private LinkLabel lblEntrarContaRg;
        private TextBox txtUsernameRg;
        private TextBox txtEmailRg;
        private Label label8;
        private Label lblMensagemRg;
        private Label label10;
        private Button CriarConta;
        private Label btnSairRegister;
        private Label label12;
        private TextBox txtConfirmPasswordRg;
        private Label label13;
        private TextBox txtPasswordRg;
        private Label label14;
        private PictureBox pictureBox1;
    }
}