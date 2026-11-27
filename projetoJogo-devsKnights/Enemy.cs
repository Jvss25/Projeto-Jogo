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
        public int Velocidade { get; set; } = 4;
        public int Vida { get; set; } = 3;

        public Enemy(int x, int y)
        {
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.StretchImage;
            String caminhoImagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "onca.png"
                );
            if (File.Exists(caminhoImagem))
            {
                Image = Image.FromFile(caminhoImagem);
            }
            else
            {
                BackColor= Color.Red;
            }
            Left = x;
            Top = y;
        }

        public virtual void Mover()
        {
            Left = Velocidade;
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
