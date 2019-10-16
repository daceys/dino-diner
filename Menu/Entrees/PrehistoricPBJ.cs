/*PrehistoricPBJ.cs
 * Modified by: Dacey Simpson
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the pb and j entree
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged, IOrderItem
    {
        // Backing variables
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Constructor for creation of the pb and j
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
        }

        /// <summary>
        /// Method to hold the peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
            ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to hold the jelly
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
            ingredients.Remove("Jelly");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Gets a description of the order item
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
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
