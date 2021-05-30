using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panipo
{
    class PastelManager
    {


        public static List<Pastel> GetPasteles()
        {

            var pasteles = new List<Pastel>();

            pasteles.Add(new Pastel
            {
                id_pastel = 1,
                nombre_pastel = "Pan de molde",
                cover_pastel = "/Imagenes/pan_molde.jpg",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 1"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 2,
                nombre_pastel = "Pan de sésamo",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 2"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 3,
                nombre_pastel = "Pan tostado",
                cover_pastel = "/Imagenes/pan_tostado.jpg",
                precio_pastel = 5.0,
                descripcion_pastel = "Descripcion del pan 3"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 4,
                nombre_pastel = "Pan pan",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 4"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 5,
                nombre_pastel = "Pan de mercadona",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 5"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 6,
                nombre_pastel = "Pan ejemplo",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 6"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 6,
                nombre_pastel = "Pan ejemplo",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 6"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 6,
                nombre_pastel = "Pan ejemplo",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 6"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 6,
                nombre_pastel = "Pan ejemplo",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 6"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 6,
                nombre_pastel = "Pan ejemplo",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 6"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 6,
                nombre_pastel = "Pan ejemplo",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 6"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 6,
                nombre_pastel = "Pan ejemplo",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 6"
            });
            pasteles.Add(new Pastel
            {
                id_pastel = 6,
                nombre_pastel = "Pan ejemplo",
                cover_pastel = "/Imagenes/marcaCorporativa.PNG",
                precio_pastel = 3.2,
                descripcion_pastel = "Descripcion del pan 6"
            });

            return pasteles;

        }

    }
}
