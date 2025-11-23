namespace AnimeHub.Forms
{
    partial class pnlEsqueceuSenha
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
            btnRedefinirSenha = new Button();
            lblRedefinirSenhaName = new Label();
            txtEmailRS = new TextBox();
            lblInfoRS = new Label();
            lblVoltarLogin = new LinkLabel();
            lblEmailRS = new Label();
            SuspendLayout();
            // 
            // btnRedefinirSenha
            // 
            btnRedefinirSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRedefinirSenha.Location = new Point(118, 132);
            btnRedefinirSenha.Name = "btnRedefinirSenha";
            btnRedefinirSenha.Size = new Size(174, 39);
            btnRedefinirSenha.TabIndex = 0;
            btnRedefinirSenha.Text = "REDEFINIR SENHA";
            btnRedefinirSenha.UseVisualStyleBackColor = true;
            // 
            // lblRedefinirSenhaName
            // 
            lblRedefinirSenhaName.AutoSize = true;
            lblRedefinirSenhaName.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRedefinirSenhaName.Location = new Point(16, 9);
            lblRedefinirSenhaName.Name = "lblRedefinirSenhaName";
            lblRedefinirSenhaName.Size = new Size(187, 31);
            lblRedefinirSenhaName.TabIndex = 2;
            lblRedefinirSenhaName.Text = "Redefinir Senha";
            // 
            // txtEmailRS
            // 
            txtEmailRS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmailRS.Location = new Point(109, 89);
            txtEmailRS.Name = "txtEmailRS";
            txtEmailRS.Size = new Size(276, 29);
            txtEmailRS.TabIndex = 3;
            txtEmailRS.Text = "dsanmike12@gmail.com";
            // 
            // lblInfoRS
            // 
            lblInfoRS.AutoSize = true;
            lblInfoRS.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoRS.Location = new Point(25, 53);
            lblInfoRS.Name = "lblInfoRS";
            lblInfoRS.Size = new Size(414, 19);
            lblInfoRS.TabIndex = 4;
            lblInfoRS.Text = "Informe o e-mail para o qual deseja redefinir a sua senha.";
            // 
            // lblVoltarLogin
            // 
            lblVoltarLogin.AutoSize = true;
            lblVoltarLogin.Location = new Point(154, 182);
            lblVoltarLogin.Name = "lblVoltarLogin";
            lblVoltarLogin.Size = new Size(86, 15);
            lblVoltarLogin.TabIndex = 5;
            lblVoltarLogin.TabStop = true;
            lblVoltarLogin.Text = "Voltar ao Login";
            lblVoltarLogin.LinkClicked += lblVoltarLogin_LinkClicked;
            // 
            // lblEmailRS
            // 
            lblEmailRS.AutoSize = true;
            lblEmailRS.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailRS.Location = new Point(25, 90);
            lblEmailRS.Name = "lblEmailRS";
            lblEmailRS.Size = new Size(78, 25);
            lblEmailRS.TabIndex = 6;
            lblEmailRS.Text = "E-mail:";
            // 
            // pnlEsqueceuSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 212);
            Controls.Add(lblEmailRS);
            Controls.Add(lblVoltarLogin);
            Controls.Add(lblInfoRS);
            Controls.Add(txtEmailRS);
            Controls.Add(lblRedefinirSenhaName);
            Controls.Add(btnRedefinirSenha);
            Name = "pnlEsqueceuSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEsqueceuSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRedefinirSenha;
        private Label lblRedefinirSenhaName;
        private TextBox txtEmailRS;
        private Label lblInfoRS;
        private LinkLabel lblVoltarLogin;
        private Label lblEmailRS;
    }
}