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
using Microsoft.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
    public class DatosTienda // Define la clase DatosTienda
    {
        private readonly ConexionBD _conexion; // Declara una variable privada y de solo lectura de tipo ConexionBD

        public DatosTienda() // Constructor de la clase DatosTienda
        {
            _conexion = new ConexionBD(); // Inicializa la variable _conexion con una nueva instancia de ConexionBD
        }

        public string Crear(TiendaEntidad tienda) // Metodo para crear una nueva tienda
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"
                        INSERT INTO Tienda 
                        (Nombre, Direccion, Telefono, Activa, Id_Administrador)
                        VALUES 
                        (@Nombre, @Direccion, @Telefono, @Activa, @Id_Administrador)"; // Define la consulta SQL para insertar una nueva tienda

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Nombre", tienda.Nombre);
                        cmd.Parameters.AddWithValue("@Direccion", tienda.Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", tienda.Telefono);
                        cmd.Parameters.AddWithValue("@Activa", tienda.Activa);
                        cmd.Parameters.AddWithValue("@Id_Administrador", tienda.Id_Administrador);

                        cmd.ExecuteNonQuery(); // Ejecuta el comando SQL
                    }
                }
                return "Tienda insertada correctamente."; // Retorna un mensaje de exito
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return "Error al insertar tienda: " + ex.Message; // Retorna un mensaje de error
            }
        }

        public List<TiendaEntidad> ObtenerTiendas() // Metodo para obtener todas las tiendas
        {
            List<TiendaEntidad> lista = new List<TiendaEntidad>(); // Crea una nueva lista de TiendaEntidad

            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"SELECT t.Id, t.Nombre, t.Direccion, t.Telefono, t.Activa, t.Id_Administrador, a.Nombre + ' ' + a.PrimerApellido + ' ' + a.SegundoApellido AS NombreAdministrador FROM Tienda t INNER JOIN Administrador a ON t.Id_Administrador = a.Identificacion"; // Define la consulta SQL para obtener todas las tiendas

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        using (var dr = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                        {
                            while (dr.Read()) // Lee los datos del lector
                            {
                                TiendaEntidad tienda = new TiendaEntidad // Crea una nueva instancia de TiendaEntidad
                                {
                                    Id = Convert.ToInt32(dr.GetDecimal(0)), // Convertir Decimal a Int
                                    Nombre = dr.GetString(1),
                                    Direccion = dr.GetString(2),
                                    Telefono = dr.GetString(3),
                                    Activa = dr.GetBoolean(4),
                                    Id_Administrador = dr.GetDecimal(5),
                                    NombreAdministrador = dr.GetString(6)
                                };

                                lista.Add(tienda); // Agrega la tienda a la lista
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al obtener tiendas: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }

            return lista; // Retorna la lista de tiendas
        }

        public bool Eliminar(int id) // Metodo para eliminar una tienda
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = "DELETE FROM Tienda WHERE Id=@Id"; // Define la consulta SQL para eliminar una tienda

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
                throw new Exception("Error al eliminar tienda: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }

        public bool Actualizar(TiendaEntidad tienda) // Metodo para actualizar una tienda
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"
                        UPDATE Tienda 
                        SET Nombre=@Nombre, Direccion=@Direccion, 
                        Telefono=@Telefono, Activa=@Activa, Id_Administrador=@Id_Administrador
                        WHERE Id=@Id"; // Define la consulta SQL para actualizar una tienda

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Id", tienda.Id);
                        cmd.Parameters.AddWithValue("@Nombre", tienda.Nombre);
                        cmd.Parameters.AddWithValue("@Direccion", tienda.Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", tienda.Telefono);
                        cmd.Parameters.AddWithValue("@Activa", tienda.Activa);
                        cmd.Parameters.AddWithValue("@Id_Administrador", tienda.Id_Administrador);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta el comando SQL y obtiene el numero de filas afectadas
                        return rowsAffected > 0; // Retorna true si se afectaron filas, de lo contrario false
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al actualizar tienda: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)


