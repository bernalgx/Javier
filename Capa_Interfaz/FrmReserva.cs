//using System;
//using System.Windows.Forms;
//using Capa_Entidades;
//using Capa_Acceso_Datos;
//using System.Collections.Generic;

//namespace TuNamespace
//{
//	public partial class FrmReserva : Form
//	{
//		private ClienteEntidad clienteActual;
//		private List<InventarioConsultaEntidad> inventarioActual;

//		public FrmReserva(ClienteEntidad cliente)
//		{
//			InitializeComponent();
//			clienteActual = cliente;
//		}

//		private void FrmReserva_Load(object sender, EventArgs e)
//		{
//			CargarTiendasActivas();
//		}

//		private void CargarTiendasActivas()
//		{
//			try
//			{
//				DatosTienda datosTienda = new DatosTienda();
//				List<TiendaEntidad> tiendas = datosTienda.ObtenerTiendas()
//					.FindAll(t => t.Activa);

//				comboBoxTiendas.DataSource = tiendas;
//				comboBoxTiendas.DisplayMember = "Nombre";
//				comboBoxTiendas.ValueMember = "Id";
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show("Error cargando tiendas: " + ex.Message);
//			}
//		}

//		private void comboBoxTiendas_SelectedIndexChanged(object sender, EventArgs e)
//		{
//			if (comboBoxTiendas.SelectedItem is TiendaEntidad tienda)
//			{
//				CargarVideojuegosEnTienda(tienda.Id);
//			}
//		}

//		private void CargarVideojuegosEnTienda(int tiendaId)
//		{
//			try
//			{
//				DatosInventario datosInventario = new DatosInventario();
//				inventarioActual = datosInventario.ObtenerInventarioPorTienda(tiendaId);

//				dataGridViewVideojuegos.DataSource = inventarioActual;
//				dataGridViewVideojuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show("Error cargando videojuegos: " + ex.Message);
//			}
//		}

//		private void btnRealizarReserva_Click(object sender, EventArgs e)
//		{
//			try
//			{
//				// Validaciones básicas
//				if (comboBoxTiendas.SelectedItem == null)
//				{
//					MessageBox.Show("Seleccione una tienda");
//					return;
//				}

//				if (dataGridViewVideojuegos.SelectedRows.Count == 0)
//				{
//					MessageBox.Show("Seleccione un videojuego");
//					return;
//				}

//				if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
//				{
//					MessageBox.Show("Cantidad debe ser un número mayor a 0");
//					return;
//				}

//				// Obtener datos seleccionados
//				TiendaEntidad tienda = (TiendaEntidad)comboBoxTiendas.SelectedItem;
//				InventarioConsultaEntidad inventario = (InventarioConsultaEntidad)dataGridViewVideojuegos.SelectedRows[0].DataBoundItem;

//				// Validar existencias
//				if (inventario.Existencias < cantidad)
//				{
//					MessageBox.Show("No hay suficientes existencias disponibles");
//					return;
//				}

//				// Crear objeto reserva
//				ReservaEntidad reserva = new ReservaEntidad
//				{
//					Cliente = clienteActual,
//					FechaReserva = dateTimePickerFecha.Value,
//					Cantidad = cantidad,
//					VideojuegoTienda = ObtenerVideojuegoTienda(inventario)
//				};

//				// Enviar al servidor
//				DatosReserva datosReserva = new DatosReserva();
//				string resultado = datosReserva.CrearReserva(reserva);

//				MessageBox.Show(resultado);
//				CargarVideojuegosEnTienda(tienda.Id); // Refrescar inventario
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show("Error realizando reserva: " + ex.Message);
//			}
//		}

//		private VideojuegosXTiendaEntidad ObtenerVideojuegoTienda(InventarioConsultaEntidad inventario)
//		{
//			DatosInventario datosInventario = new DatosInventario();
//			return datosInventario.ObtenerVideojuegoTienda(inventario.TiendaId, inventario.VideojuegoId);
//		}
//	}
//}
