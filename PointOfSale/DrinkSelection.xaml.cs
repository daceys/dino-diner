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
        // Backing variable 
        private Drink drink;
        private CretaceousCombo combo;

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

        /// <summary>
        /// Constructor for drink selection when already have a current drink
        /// </summary>
        /// <param name="drink">current drink</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Lemon.IsEnabled = false;
            Flavor.IsEnabled = false;
            SweetDecaf.IsEnabled = false;
            HoldIce.IsEnabled = false;
            if (drink is Tyrannotea)
            {
                Lemon.IsEnabled = true;
                SweetDecaf.IsEnabled = true;
                HoldIce.IsEnabled = true;
            }
            if (drink is Sodasaurus)
            {
                Flavor.IsEnabled = true;
            }
            if (drink is JurassicJava)
            {
                SweetDecaf.IsEnabled = true;
                HoldIce.IsEnabled = true;
            }
            if (drink is Water) HoldIce.IsEnabled = true;
            this.drink = drink;
        }

        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.drink = combo.Drink;
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

        /// <summary>
        /// Method to add a jurassic java to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectJurassicJava(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Drink = new JurassicJava();
                
            }
            else if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
            }
            SweetDecaf.IsEnabled = true;
            HoldIce.IsEnabled = true;
        }
        /// <summary>
        /// Method to add a sodasaurus to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Drink = new Sodasaurus();
            }
            else if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
            }
            Flavor.IsEnabled = true;
        }

        /// <summary>
        /// Method to add a tyrannotea to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Drink = new Tyrannotea();
            }
            else if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
            }
            Lemon.IsEnabled = true;
            SweetDecaf.IsEnabled = true;
            HoldIce.IsEnabled = true;
        }

        /// <summary>
        /// Method to add a water to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Drink = new Water();
            }
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
            HoldIce.IsEnabled = true;
        }

        /// <summary>
        /// Method to handle a change in size and display with the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        /// <summary>
        /// Method to create a sweet tyrannotea or a decaf jurassic java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSweetDecaf(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.Sweet = true;
            }
            if (drink is JurassicJava java)
            {
                java.Decaf = true;
            }
        }

        /// <summary>
        /// Method to add a lemon to the selected tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddLemon(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
        }

        /// <summary>
        /// Method to hold ice for the tyrannotea and water or add ice for the jurassic java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

        /// <summary>
        /// Method to send user back to menu selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Done(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
