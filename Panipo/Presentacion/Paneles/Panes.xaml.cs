using Panipo.Presentacion.Paneles;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


namespace Panipo
{
    public sealed partial class Panes : Page
    {

        public List<Pan> lista_panes = Pan.GetListPanes();
        public static Pan panes_info;
        public Image imgPan = new Image();

        public Panes()
        {
           this.InitializeComponent();
        }

        public void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {

            var panes = (Pan)e.ClickedItem;
            panes_info = panes;
            ContentFramePan.Navigate(typeof(DetallesProducto));

        }

    }
}
