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

namespace AnimeHub.Forms
{
    public partial class FrmTelaInicial : Form
    {
        private Usuario usuario;
        public FrmTelaInicial(Usuario usuario)
        {
            InitializeComponent();
        }

        private void FrmTelaInicial_Load(object sender, EventArgs e)
        {
            panelMenu.BackColor = Color.FromArgb(18, 18, 18); // fundo escuro elegante
        }

        private void uC_ResumoPerfil1_Load(object sender, EventArgs e)
        {

        }
    }
}
