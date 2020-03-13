using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Windows.Forms;
=======
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b

namespace zmeyka
{
    public class controller
    {
        public enum direction
        {
            left,
            up,
            right,
            down,
            pause
        }
        public static Size client;
        public static zmeya phyton;
        public static eda eat;
<<<<<<< HEAD
        public static int score;
=======
        public static int score = 1;
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
        public static Random rand;
        public static direction direct;
        public static kletki kletka;
        public static void refresh()
        {
<<<<<<< HEAD
            gameBlock tempHvost = new gameBlock
            {
                x = phyton.hvost.x,
                y = phyton.hvost.y
            };
=======
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
            if (direct == direction.pause)
                return;
            if (direct == direction.up)
            {
<<<<<<< HEAD
                gameBlock tempGolova = new gameBlock();
                tempGolova.x = phyton.golova.x;
                tempGolova.y = phyton.golova.y;
                controller.phyton.telo.Add(tempGolova);
=======
                controller.phyton.telo.Add(phyton.golova);
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
                phyton.golova.y -= 1;
                if (phyton.golova.y < 0)
                    phyton.golova.y = client.Height/kletka.height-1;
                phyton.hvost = phyton.golova;
<<<<<<< HEAD
                phyton.golova = phyton.hvost;
                phyton.hvost = phyton.telo.First();
                phyton.telo.Remove(phyton.telo.First());
            }
            if (direct == direction.down)
            {
                gameBlock tempGolova = new gameBlock();
                tempGolova.x = phyton.golova.x;
                tempGolova.y = phyton.golova.y;
                controller.phyton.telo.Add(tempGolova);
=======
            }
            if (direct == direction.down)
            {
                controller.phyton.telo.Add(phyton.golova);
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
                phyton.golova.y += 1;
                if (phyton.golova.y >= client.Height / kletka.height)
                    phyton.golova.y = 0;
                phyton.hvost = phyton.golova;
<<<<<<< HEAD
                phyton.golova = phyton.hvost;
                phyton.hvost = phyton.telo.First();
                phyton.telo.Remove(phyton.telo.First());
            }
            if (direct == direction.left)
            {
                gameBlock tempGolova = new gameBlock();
                tempGolova.x = phyton.golova.x;
                tempGolova.y = phyton.golova.y;
                controller.phyton.telo.Add(tempGolova);
=======
            }
            if (direct == direction.left)
            {
                controller.phyton.telo.Add(phyton.golova);
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
                phyton.golova.x -= 1;
                if (phyton.golova.x < 0)
                    phyton.golova.x = client.Width / kletka.width-1;
                phyton.hvost = phyton.golova;
                phyton.golova = phyton.hvost;
                phyton.hvost = phyton.telo.First();
                phyton.telo.Remove(phyton.telo.First());
            }
            if (direct == direction.right)
            {
<<<<<<< HEAD
                gameBlock tempGolova = new gameBlock();
                tempGolova.x = phyton.golova.x;
                tempGolova.y = phyton.golova.y;
                controller.phyton.telo.Add(tempGolova);
=======
                controller.phyton.telo.Add(phyton.golova);
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
                phyton.golova.x += 1;
                if (phyton.golova.x >= client.Height / kletka.height)
                    phyton.golova.x = 0;
                phyton.hvost = phyton.golova;
                phyton.golova = phyton.hvost;
                phyton.hvost = phyton.telo.First();
                phyton.telo.Remove(phyton.telo.First());
            }
            if (phyton.golova.x == eat.block.x && phyton.golova.y == eat.block.y)
            {
                score++;
<<<<<<< HEAD
                gameBlock afterHvost = new gameBlock { x = phyton.hvost.x, y = phyton.hvost.y };
                eat = new eda();
                controller.phyton.telo.Insert(0, afterHvost);
                phyton.hvost = new gameBlock { x = tempHvost.x, y = tempHvost.y };
=======
                eat = new eda();
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
            }
        }
    }
}
