using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        public bool Sweet = false;
        public bool Lemon = false;
        public bool Ice = true;

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
                        if (Sweet == true) Calories = 16;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (Sweet == true) Calories = 32;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        if (Sweet == true) Calories = 64;
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
            Lemon = true;
            ingredients.Add("Lemon");
        }

        public void HoldIce()
        {
            Ice = false;
        }
        public void AddSweet()
        {
            Sweet = true;
            ingredients.Add("Cane Sugar");
        }
    }
}
