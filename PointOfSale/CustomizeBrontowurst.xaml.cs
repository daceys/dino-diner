﻿/* CustomizeBrontowurst.xaml.cs
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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        // Backing variable
        private Brontowurst bw;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for the customize brontowurst page
        /// </summary>
        /// <param name="bw"></param>
        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
        }

        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.bw = combo.Entree as Brontowurst;
        }

        /// <summary>
        /// Method to hold bun for the brontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            bw.HoldBun();
        }

        /// <summary>
        /// Method to hold peppers for the brontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            bw.HoldPeppers();
        }

        /// <summary>
        /// Method to hold onion on the brontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            bw.HoldOnion();
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
