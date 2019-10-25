/* Entree.cs
 * Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for the entrees
    /// </summary>
    public abstract class Entree : IMenuItem, INotifyPropertyChanged, IOrderItem
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
        /// List to hold the ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Property to get and set the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Property to get and set the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Property to get a list of the ingredients, makes a copy
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                string [] s = ingredients.ToArray();
                List<string> i = new List<string>(s);
                return i;
            }
        }

        /// <summary>
        /// Property to get the specials for each class
        /// </summary>
        public virtual string[] Special { get; }
        /// <summary>
        /// Gets the Description
        /// </summary>
        public virtual string Description { get; }
    }
}
