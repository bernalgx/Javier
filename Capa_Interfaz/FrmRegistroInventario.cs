// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Capa_Log_Negocio;   // Asegúrate de usar el namespace donde está LogTienda
using Capa_Entidades;
using Capa_Acceso_Datos;      // Para la clase TiendaEntidad

namespace Capa_Interfaz
{
    public partial class FrmRegistroInventario : Form // Define la clase FrmRegistroInventario que hereda de Form
    {
        public FrmRegistroInventario() // Constructor de la clase FrmRegistroInventario
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            CargarTiendasActivas_CargarVideoJuegos(); // Llama al metodo CargarTiendasActivas_CargarVideoJuegos
        }

        private void CargarTiendasActivas_CargarVideoJuegos() // Metodo para cargar las tiendas activas y los videojuegos en los ComboBox
        {
            try
            {
                // Instanciar la clase LogTienda
                LogTienda logTienda = new LogTienda(); // Crea una instancia de LogTienda
                LogVideojuego logVideojuego = new LogVideojuego(); // Crea una instancia de LogVideojuego

                // Obtener todas las tiendas desde la base de datos
                List<TiendaEntidad> tiendas = logTienda.ObtenerTiendasDesdeBD(); // Obtiene la lista de tiendas desde la base de datos
                List<VideojuegoEntidad> videojuegos = logVideojuego.ObtenerVideojuegosDesdeBD(); // Obtiene la lista de videojuegos desde la base de datos

                // Filtrar las tiendas que estan activas (Activa == true)
                List<TiendaEntidad> tiendasActivas = tiendas.Where(t => t.Activa).ToList(); // Filtra las tiendas activas
                List<VideojuegoEntidad> videojuegosActivos = videojuegos.ToList(); // Obtiene la lista de videojuegos activos

                // Asignar la lista filtrada al ComboBox
                cmbTiendas.DataSource = tiendasActivas; // Asigna la lista de tiendas activas al DataSource del ComboBox cmbTiendas
                cmbVideojuegos.DataSource = videojuegosActivos; // Asigna la lista de videojuegos activos al DataSource del ComboBox cmbVideojuegos
                cmbTiendas.DisplayMember = "Nombre"; // Establece la propiedad DisplayMember del ComboBox cmbTiendas
                cmbTiendas.ValueMember = "Id"; // Establece la propiedad ValueMember del ComboBox cmbTiendas
                cmbVideojuegos.DisplayMember = "Nombre"; // Establece la propiedad DisplayMember del ComboBox cmbVideojuegos
                cmbVideojuegos.ValueMember = "Id"; // Establece la propiedad ValueMember del ComboBox cmbVideojuegos
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al cargar las tiendas activas: " + ex.Message); // Muestra un mensaje de error
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Registrar
        {
            try
            {
                // Validar que todos los datos requeridos esten presentes
                if (cmbTiendas.SelectedItem == null || cmbVideojuegos.SelectedItem == null || string.IsNullOrWhiteSpace(txtExistencias.Text)) // Verifica si los campos tienda, videojuego y existencias estan vacios
                {
                    MessageBox.Show("Todos los datos son requeridos. Por favor, selecciona una tienda, un videojuego y escribe la cantidad de existencias."); // Muestra un mensaje de advertencia
                    return; // Sale del metodo
                }

                // Validar que la cantidad (existencias) sea un numero entero mayor que cero
                if (!int.TryParse(txtExistencias.Text, out int existencias) || existencias <= 0) // Verifica si el valor del campo existencias es un numero entero mayor que cero
                {
                    MessageBox.Show("Ingresa una cantidad valida (numero entero mayor que cero) para las existencias."); // Muestra un mensaje de advertencia
                    return; // Sale del metodo
                }

                // Obtener la tienda y el videojuego seleccionados
                TiendaEntidad tiendaSeleccionada = (TiendaEntidad)cmbTiendas.SelectedItem; // Obtiene la tienda seleccionada
                VideojuegoEntidad videojuegoSeleccionado = (VideojuegoEntidad)cmbVideojuegos.SelectedItem; // Obtiene el videojuego seleccionado

                // Crear el objeto VideojuegosXTiendaEntidad usando el constructor requerido
                VideojuegosXTiendaEntidad registro = new VideojuegosXTiendaEntidad(tiendaSeleccionada, videojuegoSeleccionado, existencias); // Crea una nueva instancia de VideojuegosXTiendaEntidad

                // Instanciar la logica de negocio para VideojuegosXTienda
                LogVideojuegosXTienda logVideojuegosXTienda = new LogVideojuegosXTienda(); // Crea una instancia de LogVideojuegosXTienda

                // Intentar registrar el nuevo inventario en la tabla VideojuegosXTienda
                bool registrado = logVideojuegosXTienda.RegistrarInventario(registro); // Llama al metodo RegistrarInventario y almacena el resultado

                if (registrado) // Verifica si el registro fue exitoso
                {
                    MessageBox.Show("Registro exitoso."); // Muestra un mensaje de exito
                                                          // Limpiar el campo de existencias o actualizar la interfaz si es necesario
                    txtExistencias.Clear(); // Limpia el TextBox txtExistencias
                }
                else
                {
                    MessageBox.Show("La combinacion de tienda y videojuego ya existe o ocurrio un error al registrar el inventario."); // Muestra un mensaje de error
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error: " + ex.Message); // Muestra un mensaje de error
            }
        }

        private void FrmRegistroInventario_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
        {
            // Metodo vacio, se puede agregar logica si es necesario
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)