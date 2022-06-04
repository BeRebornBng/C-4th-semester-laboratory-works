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

        private void Процедура_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметологияDataSet.Процедура". При необходимости она может быть перемещена или удалена.
            this.процедураTableAdapter.Fill(this.косметологияDataSet.Процедура);

        }
    }
}
