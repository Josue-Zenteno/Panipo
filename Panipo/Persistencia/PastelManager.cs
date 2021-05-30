using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Panipo
{
    class PastelManager
    {


        public static List<Pastel> GetPasteles()
        {

            var pasteles = new List<Pastel>();

            JObject jsonPasteles = JObject.Parse(File.ReadAllText("./Listados/pasteles.json"));

            Dictionary<string, Dictionary<string, string>> dictPasteles = jsonPasteles.ToObject<Dictionary<string, Dictionary<string, string>>>();

            foreach (KeyValuePair<string, Dictionary<string, string>> pastel in dictPasteles)
            {
                List<KeyValuePair<string, string>> contenido = new List<KeyValuePair<string, string>>();

                string nombre = pastel.Key;

                foreach (KeyValuePair<string, string> kvp in pastel.Value)
                {
                    contenido.Add(kvp);
                }

                pasteles.Add(new Pastel
                {
                    id_pastel = int.Parse(contenido.ElementAt(0).Value),
                    nombre_pastel = nombre,
                    cover_pastel = contenido.ElementAt(1).Value,
                    precio_pastel = int.Parse(contenido.ElementAt(2).Value),
                    descripcion_pastel = contenido.ElementAt(3).Value
                });
            }

            return pasteles;

        }

    }
}
