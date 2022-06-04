namespace Косметология
{
    partial class ПодборКСcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label тип_кожиLabel;
            System.Windows.Forms.Label домашний_уходLabel;
            System.Windows.Forms.Label посещение_косметологаLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПодборКСcs));
            this.косметологияDataSet = new Косметология.КосметологияDataSet();
            this.подбор_косметического_средстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подбор_косметического_средстваTableAdapter = new Косметология.КосметологияDataSetTableAdapters.Подбор_косметического_средстваTableAdapter();
            this.tableAdapterManager = new Косметология.КосметологияDataSetTableAdapters.TableAdapterManager();
            this.подбор_косметического_средстваBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.подбор_косметического_средстваBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            тип_кожиLabel = new System.Windows.Forms.Label();
            домашний_уходLabel = new System.Windows.Forms.Label();
            посещение_косметологаLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подбор_косметического_средстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подбор_косметического_средстваBindingNavigator)).BeginInit();
            this.подбор_косметического_средстваBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // тип_кожиLabel
            // 
            тип_кожиLabel.AutoSize = true;
            тип_кожиLabel.Location = new System.Drawing.Point(51, 73);
            тип_кожиLabel.Name = "тип_кожиLabel";
            тип_кожиLabel.Size = new System.Drawing.Size(58, 13);
            тип_кожиLabel.TabIndex = 1;
            тип_кожиLabel.Text = "Тип кожи:";
            // 
            // домашний_уходLabel
            // 
            домашний_уходLabel.AutoSize = true;
            домашний_уходLabel.Location = new System.Drawing.Point(49, 112);
            домашний_уходLabel.Name = "домашний_уходLabel";
            домашний_уходLabel.Size = new System.Drawing.Size(90, 13);
            домашний_уходLabel.TabIndex = 3;
            домашний_уходLabel.Text = "Домашний уход:";
            // 
            // посещение_косметологаLabel
            // 
            посещение_косметологаLabel.AutoSize = true;
            посещение_косметологаLabel.Location = new System.Drawing.Point(49, 149);
            посещение_косметологаLabel.Name = "посещение_косметологаLabel";
            посещение_косметологаLabel.Size = new System.Drawing.Size(138, 13);
            посещение_косметологаLabel.TabIndex = 5;
            посещение_косметологаLabel.Text = "Посещение косметолога:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(51, 186);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 7;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // косметологияDataSet
            // 
            this.косметологияDataSet.DataSetName = "КосметологияDataSet";
            this.косметологияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // подбор_косметического_средстваBindingSource
            // 
            this.подбор_косметического_средстваBindingSource.DataMember = "Подбор косметического средства";
            this.подбор_косметического_средстваBindingSource.DataSource = this.косметологияDataSet;
            // 
            // подбор_косметического_средстваTableAdapter
            // 
            this.подбор_косметического_средстваTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Косметология.КосметологияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КонсультацияTableAdapter = null;
            this.tableAdapterManager.МассажTableAdapter = null;
            this.tableAdapterManager.Подбор_косметического_средстваTableAdapter = this.подбор_косметического_средстваTableAdapter;
            this.tableAdapterManager.ПроцедураTableAdapter = null;
            this.tableAdapterManager.Список_услугTableAdapter = null;
            // 
            // подбор_косметического_средстваBindingNavigator
            // 
            this.подбор_косметического_средстваBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.подбор_косметического_средстваBindingNavigator.BindingSource = this.подбор_косметического_средстваBindingSource;
            this.подбор_косметического_средстваBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.подбор_косметического_средстваBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.подбор_косметического_средстваBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.подбор_косметического_средстваBindingNavigatorSaveItem});
            this.подбор_косметического_средстваBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.подбор_косметического_средстваBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.подбор_косметического_средстваBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.подбор_косметического_средстваBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.подбор_косметического_средстваBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.подбор_косметического_средстваBindingNavigator.Name = "подбор_косметического_средстваBindingNavigator";
            this.подбор_косметического_средстваBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.подбор_косметического_средстваBindingNavigator.Size = new System.Drawing.Size(395, 25);
            this.подбор_косметического_средстваBindingNavigator.TabIndex = 0;
            this.подбор_косметического_средстваBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // подбор_косметического_средстваBindingNavigatorSaveItem
            // 
            this.подбор_косметического_средстваBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("подбор_косметического_средстваBindingNavigatorSaveItem.Image")));
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Name = "подбор_косметического_средстваBindingNavigatorSaveItem";
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Click += new System.EventHandler(this.подбор_косметического_средстваBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ПодборКС";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(111, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.подбор_косметического_средстваBindingSource, "Тип кожи", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Жирный тип",
            "Сухой тип",
            "Нормальый тип",
            "Комбинированный тип"});
            this.comboBox1.Location = new System.Drawing.Point(208, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.подбор_косметического_средстваBindingSource, "Домашний уход", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Необходимо интенсивное увлажнение, питание",
            "Нужно мягкое, но интенсивное очищение",
            "При уходе средства можно сочетать",
            "Качественное, но бережное очищение"});
            this.comboBox2.Location = new System.Drawing.Point(208, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.подбор_косметического_средстваBindingSource, "Посещение косметолога", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Раз в месяц"});
            this.comboBox3.Location = new System.Drawing.Point(208, 149);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.подбор_косметического_средстваBindingSource, "Стоимость", true));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "500"});
            this.comboBox4.Location = new System.Drawing.Point(208, 186);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ПодборКСcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(посещение_косметологаLabel);
            this.Controls.Add(домашний_уходLabel);
            this.Controls.Add(тип_кожиLabel);
            this.Controls.Add(this.подбор_косметического_средстваBindingNavigator);
            this.Name = "ПодборКСcs";
            this.Text = "ПодборКСcs";
            this.Load += new System.EventHandler(this.ПодборКСcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подбор_косметического_средстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подбор_косметического_средстваBindingNavigator)).EndInit();
            this.подбор_косметического_средстваBindingNavigator.ResumeLayout(false);
            this.подбор_косметического_средстваBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private КосметологияDataSet косметологияDataSet;
        private System.Windows.Forms.BindingSource подбор_косметического_средстваBindingSource;
        private КосметологияDataSetTableAdapters.Подбор_косметического_средстваTableAdapter подбор_косметического_средстваTableAdapter;
        private КосметологияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator подбор_косметического_средстваBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton подбор_косметического_средстваBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button2;
    }
}