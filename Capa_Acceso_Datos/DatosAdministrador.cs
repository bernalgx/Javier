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
    public class DatosAdministrador // Define la clase DatosAdministrador
    {
        private readonly ConexionBD _conexion; // Declara una variable privada y de solo lectura de tipo ConexionBD

        public DatosAdministrador() // Constructor de la clase DatosAdministrador
        {
            _conexion = new ConexionBD(); // Inicializa la variable _conexion con una nueva instancia de ConexionBD
        }

        // Crear un administrador
        public string Crear(AdministradorEntidad administrador) // Metodo para crear un nuevo administrador
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"
                        INSERT INTO Administrador 
                        (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion)
                        VALUES 
                        (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @FechaContratacion)"; // Define la consulta SQL para insertar un nuevo administrador

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Identificacion", administrador.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", administrador.PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", administrador.SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", administrador.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@FechaContratacion", administrador.FechaContratacion);

                        cmd.ExecuteNonQuery(); // Ejecuta el comando SQL
                    }
                }
                return "Administrador insertado correctamente."; // Retorna un mensaje de exito
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return "Error al insertar administrador: " + ex.Message; // Retorna un mensaje de error
            }
        }

        // Obtener todos los administradores
        public List<AdministradorEntidad> ObtenerAdministradores() // Metodo para obtener todos los administradores
        {
            var lista = new List<AdministradorEntidad>(); // Crea una nueva lista de AdministradorEntidad

            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = "SELECT Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion FROM Administrador"; // Define la consulta SQL para obtener todos los administradores

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        using (var reader = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                        {
                            while (reader.Read()) // Lee los datos del lector
                            {
                                // Agrega un nuevo administrador a la lista
                                lista.Add(new AdministradorEntidad
                                {
                                    Identificacion = reader.GetDecimal(0),
                                    Nombre = reader.GetString(1),
                                    PrimerApellido = reader.GetString(2),
                                    SegundoApellido = reader.GetString(3),
                                    FechaNacimiento = reader.GetDateTime(4),
                                    FechaContratacion = reader.GetDateTime(5)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al obtener administradores: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }

            return lista; // Retorna la lista de administradores
        }

        // Actualizar un administrador
        public bool Actualizar(AdministradorEntidad administrador) // Metodo para actualizar un administrador
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"
                        UPDATE Administrador 
                        SET Nombre = @Nombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, 
                            FechaNacimiento = @FechaNacimiento, FechaContratacion = @FechaContratacion
                        WHERE Identificacion = @Identificacion"; // Define la consulta SQL para actualizar un administrador

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Identificacion", administrador.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", administrador.PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", administrador.SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", administrador.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@FechaContratacion", administrador.FechaContratacion);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta el comando SQL y obtiene el numero de filas afectadas
                        return rowsAffected > 0; // Retorna true si se afectaron filas, de lo contrario false
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al actualizar administrador: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }

        // Eliminar un administrador
        public bool Eliminar(int identificacion) // Metodo para eliminar un administrador
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = "DELETE FROM Administrador WHERE Identificacion = @Identificacion"; // Define la consulta SQL para eliminar un administrador

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
                throw new Exception("Error al eliminar administrador: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
