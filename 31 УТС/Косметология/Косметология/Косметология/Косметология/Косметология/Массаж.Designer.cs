namespace Косметология
{
    partial class Массаж
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
            System.Windows.Forms.Label виды_массажаLabel;
            System.Windows.Forms.Label время_проведения__мин_Label;
            System.Windows.Forms.Label косметическое_средствоLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Массаж));
            this.косметологияDataSet = new Косметология.КосметологияDataSet();
            this.массажBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.массажTableAdapter = new Косметология.КосметологияDataSetTableAdapters.МассажTableAdapter();
            this.tableAdapterManager = new Косметология.КосметологияDataSetTableAdapters.TableAdapterManager();
            this.массажBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.массажBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
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
            // виды_массажаLabel
            // 
            виды_массажаLabel.AutoSize = true;
            виды_массажаLabel.Location = new System.Drawing.Point(42, 78);
            виды_массажаLabel.Name = "виды_массажаLabel";
            виды_массажаLabel.Size = new System.Drawing.Size(86, 13);
            виды_массажаLabel.TabIndex = 1;
            виды_массажаLabel.Text = "Виды массажа:";
            // 
            // время_проведения__мин_Label
            // 
            время_проведения__мин_Label.AutoSize = true;
            время_проведения__мин_Label.Location = new System.Drawing.Point(38, 111);
            время_проведения__мин_Label.Name = "время_проведения__мин_Label";
            время_проведения__мин_Label.Size = new System.Drawing.Size(135, 13);
            время_проведения__мин_Label.TabIndex = 3;
            время_проведения__мин_Label.Text = "Время проведения (мин):";
            // 
            // косметическое_средствоLabel
            // 
            косметическое_средствоLabel.AutoSize = true;
            косметическое_средствоLabel.Location = new System.Drawing.Point(38, 150);
            косметическое_средствоLabel.Name = "косметическое_средствоLabel";
            косметическое_средствоLabel.Size = new System.Drawing.Size(139, 13);
            косметическое_средствоLabel.TabIndex = 5;
            косметическое_средствоLabel.Text = "Косметическое средство:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(42, 188);
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
            this.массажBindingNavigator.Size = new System.Drawing.Size(319, 25);
            this.массажBindingNavigator.TabIndex = 0;
            this.массажBindingNavigator.Text = "bindingNavigator1";
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
            // массажBindingNavigatorSaveItem
            // 
            this.массажBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.массажBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("массажBindingNavigatorSaveItem.Image")));
            this.массажBindingNavigatorSaveItem.Name = "массажBindingNavigatorSaveItem";
            this.массажBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.массажBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.массажBindingNavigatorSaveItem.Click += new System.EventHandler(this.массажBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Массаж";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(113, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.массажBindingSource, "Виды массажа", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Косметически массаж",
            "Пластический массаж",
            "Массаж по Жаке"});
            this.comboBox2.Location = new System.Drawing.Point(186, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.массажBindingSource, "Время проведения (мин)", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "30",
            "60",
            "45"});
            this.comboBox3.Location = new System.Drawing.Point(186, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.массажBindingSource, "Косметическое средство", true));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Масло",
            "Тальк"});
            this.comboBox4.Location = new System.Drawing.Point(186, 150);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 14;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.массажBindingSource, "Стоимость", true));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1500",
            "600",
            "1000"});
            this.comboBox5.Location = new System.Drawing.Point(186, 179);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Массаж
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(косметическое_средствоLabel);
            this.Controls.Add(время_проведения__мин_Label);
            this.Controls.Add(виды_массажаLabel);
            this.Controls.Add(this.массажBindingNavigator);
            this.Name = "Массаж";
            this.Text = "Массаж";
            this.Load += new System.EventHandler(this.Массаж_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button2;
    }
}