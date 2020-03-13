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
                phyton.golova.y -= 1;
                if (phyton.golova.y < 0)
                    phyton.golova.y = client.Height/kletka.height-1;                   
            }
            if (direct == direction.down)
            {
                phyton.golova.y += 1;
                if (phyton.golova.y >= client.Height / kletka.height)
                    phyton.golova.y = 0;     
            }
            if (direct == direction.left)
            {
                phyton.golova.x -= 1;
                if (phyton.golova.x < 0)
                    phyton.golova.x = client.Width / kletka.width-1;
            }
            if (direct == direction.right)
            {
                phyton.golova.x += 1;
                if (phyton.golova.x >= client.Height / kletka.height)
                    phyton.golova.x = 0;
            }
        }
    }
}
