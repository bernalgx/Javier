//TODO NUEVO///////////////////


using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Log_Negocio
{
    public class LogAdministrador
    {
        public string RegistroAdministrador(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaContratacion)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(primerApellido) || string.IsNullOrWhiteSpace(segundoApellido))
                return "Todos los campos son requeridos.";
            if (DateTime.Today.Year - fechaNacimiento.Year < 18)
                return "El administrador debe ser mayor de edad.";
            if (fechaContratacion > DateTime.Today)
                return "La fecha de contratacion no puede ser futura.";

            // Crear objeto administrador
            AdministradorEntidad nuevoAdministrador = new AdministradorEntidad
            {
                Identificacion = identificacion,
                Nombre = nombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                FechaNacimiento = fechaNacimiento,
                FechaContratacion = fechaContratacion
            };

            // Llamar a la capa de acceso a datos
            DatosAdministrador datos = new DatosAdministrador();
            return datos.Crear(nuevoAdministrador);
        }

        public List<AdministradorEntidad> ObtenerAdministradoresDesdeBD()
        {
            DatosAdministrador datos = new DatosAdministrador();
            return datos.ObtenerAdministradores();
        }

        public string EliminarAdministrador(int identificacion)
        {
            try
            {
                DatosAdministrador datos = new DatosAdministrador();
                bool resultado = datos.Eliminar(identificacion);
                return resultado ? "Administrador eliminado correctamente." : "No se pudo eliminar el administrador.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EditarAdministrador(AdministradorEntidad administrador)
        {
            try
            {
                DatosAdministrador datos = new DatosAdministrador();
                bool resultado = datos.Actualizar(administrador);
                return resultado ? "Administrador actualizado correctamente." : "No se pudo actualizar el administrador.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}