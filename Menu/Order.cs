using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order 
    {
        public ObservableCollection<IOrderItem> Item { get; set; }

        private double cost; 

        public double SubtotalCost
        {
            get
            {
                if (cost < 0) return 0;
                return cost;
            }
        }

        public double SalesTaxRate { get; protected set; }

        public double SalesTaxCost
        {
            get { return SubtotalCost + SalesTaxRate; }
        }

        public double TotalCost
        {
            get { return SubtotalCost + SalesTaxCost; }
        }
    }
}
