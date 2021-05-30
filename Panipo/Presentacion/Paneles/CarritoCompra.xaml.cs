using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Panipo
{
    public sealed partial class CarritoCompra : Page
    {
        public static List<Pan> PANESCARRITOCOMPRA { get; set; }
        public List<Pan> panesCarritoCompra = Pan.GetListPanes();

        public CarritoCompra()
        {
            this.InitializeComponent();
            PANESCARRITOCOMPRA = panesCarritoCompra;
        }

        private void FinalizarCompra_Click(object sender, RoutedEventArgs e)
        {
            if (panesCarritoCompra.Count != 0)
            {
                var toastContent = new ToastContent()
                {
                    Visual = new ToastVisual()
                    {
                        BindingGeneric = new ToastBindingGeneric()
                        {
                            Children =
                        {
                            new AdaptiveText()
                            {
                                Text = "Su compra ha sido realizada."
                            },
                            new AdaptiveText()
                            {
                                Text = "Su pedido esta en camino..."
                            },
                            new AdaptiveImage()
                            {
                                Source = "Imagenes/panaderia.jpg"
                            }
                        },
                            AppLogoOverride = new ToastGenericAppLogo()
                            {
                                Source = "Imagenes/marcaCorporativa.PNG",
                                HintCrop = ToastGenericAppLogoCrop.Circle
                            }
                        }
                    },
                    Actions = new ToastActionsCustom()
                    {
                        Buttons =
                    {
                        new ToastButton("Aceptar", "Aceptar")
                        {
                            ActivationType = ToastActivationType.Background
                        }
                    }
                    },
                    Launch = "Imagenes/marcaCorporativa.PNG"
                };



                // Create the toast notification
                var toastNotif = new ToastNotification(toastContent.GetXml());

                // And send the notification
                ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
            }
            
        }
    }
}
