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
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            controller.phyton.draw(e.Graphics);
            controller.eat.draw(e.Graphics);
            k.draw(e.Graphics, ClientSize);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controller.refresh();
            Refresh();
            this.Text = "PHYTON. SCORE: " + controller.score;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
        }
    }
}
