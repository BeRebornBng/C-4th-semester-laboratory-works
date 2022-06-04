using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Косметология
{
    public partial class Консультация : Form
    {
        public Консультация()
        {
            InitializeComponent();
        }

        private void консультацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.консультацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.косметологияDataSet);

        }

        private void Консультация_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметологияDataSet.Консультация". При необходимости она может быть перемещена или удалена.
            this.консультацияTableAdapter.Fill(this.косметологияDataSet.Консультация);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm8 = new Form1();
            frm8.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("out.txt");
            StreamReader f1 = new StreamReader("Kons.txt");
            f.WriteLine("Значение Консультация");
        metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            f.WriteLine(s);
            goto metka;
        metka1: f.WriteLine("Список услуг");
            f.Close();
            f1.Close();
        }
    }
}
