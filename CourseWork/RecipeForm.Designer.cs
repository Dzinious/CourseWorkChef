namespace CourseWork
{
    partial class RecipeForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            SwitchFormBtn = new Button();
            RecipeGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            ExpireTermColumn = new DataGridViewTextBoxColumn();
            IngredientCountColumn = new DataGridViewTextBoxColumn();
            IndexColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            RatingColumn = new DataGridViewTextBoxColumn();
            IngredientGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            CountColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            FreshCountColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            CompareNameCmb = new ComboBox();
            CountFilterTb = new TextBox();
            CompareExpireCmb = new ComboBox();
            CountCompareCmb = new ComboBox();
            NameFilterTb = new TextBox();
            ExpireCB = new CheckBox();
            CountCB = new CheckBox();
            NameCB = new CheckBox();
            ApplyFilterBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ExpireDaysFilterTb = new TextBox();
            NameTb = new TextBox();
            ExpireDaysTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            DownBtn = new Button();
            UpBtn = new Button();
            DeleteButton = new Button();
            ApplyBtn = new Button();
            AddBtn = new Button();
            IngredientDownBtn = new Button();
            IngredientUpBtn = new Button();
            IngredientDeleteBtn = new Button();
            IngredientApplyBtn = new Button();
            IngredientAddBtn = new Button();
            label7 = new Label();
            IngredientUnitsTb = new TextBox();
            IngredientNameTb = new TextBox();
            IngredientCountTb = new TextBox();
            label8 = new Label();
            label9 = new Label();
            FixValueCB = new CheckBox();
            IngredientFixValueCB = new CheckBox();
            ClearSortBtn = new Button();
            IngredientCleartSort = new Button();
            SaveChangesBtn = new Button();
            CountReadyFilterTb = new TextBox();
            CountReadyCompareCmb = new ComboBox();
            CountReadyCB = new CheckBox();
            label6 = new Label();
            MealOftheDayTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)RecipeGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientGridView).BeginInit();
            SuspendLayout();
            // 
            // SwitchFormBtn
            // 
            SwitchFormBtn.BackColor = Color.FromArgb(255, 192, 128);
            SwitchFormBtn.Location = new Point(151, 469);
            SwitchFormBtn.Name = "SwitchFormBtn";
            SwitchFormBtn.Size = new Size(104, 72);
            SwitchFormBtn.TabIndex = 0;
            SwitchFormBtn.Text = "Перейти до сховища";
            SwitchFormBtn.UseVisualStyleBackColor = false;
            SwitchFormBtn.Click += SwitchFormBtn_Click;
            // 
            // RecipeGridView
            // 
            RecipeGridView.AllowUserToAddRows = false;
            RecipeGridView.AllowUserToDeleteRows = false;
            RecipeGridView.AllowUserToResizeColumns = false;
            RecipeGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RecipeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipeGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ExpireTermColumn, IngredientCountColumn, IndexColumn, StatusColumn, RatingColumn });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            RecipeGridView.DefaultCellStyle = dataGridViewCellStyle1;
            RecipeGridView.Location = new Point(447, 76);
            RecipeGridView.Name = "RecipeGridView";
            RecipeGridView.ReadOnly = true;
            RecipeGridView.Size = new Size(475, 339);
            RecipeGridView.TabIndex = 1;
            RecipeGridView.CurrentCellChanged += RecipeGridView_CurrentCellChanged;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Назва рецепту";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 110;
            // 
            // ExpireTermColumn
            // 
            ExpireTermColumn.HeaderText = "Строк зберігання";
            ExpireTermColumn.Name = "ExpireTermColumn";
            ExpireTermColumn.ReadOnly = true;
            ExpireTermColumn.Width = 110;
            // 
            // IngredientCountColumn
            // 
            IngredientCountColumn.HeaderText = "Кількість інгредієнтів";
            IngredientCountColumn.Name = "IngredientCountColumn";
            IngredientCountColumn.ReadOnly = true;
            // 
            // IndexColumn
            // 
            IndexColumn.HeaderText = "---";
            IndexColumn.Name = "IndexColumn";
            IndexColumn.ReadOnly = true;
            IndexColumn.Visible = false;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Готово до приготування";
            StatusColumn.Name = "StatusColumn";
            StatusColumn.ReadOnly = true;
            // 
            // RatingColumn
            // 
            RatingColumn.HeaderText = "----";
            RatingColumn.Name = "RatingColumn";
            RatingColumn.ReadOnly = true;
            RatingColumn.Visible = false;
            // 
            // IngredientGridView
            // 
            IngredientGridView.AllowUserToAddRows = false;
            IngredientGridView.AllowUserToDeleteRows = false;
            IngredientGridView.AllowUserToResizeColumns = false;
            IngredientGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            IngredientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, CountColumn, dataGridViewTextBoxColumn4, FreshCountColumn, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            IngredientGridView.DefaultCellStyle = dataGridViewCellStyle2;
            IngredientGridView.Location = new Point(942, 78);
            IngredientGridView.Name = "IngredientGridView";
            IngredientGridView.ReadOnly = true;
            IngredientGridView.Size = new Size(554, 337);
            IngredientGridView.TabIndex = 2;
            IngredientGridView.CellContentClick += IngredientGridView_CellContentClick;
            IngredientGridView.CurrentCellChanged += IngredientGridView_CurrentCellChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Назва інгредієнту";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Необхідна кількість";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CountColumn
            // 
            CountColumn.HeaderText = "Кількість на складі";
            CountColumn.Name = "CountColumn";
            CountColumn.ReadOnly = true;
            CountColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "---";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
            // 
            // FreshCountColumn
            // 
            FreshCountColumn.HeaderText = " З них за свіжістю:";
            FreshCountColumn.Name = "FreshCountColumn";
            FreshCountColumn.ReadOnly = true;
            FreshCountColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Одиниці вимірювання";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // CompareNameCmb
            // 
            CompareNameCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CompareNameCmb.FormattingEnabled = true;
            CompareNameCmb.Items.AddRange(new object[] { "Містить", "Збігається з", "Починається з", "Закінчується на" });
            CompareNameCmb.Location = new Point(162, 76);
            CompareNameCmb.Name = "CompareNameCmb";
            CompareNameCmb.Size = new Size(124, 23);
            CompareNameCmb.TabIndex = 50;
            // 
            // CountFilterTb
            // 
            CountFilterTb.Location = new Point(212, 105);
            CountFilterTb.Name = "CountFilterTb";
            CountFilterTb.Size = new Size(205, 23);
            CountFilterTb.TabIndex = 46;
            // 
            // CompareExpireCmb
            // 
            CompareExpireCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CompareExpireCmb.FormattingEnabled = true;
            CompareExpireCmb.Items.AddRange(new object[] { ">", "<", "=", ">=", "<=", "!=" });
            CompareExpireCmb.Location = new Point(161, 134);
            CompareExpireCmb.Name = "CompareExpireCmb";
            CompareExpireCmb.Size = new Size(45, 23);
            CompareExpireCmb.TabIndex = 44;
            // 
            // CountCompareCmb
            // 
            CountCompareCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CountCompareCmb.FormattingEnabled = true;
            CountCompareCmb.Items.AddRange(new object[] { ">", "<", "=", ">=", "<=", "!=" });
            CountCompareCmb.Location = new Point(162, 105);
            CountCompareCmb.Name = "CountCompareCmb";
            CountCompareCmb.Size = new Size(44, 23);
            CountCompareCmb.TabIndex = 43;
            // 
            // NameFilterTb
            // 
            NameFilterTb.Location = new Point(292, 76);
            NameFilterTb.Name = "NameFilterTb";
            NameFilterTb.Size = new Size(125, 23);
            NameFilterTb.TabIndex = 42;
            // 
            // ExpireCB
            // 
            ExpireCB.AutoSize = true;
            ExpireCB.Location = new Point(8, 138);
            ExpireCB.Name = "ExpireCB";
            ExpireCB.Size = new Size(151, 19);
            ExpireCB.TabIndex = 40;
            ExpireCB.Text = "За строком зберігання";
            ExpireCB.UseVisualStyleBackColor = true;
            // 
            // CountCB
            // 
            CountCB.AutoSize = true;
            CountCB.Location = new Point(8, 109);
            CountCB.Name = "CountCB";
            CountCB.Size = new Size(141, 19);
            CountCB.TabIndex = 38;
            CountCB.Text = "За к-стю інгредієнтів";
            CountCB.UseVisualStyleBackColor = true;
            // 
            // NameCB
            // 
            NameCB.AutoSize = true;
            NameCB.Location = new Point(8, 78);
            NameCB.Name = "NameCB";
            NameCB.Size = new Size(83, 19);
            NameCB.TabIndex = 37;
            NameCB.Text = "За назвою";
            NameCB.UseVisualStyleBackColor = true;
            // 
            // ApplyFilterBtn
            // 
            ApplyFilterBtn.Location = new Point(153, 204);
            ApplyFilterBtn.Name = "ApplyFilterBtn";
            ApplyFilterBtn.Size = new Size(104, 44);
            ApplyFilterBtn.TabIndex = 36;
            ApplyFilterBtn.Text = "Прийняти фільтри";
            ApplyFilterBtn.UseVisualStyleBackColor = true;
            ApplyFilterBtn.Click += ApplyFilterBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 47);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 35;
            label1.Text = "Фільтри:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(640, 47);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 51;
            label2.Text = "Рецепти:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1177, 47);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 52;
            label3.Text = "Інгредієнти:";
            label3.Click += label3_Click;
            // 
            // ExpireDaysFilterTb
            // 
            ExpireDaysFilterTb.Location = new Point(212, 134);
            ExpireDaysFilterTb.Name = "ExpireDaysFilterTb";
            ExpireDaysFilterTb.Size = new Size(205, 23);
            ExpireDaysFilterTb.TabIndex = 53;
            // 
            // NameTb
            // 
            NameTb.Location = new Point(506, 452);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(143, 23);
            NameTb.TabIndex = 54;
            NameTb.TextChanged += NameTb_TextChanged;
            // 
            // ExpireDaysTb
            // 
            ExpireDaysTb.Location = new Point(663, 452);
            ExpireDaysTb.Name = "ExpireDaysTb";
            ExpireDaysTb.Size = new Size(249, 23);
            ExpireDaysTb.TabIndex = 55;
            ExpireDaysTb.Text = "7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(557, 434);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 56;
            label4.Text = "Назва";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(730, 434);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 57;
            label5.Text = "Строк зберігання";
            // 
            // DownBtn
            // 
            DownBtn.Location = new Point(447, 505);
            DownBtn.Name = "DownBtn";
            DownBtn.Size = new Size(53, 23);
            DownBtn.TabIndex = 62;
            DownBtn.Text = "Вниз";
            DownBtn.UseVisualStyleBackColor = true;
            DownBtn.Click += DownBtn_Click;
            // 
            // UpBtn
            // 
            UpBtn.Location = new Point(447, 452);
            UpBtn.Name = "UpBtn";
            UpBtn.Size = new Size(53, 23);
            UpBtn.TabIndex = 61;
            UpBtn.Text = "Вгору";
            UpBtn.UseVisualStyleBackColor = true;
            UpBtn.Click += UpBtn_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(572, 505);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(77, 23);
            DeleteButton.TabIndex = 60;
            DeleteButton.Text = "Видалити";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ApplyBtn
            // 
            ApplyBtn.Location = new Point(663, 505);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(81, 23);
            ApplyBtn.TabIndex = 59;
            ApplyBtn.Text = "Встановити";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(506, 505);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(60, 23);
            AddBtn.TabIndex = 58;
            AddBtn.Text = "Додати";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // IngredientDownBtn
            // 
            IngredientDownBtn.Location = new Point(942, 505);
            IngredientDownBtn.Name = "IngredientDownBtn";
            IngredientDownBtn.Size = new Size(45, 23);
            IngredientDownBtn.TabIndex = 71;
            IngredientDownBtn.Text = "Вниз";
            IngredientDownBtn.UseVisualStyleBackColor = true;
            IngredientDownBtn.Click += IngredientDownBtn_Click;
            // 
            // IngredientUpBtn
            // 
            IngredientUpBtn.Location = new Point(942, 452);
            IngredientUpBtn.Name = "IngredientUpBtn";
            IngredientUpBtn.Size = new Size(45, 23);
            IngredientUpBtn.TabIndex = 70;
            IngredientUpBtn.Text = "Вгору";
            IngredientUpBtn.UseVisualStyleBackColor = true;
            IngredientUpBtn.Click += IngredientUpBtn_Click;
            // 
            // IngredientDeleteBtn
            // 
            IngredientDeleteBtn.Location = new Point(1073, 506);
            IngredientDeleteBtn.Name = "IngredientDeleteBtn";
            IngredientDeleteBtn.Size = new Size(65, 23);
            IngredientDeleteBtn.TabIndex = 69;
            IngredientDeleteBtn.Text = "Видалити";
            IngredientDeleteBtn.UseVisualStyleBackColor = true;
            IngredientDeleteBtn.Click += IngredientDeleteBtn_Click;
            // 
            // IngredientApplyBtn
            // 
            IngredientApplyBtn.Location = new Point(1144, 505);
            IngredientApplyBtn.Name = "IngredientApplyBtn";
            IngredientApplyBtn.Size = new Size(82, 23);
            IngredientApplyBtn.TabIndex = 68;
            IngredientApplyBtn.Text = "Встановити";
            IngredientApplyBtn.UseVisualStyleBackColor = true;
            IngredientApplyBtn.Click += IngredientApplyBtn_Click;
            // 
            // IngredientAddBtn
            // 
            IngredientAddBtn.Location = new Point(1007, 505);
            IngredientAddBtn.Name = "IngredientAddBtn";
            IngredientAddBtn.Size = new Size(52, 23);
            IngredientAddBtn.TabIndex = 67;
            IngredientAddBtn.Text = "Додати";
            IngredientAddBtn.UseVisualStyleBackColor = true;
            IngredientAddBtn.Click += IngredientAddBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1051, 434);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 65;
            label7.Text = "Назва";
            // 
            // IngredientUnitsTb
            // 
            IngredientUnitsTb.Location = new Point(1240, 453);
            IngredientUnitsTb.Name = "IngredientUnitsTb";
            IngredientUnitsTb.Size = new Size(87, 23);
            IngredientUnitsTb.TabIndex = 64;
            IngredientUnitsTb.Text = "шт";
            IngredientUnitsTb.TextChanged += IngredintUnitsTb_TextChanged;
            // 
            // IngredientNameTb
            // 
            IngredientNameTb.Location = new Point(1007, 452);
            IngredientNameTb.Name = "IngredientNameTb";
            IngredientNameTb.Size = new Size(115, 23);
            IngredientNameTb.TabIndex = 63;
            // 
            // IngredientCountTb
            // 
            IngredientCountTb.Location = new Point(1144, 453);
            IngredientCountTb.Name = "IngredientCountTb";
            IngredientCountTb.Size = new Size(82, 23);
            IngredientCountTb.TabIndex = 72;
            IngredientCountTb.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1139, 435);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 73;
            label8.Text = "Необхідна к-сть";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1256, 434);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 74;
            label9.Text = "Одиниці";
            label9.Click += label9_Click;
            // 
            // FixValueCB
            // 
            FixValueCB.AutoSize = true;
            FixValueCB.Location = new Point(750, 509);
            FixValueCB.Name = "FixValueCB";
            FixValueCB.Size = new Size(147, 19);
            FixValueCB.TabIndex = 75;
            FixValueCB.Text = "Зафіксувати значення";
            FixValueCB.UseVisualStyleBackColor = true;
            // 
            // IngredientFixValueCB
            // 
            IngredientFixValueCB.AutoSize = true;
            IngredientFixValueCB.Location = new Point(1240, 510);
            IngredientFixValueCB.Name = "IngredientFixValueCB";
            IngredientFixValueCB.Size = new Size(147, 19);
            IngredientFixValueCB.TabIndex = 76;
            IngredientFixValueCB.Text = "Зафіксувати значення";
            IngredientFixValueCB.UseVisualStyleBackColor = true;
            // 
            // ClearSortBtn
            // 
            ClearSortBtn.Location = new Point(93, 254);
            ClearSortBtn.Name = "ClearSortBtn";
            ClearSortBtn.Size = new Size(104, 56);
            ClearSortBtn.TabIndex = 77;
            ClearSortBtn.Text = "Скинути сортування";
            ClearSortBtn.UseVisualStyleBackColor = true;
            ClearSortBtn.Click += ClearSortBtn_Click;
            // 
            // IngredientCleartSort
            // 
            IngredientCleartSort.Location = new Point(203, 254);
            IngredientCleartSort.Name = "IngredientCleartSort";
            IngredientCleartSort.Size = new Size(104, 56);
            IngredientCleartSort.TabIndex = 78;
            IngredientCleartSort.Text = "Скинути сортування інгредієнтів";
            IngredientCleartSort.UseVisualStyleBackColor = true;
            IngredientCleartSort.Click += IngredientCleartSort_Click;
            // 
            // SaveChangesBtn
            // 
            SaveChangesBtn.Location = new Point(151, 324);
            SaveChangesBtn.Name = "SaveChangesBtn";
            SaveChangesBtn.Size = new Size(104, 38);
            SaveChangesBtn.TabIndex = 79;
            SaveChangesBtn.Text = "Зберегти зміни";
            SaveChangesBtn.UseVisualStyleBackColor = true;
            SaveChangesBtn.Click += SaveChangesBtn_Click;
            // 
            // CountReadyFilterTb
            // 
            CountReadyFilterTb.Location = new Point(212, 163);
            CountReadyFilterTb.Name = "CountReadyFilterTb";
            CountReadyFilterTb.Size = new Size(205, 23);
            CountReadyFilterTb.TabIndex = 82;
            // 
            // CountReadyCompareCmb
            // 
            CountReadyCompareCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CountReadyCompareCmb.FormattingEnabled = true;
            CountReadyCompareCmb.Items.AddRange(new object[] { ">", "<", "=", ">=", "<=", "!=" });
            CountReadyCompareCmb.Location = new Point(161, 163);
            CountReadyCompareCmb.Name = "CountReadyCompareCmb";
            CountReadyCompareCmb.Size = new Size(45, 23);
            CountReadyCompareCmb.TabIndex = 81;
            // 
            // CountReadyCB
            // 
            CountReadyCB.AutoSize = true;
            CountReadyCB.Location = new Point(8, 167);
            CountReadyCB.Name = "CountReadyCB";
            CountReadyCB.Size = new Size(143, 19);
            CountReadyCB.TabIndex = 80;
            CountReadyCB.Text = "За к-істю для пригот.";
            CountReadyCB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 388);
            label6.Name = "label6";
            label6.Size = new Size(147, 15);
            label6.TabIndex = 83;
            label6.Text = "Пропонована страва дня:";
            // 
            // MealOftheDayTb
            // 
            MealOftheDayTb.Location = new Point(119, 406);
            MealOftheDayTb.Name = "MealOftheDayTb";
            MealOftheDayTb.ReadOnly = true;
            MealOftheDayTb.Size = new Size(167, 23);
            MealOftheDayTb.TabIndex = 84;
            MealOftheDayTb.Click += MealOftheDayTb_Click;
            // 
            // RecipeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 761);
            Controls.Add(MealOftheDayTb);
            Controls.Add(label6);
            Controls.Add(CountReadyFilterTb);
            Controls.Add(CountReadyCompareCmb);
            Controls.Add(CountReadyCB);
            Controls.Add(SaveChangesBtn);
            Controls.Add(IngredientCleartSort);
            Controls.Add(ClearSortBtn);
            Controls.Add(IngredientFixValueCB);
            Controls.Add(FixValueCB);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(IngredientCountTb);
            Controls.Add(IngredientDownBtn);
            Controls.Add(IngredientUpBtn);
            Controls.Add(IngredientDeleteBtn);
            Controls.Add(IngredientApplyBtn);
            Controls.Add(IngredientAddBtn);
            Controls.Add(label7);
            Controls.Add(IngredientUnitsTb);
            Controls.Add(IngredientNameTb);
            Controls.Add(DownBtn);
            Controls.Add(UpBtn);
            Controls.Add(DeleteButton);
            Controls.Add(ApplyBtn);
            Controls.Add(AddBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ExpireDaysTb);
            Controls.Add(NameTb);
            Controls.Add(ExpireDaysFilterTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CompareNameCmb);
            Controls.Add(CountFilterTb);
            Controls.Add(CompareExpireCmb);
            Controls.Add(CountCompareCmb);
            Controls.Add(NameFilterTb);
            Controls.Add(ExpireCB);
            Controls.Add(CountCB);
            Controls.Add(NameCB);
            Controls.Add(ApplyFilterBtn);
            Controls.Add(label1);
            Controls.Add(IngredientGridView);
            Controls.Add(RecipeGridView);
            Controls.Add(SwitchFormBtn);
            MaximumSize = new Size(1550, 800);
            MinimumSize = new Size(1550, 800);
            Name = "RecipeForm";
            Text = "Рецепти";
            Load += RecipeForm_Load;
            FormClosing += RecipeForm_Close;
            ((System.ComponentModel.ISupportInitialize)RecipeGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SwitchFormBtn;
        private DataGridView RecipeGridView;
        private DataGridView IngredientGridView;
        private ComboBox CompareNameCmb;
        private TextBox CountFilterTb;
        private ComboBox CompareExpireCmb;
        private ComboBox CountCompareCmb;
        private TextBox NameFilterTb;
        private CheckBox ExpireCB;
        private CheckBox CountCB;
        private CheckBox NameCB;
        private Button ApplyFilterBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ExpireDaysFilterTb;
        private TextBox NameTb;
        private TextBox ExpireDaysTb;
        private Label label4;
        private Label label5;
        private Button DownBtn;
        private Button UpBtn;
        private Button DeleteButton;
        private Button ApplyBtn;
        private Button AddBtn;
        private Button IngredientDownBtn;
        private Button IngredientUpBtn;
        private Button IngredientDeleteBtn;
        private Button IngredientApplyBtn;
        private Button IngredientAddBtn;
        private Label label7;
        private TextBox IngredientUnitsTb;
        private TextBox IngredientNameTb;
        private TextBox IngredientCountTb;
        private Label label8;
        private Label label9;
        private CheckBox FixValueCB;
        private CheckBox IngredientFixValueCB;
        private Button ClearSortBtn;
        private Button IngredientCleartSort;
        private Button SaveChangesBtn;
        private TextBox CountReadyFilterTb;
        private ComboBox CountReadyCompareCmb;
        private CheckBox CountReadyCB;
        private Label label6;
        private TextBox MealOftheDayTb;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn CountColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn FreshCountColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ExpireTermColumn;
        private DataGridViewTextBoxColumn IngredientCountColumn;
        private DataGridViewTextBoxColumn IndexColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn RatingColumn;
    }
}