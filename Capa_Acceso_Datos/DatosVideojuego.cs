using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient; // O System.Data.SqlClient
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
    public class DatosVideojuego
    {
        private readonly ConexionBD _conexion;

        // Recibimos la instancia de la conexión en el constructor
        public DatosVideojuego()
        {
            _conexion = new ConexionBD();
        }



        public string Crear(VideojuegoEntidad videojuego)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    // Quita la columna Id del INSERT para que el valor se asigne automáticamente

                    string sql = @"
					INSERT INTO Videojuego 
					(Nombre, Desarrollador, Lanzamiento, Fisico, TipoVideojuegoId)
					VALUES 
					(@Nombre, @Desarrollador, @Lanzamiento, @Fisico, @TipoVideojuegoId)";

                    using (var cmd = new SqlCommand(sql, conn))
                    {

                        //cmd.Parameters.AddWithValue("@Nombre", "metalgear");
                        //cmd.Parameters.AddWithValue("@Desarrollador", "Konami");
                        //cmd.Parameters.AddWithValue("@Lanzamiento", 1995);
                        //cmd.Parameters.AddWithValue("@Fisico", 1);
                        //cmd.Parameters.AddWithValue("@TipoVideojuegoId", 1);

                        cmd.Parameters.AddWithValue("@Nombre", videojuego.Nombre);
                        cmd.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador);
                        cmd.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento);
                        cmd.Parameters.AddWithValue("@Fisico", videojuego.Fisico);
                        cmd.Parameters.AddWithValue("@TipoVideojuegoId", videojuego.TipoVideojuegoId);

                        cmd.ExecuteNonQuery();
                    }

                }
                return "Videojuego insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar videojuego: " + ex.Message;
            }
        }
        public List<VideojuegoEntidad> ObtenerVideojuegos()
        {
            List<VideojuegoEntidad> lista = new List<VideojuegoEntidad>();

            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    SELECT 
                    Id, 
                    Nombre, 
                    Desarrollador, 
                    Lanzamiento, 
                    Fisico, 
                    TipoVideojuegoId 
                    FROM Videojuego";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                VideojuegoEntidad videojuego = new VideojuegoEntidad
                                {
                                    // Asume que la columna Id es de tipo entero
                                    Id = dr.GetInt32(0),
                                    // Nombre y Desarrollador son cadenas de texto
                                    Nombre = dr.GetString(1),
                                    Desarrollador = dr.GetString(2),
                                    // Lanzamiento puede ser un entero (o DateTime, según tu diseño)
                                    Lanzamiento = dr.GetInt32(3),
                                    // Fisico es un entero o booleano, según tu modelo (ajusta si es necesario)
                                    Fisico = dr.GetBoolean(4),
                                    // TipoVideojuegoId es entero
                                    TipoVideojuegoId = dr.GetInt32(5)
                                };

                                lista.Add(videojuego);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Puedes registrar el error o manejarlo de otra forma
                throw new Exception("Error al obtener videojuegos: " + ex.Message);
            }

            return lista;
        }


        public bool Eliminar(int id)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = "DELETE FROM Videojuego WHERE Id=@Id";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según corresponda
                throw new Exception("Error al eliminar videojuego: " + ex.Message);
            }
        }

        public bool Actualizar(VideojuegoEntidad videojuego)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    UPDATE Videojuego 
                    SET Nombre=@Nombre, Desarrollador=@Desarrollador, 
                    Lanzamiento=@Lanzamiento, Fisico=@Fisico, TipoVideojuegoId=@TipoVideojuegoId
                    WHERE Id=@Id";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", videojuego.Id);
                        cmd.Parameters.AddWithValue("@Nombre", videojuego.Nombre);
                        cmd.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador);
                        cmd.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento);
                        cmd.Parameters.AddWithValue("@Fisico", videojuego.Fisico);
                        cmd.Parameters.AddWithValue("@TipoVideojuegoId", videojuego.TipoVideojuegoId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar videojuego: " + ex.Message);
            }
        }
    }
}

