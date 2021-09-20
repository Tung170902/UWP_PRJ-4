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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_App.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Eat_inpage : Page
    {
        public Eat_inpage()
        {
            this.InitializeComponent();
            gridview_product.Items.Add(new Product() {id = 1 ,name = "banh 1", img = new BitmapImage(new Uri("https://bizweb.dktcdn.net/thumb/1024x1024/100/185/210/products/img-3271.jpg?v=1574674905790")), content = "odgfjkisr o jasdiofgs hgiu adfsh ", price = "$20" });
            gridview_product.Items.Add(new Product() { id = 2, name = "banh 2", img = new BitmapImage(new Uri("https://i.imgur.com/NDE60ke.jpg")), content = "odgfjkisr o jasdiofgs hgiu adfsh ", price = "$20" });
            gridview_product.Items.Add(new Product() { id = 3, name = "banh 3", img = new BitmapImage(new Uri("https://banhkemdep.com/files/product/banh-kem-sinh-nhat-eatsfebg.jpg")), content = "odgfjkisr o jasdiofgs hgiu adfsh ", price = "$20" });
            gridview_product.Items.Add(new Product() { id = 4, name = "banh 1", img = new BitmapImage(new Uri("https://bizweb.dktcdn.net/thumb/1024x1024/100/185/210/products/img-3271.jpg?v=1574674905790")), content = "odgfjkisr o jasdiofgs hgiu adfsh ", price = "$20" });
            gridview_product.Items.Add(new Product() { id = 5, name = "banh 2", img = new BitmapImage(new Uri("https://i.imgur.com/NDE60ke.jpg")), content = "odgfjkisr o jasdiofgs hgiu adfsh ", price = "$20" });
            gridview_product.Items.Add(new Product() { id = 6, name = "banh 3", img = new BitmapImage(new Uri("https://banhkemdep.com/files/product/banh-kem-sinh-nhat-eatsfebg.jpg")), content = "odgfjkisr o jasdiofgs hgiu adfsh ", price = "$20" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
