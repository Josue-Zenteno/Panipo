using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Panipo {

    public class Pan {

        public int id_pan { get; set; }
        public string nombre_pan { get; set; }
        public string cover_pan { get; set; }
        public double precio_pan { get; set; }

    }

    public class PanManager {

        public static List<Pan> GetPanes() {

            var panes = new List<Pan>();

            panes.Add(new Pan { id_pan = 1, nombre_pan = "Pan de molde", 
                cover_pan = "/Imagenes/pan_molde.jpg", precio_pan = 3.2 });
            panes.Add(new Pan { id_pan = 2, nombre_pan = "Pan de sésamo", 
                cover_pan = "/Assets/StoreLogo.scale-200.png", precio_pan = 3.2 });
            panes.Add(new Pan { id_pan = 3, nombre_pan = "Pan de cuarto", 
                cover_pan = "/Assets/StoreLogo.scale-200.png", precio_pan = 3.2 });
            panes.Add(new Pan { id_pan = 4, nombre_pan = "Pan pan", 
                cover_pan = "/Assets/StoreLogo.scale-200.png", precio_pan = 3.2 });
            panes.Add(new Pan { id_pan = 5, nombre_pan = "Pan de mercadona", 
                cover_pan = "/Assets/StoreLogo.scale-200.png", precio_pan = 3.2 });
            panes.Add(new Pan { id_pan = 6, nombre_pan = "Pan ejemplo", 
                cover_pan = "/Assets/StoreLogo.scale-200.png", precio_pan = 3.2 });

            return panes;

        }
    }
}
