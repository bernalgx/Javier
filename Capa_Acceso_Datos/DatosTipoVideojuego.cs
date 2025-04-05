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
    public class DatosTipoVideojuego // Define la clase DatosTipoVideojuego
    {
        private readonly ConexionBD _conexion; // Declara una variable privada y de solo lectura de tipo ConexionBD

        public DatosTipoVideojuego() // Constructor de la clase DatosTipoVideojuego
        {
            _conexion = new ConexionBD(); // Inicializa la variable _conexion con una nueva instancia de ConexionBD
        }

        public string Crear(TipoVideojuegoEntidad tipoVideojuego) // Metodo para crear un nuevo tipo de videojuego
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = "INSERT INTO TipoVideojuego (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)"; // Define la consulta SQL para insertar un nuevo tipo de videojuego

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Nombre", tipoVideojuego.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", tipoVideojuego.Descripcion);
                        cmd.ExecuteNonQuery(); // Ejecuta el comando SQL
                    }
                }
                return "Tipo de videojuego registrado correctamente."; // Retorna un mensaje de exito
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return "Error al registrar tipo de videojuego: " + ex.Message; // Retorna un mensaje de error
            }
        }

        public List<TipoVideojuegoEntidad> ObtenerTodos() // Metodo para obtener todos los tipos de videojuegos
        {
            var lista = new List<TipoVideojuegoEntidad>(); // Crea una nueva lista de TipoVideojuegoEntidad

            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = "SELECT Id, Nombre, Descripcion FROM TipoVideojuego"; // Define la consulta SQL para obtener todos los tipos de videojuegos

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    using (var dr = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                    {
                        while (dr.Read()) // Lee los datos del lector
                        {
                            lista.Add(new TipoVideojuegoEntidad // Agrega un nuevo tipo de videojuego a la lista
                            {
                                Id = dr.GetDecimal(0), // Si la columna ID es INT, usa GetInt32(0)
                                Nombre = dr.GetString(1),
                                Descripcion = dr.GetString(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al obtener tipos de videojuegos: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }

            return lista; // Retorna la lista de tipos de videojuegos
        }

        public bool Eliminar(decimal id) // Metodo para eliminar un tipo de videojuego
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = "DELETE FROM TipoVideojuego WHERE Id = @Id"; // Define la consulta SQL para eliminar un tipo de videojuego

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        cmd.Parameters.AddWithValue("@Id", id); // Agrega el parametro al comando SQL
                        return cmd.ExecuteNonQuery() > 0; // Ejecuta el comando SQL y retorna true si se afectaron filas, de lo contrario false
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al eliminar tipo de videojuego: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }

        public bool Actualizar(TipoVideojuegoEntidad tipoVideojuego) // Metodo para actualizar un tipo de videojuego
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"UPDATE TipoVideojuego 
                                       SET Nombre = @Nombre, Descripcion = @Descripcion
                                       WHERE Id = @Id"; // Define la consulta SQL para actualizar un tipo de videojuego

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Id", tipoVideojuego.Id);
                        cmd.Parameters.AddWithValue("@Nombre", tipoVideojuego.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", tipoVideojuego.Descripcion);
                        return cmd.ExecuteNonQuery() > 0; // Ejecuta el comando SQL y retorna true si se afectaron filas, de lo contrario false
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al actualizar tipo de videojuego: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
