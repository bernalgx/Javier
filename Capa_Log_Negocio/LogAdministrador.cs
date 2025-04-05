// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Log_Negocio
{
    public class LogAdministrador // Define la clase LogAdministrador
    {
        public string RegistroAdministrador(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaContratacion) // Metodo para registrar un administrador
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(primerApellido) || string.IsNullOrWhiteSpace(segundoApellido))
                return "Todos los campos son requeridos."; // Verifica que los campos nombre, primerApellido y segundoApellido no esten vacios
            if (DateTime.Today.Year - fechaNacimiento.Year < 18)
                return "El administrador debe ser mayor de edad."; // Verifica que el administrador sea mayor de edad
            if (fechaContratacion > DateTime.Today)
                return "La fecha de contratacion no puede ser futura."; // Verifica que la fecha de contratacion no sea futura

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
            DatosAdministrador datos = new DatosAdministrador(); // Crea una instancia de DatosAdministrador
            return datos.Crear(nuevoAdministrador); // Llama al metodo Crear de DatosAdministrador y retorna el resultado
        }

        public List<AdministradorEntidad> ObtenerAdministradoresDesdeBD() // Metodo para obtener todos los administradores desde la base de datos
        {
            DatosAdministrador datos = new DatosAdministrador(); // Crea una instancia de DatosAdministrador
            return datos.ObtenerAdministradores(); // Llama al metodo ObtenerAdministradores de DatosAdministrador y retorna la lista de administradores
        }

        public string EliminarAdministrador(int identificacion) // Metodo para eliminar un administrador
        {
            try
            {
                DatosAdministrador datos = new DatosAdministrador(); // Crea una instancia de DatosAdministrador
                bool resultado = datos.Eliminar(identificacion); // Llama al metodo Eliminar de DatosAdministrador y almacena el resultado
                return resultado ? "Administrador eliminado correctamente." : "No se pudo eliminar el administrador."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return ex.Message; // Retorna el mensaje de la excepcion
            }
        }

        public string EditarAdministrador(AdministradorEntidad administrador) // Metodo para editar un administrador
        {
            try
            {
                DatosAdministrador datos = new DatosAdministrador(); // Crea una instancia de DatosAdministrador
                bool resultado = datos.Actualizar(administrador); // Llama al metodo Actualizar de DatosAdministrador y almacena el resultado
                return resultado ? "Administrador actualizado correctamente." : "No se pudo actualizar el administrador."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return ex.Message; // Retorna el mensaje de la excepcion
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
