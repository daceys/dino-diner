/* IMenuItems.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for the menu items
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Get for the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Get for the calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Get a list of the ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}
