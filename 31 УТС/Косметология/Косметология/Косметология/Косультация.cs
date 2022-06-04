using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Косметология
{
    public partial class Косультация : Form
    {
        public Косультация()
        {
            InitializeComponent();
        }

        private void консультацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.консультацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.косметологияDataSet);

        }

        private void Косультация_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметологияDataSet.Консультация". При необходимости она может быть перемещена или удалена.
            this.консультацияTableAdapter.Fill(this.косметологияDataSet.Консультация);

        }
    }
}
