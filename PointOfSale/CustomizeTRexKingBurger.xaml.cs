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
        public TRexKingBurger trx;
        public CustomizeTRexKingBurger(TRexKingBurger trx)
        {
            InitializeComponent();
            this.trx = trx;
        }

        public void OnHoldBun(object sender, RoutedEventArgs args)
        {
            trx.HoldBun();
        }

        public void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            trx.HoldLettuce();
        }

        public void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            trx.HoldLettuce();
        }

        public void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            trx.HoldOnion();
        }

        public void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            trx.HoldPickle();
        }

        public void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            trx.HoldKetchup();
        }

        public void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            trx.HoldMustard();
        }

        public void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            trx.HoldMayo();
        }

        
    }
}
