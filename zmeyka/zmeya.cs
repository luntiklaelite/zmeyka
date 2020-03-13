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
        public snakeBlock golova;
        Random rand;
        public SolidBrush color;

        public zmeya(int width, int height)
        {
            rand = new Random();
            golova = new snakeBlock();
            golova.x = rand.Next(controller.client.Width / controller.kletka.width);
            golova.y = rand.Next(controller.client.Height / controller.kletka.height);
            color = new SolidBrush(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
        }

        public void draw(Graphics g)
        {
            g.FillRectangle(color, controller.kletka.width * golova.x, controller.kletka.height * golova.y, controller.kletka.width, controller.kletka.height);
        }
    }
}
