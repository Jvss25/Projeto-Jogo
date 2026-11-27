using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projetoJogo_devsKnights
{
    public class EnemyRapido : Enemy
    {

        private int direcaoVertical = 1; 
        public EnemyRapido(int x, int y): base(x, y, "harpia.png") 
        {

            Velocidade = 10;
            Vida = 1;
            Size = new Size(70, 70);
        }

        public override void Mover()
        {
            base.Mover();
            Top += direcaoVertical * 3;
            if (Top <= 0 || Top + Height >= Parent.ClientSize.Height)
            {
                direcaoVertical *= -1;
            }
        }
    }
}
