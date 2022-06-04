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
    public partial class Массаж : Form
    {
        public Массаж()
        {
            InitializeComponent();
        }

        private void массажBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.массажBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.косметологияDataSet);

        }

        private void Массаж_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметологияDataSet.Массаж". При необходимости она может быть перемещена или удалена.
            this.массажTableAdapter.Fill(this.косметологияDataSet.Массаж);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm7 = new Form1();
            frm7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("out.txt");
            StreamReader f1 = new StreamReader("Mas.txt");
            f.WriteLine("Значение Массаж");
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
