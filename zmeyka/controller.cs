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
        public static direction direct;
        public static kletki kletka;
        public static void refresh()
        {
            if (direct == direction.pause)
                return;
            if (direct == direction.up)
            {
                if (phyton.golova.Y <= 0)
                    phyton.golova.Y = client.Height - kletka.height;
                else
                    phyton.golova.Y -= kletka.height;
            }
            if (direct == direction.down)
            {
                if (phyton.golova.Y >= client.Height)
                    phyton.golova.Y = 0;
                else
                    phyton.golova.Y += kletka.height;
            }
            if (direct == direction.left)
            {
                if (phyton.golova.X <= 0)
                    phyton.golova.X = client.Width - kletka.width;
                else
                    phyton.golova.X -= kletka.width;
            }
            if (direct == direction.right)
            {
                if (phyton.golova.X >= client.Width)
                    phyton.golova.X = 0;
                else
                    phyton.golova.X += kletka.width;
            }
        }
    }
}
