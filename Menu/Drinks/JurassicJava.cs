﻿/* JurassicJava.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Jurassic Java drink
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Sets fields for ice, room for cream, and decaf
        /// </summary>
        public bool Ice = false;
        public bool RoomForCream = false;
        public bool Decaf = false;

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
                switch (size)
                {
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructor for creation of the jurassic java
        /// </summary>
        public JurassicJava()
        {
            Price = 0.59;
            Calories = 2;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        /// <summary>
        /// Method to add ice
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// Method to leave room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            ingredients.Add("Room for Cream");
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf) return size + " Decaf Jurassic Java";
            return size + " Jurassic Java";
        }
    }
}
