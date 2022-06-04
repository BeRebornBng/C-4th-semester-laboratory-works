using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная10ТехнологияПрограммирования
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Visible = true;
                comboBox1.Visible= true;
                label6.Visible = true;
            }
            else { groupBox1.Visible = false;
                label6.Visible = false;
                comboBox1.Visible = false;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox1.Text.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random G;
            if (checkBox1.Checked==false)
            {
                G = new Random();
            }
            else
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                G = new Random();
                if (radioButton1.Checked == true && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    for (int n = 0; n < 10; ++n)
                    {
                        if (checkBox2.Checked == false)
                        {
                            int d = G.Next();
                            listBox1.Items.Add(d.ToString());
                            if(comboBox1.SelectedIndex==0)
                            {
                               double func = Math.Sin(d);
                               listBox2.Items.Add(func.ToString());
                            }
                            else if (comboBox1.SelectedIndex == 1)
                            {
                                double func = Math.Cos(d);
                                listBox2.Items.Add(func.ToString());
                            }
                            else if (comboBox1.SelectedIndex == 2)
                            {
                                double func = Math.Tan(d);
                                listBox2.Items.Add(func.ToString());
                            }
                        }
                    }
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == true && radioButton3.Checked == false)
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    int min = 0;
                    int max = Convert.ToInt32(textBox2.Text);
                    for(int i = 0;i <= 10; i++)
                    {
                        int n = G.Next(min, max);
                        listBox1.Items.Add(n.ToString());
                        if (comboBox1.SelectedIndex == 0)
                        {
                            double func = Math.Sin(n);
                            listBox2.Items.Add(func.ToString());
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            double func = Math.Cos(n);
                            listBox2.Items.Add(func.ToString());
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            double func = Math.Tan(n);
                            listBox2.Items.Add(func.ToString());
                        }
                    }
                }
                else if(radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == true)
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    int min = Convert.ToInt32(textBox3.Text);
                    int max = Convert.ToInt32(textBox2.Text);
                    for (int i = 0; i <= 10; i++)
                    {
                        int n = G.Next(min, max);
                        listBox1.Items.Add(n.ToString());
                        if (comboBox1.SelectedIndex == 0)
                        {
                            double func = Math.Sin(n);
                            listBox2.Items.Add(func.ToString());
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            double func = Math.Cos(n);
                            listBox2.Items.Add(func.ToString());
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            double func = Math.Tan(n);
                            listBox2.Items.Add(func.ToString());
                        }
                    }
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    for (int i = 0; i <= 10; i++)
                    {
                        int n = G.Next(0, 2);
                        listBox1.Items.Add(n.ToString());
                        double func = Math.Sin(n);
                        listBox2.Items.Add(func.ToString());
                    }
                }
            }
            if (checkBox2.Checked)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                G = new Random();
                double d = Convert.ToDouble(textBox1.Text);
                for (int n = 0; n < 10; ++n)
                {
                    if (checkBox1.Checked == false)
                    {
                        
                        listBox1.Items.Add(d.ToString());
                        if (comboBox1.SelectedIndex == 0)
                        {
                            double func = Math.Sin(d);
                            listBox2.Items.Add(func.ToString());
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            double func = Math.Cos(d);
                            listBox2.Items.Add(func.ToString());
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            double func = Math.Tan(d);
                            listBox2.Items.Add(func.ToString());
                        }
                    }
                } 
            }
            if(!(checkBox1.Checked || checkBox2.Checked))
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                G = new Random();
                for (int i = 0; i < 10; ++i)
                {
                    double value = G.NextDouble();
                    listBox1.Items.Add(value.ToString());
                    double func = Math.Sin(value);
                    listBox2.Items.Add(func.ToString());
                }
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label6.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                comboBox1.Visible = true;
            }
            else { groupBox1.Visible = false;
                label6.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                comboBox1.Visible = false;
            }
        }
    }
}
