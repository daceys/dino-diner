﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        public bool Ice = false;
        public bool RoomForCream = false;
        public bool Decaf = false;

        private Size size;

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

        public JurrasicJava()
        {
            Price = 0.59;
            Calories = 2;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        public void AddIce()
        {
            Ice = true;
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            ingredients.Add("Room for Cream");
        }
    }
}
