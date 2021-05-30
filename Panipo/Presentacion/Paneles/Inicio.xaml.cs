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

namespace Panipo
{

    public sealed partial class Inicio : Page
    {
        public Inicio()
        {
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += UcRatingText_VisibleBoundsChanged;
        }

        private void UcRatingText_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView sender, object args)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;

            if (Width >= 360)
            {
                RelativePanel.SetBelow(lblTexto, lblTituloHomePage);
                RelativePanel.SetAlignVerticalCenterWith(lblTituloHomePage, imgLogo);
            }
            else
            {
                RelativePanel.SetBelow(lblTexto, lblTituloHomePage);
            }
        }
    }
}
