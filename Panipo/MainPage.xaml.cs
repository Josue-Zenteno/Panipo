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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Panipo
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(700,1000));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;
            
            IconsListBox.SelectedIndex = 0;
            ContentFrame.Navigate(typeof(Inicio));
        }

        private void MainPage_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView sender, object args)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;

            if (Width >= 720)
            {
                svMenu.DisplayMode = SplitViewDisplayMode.CompactInline;
                svMenu.IsPaneOpen = true;
            }
            else if (Width >= 360)
            {
                svMenu.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                svMenu.IsPaneOpen = false;
            }
            else
            {
                svMenu.DisplayMode = SplitViewDisplayMode.Overlay;
                svMenu.IsPaneOpen = false;
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            svMenu.IsPaneOpen = !svMenu.IsPaneOpen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (svUpperBar.IsPaneOpen == false)
            {
                svUpperBar.IsPaneOpen = true;
                txtBusqueda.Focus(FocusState.Programmatic);
            }
            else {
                //TODO Buscar Cosas y buscar dandole al Enter porque sino está el bug
            }
            
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (InicioListBoxItem.IsSelected) {  
                MenuTitle.Text = "Inicio";

                ContentFrame.Navigate(typeof(Inicio));
            }
            else if (PanesListBoxItem.IsSelected) { 
                MenuTitle.Text = "Panes";

                ContentFrame.Navigate(typeof(Panes));
            }
            else if (PastelesListBoxItem.IsSelected) { 
                MenuTitle.Text = "Pasteles";
                ContentFrame.Navigate(typeof(Pedidos));
            }
            else if (BollosListBoxItem.IsSelected) { 
                MenuTitle.Text = "Bollos";
                ContentFrame.Navigate(typeof(InicioSesion));
            }
        }

        private void Prueba(object sender, RoutedEventArgs e)
        {
            svUpperBar.IsPaneOpen = false;
        }
    }
}