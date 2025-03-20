//AQUI TODO ES NUEVO////////////////


//using System;
//using Microsoft.Data.SqlClient;
//using Capa_Acceso_Datos;
//using Capa_Entidades;

//namespace Capa_Acceso_Datos
//{
//    public class DatosTienda
//    {
//        private readonly ConexionBD _conexion;

//        public DatosTienda()
//        {
//            _conexion = new ConexionBD();
//        }

//        public string Crear(TiendaEntidad tienda)
//        {
//            try
//            {
//                using (var conn = _conexion.ObtenerConexion())
//                {
//                    conn.Open();

//                    string sql = @"
//                    INSERT INTO Tienda 
//                    (Id, Nombre, AdministradorId, Direccion, Telefono, Activa)
//                    VALUES 
//                    (@Id, @Nombre, @AdministradorId, @Direccion, @Telefono, @Activa)";

//                    using (var cmd = new SqlCommand(sql, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@Id", tienda.Id);
//                        cmd.Parameters.AddWithValue("@Nombre", tienda.Nombre);
//                        cmd.Parameters.AddWithValue("@AdministradorId", tienda.Administrador.Identificacion);
//                        cmd.Parameters.AddWithValue("@Direccion", tienda.Direccion);
//                        cmd.Parameters.AddWithValue("@Telefono", tienda.Telefono);
//                        cmd.Parameters.AddWithValue("@Activa", tienda.Activa);

//                        cmd.ExecuteNonQuery();
//                    }
//                }
//                return "Tienda registrada correctamente.";
//            }
//            catch (Exception ex)
//            {
//                return "Error al insertar tienda: " + ex.Message;
//            }
//        }

//        public TiendaEntidad ObtenerPorId(int id)
//        {
//            try
//            {
//                using (var conn = _conexion.ObtenerConexion())
//                {
//                   conn.Open();

//                    string sql = "SELECT Id, Nombre, AdministradorId, Direccion, Telefono, Activa FROM Tienda WHERE Id = @Id";

//                    using (var cmd = new SqlCommand(sql, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@Id", id);

//                        using (SqlDataReader reader = cmd.ExecuteReader())
//                        {
//                            if (reader.Read())
//                            {
//                                return new TiendaEntidad
//                                {
//                                    Id = reader.GetInt32(0),
//                                    Nombre = reader.GetString(1),
//                                    Administrador = new AdministradorEntidad { Identificacion = reader.GetInt32(2) },
//                                    Direccion = reader.GetString(3),
//                                    Telefono = reader.GetString(4),
//                                    Activa = reader.GetBoolean(5)
//                                };
//                           }
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error al obtener tienda: " + ex.Message);
//            }
//            return null;
//        }

//        public List<TiendaEntidad> ObtenerTodas()
 //       {
//            List<TiendaEntidad> tiendas = new List<TiendaEntidad>();

//            try
//            {
//                using (var conn = _conexion.ObtenerConexion())
//                {
//                    conn.Open();

//                    string sql = "SELECT Id, Nombre, AdministradorId, Direccion, Telefono, Activa FROM Tienda";

//                    using (var cmd = new SqlCommand(sql, conn))
//                    {
//                        using (SqlDataReader reader = cmd.ExecuteReader())
//                        {
//                            while (reader.Read())
//                            {
//                                tiendas.Add(new TiendaEntidad
//                                {
//                                    Id = reader.GetInt32(0),
//                                    Nombre = reader.GetString(1),
//                                    Administrador = new AdministradorEntidad { Identificacion = reader.GetInt32(2) },
//                                    Direccion = reader.GetString(3),
//                                    Telefono = reader.GetString(4),
//                                    Activa = reader.GetBoolean(5)
//                                });
//                            }
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error al obtener tiendas: " + ex.Message);
//            }

//            return tiendas;
//        }
//    }
//}
