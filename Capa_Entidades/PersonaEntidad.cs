namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    // Clase base para administradores y clientes
    public class PersonaEntidad
    {
        // Identificacion unica de la persona
        public int Identificacion { get; set; }

        // Nombre de la persona
        public required string Nombre { get; set; }

        // Primer apellido de la persona
        public required string PrimerApellido { get; set; }

        // Segundo apellido de la persona
        public required string SegundoApellido { get; set; }

        // Fecha de nacimiento
        public DateTime FechaNacimiento { get; set; }
    }
}
