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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Panipo
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
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

            if (Width >= 400)
            {
                //RelativePanel.SetBelow(imgPerfil, imgLogo);
                RelativePanel.SetBelow(lblTexto, lblTituloHomePage);
                //RelativePanel.SetRightOf(lblTituloHomePage, imgLogo);
                RelativePanel.SetAlignVerticalCenterWith(lblTituloHomePage, imgLogo);
                //RelativePanel.SetAlignVerticalCenterWithPanel(imgLogo, true);

            }
            else
            {
                RelativePanel.SetBelow(lblTexto, lblTituloHomePage);
                //RelativePanel.SetRightOf(lblTituloHomePage, null);
                //RelativePanel.SetBelow(lblTituloHomePage, imgLogo);
                //RelativePanel.SetAlignVerticalCenterWith(lblTituloHomePage, null);
                //RelativePanel.SetAlignVerticalCenterWithPanel(imgLogo, false);
            }
        }
    }
}
