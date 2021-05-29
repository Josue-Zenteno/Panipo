using Panipo.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Panipo
{

    public class Pan
    {

        public int id_pan { get; set; }
        public string nombre_pan { get; set; }
        public string cover_pan { get; set; }
        public double precio_pan { get; set; }
        public string descripcion_pan { get; set; }

        public static List<Pan> GetListPanes()
        {

            List<Pan> lista_panes = PanManager.GetPanes();

            return lista_panes;
        }
    }
}