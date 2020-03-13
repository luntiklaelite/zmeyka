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
        public Rectangle golova;
        Random rand;
        public SolidBrush color;

        public zmeya(int width, int height)
        {
            rand = new Random();
            golova.X = controller.kletka.width * rand.Next(controller.client.Width / controller.kletka.width);
            golova.Y = controller.kletka.height * rand.Next(controller.client.Height / controller.kletka.height);
            golova.Width = controller.kletka.width;
            golova.Height = controller.kletka.height;
            color = new SolidBrush(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
        }

        public void draw(Graphics g)
        {
            g.FillRectangle(color, golova);
        }
    }
}
