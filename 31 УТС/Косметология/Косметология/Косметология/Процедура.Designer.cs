namespace Косметология
{
    partial class Процедура
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Процедура));
            System.Windows.Forms.Label процедурыLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label длительность_процедуры__мин_Label;
            this.косметологияDataSet = new Косметология.КосметологияDataSet();
            this.процедураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедураTableAdapter = new Косметология.КосметологияDataSetTableAdapters.ПроцедураTableAdapter();
            this.tableAdapterManager = new Косметология.КосметологияDataSetTableAdapters.TableAdapterManager();
            this.процедураBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.процедураBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.процедурыTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.длительность_процедуры__мин_TextBox = new System.Windows.Forms.TextBox();
            процедурыLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            длительность_процедуры__мин_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураBindingNavigator)).BeginInit();
            this.процедураBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // косметологияDataSet
            // 
            this.косметологияDataSet.DataSetName = "КосметологияDataSet";
            this.косметологияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // процедураBindingSource
            // 
            this.процедураBindingSource.DataMember = "Процедура";
            this.процедураBindingSource.DataSource = this.косметологияDataSet;
            // 
            // процедураTableAdapter
            // 
            this.процедураTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Косметология.КосметологияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КонсультацияTableAdapter = null;
            this.tableAdapterManager.МассажTableAdapter = null;
            this.tableAdapterManager.Подбор_косметического_средстваTableAdapter = null;
            this.tableAdapterManager.ПроцедураTableAdapter = this.процедураTableAdapter;
            this.tableAdapterManager.Список_услугTableAdapter = null;
            // 
            // процедураBindingNavigator
            // 
            this.процедураBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.процедураBindingNavigator.BindingSource = this.процедураBindingSource;
            this.процедураBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.процедураBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.процедураBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.процедураBindingNavigatorSaveItem});
            this.процедураBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.процедураBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.процедураBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.процедураBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.процедураBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.процедураBindingNavigator.Name = "процедураBindingNavigator";
            this.процедураBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.процедураBindingNavigator.Size = new System.Drawing.Size(438, 25);
            this.процедураBindingNavigator.TabIndex = 0;
            this.процедураBindingNavigator.Text = "bindingNavigator1";
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
            // процедураBindingNavigatorSaveItem
            // 
            this.процедураBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.процедураBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("процедураBindingNavigatorSaveItem.Image")));
            this.процедураBindingNavigatorSaveItem.Name = "процедураBindingNavigatorSaveItem";
            this.процедураBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.процедураBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.процедураBindingNavigatorSaveItem.Click += new System.EventHandler(this.процедураBindingNavigatorSaveItem_Click);
            // 
            // процедурыLabel
            // 
            процедурыLabel.AutoSize = true;
            процедурыLabel.Location = new System.Drawing.Point(57, 33);
            процедурыLabel.Name = "процедурыLabel";
            процедурыLabel.Size = new System.Drawing.Size(67, 13);
            процедурыLabel.TabIndex = 1;
            процедурыLabel.Text = "Процедуры:";
            // 
            // процедурыTextBox
            // 
            this.процедурыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедураBindingSource, "Процедуры", true));
            this.процедурыTextBox.Location = new System.Drawing.Point(261, 33);
            this.процедурыTextBox.Name = "процедурыTextBox";
            this.процедурыTextBox.Size = new System.Drawing.Size(100, 20);
            this.процедурыTextBox.TabIndex = 2;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(57, 75);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 3;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедураBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(261, 75);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 20);
            this.стоимостьTextBox.TabIndex = 4;
            // 
            // длительность_процедуры__мин_Label
            // 
            длительность_процедуры__мин_Label.AutoSize = true;
            длительность_процедуры__мин_Label.Location = new System.Drawing.Point(57, 119);
            длительность_процедуры__мин_Label.Name = "длительность_процедуры__мин_Label";
            длительность_процедуры__мин_Label.Size = new System.Drawing.Size(170, 13);
            длительность_процедуры__мин_Label.TabIndex = 5;
            длительность_процедуры__мин_Label.Text = "Длительность процедуры (мин):";
            // 
            // длительность_процедуры__мин_TextBox
            // 
            this.длительность_процедуры__мин_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедураBindingSource, "Длительность процедуры (мин)", true));
            this.длительность_процедуры__мин_TextBox.Location = new System.Drawing.Point(261, 119);
            this.длительность_процедуры__мин_TextBox.Name = "длительность_процедуры__мин_TextBox";
            this.длительность_процедуры__мин_TextBox.Size = new System.Drawing.Size(100, 20);
            this.длительность_процедуры__мин_TextBox.TabIndex = 6;
            // 
            // Процедура
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 262);
            this.Controls.Add(длительность_процедуры__мин_Label);
            this.Controls.Add(this.длительность_процедуры__мин_TextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(процедурыLabel);
            this.Controls.Add(this.процедурыTextBox);
            this.Controls.Add(this.процедураBindingNavigator);
            this.Name = "Процедура";
            this.Text = "Процедура";
            this.Load += new System.EventHandler(this.Процедура_Load);
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураBindingNavigator)).EndInit();
            this.процедураBindingNavigator.ResumeLayout(false);
            this.процедураBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private КосметологияDataSet косметологияDataSet;
        private System.Windows.Forms.BindingSource процедураBindingSource;
        private КосметологияDataSetTableAdapters.ПроцедураTableAdapter процедураTableAdapter;
        private КосметологияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator процедураBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton процедураBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox процедурыTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox длительность_процедуры__мин_TextBox;
    }
}