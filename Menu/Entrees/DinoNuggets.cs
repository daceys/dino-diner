using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        private uint extraNuggets = 0;

        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 59 * 6;
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
        }

        public void AddNugget()
        {
            extraNuggets += 1;
            Price = 4.25 + (extraNuggets * 0.25);
            Calories = 59 * 6 + (extraNuggets * 59);
            ingredients.Add("Chicken Nugget");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
