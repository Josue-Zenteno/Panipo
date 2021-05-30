using System;
using System.Collections.Generic;
using Panipo.Presentacion.Paneles;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Panipo
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Bollos : Page
    {

        public List<Bollo> lista_bollos = Bollo.GetListBollos();
        public static Bollo bollos_info;
        public Image imgBollo = new Image();

        public Bollos()
        {
            this.InitializeComponent();
        }

        public void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var bollos = (Bollo)e.ClickedItem;
            bollos_info = bollos;
            c.Navigate(typeof(DetallesProducto));
        }

        private void on_click(object sender, RoutedEventArgs e)
        {


            c.Navigate(typeof(DetallesProducto));

        }

    }
}
