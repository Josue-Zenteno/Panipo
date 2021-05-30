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


namespace Panipo.Presentacion.Paneles
{

    public sealed partial class DetallesProducto : Page
    {

        public Pan ventana_panes_info = Panes.panes_info;
        public List<Pan> lista_panes_info = Pan.GetListPanes();

        public DetallesProducto()
        {
            this.InitializeComponent();
            this.Visibility = Visibility.Visible;

        }

        private void on_ClickReturnPanWindow(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            ContentFrameProductDetails.Navigate(typeof(Panes));

        }
    }
}
