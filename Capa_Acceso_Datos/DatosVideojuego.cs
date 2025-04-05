// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================


using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient; // O System.Data.SqlClient
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
    public class DatosVideojuego // Define la clase DatosVideojuego
    {
        private readonly ConexionBD _conexion; // Declara una variable privada y de solo lectura de tipo ConexionBD

        // Recibimos la instancia de la conexion en el constructor
        public DatosVideojuego() // Constructor de la clase DatosVideojuego
        {
            _conexion = new ConexionBD(); // Inicializa la variable _conexion con una nueva instancia de ConexionBD
        }

        public List<VideojuegosXTiendaEntidad> ObtenerVideojuegosPorTienda(int tiendaId) // Metodo para obtener videojuegos por tienda
        {
            List<VideojuegosXTiendaEntidad> lista = new List<VideojuegosXTiendaEntidad>(); // Crea una nueva lista de VideojuegosXTiendaEntidad

            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                                 // Consulta que une la tabla VideojuegosXTienda con Videojuego y Tienda para obtener toda la informacion necesaria.
                    string sql = "SELECT vt.Existencias, v.Id, v.Nombre, v.Desarrollador, v.Lanzamiento, v.Fisico, v.Id_TipoVideojuego, t.Id, t.Nombre, t.Direccion, t.Telefono, t.Activa, t.Id_Administrador FROM VideojuegosXTienda vt INNER JOIN Videojuego v ON vt.Id_VideoJuego = v.Id INNER JOIN Tienda t ON vt.Id_Tienda = t.Id WHERE t.Id = @Id_Tienda"; // Define la consulta SQL para obtener videojuegos por tienda

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        cmd.Parameters.AddWithValue("@Id_Tienda", tiendaId); // Agrega el parametro al comando SQL

                        using (var dr = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                        {
                            while (dr.Read()) // Lee los datos del lector
                            {
                                // Leer la cantidad de existencias
                                decimal existencias = dr.GetDecimal(0);

                                // Crear el objeto VideojuegoEntidad con la informacion obtenida
                                VideojuegoEntidad videojuego = new VideojuegoEntidad
                                {
                                    Id = Convert.ToInt32(dr.GetDecimal(1)),
                                    Nombre = dr.GetString(2),
                                    Desarrollador = dr.GetString(3),
                                    Lanzamiento = Convert.ToInt32(dr.GetDecimal(4)), // Suponiendo que "Lanzamiento" tambien es numeric
                                    Fisico = dr.GetBoolean(5),
                                    Id_TipoVideojuego = Convert.ToInt32(dr.GetDecimal(6)) // Si es numeric, de lo contrario, si es int, usa GetInt32
                                };

                                // Crear el objeto TiendaEntidad con la informacion obtenida
                                TiendaEntidad tienda = new TiendaEntidad
                                {
                                    Id = Convert.ToInt32(dr.GetDecimal(7)),
                                    Nombre = dr.GetString(8),
                                    Direccion = dr.GetString(9),
                                    Telefono = dr.GetString(10),
                                    Activa = dr.GetBoolean(11),
                                    Id_Administrador = Convert.ToInt32(dr.GetDecimal(12))
                                };

                                // Crear la entidad VideojuegosXTiendaEntidad y agregarla a la lista
                                VideojuegosXTiendaEntidad entidad = new VideojuegosXTiendaEntidad(tienda, videojuego, existencias);
                                lista.Add(entidad); // Agrega la entidad a la lista
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al obtener videojuegos por tienda: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }

            return lista; // Retorna la lista de videojuegos por tienda
        }

        public string Crear(VideojuegoEntidad videojuego) // Metodo para crear un nuevo videojuego
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                                 // Quita la columna Id del INSERT para que el valor se asigne automaticamente
                    string sql = @"
                        INSERT INTO Videojuego 
                        (Nombre, Desarrollador, Lanzamiento, Fisico, Id_TipoVideojuego)
                        VALUES 
                        (@Nombre, @Desarrollador, @Lanzamiento, @Fisico, @Id_TipoVideojuego)"; // Define la consulta SQL para insertar un nuevo videojuego

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Nombre", videojuego.Nombre);
                        cmd.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador);
                        cmd.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento);
                        cmd.Parameters.AddWithValue("@Fisico", videojuego.Fisico);
                        cmd.Parameters.AddWithValue("@Id_TipoVideojuego", videojuego.Id_TipoVideojuego);

                        cmd.ExecuteNonQuery(); // Ejecuta el comando SQL
                    }
                }
                return "Videojuego insertado correctamente."; // Retorna un mensaje de exito
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return "Error al insertar videojuego: " + ex.Message; // Retorna un mensaje de error
            }
        }

        // Fixing the conversion issue by explicitly casting decimal to int
        public List<VideojuegoEntidad> ObtenerVideojuegos() // Metodo para obtener todos los videojuegos
        {
            List<VideojuegoEntidad> lista = new List<VideojuegoEntidad>(); // Crea una nueva lista de VideojuegoEntidad

            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"SELECT Id, 
                        Nombre, 
                        Desarrollador, 
                        Lanzamiento, 
                        Fisico, 
                        Id_TipoVideojuego 
                        FROM Videojuego"; // Define la consulta SQL para obtener todos los videojuegos

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        using (var dr = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                        {
                            while (dr.Read()) // Lee los datos del lector
                            {
                                VideojuegoEntidad videojuego = new VideojuegoEntidad // Crea una nueva instancia de VideojuegoEntidad
                                {
                                    Id = (int)dr.GetDecimal(0),
                                    Nombre = dr.GetString(1),
                                    Desarrollador = dr.GetString(2),
                                    Lanzamiento = (int)dr.GetDecimal(3),
                                    Fisico = dr.GetBoolean(4),
                                    Id_TipoVideojuego = (int)dr.GetDecimal(5)
                                };

                                lista.Add(videojuego); // Agrega el videojuego a la lista
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                // Puedes registrar el error o manejarlo de otra forma
                throw new Exception("Error al obtener videojuegos: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }

            return lista; // Retorna la lista de videojuegos
        }

        public bool Eliminar(int id) // Metodo para eliminar un videojuego
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = "DELETE FROM Videojuego WHERE Id=@Id"; // Define la consulta SQL para eliminar un videojuego

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        cmd.Parameters.AddWithValue("@Id", id); // Agrega el parametro al comando SQL
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta el comando SQL y obtiene el numero de filas afectadas
                        return rowsAffected > 0; // Retorna true si se afectaron filas, de lo contrario false
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                // Manejar la excepcion segun corresponda
                throw new Exception("Error al eliminar videojuego: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }

        public bool Actualizar(VideojuegoEntidad videojuego) // Metodo para actualizar un videojuego
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @" 
                        UPDATE Videojuego 
                        SET Nombre=@Nombre, Desarrollador=@Desarrollador, 
                        Lanzamiento=@Lanzamiento, Fisico=@Fisico, Id_TipoVideojuego=@Id_TipoVideojuego
                        WHERE Id=@Id"; // Define la consulta SQL para actualizar un videojuego

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Id", videojuego.Id);
                        cmd.Parameters.AddWithValue("@Nombre", videojuego.Nombre);
                        cmd.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador);
                        cmd.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento);
                        cmd.Parameters.AddWithValue("@Fisico", videojuego.Fisico);
                        cmd.Parameters.AddWithValue("@Id_TipoVideojuego", videojuego.Id_TipoVideojuego);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta el comando SQL y obtiene el numero de filas afectadas
                        return rowsAffected > 0; // Retorna true si se afectaron filas, de lo contrario false
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al actualizar videojuego: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
