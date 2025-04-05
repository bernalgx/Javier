// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================


using System;
using Microsoft.Data.SqlClient;
using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
    public class DatosInventario // Define la clase DatosInventario
    {
        private readonly ConexionBD _conexion; // Declara una variable privada y de solo lectura de tipo ConexionBD

        public DatosInventario() // Constructor de la clase DatosInventario
        {
            _conexion = new ConexionBD(); // Inicializa la variable _conexion con una nueva instancia de ConexionBD
        }

        public List<InventarioConsultaEntidad> ObtenerInventario() // Metodo para obtener el inventario
        {
            List<InventarioConsultaEntidad> lista = new List<InventarioConsultaEntidad>(); // Crea una nueva lista de InventarioConsultaEntidad

            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion

                    string sql = @"SELECT 
                            T.[Id] AS Id_Tienda, 
                            T.[Nombre] AS TiendaNombre, 
                            T.[Direccion] AS TiendaDireccion, 
                            V.[Id] AS Id_Videojuego, 
                            V.[Nombre] AS VideojuegoNombre, 
                            TV.[Nombre] AS TipoVideojuegoNombre, 
                            VT.[Existencias] 
                          FROM [VideojuegosXTienda] VT 
                          JOIN [Tienda] T ON VT.[Id_Tienda] = T.[Id] 
                          JOIN [Videojuego] V ON VT.[Id_Videojuego] = V.[Id] 
                          JOIN [TipoVideojuego] TV ON V.[Id_TipoVideojuego] = TV.[Id]"; // Define la consulta SQL para obtener el inventario

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        using (var dr = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                        {
                            while (dr.Read()) // Lee los datos del lector
                            {
                                InventarioConsultaEntidad item = new InventarioConsultaEntidad // Crea una nueva instancia de InventarioConsultaEntidad
                                {
                                    Id_Tienda = Convert.ToInt32(dr["Id_Tienda"]),
                                    TiendaNombre = dr["TiendaNombre"].ToString(),
                                    TiendaDireccion = dr["TiendaDireccion"].ToString(),
                                    Id_VideoJuego = Convert.ToDecimal(dr["Id_Videojuego"]),
                                    VideojuegoNombre = dr["VideojuegoNombre"].ToString(),
                                    TipoVideojuegoNombre = dr["TipoVideojuegoNombre"].ToString(),
                                    Existencias = Convert.ToInt32(dr["Existencias"])
                                };
                                lista.Add(item); // Agrega el item a la lista
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al obtener inventario: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }

            return lista; // Retorna la lista de inventario
        }

        public string Crear(VideojuegosXTiendaEntidad nuevoRegistro) // Metodo para crear un nuevo registro en el inventario
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"INSERT INTO VideojuegosXTienda (Id_Tienda, Id_Videojuego, Existencias) VALUES (@Id_Tienda, @Id_Videojuego, @Existencias)"; // Define la consulta SQL para insertar un nuevo registro

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Id_Tienda", nuevoRegistro.Tienda.Id);
                        cmd.Parameters.AddWithValue("@Id_Videojuego", nuevoRegistro.Videojuego.Id);
                        cmd.Parameters.AddWithValue("@Existencias", nuevoRegistro.Existencias);

                        int filasAfectadas = cmd.ExecuteNonQuery(); // Ejecuta el comando SQL y obtiene el numero de filas afectadas
                        if (filasAfectadas > 0) // Verifica si se afectaron filas
                        {
                            return "Registro creado correctamente."; // Retorna un mensaje de exito
                        }
                        else
                        {
                            return "No se pudo crear el registro."; // Retorna un mensaje de error
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return ("Error al crear el registro: "  + ex.Message); // Retorna un mensaje de error
            }
        }

        public List<InventarioConsultaEntidad> ObtenerInventarioPorTienda(int Id_Tienda) // Metodo para obtener el inventario por tienda
        {
            List<InventarioConsultaEntidad> lista = new List<InventarioConsultaEntidad>(); // Crea una nueva lista de InventarioConsultaEntidad

            try
            {
                using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
                {
                    conn.Open(); // Abre la conexion
                    string sql = @"SELECT T.Id, T.Nombre, T.Direccion, 
                            V.Id, V.Nombre, TV.Nombre, VT.Existencias
                            FROM VideojuegosXTienda VT
                            JOIN Tienda T ON VT.Id_Tienda = T.Id
                            JOIN Videojuego V ON VT.Id_Videojuego = V.Id
                            JOIN TipoVideojuego TV ON V.Id_TipoVideojuego = TV.Id
                            WHERE T.Id = @Id_Tienda AND VT.Existencias > 0"; // Define la consulta SQL para obtener el inventario por tienda

                    using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
                    {
                        cmd.Parameters.AddWithValue("@Id_Tienda", Id_Tienda); // Agrega el parametro al comando SQL
                        using (var dr = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                        {
                            while (dr.Read()) // Lee los datos del lector
                            {
                                InventarioConsultaEntidad item = new InventarioConsultaEntidad // Crea una nueva instancia de InventarioConsultaEntidad
                                {
                                    Id_Tienda = Convert.ToInt32(dr[0]),
                                    TiendaNombre = dr[1].ToString(),
                                    TiendaDireccion = dr[2].ToString(),
                                    Id_VideoJuego = Convert.ToDecimal(dr[3]),
                                    VideojuegoNombre = dr[4].ToString(),
                                    TipoVideojuegoNombre = dr[5].ToString(),
                                    Existencias = Convert.ToInt32(dr[6])
                                };
                                lista.Add(item); // Agrega el item a la lista
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error obteniendo inventario por tienda: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
            return lista; // Retorna la lista de inventario por tienda
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
