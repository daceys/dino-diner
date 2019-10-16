/* Side.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for the sides
    /// </summary>
    public abstract class Side : IMenuItem, INotifyPropertyChanged, IOrderItem
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
        /// Holds the list of ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();
        
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
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
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        public virtual string Description { get; }

        public virtual string[] Special { get; }
    }
}
