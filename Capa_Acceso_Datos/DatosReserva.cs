// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Acceso_Datos;
using Capa_Entidades;
using Microsoft.Data.SqlClient;

public class DatosReserva // Define la clase DatosReserva
{
    private readonly ConexionBD _conexion; // Declara una variable privada y de solo lectura de tipo ConexionBD

    public DatosReserva() // Constructor de la clase DatosReserva
    {
        _conexion = new ConexionBD(); // Inicializa la variable _conexion con una nueva instancia de ConexionBD
    }

    public string CrearReserva(ReservaEntidad reserva) // Metodo para crear una nueva reserva
    {
        // Validar que ninguno de los objetos criticos sea nulo
        if (reserva == null)
            throw new ArgumentNullException(nameof(reserva));
        if (reserva.Cliente == null)
            throw new Exception("El cliente en la reserva es nulo.");
        if (reserva.VideojuegoTienda == null)
            throw new Exception("El objeto VideojuegoTienda en la reserva es nulo.");
        if (reserva.VideojuegoTienda.Videojuego == null)
            throw new Exception("El videojuego en la reserva es nulo.");
        if (reserva.VideojuegoTienda.Tienda == null)
            throw new Exception("La tienda en la reserva es nula.");

        using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
        {
            conn.Open(); // Abre la conexion
            using (var transaction = conn.BeginTransaction()) // Inicia una transaccion
            {
                try
                {
                    // 1. Insertar reserva usando los nombres de columna correctos segun el esquema
                    string sqlReserva = @"
        INSERT INTO Reserva (Id_Cliente, Id_Videojuego, Id_Tienda, FechaReserva, Cantidad)
        VALUES (@ClienteId, @VideojuegoId, @TiendaId, @Fecha, @Cantidad)"; // Define la consulta SQL para insertar una nueva reserva

                    using (var cmd = new SqlCommand(sqlReserva, conn, transaction)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@ClienteId", reserva.Cliente.Identificacion);
                        cmd.Parameters.AddWithValue("@VideojuegoId", reserva.VideojuegoTienda.Videojuego.Id);
                        cmd.Parameters.AddWithValue("@TiendaId", reserva.VideojuegoTienda.Tienda.Id);
                        cmd.Parameters.AddWithValue("@Fecha", reserva.FechaReserva);
                        cmd.Parameters.AddWithValue("@Cantidad", reserva.Cantidad);
                        cmd.ExecuteNonQuery(); // Ejecuta el comando SQL
                    }

                    // 2. Actualizar existencias en la tabla VideojuegosXTienda
                    string sqlInventario = @"
        UPDATE VideojuegosXTienda 
        SET Existencias = Existencias - @Cantidad 
        WHERE Id_Tienda = @TiendaId AND Id_Videojuego = @VideojuegoId"; // Define la consulta SQL para actualizar las existencias

                    using (var cmd = new SqlCommand(sqlInventario, conn, transaction)) // Crea un nuevo comando SQL
                    {
                        // Agrega los parametros al comando SQL
                        cmd.Parameters.AddWithValue("@Cantidad", reserva.Cantidad);
                        cmd.Parameters.AddWithValue("@TiendaId", reserva.VideojuegoTienda.Tienda.Id);
                        cmd.Parameters.AddWithValue("@VideojuegoId", reserva.VideojuegoTienda.Videojuego.Id);
                        cmd.ExecuteNonQuery(); // Ejecuta el comando SQL
                    }

                    transaction.Commit(); // Confirma la transaccion
                    return "Reserva realizada exitosamente"; // Retorna un mensaje de exito
                }
                catch (Exception ex) // Captura cualquier excepcion que ocurra
                {
                    transaction.Rollback(); // Revierte la transaccion
                    return "Error al procesar reserva: " + ex.Message; // Retorna un mensaje de error
                }
            }
        }
    }

