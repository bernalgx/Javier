namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public class ClienteEntidad : PersonaEntidad // Clase que representa a un cliente, hereda de PersonaEntidad
    {
        public bool JugadorEnLinea { get; set; } // Propiedad que muestra si el cliente es un jugador en linea
    }
}
