using System.Collections.Generic;
using Capa_Entidades;

public class LogicaReserva
{
	private DatosReserva datosReserva;

	public LogicaReserva()
	{
		datosReserva = new DatosReserva();
	}

	// Retorna todas las reservas del cliente
	public List<ReservaEntidad> ObtenerReservasPorCliente(int clienteId)
	{
		return datosReserva.ConsultarReservasPorCliente(clienteId);
	}

	// Retorna la reserva específica del cliente por ID
	public List<ReservaEntidad> ObtenerReservaPorId(int clienteId, int idReserva)
	{
		return datosReserva.ConsultarReservaPorId(clienteId, idReserva);
	}

	// Método para crear una reserva a través de la capa de acceso a datos
	public string CrearReserva(ReservaEntidad reserva)
	{
		return datosReserva.CrearReserva(reserva);
	}
}
