namespace OOP.Encapsulation.PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Dough
    {
        private const double BaseCalsPerGram = 2;
        private Dictionary<string, double> availableFlourTypes = new Dictionary<string, double>()
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 }
        };

        private Dictionary<string, double> availableBakingTechniques = new Dictionary<string, double>()
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
        };

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Dought flour type cannot be empty.");
                }
                else if (this.availableFlourTypes.ContainsKey(value.ToLower()))
                {
                    this.flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public string BakingTechnique 
        {
            get => this.bakingTechnique; 
            private set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Dought baking technique cannot be empty.");
                }
                else if (this.availableBakingTechniques.ContainsKey(value.ToLower()))
                {
                    this.bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            return BaseCalsPerGram 
                * this.Weight 
                * this.availableFlourTypes[this.FlourType.ToLower()] 
                * this.availableBakingTechniques[this.BakingTechnique.ToLower()];
        }
    }
}