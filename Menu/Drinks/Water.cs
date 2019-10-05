/* Water.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Fields for the presence of lemon and ice
        /// </summary>
        public bool Lemon = false;
        public bool Ice = true;

        /// <summary>
        /// Constructor for creation of water
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water");
        }

        /// <summary>
        /// Method to add lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

        /// <summary>
        /// Method to remove ice from the water
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
            return Size + " Water";
        }
    }
}
