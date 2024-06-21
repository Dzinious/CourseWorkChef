using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseWork
{
    public enum FreshLevel
    {
        Fresh = 3,
        Spoiling = 2,
        Spoiled = 1,
        Rotten = 0
    }

    internal struct FoodNotation : IEquatable<FoodNotation>
    {
        public string Name { get; set; }

        private double count;
        public double Count
        {
            get => count;
            set
            {
                if (value < 0)
                {
                    count = 0;
                }
                else
                {
                    count = value;
                }
            }
        }

        public string Units { get; set; } = "шт";

        [JsonConstructor]
        public FoodNotation(string Name, double Count, string Units = "шт")
        {
            this.Name = Name;
            this.Count = Count;
            this.Units = Units;
        }

        public string Repr => $"{Name} {Count} {Units}";

        public bool Equals(FoodNotation other) 
        { 
            return Name == other.Name && Units == other.Units;
        }

    }

    [Serializable]
    internal class FoodItem
    {
        public string Name { get; set; }

        private double count;
        public double Count
        {
            get => count;
            set
            {
                if (value < 0)
                {
                    count = 0;
                }
                else
                {
                    count = value;
                }
            }
        }

        public bool AnyLeft => Count != 0;
        public DateOnly ExpireDate { get; set; }

        public int DaysToExpire => ExpireDate.DayNumber - DateOnly.FromDateTime(DateTime.Now).DayNumber;


        public FreshLevel Freshness
        {
            get
            {
                return DaysToExpire switch
                {
                    > 7 => FreshLevel.Fresh,
                    > 0 => FreshLevel.Spoiling,
                    > -7 => FreshLevel.Spoiled,
                    _ => FreshLevel.Rotten
                };

            }
        }

        public string Units { get; set; } = "шт";

        public double Cost { get; set; }
        public double TotalCost => Cost * Count;

        public string Repr => $"{Name} {Count} {Units}";

        public FoodItem(string Name, double Count, DateOnly ExpireDate, string Units = "шт", double Cost = 0)
        {
            this.Name = Name;
            this.Count = Count;
            this.ExpireDate = ExpireDate;
            this.Units = Units;
            this.Cost = Cost;
        }

        public bool FitsNotation(FoodNotation notation)
        {
            return (this.Name == notation.Name &&
                this.Units == notation.Units);
        }
        public bool Contains(FoodNotation notation) 
        {
            return (FitsNotation(notation) && 
                this.Count >= notation.Count);
        }

        public void Add(int c)
        {
            if (c >= 0)
                count += c;
        }
        public void Substract(int c)
        {

            if (c >= 0)
                count -= c;
        }

    }

}
