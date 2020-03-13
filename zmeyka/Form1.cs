using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zmeyka
{
    public partial class Form1 : Form
    {
        kletki k;
<<<<<<< HEAD
        controller.direction dir;
        public Form1()
        {
            InitializeComponent();
            gameStart();
        }

        public void gameStart()
        {
            this.DoubleBuffered = true;
            dir = controller.direction.pause;
=======
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            ClientSize = new Size(600, 600);
            controller.rand = new Random();
            this.Text = "PHYTON";
            k = new kletki(50, 50);
            controller.client = ClientSize;
            controller.kletka = k;
            controller.direct = controller.direction.pause;
            controller.phyton = new zmeya();
            controller.eat = new eda();
<<<<<<< HEAD
            controller.score = 2;
            timer1.Start();
        }

        public void gameWin()
        {
            timer1.Stop();
            MessageBox.Show("Вы выйграли!");
            gameStart();
        }

        public void gameLose()
        {
            timer1.Stop();
            MessageBox.Show("Вы проиграли!");
            gameStart();
        }
=======
            timer1.Start();
        }

>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            controller.phyton.draw(e.Graphics);
            controller.eat.draw(e.Graphics);
            k.draw(e.Graphics, ClientSize);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
<<<<<<< HEAD
            controller.direct = dir;
            if (controller.score + 1 >= (controller.client.Height / controller.kletka.height) * (controller.client.Width / controller.kletka.width))
            {
                gameWin();
            }
            controller.refresh();
            if (controller.score > 2)
            {
                if (controller.phyton.golova.x == controller.phyton.hvost.x && controller.phyton.golova.y == controller.phyton.hvost.y)
                    gameLose();
                foreach (gameBlock gb in controller.phyton.telo)
                {
                    if (gb.x == controller.phyton.golova.x && gb.y == controller.phyton.golova.y)
                        gameLose();
                }
            }
=======
            controller.refresh();
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
            Refresh();
            this.Text = "PHYTON. SCORE: " + controller.score;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
<<<<<<< HEAD
            if (e.KeyCode == Keys.W && controller.direct != controller.direction.down)
                dir = controller.direction.up;
            else if (e.KeyCode == Keys.A && controller.direct != controller.direction.right)
                dir = controller.direction.left;
            else if (e.KeyCode == Keys.S && controller.direct != controller.direction.up)
                dir = controller.direction.down;
            else if (e.KeyCode == Keys.D && controller.direct != controller.direction.left)
                dir = controller.direction.right;
            else if (e.KeyCode == Keys.Space)
            {
                controller.direct = controller.direction.pause;
                dir = controller.direction.pause;
            }
=======
            if (e.KeyCode == Keys.W)
                controller.direct = controller.direction.up;
            else if (e.KeyCode == Keys.A)
                controller.direct = controller.direction.left;
            else if (e.KeyCode == Keys.S)
                controller.direct = controller.direction.down;
            else if (e.KeyCode == Keys.D)
                controller.direct = controller.direction.right;
            else if (e.KeyCode == Keys.Space)
                controller.direct = controller.direction.pause;
>>>>>>> 3a5bf11e5bee5e69e7492dd1fe5a0f4015b0637b
        }
    }
}
