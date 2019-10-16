/* IOrderItem.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for the Dino-Diner Order Items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Property for the price
        /// </summary>
        double Price { get; set; }

        /// <summary>
        /// Property for the Description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Property for the Special
        /// </summary>
        string[] Special { get; }
    }
}
