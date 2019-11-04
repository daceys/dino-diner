/* CustomizeSteakosaurusBurger.xaml.cs
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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        //Backing Variables
        private SteakosaurusBurger st;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for the customize steakosaurus burger page
        /// </summary>
        /// <param name="st"></param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger st)
        {
            InitializeComponent();
            this.st = st;
        }

        /// <summary>
        /// Constructor for burger when a combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.st = combo.Entree as SteakosaurusBurger;
        }

        /// <summary>
        /// Method to hold bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldBun(object sender, RoutedEventArgs args)
        {
            st.HoldBun();
        }

        /// <summary>
        /// Method to hold pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            st.HoldPickle();
        }

        /// <summary>
        /// Method to hold ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            st.HoldKetchup();
        }

        /// <summary>
        /// Method to hold mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            st.HoldMustard();
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
