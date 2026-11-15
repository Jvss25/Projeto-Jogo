
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projetoJogo_devsKnights
{
    public class Player : PictureBox
    {
        public List<Bullet> Balas { get; set; } = new List<Bullet>();

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
