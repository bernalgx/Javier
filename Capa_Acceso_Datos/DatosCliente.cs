//AQUI TODO ES NUEVO//////////////////////////

//using System;
//using Microsoft.Data.SqlClient;
//using Capa_Acceso_Datos;
//using Capa_Entidades;

//namespace Capa_Acceso_Datos
//{
//    public class DatosCliente
//    {
//        private readonly ConexionBD _conexion;

//        public DatosCliente()
//        {
//            _conexion = new ConexionBD();
//        }

//        public string Crear(ClienteEntidad cliente)
//        {
//            try
//            {
//                using (var conn = _conexion.ObtenerConexion())
//                {
//                    conn.Open();

//                    string sql = @"
//                    INSERT INTO Cliente 
//                    (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, JugadorEnLinea)
//                    VALUES 
//                    (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @JugadorEnLinea)";

//                    using (var cmd = new SqlCommand(sql, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
//                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
//                        cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
//                        cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
//                        cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
//                        cmd.Parameters.AddWithValue("@JugadorEnLinea", cliente.JugadorEnLinea);

//                        cmd.ExecuteNonQuery();
//                    }
//                }
//                return "Cliente insertado correctamente.";
//            }
//            catch (Exception ex)
//            {
//                return "Error al insertar cliente: " + ex.Message;
//            }
//        }
//    }
//}


