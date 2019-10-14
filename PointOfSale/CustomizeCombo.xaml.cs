/* CustomizeCombo.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Constructor for Customize Combo
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to take user to Side Selection page when Side button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Method to take user to Drink Selection page when Drink button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
