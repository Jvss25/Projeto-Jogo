using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoJogo_devsKnights
{
    public partial class Game : Form
    {
        private Player jogador;
        public Game()
        {
            InitializeComponent();
            iniciarJogo();
        }

        public void iniciarJogo()
        {
            jogador = new Player();
            jogador.Location = new Point(50, 340);
            Controls.Add(jogador);
        }
    }
}
