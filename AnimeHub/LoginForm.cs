using AnimeHub.Data;
using AnimeHub.Forms;

namespace AnimeHub
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            pnlLogin.Visible = true;
            pnlRegister.Visible = false;
            pictureBox1.Visible = true;
            picImagem2.Visible = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            lblMensagem.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMensagem.Text = "Preencha todos os campos.";
                return;
            }

            using (var db = new AnimeContext())
            {
                db.Database.EnsureCreated(); // cria tabelas se não existirem

                var usuario = db.Usuarios.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (usuario != null)
                {
                    // Abre perfil
                    FrmTelaInicial perfil = new FrmTelaInicial(usuario);
                    perfil.Show();
                    this.Hide();
                }
                else
                {
                    lblMensagem.Text = "Usuário ou senha incorretos.";
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            ConfigurarLabelComoButton(btnSairLogin);
            ConfigurarLabelComoButton(btnSairRegister);
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlEsqueceuSenha recuperarSenha = new pnlEsqueceuSenha();
            recuperarSenha.ShowDialog();
        }

        private void linkRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlLogin.Visible = false;
            pictureBox1.Visible = false;
            picImagem2.Visible = true;

            lblMensagem.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";

        }

        private void ConfigurarLabelComoButton(Label lblBtn)
        {
            lblBtn.Cursor = Cursors.Hand;

            lblBtn.MouseEnter += (s, e2) => { lblBtn.ForeColor = Color.Red; };

            lblBtn.MouseLeave += (s, e2) => { lblBtn.ForeColor = Color.Black; };

            lblBtn.MouseClick += (s, e2) => { Application.Exit(); };
        }

        private void CriarConta_Click(object sender, EventArgs e)
        {
            using (var db = new AnimeContext())
            {
                string username = txtUsernameRg.Text.Trim();
                string email = txtEmailRg.Text.Trim();
                string password = txtPasswordRg.Text.Trim();
                string confirmPassword = txtConfirmPasswordRg.Text.Trim();

                lblMensagemRg.ForeColor = Color.Red;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    lblMensagemRg.Text = "Preencha todos os campos.";
                    return;
                }

                if (db.Usuarios.Any(u => u.Username == username))
                {
                    lblMensagemRg.Text = "Usuário já existe!";
                    return;
                }
                if (db.Usuarios.Any(u => u.Email == email))
                {
                    lblMensagemRg.Text = "Email ja cadastrado!";
                    return;
                }

                if (password != confirmPassword)
                {
                    lblMensagemRg.Text = "As senhas devem ser iguais.";
                    return;

                }



                lblMensagemRg.Text = "Usuário cadastrado com sucesso!";
            }
        }

        private void lblEntrarContaRg_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
            pictureBox1.Visible = true;
            picImagem2.Visible = false;

            txtUsernameRg.Text = "";
            txtEmailRg.Text = "";
            txtPasswordRg.Text = "";
            txtPasswordRg.Text = "";
            txtConfirmPasswordRg.Text = "";

            lblMensagemRg.Text = "";
        }
    }
}
