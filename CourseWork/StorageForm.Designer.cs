namespace CourseWork
{
    partial class StorageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FoodGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            CountColumn = new DataGridViewTextBoxColumn();
            Units = new DataGridViewTextBoxColumn();
            ExpireDateColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            IndexColumn = new DataGridViewTextBoxColumn();
            CostColumn = new DataGridViewTextBoxColumn();
            TotalCostColumn = new DataGridViewTextBoxColumn();
            AddBtn = new Button();
            CountTB = new TextBox();
            label = new Label();
            label2 = new Label();
            NameTb = new TextBox();
            UnitsTb = new TextBox();
            label4 = new Label();
            ExpireDateTime = new DateTimePicker();
            label3 = new Label();
            SwitchFormBtn = new Button();
            ApplyBtn = new Button();
            DeleteButton = new Button();
            label5 = new Label();
            GetWaybilBtn = new Button();
            UpBtn = new Button();
            DownBtn = new Button();
            label1 = new Label();
            ApplyFilterBtn = new Button();
            NameCB = new CheckBox();
            CountCB = new CheckBox();
            UnitCB = new CheckBox();
            ExpireCB = new CheckBox();
            StatusCB = new CheckBox();
            NameFilterTb = new TextBox();
            CountCompareCmb = new ComboBox();
            CompareExpireCmb = new ComboBox();
            CompareStatusCmb = new ComboBox();
            CountFilterTb = new TextBox();
            UnitFilterTb = new TextBox();
            StatusCmb = new ComboBox();
            FilterTimePicker = new DateTimePicker();
            CompareNameCmb = new ComboBox();
            SaveChangesBtn = new Button();
            FixValueCB = new CheckBox();
            GetCalendarBtn = new Button();
            FileNameTb = new TextBox();
            CalendarTimePicker = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            ClearSortBtn = new Button();
            label8 = new Label();
            CostTb = new TextBox();
            CostCB = new CheckBox();
            CostCompareCmb = new ComboBox();
            CostFilterTb = new TextBox();
            TotalCostFilterTb = new TextBox();
            TotalCostCompareCmb = new ComboBox();
            TotalCostCB = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)FoodGridView).BeginInit();
            SuspendLayout();
            // 
            // FoodGridView
            // 
            FoodGridView.AllowUserToAddRows = false;
            FoodGridView.AllowUserToDeleteRows = false;
            FoodGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FoodGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, CountColumn, Units, ExpireDateColumn, StatusColumn, IndexColumn, CostColumn, TotalCostColumn });
            FoodGridView.Location = new Point(430, 55);
            FoodGridView.MultiSelect = false;
            FoodGridView.Name = "FoodGridView";
            FoodGridView.Size = new Size(742, 435);
            FoodGridView.TabIndex = 0;
            FoodGridView.CellContentClick += FoodGridView_CellContentClick;
            FoodGridView.RowPrePaint += FoodGridView_RowPrePaint;
            FoodGridView.SelectionChanged += FoodGridView_SelectionChanged;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Назва";
            NameColumn.Name = "NameColumn";
            // 
            // CountColumn
            // 
            CountColumn.HeaderText = "Кількість";
            CountColumn.Name = "CountColumn";
            CountColumn.ReadOnly = true;
            // 
            // Units
            // 
            Units.HeaderText = "Одиниці";
            Units.Name = "Units";
            Units.ReadOnly = true;
            // 
            // ExpireDateColumn
            // 
            ExpireDateColumn.HeaderText = "Срок придатності спливає:";
            ExpireDateColumn.Name = "ExpireDateColumn";
            ExpireDateColumn.Width = 140;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Статус";
            StatusColumn.Name = "StatusColumn";
            // 
            // IndexColumn
            // 
            IndexColumn.HeaderText = "---";
            IndexColumn.Name = "IndexColumn";
            IndexColumn.ReadOnly = true;
            IndexColumn.Visible = false;
            // 
            // CostColumn
            // 
            CostColumn.HeaderText = "Ціна за одиницю";
            CostColumn.Name = "CostColumn";
            CostColumn.Width = 80;
            // 
            // TotalCostColumn
            // 
            TotalCostColumn.HeaderText = "Загальна ціна";
            TotalCostColumn.Name = "TotalCostColumn";
            TotalCostColumn.Width = 75;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(496, 564);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(104, 23);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Додати";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CountTB
            // 
            CountTB.Location = new Point(606, 512);
            CountTB.Name = "CountTB";
            CountTB.Size = new Size(100, 23);
            CountTB.TabIndex = 2;
            CountTB.Text = "1";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(525, 494);
            label.Name = "label";
            label.Size = new Size(39, 15);
            label.TabIndex = 3;
            label.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(625, 494);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Кількість";
            // 
            // NameTb
            // 
            NameTb.Location = new Point(496, 512);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(104, 23);
            NameTb.TabIndex = 5;
            // 
            // UnitsTb
            // 
            UnitsTb.Location = new Point(712, 512);
            UnitsTb.Name = "UnitsTb";
            UnitsTb.Size = new Size(85, 23);
            UnitsTb.TabIndex = 6;
            UnitsTb.Text = "шт";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(726, 494);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Одиниці";
            // 
            // ExpireDateTime
            // 
            ExpireDateTime.Location = new Point(807, 512);
            ExpireDateTime.Name = "ExpireDateTime";
            ExpireDateTime.Size = new Size(228, 23);
            ExpireDateTime.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(775, 26);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 10;
            label3.Text = "Продукти на зберіганні:";
            // 
            // SwitchFormBtn
            // 
            SwitchFormBtn.BackColor = Color.FromArgb(255, 192, 128);
            SwitchFormBtn.Location = new Point(115, 496);
            SwitchFormBtn.Name = "SwitchFormBtn";
            SwitchFormBtn.Size = new Size(213, 38);
            SwitchFormBtn.TabIndex = 11;
            SwitchFormBtn.Text = "Перейти до рецептів";
            SwitchFormBtn.UseVisualStyleBackColor = false;
            SwitchFormBtn.Click += SwitchFormBtn_Click;
            // 
            // ApplyBtn
            // 
            ApplyBtn.Location = new Point(712, 564);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(85, 23);
            ApplyBtn.TabIndex = 12;
            ApplyBtn.Text = "Встановити";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(606, 564);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(100, 23);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "Видалити";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(827, 494);
            label5.Name = "label5";
            label5.Size = new Size(155, 15);
            label5.TabIndex = 14;
            label5.Text = "Срок придатності спливає:";
            // 
            // GetWaybilBtn
            // 
            GetWaybilBtn.Location = new Point(115, 653);
            GetWaybilBtn.Name = "GetWaybilBtn";
            GetWaybilBtn.Size = new Size(75, 38);
            GetWaybilBtn.TabIndex = 15;
            GetWaybilBtn.Text = "Отримати накладну";
            GetWaybilBtn.UseVisualStyleBackColor = true;
            GetWaybilBtn.Click += GetWaybilBtn_Click;
            // 
            // UpBtn
            // 
            UpBtn.Location = new Point(437, 511);
            UpBtn.Name = "UpBtn";
            UpBtn.Size = new Size(53, 23);
            UpBtn.TabIndex = 16;
            UpBtn.Text = "Вгору";
            UpBtn.UseVisualStyleBackColor = true;
            UpBtn.Click += UpBtn_Click;
            // 
            // DownBtn
            // 
            DownBtn.Location = new Point(437, 564);
            DownBtn.Name = "DownBtn";
            DownBtn.Size = new Size(53, 23);
            DownBtn.TabIndex = 17;
            DownBtn.Text = "Вниз";
            DownBtn.UseVisualStyleBackColor = true;
            DownBtn.Click += DownBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 26);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 18;
            label1.Text = "Фільтри:";
            label1.Click += label1_Click;
            // 
            // ApplyFilterBtn
            // 
            ApplyFilterBtn.Location = new Point(169, 288);
            ApplyFilterBtn.Name = "ApplyFilterBtn";
            ApplyFilterBtn.Size = new Size(104, 44);
            ApplyFilterBtn.TabIndex = 19;
            ApplyFilterBtn.Text = "Прийняти фільтри";
            ApplyFilterBtn.UseVisualStyleBackColor = true;
            ApplyFilterBtn.Click += ApplyFilterBtn_Click;
            // 
            // NameCB
            // 
            NameCB.AutoSize = true;
            NameCB.Location = new Point(25, 57);
            NameCB.Name = "NameCB";
            NameCB.Size = new Size(83, 19);
            NameCB.TabIndex = 20;
            NameCB.Text = "За назвою";
            NameCB.UseVisualStyleBackColor = true;
            // 
            // CountCB
            // 
            CountCB.AutoSize = true;
            CountCB.Location = new Point(25, 88);
            CountCB.Name = "CountCB";
            CountCB.Size = new Size(94, 19);
            CountCB.TabIndex = 21;
            CountCB.Text = "За кількістю";
            CountCB.UseVisualStyleBackColor = true;
            // 
            // UnitCB
            // 
            UnitCB.AutoSize = true;
            UnitCB.Location = new Point(25, 117);
            UnitCB.Name = "UnitCB";
            UnitCB.Size = new Size(105, 19);
            UnitCB.TabIndex = 22;
            UnitCB.Text = "За одиницями";
            UnitCB.UseVisualStyleBackColor = true;
            // 
            // ExpireCB
            // 
            ExpireCB.AutoSize = true;
            ExpireCB.Location = new Point(25, 146);
            ExpireCB.Name = "ExpireCB";
            ExpireCB.Size = new Size(117, 19);
            ExpireCB.TabIndex = 23;
            ExpireCB.Text = "За сроком прид.";
            ExpireCB.UseVisualStyleBackColor = true;
            // 
            // StatusCB
            // 
            StatusCB.AutoSize = true;
            StatusCB.Location = new Point(25, 180);
            StatusCB.Name = "StatusCB";
            StatusCB.Size = new Size(92, 19);
            StatusCB.TabIndex = 24;
            StatusCB.Text = "За статусом";
            StatusCB.UseVisualStyleBackColor = true;
            // 
            // NameFilterTb
            // 
            NameFilterTb.Location = new Point(279, 55);
            NameFilterTb.Name = "NameFilterTb";
            NameFilterTb.Size = new Size(130, 23);
            NameFilterTb.TabIndex = 25;
            // 
            // CountCompareCmb
            // 
            CountCompareCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CountCompareCmb.FormattingEnabled = true;
            CountCompareCmb.Items.AddRange(new object[] { ">", "<", "=", ">=", "<=", "!=" });
            CountCompareCmb.Location = new Point(149, 84);
            CountCompareCmb.Name = "CountCompareCmb";
            CountCompareCmb.Size = new Size(44, 23);
            CountCompareCmb.TabIndex = 26;
            // 
            // CompareExpireCmb
            // 
            CompareExpireCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CompareExpireCmb.FormattingEnabled = true;
            CompareExpireCmb.Items.AddRange(new object[] { ">", "<", "=", ">=", "<=", "!=" });
            CompareExpireCmb.Location = new Point(148, 142);
            CompareExpireCmb.Name = "CompareExpireCmb";
            CompareExpireCmb.Size = new Size(45, 23);
            CompareExpireCmb.TabIndex = 27;
            // 
            // CompareStatusCmb
            // 
            CompareStatusCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CompareStatusCmb.FormattingEnabled = true;
            CompareStatusCmb.Items.AddRange(new object[] { ">", "<", "=", ">=", "<=", "!=" });
            CompareStatusCmb.Location = new Point(148, 176);
            CompareStatusCmb.Name = "CompareStatusCmb";
            CompareStatusCmb.Size = new Size(45, 23);
            CompareStatusCmb.TabIndex = 28;
            // 
            // CountFilterTb
            // 
            CountFilterTb.Location = new Point(199, 84);
            CountFilterTb.Name = "CountFilterTb";
            CountFilterTb.Size = new Size(210, 23);
            CountFilterTb.TabIndex = 29;
            // 
            // UnitFilterTb
            // 
            UnitFilterTb.Location = new Point(199, 113);
            UnitFilterTb.Name = "UnitFilterTb";
            UnitFilterTb.Size = new Size(210, 23);
            UnitFilterTb.TabIndex = 30;
            // 
            // StatusCmb
            // 
            StatusCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusCmb.FormattingEnabled = true;
            StatusCmb.Items.AddRange(new object[] { "Свіжий", "Напівсвіжий", "Прострочений", "Гнилий" });
            StatusCmb.Location = new Point(199, 176);
            StatusCmb.Name = "StatusCmb";
            StatusCmb.Size = new Size(210, 23);
            StatusCmb.TabIndex = 32;
            // 
            // FilterTimePicker
            // 
            FilterTimePicker.Location = new Point(199, 142);
            FilterTimePicker.Name = "FilterTimePicker";
            FilterTimePicker.Size = new Size(210, 23);
            FilterTimePicker.TabIndex = 33;
            // 
            // CompareNameCmb
            // 
            CompareNameCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CompareNameCmb.FormattingEnabled = true;
            CompareNameCmb.Items.AddRange(new object[] { "Містить", "Збігається з", "Починається з", "Закінчується на" });
            CompareNameCmb.Location = new Point(149, 55);
            CompareNameCmb.Name = "CompareNameCmb";
            CompareNameCmb.Size = new Size(124, 23);
            CompareNameCmb.TabIndex = 34;
            // 
            // SaveChangesBtn
            // 
            SaveChangesBtn.Location = new Point(169, 406);
            SaveChangesBtn.Name = "SaveChangesBtn";
            SaveChangesBtn.Size = new Size(104, 38);
            SaveChangesBtn.TabIndex = 35;
            SaveChangesBtn.Text = "Зберегти зміни";
            SaveChangesBtn.UseVisualStyleBackColor = true;
            SaveChangesBtn.Click += SaveChangesBtn_Click;
            // 
            // FixValueCB
            // 
            FixValueCB.AutoSize = true;
            FixValueCB.Location = new Point(807, 568);
            FixValueCB.Name = "FixValueCB";
            FixValueCB.Size = new Size(147, 19);
            FixValueCB.TabIndex = 36;
            FixValueCB.Text = "Зафіксувати значення";
            FixValueCB.UseVisualStyleBackColor = true;
            // 
            // GetCalendarBtn
            // 
            GetCalendarBtn.Location = new Point(115, 609);
            GetCalendarBtn.Name = "GetCalendarBtn";
            GetCalendarBtn.Size = new Size(75, 38);
            GetCalendarBtn.TabIndex = 37;
            GetCalendarBtn.Text = "Отримати календар";
            GetCalendarBtn.UseVisualStyleBackColor = true;
            GetCalendarBtn.Click += GetCalendarBtn_Click;
            // 
            // FileNameTb
            // 
            FileNameTb.Location = new Point(115, 562);
            FileNameTb.Name = "FileNameTb";
            FileNameTb.Size = new Size(213, 23);
            FileNameTb.TabIndex = 38;
            // 
            // CalendarTimePicker
            // 
            CalendarTimePicker.CustomFormat = "MM/yyyy";
            CalendarTimePicker.Format = DateTimePickerFormat.Custom;
            CalendarTimePicker.Location = new Point(199, 614);
            CalendarTimePicker.Name = "CalendarTimePicker";
            CalendarTimePicker.Size = new Size(129, 23);
            CalendarTimePicker.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 545);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 40;
            label6.Text = "Ім'я файлу";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(244, 597);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 41;
            label7.Text = "Місяць:";
            // 
            // ClearSortBtn
            // 
            ClearSortBtn.Location = new Point(169, 336);
            ClearSortBtn.Name = "ClearSortBtn";
            ClearSortBtn.Size = new Size(104, 44);
            ClearSortBtn.TabIndex = 42;
            ClearSortBtn.Text = "Скинути сортування";
            ClearSortBtn.UseVisualStyleBackColor = true;
            ClearSortBtn.Click += ClearSortBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1058, 495);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 43;
            label8.Text = "Ціна за одиницю";
            // 
            // CostTb
            // 
            CostTb.Location = new Point(1044, 511);
            CostTb.Name = "CostTb";
            CostTb.Size = new Size(114, 23);
            CostTb.TabIndex = 44;
            CostTb.Text = "0";
            // 
            // CostCB
            // 
            CostCB.AutoSize = true;
            CostCB.Location = new Point(25, 205);
            CostCB.Name = "CostCB";
            CostCB.Size = new Size(79, 19);
            CostCB.TabIndex = 45;
            CostCB.Text = "За ціною:";
            CostCB.UseVisualStyleBackColor = true;
            // 
            // CostCompareCmb
            // 
            CostCompareCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CostCompareCmb.FormattingEnabled = true;
            CostCompareCmb.Items.AddRange(new object[] { ">", "<", "=", ">=", "<=", "!=" });
            CostCompareCmb.Location = new Point(148, 205);
            CostCompareCmb.Name = "CostCompareCmb";
            CostCompareCmb.Size = new Size(45, 23);
            CostCompareCmb.TabIndex = 46;
            // 
            // CostFilterTb
            // 
            CostFilterTb.Location = new Point(199, 203);
            CostFilterTb.Name = "CostFilterTb";
            CostFilterTb.Size = new Size(210, 23);
            CostFilterTb.TabIndex = 47;
            // 
            // TotalCostFilterTb
            // 
            TotalCostFilterTb.Location = new Point(199, 234);
            TotalCostFilterTb.Name = "TotalCostFilterTb";
            TotalCostFilterTb.Size = new Size(210, 23);
            TotalCostFilterTb.TabIndex = 50;
            // 
            // TotalCostCompareCmb
            // 
            TotalCostCompareCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            TotalCostCompareCmb.FormattingEnabled = true;
            TotalCostCompareCmb.Items.AddRange(new object[] { ">", "<", "=", ">=", "<=", "!=" });
            TotalCostCompareCmb.Location = new Point(147, 234);
            TotalCostCompareCmb.Name = "TotalCostCompareCmb";
            TotalCostCompareCmb.Size = new Size(45, 23);
            TotalCostCompareCmb.TabIndex = 49;
            // 
            // TotalCostCB
            // 
            TotalCostCB.AutoSize = true;
            TotalCostCB.Location = new Point(25, 234);
            TotalCostCB.Name = "TotalCostCB";
            TotalCostCB.Size = new Size(101, 19);
            TotalCostCB.TabIndex = 48;
            TotalCostCB.Text = "За заг. ціною:";
            TotalCostCB.UseVisualStyleBackColor = true;
            // 
            // StorageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(TotalCostFilterTb);
            Controls.Add(TotalCostCompareCmb);
            Controls.Add(TotalCostCB);
            Controls.Add(CostFilterTb);
            Controls.Add(CostCompareCmb);
            Controls.Add(CostCB);
            Controls.Add(CostTb);
            Controls.Add(label8);
            Controls.Add(ClearSortBtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(CalendarTimePicker);
            Controls.Add(FileNameTb);
            Controls.Add(GetCalendarBtn);
            Controls.Add(FixValueCB);
            Controls.Add(SaveChangesBtn);
            Controls.Add(CompareNameCmb);
            Controls.Add(FilterTimePicker);
            Controls.Add(StatusCmb);
            Controls.Add(UnitFilterTb);
            Controls.Add(CountFilterTb);
            Controls.Add(CompareStatusCmb);
            Controls.Add(CompareExpireCmb);
            Controls.Add(CountCompareCmb);
            Controls.Add(NameFilterTb);
            Controls.Add(StatusCB);
            Controls.Add(ExpireCB);
            Controls.Add(UnitCB);
            Controls.Add(CountCB);
            Controls.Add(NameCB);
            Controls.Add(ApplyFilterBtn);
            Controls.Add(label1);
            Controls.Add(DownBtn);
            Controls.Add(UpBtn);
            Controls.Add(GetWaybilBtn);
            Controls.Add(label5);
            Controls.Add(DeleteButton);
            Controls.Add(ApplyBtn);
            Controls.Add(SwitchFormBtn);
            Controls.Add(label3);
            Controls.Add(ExpireDateTime);
            Controls.Add(label4);
            Controls.Add(UnitsTb);
            Controls.Add(NameTb);
            Controls.Add(label2);
            Controls.Add(label);
            Controls.Add(CountTB);
            Controls.Add(AddBtn);
            Controls.Add(FoodGridView);
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1200, 800);
            Name = "StorageForm";
            Text = "Сховище";
            Load += Form1_Load;
            FormClosing += Form1_Close;
            ((System.ComponentModel.ISupportInitialize)FoodGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView FoodGridView;
        private Button AddBtn;
        private TextBox CountTB;
        private Label label;
        private Label label2;
        private TextBox NameTb;
        private TextBox UnitsTb;
        private Label label4;
        private DateTimePicker ExpireDateTime;
        private Label label3;
        private Button SwitchFormBtn;
        private Button ApplyBtn;
        private Button DeleteButton;
        private Label label5;
        private Button GetWaybilBtn;
        private Button UpBtn;
        private Button DownBtn;
        private Label label1;
        private Button ApplyFilterBtn;
        private CheckBox NameCB;
        private CheckBox CountCB;
        private CheckBox UnitCB;
        private CheckBox ExpireCB;
        private CheckBox StatusCB;
        private TextBox NameFilterTb;
        private ComboBox CountCompareCmb;
        private ComboBox CompareExpireCmb;
        private ComboBox CompareStatusCmb;
        private TextBox CountFilterTb;
        private TextBox UnitFilterTb;
        private ComboBox StatusCmb;
        private DateTimePicker FilterTimePicker;
        private ComboBox CompareNameCmb;
        private Button SaveChangesBtn;
        private CheckBox FixValueCB;
        private Button GetCalendarBtn;
        private TextBox FileNameTb;
        private DateTimePicker CalendarTimePicker;
        private Label label6;
        private Label label7;
        private Button ClearSortBtn;
        private Label label8;
        private TextBox CostTb;
        private CheckBox CostCB;
        private ComboBox CostCompareCmb;
        private TextBox CostFilterTb;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CountColumn;
        private DataGridViewTextBoxColumn Units;
        private DataGridViewTextBoxColumn ExpireDateColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn IndexColumn;
        private DataGridViewTextBoxColumn CostColumn;
        private DataGridViewTextBoxColumn TotalCostColumn;
        private TextBox TotalCostFilterTb;
        private ComboBox TotalCostCompareCmb;
        private CheckBox TotalCostCB;
    }
}
