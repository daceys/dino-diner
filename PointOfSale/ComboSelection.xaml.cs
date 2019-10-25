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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public CretaceousCombo combo;

        /// <summary>
        /// Constructor for ComboSelection
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Method to send user to the customize combo page when you have selected an entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>

        private void OnSelectBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void OnSelectDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void OnSelectPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void OnSelectPterodactylWingsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void OnSelectSteakosaurusBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void OnSelectTRexKingBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }

        private void OnSelectVelociWrapCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
    }
}
