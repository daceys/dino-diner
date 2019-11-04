/* CustomizeTRexKingBurger.xaml.cs
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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        // Backing variable
        private TRexKingBurger trx;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for the t rex king burger
        /// </summary>
        /// <param name="trx"></param>
        public CustomizeTRexKingBurger(TRexKingBurger trx)
        {
            InitializeComponent();
            this.trx = trx;
        }

        /// <summary>
        /// Constructor for when sent as a combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeTRexKingBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.trx = combo.Entree as TRexKingBurger;
        }

        /// <summary>
        /// Method to hold bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldBun(object sender, RoutedEventArgs args)
        {
            trx.HoldBun();
        }

        /// <summary>
        /// Method to hold lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            trx.HoldLettuce();
        }

        /// <summary>
        /// Method to hold tomato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            trx.HoldLettuce();
        }

        /// <summary>
        /// Method to hold the onion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            trx.HoldOnion();
        }

        /// <summary>
        /// Method to hold pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            trx.HoldPickle();
        }

        /// <summary>
        /// Method to hold ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            trx.HoldKetchup();
        }

        /// <summary>
        /// Method to hold mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            trx.HoldMustard();
        }

        /// <summary>
        /// Method to hold mayo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            trx.HoldMayo();
        }

        /// <summary>
        /// Method when done button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnClickDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
