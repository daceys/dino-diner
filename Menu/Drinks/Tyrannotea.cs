using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
            get
            {
                return size;
            }
        } 

        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }

        public void AddLemon()
        {
            ingredients.Add("Lemon");
        }
    }
}
