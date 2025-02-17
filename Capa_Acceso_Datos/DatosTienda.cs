//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using Capa_Entidades;


//namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
//{
//    // Clase para gestionar la informacion de las tiendas en la base de datos
//    public class DatosTienda
//    {
//        private ConexionBD conexion = new ConexionBD();

//        // Metodo para insertar una tienda en la base de datos
//        public bool AgregarTienda(TiendaEntidad tienda)
//        {
//            using (SqlConnection con = conexion.ObtenerConexion())
//            {
//                string query = "INSERT INTO Tienda (Nombre, AdministradorId, Direccion, Telefono, Activa) " +
//                               "VALUES (@Nombre, @AdministradorId, @Direccion, @Telefono, @Activa)";

//                SqlCommand cmd = new SqlCommand(query, con);
//                cmd.Parameters.AddWithValue("@Nombre", tienda.Nombre);
//                cmd.Parameters.AddWithValue("@AdministradorId", tienda.Administrador.Identificacion);
//                cmd.Parameters.AddWithValue("@Direccion", tienda.Direccion);
//                cmd.Parameters.AddWithValue("@Telefono", tienda.Telefono);
//                cmd.Parameters.AddWithValue("@Activa", tienda.Activa);

//                try
//                {
//                    con.Open();
//                    int filasAfectadas = cmd.ExecuteNonQuery();
//                    return filasAfectadas > 0;
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Error al agregar tienda: " + ex.Message);
//                    return false;
//                }
//            }
//        }
//    }
//}
