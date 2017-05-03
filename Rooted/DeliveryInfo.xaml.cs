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
        Entry deliveryEntry;
        //reference entry to transfer to the delivery entry
        

        public DeliveryInfo()
        {
            InitializeComponent();
        }


        //on clicking the next button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("PricingPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

            //test output

           // Console.WriteLine(deliveryEntry.ToString());
        }

        private void DeliveryDeceasedBx_Checked(object sender, RoutedEventArgs e)
        {
            deliveryEntry.IsDeceased = true;
        }

        private void SameAsBillingBtn_Click(object sender, RoutedEventArgs e)
        {
            deliveryEntry = ((App)Application.Current).GetEntry();

            //populate field with data
            DeliveryStreetAddressBx.Text = deliveryEntry.Address;
            DeliveryPhoneNumberBx.Text = deliveryEntry.PhoneNumber;
            DeliveryCityBx.Text = deliveryEntry.City;
            DeliveryStateDropDown.Text = deliveryEntry.State;
            DeliveryZipBx.Text = deliveryEntry.Zip;

        }
    }
}

