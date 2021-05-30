using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panipo
{
    public class Pastel
    {

        public int id_pastel { get; set; }
        public string nombre_pastel { get; set; }
        public string cover_pastel { get; set; }
        public double precio_pastel { get; set; }
        public string descripcion_pastel { get; set; }

        public static List<Pastel> GetListPasteles()
        {

            List<Pastel> lista_pasteles = PastelManager.GetPasteles();

            return lista_pasteles;
        }

    }
}
