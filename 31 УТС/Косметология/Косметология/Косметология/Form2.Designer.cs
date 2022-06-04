namespace Косметология
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label код_услугиLabel;
            System.Windows.Forms.Label процедураLabel;
            System.Windows.Forms.Label консультацияLabel;
            System.Windows.Forms.Label подбор_косметичсекого_средстваLabel;
            this.косметологияDataSet = new Косметология.КосметологияDataSet();
            this.список_услугBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_услугTableAdapter = new Косметология.КосметологияDataSetTableAdapters.Список_услугTableAdapter();
            this.tableAdapterManager = new Косметология.КосметологияDataSetTableAdapters.TableAdapterManager();
            this.список_услугBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.список_услугBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_услугиTextBox = new System.Windows.Forms.TextBox();
            this.процедураTextBox = new System.Windows.Forms.TextBox();
            this.консультацияTextBox = new System.Windows.Forms.TextBox();
            this.подбор_косметичсекого_средстваTextBox = new System.Windows.Forms.TextBox();
            код_услугиLabel = new System.Windows.Forms.Label();
            процедураLabel = new System.Windows.Forms.Label();
            консультацияLabel = new System.Windows.Forms.Label();
            подбор_косметичсекого_средстваLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугBindingNavigator)).BeginInit();
            this.список_услугBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // косметологияDataSet
            // 
            this.косметологияDataSet.DataSetName = "КосметологияDataSet";
            this.косметологияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_услугBindingSource
            // 
            this.список_услугBindingSource.DataMember = "Список услуг";
            this.список_услугBindingSource.DataSource = this.косметологияDataSet;
            // 
            // список_услугTableAdapter
            // 
            this.список_услугTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Косметология.КосметологияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КонсультацияTableAdapter = null;
            this.tableAdapterManager.МассажTableAdapter = null;
            this.tableAdapterManager.Подбор_косметического_средстваTableAdapter = null;
            this.tableAdapterManager.ПроцедураTableAdapter = null;
            this.tableAdapterManager.Список_услугTableAdapter = this.список_услугTableAdapter;
            // 
            // список_услугBindingNavigator
            // 
            this.список_услугBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.список_услугBindingNavigator.BindingSource = this.список_услугBindingSource;
            this.список_услугBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.список_услугBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.список_услугBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.список_услугBindingNavigatorSaveItem});
            this.список_услугBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.список_услугBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.список_услугBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.список_услугBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.список_услугBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.список_услугBindingNavigator.Name = "список_услугBindingNavigator";
            this.список_услугBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.список_услугBindingNavigator.Size = new System.Drawing.Size(462, 25);
            this.список_услугBindingNavigator.TabIndex = 0;
            this.список_услугBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // список_услугBindingNavigatorSaveItem
            // 
            this.список_услугBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.список_услугBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("список_услугBindingNavigatorSaveItem.Image")));
            this.список_услугBindingNavigatorSaveItem.Name = "список_услугBindingNavigatorSaveItem";
            this.список_услугBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.список_услугBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.список_услугBindingNavigatorSaveItem.Click += new System.EventHandler(this.список_услугBindingNavigatorSaveItem_Click);
            // 
            // код_услугиLabel
            // 
            код_услугиLabel.AutoSize = true;
            код_услугиLabel.Location = new System.Drawing.Point(63, 45);
            код_услугиLabel.Name = "код_услугиLabel";
            код_услугиLabel.Size = new System.Drawing.Size(65, 13);
            код_услугиLabel.TabIndex = 1;
            код_услугиLabel.Text = "Код услуги:";
            // 
            // код_услугиTextBox
            // 
            this.код_услугиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_услугBindingSource, "Код услуги", true));
            this.код_услугиTextBox.Location = new System.Drawing.Point(223, 38);
            this.код_услугиTextBox.Name = "код_услугиTextBox";
            this.код_услугиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_услугиTextBox.TabIndex = 2;
            // 
            // процедураLabel
            // 
            процедураLabel.AutoSize = true;
            процедураLabel.Location = new System.Drawing.Point(63, 71);
            процедураLabel.Name = "процедураLabel";
            процедураLabel.Size = new System.Drawing.Size(65, 13);
            процедураLabel.TabIndex = 3;
            процедураLabel.Text = "Процедура:";
            // 
            // процедураTextBox
            // 
            this.процедураTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_услугBindingSource, "Процедура", true));
            this.процедураTextBox.Location = new System.Drawing.Point(223, 68);
            this.процедураTextBox.Name = "процедураTextBox";
            this.процедураTextBox.Size = new System.Drawing.Size(100, 20);
            this.процедураTextBox.TabIndex = 4;
            // 
            // консультацияLabel
            // 
            консультацияLabel.AutoSize = true;
            консультацияLabel.Location = new System.Drawing.Point(47, 109);
            консультацияLabel.Name = "консультацияLabel";
            консультацияLabel.Size = new System.Drawing.Size(81, 13);
            консультацияLabel.TabIndex = 5;
            консультацияLabel.Text = "Консультация:";
            // 
            // консультацияTextBox
            // 
            this.консультацияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_услугBindingSource, "Консультация", true));
            this.консультацияTextBox.Location = new System.Drawing.Point(223, 109);
            this.консультацияTextBox.Name = "консультацияTextBox";
            this.консультацияTextBox.Size = new System.Drawing.Size(100, 20);
            this.консультацияTextBox.TabIndex = 6;
            // 
            // подбор_косметичсекого_средстваLabel
            // 
            подбор_косметичсекого_средстваLabel.AutoSize = true;
            подбор_косметичсекого_средстваLabel.Location = new System.Drawing.Point(33, 152);
            подбор_косметичсекого_средстваLabel.Name = "подбор_косметичсекого_средстваLabel";
            подбор_косметичсекого_средстваLabel.Size = new System.Drawing.Size(184, 13);
            подбор_косметичсекого_средстваLabel.TabIndex = 7;
            подбор_косметичсекого_средстваLabel.Text = "Подбор косметичсекого средства:";
            // 
            // подбор_косметичсекого_средстваTextBox
            // 
            this.подбор_косметичсекого_средстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.список_услугBindingSource, "Подбор косметичсекого средства", true));
            this.подбор_косметичсекого_средстваTextBox.Location = new System.Drawing.Point(223, 149);
            this.подбор_косметичсекого_средстваTextBox.Name = "подбор_косметичсекого_средстваTextBox";
            this.подбор_косметичсекого_средстваTextBox.Size = new System.Drawing.Size(100, 20);
            this.подбор_косметичсекого_средстваTextBox.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 262);
            this.Controls.Add(подбор_косметичсекого_средстваLabel);
            this.Controls.Add(this.подбор_косметичсекого_средстваTextBox);
            this.Controls.Add(консультацияLabel);
            this.Controls.Add(this.консультацияTextBox);
            this.Controls.Add(процедураLabel);
            this.Controls.Add(this.процедураTextBox);
            this.Controls.Add(код_услугиLabel);
            this.Controls.Add(this.код_услугиTextBox);
            this.Controls.Add(this.список_услугBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_услугBindingNavigator)).EndInit();
            this.список_услугBindingNavigator.ResumeLayout(false);
            this.список_услугBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private КосметологияDataSet косметологияDataSet;
        private System.Windows.Forms.BindingSource список_услугBindingSource;
        private КосметологияDataSetTableAdapters.Список_услугTableAdapter список_услугTableAdapter;
        private КосметологияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator список_услугBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton список_услугBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_услугиTextBox;
        private System.Windows.Forms.TextBox процедураTextBox;
        private System.Windows.Forms.TextBox консультацияTextBox;
        private System.Windows.Forms.TextBox подбор_косметичсекого_средстваTextBox;
    }
}