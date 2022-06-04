namespace Косметология
{
    partial class Подбор_косметического_средства
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Подбор_косметического_средства));
            System.Windows.Forms.Label тип_кожиLabel;
            System.Windows.Forms.Label домашний_уходLabel;
            System.Windows.Forms.Label посещение_косметологаLabel;
            System.Windows.Forms.Label стоимостьLabel;
            this.косметологияDataSet = new Косметология.КосметологияDataSet();
            this.подбор_косметического_средстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подбор_косметического_средстваTableAdapter = new Косметология.КосметологияDataSetTableAdapters.Подбор_косметического_средстваTableAdapter();
            this.tableAdapterManager = new Косметология.КосметологияDataSetTableAdapters.TableAdapterManager();
            this.подбор_косметического_средстваBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.подбор_косметического_средстваBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.тип_кожиTextBox = new System.Windows.Forms.TextBox();
            this.домашний_уходTextBox = new System.Windows.Forms.TextBox();
            this.посещение_косметологаTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
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
            this.подбор_косметического_средстваBindingNavigator.Size = new System.Drawing.Size(330, 25);
            this.подбор_косметического_средстваBindingNavigator.TabIndex = 0;
            this.подбор_косметического_средстваBindingNavigator.Text = "bindingNavigator1";
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
            // подбор_косметического_средстваBindingNavigatorSaveItem
            // 
            this.подбор_косметического_средстваBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("подбор_косметического_средстваBindingNavigatorSaveItem.Image")));
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Name = "подбор_косметического_средстваBindingNavigatorSaveItem";
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.подбор_косметического_средстваBindingNavigatorSaveItem.Click += new System.EventHandler(this.подбор_косметического_средстваBindingNavigatorSaveItem_Click);
            // 
            // тип_кожиLabel
            // 
            тип_кожиLabel.AutoSize = true;
            тип_кожиLabel.Location = new System.Drawing.Point(64, 52);
            тип_кожиLabel.Name = "тип_кожиLabel";
            тип_кожиLabel.Size = new System.Drawing.Size(58, 13);
            тип_кожиLabel.TabIndex = 1;
            тип_кожиLabel.Text = "Тип кожи:";
            // 
            // тип_кожиTextBox
            // 
            this.тип_кожиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подбор_косметического_средстваBindingSource, "Тип кожи", true));
            this.тип_кожиTextBox.Location = new System.Drawing.Point(210, 49);
            this.тип_кожиTextBox.Name = "тип_кожиTextBox";
            this.тип_кожиTextBox.Size = new System.Drawing.Size(100, 20);
            this.тип_кожиTextBox.TabIndex = 2;
            // 
            // домашний_уходLabel
            // 
            домашний_уходLabel.AutoSize = true;
            домашний_уходLabel.Location = new System.Drawing.Point(62, 90);
            домашний_уходLabel.Name = "домашний_уходLabel";
            домашний_уходLabel.Size = new System.Drawing.Size(90, 13);
            домашний_уходLabel.TabIndex = 3;
            домашний_уходLabel.Text = "Домашний уход:";
            // 
            // домашний_уходTextBox
            // 
            this.домашний_уходTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подбор_косметического_средстваBindingSource, "Домашний уход", true));
            this.домашний_уходTextBox.Location = new System.Drawing.Point(210, 87);
            this.домашний_уходTextBox.Name = "домашний_уходTextBox";
            this.домашний_уходTextBox.Size = new System.Drawing.Size(100, 20);
            this.домашний_уходTextBox.TabIndex = 4;
            // 
            // посещение_косметологаLabel
            // 
            посещение_косметологаLabel.AutoSize = true;
            посещение_косметологаLabel.Location = new System.Drawing.Point(62, 124);
            посещение_косметологаLabel.Name = "посещение_косметологаLabel";
            посещение_косметологаLabel.Size = new System.Drawing.Size(138, 13);
            посещение_косметологаLabel.TabIndex = 5;
            посещение_косметологаLabel.Text = "Посещение косметолога:";
            // 
            // посещение_косметологаTextBox
            // 
            this.посещение_косметологаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подбор_косметического_средстваBindingSource, "Посещение косметолога", true));
            this.посещение_косметологаTextBox.Location = new System.Drawing.Point(210, 121);
            this.посещение_косметологаTextBox.Name = "посещение_косметологаTextBox";
            this.посещение_косметологаTextBox.Size = new System.Drawing.Size(100, 20);
            this.посещение_косметологаTextBox.TabIndex = 6;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(64, 164);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 7;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подбор_косметического_средстваBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(210, 161);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 20);
            this.стоимостьTextBox.TabIndex = 8;
            // 
            // Подбор_косметического_средства
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 262);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(посещение_косметологаLabel);
            this.Controls.Add(this.посещение_косметологаTextBox);
            this.Controls.Add(домашний_уходLabel);
            this.Controls.Add(this.домашний_уходTextBox);
            this.Controls.Add(тип_кожиLabel);
            this.Controls.Add(this.тип_кожиTextBox);
            this.Controls.Add(this.подбор_косметического_средстваBindingNavigator);
            this.Name = "Подбор_косметического_средства";
            this.Text = "Подбор_косметического_средства";
            this.Load += new System.EventHandler(this.Подбор_косметического_средства_Load);
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
        private System.Windows.Forms.TextBox тип_кожиTextBox;
        private System.Windows.Forms.TextBox домашний_уходTextBox;
        private System.Windows.Forms.TextBox посещение_косметологаTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
    }
}