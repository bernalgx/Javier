using Capa_Acceso_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Interfaz
{
	public partial class FrmReserva : Form
	{
		// Variable para guardar la lista original de VideojuegosXTiendaEntidad.
		private List<VideojuegosXTiendaEntidad> listaOriginal;

		public FrmReserva()
		{
			InitializeComponent();
		}

		private void FrmReserva_Load(object sender, EventArgs e)
		{
			try
			{
				DatosTienda datosTienda = new DatosTienda();
				// Obtiene todas las tiendas y filtra solo las activas.
				List<TiendaEntidad> tiendas = datosTienda.ObtenerTiendas();
				var tiendasActivas = tiendas.Where(t => t.Activa).ToList();

				if (tiendasActivas.Count == 0)
				{
					MessageBox.Show("No hay tiendas activas disponibles.");
					return;
				}

				// Configuramos el ComboBox. Puedes usar la lista filtrada si lo deseas.
				comboBoxTiendas.DisplayMember = "Nombre";
				comboBoxTiendas.ValueMember = "Id";
				comboBoxTiendas.DataSource = tiendasActivas;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar las tiendas: " + ex.Message);
			}
		}

		private void comboBoxTiendas_SelectedValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (comboBoxTiendas.SelectedValue == null)
					return;

				int tiendaId = 0;
				if (comboBoxTiendas.SelectedValue is int)
					tiendaId = (int)comboBoxTiendas.SelectedValue;
				else if (comboBoxTiendas.SelectedValue is TiendaEntidad tienda)
					tiendaId = tienda.Id;
				else
					tiendaId = Convert.ToInt32(comboBoxTiendas.SelectedValue);

				DatosVideojuego datosVideojuego = new DatosVideojuego();
				List<VideojuegosXTiendaEntidad> listaVideojuegos = datosVideojuego.ObtenerVideojuegosPorTienda(tiendaId);

				if (listaVideojuegos == null || listaVideojuegos.Count == 0)
				{
					MessageBox.Show("No hay videojuegos disponibles en esta tienda.");
					dataGridViewVideojuegos.DataSource = null;
				}
				else
				{
					// Guardamos la lista original para poder acceder a ella luego.
					listaOriginal = listaVideojuegos;

					// Creamos una lista de objetos anónimos para mostrar solo las columnas deseadas.
					var listaMostrar = listaVideojuegos.Select(v => new
					{
						Tienda = v.Tienda.Nombre,
						Videojuego = v.Videojuego.Nombre,
						Existencias = v.Existencias
					}).ToList();

					dataGridViewVideojuegos.DataSource = listaMostrar;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar los videojuegos: " + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				// Validar que se haya seleccionado un videojuego.
				if (dataGridViewVideojuegos.SelectedRows.Count == 0)
				{
					MessageBox.Show("Por favor, seleccione un videojuego.");
					return;
				}

				// Validar que la cantidad digitada sea un número mayor a 0.
				if (!int.TryParse(textBoxCantidad.Text, out int cantidad) || cantidad <= 0)
				{
					MessageBox.Show("La cantidad debe ser un número mayor a 0.");
					return;
				}

				// Obtenemos el índice de la fila seleccionada.
				int indiceSeleccionado = dataGridViewVideojuegos.SelectedRows[0].Index;
				VideojuegosXTiendaEntidad videojuegoSeleccionado = listaOriginal[indiceSeleccionado];

				// Validar que existan suficientes existencias.
				if (videojuegoSeleccionado.Existencias < cantidad)
				{
					MessageBox.Show("No hay suficientes existencias para realizar la reserva.");
					return;
				}

				// Crear el objeto de reserva.
				ReservaEntidad reserva = new ReservaEntidad(
					0, // IdReserva se asigna automáticamente en la base de datos.
					videojuegoSeleccionado,
					Program.ClienteActual, // Asegúrate de tener definido y asignado ClienteActual.
					dateTimePickerReserva.Value,
					cantidad
				);



				DatosReserva datosReserva = new DatosReserva();
				string resultado = datosReserva.CrearReserva(reserva);
				MessageBox.Show(resultado);

				if (resultado.Contains("exitosamente"))
				{

				//crear funcion que refresque el data grid
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
