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


namespace Rooted
{
    /// <summary>
    /// Interaction logic for DeliveryInfo.xaml
    /// </summary>
    public partial class DeliveryInfo : Page
    {
        public Entry deliveryEntry;

        public DeliveryInfo()
        {
            InitializeComponent();
            deliveryEntry = deliveryEntry.ReceiveEntry();
            //test output
            Console.WriteLine(deliveryEntry.ToString());
        }


        //on clicking the next button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("PricingPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

            //access class information stored on last page
        }
    }
}
