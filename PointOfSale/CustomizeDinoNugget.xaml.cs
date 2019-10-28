/* CustomizeDinoNugget.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeDinoNugget.xaml
    /// </summary>
    public partial class CustomizeDinoNugget : Page
    {
        // Backing variable
        private DinoNuggets nugget;

        /// <summary>
        /// Constructor for the dino nugget customize page
        /// </summary>
        /// <param name="nugget"></param>
        public CustomizeDinoNugget(DinoNuggets nugget)
        {
            InitializeComponent();
            this.nugget = nugget;
        }

        /// <summary>
        /// Method to add a nugget to the dino nuggets order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            nugget.AddNugget();
        }
    }
}
