using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum Colors {белый,красный,черный,желтый,коричневый};
        [   ] public class Car {
            public Car(string GosNumber, string Model, string Color, string FIO)
            {
                _GosNumber = GosNumber;
                _Model = Model;
                _Color = Color;
                _FIO = FIO;
            }
            public void CreateGosNumber()
            {
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
        List<Car> list = new List<Car>(100);
        public Form1()
        {
            InitializeComponent();
        }
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
            if (comboBox2.SelectedIndex>-1)
            {
                if (list.Count == 0)
                {
                    list.Add(new Car(GosNumber, Model, comboBox2.SelectedItem.ToString(), FIO));
                    comboBox1.Items.Add((GosNumber));
                    comboBox2.
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
                        list.Add(new Car(GosNumber, Model, comboBox2.SelectedItem.ToString(), FIO));
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
                    if (!comboBox2.Items.Contains(Color))
                    {
                        comboBox2.Items.Add(Color);
                    }
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
                        if (Color == l._Color || comboBox2.Items.Contains(Color))
                        {
                        color_flag = false;
                        }
                    }
                    if (flag)
                    {
                        list.Add(new Car(GosNumber, Model, Color, FIO));
                        comboBox1.Items.Add(GosNumber);
                        if (color_flag) { comboBox2.Items.Add(Color); }
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
        private async void Form1_Closed(Object sender, FormClosedEventArgs e)
        {
            if (list.Count > 0)
            {
               try
                {
                    FileStream file;
                    file = new FileStream("Данные", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    foreach (var l in list)
                    {
                        bf.Serialize(file, l);
                    }
                    file.Close();
                }
                catch(IOException exeption)
                {
                    MessageBox.Show(exeption.Message);
                }
            }
            else
            {
                FileStream file;
                file = new FileStream("Данные", FileMode.CreateNew);
                file.Close();
            }
        }
        private void Form1_Load(Object sender,EventArgs e)
        {
            try
            {
                FileStream F = new FileStream("Данные", FileMode.Open, FileAccess.Read);
                BinaryFormatter P = new BinaryFormatter();
                while (F.Position < F.Length)
                {
                    list.Add((Car)P.Deserialize(F));
                }
                F.Close();
                foreach(var l in list)
                {
                    comboBox1.Items.Add(l._GosNumber);
                    comboBox2.Items.Add(l._Color);
                }
            }
            catch (IOException)
            {
                for (int i = 0; i < 5; ++i) {
                   comboBox2.Items.Add(((Colors)i).ToString());
                }
            }
        }
    }
}
