using Capa_Entidades;

namespace Capa_Log_Negocio
{
	// Clase que gestiona la lógica de negocio para los tipos de videojuegos
	public class LogTipoVideojuego
	{
		// Arreglo para almacenar los tipos de videojuegos
		private TipoVideojuegoEntidad[] tipos = new TipoVideojuegoEntidad[10];
		// Índice para llevar el control de la cantidad de tipos almacenados
		private int indice = 0;

		// Método para registrar un nuevo tipo de videojuego
		public string RegistrarTipo(int id, string nombre, string descripcion)
		{
			// Validación: Todos los datos son requeridos
			if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
				return "Todos los campos son requeridos.";

			// Validar que el Id sea único
			for (int i = 0; i < indice; i++)
			{
				if (tipos[i].Id == id)
					return "El ID ya existe.";
			}

			// Validar que aún haya espacio en el arreglo
			if (indice >= tipos.Length)
				return "No se pueden agregar más tipos.";

			// Agregar el nuevo tipo al arreglo
			tipos[indice] = new TipoVideojuegoEntidad { Id = id, Nombre = nombre, Descripcion = descripcion };
			indice++;

			return "Tipo de videojuego registrado correctamente.";
		}

		// Método para retornar el arreglo de tipos de videojuegos (o convertirlo a List) y poder cargarlo en un ComboBox
		public TipoVideojuegoEntidad[] ObtenerTipos()
		{
			// Retorna solo los elementos válidos del arreglo
			return tipos.Take(indice).ToArray();
		}
	}
}
