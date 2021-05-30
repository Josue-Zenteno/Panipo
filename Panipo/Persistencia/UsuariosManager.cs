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
    class UsuariosManager
    {
        public static bool isValidUser(string usuario, string contrasena)
        {
            JObject jsonUsuarios = JObject.Parse(File.ReadAllText("./Listados/usuarios.json"));
            Dictionary<string, string> dictUsuarios = jsonUsuarios.ToObject<Dictionary<string, string>>();

            if (dictUsuarios.ContainsKey(string.Format("{0}", usuario)))
            {
                if(dictUsuarios[usuario] == contrasena)
                {
                    return true;
                }
            }

            return false;
        }
            
        
    }
}
