// AQUI TODO ES NUEVO/////////////////////////////////


using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
    public class DatosAdministrador
    {
        private readonly ConexionBD _conexion;

        public DatosAdministrador()
        {
            _conexion = new ConexionBD();
        }

        // Crear un administrador
        public string Crear(AdministradorEntidad administrador)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    INSERT INTO Administrador 
                    (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion)
                    VALUES 
                    (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @FechaContratacion)";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Identificacion", administrador.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", administrador.PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", administrador.SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", administrador.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@FechaContratacion", administrador.FechaContratacion);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "Administrador insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar administrador: " + ex.Message;
            }
        }

        // Obtener todos los administradores
        public List<AdministradorEntidad> ObtenerAdministradores()
        {
            var lista = new List<AdministradorEntidad>();

            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = "SELECT Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion FROM Administrador";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new AdministradorEntidad
                                {
                                    Identificacion = reader.GetInt32(0),
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
            catch (Exception ex)
            {
                throw new Exception("Error al obtener administradores: " + ex.Message);
            }

            return lista;
        }

        // Actualizar un administrador
        public bool Actualizar(AdministradorEntidad administrador)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    UPDATE Administrador 
                    SET Nombre = @Nombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, 
                        FechaNacimiento = @FechaNacimiento, FechaContratacion = @FechaContratacion
                    WHERE Identificacion = @Identificacion";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Identificacion", administrador.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", administrador.PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", administrador.SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", administrador.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@FechaContratacion", administrador.FechaContratacion);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar administrador: " + ex.Message);
            }
        }

        // Eliminar un administrador
        public bool Eliminar(int identificacion)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = "DELETE FROM Administrador WHERE Identificacion = @Identificacion";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Identificacion", identificacion);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar administrador: " + ex.Message);
            }
        }
    }
}
