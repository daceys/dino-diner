using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order 
    {
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        public double SubtotalCost
        {
            get;
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
