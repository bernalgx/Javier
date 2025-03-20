// AQUI TODO ES NUEVO/////////////////////////////////


//using System;
//using Microsoft.Data.SqlClient;
//using Capa_Acceso_Datos;
//using Capa_Entidades;

//namespace Capa_Acceso_Datos
//{
//    public class DatosAdministrador
//    {
//        private readonly ConexionBD _conexion;

//        public DatosAdministrador()
//        {
//            _conexion = new ConexionBD();
//        }

//        public string Crear(AdministradorEntidad administrador)
//        {
//            try
//            {
//                using (var conn = _conexion.ObtenerConexion())
//                {
//                    conn.Open();

//                    string sql = @"
//                    INSERT INTO Administrador 
//                    (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion)
//                    VALUES 
//                    (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @FechaContratacion)";

//                    using (var cmd = new SqlCommand(sql, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@Identificacion", administrador.Identificacion);
//                        cmd.Parameters.AddWithValue("@Nombre", administrador.Nombre);
//                        cmd.Parameters.AddWithValue("@PrimerApellido", administrador.PrimerApellido);
//                        cmd.Parameters.AddWithValue("@SegundoApellido", administrador.SegundoApellido);
//                       cmd.Parameters.AddWithValue("@FechaNacimiento", administrador.FechaNacimiento);
//                        cmd.Parameters.AddWithValue("@FechaContratacion", administrador.FechaContratacion);

//                        cmd.ExecuteNonQuery();
//                    }
//                }
//                return "Administrador insertado correctamente.";
//            }
//           catch (Exception ex)
//            {
//                return "Error al insertar administrador: " + ex.Message;
//            }
//        }
//   }
//}
