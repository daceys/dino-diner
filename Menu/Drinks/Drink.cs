﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Drink
    {
        protected List<string> ingredients = new List<string>();

        public virtual Size Size { get; set; }

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get { return ingredients; }
        }
    }
}
