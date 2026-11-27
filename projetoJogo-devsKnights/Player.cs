
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace projetoJogo_devsKnights
{
    public class Player : PictureBox
    {
        public List<Bullet> Balas { get; set; } = new List<Bullet>();

        public int Points { get; set; } = 48;

        public int Velocidade{get;set;} = 20;
        public int Vida { get; set; } = 10;
        public Player()
        {
            
            Size = new Size(200, 200);
            SizeMode = PictureBoxSizeMode.StretchImage;

            string caminhoImagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "capivara.png"
            );

            Image = Image.FromFile(caminhoImagem);
            BackColor = Color.Transparent;
        }

            
            
        
        public void Mover(Keys tecla, int larguraTela, int alturaTela)
        {
           if (tecla == Keys.W || tecla == Keys.Up)
            {
                Top -= Velocidade;

                if (Top+Height < 0)
                {
                    Top = alturaTela;
                }
            }

            else if (tecla == Keys.A || tecla == Keys.Left)
            {
                Left -= Velocidade;
                if (Left+Width < 0)
                {
                    Left = larguraTela;
                }
            }

            else if (tecla == Keys.S || tecla == Keys.Down)
            {
                Top += Velocidade;
                if (Top > alturaTela)
                {
                    Top = -Height;
                }
            }

            else if(tecla == Keys.D || tecla == Keys.Right)
            {
                Left += Velocidade;

                if(Left > larguraTela)
                {
                    Left = -Width;
                }
            }
        }

   
        public Bullet Atirar()
        {
            Bullet bala = new Bullet(
                 Left + (Width / 2) - 10,
                  Top + 100
            );

            Balas.Add(bala);
            return bala;

        }
    }
}
