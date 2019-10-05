/* Sodasaurus.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Sodasaurus drink
    /// </summary
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Field to hold sodasaurus flavors
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Property to get and set the flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Constructor to create a sodasaurus drink
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }
        
        /// <summary>
        /// Holds the value for size
        /// </summary>
        private Size size;
        /// <summary>
        /// Determines size and sets the price and calories for each
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// field to determine presence of ice
        /// </summary>
        public bool Ice = true;
        /// <summary>
        /// Method to hold ice from the drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size + " " + flavor + " Sodasaurus";
        }
    }
}
