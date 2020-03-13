using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int score = 1;
        public static Random rand;
        public static direction direct;
        public static kletki kletka;
        public static void refresh()
        {
            if (direct == direction.pause)
                return;
            if (direct == direction.up)
            {
                controller.phyton.telo.Add(phyton.golova);
                phyton.golova.y -= 1;
                if (phyton.golova.y < 0)
                    phyton.golova.y = client.Height/kletka.height-1;
                phyton.hvost = phyton.golova;
            }
            if (direct == direction.down)
            {
                controller.phyton.telo.Add(phyton.golova);
                phyton.golova.y += 1;
                if (phyton.golova.y >= client.Height / kletka.height)
                    phyton.golova.y = 0;
                phyton.hvost = phyton.golova;
            }
            if (direct == direction.left)
            {
                controller.phyton.telo.Add(phyton.golova);
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
                controller.phyton.telo.Add(phyton.golova);
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
                eat = new eda();
            }
        }
    }
}
