using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        public void OnSelectCherry(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length-1] is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Cherry;
                }
            }
            NavigationService.GoBack();
        }

        public void OnSelectChocolate(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Chocolate;
                }
            }
            NavigationService.GoBack();
        }

        public void OnSelectCola(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Cola;
                }
            }
            NavigationService.GoBack();
        }

        public void OnSelectLime(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Lime;
                }
            }
            NavigationService.GoBack();
        }

        public void OnSelectOrange(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Orange;
                }
            }
            NavigationService.GoBack();
        }

        public void OnSelectRootBeer(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.RootBeer;
                }
            }
            NavigationService.GoBack();
        }

        public void OnSelectVanilla(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Vanilla;
                }
            }
            NavigationService.GoBack();
        }
    }
}
