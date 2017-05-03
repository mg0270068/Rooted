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
        public Confirmation()
        {
            InitializeComponent();
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
