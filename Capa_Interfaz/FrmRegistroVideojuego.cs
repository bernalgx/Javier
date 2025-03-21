﻿using System;
using System.Windows.Forms;
using Capa_Acceso_Datos;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
	public partial class FrmRegistroVideojuego : Form
	{
		// Instancia para gestionar la lógica de negocio de los videojuegos
		private LogVideojuego logicaVideojuego = new LogVideojuego();
		// Instancia compartida para gestionar los tipos de videojuegos
		private LogTipoVideojuego TipoVideoJuego;

		// Constructor que recibe la instancia compartida de LogTipoVideojuego
		public FrmRegistroVideojuego(LogTipoVideojuego TipoVideoJuegoCompartida)
		{
			InitializeComponent();
			TipoVideoJuego = TipoVideoJuegoCompartida;
		}

		// Evento que se ejecuta al cargar el formulario
		private void FrmRegistroVideojuego_Load(object sender, EventArgs e)
		{
			var datos = new DatosTipoVideojuego();
			var lista = datos.ObtenerTodos();

			cmbTipoVideojuego.DataSource = lista;
			cmbTipoVideojuego.DisplayMember = "Nombre"; // Lo que se muestra en la lista
			cmbTipoVideojuego.ValueMember = "Id";       // Valor interno (FK)
			cmbTipoVideojuego.SelectedIndex = -1;       // Para que no seleccione ninguno al inicio




			// Configura el ComboBox para mostrar el nombre del tipo de videojuego
			cmbTipoVideojuego.DisplayMember = "Nombre";
			cmbTipoVideojuego.ValueMember = "Id";

			// Asigna el DataSource al ComboBox con los tipos de videojuegos obtenidos
			//cmbTipoVideojuego.DataSource = TipoVideoJuego.ObtenerTipos();

			// Limpia y agrega opciones al ComboBox de formato físico/virtual
			cmbFisico.Items.Clear();
			cmbFisico.Items.Add("Físico");
			cmbFisico.Items.Add("Virtual");
		}

		// Evento que se ejecuta al hacer clic en el botón de registrar
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Obtiene los valores ingresados por el usuario
				string nombre = txtNombre.Text;

				// Verifica que se haya seleccionado un tipo de videojuego
				if (cmbTipoVideojuego.SelectedItem == null)
				{
					MessageBox.Show("Seleccione un tipo de videojuego.");
					return;
				}

				// Toma el valor (int) que se configuró en ValueMember del ComboBox
				int tipo = (int)cmbTipoVideojuego.SelectedValue;

				string desarrollador = txtDesarrollador.Text;
				int lanzamiento = int.Parse(txtLanzamiento.Text);
				bool fisico = (cmbFisico.SelectedItem?.ToString() == "Físico");

				// Crea el objeto VideojuegoEntidad
				VideojuegoEntidad nuevoVideojuego = new VideojuegoEntidad
				{
					// Asumiendo que la columna Id es autoincremental en la base de datos
					//Id = 0,
					Nombre = nombre,
					Desarrollador = desarrollador,
					Lanzamiento = lanzamiento,
					Fisico = fisico,
					TipoVideojuegoId = tipo
				};

				// Llama al método Crear de la clase de acceso a datos
				DatosVideojuego datos = new DatosVideojuego();
				string mensaje = datos.Crear(nuevoVideojuego);
				MessageBox.Show(mensaje);

				// Limpia los campos del formulario
				txtNombre.Clear();
				txtDesarrollador.Clear();
				txtLanzamiento.Clear();
				cmbTipoVideojuego.SelectedIndex = -1;
				cmbFisico.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmRegistroTipoVideojuego frmRegistroTipoVideojuego = new FrmRegistroTipoVideojuego(TipoVideoJuego);
			frmRegistroTipoVideojuego.ShowDialog();
		}
	}
}
