using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Universal_App.Model
{
    class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public string price { set; get; }
        public string content { set; get; }
        public BitmapImage img { set; get; }
    }
}
