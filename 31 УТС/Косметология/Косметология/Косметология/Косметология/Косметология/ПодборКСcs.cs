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
    public partial class ПодборКСcs : Form
    {
        public ПодборКСcs()
        {
            InitializeComponent();
        }

        private void подбор_косметического_средстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.подбор_косметического_средстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.косметологияDataSet);

        }

        private void ПодборКСcs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметологияDataSet.Подбор_косметического_средства". При необходимости она может быть перемещена или удалена.
            this.подбор_косметического_средстваTableAdapter.Fill(this.косметологияDataSet.Подбор_косметического_средства);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm6 = new Form1();
            frm6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("out.txt");
            StreamReader f1 = new StreamReader("Podbor.txt");
            f.WriteLine("Значение Подбор КС");
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
