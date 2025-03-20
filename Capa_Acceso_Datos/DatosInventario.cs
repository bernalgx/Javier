///TODO NUEVO///////////////////////


//using System;
//using Microsoft.Data.SqlClient;
//using Capa_Acceso_Datos;

//namespace Capa_Acceso_Datos
//{
//    public class DatosInventario
//    {
//        private readonly ConexionBD _conexion;

//        public DatosInventario()
//        {
//            _conexion = new ConexionBD();
//        }

//        public string Crear(VideojuegosXTiendaEntidad inventario)
//        {
//            try
//            {
//                using (var conn = _conexion.ObtenerConexion())
//                {
//                    conn.Open();

//                    string sql = @"
//                    INSERT INTO Inventario 
//                    (TiendaId, VideojuegoId, Existencias)
//                    VALUES 
//                    (@TiendaId, @VideojuegoId, @Existencias)";

//                    using (var cmd = new SqlCommand(sql, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@TiendaId", inventario.Tienda.Id);
//                        cmd.Parameters.AddWithValue("@VideojuegoId", inventario.Videojuego.Id);
//                        cmd.Parameters.AddWithValue("@Existencias", inventario.Existencias);

//                        cmd.ExecuteNonQuery();
//                    }
//                }
//                return "Inventario registrado correctamente.";
//            }
//            catch (Exception ex)
//            {
//                return "Error al insertar inventario: " + ex.Message;
//            }
//       }
//    }
//}
