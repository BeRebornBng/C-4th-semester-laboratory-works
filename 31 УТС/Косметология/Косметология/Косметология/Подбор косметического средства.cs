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
    public partial class Подбор_косметического_средства : Form
    {
        public Подбор_косметического_средства()
        {
            InitializeComponent();
        }

        private void подбор_косметического_средстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.подбор_косметического_средстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.косметологияDataSet);

        }

        private void Подбор_косметического_средства_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметологияDataSet.Подбор_косметического_средства". При необходимости она может быть перемещена или удалена.
            this.подбор_косметического_средстваTableAdapter.Fill(this.косметологияDataSet.Подбор_косметического_средства);

        }
    }
}
