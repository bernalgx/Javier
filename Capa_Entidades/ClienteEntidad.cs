//TODO NUEVO /////////////////////


using System;

namespace Capa_Entidades
{
    public class ClienteEntidad
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool JugadorEnLinea { get; set; }

        // Propiedad para mostrar nombre completo
        public string NombreCompleto => $"{Nombre} {PrimerApellido} {SegundoApellido}";
    }
}
