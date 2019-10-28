/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        // Backing variable 
        public Entree entree;
        
        /// <summary>
        /// Constructor for the entree selection page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for the current entree selection
        /// </summary>
        /// <param name="entree">current entree</param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }

        /// <summary>
        /// Method to add a brontowurst to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                order.Add(bw);
                NavigationService.Navigate(new CustomizeBrontowurst(bw));
            }
        }

        /// <summary>
        /// Method to add a dino nuggets to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nug = new DinoNuggets();
                order.Add(nug);
                NavigationService.Navigate(new CustomizeDinoNugget(nug));
            }
        }

        /// <summary>
        /// Method to add a prehistoric pbj to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        /// <summary>
        /// Method to add pterodactyl wings to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Method to add a steakosaurus burger to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Method to add a trex king burger to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Method to add a velociwrap to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
            }
            NavigationService.GoBack();
        }
    }
}
