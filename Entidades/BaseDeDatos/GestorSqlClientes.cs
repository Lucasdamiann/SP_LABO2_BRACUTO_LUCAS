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
    public static class GestorSqlClientes
    {
        private static string stringConnection;

        static GestorSqlClientes()
        {
            GestorSqlClientes.stringConnection = "Server=.;Database=tiendaX_db;Trusted_Connection=True;";
        }

        public static Cliente ObtenerClientePorCampo(string item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSqlClientes.stringConnection))
                {
                    string query = "SELECT * FROM clientes WHERE nombre = @item OR apellido = @item OR direccion = @item";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("item", item);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        Cliente cliente = new Cliente();
                        cliente.NumeroCliente = reader.GetInt32(0);
                        cliente.NombreCliente = reader.GetString(1);
                        cliente.ApellidoCliente = reader.GetString(2);
                        cliente.DireccionCliente = reader.GetString(3);
                        return cliente;
                    }
                    else
                    {
                        throw new ElementoNoEncontrado("No se encontraron elementos");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new UsuarioInvalidoException("ERROR: ID desconocido o inexistente");
            }
        }

        public static List<Cliente> ObtenerClientes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSqlClientes.stringConnection))
                {
                    string query = "SELECT * FROM clientes";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            List<Cliente> listaClientes = new List<Cliente>();
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente();
                                cliente.NumeroCliente = reader.GetInt32(0);
                                cliente.NombreCliente = reader.GetString(1);
                                cliente.ApellidoCliente = reader.GetString(2);
                                cliente.DireccionCliente = reader.GetString(3);
                                listaClientes.Add(cliente);
                            }
                            return listaClientes;
                        }
                        else
                        {
                            throw new ElementoNoEncontrado("No se encontraron elementos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new UsuarioInvalidoException("ERROR: Falla en la conexion");
            }

        }
            public static void GenerarAltaCliente(string nombre, string apellido, string direccion)
            {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSqlClientes.stringConnection))
                {
                    string query = "INSERT INTO clientes (nombre, apellido, direccion) VALUES (@nombre, @apellido, @direccion)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("nombre", nombre);
                    command.Parameters.AddWithValue("apellido", apellido);
                    command.Parameters.AddWithValue("direccion", direccion);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                throw new UsuarioInvalidoException("ERROR: ID desconocido o inexistente");
            }
        }
    }
}
