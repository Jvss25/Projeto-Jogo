using System;
using System.Drawing;
using System.Windows.Forms;

namespace projetoJogo_devsKnights
{
    public partial class Game : Form
    {
        private Player jogador;
        private List<Enemy> inimigos = new List<Enemy>();
        private Random random = new Random();
        private int contadorSpawn = 0;

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

            TxtVida.Text = jogador.Vida.ToString();
            TxtPoints.Text = jogador.Points.ToString();
            
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

        private void CriarInimigo()
        {
            int x = ClientSize.Width;
            int y = random.Next(0, ClientSize.Height - 100);

            Enemy inimigo;

            if (random.Next(0, 100) < 30)
            {
                inimigo = new EnemyRapido(x, y);
            }
            else
            {
                inimigo = new Enemy(x, y);
            }
            if(jogador.Points >= 10)
            {
                inimigo.Velocidade += 2;
            }
            else if (jogador.Points >= 20)
            {
                inimigo.Velocidade += 2;

            }
            else if (jogador.Points >= 30)
            {
                inimigo.Velocidade += 2;

            }
            else if (jogador.Points >= 40)
            {
                inimigo.Velocidade += 2;
            }
            else if (jogador.Points >= 50)
            {
                inimigo.Velocidade += 2;
            }
            inimigos.Add(inimigo);
            Controls.Add(inimigo);
        }

        private void RemoverInimigo(Enemy inimigo)
        {
            Controls.Remove(inimigo);
            inimigos.Remove(inimigo);
            inimigo.Dispose();
        }

        private void RemoverDisparo(Bullet disparo)
        {
            Controls.Remove(disparo);
            jogador.Balas.Remove(disparo);
            disparo.Dispose();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = jogador.Balas.Count - 1; i >= 0; i--)
            {
                Bullet disparo = jogador.Balas[i];

                disparo.Mover();

                if (disparo.SaiuDaTela())
                {
                    RemoverDisparo(disparo);
                }
            }
            contadorSpawn++;
            if (contadorSpawn >= 50)
            {
                CriarInimigo();
                contadorSpawn = 0;
            }

            for (int i = inimigos.Count - 1; i >= 0; i--)
            {
                Enemy inimigo = inimigos[i];
                inimigo.Mover();

                if (inimigo.SaiuDaTela())
                {
                    RemoverInimigo(inimigo);
                    continue;
                }

                for (int j = jogador.Balas.Count - 1; j >= 0; j--)
                {
                    Bullet disparo = jogador.Balas[j];
                    if (disparo.Bounds.IntersectsWith(inimigo.Bounds))
                    {
                        inimigo.ReceberDano();
                        RemoverDisparo(disparo);
                        if (inimigo.Vida <= 0)
                        {
                            jogador.Points++;
                            TxtPoints.Text = jogador.Points.ToString();
                            if (jogador.Points >= 10)
                            {
                                jogador.Vida += 1;
                                TxtVida.Text = jogador.Vida.ToString();
                            }
                            else if (jogador.Points >= 20)
                            {
                                jogador.Vida += 1;
                                TxtVida.Text = jogador.Vida.ToString();
                            }
                            else if (jogador.Points >= 30)
                            {
                                jogador.Vida += 1;
                                TxtVida.Text = jogador.Vida.ToString();
                            }
                            else if (jogador.Points >= 40)
                            {
                                jogador.Vida += 1;
                                TxtVida.Text = jogador.Vida.ToString();
                            }
                            else if (jogador.Points >= 50)
                            {
                                jogador.Vida += 1;
                                TxtVida.Text = jogador.Vida.ToString();
                            }
                        }
                        break;
                    }
                }

                if (inimigo.EstaMorto())
                {
                    RemoverInimigo(inimigo);
                    continue;
                }

                if (jogador.Bounds.IntersectsWith(inimigo.Bounds))
                {
                    jogador.Vida--;
                    TxtVida.Text = jogador.Vida.ToString();
                    RemoverInimigo(inimigo);

                    if (jogador.Vida <= 0)
                    {
                        timer1.Stop();
                        Gameover gameover = new Gameover();
                        gameover.Show();
                        this.Hide();
                    }
                    if (jogador.Points == 50)
                    {
                        timer1.Stop();
                        Vitoria vitoria = new Vitoria();
                        vitoria.Show();
                        this.Hide();
                    }

                }
            }


        }
    }
}
