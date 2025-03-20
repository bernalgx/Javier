//TODO NUEVO /////////////////////


namespace Capa_Entidades
{
    public class ClienteEntidad : PersonaEntidad
    {
        public bool JugadorEnLinea { get; set; }

        // Constructor que obliga a inicializar todas las propiedades heredadas
        public ClienteEntidad(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, bool jugadorEnLinea)
            : base(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento)
        {
            JugadorEnLinea = jugadorEnLinea;
        }
    }
}
