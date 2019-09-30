using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class PterodactylWings : EntreeBase
    {
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }
    }
}
