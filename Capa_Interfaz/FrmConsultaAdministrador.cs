// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
	public partial class FrmConsultaAdministrador : Form // Define la clase FrmConsultaAdministrador que hereda de Form
	{
		public FrmConsultaAdministrador() // Constructor de la clase FrmConsultaAdministrador
		{
			InitializeComponent(); // Inicializa los componentes del formulario
		}

		private void FrmConsultaAdministrador_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
		{

		}

		private void CargarAdministradores() // Metodo para cargar los administradores en el DataGridView
		{
			LogAdministrador log = new LogAdministrador(); // Crea una instancia de LogAdministrador
			dataGridView1.DataSource = log.ObtenerAdministradoresDesdeBD(); // Asigna la lista de administradores al DataSource del DataGridView
		}

		private void btnEditar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Editar
		{
			if (dataGridView1.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
			{
				var admin = new AdministradorEntidad // Crea una nueva instancia de AdministradorEntidad
				{
					Identificacion = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Identificacion"].Value), // Asigna el valor de la celda Identificacion
					Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString(), // Asigna el valor de la celda Nombre
					PrimerApellido = dataGridView1.SelectedRows[0].Cells["PrimerApellido"].Value.ToString(), // Asigna el valor de la celda PrimerApellido
					SegundoApellido = dataGridView1.SelectedRows[0].Cells["SegundoApellido"].Value.ToString(), // Asigna el valor de la celda SegundoApellido
					FechaNacimiento = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["FechaNacimiento"].Value), // Asigna el valor de la celda FechaNacimiento
					FechaContratacion = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["FechaContratacion"].Value) // Asigna el valor de la celda FechaContratacion
				};

				FrmEditarAdministrador frmEditar = new FrmEditarAdministrador(admin); // Crea una nueva instancia de FrmEditarAdministrador
				if (frmEditar.ShowDialog() == DialogResult.OK) // Muestra el formulario FrmEditarAdministrador y verifica si el resultado es OK
				{
					LogAdministrador log = new LogAdministrador(); // Crea una instancia de LogAdministrador
					string mensaje = log.EditarAdministrador(frmEditar.Administrador); // Llama al metodo EditarAdministrador y almacena el mensaje
					MessageBox.Show(mensaje); // Muestra el mensaje en un MessageBox
					CargarAdministradores(); // Llama al metodo CargarAdministradores
				}
			}
			else
			{
				MessageBox.Show("Seleccione un administrador para editar."); // Muestra un mensaje si no hay filas seleccionadas
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Eliminar
		{
			if (dataGridView1.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
			{
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Identificacion"].Value); // Obtiene el valor de la celda Identificacion
				LogAdministrador log = new LogAdministrador(); // Crea una instancia de LogAdministrador
				string mensaje = log.EliminarAdministrador(id); // Llama al metodo EliminarAdministrador y almacena el mensaje
				MessageBox.Show(mensaje); // Muestra el mensaje en un MessageBox
				CargarAdministradores(); // Llama al metodo CargarAdministradores
			}
			else
			{
				MessageBox.Show("Seleccione un administrador para eliminar."); // Muestra un mensaje si no hay filas seleccionadas
			}
		}

		private void FrmConsultaAdministrador_Load_1(object sender, EventArgs e)
		{
			CargarAdministradores(); // Llama al metodo CargarAdministradores
		}
	}
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
