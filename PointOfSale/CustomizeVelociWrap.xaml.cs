/* CustomizeVelociWrap.xaml.cs
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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        // Backing variable
        private VelociWrap vw;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for the customize veloci wrap
        /// </summary>
        /// <param name="vw"></param>
        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }

        /// <summary>
        /// construcror for velci wrap when a combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeVelociWrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.vw = combo.Entree as VelociWrap;
        }

        /// <summary>
        /// Method to hold the dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            vw.HoldDressing();
        }

        /// <summary>
        /// Method to hold the lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            vw.HoldLettuce();
        }

        /// <summary>
        /// Method to hold the cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            vw.HoldCheese();
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
