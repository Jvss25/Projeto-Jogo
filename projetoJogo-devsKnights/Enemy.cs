using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace projetoJogo_devsKnights
{
    public class Enemy : PictureBox
    {
        public int Velocidade { get; set; } = 5;
        public int Vida { get; set; } = 3;

        public Enemy(int x, int y, string imagem)
        {
            string caminhoImagem = Path.Combine(
              Application.StartupPath,
              "assets",
              imagem
          );

            Image = Image.FromFile(caminhoImagem);

            Location = new Point(x, y);
            SizeMode = PictureBoxSizeMode.StretchImage;

            if (File.Exists(caminhoImagem))
            {
                Image = Image.FromFile(caminhoImagem);
                BackColor = Color.Transparent;
            }
            else
            {
                BackColor= Color.Red;
            }
            Left = x;
            Top = y;
        }

        public Enemy(int x, int y) : this(x, y, "onca.png")
        {
            Size = new Size(130, 100);
        }

        public virtual void Mover()
        {
            Left -= Velocidade;
        }

        public void ReceberDano(int dano = 1)
        {
            Vida -= dano;
        }

        public bool EstaMorto()
        {
            return Vida <= 0;
        }

        public bool SaiuDaTela()
        {
            return Left + Width < 0;
        }
    }
}
