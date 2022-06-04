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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void список_услугBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.список_услугBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.косметологияDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметологияDataSet.Список_услуг". При необходимости она может быть перемещена или удалена.
            this.список_услугTableAdapter.Fill(this.косметологияDataSet.Список_услуг);

        }
    }
}
