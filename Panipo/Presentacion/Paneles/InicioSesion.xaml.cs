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
using Panipo;

namespace Panipo
{

    public sealed partial class InicioSesion : Page
    {

        public InicioSesion()
        {
            this.InitializeComponent();
            
        }

        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreUsuario.Text != "" && txtContrasena.Password != "") {

                string usuario = txtNombreUsuario.Text;
                string contrasena = txtContrasena.Password;

                if (UsuariosManager.isValidUser(usuario, contrasena))
                {
                    MainPage.ContentFrameMainPage.Navigate(typeof(Inicio));
                    lblInicioSesionIncorrecto.Visibility = Visibility.Collapsed;
                    MainPage.ButtonIniciarSesion.Visibility = Visibility.Collapsed;
                    MainPage.ButtonCerrarSesion.Visibility = Visibility.Visible;
                    MainPage.ButtonCarritocompra.Visibility = Visibility.Visible;
                }
                else
                {
                    lblInicioSesionIncorrecto.Text = "Usuario y/o Contraseña incorrectos";
                    lblInicioSesionIncorrecto.Visibility = Visibility.Visible;
                }

            }
            else
            {
                lblInicioSesionIncorrecto.Text = "Hay campos vacíos";
                lblInicioSesionIncorrecto.Visibility = Visibility.Visible;
            }

        }
    }
}
