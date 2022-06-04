using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace Косметология
{
    public partial class Процедура : Form
    {
        public Процедура()
        {
            InitializeComponent();
        }

        private void процедураBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.процедураBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.косметологияDataSet);

        }

        private void процедураBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.процедураBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.косметологияDataSet);

        }

        private void Процедура_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметологияDataSet.Процедура". При необходимости она может быть перемещена или удалена.
            this.процедураTableAdapter.Fill(this.косметологияDataSet.Процедура);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm5 = new Form1();
            frm5.Show();
            this.Hide();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("out.txt", true, Encoding.Default);//Encoding.GetEncoding(1251));
            StreamReader f1 = new StreamReader("Pro.txt");
            f.WriteLine("Значение Процедура", Encoding.Default);// Encoding.GetEncoding(1251));
        metka: s = f1.ReadLine();
        if (s == null) goto metka1;
            f.WriteLine(s, Encoding.Default);// Encoding.GetEncoding(1251));
        goto metka;
        metka1: f.WriteLine("Список услуг", Encoding.Default);// Encoding.GetEncoding(1251));
    f.Close();
    f1.Close();
            /*FileStream stream = new FileStream("out.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            stream.Close();
            FileStream outFile = new FileStream("Pro.txt", FileMode.Open,FileAccess.Write);
            byte[] outBuffer = Encoding.Default.GetBytes(str);
            await outFile.WriteAsync(outBuffer, 0, outBuffer.Length);
            outFile.Close();*/
        }
    }
}
