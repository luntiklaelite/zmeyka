using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeyka
{
    public class eda
    {
        public gameBlock block;
        SolidBrush color;
        public eda()
        {
            block = new gameBlock();
            Random rand = controller.rand;
            block.x = controller.rand.Next(controller.client.Width / controller.kletka.width);
            block.y = controller.rand.Next(controller.client.Height / controller.kletka.height);
            color = new SolidBrush(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
        }
        public void draw(Graphics g) 
        {
            g.FillEllipse(color, block.x * controller.kletka.width, block.y * controller.kletka.height, controller.kletka.width, controller.kletka.height);
        }
    }
}
