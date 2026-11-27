using System;
using System.Drawing;
using System.Windows.Forms;

namespace projetoJogo_devsKnights
{
    public partial class Game : Form
    {
        private Player jogador;

        public Game()
        {
            InitializeComponent();

            DoubleBuffered = true;

            iniciarJogo();

            
            KeyPreview = true;
            KeyDown += Game_KeyDown;

        }

        public void iniciarJogo()
        {
            jogador = new Player();
            jogador.Location = new Point(50, 340);
            Controls.Add(jogador);
            string vida = jogador.vida.ToString();
            string points = jogador.points.ToString();
            TxtVida.Text = vida;
            TxtPoints.Text = points;
        }

        

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            jogador.Mover(e.KeyCode, ClientSize.Width, ClientSize.Height);

            if (e.KeyCode == Keys.Space)
            {
                Bullet bala = jogador.Atirar();
                Controls.Add(bala);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = jogador.Balas.Count - 1; i >= 0; i--)
            {
                Bullet bala = jogador.Balas[i];

                bala.Mover();

                if (bala.SaiuDaTela())
                {
                    Controls.Remove(bala);

                    jogador.Balas.RemoveAt(i);

                    bala.Dispose();
                }
            }
        }
    }
}
