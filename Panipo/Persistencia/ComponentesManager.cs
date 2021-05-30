using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panipo.Persistencia
{
    public class ComponentesManager
    {
        public static List<Componentes> GetComponentes()
        {

            var componente = new List<Componentes>();

            componente.Add(new Componentes
            {
                nombre_componente = "Sergio ",
                apellido_componente = "Silvestre Pavón",
                foto_componente = "/Imagenes/perfilSergio.png"
               
            });
            componente.Add(new Componentes
            {
                nombre_componente = "Guadalupe ",
                apellido_componente = "Plaza Gómez",
                foto_componente = "/Imagenes/perfilGuada.jpg"
            });
            componente.Add(new Componentes
            {
                nombre_componente = "Josue",
                apellido_componente = "Zenteno Yave",
                foto_componente = "/Imagenes/perfilJosu.jpg"
            });
            componente.Add(new Componentes
            {
                nombre_componente = "María Jesús ",
                apellido_componente = "Dueñas Recuero",
                foto_componente = "/Imagenes/perfilMJ.jpg"
            });

            return componente;
        }
    }
}
