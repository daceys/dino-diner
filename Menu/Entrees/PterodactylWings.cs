/*PterodactylWings.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the pterodactyl wings entree
    /// </summary>
    public class PterodactylWings : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for creation of the wings
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
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
                return special.ToArray();
            }
        }
    }
}
