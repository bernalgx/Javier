//AQUI TODO ES NUEVO//////////////////////////

using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
    public class DatosCliente
    {
        private readonly ConexionBD _conexion;

        public DatosCliente()
        {
            _conexion = new ConexionBD();
        }

        public string Crear(ClienteEntidad cliente)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    INSERT INTO Cliente 
                    (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, JugadorEnLinea)
                    VALUES 
                    (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @JugadorEnLinea)";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@JugadorEnLinea", cliente.JugadorEnLinea);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "Cliente registrado correctamente.";
            }
            catch (SqlException ex) when (ex.Number == 2627) // Violación de clave única
            {
                return "Error: La identificación ya existe.";
            }
            catch (Exception ex)
            {
                return "Error al registrar cliente: " + ex.Message;
            }
        }

        public List<ClienteEntidad> ObtenerClientes()
        {
            List<ClienteEntidad> lista = new List<ClienteEntidad>();

            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    SELECT 
                    Identificacion, 
                    Nombre, 
                    PrimerApellido, 
                    SegundoApellido, 
                    FechaNacimiento, 
                    JugadorEnLinea 
                    FROM Cliente";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ClienteEntidad cliente = new ClienteEntidad
                                {
                                    Identificacion = dr.GetInt32(0),
                                    Nombre = dr.GetString(1),
                                    PrimerApellido = dr.GetString(2),
                                    SegundoApellido = dr.GetString(3),
                                    FechaNacimiento = dr.GetDateTime(4),
                                    JugadorEnLinea = dr.GetBoolean(5)
                                };

                                lista.Add(cliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }

            return lista;
        }

        public bool Eliminar(int identificacion)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = "DELETE FROM Cliente WHERE Identificacion=@Identificacion";

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
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }

        public bool Actualizar(ClienteEntidad cliente)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = @"
                    UPDATE Cliente 
                    SET Nombre=@Nombre, PrimerApellido=@PrimerApellido, 
                    SegundoApellido=@SegundoApellido, FechaNacimiento=@FechaNacimiento, 
                    JugadorEnLinea=@JugadorEnLinea
                    WHERE Identificacion=@Identificacion";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@JugadorEnLinea", cliente.JugadorEnLinea);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }

        public bool ExisteCliente(int identificacion)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM Cliente WHERE Identificacion=@Identificacion";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Identificacion", identificacion);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar cliente: " + ex.Message);
            }
        }
    }
}



