namespace Косметология
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label виды_массажаLabel;
            System.Windows.Forms.Label время_проведения__мин_Label;
            System.Windows.Forms.Label косметическое_средствоLabel;
            System.Windows.Forms.Label стоимостьLabel;
            this.косметологияDataSet = new Косметология.КосметологияDataSet();
            this.массажBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.массажTableAdapter = new Косметология.КосметологияDataSetTableAdapters.МассажTableAdapter();
            this.tableAdapterManager = new Косметология.КосметологияDataSetTableAdapters.TableAdapterManager();
            this.массажBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.массажBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.виды_массажаTextBox = new System.Windows.Forms.TextBox();
            this.время_проведения__мин_TextBox = new System.Windows.Forms.TextBox();
            this.косметическое_средствоTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            виды_массажаLabel = new System.Windows.Forms.Label();
            время_проведения__мин_Label = new System.Windows.Forms.Label();
            косметическое_средствоLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.массажBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.массажBindingNavigator)).BeginInit();
            this.массажBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // косметологияDataSet
            // 
            this.косметологияDataSet.DataSetName = "КосметологияDataSet";
            this.косметологияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // массажBindingSource
            // 
            this.массажBindingSource.DataMember = "Массаж";
            this.массажBindingSource.DataSource = this.косметологияDataSet;
            // 
            // массажTableAdapter
            // 
            this.массажTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Косметология.КосметологияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КонсультацияTableAdapter = null;
            this.tableAdapterManager.МассажTableAdapter = this.массажTableAdapter;
            this.tableAdapterManager.Подбор_косметического_средстваTableAdapter = null;
            this.tableAdapterManager.ПроцедураTableAdapter = null;
            this.tableAdapterManager.Список_услугTableAdapter = null;
            // 
            // массажBindingNavigator
            // 
            this.массажBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.массажBindingNavigator.BindingSource = this.массажBindingSource;
            this.массажBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.массажBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.массажBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.массажBindingNavigatorSaveItem});
            this.массажBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.массажBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.массажBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.массажBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.массажBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.массажBindingNavigator.Name = "массажBindingNavigator";
            this.массажBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.массажBindingNavigator.Size = new System.Drawing.Size(443, 25);
            this.массажBindingNavigator.TabIndex = 0;
            this.массажBindingNavigator.Text = "bindingNavigator1";
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
            // массажBindingNavigatorSaveItem
            // 
            this.массажBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.массажBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("массажBindingNavigatorSaveItem.Image")));
            this.массажBindingNavigatorSaveItem.Name = "массажBindingNavigatorSaveItem";
            this.массажBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.массажBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.массажBindingNavigatorSaveItem.Click += new System.EventHandler(this.массажBindingNavigatorSaveItem_Click);
            // 
            // виды_массажаLabel
            // 
            виды_массажаLabel.AutoSize = true;
            виды_массажаLabel.Location = new System.Drawing.Point(65, 58);
            виды_массажаLabel.Name = "виды_массажаLabel";
            виды_массажаLabel.Size = new System.Drawing.Size(86, 13);
            виды_массажаLabel.TabIndex = 1;
            виды_массажаLabel.Text = "Виды массажа:";
            // 
            // виды_массажаTextBox
            // 
            this.виды_массажаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.массажBindingSource, "Виды массажа", true));
            this.виды_массажаTextBox.Location = new System.Drawing.Point(266, 51);
            this.виды_массажаTextBox.Name = "виды_массажаTextBox";
            this.виды_массажаTextBox.Size = new System.Drawing.Size(100, 20);
            this.виды_массажаTextBox.TabIndex = 2;
            // 
            // время_проведения__мин_Label
            // 
            время_проведения__мин_Label.AutoSize = true;
            время_проведения__мин_Label.Location = new System.Drawing.Point(65, 93);
            время_проведения__мин_Label.Name = "время_проведения__мин_Label";
            время_проведения__мин_Label.Size = new System.Drawing.Size(135, 13);
            время_проведения__мин_Label.TabIndex = 3;
            время_проведения__мин_Label.Text = "Время проведения (мин):";
            // 
            // время_проведения__мин_TextBox
            // 
            this.время_проведения__мин_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.массажBindingSource, "Время проведения (мин)", true));
            this.время_проведения__мин_TextBox.Location = new System.Drawing.Point(266, 86);
            this.время_проведения__мин_TextBox.Name = "время_проведения__мин_TextBox";
            this.время_проведения__мин_TextBox.Size = new System.Drawing.Size(100, 20);
            this.время_проведения__мин_TextBox.TabIndex = 4;
            // 
            // косметическое_средствоLabel
            // 
            косметическое_средствоLabel.AutoSize = true;
            косметическое_средствоLabel.Location = new System.Drawing.Point(65, 130);
            косметическое_средствоLabel.Name = "косметическое_средствоLabel";
            косметическое_средствоLabel.Size = new System.Drawing.Size(139, 13);
            косметическое_средствоLabel.TabIndex = 5;
            косметическое_средствоLabel.Text = "Косметическое средство:";
            // 
            // косметическое_средствоTextBox
            // 
            this.косметическое_средствоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.массажBindingSource, "Косметическое средство", true));
            this.косметическое_средствоTextBox.Location = new System.Drawing.Point(266, 127);
            this.косметическое_средствоTextBox.Name = "косметическое_средствоTextBox";
            this.косметическое_средствоTextBox.Size = new System.Drawing.Size(100, 20);
            this.косметическое_средствоTextBox.TabIndex = 6;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(65, 173);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 7;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.массажBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(266, 173);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 20);
            this.стоимостьTextBox.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 280);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(косметическое_средствоLabel);
            this.Controls.Add(this.косметическое_средствоTextBox);
            this.Controls.Add(время_проведения__мин_Label);
            this.Controls.Add(this.время_проведения__мин_TextBox);
            this.Controls.Add(виды_массажаLabel);
            this.Controls.Add(this.виды_массажаTextBox);
            this.Controls.Add(this.массажBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.косметологияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.массажBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.массажBindingNavigator)).EndInit();
            this.массажBindingNavigator.ResumeLayout(false);
            this.массажBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private КосметологияDataSet косметологияDataSet;
        private System.Windows.Forms.BindingSource массажBindingSource;
        private КосметологияDataSetTableAdapters.МассажTableAdapter массажTableAdapter;
        private КосметологияDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator массажBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton массажBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox виды_массажаTextBox;
        private System.Windows.Forms.TextBox время_проведения__мин_TextBox;
        private System.Windows.Forms.TextBox косметическое_средствоTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
    }
}