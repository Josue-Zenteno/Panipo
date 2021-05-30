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
    class BolloManager
    {

        public static List<Bollo> GetBollos()
        {

            var bollos= new List<Bollo>();

            JObject jsonBollos = JObject.Parse(File.ReadAllText("./Listados/bollos.json"));

            Dictionary<string, Dictionary<string, string>> dictBollos = jsonBollos.ToObject<Dictionary<string, Dictionary<string, string>>>();

            foreach (KeyValuePair<string, Dictionary<string, string>> bollo in dictBollos)
            {
                List<KeyValuePair<string, string>> contenido = new List<KeyValuePair<string, string>>();

                string nombre = bollo.Key;

                foreach (KeyValuePair<string, string> kvp in bollo.Value)
                {
                    contenido.Add(kvp);
                }

                bollos.Add(new Bollo
                {
                    id_bollo = int.Parse(contenido.ElementAt(0).Value),
                    nombre_bollo = nombre,
                    cover_bollo = contenido.ElementAt(1).Value,
                    precio_bollo = int.Parse(contenido.ElementAt(2).Value),
                    descripcion_bollo = contenido.ElementAt(3).Value
                });
            }

            return bollos;

        }

    }
}
