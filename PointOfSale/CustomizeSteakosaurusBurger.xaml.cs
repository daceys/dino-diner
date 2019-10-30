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
        public SteakosaurusBurger st;
        public CustomizeSteakosaurusBurger(SteakosaurusBurger st)
        {
            InitializeComponent();
            this.st = st;
        }

        public void OnHoldBun(object sender, RoutedEventArgs args)
        {
            st.HoldBun();
        }

        public void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            st.HoldPickle();
        }

        public void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            st.HoldKetchup();
        }

        public void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            st.HoldMustard();
        }
    }
}
