using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic.Devices;

namespace projetoJogo_devsKnights
{
    public class Player : PictureBox
    {
        public Player()
        {
            Size = new System.Drawing.Size(200, 200);
            SizeMode = PictureBoxSizeMode.StretchImage;
            string caminhoImagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "capivara.png"
                );
                Image = Image.FromFile(caminhoImagem);


            Function walk()
            {
                if (Keyboard.is)
                {

                }
            }
        }
    }
}
