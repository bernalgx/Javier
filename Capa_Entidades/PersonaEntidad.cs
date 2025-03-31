namespace Capa_Entidades
{
    public class PersonaEntidad
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; } 
        public string PrimerApellido { get; set; } 
        public string SegundoApellido { get; set; } 
        public DateTime FechaNacimiento { get; set; }

        public PersonaEntidad(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
