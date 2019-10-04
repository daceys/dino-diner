using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem
    {
        protected List<string> ingredients = new List<string>();

        public virtual Size Size { get; set; }

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                string[] s = ingredients.ToArray();
                List<string> i = new List<string>(s);
                return i;
            }
        }
    }
}
