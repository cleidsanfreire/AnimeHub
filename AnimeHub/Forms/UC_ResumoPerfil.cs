

namespace AnimeHub.Forms
{
    public partial class UC_ResumoPerfil : UserControl
    {
        public UC_ResumoPerfil()
        {
            InitializeComponent();
        }

        private void AddFavoritos()
        {
            flowFavoritos.Controls.Clear();

            string[] imagens =
            {
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav1.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav2.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav3.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav3.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav3.jpg"
            };


            foreach (string caminho in imagens)
            {
                Panel card = new Panel();
                card.Size = new Size(130, 180);
                card.Margin = new Padding(10);

                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 140);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.ImageLocation = caminho;
                pic.Margin = new Padding(10);
                card.Controls.Add(pic);

                Label lblNome = new Label();
                lblNome.Text = System.IO.Path.GetFileNameWithoutExtension(caminho);
                lblNome.Dock = DockStyle.Bottom;
                lblNome.TextAlign = ContentAlignment.MiddleCenter;
                lblNome.ForeColor = Color.Black;
                lblNome.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                card.Controls.Add(lblNome);

                flowFavoritos.Controls.Add(card);
            }
        }

        private void AddProximos()
        {
            flowProximos.Controls.Clear();
           

            string[] imagens =
            {
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav1.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav2.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav3.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav3.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav3.jpg"
            };

            foreach (string caminho in imagens)
            {
                Panel card = new Panel();
                card.Size = new Size(130, 180);
                card.Margin = new Padding(10);

                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 140);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.ImageLocation = caminho;
                pic.Margin = new Padding(10);
                card.Controls.Add(pic);

                Label lblNome = new Label();
                lblNome.Text = System.IO.Path.GetFileNameWithoutExtension(caminho);
                lblNome.Dock = DockStyle.Bottom;
                lblNome.TextAlign = ContentAlignment.MiddleCenter;
                lblNome.ForeColor = Color.Black;
                lblNome.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                card.Controls.Add(lblNome);

                flowProximos.Controls.Add(card);
            }
        }

        private void AddUltimosAssistidos()
        {
            flowUltimos.Controls.Clear();

            string[] ultimos =
            {
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav1.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav2.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav3.jpg",
                "C:\\Users\\loock\\Downloads\\Nova pasta\\fav3.jpg"
            };

            foreach (string caminho in ultimos)
            {
                Panel card = new Panel();
                card.Size = new Size(130, 180);
                card.Margin = new Padding(10);

                PictureBox pic = new PictureBox();
                pic.Size = new Size(130, 150);
                pic.Dock = DockStyle.Top;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.ImageLocation = caminho;
                card.Controls.Add(pic);

                Label lblNome = new Label();
                lblNome.Text = System.IO.Path.GetFileNameWithoutExtension(caminho);
                lblNome.Dock = DockStyle.Bottom;
                lblNome.TextAlign = ContentAlignment.MiddleCenter;
                lblNome.ForeColor = Color.Black;
                lblNome.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                card.Controls.Add(lblNome);

                flowUltimos.Controls.Add(card);
            }
        }

        private void UC_ResumoPerfil_Load(object sender, EventArgs e)
        {
            AddFavoritos();
            AddProximos();
            AddUltimosAssistidos();
        }
    }
}
