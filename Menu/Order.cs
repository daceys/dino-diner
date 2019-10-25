using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<IOrderItem> items;
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        public double SubtotalCost
        {
            get
            {
                double cost = 0;
                foreach (IOrderItem item in Items)
                {
                    cost += item.Price;
                }
                if (cost <= 0) return 0;
                return cost;
            }
        }

        public double SalesTaxRate { get; protected set; }

        public double SalesTaxCost
        {
            get { return SubtotalCost * SalesTaxRate; }
        }

        public double TotalCost
        {
            get { return SubtotalCost + SalesTaxCost; }
        }

        public Order()
        {
            items = new List<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
