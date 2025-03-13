//namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
//{
//    public class VideojuegoEntidad
//    {
//        public int Id { get; set; }
//        public string Nombre { get; set; }
//        public TipoVideojuegoEntidad TipoVideojuego { get; set; }
//        public string Desarrollador { get; set; }
//        public int Lanzamiento { get; set; }
//        public bool Fisico { get; set; } // True = Fisico, False = Virtual

//        public VideojuegoEntidad(int id, string nombre, TipoVideojuegoEntidad tipoVideojuego, string desarrollador, int lanzamiento, bool fisico)
//        {
//            Id = id;
//            Nombre = nombre;
//            TipoVideojuego = tipoVideojuego;
//            Desarrollador = desarrollador;
//            Lanzamiento = lanzamiento;
//            Fisico = fisico;
//        }
//    }
//}


namespace Capa_Entidades
{
	/// <summary>
	/// Representa un videojuego con sus datos básicos.
	/// </summary>
	public class VideojuegoEntidad
	{


		public int Id { get; set; }
		public string Nombre { get; set; }
		public int TipoVideojuegoId { get; set; }
		public string Desarrollador { get; set; }
		public int Lanzamiento { get; set; }
		public bool Fisico { get; set; }
	}
}
