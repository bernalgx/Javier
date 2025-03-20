namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public class AdministradorEntidad : PersonaEntidad // Clase que representa a un administrador, hereda de PersonaEntidad
    {
        public DateTime FechaContratacion { get; set; } // Propiedad para almacenar la fecha de contratacion del administrador

     // Constructor que obliga a iniciar todas las propiedades heredadas
        public AdministradorEntidad(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaContratacion)
            : base(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento)
        {
            FechaContratacion = fechaContratacion;
        }
    }
}
