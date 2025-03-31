using Capa_Acceso_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Interfaz
{
	// Definición parcial de la clase FrmConsultaInventario, heredando de Form
	public partial class FrmConsultaInventario : Form
	{
		// Constructor de FrmConsultaInventario
		public FrmConsultaInventario()
		{
			// Inicializa los componentes del formulario
			InitializeComponent();
		}

		// Manejador de eventos para el evento Load del formulario
		private void FrmConsultaInventario_Load(object sender, EventArgs e)
		{
			// Crea una instancia de DatosInventario para acceder a los datos del inventario
			DatosInventario datos = new DatosInventario();

			// Recupera los datos del inventario como una lista de objetos InventarioConsultaEntidad
			List<InventarioConsultaEntidad> lista = datos.ObtenerInventario();

			// Asigna la lista recuperada al DataGridView para mostrar los datos
			dgvConsultaInventario.DataSource = lista;
		}
	}


}
