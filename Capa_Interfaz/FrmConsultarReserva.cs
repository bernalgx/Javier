using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Capa_Entidades;
using System.Runtime.CompilerServices;

namespace Capa_Interfaz
{
	public partial class FrmConsultarReserva : Form
	{
		private LogicaReserva logicaReserva = new LogicaReserva();
		// Se asume que el cliente autenticado tiene este ID (en un escenario real se obtiene dinámicamente)
		private int clienteId = 1;

		public FrmConsultarReserva()
		{
			InitializeComponent();

		}




		// Consulta todas las reservas del cliente
		private void btnVerTodas_Click(object sender, EventArgs e)
		{
			try
			{
				List<ReservaEntidad> reservas = logicaReserva.ObtenerReservasPorCliente(clienteId);
				// Proyección para mostrar solo los campos deseados en el DataGridView
				dgvReservas.DataSource = reservas.Select(r => new
				{
					r.IdReserva,
					Tienda = r.VideojuegoTienda.Tienda.Nombre,
					Videojuego = r.VideojuegoTienda.Videojuego.Nombre,
					FechaReserva = r.FechaReserva.ToShortDateString(),
					r.Cantidad
				}).ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al consultar las reservas: " + ex.Message);
			}
		}

		// Consulta una reserva específica por ID


		private void btnBuscarPorId_Click_1(object sender, EventArgs e)
		{

		}

		private void btnBuscarPorId_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtIdReserva.Text))
			{
				MessageBox.Show("Ingrese el ID de la reserva.");
				return;
			}

			if (!int.TryParse(txtIdReserva.Text, out int idReserva))
			{
				MessageBox.Show("El ID de la reserva debe ser numérico.");
				return;
			}

			try
			{
				var reservas = logicaReserva.ObtenerReservaPorId(clienteId, idReserva);

				if (reservas == null || reservas.Count == 0)
				{
					MessageBox.Show("No se encontró la reserva con el ID proporcionado.");
					dgvReservas.DataSource = null; // Limpiar DataGridView
					return;
				}

				dgvReservas.DataSource = reservas.Select(r => new
				{
					r.IdReserva,
					Tienda = r.VideojuegoTienda?.Tienda?.Nombre ?? "Desconocida",
					Videojuego = r.VideojuegoTienda?.Videojuego?.Nombre ?? "Desconocido",
					FechaReserva = r.FechaReserva.ToShortDateString(),
					r.Cantidad
				}).ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al consultar la reserva: " + ex.Message);
			}
		}
	}
}
