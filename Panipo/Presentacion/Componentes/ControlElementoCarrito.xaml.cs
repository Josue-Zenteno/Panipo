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

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace Panipo
{
    public sealed partial class ControlElementoCarrito : UserControl
    {

       public string NombrePan
        {
            get { return lblNombrePan.Text; }
            set { lblNombrePan.Text = value; }
        }

        public string DescripcionPan
        {
            get { return lblDescripcionPan.Text; }
            set { lblDescripcionPan.Text = value; }
        }

        public string PrecioPan
        {
            get { return lblPrecioPan.Text; }
            set { lblPrecioPan.Text = value; }
        }

        public ImageSource CoverPan
        {
            get { return imgCoverPan.Source; }
            set { imgCoverPan.Source = value; }
        }


        public static readonly DependencyProperty PropertyNombrePan = DependencyProperty.Register(nameof(NombrePan), 
            typeof(string), typeof(ControlElementoCarrito), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty PropertyDescripcionPan = DependencyProperty.Register(nameof(DescripcionPan),
            typeof(string), typeof(ControlElementoCarrito), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty PropertyPrecioPan = DependencyProperty.Register(nameof(PrecioPan),
            typeof(string), typeof(ControlElementoCarrito), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty PropertyCoverPan = DependencyProperty.Register(nameof(CoverPan),
            typeof(string), typeof(ControlElementoCarrito), new PropertyMetadata(string.Empty));

        public ControlElementoCarrito()
        {
            this.InitializeComponent();
        }
    }
}
