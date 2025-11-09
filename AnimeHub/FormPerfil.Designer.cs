namespace AnimeHub
{
    partial class FormPerfil
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
            lblUsuario = new Label();
            btnAdicionarAnime = new Button();
            pictureBoxPerfil = new PictureBox();
            button1 = new Button();
            lblAssistidos = new Label();
            lblParaAssistir = new Label();
            flowAssistidos = new FlowLayoutPanel();
            flowParaAssistir = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(101, 64);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(176, 30);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Nome do Usuário";
            // 
            // btnAdicionarAnime
            // 
            btnAdicionarAnime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarAnime.Location = new Point(463, 10);
            btnAdicionarAnime.Name = "btnAdicionarAnime";
            btnAdicionarAnime.Size = new Size(125, 46);
            btnAdicionarAnime.TabIndex = 2;
            btnAdicionarAnime.Text = "Adicionar";
            btnAdicionarAnime.UseVisualStyleBackColor = true;
            btnAdicionarAnime.Click += btnAdicionarAnime_Click;
            // 
            // pictureBoxPerfil
            // 
            pictureBoxPerfil.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPerfil.Location = new Point(21, 33);
            pictureBoxPerfil.Name = "pictureBoxPerfil";
            pictureBoxPerfil.Size = new Size(74, 61);
            pictureBoxPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerfil.TabIndex = 3;
            pictureBoxPerfil.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(101, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Trocar foto";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblAssistidos
            // 
            lblAssistidos.AutoSize = true;
            lblAssistidos.Location = new Point(21, 127);
            lblAssistidos.Name = "lblAssistidos";
            lblAssistidos.Size = new Size(62, 15);
            lblAssistidos.TabIndex = 5;
            lblAssistidos.Text = "Assistidos:";
            // 
            // lblParaAssistir
            // 
            lblParaAssistir.AutoSize = true;
            lblParaAssistir.Location = new Point(24, 308);
            lblParaAssistir.Name = "lblParaAssistir";
            lblParaAssistir.Size = new Size(71, 15);
            lblParaAssistir.TabIndex = 6;
            lblParaAssistir.Text = "Para assistir:";
            // 
            // flowAssistidos
            // 
            flowAssistidos.Location = new Point(23, 145);
            flowAssistidos.Name = "flowAssistidos";
            flowAssistidos.Size = new Size(340, 136);
            flowAssistidos.TabIndex = 7;
            // 
            // flowParaAssistir
            // 
            flowParaAssistir.Location = new Point(23, 326);
            flowParaAssistir.Name = "flowParaAssistir";
            flowParaAssistir.Size = new Size(340, 136);
            flowParaAssistir.TabIndex = 8;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 517);
            Controls.Add(flowParaAssistir);
            Controls.Add(flowAssistidos);
            Controls.Add(lblParaAssistir);
            Controls.Add(lblAssistidos);
            Controls.Add(button1);
            Controls.Add(pictureBoxPerfil);
            Controls.Add(btnAdicionarAnime);
            Controls.Add(lblUsuario);
            Name = "FormPerfil";
            Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Button btnAdicionarAnime;
        private PictureBox pictureBoxPerfil;
        private Button button1;
        private Label lblAssistidos;
        private Label lblParaAssistir;
        private FlowLayoutPanel flowAssistidos;
        private FlowLayoutPanel flowParaAssistir;
    }
}