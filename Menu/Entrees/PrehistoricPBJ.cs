/*PrehistoricPBJ.cs
 * Modified by: Dacey Simpson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the pb and j entree
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
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
            ingredients.Remove("Peanut Butter");
        }

        /// <summary>
        /// Method to hold the jelly
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
