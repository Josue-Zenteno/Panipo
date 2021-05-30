using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panipo
{
    class BolloManager
    {

        public static List<Bollo> GetBollos()
        {

            var bollos= new List<Bollo>();

            bollos.Add(new Bollo
            {
                id_bollo = 1,
                nombre_bollo = "Pan de molde",
                cover_bollo = "/Imagenes/pan_molde.jpg",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 1"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 2,
                nombre_bollo = "Pan de sésamo",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 2"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 3,
                nombre_bollo = "Pan tostado",
                cover_bollo = "/Imagenes/pan_tostado.jpg",
                precio_bollo = 5.0,
                descripcion_bollo = "Descripcion del pan 3"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 4,
                nombre_bollo = "Pan pan",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 4"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 5,
                nombre_bollo = "Pan de mercadona",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 5"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 6,
                nombre_bollo = "Pan ejemplo",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 6"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 6,
                nombre_bollo = "Pan ejemplo",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 6"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 6,
                nombre_bollo = "Pan ejemplo",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 6"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 6,
                nombre_bollo = "Pan ejemplo",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 6"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 6,
                nombre_bollo = "Pan ejemplo",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 6"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 6,
                nombre_bollo = "Pan ejemplo",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 6"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 6,
                nombre_bollo = "Pan ejemplo",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 6"
            });
            bollos.Add(new Bollo
            {
                id_bollo = 6,
                nombre_bollo = "Pan ejemplo",
                cover_bollo = "/Imagenes/marcaCorporativa.PNG",
                precio_bollo = 3.2,
                descripcion_bollo = "Descripcion del pan 6"
            });

            return bollos;

        }

    }
}
