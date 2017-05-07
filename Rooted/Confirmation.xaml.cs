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
    /// Interaction logic for Confirmation.xaml
    /// </summary>
    public partial class Confirmation : Page
	{
		Entry saleEntry;
		Entry deliveryEntry;
		string deliveryInfoText;
		string pricingInfoText;

        public Confirmation()
        {
            InitializeComponent();

			try
			{
				//obtain classes
				saleEntry = ((App)Application.Current).GetEntry();
				deliveryEntry = ((App)Application.Current).GetDeliveryInfo();

				//set text boxes

				//descriptions
				ConfirmDelInstructionsOutTx.Text = ((App)Application.Current).DeliveryInstructions;
				ConfirmOrdDescriptionOutTx.Text = ((App)Application.Current).PricingInstructions;

				//order
				ConfirmOrdFirstNameOutTx.Text = saleEntry.FirstName;
				ConfirmOrdLastNameOutTx.Text = saleEntry.LastName;
				ConfirmOrdCityOutTx.Text = saleEntry.City;
				ConfirmOrdAddressOutTx.Text = saleEntry.Address;
				ConfirmOrdStateOutTx.Text = saleEntry.State;
				ConfirmOrdZipOutTx.Text = saleEntry.Zip;

				//delivery
				ConfirmDelFirstNameOutTx.Text = deliveryEntry.FirstName;
				ConfirmDelLastNameOutTx.Text = deliveryEntry.LastName;
				ConfirmDelAddressOutTx.Text = deliveryEntry.Address;
				ConfirmDelCityOutTx.Text = deliveryEntry.City;
				ConfirmDelStateOutTx.Text = deliveryEntry.State;
				ConfirmDelZipOutTx.Text = deliveryEntry.Zip;

				//check for deceased
				if (deliveryEntry.IsDeceased == true)
				{
					ConfirmDelDeceasedOutTx.Text = "Yes";
				}
				else if (deliveryEntry.IsDeceased == false)
				{
					ConfirmDelDeceasedOutTx.Text = "No";
				}

				//price
				ConfirmPriceOutTx.Text = Convert.ToString(saleEntry.InitialSale);
				ConfirmTaxOutTx.Text = Convert.ToString(saleEntry.Tax);
				ConfirmGrandTotalOutTx.Text = Convert.ToString(saleEntry.FinalSale);
			}
			catch (Exception ex)
			{
				Console.Write("Error: " + ex);
			}

		}


        // confirmation submit button also goes to home page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("BlankHomePage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

            PrintDialog prtDlg = new PrintDialog();
            if (prtDlg.ShowDialog() == true)
            {

                StackPanelConfirmation.Background = new SolidColorBrush(Colors.White);
                prtDlg.PrintVisual(StackPanelConfirmation, "Hazel's Flowers Sales Quote:"); // The Name you call the Window in the XAML file  

            }
        }
    }
}
