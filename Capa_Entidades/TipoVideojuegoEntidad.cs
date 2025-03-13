


namespace Capa_Entidades
{
	/// <summary>
	/// Representa el tipo o categoría de un videojuego (por ejemplo: Acción, Aventura, RPG, etc.).
	/// </summary>
	public class TipoVideojuegoEntidad
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }

		// Para que el ComboBox muestre el Nombre en lugar del nombre de la clase
		public override string ToString()
		{
			return Nombre;
		}
	}
}