namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
{
    public class AdministradorEntidad // Clase que representa una entidad de administrador
    {
        public object Identificacion { get; internal set; } // Propiedad para almacenar la identificación (lectura publica, escritura interna)

        public AdministradorEntidad(object identificacion) // Constructor que recibe la identificaciin
        {
            Identificacion = identificacion; // Le da el valor recibido a la propiedad Identificacion
        }
    }
}