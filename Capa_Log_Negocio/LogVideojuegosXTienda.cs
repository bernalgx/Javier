using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Log_Negocio
{
	public class LogVideojuegosXTienda
	{
		// Lista en memoria para validar la unicidad durante la sesión actual.
		private List<VideojuegosXTiendaEntidad> registros = new List<VideojuegosXTiendaEntidad>();

		public bool RegistrarInventario(VideojuegosXTiendaEntidad nuevoRegistro)
		{
			// Validar que la combinación tienda-videojuego no exista en la lista en memoria.
			bool existe = registros.Any(r =>
				r.Tienda.Id == nuevoRegistro.Tienda.Id &&
				r.Videojuego.Id == nuevoRegistro.Videojuego.Id);

			if (existe)
			{
				// La combinación ya existe; no se permite duplicado.
				return false;
			}
			else
			{
				// Llamar a la capa de acceso a datos para insertar el registro.
				DatosInventario datos = new DatosInventario();
				string resultado = datos.Crear(nuevoRegistro);

				// Se asume que si el resultado contiene "correctamente", la inserción fue exitosa.
				if (resultado.Contains("correctamente"))
				{
					// Agregar a la lista en memoria (opcional) para mantener el estado durante la sesión.
					registros.Add(nuevoRegistro);
					return true;
				}
				else
				{
					// Hubo un error en la inserción.
					return false;
				}
			}
		}
	}
}
