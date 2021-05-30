using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Panipo
{
    public sealed partial class MainPage : Page
    {

        public static Button ButtonCarritocompra { get; set; }
        public static Button ButtonIniciarSesion { get; set; }
        public static Button ButtonCerrarSesion { get; set; }
        public static Frame ContentFrameMainPage { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(500,500));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += Ventana_Resize;
            
            listBoxSecciones.SelectedIndex = 0;
            ContentFrame.Navigate(typeof(Inicio));

            ButtonCarritocompra = btnCarritoCompra;
            ButtonIniciarSesion = btnIniciarSesion;
            ButtonCerrarSesion = btnCerrarSesion;
            ContentFrameMainPage = ContentFrame;
        }

        private void Ventana_Resize(Windows.UI.ViewManagement.ApplicationView sender, object args)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;

            if (Width >= 920)
            {
                svMenu.DisplayMode = SplitViewDisplayMode.CompactInline;
                svMenu.IsPaneOpen = true;
            }
            else if (Width >= 600)
            {
                svMenu.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                svMenu.IsPaneOpen = false;
                svUpperBar.IsPaneOpen = false;
            }
            else
            {
                svMenu.DisplayMode = SplitViewDisplayMode.Overlay;
                svMenu.IsPaneOpen = false;
                svUpperBar.IsPaneOpen = false;
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            svMenu.IsPaneOpen = !svMenu.IsPaneOpen;
        }

        private void Seccion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (InicioListBoxItem.IsSelected)
            {
                MenuTitle.Text = "Inicio";

                ContentFrame.Navigate(typeof(Inicio));
            }
            else if (PanesListBoxItem.IsSelected)
            {
                MenuTitle.Text = "Panes";

                ContentFrame.Navigate(typeof(Panes));
            }
            else if (PastelesListBoxItem.IsSelected)
            {
                MenuTitle.Text = "Pasteles";
                ContentFrame.Navigate(typeof(Pasteles));
            }
            else if (BollosListBoxItem.IsSelected)
            {
                MenuTitle.Text = "Bollos";
                ContentFrame.Navigate(typeof(Bollos));
            }
            else if (AboutUsListBoxItem.IsSelected)
            {
                MenuTitle.Text = "Sobre Nosotros";
                ContentFrame.Navigate(typeof(SobreNosotros));
            }
        }

        private void AbrirBarraBusqueda_Click(object sender, RoutedEventArgs e)
        {
            if (svUpperBar.IsPaneOpen == false)
            {
                svUpperBar.IsPaneOpen = true;
                txtBusqueda.Focus(FocusState.Programmatic);
            }
             
        }

        private void CerrarBarraBusqueda_Focus(object sender, RoutedEventArgs e)
        {
            svUpperBar.IsPaneOpen = false;
        }

        private void CarritoCompra_Click(object sender, RoutedEventArgs e)
        {
            MenuTitle.Text = "Mi Carrito";
            ContentFrame.Navigate(typeof(CarritoCompra));
        }

        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            MenuTitle.Text = "Iniciar Sesion";
            ContentFrame.Navigate(typeof(InicioSesion));
        }

        private void CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Inicio));
            btnCerrarSesion.Visibility = Visibility.Collapsed;
            btnIniciarSesion.Visibility = Visibility.Visible;
            btnCarritoCompra.Visibility = Visibility.Collapsed;
        }
    }
}