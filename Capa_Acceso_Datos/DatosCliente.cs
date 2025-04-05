// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
    public class DatosCliente // Define la clase DatosCliente
    {
        private readonly ConexionBD _conexion; // Declara una variable privada y de solo lectura de tipo ConexionBD

        public DatosCliente() // Constructor de la clase DatosCliente
        {
            _conexion = new ConexionBD(); // Inicializa la variable _conexion con una nueva instancia de ConexionBD
        }

        public string Crear(ClienteEntidad cliente) // Metodo para crear un nuevo cliente
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"
                        INSERT INTO Cliente 
                        (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, JugadorEnLinea)
                        VALUES 
                        (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @JugadorEnLinea)"; // Define la consulta SQL para insertar un nuevo cliente

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@JugadorEnLinea", cliente.JugadorEnLinea);

                        cmd.ExecuteNonQuery(); // Ejecuta el comando SQL
                    }
                }
                return "Cliente registrado correctamente."; // Retorna un mensaje de exito
            }
            catch (SqlException ex) when (ex.Number == 2627) // Captura excepcion de violacion de clave unica
            {
                return "Error: La identificacion ya existe."; // Retorna un mensaje de error especifico
            }
            catch (Exception ex) // Captura cualquier otra excepcion que ocurra
            {
                return "Error al registrar cliente: " + ex.Message; // Retorna un mensaje de error
            }
        }

        public List<ClienteEntidad> ObtenerClientes() // Metodo para obtener todos los clientes
        {
            List<ClienteEntidad> lista = new List<ClienteEntidad>(); // Crea una nueva lista de ClienteEntidad

            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"
                        SELECT 
                        Identificacion, 
                        Nombre, 
                        PrimerApellido, 
                        SegundoApellido, 
                        FechaNacimiento, 
                        JugadorEnLinea 
                        FROM Cliente"; // Define la consulta SQL para obtener todos los clientes

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        using (var dr = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                        {
                            while (dr.Read()) // Lee los datos del lector
                            {
                                ClienteEntidad cliente = new ClienteEntidad // Crea una nueva instancia de ClienteEntidad
                                {
                                    Identificacion = Convert.ToInt32(dr.GetDecimal(0)),
                                    Nombre = dr.GetString(1),
                                    PrimerApellido = dr.GetString(2),
                                    SegundoApellido = dr.GetString(3),
                                    FechaNacimiento = dr.GetDateTime(4),
                                    JugadorEnLinea = dr.GetBoolean(5)
                                };

                                lista.Add(cliente); // Agrega el cliente a la lista
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al obtener clientes: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }

            return lista; // Retorna la lista de clientes
        }

        public bool Eliminar(int identificacion) // Metodo para eliminar un cliente
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = "DELETE FROM Cliente WHERE Identificacion=@Identificacion"; // Define la consulta SQL para eliminar un cliente

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        cmd.Parameters.AddWithValue("@Identificacion", identificacion); // Agrega el parametro al comando SQL
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta el comando SQL y obtiene el numero de filas afectadas
                        return rowsAffected > 0; // Retorna true si se afectaron filas, de lo contrario false
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }

        public bool Actualizar(ClienteEntidad cliente) // Metodo para actualizar un cliente
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"
                        UPDATE Cliente 
                        SET Nombre=@Nombre, PrimerApellido=@PrimerApellido, 
                        SegundoApellido=@SegundoApellido, FechaNacimiento=@FechaNacimiento, 
                        JugadorEnLinea=@JugadorEnLinea
                        WHERE Identificacion=@Identificacion"; // Define la consulta SQL para actualizar un cliente

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@JugadorEnLinea", cliente.JugadorEnLinea);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta el comando SQL y obtiene el numero de filas afectadas
                        return rowsAffected > 0; // Retorna true si se afectaron filas, de lo contrario false
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }

        public bool ExisteCliente(int identificacion) // Metodo para verificar si un cliente existe
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = "SELECT COUNT(*) FROM Cliente WHERE Identificacion=@Identificacion"; // Define la consulta SQL para verificar si un cliente existe

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        cmd.Parameters.AddWithValue("@Identificacion", identificacion); // Agrega el parametro al comando SQL
                        int count = (int)cmd.ExecuteScalar(); // Ejecuta el comando SQL y obtiene el numero de registros
                        return count > 0; // Retorna true si el cliente existe, de lo contrario false
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al verificar cliente: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }
    }
}


//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)

