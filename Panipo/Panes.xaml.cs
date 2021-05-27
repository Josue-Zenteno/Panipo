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
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Panes : Page {

        public List<Pan> lista_panes;


        public Panes() {

            this.InitializeComponent();

            inicializarPanes();

        }

        public void inicializarPanes() {
            
            lista_panes = PanManager.GetPanes();

            foreach(Pan item in lista_panes) {

                this.listViewPanes.Items.Add("Nombre: " + item.nombre_pan);

            }

        }

       
    }
}
