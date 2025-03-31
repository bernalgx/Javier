using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
    public class DatosTipoVideojuego
    {
        private readonly ConexionBD _conexion;

        public DatosTipoVideojuego()
        {
            _conexion = new ConexionBD();
        }

        public string Crear(TipoVideojuegoEntidad tipoVideojuego)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = "INSERT INTO TipoVideojuego (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", tipoVideojuego.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", tipoVideojuego.Descripcion);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Tipo de videojuego registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al registrar tipo de videojuego: " + ex.Message;
            }
        }

        public List<TipoVideojuegoEntidad> ObtenerTodos()
        {
            var lista = new List<TipoVideojuegoEntidad>();

            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = "SELECT Id, Nombre, Descripcion FROM TipoVideojuego";

                    using (var cmd = new SqlCommand(sql, conn))
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new TipoVideojuegoEntidad
                            {
                                Id = dr.GetInt32(0),
                                Nombre = dr.GetString(1),
                                Descripcion = dr.GetString(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener tipos de videojuegos: " + ex.Message);
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
                    string sql = "DELETE FROM TipoVideojuego WHERE Id = @Id";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar tipo de videojuego: " + ex.Message);
            }
        }

        public bool Actualizar(TipoVideojuegoEntidad tipoVideojuego)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"UPDATE TipoVideojuego 
                                 SET Nombre = @Nombre, Descripcion = @Descripcion
                                 WHERE Id = @Id";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", tipoVideojuego.Id);
                        cmd.Parameters.AddWithValue("@Nombre", tipoVideojuego.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", tipoVideojuego.Descripcion);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar tipo de videojuego: " + ex.Message);
            }
        }
    }
}
