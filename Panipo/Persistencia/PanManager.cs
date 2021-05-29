using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panipo.Persistencia
{

    class PanManager
    {

        public static List<Pan> GetPanes()
        {

            var panes = new List<Pan>();

            panes.Add(new Pan
            {
                id_pan = 1,
                nombre_pan = "Pan de molde",
                cover_pan = "/Imagenes/pan_molde.jpg",
                precio_pan = 3.2
            });
            panes.Add(new Pan
            {
                id_pan = 2,
                nombre_pan = "Pan de sésamo",
                cover_pan = "/Imagenes/marcaCorporativa.PNG",
                precio_pan = 3.2
            });
            panes.Add(new Pan
            {
                id_pan = 3,
                nombre_pan = "Pan tostado",
                cover_pan = "/Imagenes/pan_tostado.jpg",
                precio_pan = 5.0
            });
            panes.Add(new Pan
            {
                id_pan = 4,
                nombre_pan = "Pan pan",
                cover_pan = "/Imagenes/marcaCorporativa.PNG",
                precio_pan = 3.2
            });
            panes.Add(new Pan
            {
                id_pan = 5,
                nombre_pan = "Pan de mercadona",
                cover_pan = "/Imagenes/marcaCorporativa.PNG",
                precio_pan = 3.2
            });
            panes.Add(new Pan
            {
                id_pan = 6,
                nombre_pan = "Pan ejemplo",
                cover_pan = "/Imagenes/marcaCorporativa.PNG",
                precio_pan = 3.2
            });

            return panes;

        }

    }
}
