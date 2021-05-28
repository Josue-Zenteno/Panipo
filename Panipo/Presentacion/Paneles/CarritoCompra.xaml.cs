using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Panipo {

    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Pedidos : Page {

        public List<Pan> lista_panes = PanManager.GetPanes();

        public Pedidos() {

            this.InitializeComponent();
        
            //inicializarPedidos();

        }
        /**
        public void inicializarPedidos() {

            lista_panes = PanManager.GetPanes();
      
            foreach (Pan item in lista_panes) {

                this.LstPedidos.Items.Add("Nombre: " + item.nombre_pan);

            }

        }
        */
       
        private void btnComprarNoti(object sender, RoutedEventArgs e)
         {
            ToastContent toastContent = new ToastContent()
 {
     Visual = new ToastVisual()
     {
         BindingGeneric = new ToastBindingGeneric()
         {
             Children = 
             {
                 new AdaptiveText()
                 {
                     Text = "Compra realizada"
                 },
                 new AdaptiveText()
                 {
                     Text = "Muchas gracias por confiar en nosotros"
                 }
             }
         }
     }
 };

 // Create the toast notification
 var toastNotif = new ToastNotification(toastContent.GetXml());

 // And send the notification
 ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
         }


    }
}

