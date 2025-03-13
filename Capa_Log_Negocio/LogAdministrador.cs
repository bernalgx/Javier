//using System; // Importa el espacio de nombres System
////using Capa_Entidades; // Importa la capa de entidades
//using System.Collections.Generic; // Importa el espacio de nombres para listas

//namespace Capa_Log_Negocio // Define el espacio de nombres para la logica de negocio
//{
//	// Clase para manejar la logica de negocio relacionada con los administradores
//	public class LogAdministrador
//	{
//		private DatosAdministrador datos = new DatosAdministrador();

//		//Metodo para registrar un administrador en el sistema

//				public string RegistroAdministrador(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaContratacion)
//		{
//			//Validacion de datos obligatorios

//					if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(primerApellido) || string.IsNullOrWhiteSpace(segundoApellido))
//			{
//				return "Todos los campos son obligatorios.";
//			}

//			//Validacion de edad(debe ser mayor de 18 años)

//					int edad = DateTime.Today.Year - fechaNacimiento.Year;
//			if (edad < 18)
//			{
//				return "El administrador debe ser mayor de edad (mínimo 18 años).";
//			}

//			//Validacion de fecha de contratacion(no puede ser futura)

//					if (fechaContratacion > DateTime.Today)
//			{
//				return "La fecha de contratacion no puede ser mayor a la fecha actual.";
//			}

//			//Creacion del objeto AdministradorEntidad

//					var administrador = new AdministradorEntidad
//					{
//						Identificacion = identificacion,
//						Nombre = nombre,
//						PrimerApellido = primerApellido,
//						SegundoApellido = segundoApellido,
//						FechaNacimiento = fechaNacimiento,
//						FechaContratacion = fechaContratacion
//					};

//			//Llamada a la capa de acceso a datos

//					bool resultado = datos.AgregarAdministrador(administrador);

//			return resultado ? "Administrador registrado correctamente." : "Error al registrar administrador.";
//		}
//	}
//}
