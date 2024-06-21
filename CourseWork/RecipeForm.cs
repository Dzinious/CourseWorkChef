using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{
    public partial class RecipeForm : Form
    {
        public RecipeForm(StorageForm sf)
        {
            InitializeComponent();
            storageForm = sf;
        }

        public void RecipeForm_Close(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                AskAboutSaving();
            }
           
        }

        private void AskAboutSaving()
        {
            DialogResult dialogResult = MessageBox.Show("Зберегти зміни перед виходом?", "Попередження", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveChangesBtn_Click(null, null);
            }
        }

        private int GetReadyCount(Recipe rec)
        {
            if (rec.IngredientCount == 0 || foodItems.Count == 0)
                return 0;
            int minCount = int.MaxValue;
            foreach (FoodNotation ing in rec.Ingredients)
            {
                double count = 0;
                foreach (FoodItem fd in foodItems)
                {
                    if (fd.FitsNotation(ing) && fd.Freshness > FreshLevel.Rotten)
                    {
                        count += fd.Count;
                    }

                }

                int rCount = (int)Math.Floor(count / ing.Count);
                if (rCount < minCount)
                {
                    minCount = rCount;
                }
            }

            return minCount;
        }

        private int GetReadyCount(Recipe rec, out int rating)
        {
            rating = 0;
            if (rec.IngredientCount == 0 || foodItems.Count == 0)
                return 0;
            int minCount = int.MaxValue;
            foreach (FoodNotation ing in rec.Ingredients)
            {
                double count = 0;
                foreach (FoodItem fd in foodItems)
                {
                    if (fd.FitsNotation(ing) && fd.Freshness > FreshLevel.Rotten)
                    {
                        count += fd.Count;

                        rating += fd.Freshness switch
                        {
                            FreshLevel.Fresh => 10,
                            FreshLevel.Spoiling => 20,
                            FreshLevel.Spoiled => -10,
                            _ => 0,
                        };
                    }

                }

                int rCount = (int)Math.Floor(count / ing.Count);
                if (rCount < minCount)
                {
                    minCount = rCount;
                }

            }

            rating += minCount * 100;

            return minCount;
        }

        private bool IsFiltered(Recipe recipe)
        {
            return (NameCB.Checked && !NameFilter(recipe)) ||
                (CountCB.Checked && !IngredientCountFilter(recipe)) ||
                (ExpireCB.Checked && !ExpireDaysFilter(recipe)) ||
                (CountReadyCB.Checked && !CountReadyFilter(recipe));
        }

        private StorageForm storageForm;
        private void SwitchFormBtn_Click(object sender, EventArgs e)
        {
            AskAboutSaving();
            this.Hide();
           
            storageForm.Show();
            storageForm.Location = this.Location;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private List<FoodItem> foodItems = new List<FoodItem>();
        private List<Recipe> recipes = new List<Recipe>();
        private int MealOfTheDayN = -1;

        private bool isRefilling = false;
        private void UpdateRecipes(bool updateSort = true)
        {
            RecipeGridView.Rows.Clear();

            isRefilling = true;
            int maxRating = int.MinValue;
            for (int i = 0; i < recipes.Count; i++)
            {

                var recipe = recipes[i];
                int r = 0;

                if (IsFiltered(recipe))
                    continue;

                RecipeGridView.Rows.Add(recipe.Name, recipe.ExpireDays, recipe.IngredientCount,
                    i, GetReadyCount(recipe, out r), r);

                if (r > maxRating)
                {
                    maxRating = r;
                    MealOfTheDayN = i;
                }
            }

            if (MealOfTheDayN != -1)
            {
                MealOftheDayTb.Text = recipes[MealOfTheDayN].Name;
            }

            isRefilling = false;
            if (RecipeGridView.SortedColumn != null && updateSort)
            {
                ListSortDirection direction = RecipeGridView.SortOrder switch
                {
                    SortOrder.Ascending => ListSortDirection.Ascending,
                    SortOrder.Descending => ListSortDirection.Descending,
                    _ => ListSortDirection.Ascending
                };
                RecipeGridView.Sort(RecipeGridView.SortedColumn, direction);
            }
            //UpdateIngredients();
        }

        private void UpdateIngredientCount()
        {
            if (RecipeGridView.CurrentRow == null || currentIngredients == null)
                return;
            RecipeGridView.CurrentRow.Cells[2].Value = currentIngredients.Count;
        }



        HashSet<FoodNotation> currentIngredients;
        public void UpdateIngredients(bool updateSort = true)
        {
            if (currentIngredients == null || RecipeGridView.CurrentRow == null)
                return;

            IngredientGridView.Rows.Clear();


            foreach (FoodNotation ing in currentIngredients)
            {
                List<double> freshCounts = new List<double>() { 0, 0, 0, 0 };
                double count = 0;
                foreach (var fd in foodItems)
                {
                    if (fd.FitsNotation(ing) && fd.Freshness > FreshLevel.Rotten)
                    {
                        count += fd.Count;
                        freshCounts[(int)fd.Freshness - 1] += fd.Count;
                    }

                }

                string nl = Environment.NewLine;
                string countText =
                    $"свіжих: {freshCounts[2]} " + nl +
                    $"напівсвіжих: {freshCounts[1]} " + nl +
                    $"прострочених {freshCounts[0]}";

                IngredientGridView.Rows.Add(ing.Name, ing.Count, count, ing, countText, ing.Units);
            }

            if (IngredientGridView.SortedColumn != null && updateSort)
            {
                ListSortDirection direction = IngredientGridView.SortOrder switch
                {
                    SortOrder.Ascending => ListSortDirection.Ascending,
                    SortOrder.Descending => ListSortDirection.Descending,
                    _ => ListSortDirection.Ascending
                };
                IngredientGridView.Sort(IngredientGridView.SortedColumn, direction);
            }


        }


        private Predicate<Recipe> NameFilter = (r) => true;
        private Predicate<Recipe> IngredientCountFilter = (r) => true;
        private Predicate<Recipe> ExpireDaysFilter = (r) => true;
        private Predicate<Recipe> CountReadyFilter = (r) => true;
        private void ApplyFilterBtn_Click(object sender, EventArgs e)
        {

            //Name filter
            string str = NameFilterTb.Text;
            NameFilter = CompareNameCmb.Text switch
            {
                "Містить" => (recipe) => recipe.Name.Contains(str),
                "Збігається з" => (recipe) => recipe.Name == str,
                "Починається з" => (recipe) => recipe.Name.StartsWith(str),
                "Закінчується на" => (recipe) => recipe.Name.EndsWith(str),
                _ => (recipe) => recipe.Name == str,

            };


            //Count filter
            if (int.TryParse(CountFilterTb.Text, out int count))
            {
                //MessageBox.Show($"Count i {count}");
                IngredientCountFilter = CountCompareCmb.Text switch
                {
                    ">" => (recipe) => recipe.IngredientCount > count,
                    "<" => (recipe) => recipe.IngredientCount < count,
                    "=" => (recipe) => recipe.IngredientCount == count,
                    ">=" => (recipe) => recipe.IngredientCount >= count,
                    "<=" => (recipe) => recipe.IngredientCount <= count,
                    "!=" => (recipe) => recipe.IngredientCount != count,
                    _ => (recipe) => recipe.IngredientCount == count,
                };
            }

            //Expire filter
            if (int.TryParse(ExpireDaysFilterTb.Text, out int days))
            {
                //MessageBox.Show($"Count i {count}");
                ExpireDaysFilter = CompareExpireCmb.Text switch
                {
                    ">" => (recipe) => recipe.ExpireDays > days,
                    "<" => (recipe) => recipe.ExpireDays < days,
                    "=" => (recipe) => recipe.ExpireDays == days,
                    ">=" => (recipe) => recipe.ExpireDays >= days,
                    "<=" => (recipe) => recipe.ExpireDays <= days,
                    "!=" => (recipe) => recipe.ExpireDays != days,
                    _ => (recipe) => recipe.ExpireDays == days,
                };
            }


            //Count ready filter
            if (int.TryParse(CountReadyFilterTb.Text, out int cr))
            {
                //MessageBox.Show($"Count i {count}");
                CountReadyFilter = CountReadyCompareCmb.Text switch
                {
                    ">" => (recipe) => GetReadyCount(recipe) > cr,
                    "<" => (recipe) => GetReadyCount(recipe) < cr,
                    "=" => (recipe) => GetReadyCount(recipe) == cr,
                    ">=" => (recipe) => GetReadyCount(recipe) >= cr,
                    "<=" => (recipe) => GetReadyCount(recipe) >= cr,
                    "!=" => (recipe) => GetReadyCount(recipe) != cr,
                    _ => (recipe) => GetReadyCount(recipe) == cr,
                };
            }

            int toSelect = -1;
            if (RecipeGridView.CurrentRow != null)
                toSelect = (int)RecipeGridView.CurrentRow.Cells[3].Value;
            UpdateRecipes();
            SelectRowById(RecipeGridView, toSelect);

            if (RecipeGridView.CurrentRow == null)
                SelectRowByNumber(RecipeGridView, 0);
            UpdateIngredients();
        }


        private int LastSelectedIdx = -1;
        private void RecipeGridView_CurrentCellChanged(Object sender, EventArgs e)
        {

            if (RecipeGridView.CurrentCell == null)
            {
                return;
            }

            RecipeGridView.CurrentRow.Selected = true;

            if (!FixValueCB.Checked)
            {
                NameTb.Text = RecipeGridView.CurrentRow.Cells[0].Value.ToString();
                ExpireDaysTb.Text = RecipeGridView.CurrentRow.Cells[1].Value.ToString();
            }

            int id = (int)RecipeGridView.CurrentRow.Cells[3].Value;

            currentIngredients = recipes[id].Ingredients;
            UpdateIngredients();

        }

        private void IngredientGridView_CurrentCellChanged(Object sender, EventArgs e)
        {
            if (IngredientGridView.CurrentCell == null)
            {
                return;
            }

            IngredientGridView.CurrentRow.Selected = true;

            if (!IngredientFixValueCB.Checked)
            {
                IngredientNameTb.Text = IngredientGridView.CurrentRow.Cells[0].Value.ToString();
                IngredientCountTb.Text = IngredientGridView.CurrentRow.Cells[1].Value.ToString();
                if (IngredientGridView.CurrentRow.Cells[5].Value != null)
                    IngredientUnitsTb.Text = IngredientGridView.CurrentRow.Cells[5].Value.ToString();

            }

        }

        private void MoveSelectionUp(DataGridView grid)
        {
            if (grid.CurrentCell == null)
                return;

            int idx = grid.Rows.IndexOf(grid.CurrentRow);

            idx--;
            if (idx < 0)
                idx = grid.Rows.Count - 1;

            grid.CurrentCell = grid.Rows[idx].Cells[0];
        }

        private void MoveSelectionDown(DataGridView grid)
        {
            if (grid.CurrentCell == null)
                return;

            int idx = grid.Rows.IndexOf(grid.CurrentRow);

            idx++;
            if (idx >= grid.Rows.Count)
                idx = 0;

            grid.CurrentCell = grid.Rows[idx].Cells[0];
        }
        private void UpBtn_Click(object sender, EventArgs e)
        {
            MoveSelectionUp(RecipeGridView);
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            MoveSelectionDown(RecipeGridView);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = NameTb.Text;

            if (name.Trim().Length == 0)
            {
                MessageBox.Show("Некоректна назва");
                return;
            }

            if (!int.TryParse(ExpireDaysTb.Text, out int c) || c < 1)
            {
                MessageBox.Show("Некоректна кількість днів");
                return;
            }

            Recipe rec = new Recipe(name, c);


            recipes.Add(rec);
            int id = recipes.IndexOf(rec);

            UpdateRecipes();
            SelectRowById(RecipeGridView, id);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (RecipeGridView.CurrentCell == null)
            {
                MessageBox.Show("Жодної строки не обрано!");
                return;
            }

            int id = (int)RecipeGridView.CurrentRow.Cells[3].Value;

            if (id < 0 || id >= recipes.Count || recipes.Count == 0)
            {
                MessageBox.Show("Некоректний вибір строки");
                return;
            }

            int newSelN = RecipeGridView.Rows.IndexOf(RecipeGridView.CurrentRow) - 1;
            if (newSelN < 0)
            {
                newSelN = 0;
            }

            recipes.RemoveAt(id);
            UpdateRecipes();
            SelectRowByNumber(RecipeGridView, newSelN);
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (RecipeGridView.CurrentCell == null)
            {
                MessageBox.Show("Жодної строки не обрано!");
                return;
            }

            int id = (int)RecipeGridView.CurrentRow.Cells[3].Value;
            Recipe r = recipes[id];

            string name = NameTb.Text;

            if (name.Trim().Length == 0)
            {
                MessageBox.Show("Некоректна назва");
                return;
            }

            if (!int.TryParse(ExpireDaysTb.Text, out int c) || c < 1)
            {
                MessageBox.Show("Некоректна кількість днів");
                return;
            }

            r.Name = name;
            r.ExpireDays = c;
            UpdateRecipes();
            SelectRowById(RecipeGridView, id);
        }


        private void SelectRowByNumber(DataGridView grid, int rowIdx)
        {
            grid.ClearSelection();

            if (rowIdx >= 0 && rowIdx < grid.Rows.Count)
            {
                grid.CurrentCell = grid.Rows[rowIdx].Cells[0];
                grid.Rows[rowIdx].Selected = true;
            }
            else if (grid.Rows.Count > 0)
            {
                grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[0];
                grid.Rows[grid.Rows.Count - 1].Selected = true;
            }

        }

        private void SelectRowById(DataGridView grid, int id)
        {
            grid.ClearSelection();
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                if ((int)grid.Rows[i].Cells[3].Value == id)
                {
                    grid.ClearSelection();
                    grid.CurrentCell = grid.Rows[i].Cells[0];
                    grid.Rows[i].Selected = true;
                }
            }

        }

        private void SelectRowById(DataGridView grid, Object id)
        {
            grid.ClearSelection();
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                if (grid.Rows[i].Cells[3].Value.Equals(id))
                {
                    grid.ClearSelection();
                    grid.CurrentCell = grid.Rows[i].Cells[0];
                    grid.Rows[i].Selected = true;
                }
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void IngredientUpBtn_Click(object sender, EventArgs e)
        {
            MoveSelectionUp(IngredientGridView);
        }

        private void IngredientDownBtn_Click(object sender, EventArgs e)
        {
            MoveSelectionDown(IngredientGridView);
        }

        private FoodNotation? GetIngredient()
        {
            string name = IngredientNameTb.Text;
            if (name.Trim().Length == 0)
            {
                MessageBox.Show("Некоректна назва");
                return null;
            }

            if (!double.TryParse(IngredientCountTb.Text, out double c) || c <= 0)
            {
                MessageBox.Show("Некоректна кількість");
                return null;
            }

            string units = IngredientUnitsTb.Text;
            if (units.Trim().Length == 0)
            {
                MessageBox.Show("Некоректні одиниці вимірювання");
                return null;
            }

            return new FoodNotation(name, c, units);
        }
        private void IngredientAddBtn_Click(object sender, EventArgs e)
        {
            if (currentIngredients == null)
                return;


            FoodNotation? ingredient = GetIngredient();

            if (ingredient == null)
                return;

            currentIngredients.Add(ingredient.Value);


            //UpdateIngredientCount();
            int toSelect = (int)RecipeGridView.CurrentRow.Cells[3].Value;
            UpdateRecipes();
            SelectRowById(RecipeGridView, toSelect);
            UpdateIngredients();
            SelectRowById(IngredientGridView, ingredient.Value);
        }

        private void IngredientDeleteBtn_Click(object sender, EventArgs e)
        {
            if (IngredientGridView.CurrentCell == null)
            {
                MessageBox.Show("Жодної строки не обрано!");
                return;
            }

            FoodNotation ing = (FoodNotation)IngredientGridView.CurrentRow.Cells[3].Value;

            if (!currentIngredients.Contains(ing) || currentIngredients.Count == 0)
            {
                MessageBox.Show("Некоректний вибір строки");
                return;
            }

            int newSelN = IngredientGridView.Rows.IndexOf(IngredientGridView.CurrentRow) - 1;
            if (newSelN < 0)
            {
                newSelN = 0;
            }

            currentIngredients.Remove(ing);

            //UpdateIngredientCount();
            int toSelect = (int)RecipeGridView.CurrentRow.Cells[3].Value;
            UpdateRecipes();
            SelectRowById(RecipeGridView, toSelect);
            UpdateIngredients();
            SelectRowByNumber(IngredientGridView, newSelN);
        }

        private void IngredientApplyBtn_Click(object sender, EventArgs e)
        {
            if (IngredientGridView.CurrentCell == null)
            {
                MessageBox.Show("Жодної строки не обрано!");
                return;
            }

            FoodNotation? tempIng = GetIngredient();
            if (tempIng == null)
            {
                return;
            }

            var ing = tempIng.Value;

            var id = IngredientGridView.CurrentRow.Cells[3].Value;
            currentIngredients.Remove((FoodNotation)id);
            currentIngredients.Add(ing);


            //UpdateIngredientCount();
            int toSelect = (int)RecipeGridView.CurrentRow.Cells[3].Value;
            UpdateRecipes();
            SelectRowById(RecipeGridView, toSelect);
            UpdateIngredients();
            SelectRowById(IngredientGridView, ing);
        }

        private void IngredintUnitsTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClearSortBtn_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (RecipeGridView.SelectedRows.Count > 1 && RecipeGridView.SelectedRows[0] != null)
                id = (int)RecipeGridView.SelectedRows[0].Cells[3].Value;

            if (RecipeGridView.SortedColumn != null)
            {
                var column = RecipeGridView.SortedColumn;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.SortMode = DataGridViewColumnSortMode.Automatic;

            }


            UpdateRecipes(false);
        }

        private void IngredientCleartSort_Click(object sender, EventArgs e)
        {
            Object id = null;

            if (IngredientGridView.SelectedRows.Count > 1 && IngredientGridView.SelectedRows[0] != null)
                id = RecipeGridView.SelectedRows[0].Cells[3].Value;

            if (IngredientGridView.SortedColumn != null)
            {
                var column = IngredientGridView.SortedColumn;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.SortMode = DataGridViewColumnSortMode.Automatic;

            }


            UpdateIngredients(false);
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName = "Recipes.json";

                string jsonString = File.ReadAllText(fileName);
                recipes = JsonSerializer.Deserialize<List<Recipe>>(jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося завантажити список рецептів");
                recipes = new List<Recipe> { };
            }

            try
            {
                string fileName = "Products.json";
                string jsonString = File.ReadAllText(fileName);
                foodItems = JsonSerializer.Deserialize<List<FoodItem>>(jsonString);
            }
            catch
            {
                MessageBox.Show("Не вдалося завантажити список продуктів");
                foodItems = new List<FoodItem> { };
            }

            CompareExpireCmb.SelectedIndex = 0;
            CompareNameCmb.SelectedIndex = 0;
            CountCompareCmb.SelectedIndex = 0;
            CountReadyCompareCmb.SelectedIndex = 0;

            UpdateRecipes();
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            string fileName = "Recipes.json";

            try
            {
                string jsonString = JsonSerializer.Serialize(recipes);
                File.WriteAllText(fileName, jsonString);
                MessageBox.Show("Дані успішно оновлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникли проблеми зі збереженням до файлу: " + ex.Message);
            }
        }

        private void IngredientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MealOftheDayTb_Click(object sender, EventArgs e)
        {
            SelectRowById(RecipeGridView, MealOfTheDayN);
        }
    }
}
