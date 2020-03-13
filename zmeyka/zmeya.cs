using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeyka
{
    public class zmeya
    {
        public gameBlock golova;
        public List<gameBlock> telo;
        public gameBlock hvost;
        public SolidBrush color;

        public zmeya()
        {
            golova = new gameBlock();
            hvost = new gameBlock();
            Random rand = controller.rand;
            golova.x = controller.rand.Next(controller.client.Width / controller.kletka.width);
            golova.y = controller.rand.Next(controller.client.Height / controller.kletka.height);
<<<<<<< HEAD
            hvost.x = golova.x;
=======
            hvost.x = golova.x-1;
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
            hvost.y = golova.y;
            telo = new List<gameBlock>();
            color = new SolidBrush(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
        }

        public void draw(Graphics g)
        {
<<<<<<< HEAD
            g.FillRectangle(Brushes.Black, controller.kletka.width * golova.x, controller.kletka.height * golova.y, controller.kletka.width, controller.kletka.height);
=======
            g.FillRectangle(color, controller.kletka.width * golova.x, controller.kletka.height * golova.y, controller.kletka.width, controller.kletka.height);
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
            foreach (gameBlock gb in telo)
            {
                g.FillRectangle(color, controller.kletka.width * gb.x, controller.kletka.height * gb.y, controller.kletka.width, controller.kletka.height);
            }
            g.FillRectangle(color, controller.kletka.width * hvost.x, controller.kletka.height * hvost.y, controller.kletka.width, controller.kletka.height);
        }
    }
}
