using Entidades.Excepciones;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.BaseDeDatos
{
    public static class GestorSqlUsuarios
    {
        private static string stringConnection;

        static GestorSqlUsuarios()
        {
            GestorSqlUsuarios.stringConnection = "Server=.;Database=tiendaX_db;Trusted_Connection=True;";
        }

        public static bool IniciarSesionUsuario(string usuario, string clave)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSqlUsuarios.stringConnection))
                {
                    string query = "SELECT * FROM usuarios WHERE usuario = @usuario AND clave = @clave";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("usuario", usuario);
                    command.Parameters.AddWithValue("clave", clave);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        throw new ElementoNoEncontrado("No se encontraron usuarios");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new UsuarioInvalidoException("ERROR: Debe ingresar Usuario y Clave");
            }
        }              
    }
}
