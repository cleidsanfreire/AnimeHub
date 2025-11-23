namespace AnimeHub.Forms
{
    partial class FrmTelaInicial
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
            panelMenu = new Panel();
            panel2 = new Panel();
            uC_ResumoPerfil1 = new UC_ResumoPerfil();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaptionText;
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 858);
            panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(uC_ResumoPerfil1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 858);
            panel2.TabIndex = 1;
            // 
            // uC_ResumoPerfil1
            // 
            uC_ResumoPerfil1.Location = new Point(0, 0);
            uC_ResumoPerfil1.Name = "uC_ResumoPerfil1";
            uC_ResumoPerfil1.Size = new Size(974, 881);
            uC_ResumoPerfil1.TabIndex = 0;
            uC_ResumoPerfil1.Load += uC_ResumoPerfil1_Load;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 858);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTelaInicial";
            Load += FrmTelaInicial_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel2;
        private UC_ResumoPerfil uC_ResumoPerfil1;
    }
}