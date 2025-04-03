// Archivo: VideojuegosXTiendaEntidad.cs
using Capa_Entidades;

public class VideojuegosXTiendaEntidad
{
	public TiendaEntidad Tienda { get; set; }
	public VideojuegoEntidad Videojuego { get; set; }
	public decimal Existencias { get; set; }

	public VideojuegosXTiendaEntidad(TiendaEntidad tienda, VideojuegoEntidad videojuego, decimal existencias)
	{
		Tienda = tienda;
		Videojuego = videojuego;
		Existencias = existencias;
	}
}
