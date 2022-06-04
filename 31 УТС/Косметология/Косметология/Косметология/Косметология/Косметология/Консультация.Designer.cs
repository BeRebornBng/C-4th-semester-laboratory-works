namespace Косметология
{
    partial class Консультация
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
            System.Windows.Forms.Label типы_кожиLabel;
            System.Windows.Forms.Label список_мероприятийLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Консультация));
            this.косметологияDataSet = new Косметология.КосметологияDataSet();
            this.консультацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.консультацияTableAdapter = new Косметология.КосметологияDataSetTableAdapters.КонсультацияTableAdapter();
            this.tableAdapterManager = new Косметология.КосметологияDataSetTableAdapters.TableAdapterManager();
            this.консультацияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.консультацияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            типы_кожиLabel = new System.Windows.Forms.Label();
            список_мероприятийLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.консультацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.консультацияBindingNavigator)).BeginInit();
            this.консультацияBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // типы_кожиLabel
            // 
            типы_кожиLabel.AutoSize = true;
            типы_кожиLabel.Location = new System.Drawing.Point(40, 71);
            типы_кожиLabel.Name = "типы_кожиLabel";
            типы_кожиLabel.Size = new System.Drawing.Size(66, 13);
            типы_кожиLabel.TabIndex = 1;
            типы_кожиLabel.Text = "Типы кожи:";
            // 
            // список_мероприятийLabel
            // 
            список_мероприятийLabel.AutoSize = true;
            список_мероприятийLabel.Location = new System.Drawing.Point(40, 107);
            список_мероприятийLabel.Name = "список_мероприятийLabel";
            список_мероприятийLabel.Size = new System.Drawing.Size(117, 13);
            список_мероприятийLabel.TabIndex = 3;
            список_мероприятийLabel.Text = "Список мероприятий:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(41, 149);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 5;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // косметологияDataSet
            // 
            this.косметологияDataSet.DataSetName = "КосметологияDataSet";
            this.косметологияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // консультацияBindingSource
            // 
            this.консультацияBindingSource.DataMember = "Консультация";
            this.консультацияBindingSource.DataSource = this.косметологияDataSet;
            // 
            // консультацияTableAdapter
            // 
            this.консультацияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Косметология.КосметологияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КонсультацияTableAdapter = this.консультацияTableAdapter;
            this.tableAdapterManager.МассажTableAdapter = null;
            this.tableAdapterManager.Подбор_косметического_средстваTableAdapter = null;
            this.tableAdapterManager.ПроцедураTableAdapter = null;
            this.tableAdapterManager.Список_услугTableAdapter = null;
            // 
            // консультацияBindingNavigator
            // 
            this.консультацияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.консультацияBindingNavigator.BindingSource = this.консультацияBindingSource;
            this.консультацияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.консультацияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.консультацияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.консультацияBindingNavigatorSaveItem});
            this.консультацияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.консультацияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.консультацияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.консультацияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.консультацияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.консультацияBindingNavigator.Name = "консультацияBindingNavigator";
            this.консультацияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.консультацияBindingNavigator.Size = new System.Drawing.Size(358, 25);
            this.консультацияBindingNavigator.TabIndex = 0;
            this.консультацияBindingNavigator.Text = "bindingNavigator1";
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
            // консультацияBindingNavigatorSaveItem
            // 
            this.консультацияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.консультацияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("консультацияBindingNavigatorSaveItem.Image")));
            this.консультацияBindingNavigatorSaveItem.Name = "консультацияBindingNavigatorSaveItem";
            this.консультацияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.консультацияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.консультацияBindingNavigatorSaveItem.Click += new System.EventHandler(this.консультацияBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Консультация";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(98, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.консультацияBindingSource, "Типы кожи", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Жирный тип",
            "Сухой тип",
            "Комбинированный тип",
            "Нормальный тип",
            "Проблемный"});
            this.comboBox1.Location = new System.Drawing.Point(182, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.консультацияBindingSource, "Список мероприятий", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Мероприятия у косметолога",
            "Обращение к врчуу-дерматологу"});
            this.comboBox2.Location = new System.Drawing.Point(182, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.консультацияBindingSource, "Стоимость", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "200",
            "бесплатно"});
            this.comboBox3.Location = new System.Drawing.Point(182, 149);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Консультация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(список_мероприятийLabel);
            this.Controls.Add(типы_кожиLabel);
            this.Controls.Add(this.консультацияBindingNavigator);
            this.Name = "Консультация";
            this.Text = "Консультация";
            this.Load += new System.EventHandler(this.Консультация_Load);
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.консультацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.консультацияBindingNavigator)).EndInit();
            this.консультацияBindingNavigator.ResumeLayout(false);
            this.консультацияBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private КосметологияDataSet косметологияDataSet;
        private System.Windows.Forms.BindingSource консультацияBindingSource;
        private КосметологияDataSetTableAdapters.КонсультацияTableAdapter консультацияTableAdapter;
        private КосметологияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator консультацияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton консультацияBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
    }
}