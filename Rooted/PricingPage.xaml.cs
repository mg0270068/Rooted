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
    /// Interaction logic for PricingPage.xaml
    /// </summary>
    public partial class PricingPage : Page
    {
		Entry pricingEntry;

        public PricingPage()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Next button on pricing page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Confirmation.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

			//get initialentry
			pricingEntry = ((App)Application.Current).GetEntry();

			//populate initialentry with new data
			pricingEntry.InitialSale = Convert.ToDouble(PricingPriceBx.Text);
			pricingEntry.Tax = Convert.ToDouble(TaxPriceBx.Text);
			pricingEntry.FinalSale = pricingEntry.Tax + pricingEntry.InitialSale;

        }
    }
}
