/* Triceritots.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the triceritots side
    /// </summary>
    public class Triceritots : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Holds the value for size
        /// </summary>
        private Size size;

        /// <summary>
        /// Determines size and sets the price and calories for each
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch(size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Size");
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructor that creates triceritots
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size + " Triceritots";
        }

        /// <summary>
        /// gets the description for triceritots
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// gets the specials for the triceritots
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
