namespace Budget1._1
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillByCategoryBtn = new System.Windows.Forms.Button();
            this.fillByDateBtn = new System.Windows.Forms.Button();
            this.monthCalendarStart = new System.Windows.Forms.MonthCalendar();
            this.fillByDateAndCategoryBtn = new System.Windows.Forms.Button();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Budget1._1.Data.DataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.Filters = new System.Windows.Forms.Label();
            this.fillByTypeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.fillByMonthBtn = new System.Windows.Forms.Button();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.FillByDateAndTypeBtn = new System.Windows.Forms.Button();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.deleteTxt = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.reportsArea = new System.Windows.Forms.TextBox();
            this.mainTableAdapter1 = new Budget1._1.Data.DataSet2TableAdapters.mainTableAdapter();
            this.tableAdapterManager1 = new Budget1._1.Data.DataSet2TableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingNavigator)).BeginInit();
            this.mainBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(14, 25);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(14, 48);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "name:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(15, 69);
            valueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(36, 13);
            valueLabel.TabIndex = 4;
            valueLabel.Text = "value:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(15, 90);
            categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(51, 13);
            categoryLabel.TabIndex = 6;
            categoryLabel.Text = "category:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(15, 134);
            dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(31, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "date:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(14, 110);
            typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(30, 13);
            typeLabel.TabIndex = 10;
            typeLabel.Text = "type:";
            // 
            // mainBindingNavigator
            // 
            this.mainBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mainBindingNavigator.BindingSource = this.mainBindingSource;
            this.mainBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mainBindingNavigator.DeleteItem = null;
            this.mainBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mainBindingNavigatorSaveItem});
            this.mainBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mainBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mainBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mainBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mainBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mainBindingNavigator.Name = "mainBindingNavigator";
            this.mainBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mainBindingNavigator.Size = new System.Drawing.Size(1047, 27);
            this.mainBindingNavigator.TabIndex = 0;
            this.mainBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataMember = "main";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // mainBindingNavigatorSaveItem
            // 
            this.mainBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mainBindingNavigatorSaveItem.Image")));
            this.mainBindingNavigatorSaveItem.Name = "mainBindingNavigatorSaveItem";
            this.mainBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.mainBindingNavigatorSaveItem.Text = "Save Data";
            this.mainBindingNavigatorSaveItem.Click += new System.EventHandler(this.mainBindingNavigatorSaveItem_Click);
            // 
            // fillByCategoryBtn
            // 
            this.fillByCategoryBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fillByCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByCategoryBtn.Location = new System.Drawing.Point(4, 88);
            this.fillByCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fillByCategoryBtn.Name = "fillByCategoryBtn";
            this.fillByCategoryBtn.Size = new System.Drawing.Size(94, 29);
            this.fillByCategoryBtn.TabIndex = 12;
            this.fillByCategoryBtn.Text = "Category";
            this.fillByCategoryBtn.UseVisualStyleBackColor = false;
            this.fillByCategoryBtn.Click += new System.EventHandler(this.fillByCategoryBtn_Click);
            // 
            // fillByDateBtn
            // 
            this.fillByDateBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fillByDateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByDateBtn.Location = new System.Drawing.Point(4, 17);
            this.fillByDateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fillByDateBtn.Name = "fillByDateBtn";
            this.fillByDateBtn.Size = new System.Drawing.Size(94, 30);
            this.fillByDateBtn.TabIndex = 13;
            this.fillByDateBtn.Text = "Date";
            this.fillByDateBtn.UseVisualStyleBackColor = false;
            this.fillByDateBtn.Click += new System.EventHandler(this.fillByDateBtn_Click);
            // 
            // monthCalendarStart
            // 
            this.monthCalendarStart.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarStart.Location = new System.Drawing.Point(485, 204);
            this.monthCalendarStart.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendarStart.MaxSelectionCount = 31;
            this.monthCalendarStart.Name = "monthCalendarStart";
            this.monthCalendarStart.ShowWeekNumbers = true;
            this.monthCalendarStart.TabIndex = 20;
            // 
            // fillByDateAndCategoryBtn
            // 
            this.fillByDateAndCategoryBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fillByDateAndCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByDateAndCategoryBtn.Location = new System.Drawing.Point(4, 121);
            this.fillByDateAndCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fillByDateAndCategoryBtn.Name = "fillByDateAndCategoryBtn";
            this.fillByDateAndCategoryBtn.Size = new System.Drawing.Size(94, 27);
            this.fillByDateAndCategoryBtn.TabIndex = 21;
            this.fillByDateAndCategoryBtn.Text = "Date Cat";
            this.fillByDateAndCategoryBtn.UseVisualStyleBackColor = false;
            this.fillByDateAndCategoryBtn.Click += new System.EventHandler(this.fillByDateAndCategoryBtn_Click);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AutoGenerateColumns = false;
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.mainDataGridView.DataSource = this.mainBindingSource1;
            this.mainDataGridView.Location = new System.Drawing.Point(31, 30);
            this.mainDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowHeadersVisible = false;
            this.mainDataGridView.RowHeadersWidth = 51;
            this.mainDataGridView.RowTemplate.Height = 24;
            this.mainDataGridView.Size = new System.Drawing.Size(415, 468);
            this.mainDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn5.HeaderText = "date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "value";
            this.dataGridViewTextBoxColumn3.HeaderText = "value";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn4.HeaderText = "category";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn6.HeaderText = "type";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // mainBindingSource1
            // 
            this.mainBindingSource1.DataMember = "main";
            this.mainBindingSource1.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(valueLabel);
            this.groupBox1.Controls.Add(this.valueTextBox);
            this.groupBox1.Controls.Add(categoryLabel);
            this.groupBox1.Controls.Add(this.categoryTextBox);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(this.dateDateTimePicker);
            this.groupBox1.Controls.Add(typeLabel);
            this.groupBox1.Controls.Add(this.typeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(467, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 162);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource1, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(66, 22);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(151, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource1, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(66, 46);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource1, "value", true));
            this.valueTextBox.Location = new System.Drawing.Point(66, 66);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(151, 20);
            this.valueTextBox.TabIndex = 5;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource1, "category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(66, 88);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(151, 20);
            this.categoryTextBox.TabIndex = 7;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mainBindingSource1, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(66, 110);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateDateTimePicker.TabIndex = 9;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource1, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(66, 132);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(151, 20);
            this.typeTextBox.TabIndex = 11;
            // 
            // Filters
            // 
            this.Filters.AutoSize = true;
            this.Filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filters.Location = new System.Drawing.Point(716, 30);
            this.Filters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(60, 24);
            this.Filters.TabIndex = 23;
            this.Filters.Text = "Filters";
            // 
            // fillByTypeBtn
            // 
            this.fillByTypeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fillByTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByTypeBtn.Location = new System.Drawing.Point(4, 51);
            this.fillByTypeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fillByTypeBtn.Name = "fillByTypeBtn";
            this.fillByTypeBtn.Size = new System.Drawing.Size(94, 33);
            this.fillByTypeBtn.TabIndex = 24;
            this.fillByTypeBtn.Text = "Type";
            this.fillByTypeBtn.UseVisualStyleBackColor = false;
            this.fillByTypeBtn.Click += new System.EventHandler(this.fillByTypeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCB);
            this.groupBox2.Controls.Add(this.fillByMonthBtn);
            this.groupBox2.Controls.Add(this.typeCB);
            this.groupBox2.Controls.Add(this.categoryCB);
            this.groupBox2.Controls.Add(this.FillByDateAndTypeBtn);
            this.groupBox2.Controls.Add(this.showAllBtn);
            this.groupBox2.Controls.Add(this.fillByDateBtn);
            this.groupBox2.Controls.Add(this.fillByTypeBtn);
            this.groupBox2.Controls.Add(this.fillByCategoryBtn);
            this.groupBox2.Controls.Add(this.fillByDateAndCategoryBtn);
            this.groupBox2.Location = new System.Drawing.Point(767, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(245, 312);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // monthCB
            // 
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Location = new System.Drawing.Point(102, 225);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(118, 21);
            this.monthCB.TabIndex = 36;
            // 
            // fillByMonthBtn
            // 
            this.fillByMonthBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fillByMonthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByMonthBtn.Location = new System.Drawing.Point(6, 220);
            this.fillByMonthBtn.Name = "fillByMonthBtn";
            this.fillByMonthBtn.Size = new System.Drawing.Size(92, 27);
            this.fillByMonthBtn.TabIndex = 35;
            this.fillByMonthBtn.Text = "Month";
            this.fillByMonthBtn.UseVisualStyleBackColor = false;
            this.fillByMonthBtn.Click += new System.EventHandler(this.fillByMonthBtn_Click);
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(102, 59);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(118, 21);
            this.typeCB.TabIndex = 34;
            // 
            // categoryCB
            // 
            this.categoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(102, 94);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(118, 21);
            this.categoryCB.TabIndex = 33;
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // FillByDateAndTypeBtn
            // 
            this.FillByDateAndTypeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FillByDateAndTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillByDateAndTypeBtn.Location = new System.Drawing.Point(5, 153);
            this.FillByDateAndTypeBtn.Name = "FillByDateAndTypeBtn";
            this.FillByDateAndTypeBtn.Size = new System.Drawing.Size(93, 28);
            this.FillByDateAndTypeBtn.TabIndex = 32;
            this.FillByDateAndTypeBtn.Text = "Date Type";
            this.FillByDateAndTypeBtn.UseVisualStyleBackColor = false;
            this.FillByDateAndTypeBtn.Click += new System.EventHandler(this.FillByDateAndTypeBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.showAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.Location = new System.Drawing.Point(5, 187);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(94, 26);
            this.showAllBtn.TabIndex = 31;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.UseVisualStyleBackColor = false;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // deleteTxt
            // 
            this.deleteTxt.Location = new System.Drawing.Point(565, 420);
            this.deleteTxt.Name = "deleteTxt";
            this.deleteTxt.Size = new System.Drawing.Size(100, 20);
            this.deleteTxt.TabIndex = 29;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(467, 420);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(467, 449);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 31;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // reportsArea
            // 
            this.reportsArea.Location = new System.Drawing.Point(784, 95);
            this.reportsArea.Name = "reportsArea";
            this.reportsArea.Size = new System.Drawing.Size(178, 20);
            this.reportsArea.TabIndex = 32;
            // 
            // mainTableAdapter1
            // 
            this.mainTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.mainTableAdapter = this.mainTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Budget1._1.Data.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1047, 514);
            this.Controls.Add(this.reportsArea);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.deleteTxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.monthCalendarStart);
            this.Controls.Add(this.mainBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Budget";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingNavigator)).EndInit();
            this.mainBindingNavigator.ResumeLayout(false);
            this.mainBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.BindingSource mainBindingSource;
        private System.Windows.Forms.BindingNavigator mainBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mainBindingNavigatorSaveItem;
        private System.Windows.Forms.Button fillByCategoryBtn;
        private System.Windows.Forms.Button fillByDateBtn;
        private System.Windows.Forms.MonthCalendar monthCalendarStart;
        private System.Windows.Forms.Button fillByDateAndCategoryBtn;
        private Data.DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource mainBindingSource1;
        private Data.DataSet2TableAdapters.mainTableAdapter mainTableAdapter1;
        private Data.DataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label Filters;
        private System.Windows.Forms.Button fillByTypeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox deleteTxt;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.TextBox reportsArea;
        private System.Windows.Forms.Button FillByDateAndTypeBtn;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.Button fillByMonthBtn;
    }
}

