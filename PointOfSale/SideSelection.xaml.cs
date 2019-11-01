/* SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        // Backing variable
        private Side side;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for the Side selection page
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor  for the current side selection
        /// </summary>
        /// <param name="side">current side</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.side = combo.Side;
        }

        /// <summary>
        /// Method to add a fryceritops to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Side = new Fryceritops();
                this.side = combo.Side;
            }
            else if (DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(side);
            }
        }
        
        /// <summary>
        /// Method to add a meteor mac and cheese to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Side = new MeteorMacAndCheese();
                this.side = combo.Side;
            }
            else if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(side);
            }
        }
        /// <summary>
        /// Method to add a mezzorella sticks to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Side = new MezzorellaSticks();
                this.side = combo.Side;
            }
            else if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Add(side);
            }
        }

        /// <summary>
        /// Method to add a triceritots to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                combo.Side = new Triceritots();
                this.side = combo.Side;
            }
            else if (DataContext is Order order)
            {
                side = new Triceritots();
                order.Add(side);
            }
        }

        /// <summary>
        /// Method to change the sides size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
            NavigationService.GoBack();
        }
    }
}
