using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class EntreeBase
    {
        protected List<string> ingredients = new List<string>();

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get { return ingredients; }
        }
    }
}
