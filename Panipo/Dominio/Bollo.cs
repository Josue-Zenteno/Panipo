using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panipo
{
    public class Bollo
    {

        public int id_bollo { get; set; }
        public string nombre_bollo { get; set; }
        public string cover_bollo { get; set; }
        public double precio_bollo { get; set; }
        public string descripcion_bollo { get; set; }

        public static List<Bollo> GetListBollos()
        {

            List<Bollo> lista_bollos = BolloManager.GetBollos();

            return lista_bollos;
        }

    }
}
