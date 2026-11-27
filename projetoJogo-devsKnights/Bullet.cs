using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projetoJogo_devsKnights
{
    public class Bullet : PictureBox
    {
        public int Velocidade { get; set; } = 10;

        public Bullet(int x, int y)
        {
            Size = new Size(30, 30);
            SizeMode = PictureBoxSizeMode.StretchImage;

            string caminhoImagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "bullet.png"
            );
            Image = Image.FromFile(caminhoImagem);
            BackColor = Color.Transparent;
            Left = x;
            Top = y;
        }

        public void Mover()
        {
            Left += Velocidade;
        }

        public bool SaiuDaTela()
        {
            return Left + Width > 1920;
        }
    }
}