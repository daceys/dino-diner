using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Lettuce");
            ingredients.Add("Tomato");
            ingredients.Add("Onion");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Mayo");
        }

        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
        }

        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
        }

        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }

        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }

        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }

        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }

        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
