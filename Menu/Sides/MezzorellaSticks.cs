﻿/* MezzorellaSticks.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the mezzorella sticks
    /// </summary>
    public class MezzorellaSticks : Side, IOrderItem, INotifyPropertyChanged
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
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
        /// Constructor for the creation of the cheese sticks
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            ingredients.Add("Breading");
            ingredients.Add("Cheese Product");
            ingredients.Add("Vegetable Oil");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size + " Mezzorella Sticks";
        }

        /// <summary>
        /// gets the description for mezzorella sticks
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// gets the specials for the mezzorella sticks
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
