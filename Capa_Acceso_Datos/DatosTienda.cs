//AQUI TODO ES NUEVO////////////////


using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
    public class DatosTienda
    {
        private readonly ConexionBD _conexion;

        public DatosTienda()
        {
            _conexion = new ConexionBD();
        }

        public string Crear(TiendaEntidad tienda)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    INSERT INTO Tienda 
                    (Nombre, Direccion, Telefono, Activa, AdministradorId)
                    VALUES 
                    (@Nombre, @Direccion, @Telefono, @Activa, @AdministradorId)";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", tienda.Nombre);
                        cmd.Parameters.AddWithValue("@Direccion", tienda.Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", tienda.Telefono);
                        cmd.Parameters.AddWithValue("@Activa", tienda.Activa);
                        cmd.Parameters.AddWithValue("@AdministradorId", tienda.AdministradorId);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "Tienda insertada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar tienda: " + ex.Message;
            }
        }

        public List<TiendaEntidad> ObtenerTiendas()
        {
            List<TiendaEntidad> lista = new List<TiendaEntidad>();

            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    SELECT 
                    t.Id, 
                    t.Nombre, 
                    t.Direccion, 
                    t.Telefono, 
                    t.Activa, 
                    t.AdministradorId,
                    a.Nombre + ' ' + a.PrimerApellido + ' ' + a.SegundoApellido AS NombreAdministrador
                    FROM Tienda t
                    INNER JOIN Administrador a ON t.AdministradorId = a.Identificacion";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                TiendaEntidad tienda = new TiendaEntidad
                                {
                                    Id = dr.GetInt32(0),
                                    Nombre = dr.GetString(1),
                                    Direccion = dr.GetString(2),
                                    Telefono = dr.GetString(3),
                                    Activa = dr.GetBoolean(4),
                                    AdministradorId = dr.GetInt32(5),
                                    NombreAdministrador = dr.GetString(6)
                                };

                                lista.Add(tienda);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener tiendas: " + ex.Message);
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
                    string sql = "DELETE FROM Tienda WHERE Id=@Id";

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
                throw new Exception("Error al eliminar tienda: " + ex.Message);
            }
        }

        public bool Actualizar(TiendaEntidad tienda)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    UPDATE Tienda 
                    SET Nombre=@Nombre, Direccion=@Direccion, 
                    Telefono=@Telefono, Activa=@Activa, AdministradorId=@AdministradorId
                    WHERE Id=@Id";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", tienda.Id);
                        cmd.Parameters.AddWithValue("@Nombre", tienda.Nombre);
                        cmd.Parameters.AddWithValue("@Direccion", tienda.Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", tienda.Telefono);
                        cmd.Parameters.AddWithValue("@Activa", tienda.Activa);
                        cmd.Parameters.AddWithValue("@AdministradorId", tienda.AdministradorId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar tienda: " + ex.Message);
            }
        }
    }
}


