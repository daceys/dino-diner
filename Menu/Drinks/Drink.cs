/* Drink.cs 
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for drinks
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Creates a list to hold ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Creates a size property to get and set the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Property to get and set price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Property to get and set the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Creation of a list and copy of the list of ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                string[] s = ingredients.ToArray();
                List<string> i = new List<string>(s);
                return i;
            }
        }

        /// <summary>
        /// Get the description
        /// </summary>
        public virtual string Description { get; }

        /// <summary>
        /// Gets the special
        /// </summary>
        public virtual string[] Special { get; }
    }
}
