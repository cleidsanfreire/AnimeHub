namespace AnimeHub.Forms
{
    public partial class pnlEsqueceuSenha : Form
    {
        public pnlEsqueceuSenha()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void lblVoltarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
