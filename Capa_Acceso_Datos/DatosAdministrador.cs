//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using Capa_Entidades;


//namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
//{
//    // Clase para realizar operaciones en la base de datos relacionadas con los administradores
//    public class DatosAdministrador
//    {
//        private ConexionBD conexion = new ConexionBD();

//        // Metodo para insertar un nuevo administrador en la base de datos
//        public bool AgregarAdministrador(AdministradorEntidad administrador)
//        {
//            using (SqlConnection con = conexion.ObtenerConexion())
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

//                try
//                {
//                    con.Open();
//                    int filasAfectadas = cmd.ExecuteNonQuery();
//                    return filasAfectadas > 0;
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Error al agregar administrador: " + ex.Message);
//                    return false;
//                }
//            }
//        }
//    }
//}
