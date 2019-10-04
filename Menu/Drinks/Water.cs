using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        public bool Lemon = false;
        public bool Ice = true;

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water");
        }

        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

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
