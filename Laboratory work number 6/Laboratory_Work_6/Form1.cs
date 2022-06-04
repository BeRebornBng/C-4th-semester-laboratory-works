using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Work_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xmin = 0;
            double ymin = 0;
            double xmax = double.Parse(textBox1.Text);
            double ymax = double.Parse(textBox2.Text);
            double step = double.Parse(textBox3.Text);
            int count = (int)Math.Ceiling((xmax - xmin) / step)+1;
            double[] function = new double[count];
            double[] x=new double[count];
            for(int i = 0; i < count; ++i)
            {
                x[i] = xmin + step * i;
                ymin = ymin + step * i;
                function[i]=(Math.Max(Math.Max(Math.Pow(x[i],2),Math.Pow(ymin,2)),(x[i]-ymin))+x[i])/(Math.Pow(Math.Min(x[i],ymin),2)+Math.Pow(ymin,4));
            }
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            chart1.Series[0].Points.DataBindXY(x,function);
        }
    }
}
