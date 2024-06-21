using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Text.Json;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;


namespace CourseWork
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
            recipeForm = new RecipeForm(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                string fileName = "Products.json";

                string jsonString = File.ReadAllText(fileName);
                foodItems = JsonSerializer.Deserialize<List<FoodItem>>(jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося завантажити список продуктів!");
                foodItems = new List<FoodItem> { };
            }


            if (foodItems is null)
                foodItems = new List<FoodItem>();


            UpdateGrid();
            CompareNameCmb.SelectedIndex = 0;
            CountCompareCmb.SelectedIndex = 0;
            CompareExpireCmb.SelectedIndex = 0;
            StatusCmb.SelectedIndex = 0;
            CompareStatusCmb.SelectedIndex = 0;
            CostCompareCmb.SelectedIndex = 0;
            TotalCostCompareCmb.SelectedIndex = 0;
        }

        private void AskAboutSaving()
        {
            DialogResult dialogResult = MessageBox.Show("Зберегти зміни перед виходом?", "Попередження", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveChangesBtn_Click(null, null);
            }
        }
        private void Form1_Close(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                AskAboutSaving();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        FoodItem? GetFoodItem()
        {
            string name = NameTb.Text;

            if (!double.TryParse(CountTB.Text, out double c) || c < 0)
            {
                MessageBox.Show("некоректна кількість!");
                return null;
            }

            string units = UnitsTb.Text;
            if (units.Length > 10)
            {
                MessageBox.Show("Занадто довга назва одиниці!");
                return null;
            }

            DateOnly expireDate = DateOnly.FromDateTime(ExpireDateTime.Value);
            if (!double.TryParse(CostTb.Text, out double cost) || c < 0)
            {
                MessageBox.Show("некоректна ціна!");
                return null;
            }


            return new FoodItem(name, c, expireDate, units, cost);
        }

        List<FoodItem> foodItems = new List<FoodItem>();


        private bool IsFiltered(FoodItem item)
        {
            return NameCB.Checked && !NameFilter(item) ||
            (CountCB.Checked && !CountFilter(item)) ||
            (UnitCB.Checked && !UnitsFilter(item)) ||
            (ExpireCB.Checked && !ExpireFilter(item)) ||
            (StatusCB.Checked && !StatusFilter(item)) ||
            (CostCB.Checked && !CostFilter(item)) ||
            (TotalCostCB.Checked && !TotalCostFilter(item));
            
        }
        private void UpdateGrid(int idx = 0, bool updateSort = true)
        {
            FoodGridView.Rows.Clear();

            for (int i = 0; i < foodItems.Count; i++)
            {

                FoodItem item = foodItems[i];

                //Filters
                if(IsFiltered(item))
                        continue;

                string status = item.Freshness switch
                {
                    FreshLevel.Fresh => "Свіжий",
                    FreshLevel.Spoiling => "Напівсвіжий",
                    FreshLevel.Spoiled => "Прострочений",
                    FreshLevel.Rotten => "Гнилий",
                    _ => "Невідомо"

                };
                FoodGridView.Rows.Add(item.Name, item.Count, item.Units, item.ExpireDate,
                    status, i, item.Cost + " грн", item.TotalCost + " грн");
            }


            /* if (rowIdx >= 0 && rowIdx < FoodGridView.Rows.Count)
             {
                 FoodGridView.Rows[rowIdx].Selected = true;
             }
             else if (FoodGridView.Rows.Count > 0)
             {
                 FoodGridView.Rows[FoodGridView.Rows.Count - 1].Selected = true;
             }*/

            if (FoodGridView.SortedColumn != null && updateSort)
            {
                ListSortDirection direction = FoodGridView.SortOrder switch
                {
                    SortOrder.Ascending => ListSortDirection.Ascending,
                    SortOrder.Descending => ListSortDirection.Descending,
                    _ => ListSortDirection.Ascending
                };
                FoodGridView.Sort(FoodGridView.SortedColumn, direction);
            }
        }

        private void SelectRowByNumber(int rowIdx)
        {
            FoodGridView.ClearSelection();

            if (rowIdx >= 0 && rowIdx < FoodGridView.Rows.Count)
            {
                FoodGridView.Rows[rowIdx].Selected = true;
            }
            else if (FoodGridView.Rows.Count > 0)
            {
                FoodGridView.Rows[FoodGridView.Rows.Count - 1].Selected = true;
            }

        }

        private void SelectRowById(int id)
        {
            for (int i = 0; i < FoodGridView.Rows.Count; i++)
            {
                if ((int)FoodGridView.Rows[i].Cells[5].Value == id)
                {
                    FoodGridView.ClearSelection();
                    FoodGridView.Rows[i].Selected = true;
                }
            }

        }


        private void FoodGridView_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = FoodGridView.Rows[e.RowIndex];
            var date = row.Cells[3].Value;

            if (date == null)
                return;

            DateOnly expireDate = (DateOnly)date;
            int daysToExpire = expireDate.DayNumber - DateOnly.FromDateTime(DateTime.Now).DayNumber;

            if (Convert.ToDouble(row.Cells[1].Value) > 0d)
            {
                row.DefaultCellStyle.BackColor = daysToExpire switch
                {
                    > 7 => Color.LightGreen,
                    > 0 => Color.Yellow,
                    > -7 => Color.Orange,
                    _ => Color.IndianRed

                };
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 100, 100, 100);
            }


        }
        private void FoodGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FoodGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FoodGridView.SelectedRows == null || FoodGridView.SelectedRows.Count == 0)
            {
                FoodGridView.ClearSelection();

                if (FoodGridView.CurrentRow != null)
                    FoodGridView.CurrentRow.Selected = true;

                return;
            }

            var row = FoodGridView.SelectedRows[0];
            FoodGridView.CurrentCell = row.Cells[0];

            for (int i = 0; i < 4; i++)
            {
                if (row.Cells[i].Value == null)
                {
                    return;
                }

            }
            if (!FixValueCB.Checked)
            {
                NameTb.Text = row.Cells[0].Value.ToString();
                CountTB.Text = row.Cells[1].Value.ToString();
                UnitsTb.Text = row.Cells[2].Value.ToString();
                CostTb.Text = double.Parse(row.Cells[6].Value.ToString().Split()[0]).ToString();
                ExpireDateTime.Value = ((DateOnly)row.Cells[3].Value).ToDateTime(TimeOnly.Parse("10:00 PM"));
            }


        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (FoodGridView.SelectedRows == null || FoodGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Жодної строки не обрано!");
                return;
            }
            var row = FoodGridView.SelectedRows[0];

            int idx = (int)row.Cells[5].Value;

            if (idx < 0 || idx >= foodItems.Count)
            {
                MessageBox.Show("Некоректний вибір строки!");
                return;
            }

            FoodItem? item = GetFoodItem();
            if (item == null)
            {
                return;
            }

            foodItems[idx] = item;
            UpdateGrid();
            SelectRowById(idx);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FoodItem fi = GetFoodItem();
            if (fi == null)
                return;

            if (fi.Name.Trim() == "")
            {
                MessageBox.Show("Некоректна назва продукту!");
                return;
            }

            foodItems.Add(fi);
            UpdateGrid();
            SelectRowById(foodItems.IndexOf(fi));

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FoodGridView.SelectedRows == null || FoodGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Жодної строки не обрано");
                return;
            }
            var row = FoodGridView.SelectedRows[0];

            int idx = (int)row.Cells[5].Value;


            if (idx < 0 || idx >= foodItems.Count || foodItems.Count == 0)
            {
                MessageBox.Show("Некоректний вибір строки");
                return;
            }

            int newSelN = FoodGridView.Rows.IndexOf(row) - 1;
            if (newSelN < 0)
            {
                newSelN = 0;
            }

            foodItems.RemoveAt(idx);
            UpdateGrid();

            SelectRowByNumber(newSelN);
        }


        private RecipeForm recipeForm;
        private void SwitchFormBtn_Click(object sender, EventArgs e)
        {
            AskAboutSaving();
            this.Hide();
            recipeForm.Show();
            recipeForm.Location = this.Location;
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            int count = FoodGridView.Rows.Count;
            if (FoodGridView.SelectedRows == null || FoodGridView.SelectedRows.Count == 0)
            {
                if (count > 0)
                {
                    FoodGridView.Rows[0].Selected = true;
                }

                return;
            }

            int idx = FoodGridView.Rows.IndexOf((FoodGridView.SelectedRows[0]));
            FoodGridView.ClearSelection();

            int newIdx = idx - 1 >= 0 ? idx - 1 : count - 1;
            FoodGridView.Rows[newIdx].Selected = true;
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            int count = FoodGridView.Rows.Count;
            if (FoodGridView.SelectedRows == null || FoodGridView.SelectedRows.Count == 0)
            {
                if (count > 0)
                {
                    FoodGridView.Rows[count - 1].Selected = true;
                }
                return;
            }

            int idx = FoodGridView.Rows.IndexOf((FoodGridView.SelectedRows[0]));
            FoodGridView.ClearSelection();

            int newIdx = idx + 1 < count ? idx + 1 : 0;
            FoodGridView.Rows[newIdx].Selected = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Predicate<FoodItem> NameFilter = (item) => true;
        private Predicate<FoodItem> CountFilter = (item) => true;
        private Predicate<FoodItem> UnitsFilter = (item) => true;
        private Predicate<FoodItem> ExpireFilter = (item) => true;
        private Predicate<FoodItem> StatusFilter = (item) => true;
        private Predicate<FoodItem> CostFilter = (item) => true;
        private Predicate<FoodItem> TotalCostFilter = (item) => true;


        private void ApplyFilterBtn_Click(object sender, EventArgs e)
        {
            //Name filter
            string str = NameFilterTb.Text;
            NameFilter = CompareNameCmb.Text switch
            {
                "Містить" => (item) => item.Name.Contains(str),
                "Збігається з" => (item) => item.Name == str,
                "Починається з" => (item) => item.Name.StartsWith(str),
                "Закінчується на" => (item) => item.Name.EndsWith(str),
                _ => (item) => item.Name == str,

            };


            //Count filter
            if (int.TryParse(CountFilterTb.Text, out int count))
            {
                //MessageBox.Show($"Count i {count}");
                CountFilter = CountCompareCmb.Text switch
                {
                    ">" => (item) => item.Count > count,
                    "<" => (item) => item.Count < count,
                    "=" => (item) => item.Count == count,
                    ">=" => (item) => item.Count >= count,
                    "<=" => (item) => item.Count <= count,
                    "!=" => (item) => item.Count != count,
                    _ => (item) => item.Count == count
                };
            }

            //Units filter
            string units = UnitFilterTb.Text;
            UnitsFilter = (item) => item.Units == units;

            //Expire filter
            DateOnly expireDate = DateOnly.FromDateTime(FilterTimePicker.Value);

            ExpireFilter = CompareExpireCmb.Text switch
            {
                ">" => (item) => item.ExpireDate > expireDate,
                "<" => (item) => item.ExpireDate < expireDate,
                "=" => (item) => item.ExpireDate == expireDate,
                ">=" => (item) => item.ExpireDate >= expireDate,
                "<=" => (item) => item.ExpireDate <= expireDate,
                "!=" => (item) => item.ExpireDate != expireDate,
                _ => (item) => item.ExpireDate == expireDate
            };

            //Status filter
            FreshLevel lvl = StatusCmb.Text switch
            {
                "Свіжий" => FreshLevel.Fresh,
                "Напівсвіжий" => FreshLevel.Spoiling,
                "Прострочений" => FreshLevel.Spoiled,
                "Гнилий" => FreshLevel.Rotten,
                _ => FreshLevel.Fresh,
            };

            StatusFilter = CompareStatusCmb.Text switch
            {
                ">" => (item) => item.Freshness > lvl,
                "<" => (item) => item.Freshness < lvl,
                "=" => (item) => item.Freshness == lvl,
                ">=" => (item) => item.Freshness >= lvl,
                "<=" => (item) => item.Freshness <= lvl,
                "!=" => (item) => item.Freshness != lvl,
                _ => (item) => item.Freshness == lvl
            };

            //Cost filter
            if (double.TryParse(CostFilterTb.Text, out double cost))
            {
                CostFilter = CostCompareCmb.Text switch
                {
                    ">" => (item) => item.Cost > cost,
                    "<" => (item) => item.Cost < cost,
                    "=" => (item) => item.Cost == cost,
                    ">=" => (item) => item.Cost >= cost,
                    "<=" => (item) => item.Cost <= cost,
                    "!=" => (item) => item.Cost != cost,
                    _ => (item) => item.Cost == cost
                };

            }

            //Cost filter
            if (double.TryParse(TotalCostFilterTb.Text, out double tCost))
            {
                TotalCostFilter = TotalCostCompareCmb.Text switch
                {
                    ">" => (item) => item.TotalCost > tCost,
                    "<" => (item) => item.TotalCost < tCost,
                    "=" => (item) => item.TotalCost == tCost,
                    ">=" => (item) => item.TotalCost >= tCost,
                    "<=" => (item) => item.TotalCost <= tCost,
                    "!=" => (item) => item.TotalCost != tCost,
                    _ => (item) => item.Cost == tCost
                };

            }





            UpdateGrid();

        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            string fileName = "Products.json";

            try
            {
                string jsonString = JsonSerializer.Serialize(foodItems);
                File.WriteAllText(fileName, jsonString);
                MessageBox.Show("Дані успішно оновлено!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Виникли проблеми зі збереженням до файлу");
            }
           
        }

        private void GetCalendarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileNameTb.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Будь ласка, введіть назву файлу");
                    return;
                }
                ExcelSheet sheet = new ExcelSheet(FileNameTb.Text);
                sheet.SetBorder("A3:G8", Color.Black);


                int month = CalendarTimePicker.Value.Month;
                string monthStr = month switch
                {
                    1 => "Січень",
                    2 => "Лютий",
                    3 => "Березень",
                    4 => "Квітень",
                    5 => "Травень",
                    6 => "Червень",
                    7 => "Липень",
                    8 => "Серпень",
                    9 => "Вересень",
                    10 => "Жовтень",
                    11 => "Листопад",
                    12 => "Грудень",
                    _ => "???"
                };
                sheet.WriteToCell(0, 3, monthStr + " " + CalendarTimePicker.Value.Year);

                List<string> Days = new() { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" };
                for (int i = 0; i < 7; i++)
                    sheet.WriteToCell(2, i, Days[i]);

                sheet.Show();
                int rowN = 3;
                var startDate = new DateOnly(CalendarTimePicker.Value.Year, month, 1);
                var date = startDate;

                List<string> expires = Enumerable.Repeat("", 32).ToList();


                foreach (FoodItem fd in foodItems)
                {
                    if (fd.ExpireDate.Month == CalendarTimePicker.Value.Month)
                    {
                        int dayN = fd.ExpireDate.Day;
                        expires[dayN] += fd.Repr + "\n";
                    }

                }

                int n = 0;
                while (date.Month == month)
                {
                    if (date.Day != 1 && date.DayOfWeek == DayOfWeek.Monday)
                    {
                        rowN++;
                    }
                    int colN = (int)date.DayOfWeek - 1;
                    if (colN == -1) colN = 6;

                    string newContent = date.Day.ToString() + "\n" + expires[date.Day];
                    if (expires[date.Day] != "")
                    {
                        sheet.PaintCell(rowN, colN, Color.LightCoral);
                    }
                    else
                    {
                        sheet.PaintCell(rowN, colN, Color.LightGray);
                    }

                    sheet.WriteToCell(rowN, colN, newContent);

                    n++;
                    date = startDate.AddDays(n);
                }

                sheet.Save();
                sheet.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Неможливо виконати операцію з файлом: " + ex.Message);
            }



        }

        private void GetWaybilBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (FileNameTb.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Будь ласка, введіть назву файлу");
                    return;
                }
                ExcelSheet sheet = new ExcelSheet(FileNameTb.Text);
                sheet.SetBorder($"A8:F{foodItems.Count + 8}", Color.Black);

                List<string> headers = new List<string>() { "№", "Товар", "Кількість", "Одиниці", "Ціна за од.", "Загальна ціна"};

                sheet.WriteToCell(0, 1, "Видаткова накладна від " + DateOnly.FromDateTime(CalendarTimePicker.Value.Date));

                sheet.WriteToCell(3, 1, "Постачальник: ");
                sheet.WriteToCell(4, 1, "Покупець: ");
                sheet.WriteToCell(5, 1, "Договір: ");
                for (int i = 0; i < headers.Count; i++)
                {
                    sheet.WriteToCell(7, i, headers[i]);
                    sheet.PaintCell(7, i, Color.Gold);

                }
                sheet.SetColumnWidth(1, 8);
                sheet.SetColumnWidth(2, 40);
                sheet.MergeRange("A1:F1");

                double sum = 0;
                int n = 0;
                for (n = 0; n < foodItems.Count; n++)
                {
                    sheet.WriteToCell(n + 8, 0, (n + 1).ToString());
                    sheet.WriteToCell(n + 8, 1, foodItems[n].Name);
                    sheet.WriteToCell(n + 8, 2, foodItems[n].Count.ToString());
                    sheet.WriteToCell(n + 8, 3, foodItems[n].Units);
                    sheet.WriteToCell(n + 8, 4, foodItems[n].Cost + " грн");
                    sheet.WriteToCell(n + 8, 5, foodItems[n].TotalCost + " грн");
                    sum += foodItems[n].TotalCost;
                }
                sheet.WriteToCell(n + 9, 1, $"Всього найменувань: {n}");
                sheet.WriteToCell(n + 9, 5, $"Всього: {sum} грн");

                double tax = Math.Round(sum * 0.2, 5); 
                sheet.WriteToCell(n + 10, 5, $"ПДВ: {tax, 3} грн");
                sheet.WriteToCell(n + 11, 5, $"Всього з ПДВ: {sum + tax} грн");


                sheet.Show();

                sheet.Save();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неможливо виконати операцію з файлом: " + ex.Message);
            }
        }

        private void ClearSortBtn_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (FoodGridView.SelectedRows.Count > 0 && FoodGridView.SelectedRows[0] != null)
                id = (int)FoodGridView.SelectedRows[0].Cells[5].Value;

            if (FoodGridView.SortedColumn != null)
            {
                var column = FoodGridView.SortedColumn;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.SortMode = DataGridViewColumnSortMode.Automatic;

            }
                
            UpdateGrid(0, false);
            SelectRowById(id);
        }

        
    }
}
