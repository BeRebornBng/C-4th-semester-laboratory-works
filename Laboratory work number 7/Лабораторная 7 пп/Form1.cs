using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_7_пп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            //отрисовка эллипса
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            Pen VioletPen = new Pen(Color.Violet, 32);
            Rectangle rect = new Rectangle(45, 45, 200, 100);
            g.DrawEllipse(VioletPen, rect);
            //отрисовка закрашенного эллипса
            SolidBrush solidBrush = new SolidBrush(
            Color.FromArgb(120, 255, 0, 0));
            g.FillEllipse(solidBrush, 300, 150, 100, 60);
            SolidBrush solidBrush2 = new SolidBrush(Color.FromArgb(255, 255, 3, 4));
            Rectangle rect5 = new Rectangle(120,230, 200, 100);
            g.FillRectangle(solidBrush2, rect5);
            //отрисовка незакрашенного квадрата
            Pen PolPen = new Pen(Color.Aqua, 20);
            Rectangle rect3 = new Rectangle(400, 240, 100, 100);
            g.DrawRectangle(PolPen, rect3);
            //отрисовка прямых и кривых линий
            Pen redPen = new Pen(Color.Red, 3);
            Pen greenPen = new Pen(Color.Green, 3);
            Point point1 = new Point(325,50);
            Point point2 = new Point(390, 25);
            Point point3 = new Point(420, 5);
            Point point4 = new Point(450, 50);
            Point point9 = new Point(490, 32);
            Point[] curvePoints = { point1, point2, point3, point4,point9};
            e.Graphics.DrawLines(redPen, curvePoints);
            Point point5 = new Point(325, 75);
            Point point6 = new Point(390, 89);
            Point point7 = new Point(420, 13);
            Point point8 = new Point(450, 150);
            Point[] curvePoints2 = { point5, point6, point7, point8 };
            e.Graphics.DrawCurve(greenPen, curvePoints2);
            //отрисовка многоугольника
            Pen polygonPen = new Pen(Color.Cornsilk, 5);
            PointF point10 = new PointF(530.0F, 400.0F);
            PointF point11 = new PointF(560.0F, 25.0F);
            PointF point12 = new PointF(580.0F, 5.0F);
            PointF point13 = new PointF(600.0F, 50.0F);
            PointF point14 = new PointF(620.0F, 100.0F);
            PointF point15 = new PointF(640.0F, 200.0F);
            PointF point16 = new PointF(670.0F, 250.0F);
            PointF[] curvePointsP =
                     {
                 point10,
                 point11,
                 point12,
                 point13,
                 point14,
                 point15,
                 point16
             };

            // Draw polygon curve to screen.
            e.Graphics.DrawPolygon(polygonPen, curvePointsP);
            //штрих пунктирные линии
            float[] dashValues = { 5, 2, 15, 4 };
            Pen penBl = new Pen(Color.Black, 5);
            penBl.DashPattern = dashValues;
            e.Graphics.DrawLine(penBl, new Point(10, 410), new Point(700, 410));
        }
    }
}
