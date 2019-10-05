/* CretaceousCombo.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the combos
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// Get and set the entrees
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Hold the side
        /// </summary>
        private Side side;
        /// <summary>
        /// Get and set the side
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }

        /// <summary>
        /// Get and set the drink
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Get the price for the combo
        /// </summary>
        public double Price
        {
            get { return Entree.Price + Side.Price + Drink.Price - 0.25; }
        }

        /// <summary>
        /// Get the calories for the combo
        /// </summary>
        public uint Calories
        {
            get { return Entree.Calories + Side.Calories + Drink.Calories; }
        }

        /// <summary>
        /// Set the default size to small
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// Get and return the size of drink and the side
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// Get the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the creation of a combo
        /// </summary>
        /// <param name="entree"> the kind of entree </param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// Method to override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Entree + " Combo"; 
        }

    }
}
