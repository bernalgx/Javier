namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public class PersonaEntidad // Clase que representa una persona en el sistema
    {
        public int Identificacion { get; set; } // Propiedad para el ID de la persona
        public string Nombre { get; set; } = string.Empty; // Nombre de la persona, inicializado vacio

        public string PrimerApellido { get; set; } = string.Empty; // Primer apellido, inicializado vacio
        public string SegundoApellido { get; set; } = string.Empty; // Segundo apellido, inicializado vacio
        public DateTime FechaNacimiento { get; set; } // Fecha de nacimiento de la persona
    }
}