    // Consulta todas las reservas de un cliente
    public List<ReservaEntidad> ConsultarReservasPorCliente(int clienteId) // Metodo para consultar todas las reservas de un cliente
    {
        List<ReservaEntidad> reservas = new List<ReservaEntidad>(); // Crea una nueva lista de ReservaEntidad

        using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
        {
            conn.Open(); // Abre la conexion
            string sql = @"
            SELECT 
                r.Id AS IdReserva, 
                t.Nombre AS Tienda, 
                v.Nombre AS Videojuego, 
                r.FechaReserva, 
                r.Cantidad 
            FROM Reserva r 
            INNER JOIN Tienda t ON r.Id_Tienda = t.Id 
            INNER JOIN Videojuego v ON r.Id_Videojuego = v.Id 
            WHERE r.Id_Cliente = @clienteId"; // Define la consulta SQL para obtener todas las reservas de un cliente

            using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
            {
                cmd.Parameters.AddWithValue("@clienteId", clienteId); // Agrega el parametro al comando SQL
                using (var reader = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                {
                    while (reader.Read()) // Lee los datos del lector
                    {
                        var reserva = new ReservaEntidad(
                            Convert.ToInt32(reader["IdReserva"]), // Convertir de decimal a int
                            new VideojuegosXTiendaEntidad(
                                new TiendaEntidad { Nombre = reader.GetString(reader.GetOrdinal("Tienda")) },
                                new VideojuegoEntidad { Nombre = reader.GetString(reader.GetOrdinal("Videojuego")) },
                                0 // Existencias no se usa aqui
                            ),
                            null, // ClienteEntidad no es necesario aqui
                            reader.GetDateTime(reader.GetOrdinal("FechaReserva")),
                            Convert.ToInt32(reader["Cantidad"]) // Convertir de decimal a int
                        );
                        reservas.Add(reserva); // Agrega la reserva a la lista
                    }
                }
            }
        }
        return reservas; // Retorna la lista de reservas
    }

    // Consulta una reserva especifica del cliente por ID
    public List<ReservaEntidad> ConsultarReservaPorId(int clienteId, int idReserva) // Metodo para consultar una reserva especifica del cliente por ID
    {
        List<ReservaEntidad> reservas = new List<ReservaEntidad>(); // Crea una nueva lista de ReservaEntidad

        using (var conn = _conexion.ObtenerConexion()) // Obtiene una conexion a la base de datos
        {
            conn.Open(); // Abre la conexion
            string sql = @"
            SELECT 
                r.Id AS IdReserva, 
                t.Nombre AS Tienda, 
                v.Nombre AS Videojuego, 
                r.FechaReserva, 
                r.Cantidad
            FROM Reserva r
            INNER JOIN Tienda t ON r.Id_Tienda = t.Id
            INNER JOIN Videojuego v ON r.Id_Videojuego = v.Id
            WHERE r.Id_Cliente = @clienteId AND r.Id = @idReserva"; // Define la consulta SQL para obtener una reserva especifica del cliente por ID

            using (var cmd = new SqlCommand(sql, conn)) // Crea un nuevo comando SQL
            {
                cmd.Parameters.AddWithValue("@clienteId", clienteId); // Agrega el parametro al comando SQL
                cmd.Parameters.AddWithValue("@idReserva", idReserva); // Agrega el parametro al comando SQL
                using (var reader = cmd.ExecuteReader()) // Ejecuta el comando SQL y obtiene un lector de datos
                {
                    while (reader.Read()) // Lee los datos del lector
                    {
                        var reserva = new ReservaEntidad(
                            Convert.ToInt32(reader["IdReserva"]), // Conversion de decimal a int
                            new VideojuegosXTiendaEntidad(
                                new TiendaEntidad { Nombre = reader.GetString(reader.GetOrdinal("Tienda")) },
                                new VideojuegoEntidad { Nombre = reader.GetString(reader.GetOrdinal("Videojuego")) },
                                0 // Existencias no es relevante para el display
                            ),
                            null, // ClienteEntidad no es necesario en este contexto
                            reader.GetDateTime(reader.GetOrdinal("FechaReserva")),
                            Convert.ToInt32(reader["Cantidad"]) // Conversion de decimal a int
                        );
                        reservas.Add(reserva); // Agrega la reserva a la lista
                    }
                }
            }
        }
        return reservas; // Retorna la lista de reservas
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
