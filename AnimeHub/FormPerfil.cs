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
    public partial class FormPerfil : Form
    {
        private Usuario usuario;
        public FormPerfil(Usuario usuarioLogado)
        {
            InitializeComponent();
            usuario = usuarioLogado;
            CarregarPerfil();
            AplicarTema();
        }

        public void CarregarPerfil()
        {
            lblUsuario.Text = usuario.Username;

            var assistidos = usuario.Animes.Where(a => a.Status == "Assistido").Take(3).ToList();
            var paraAssistir = usuario.Animes.Where(a => a.Status == "Para Assistir").Take(3).ToList();

            lblAssistidos.Text = $"Assistidos: {assistidos.Count}";
            lblParaAssistir.Text = $"Para Assistir: {paraAssistir.Count}";

            flowAssistidos.Controls.Clear();
            flowParaAssistir.Controls.Clear();

            foreach (var anime in assistidos)
                flowAssistidos.Controls.Add(CriarCardAnime(anime));

            foreach (var anime in paraAssistir)
                flowParaAssistir.Controls.Add(CriarCardAnime(anime));
        }

        private void btnAdicionarAnime_Click(object sender, EventArgs e)
        {
            FormAddAnime addAnimeForm = new FormAddAnime();
            addAnimeForm.ShowDialog();

        }
        private void AplicarTema()
        {
            // Fundo geral
            this.BackColor = Color.Orange;

            // === FOTO DE PERFIL ===
            pictureBoxPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPerfil.BorderStyle = BorderStyle.None;

            // Tornar redondo
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBoxPerfil.Width - 1, pictureBoxPerfil.Height - 1);
            pictureBoxPerfil.Region = new Region(path);

            // === LABELS ===
            lblUsuario.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;

            lblAssistidos.ForeColor = Color.White;
            lblParaAssistir.ForeColor = Color.White;

            // === BOTÃO ADICIONAR ===
            btnAdicionarAnime.BackColor = Color.White;
            btnAdicionarAnime.ForeColor = Color.DarkOrange;
            btnAdicionarAnime.FlatStyle = FlatStyle.Flat;
            btnAdicionarAnime.FlatAppearance.BorderSize = 0;
            btnAdicionarAnime.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAdicionarAnime.Cursor = Cursors.Hand;
        }

        private Panel CriarCardAnime(Anime anime)
        {
            Panel card = new Panel();
            card.Width = 120;
            card.Height = 160;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Padding = new Padding(5);
            card.BorderStyle = BorderStyle.None;
            card.Cursor = Cursors.Hand;

            // Borda arredondada
            card.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.DarkOrange, 3))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    var rect = new Rectangle(1, 1, card.Width - 3, card.Height - 3);
                    e.Graphics.DrawRoundedRectangle(pen, rect, 15);
                }
            };

            PictureBox img = new PictureBox();
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Width = 100;
            img.Height = 100;
            //img.ImageLocation = anime.ImagemUrl; // propriedade da classe Anime
            img.Dock = DockStyle.Top;

            Label lblNome = new Label();
            //lblNome.Text = anime.Nome;
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            lblNome.Dock = DockStyle.Bottom;
            lblNome.ForeColor = Color.DarkOrange;
            lblNome.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblNome.Height = 40;

            card.Controls.Add(lblNome);
            card.Controls.Add(img);

            return card;
        }

    }
    public static class GraphicsExtensions
    {
        public static void DrawRoundedRectangle(this Graphics g, Pen pen, Rectangle rect, int radius)
        {
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int d = radius * 2;
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                path.CloseFigure();
                g.DrawPath(pen, path);
            }
        }
    }

}
