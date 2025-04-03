using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Entidades
{
	public class InventarioConsultaEntidad
	{
		public int Id_Tienda { get; set; }
		public string TiendaNombre { get; set; }
		public string TiendaDireccion { get; set; }
		public decimal Id_VideoJuego { get; set; }  // ← Cambia de int a decimal
		public string VideojuegoNombre { get; set; }
		public string TipoVideojuegoNombre { get; set; }
		public int Existencias { get; set; }
	}


}

