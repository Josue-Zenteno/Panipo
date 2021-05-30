using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Panipo.Persistencia
{

    class PanManager
    {

        public static List<Pan> GetPanes()
        {

            var panes = new List<Pan>();

            JObject jsonPanes = JObject.Parse(File.ReadAllText("./Listados/panes.json"));

            Dictionary<string, Dictionary<string,string>> dictPanes = jsonPanes.ToObject<Dictionary<string, Dictionary<string,string>>>();

            foreach(KeyValuePair<string, Dictionary<string,string>> pan in dictPanes){
                List<KeyValuePair<string, string>> contenido = new List<KeyValuePair<string, string>>();
                
                string nombre = pan.Key;

                foreach (KeyValuePair<string, string> kvp in pan.Value) {
                    contenido.Add(kvp);
                }

                panes.Add(new Pan
                {
                    id_pan = int.Parse(contenido.ElementAt(0).Value),
                    nombre_pan = nombre,
                    cover_pan = contenido.ElementAt(1).Value,
                    precio_pan = int.Parse(contenido.ElementAt(2).Value),
                    descripcion_pan = contenido.ElementAt(3).Value
                });
            }

            return panes;

        }

    }
}
