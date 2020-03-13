using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeyka
{
    public class kletki
    {
        public int width = 50, height = 50;
        public kletki(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void draw(Graphics g, Size client) 
        {
            for(int x = 0; x<client.Width; x+=width) 
            {
                for(int y = 0; y<client.Height; y+=height)
                {
                    g.DrawLine(new Pen(Brushes.Black), x, y, client.Width, y);
                    g.DrawLine(new Pen(Brushes.Black), x, y, x, client.Height);
                }
                
            }
        }
    }
}
