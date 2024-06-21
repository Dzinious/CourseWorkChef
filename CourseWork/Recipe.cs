using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseWork
{
    [Serializable]
    internal class Recipe
    {
        public HashSet<FoodNotation> Ingredients { get; set; }

        public string Name { get; set; }
        public int ExpireDays { get; set; }
        public int IngredientCount => Ingredients.Count;


        [JsonConstructor]
        public Recipe(string Name, int ExpireDays, HashSet<FoodNotation> Ingredients)
        {
            this.Ingredients = Ingredients;
            this.ExpireDays = ExpireDays;
            this.Name = Name;
        }

        public Recipe(string Name, int ExpireDays, params FoodNotation[] Ingredients) : 
            this(Name, ExpireDays, new HashSet<FoodNotation>(Ingredients))
        {
        }
    }
}
