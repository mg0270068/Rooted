using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Rooted
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        Entry initialEntry;
        Entry deliveryInfo;

        //receive and send from initialEntry
        public Entry GetEntry()
        {
            return initialEntry;
        }

        public void SendEntry(Entry entry)
        {
            initialEntry = entry;
        }

        //get deliveryEntry and store it
        public void SendDeliveryInfo(Entry entry)
        {
            deliveryInfo = entry;
        }
    }
}
