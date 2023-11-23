using Entidades.BaseDeDatos;
using Entidades.Modelos;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> listaClientes = GestorSqlClientes.ObtenerClientes();
            foreach (var item in listaClientes)
            { 
                Console.WriteLine(item.MostrarPersona());

            }

        }
    }
}