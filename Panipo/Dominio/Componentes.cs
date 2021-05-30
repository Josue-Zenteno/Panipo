using Panipo.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panipo
{
    public class Componentes

    {

        public string nombre_componente { get; set; }
        public string foto_componente { get; set; }
        public string apellido_componente { get; set; }



        public static List<Componentes> GetListComponentes()
        {

            List<Componentes> lista_componentes = ComponentesManager.GetComponentes();

            return lista_componentes;
        }
    }
}
