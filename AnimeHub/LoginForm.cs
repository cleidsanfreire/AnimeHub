using AnimeHub.Data;
using AnimeHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeHub
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (var db = new AnimeContext())
            {
                string username = Microsoft.VisualBasic.Interaction.InputBox("Digite um nome de usuário:", "Cadastrar");
                string password = Microsoft.VisualBasic.Interaction.InputBox("Digite a senha:", "Cadastrar");

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Usuário e senha não podem ficar vazios.");
                    return;
                }

                if (db.Usuarios.Any(u => u.Username == username))
                {
                    MessageBox.Show("Usuário já existe!");
                    return;
                }

                var novoUsuario = new Usuario
                {
                    Username = username,
                    Password = password
                };

                db.Usuarios.Add(novoUsuario);
                db.SaveChanges();

                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

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
                    FormPerfil perfil = new FormPerfil(usuario);
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

            btnSairLogin.Cursor = Cursors.Hand;

            btnSairLogin.MouseEnter += (s, e2) =>
            {
                btnSairLogin.ForeColor = Color.Red;
            };

            btnSairLogin.MouseLeave += (s, e2) =>
            {
                btnSairLogin.ForeColor = Color.Black;
            };

            btnSairLogin.MouseClick += (s, e2) =>
            {
                Application.Exit();
            };
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //RecuperarSenhaForm recuperarSenha = new RecuperarSenhaForm();
            //recuperarSenha.Show();
        }

        private void linkRegister_Click(object sender, EventArgs e)
        {
            //RegisterForm register = new RegisterForm();
            //register.Show();
        }
    }
}
