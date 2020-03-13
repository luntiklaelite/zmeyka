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
<<<<<<< HEAD
            makeRandomBlock();
            color = new SolidBrush(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
        }

        public void makeRandomBlock()
        {
            block.x = controller.rand.Next(controller.client.Width / controller.kletka.width);
            block.y = controller.rand.Next(controller.client.Height / controller.kletka.height);
            if (block.x == controller.phyton.golova.x && block.y == controller.phyton.golova.y || block.x == controller.phyton.hvost.x && block.y == controller.phyton.hvost.y)
                makeRandomBlock();
            foreach (gameBlock gb in controller.phyton.telo)
            {
                if (gb.x == block.x && gb.y == block.y)
                    makeRandomBlock();
            }
        }

=======
            block.x = controller.rand.Next(controller.client.Width / controller.kletka.width);
            block.y = controller.rand.Next(controller.client.Height / controller.kletka.height);
            color = new SolidBrush(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
        }
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
        public void draw(Graphics g) 
        {
            g.FillEllipse(color, block.x * controller.kletka.width, block.y * controller.kletka.height, controller.kletka.width, controller.kletka.height);
        }
    }
}
