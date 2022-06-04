using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба9ПОТЕХНОЛОГИИПРОГРАММИРОВАНИЯ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double h,r;
        double temp_r;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.Leave += new System.EventHandler(Leave1);
            double r;
            r = Convert.ToDouble(textBox1.Text);
            temp_r = r;
            label8.Text = String.Format("{0,10:####.##}", Math.PI * r * r);
        }

        private void Leave1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            r = temp_r;
            h = Convert.ToDouble(textBox2.Text);
            label9.Text = String.Format("{0,10:####.##}", Math.PI * r * r * h);
            label10.Text = String.Format("{0,10:####.##}", 2 * Math.PI * r * h + 2 * Math.PI * r * r);
        }
    }
}
