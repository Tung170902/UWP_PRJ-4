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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_App.Practical
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
            this.InitializeComponent();
            var item1 = new Model.item_menu { Description = "Description: ", Name = "Name: ", Image = "https://i.pinimg.com/236x/eb/4b/d4/eb4bd4acc40c8d3954ad03a380e75207.jpg" };
            GV.Items.Add(item1);
            var item2 = new Model.item_menu { Description = "Description:", Name = "Name: ", Image = "https://i.pinimg.com/236x/eb/4b/d4/eb4bd4acc40c8d3954ad03a380e75207.jpg" };
            GV.Items.Add(item2);
            var item3 = new Model.item_menu { Description = "Description:", Name = "Name: ", Image = "https://i.pinimg.com/236x/eb/4b/d4/eb4bd4acc40c8d3954ad03a380e75207.jpg" };
            GV.Items.Add(item3);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (nameProduct.Text != "" && desProduct.Text != "" && imageProduct.Text != "")
            {
                var name = nameProduct.Text;
                var des = desProduct.Text;
                var image = imageProduct.Text;
                var item = new Model.item_menu() { Description = des, Name = name, Image = image };
                GV.Items.Add(item);
                nameProduct.Text = "";
                desProduct.Text = "";
                imageProduct.Text = "";
            }
        }
    }
}
