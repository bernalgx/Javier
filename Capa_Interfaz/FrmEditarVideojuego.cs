using Capa_Acceso_Datos;
using Capa_Entidades;
using System;
using System.Windows.Forms;

namespace Capa_Interfaz
{
	public partial class FrmEditarVideojuego : Form
	{
		public VideojuegoEntidad Videojuego { get; private set; }

		public FrmEditarVideojuego(VideojuegoEntidad videojuego)
		{
			InitializeComponent();
			Videojuego = videojuego;
			CargarDatos();
		}
		private void CargarDatos()
		{
			// Cargar la lista de tipos de videojuegos
			var datos = new DatosTipoVideojuego();
			var lista = datos.ObtenerTodos();

			cmbTipoVideojuego.DataSource = lista;
			cmbTipoVideojuego.DisplayMember = "Nombre";   // Ajusta según la propiedad a mostrar
			cmbTipoVideojuego.ValueMember = "Id";           // Ajusta según la propiedad del identificador

			// Cargar los demás campos del formulario
			txtNombre.Text = Videojuego.Nombre;
			txtDesarrollador.Text = Videojuego.Desarrollador;
			txtLanzamiento.Text = Videojuego.Lanzamiento.ToString();

			// Configurar el ComboBox para "Físico" o "Digital"
			var formatoList = new[]
			{
		new { Text = "Físico", Value = true },
		new { Text = "Digital", Value = false }
	};

			cmbFisico.DataSource = formatoList;
			cmbFisico.DisplayMember = "Text";
			cmbFisico.ValueMember = "Value";

			// Seleccionar el valor actual del videojuego
			cmbFisico.SelectedValue = Videojuego.Fisico;
			cmbTipoVideojuego.SelectedValue = Videojuego.TipoVideojuegoId;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			// Validación básica de campos requeridos
			if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
				string.IsNullOrWhiteSpace(txtDesarrollador.Text))
			{
				MessageBox.Show("Los campos Nombre y Desarrollador son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Validar que el lanzamiento sea un número válido
			if (!int.TryParse(txtLanzamiento.Text, out int lanzamiento))
			{
				MessageBox.Show("El año de lanzamiento debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Actualizar las propiedades del objeto
			Videojuego.Nombre = txtNombre.Text;
			Videojuego.Desarrollador = txtDesarrollador.Text;
			Videojuego.Lanzamiento = lanzamiento;

			// Asignar el valor booleano a partir del ComboBox de formato
			if (cmbFisico.SelectedItem != null && cmbFisico.SelectedItem.ToString().Contains("Físico"))
			{
				Videojuego.Fisico = true;
			}
			else
			{
				Videojuego.Fisico = false;
			}

			// Actualizar el tipo de videojuego
			if (cmbTipoVideojuego.SelectedValue != null)
			{
				Videojuego.TipoVideojuegoId = Convert.ToInt32(cmbTipoVideojuego.SelectedValue);
			}
			else
			{
				MessageBox.Show("Seleccione un tipo de videojuego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Si todo es correcto, se indica que la edición fue exitosa y se cierra el formulario
			DialogResult = DialogResult.OK;
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void FrmEditarVideojuego_Load(object sender, EventArgs e)
		{

		}
	}
}
