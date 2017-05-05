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
				ConfirmDelInstructionsTx.Text = ((App)Application.Current).DeliveryInstructions;
				ConfirmOrdDescriptionTx.Text = ((App)Application.Current).PricingInstructions;

				//order
				ConfirmOrdFirstNameTx.Text = saleEntry.FirstName;
				ConfirmOrdLastNameTx.Text = saleEntry.LastName;
				ConfirmOrdCityTx.Text = saleEntry.City;
				ConfirmOrdAddressTx.Text = saleEntry.Address;
				ConfirmOrdStateTx.Text = saleEntry.State;
				ConfirmOrdZipTx.Text = saleEntry.Zip;

				//delivery
				ConfirmDelFirstNameTx.Text = deliveryEntry.FirstName;
				ConfirmDelLastNameTx.Text = deliveryEntry.LastName;
				ConfirmDelAddressTx.Text = deliveryEntry.Address;
				ConfirmDelCityTx.Text = deliveryEntry.City;
				ConfirmDelStateTx.Text = deliveryEntry.State;
				ConfirmDelZipTx.Text = deliveryEntry.Zip;

				//check for deceased
				if (deliveryEntry.IsDeceased == true)
				{
					ConfirmDelDeceasedTx.Text = "Yes";
				}
				else if (deliveryEntry.IsDeceased == false)
				{
					ConfirmDelDeceasedTx.Text = "No";
				}

				//price
					ConfirmPriceTx.Text = Convert.ToString(saleEntry.InitialSale);
				ConfirmTaxTx.Text = Convert.ToString(saleEntry.Tax);
				ConfirmGrandTotalTx.Text = Convert.ToString(saleEntry.FinalSale);
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
