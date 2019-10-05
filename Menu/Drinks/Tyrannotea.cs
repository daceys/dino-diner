/* Tyrannotea.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the tyrannotea drink
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Fields for sweet tea, lemon, and ice
        /// </summary>
        public bool Sweet = false;
        public bool Lemon = false;
        public bool Ice = true;

        /// <summary>
        /// Holds the value for size
        /// </summary>
        private Size size;
        /// <summary>
        /// Determines size and sets the price and calories for each
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        if (Sweet == true) Calories = 16;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (Sweet == true) Calories = 32;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        if (Sweet == true) Calories = 64;
                        break;
                }
            }
            get
            {
                return size;
            }
        } 

        /// <summary>
        /// Constructor for creation of the tyrannotea drink
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }

        /// <summary>
        /// Method to Add Lemon to the drink
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

        /// <summary>
        /// Method to hold ice 
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// Method to make tyrannotea a sweet tea
        /// </summary>
        public void AddSweet()
        {
            Sweet = true;
            ingredients.Add("Cane Sugar");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Sweet) return size + " Sweet Tyrannotea";
            return size + " Tyrannotea";
        }
    }
}
