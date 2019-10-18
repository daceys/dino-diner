/* VelociWrap.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the veloci wrap entree
    /// </summary>
    public class VelociWrap : Entree, IOrderItem, INotifyPropertyChanged
    {
        // Backing Variables 
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

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
            dressing = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Romain Lettuce");
            lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the cheese
        /// </summary>
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
            cheese = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
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
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
    }
}

