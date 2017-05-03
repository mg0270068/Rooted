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
    /// Interaction logic for SalesQuote.xaml
    /// </summary>
    public partial class SalesQuote : Page
    {
        public SalesQuote()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("BlankHomePage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

            
            PrintDialog prtDlg = new PrintDialog();
            if (prtDlg.ShowDialog() == true)
            {
               
                StackPanelQuote.Background = new SolidColorBrush(Colors.White);
                prtDlg.PrintVisual(StackPanelQuote, "Hazel's Flowers Sales Quote:"); // The Name you call the Window in the XAML file  
             
            }
        }
    }
}
