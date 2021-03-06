﻿using System;
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
    /// Interaction logic for OrderEntry.xaml
    /// </summary>

    public partial class OrderEntry : Page
    {


        //local variables
        public Entry orderEntry;

        public OrderEntry()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

           //will store the initial names and variables on the entry
            try
            {
                //TODO: add if statements to check for blank strings
                orderEntry = new Entry(OrderFirstNameBx.Text, OrderLastNameBx.Text, OrderStreetAddressBx.Text, OrderPhoneBx.Text, OrderCityBx.Text, OrderStateDropDown.Text, OrderZipBx.Text);

                //send entry to initialEntry Class for storage
                ((App)Application.Current).SendEntry(orderEntry);


                //output test
                Console.WriteLine(orderEntry.ToString());

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
           
            Uri uri = new Uri("DeliveryInfo.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
           


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OrderLastNameBx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("DeliveryInfo.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
