
namespace Capa_Entidades
{
	public class TipoVideojuegoEntidad
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }

        public static implicit operator TipoVideojuegoEntidad(int v)
        {
            throw new NotImplementedException();
        }
    }
}