using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, x7, y7, x8, y8, x9, y9, x10, y10;
        Pen pen = new Pen(Color.Brown, 1);
        Pen pen2 = new Pen(Color.Brown, 1);
        Rectangle rect = new Rectangle(175,50,50,50);
        int tempy9,tempx1,tempx8,tempx9,tempx7,tempy10;
        int count = 0;
        int x11;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (count < 7)
            {
                if (x11 > tempx1)
                {
                    x11 -= 10;
                    y10 -= 25;
                }
                else
                {
                    if (tempx1 < 200)
                    {
                        y10 += 25;
                        tempx1 += 10;
                        x11 += 10;
                    }
                    else
                    {
                        tempx1 = 170;
                    }
                }
                count += 1;
                if (count == 7)
                {
                    count = 0;
                    tempx1 = 170;
                }
            }
            Invalidate();
        }
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x3, y3);
            Point point4 = new Point(x4, y4);
            Point point5 = new Point(x5, y5);
            Point point6 = new Point(x6, y6);
            Point point7 = new Point(x7, y7);
            Point point8 = new Point(x8, y8);
            Point point9 = new Point(x9, y9);
            Point point10 = new Point(x10, y10);
            g.DrawLine(pen,point1, point2);
            g.DrawLine(pen, point1, point3);
            g.DrawLine(pen, point1, point4);
            g.DrawLine(pen, point4, point5);
            g.DrawLine(pen, point3, point6);
            g.DrawLine(pen, point2, point7);
            g.DrawLine(pen, point2, point8);
            g.DrawLine(pen, point8, point9);
            g.DrawLine(pen, point7, point10);
            g.DrawEllipse(pen2, rect);
        }
        private void Form_Load(object sender, EventArgs e)
        {
            x1 = 200;
            y1 = 200;
            x2 = 200;
            y2 = 100;
            x3 = 175;
            y3 = 250;
            x4 = 225;
            y4 = 250;
            x5 = 250;
            y5 = 300;
            x6 = 150;
            y6 = 300;
            x7 = 150;
            y7 = 150;
            x8 = 250;
            y8 = 150;
            x9 = 300;
            y9 = 200;
            x10 = 100;
            y10 = 200;
            tempy9 = y9;
            tempx1 = x1;
            tempx7 = x7;
            tempx8 = x8;
            tempx9 = x9;
            tempy10 = y10;
            x11 = x1;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

    }
}
