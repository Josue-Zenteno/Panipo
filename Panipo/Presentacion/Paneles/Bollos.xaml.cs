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

namespace Panipo
{
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
            c.Navigate(typeof(DetallesProductoBollos));
        }

    }
}
