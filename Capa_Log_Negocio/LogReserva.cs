// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System.Collections.Generic;
using Capa_Entidades;

public class LogicaReserva // Define la clase LogicaReserva
{
    private DatosReserva datosReserva; // Declara una variable privada de tipo DatosReserva

    public LogicaReserva() // Constructor de la clase LogicaReserva
    {
        datosReserva = new DatosReserva(); // Inicializa la variable datosReserva con una nueva instancia de DatosReserva
    }

    // Retorna todas las reservas del cliente
    public List<ReservaEntidad> ObtenerReservasPorCliente(int clienteId) // Metodo para obtener todas las reservas de un cliente
    {
        return datosReserva.ConsultarReservasPorCliente(clienteId); // Llama al metodo ConsultarReservasPorCliente de DatosReserva y retorna la lista de reservas
    }

    // Retorna la reserva especifica del cliente por ID
    public List<ReservaEntidad> ObtenerReservaPorId(int clienteId, int idReserva) // Metodo para obtener una reserva especifica del cliente por ID
    {
        return datosReserva.ConsultarReservaPorId(clienteId, idReserva); // Llama al metodo ConsultarReservaPorId de DatosReserva y retorna la lista de reservas
    }

    // Metodo para crear una reserva a traves de la capa de acceso a datos
    public string CrearReserva(ReservaEntidad reserva) // Metodo para crear una nueva reserva
    {
        return datosReserva.CrearReserva(reserva); // Llama al metodo CrearReserva de DatosReserva y retorna el resultado
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
