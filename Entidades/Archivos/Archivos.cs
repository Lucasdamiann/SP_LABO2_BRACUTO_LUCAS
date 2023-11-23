using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public static class Archivos
    {
        public static string CrearRutaArchivo()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string directorioArchivo = "Archivos Json";
            path = Path.Combine(path, directorioArchivo);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        public static string CargarArchivo(string nombreArchivo)
        {
            string ruta = "..\\..\\..\\..\\VideoClub\\Properties\\Resources\\";
            using (StreamReader sr = new StreamReader(Path.Combine(ruta, nombreArchivo)))
            {
                return sr.ReadToEnd();
            }
        }

        public static void SerializarClientes(List<Cliente> clientes)
        {
            string archivo = "clientes.json";
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            using (StreamWriter sw = new StreamWriter(Path.Combine(CrearRutaArchivo(), archivo)))
            {
                string listaSerializar = JsonSerializer.Serialize(clientes, options);
                sw.WriteLine(listaSerializar);
            }
        }

        public static List<Cliente> DeserializarClientes()
        {
            string archivo = "clientes.json";
            using (StreamReader sr = new StreamReader(Path.Combine(CrearRutaArchivo(), archivo)))
            {
                string listaSerializada = sr.ReadToEnd();
                return JsonSerializer.Deserialize<List<Cliente>>(listaSerializada);
            }
        }
    }
}
