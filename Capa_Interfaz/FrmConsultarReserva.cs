// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Capa_Entidades;
using System.Runtime.CompilerServices;

namespace Capa_Interfaz
{
    public partial class FrmConsultarReserva : Form // Define la clase FrmConsultarReserva que hereda de Form
    {
        private LogicaReserva logicaReserva = new LogicaReserva(); // Declara una variable privada de tipo LogicaReserva e inicializa una nueva instancia
                                                                   // Se asume que el cliente autenticado tiene este ID (en un escenario real se obtiene dinamicamente)
        private int clienteId = 1; // Declara una variable privada para almacenar el ID del cliente autenticado

        public FrmConsultarReserva() // Constructor de la clase FrmConsultarReserva
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        // Consulta todas las reservas del cliente
        private void btnVerTodas_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Ver Todas
        {
            try
            {
                List<ReservaEntidad> reservas = logicaReserva.ObtenerReservasPorCliente(clienteId); // Obtiene la lista de reservas del cliente desde la logica de negocio
                                                                                                    // Proyeccion para mostrar solo los campos deseados en el DataGridView
                dgvReservas.DataSource = reservas.Select(r => new
                {
                    r.IdReserva,
                    Tienda = r.VideojuegoTienda.Tienda.Nombre,
                    Videojuego = r.VideojuegoTienda.Videojuego.Nombre,
                    FechaReserva = r.FechaReserva.ToShortDateString(),
                    r.Cantidad
                }).ToList(); // Asigna la lista proyectada al DataSource del DataGridView
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al consultar las reservas: " + ex.Message); // Muestra un mensaje de error
            }
        }

        // Consulta una reserva especifica por ID
        private void btnBuscarPorId_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Buscar Por ID
        {
            if (string.IsNullOrEmpty(txtIdReserva.Text)) // Verifica si el campo txtIdReserva esta vacio
            {
                MessageBox.Show("Ingrese el ID de la reserva."); // Muestra un mensaje si el campo esta vacio
                return; // Sale del metodo
            }

            if (!int.TryParse(txtIdReserva.Text, out int idReserva)) // Verifica si el valor del campo txtIdReserva es numerico
            {
                MessageBox.Show("El ID de la reserva debe ser numerico."); // Muestra un mensaje si el valor no es numerico
                return; // Sale del metodo
            }

            try
            {
                var reservas = logicaReserva.ObtenerReservaPorId(clienteId, idReserva); // Obtiene la lista de reservas por ID desde la logica de negocio

                if (reservas == null || reservas.Count == 0) // Verifica si no se encontraron reservas
                {
                    MessageBox.Show("No se encontro la reserva con el ID proporcionado."); // Muestra un mensaje si no se encontraron reservas
                    dgvReservas.DataSource = null; // Limpiar DataGridView
                    return; // Sale del metodo
                }

                dgvReservas.DataSource = reservas.Select(r => new
                {
                    r.IdReserva,
                    Tienda = r.VideojuegoTienda?.Tienda?.Nombre ?? "Desconocida",
                    Videojuego = r.VideojuegoTienda?.Videojuego?.Nombre ?? "Desconocido",
                    FechaReserva = r.FechaReserva.ToShortDateString(),
                    r.Cantidad
                }).ToList(); // Asigna la lista proyectada al DataSource del DataGridView
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al consultar la reserva: " + ex.Message); // Muestra un mensaje de error
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)