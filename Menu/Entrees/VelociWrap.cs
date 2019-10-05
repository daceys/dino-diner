/* VelociWrap.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the veloci wrap entree
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Constructor for the creation of the wrap
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// Method to hold the dressing
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
        }

        /// <summary>
        /// Method to hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Romain Lettuce");
        }

        /// <summary>
        /// Method to hold the cheese
        /// </summary>
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}

