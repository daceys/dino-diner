/* Brontowurst.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the brontowurst entree
    /// </summary>
    public class Brontowurst : Entree, IOrderItem, INotifyPropertyChanged
    {
        //Backing variables
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

        /// <summary>
        /// Constructor for creation of the brontowurst
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
            ingredients.Add("Onion");
        }

        /// <summary>
        /// Method to hold the bun 
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold peppers fromt the brontowurst
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
            ingredients.Remove("Peppers");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the onion
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// Gets a description of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets the special requirements for the brontowurst entree
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onion) special.Add("Hold Onion");
                return special.ToArray();
            }
        }
    }
}
