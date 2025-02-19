//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using Capa_Entidades;


//namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
//{
    // Clase para realizar operaciones con los administradores en la base de datos
//    public class DatosAdministrador
//    {
//        private ConexionBD conexion = new ConexionBD();

        // Metodo para verificar si un administrador ya existe en la base de datos
//        private bool AdministradorExiste(int identificacion)
//        {
//            using (SqlConnection con = conexion.ObtenerConexion())
//            {
//                string query = "SELECT COUNT(*) FROM Administrador WHERE Identificacion = @Identificacion";
//                SqlCommand cmd = new SqlCommand(query, con);
//                cmd.Parameters.AddWithValue("@Identificacion", identificacion);

//                try
//               {
//                   con.Open();
//                    int count = (int)cmd.ExecuteScalar();
//                    return count > 0;
//                }
//                catch (Exception ex)
//                {
//                   Console.WriteLine("Error al verificar administrador: " + ex.Message);
//                   return true; // Si hay error, asumimos que ya existe para evitar problemas
//                }
//            }
//        }

        // Metodo para insertar un nuevo administrador en la base de datos
//        public bool AgregarAdministrador(AdministradorEntidad administrador)
//        {
//            if (AdministradorExiste(administrador.Identificacion))
//            {
//                Console.WriteLine("El administrador con esta identificación ya existe.");
//                return false;
//            }

//           using (SqlConnection con = conexion.ObtenerConexion())
//            {
//                string query = "INSERT INTO Administrador (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion) " +
//                               "VALUES (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @FechaContratacion)";

//                SqlCommand cmd = new SqlCommand(query, con);
//                cmd.Parameters.AddWithValue("@Identificacion", administrador.Identificacion);
//                cmd.Parameters.AddWithValue("@Nombre", administrador.Nombre);
//                cmd.Parameters.AddWithValue("@PrimerApellido", administrador.PrimerApellido);
//                cmd.Parameters.AddWithValue("@SegundoApellido", administrador.SegundoApellido);
//                cmd.Parameters.AddWithValue("@FechaNacimiento", administrador.FechaNacimiento);
//                cmd.Parameters.AddWithValue("@FechaContratacion", administrador.FechaContratacion);

//               try
//                {
//                    con.Open();
//                    int filasAfectadas = cmd.ExecuteNonQuery();
//                    return filasAfectadas > 0;
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Error al agregar administrador: " + ex.Message);
 //                   return false;
 //               }
 //           }
//        }
//    }
//}
