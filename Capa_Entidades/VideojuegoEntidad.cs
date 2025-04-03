namespace Capa_Entidades
{
	public class VideojuegoEntidad
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Desarrollador { get; set; }
		public int Lanzamiento { get; set; }
		public bool Fisico { get; set; }
		public int Id_TipoVideojuego { get; set; }
	}
}
