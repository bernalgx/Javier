//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using Capa_Entidades;


//namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
//{
//    // Clase para manejar los clientes en la base de datos
//    public class DatosCliente
//    {
//        private ConexionBD conexion = new ConexionBD();

//        // Metodo para insertar un nuevo cliente
//        public bool AgregarCliente(ClienteEntidad cliente)
//        {
//            using (SqlConnection con = conexion.ObtenerConexion())
//            {
//                string query = "INSERT INTO Cliente (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, JugadorEnLinea) " +
//                               "VALUES (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @JugadorEnLinea)";

//                SqlCommand cmd = new SqlCommand(query, con);
//                cmd.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
//                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
//                cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
//                cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
//                cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
//                cmd.Parameters.AddWithValue("@JugadorEnLinea", cliente.JugadorEnLinea);

//                try
//                {
//                    con.Open();
//                    int filasAfectadas = cmd.ExecuteNonQuery();
//                    return filasAfectadas > 0;
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Error al agregar cliente: " + ex.Message);
//                    return false;
//                }
//            }
//        }
//    }
//}
