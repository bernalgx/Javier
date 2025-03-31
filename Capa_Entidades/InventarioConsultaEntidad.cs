using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Entidades
{
	public class InventarioConsultaEntidad

	{
		// Datos de la Tienda
		public int TiendaId { get; set; }
		public string TiendaNombre { get; set; }
		public string TiendaDireccion { get; set; }

		// Datos del Videojuego
		public int VideojuegoId { get; set; }
		public string VideojuegoNombre { get; set; }
		public string TipoVideojuegoNombre { get; set; }

		// Existencias
		public int Existencias { get; set; }
	}
}

