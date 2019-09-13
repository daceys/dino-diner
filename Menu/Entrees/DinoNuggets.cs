using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint extraNuggets = 0;
        //private uint nuggets = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                for (uint i = extraNuggets; i > 0; i--) ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            //for(uint i = extraNuggets; i > 0; i--) 
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        public void AddNugget()
        {
            extraNuggets += 1;
            this.Price = 4.25 + (extraNuggets * 0.25);
            this.Calories = 59 * 6 + (extraNuggets * 59);
        }
    }
}
