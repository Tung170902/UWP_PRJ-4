using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Universal_App.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_App.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageApp : Page
    {
        public PageApp()
        {
            this.InitializeComponent();
            Mainframe.Navigate(typeof(pages.Home));
        }

        private void list_menu_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new item_menu() { name = "Home", page = "home", icon = "\xE700" };
            var item2 = new item_menu() { name = "Eat_in", page = "eat", icon = "\xE700" };
            var item3 = new item_menu() { name = "Collection", page = "collection", icon = "\xE700" };
            var item4 = new item_menu() { name = "Delivery", page = "delivery", icon = "\xE700" };
            var item5 = new item_menu() { name = "Take away", page = "take", icon = "\xE700" };
            var item6 = new item_menu() { name = "Driver payment", page = "payment", icon = "\xE700" };
            var item7 = new item_menu() { name = "Customer", page = "customer", icon = "\xE700" };
            list_menu.Items.Add(item1);
            list_menu.Items.Add(item2);
            list_menu.Items.Add(item3);
            list_menu.Items.Add(item4);
            list_menu.Items.Add(item5);
            list_menu.Items.Add(item6);
            list_menu.Items.Add(item7);
        }

        private void item_Tapped(object sender, TappedRoutedEventArgs e)
        {
            item_menu select = (item_menu)list_menu.SelectedItem;
            switch (select.page) {
                case "home":
                    Mainframe.Navigate(typeof(pages.Home));
                break;

                case "eat":
                    Mainframe.Navigate(typeof(pages.Eat_inpage));
                break;

                case "collection":
                    Mainframe.Navigate(typeof(pages.Collection));
                break;

                case "delivery":
                    Mainframe.Navigate(typeof(pages.Delivery));
                break;

                case "take":
                    Mainframe.Navigate(typeof(pages.Take_away));
                break;

                case "payment":
                    Mainframe.Navigate(typeof(pages.Payment));
                break;

                case "customer":
                    Mainframe.Navigate(typeof(pages.Customerpage));
                break;
            }
        }
    }
}
