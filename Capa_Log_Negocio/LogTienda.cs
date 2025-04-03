//TODO NUEVO/////////////

using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Log_Negocio
{
	public class LogTienda
	{
		private TiendaEntidad[] tiendas = new TiendaEntidad[20];
		private int indice = 0;




		public string RegistroTienda(int id, string nombre, string direccion, string telefono, bool activa, int administradorId)
		{
			// Validación de campos requeridos
			if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono))
				return "Todos los campos son requeridos.";

			// Validar que el Id sea unico
			for (int i = 0; i < indice; i++)
			{
				if (tiendas[i].Id == id)
					return "El ID ya existe.";
			}

			// Validar espacio en el arreglo
			if (indice >= tiendas.Length)
				return "No se pueden agregar más tiendas.";

			// Registrar la tienda
			tiendas[indice] = new TiendaEntidad
			{
				Id = id,
				Nombre = nombre,
				Direccion = direccion,
				Telefono = telefono,
				Activa = activa,
				Id_Administrador = administradorId
			};
			indice++;

			return "Tienda registrada correctamente.";
		}

		public List<TiendaEntidad> ObtenerTiendasDesdeBD()
		{
			DatosTienda datos = new DatosTienda();
			return datos.ObtenerTiendas();
		}

		public string EliminarTienda(int id)
		{
			try
			{
				DatosTienda datos = new DatosTienda();
				bool resultado = datos.Eliminar(id);
				return resultado ? "Tienda eliminada correctamente." : "No se pudo eliminar la tienda.";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		public string EditarTienda(TiendaEntidad tienda)
		{
			try
			{
				DatosTienda datos = new DatosTienda();
				bool resultado = datos.Actualizar(tienda);
				return resultado ? "Tienda actualizada correctamente." : "No se pudo actualizar la tienda.";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}