/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Constructor for ComboSelection
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to send user to the customize combo page when you have selected an entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void Customize(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
