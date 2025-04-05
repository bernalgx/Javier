// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Entidades;
using Capa_Log_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Interfaz
{
    public partial class FrmConsultaTiendas : Form // Define la clase FrmConsultaTiendas que hereda de Form
    {
        private LogTienda logicaTienda = new LogTienda(); // Declara una variable privada de tipo LogTienda e inicializa una nueva instancia

        public FrmConsultaTiendas() // Constructor de la clase FrmConsultaTiendas
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            CargarTiendas(); // Llama al metodo CargarTiendas
            ConfigurarDataGridView(); // Llama al metodo ConfigurarDataGridView
        }

        private void CargarTiendas() // Metodo para cargar las tiendas en el DataGridView
        {
            try
            {
                var tiendas = logicaTienda.ObtenerTiendasDesdeBD(); // Obtiene la lista de tiendas desde la base de datos
                dataGridView1.DataSource = tiendas; // Asigna la lista de tiendas al DataSource del DataGridView
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al cargar tiendas: " + ex.Message); // Muestra un mensaje de error
            }
        }

        private void ConfigurarDataGridView() // Metodo para configurar el DataGridView
        {
            // Configurar columnas
            dataGridView1.Columns["Id"].HeaderText = "ID"; // Configura el encabezado de la columna Id
            dataGridView1.Columns["Nombre"].HeaderText = "Nombre"; // Configura el encabezado de la columna Nombre
            dataGridView1.Columns["Direccion"].HeaderText = "Direccion"; // Configura el encabezado de la columna Direccion
            dataGridView1.Columns["Telefono"].HeaderText = "Telefono"; // Configura el encabezado de la columna Telefono
            dataGridView1.Columns["NombreAdministrador"].HeaderText = "Administrador"; // Configura el encabezado de la columna NombreAdministrador

            // Configurar columna Activa
            dataGridView1.Columns["Activa"].HeaderText = "Activa"; // Configura el encabezado de la columna Activa
            dataGridView1.Columns["Activa"].DefaultCellStyle.Format = "Si;No"; // Formato Si/No para la columna Activa

            // Ocultar columnas no necesarias
            dataGridView1.Columns["Id_Administrador"].Visible = false; // Oculta la columna Id_Administrador
        }

        private void btnEditar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Editar
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
            {
                var tiendaSeleccionada = ObtenerTiendaSeleccionada(); // Obtiene la tienda seleccionada
                var frmEditar = new FrmEditarTienda(tiendaSeleccionada); // Crea una nueva instancia de FrmEditarTienda

                if (frmEditar.ShowDialog() == DialogResult.OK) // Muestra el formulario FrmEditarTienda y verifica si el resultado es OK
                {
                    string resultado = logicaTienda.EditarTienda(frmEditar.Tienda); // Llama al metodo EditarTienda y almacena el resultado
                    MessageBox.Show(resultado); // Muestra el resultado en un MessageBox
                    CargarTiendas(); // Llama al metodo CargarTiendas
                }
            }
            else
            {
                MessageBox.Show("Selecciona una tienda para editar."); // Muestra un mensaje si no hay filas seleccionadas
            }
        }

        private TiendaEntidad ObtenerTiendaSeleccionada() // Metodo para obtener la tienda seleccionada
        {
            return new TiendaEntidad
            {
                Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value), // Asigna el valor de la celda Id
                Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString(), // Asigna el valor de la celda Nombre
                Direccion = dataGridView1.SelectedRows[0].Cells["Direccion"].Value.ToString(), // Asigna el valor de la celda Direccion
                Telefono = dataGridView1.SelectedRows[0].Cells["Telefono"].Value.ToString(), // Asigna el valor de la celda Telefono
                Activa = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Activa"].Value), // Asigna el valor de la celda Activa
                Id_Administrador = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AdministradorId"].Value) // Asigna el valor de la celda AdministradorId
            };
        }

        private void btnEliminar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Eliminar
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value); // Obtiene el valor de la celda Id
                string resultado = logicaTienda.EliminarTienda(id); // Llama al metodo EliminarTienda y almacena el resultado
                MessageBox.Show(resultado); // Muestra el resultado en un MessageBox
                CargarTiendas(); // Llama al metodo CargarTiendas
            }
            else
            {
                MessageBox.Show("Selecciona una tienda para eliminar."); // Muestra un mensaje si no hay filas seleccionadas
            }
        }

        private void FrmConsultaTiendas_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
        {
            
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)