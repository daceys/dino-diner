/* Menu.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the Menu
    /// </summary>
    public class Menu : IMenuItem
    {
        /// <summary>
        /// Get the price
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Get the calories
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// Get a list of the ingredients
        /// </summary>
        public List<string> Ingredients { get; }

        /// <summary>
        /// List with all the available menu items
        /// </summary>
        public List<Menu> AvailableMenuItems
        {
            get
            {
                List<Menu> menu = new List<Menu>();
                menu.Add(new Brontowurst());
                menu.Add(new DinoNuggets());
                menu.Add(new PrehistoricPBJ());
                menu.Add(new PterodactylWings());
                menu.Add(new SteakosaurusBurger());
                menu.Add(new TRexKingBurger());
                menu.Add(new VelociWrap());
                menu.Add(new Fryceritops());
                menu.Add(new MezzorellaSticks());
                menu.Add(new MeteorMacAndCheese());
                menu.Add(new Triceritots());
                menu.Add(new JurassicJava());
                menu.Add(new Sodasaurus());
                menu.Add(new Tyrannotea());
                menu.Add(new Water());
                return menu;
            }
        }

        /// <summary>
        /// List of the Available Entrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> entree = new List<Entree>();
                entree.Add(new Brontowurst());
                entree.Add(new DinoNuggets());
                entree.Add(new PrehistoricPBJ());
                entree.Add(new PterodactylWings());
                entree.Add(new SteakosaurusBurger());
                entree.Add(new TRexKingBurger());
                entree.Add(new VelociWrap());
                return entree;
            }
        }

        /// <summary>
        /// List of the available sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> side = new List<Side>();
                side.Add(new Fryceritops());
                side.Add(new MeteorMacAndCheese());
                side.Add(new MezzorellaSticks());
                side.Add(new Triceritots());
                return side;
            }
        }

        /// <summary>
        /// List of all the available drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drink = new List<Drink>();
                drink.Add(new Sodasaurus());
                drink.Add(new JurassicJava());
                drink.Add(new Tyrannotea());
                drink.Add(new Water());
                return drink;
            }
        }

        /// <summary>
        /// List of the available combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> combo = new List<CretaceousCombo>();
                combo.Add(new CretaceousCombo(Brontowurst));
                combo.Add(new CretaceousCombo(DinoNuggets));
                combo.Add(new CretaceousCombo(PrehistoricPBJ));
                combo.Add(new CretaceousCombo(PterodactylWings));
                combo.Add(new CretaceousCombo(SteakosaurusBurger));
                combo.Add(new CretaceousCombo(TRexKingBurger));
                combo.Add(new CretaceousCombo(VelociWrap));
                return combo;
            }
        }
    }
}
