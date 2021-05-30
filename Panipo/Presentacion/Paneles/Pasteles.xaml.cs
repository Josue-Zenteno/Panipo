using System;
using Panipo.Presentacion.Paneles;
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

namespace Panipo
{
    public sealed partial class Pasteles : Page
    {

        public List<Pastel> lista_pasteles = Pastel.GetListPasteles();
        public static Pastel pasteles_info;
        public Image imgPastel = new Image();

        public Pasteles()
        {
            this.InitializeComponent();
        }


        public void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var pasteles = (Pastel)e.ClickedItem;
            pasteles_info = pasteles;
            c.Navigate(typeof(DetallesProductoPasteles));
        }

        private void on_click(object sender, RoutedEventArgs e)
        {

            c.Navigate(typeof(DetallesProducto));

        }
    }
}
