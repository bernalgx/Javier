namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public class AdministradorEntidad : PersonaEntidad // Clase que representa a un administrador, hereda de PersonaEntidad
    {
        public DateTime FechaContratacion { get; set; } // Propiedad para almacenar la fecha de contratacion del administrador
    }
}
