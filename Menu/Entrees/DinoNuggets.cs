/* DinoNuggets.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the dino nugget entree
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Field to keep track of added extra nuggets
        /// </summary>
        private uint extraNuggets = 0;

        /// <summary>
        /// Constructor for new creation of dino nuggets
        /// </summary>
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

        /// <summary>
        /// Method to Add a nugget
        /// </summary>
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
