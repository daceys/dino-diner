/* TRexKingBurger.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the t-rex king burger
    /// </summary>
    public class TRexKingBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        //Backing Variables
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// Constructor for the creation of the burger
        /// </summary>
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

        /// <summary>
        /// Method to hold bun
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
            bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
            lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the tomato
        /// </summary>
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
            tomato = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the onion
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
            onion = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the pickle
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
            pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold ketchup
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
            ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the mustard
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
            mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the mayo
        /// </summary>
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
            mayo = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }

        /// <summary>
        /// Gets the special requirements for the prehistoric pb&j
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets the special requirements for the prehistoric pb&j
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
    }
}
