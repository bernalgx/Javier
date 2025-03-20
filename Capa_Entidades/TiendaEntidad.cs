
namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public class TiendaEntidad // Clase que representa una tienda en el sistema, con acceso interno
    {
        public int Id { get; set; } // Identificador unico de la tienda
        public string Nombre { get; set; } = string.Empty; // Nombre de la tienda
        public AdministradorEntidad Administrador { get; set; } // Administrador de la tienda (relacion con AdministradorEntidad)
        public string Direccion { get; set; } = string.Empty;// Direccion de la tienda
        public string Telefono { get; set; } = string.Empty; // Numero de telefono de la tienda
        public bool Activa { get; set; }  // Muestra si la tienda esta activa (true) o cerrada (false)

        public static void AgregarTienda(TiendaEntidad nuevaTienda)
        {
            throw new NotImplementedException();
        }
    }
}
