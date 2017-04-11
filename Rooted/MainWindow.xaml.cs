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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
			WindowState = WindowState.Maximized;
		}


        // Order entry button on main window
        private void OrderEntryClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new OrderEntry();
            
        }


        // Home button on main window
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Main.Content = new Frame();
		}


        // Sales quote button on main window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new SalesQuote();
        }


        // Exit button on main window
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
