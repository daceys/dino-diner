/* DrinkSelection.xaml.cs
 * Author: Dacey Simpson
 */
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
using DDSize = DinoDiner.Menu.Size;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink drink;

        /// <summary>
        /// Constructor for Drink Selection
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            Lemon.IsEnabled = false;
            SweetDecaf.IsEnabled = false;
            HoldIce.IsEnabled = false;
            Flavor.IsEnabled = false;
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Lemon.IsEnabled = false;
            SweetDecaf.IsEnabled = false;
            HoldIce.IsEnabled = false;
            Flavor.IsEnabled = false;
            this.drink = drink;
        }

        /// <summary>
        /// When select the flavor button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void OnSelectJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
            }
            SweetDecaf.IsEnabled = true;
            HoldIce.IsEnabled = true;
        }

        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
            }
            Flavor.IsEnabled = true;
        }

        private void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
            }
            Lemon.IsEnabled = true;
            SweetDecaf.IsEnabled = true;
            HoldIce.IsEnabled = true;
        }

        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
            HoldIce.IsEnabled = true;
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        private void OnSweetDecaf(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.AddSweet();
            }
            if (drink is JurassicJava java)
            {
                java.Decaf = true;
            }
        }

        private void OnAddLemon(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
        }

        private void OnHoldIce(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.HoldIce();
            }
            if (drink is Water water)
            {
                water.HoldIce();
            }
            if (drink is JurassicJava java)
            {
                java.AddIce();
            }
        }

        private void Done(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
