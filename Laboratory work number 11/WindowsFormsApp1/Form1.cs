using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public class Car {
            public Car(string GosNumber,string Model,string Color,string FIO)
            {
                _GosNumber = GosNumber;
                _Model = Model;
                _Color = Color;
                    _FIO = FIO;
            }
            public string get()
            {
                return _GosNumber;
            }
            public string _GosNumber="";//гос номер машины
            public string _Model="";//модель
            public string _Color="";//цвет
            public string _FIO="";//фио владельца машины
        }
        public Form1()
        {
            InitializeComponent();
        }
        List<Car> list=new List<Car>(100);
        private void keypressed(Object o, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string GosNumber;
            string Model;
            string Color;
            string FIO;
            GosNumber = Convert.ToString(textBox1.Text);
            Model = Convert.ToString(textBox2.Text);
            Color = Convert.ToString(textBox3.Text);
            FIO = Convert.ToString(textBox4.Text);
            if (comboBox2.Capture)
            {
                if (list.Count == 0)
                {
                    list.Add(new Car(GosNumber, Model, Convert.ToString(comboBox2.SelectedItem), FIO));
                    comboBox1.Items.Add(GosNumber);
                }
                else
                {
                    bool flag = true;
                    foreach (var l in list)
                    {
                        if (GosNumber == l._GosNumber)
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        list.Add(new Car(GosNumber, Model, Convert.ToString(comboBox2.SelectedItem), FIO));
                        comboBox1.Items.Add(GosNumber);
                    }
                }
            }
            else
            {
                if (list.Count == 0)
                {
                    list.Add(new Car(GosNumber, Model, Color, FIO));
                    comboBox1.Items.Add(GosNumber);
                    comboBox2.Items.Add(Color);
                }
                else
                {
                    bool flag = true;
                    bool color_flag = true;
                    foreach (var l in list)
                    {
                        if (GosNumber == l._GosNumber)
                        {
                            flag = false;
                        }
                        if (Color == l._Color)
                        {
                            color_flag = false;
                        }
                    }
                    if (flag)
                    {
                        list.Add(new Car(GosNumber, Model, Color, FIO));
                        comboBox1.Items.Add(GosNumber);
                        if (color_flag) comboBox2.Items.Add(Color);
                    }
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            foreach (var car in list)
            {
                if (car._GosNumber == Convert.ToString(comboBox1.SelectedItem))
                {
                    list.Remove(car);
                    comboBox1.SelectedItem = null;
                }
            }
        }
    }
}
