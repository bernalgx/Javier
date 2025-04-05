// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Windows.Forms;
using Capa_Acceso_Datos;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
    public partial class FrmRegistroVideojuego : Form // Define la clase FrmRegistroVideojuego que hereda de Form
    {
        // Instancia para gestionar la logica de negocio de los videojuegos
        private LogVideojuego logicaVideojuego = new LogVideojuego(); // Declara una variable privada de tipo LogVideojuego e inicializa una nueva instancia
                                                                      // Instancia compartida para gestionar los tipos de videojuegos
        private LogTipoVideojuego TipoVideoJuego; // Declara una variable privada de tipo LogTipoVideojuego

        // Constructor que recibe la instancia compartida de LogTipoVideojuego
        public FrmRegistroVideojuego(LogTipoVideojuego TipoVideoJuegoCompartida)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            TipoVideoJuego = TipoVideoJuegoCompartida; // Asigna la instancia compartida de LogTipoVideojuego a la variable TipoVideoJuego
        }

        // Evento que se ejecuta al cargar el formulario
        private void FrmRegistroVideojuego_Load(object sender, EventArgs e)
        {
            try
            {
                var datos = new DatosTipoVideojuego(); // Crea una instancia de DatosTipoVideojuego

                // Obtener los tipos de videojuegos desde la base de datos
                var listaTipos = datos.ObtenerTodos(); // Obtiene la lista de tipos de videojuegos desde la base de datos

                // Configurar el ComboBox de tipos de videojuegos
                cmbTipoVideojuego.DataSource = listaTipos; // Asigna la lista de tipos de videojuegos al DataSource del ComboBox cmbTipoVideojuego
                cmbTipoVideojuego.DisplayMember = "Nombre"; // Establece la propiedad DisplayMember del ComboBox cmbTipoVideojuego
                cmbTipoVideojuego.ValueMember = "Id"; // Establece la propiedad ValueMember del ComboBox cmbTipoVideojuego

                // Seleccionar primer item (opcional)
                if (cmbTipoVideojuego.Items.Count > 0) // Verifica si hay items en el ComboBox cmbTipoVideojuego
                    cmbTipoVideojuego.SelectedIndex = 0; // Establece el indice seleccionado del ComboBox cmbTipoVideojuego en 0

                // Configurar ComboBox de formato fisico/virtual (se mantiene igual)
                cmbFisico.Items.Clear(); // Limpia los items del ComboBox cmbFisico
                cmbFisico.Items.Add("Fisico"); // Agrega el item "Fisico" al ComboBox cmbFisico
                cmbFisico.Items.Add("Virtual"); // Agrega el item "Virtual" al ComboBox cmbFisico
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show($"Error cargando datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Muestra un mensaje de error
            }
        }

        // Evento que se ejecuta al hacer clic en el boton de registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene los valores ingresados por el usuario
                string nombre = txtNombre.Text; // Obtiene el texto del TextBox txtNombre

                // Verifica que se haya seleccionado un tipo de videojuego
                if (cmbTipoVideojuego.SelectedItem == null) // Verifica si no hay un item seleccionado en el ComboBox cmbTipoVideojuego
                {
                    MessageBox.Show("Seleccione un tipo de videojuego."); // Muestra un mensaje de advertencia
                    return; // Sale del metodo
                }

                // Toma el valor (int) que se configuro en ValueMember del ComboBox
                int tipo = Convert.ToInt32(cmbTipoVideojuego.SelectedValue); // Convierte el valor seleccionado del ComboBox cmbTipoVideojuego a entero

                string desarrollador = txtDesarrollador.Text; // Obtiene el texto del TextBox txtDesarrollador
                int lanzamiento = int.Parse(txtLanzamiento.Text); // Convierte el texto del TextBox txtLanzamiento a entero
                bool fisico = (cmbFisico.SelectedItem?.ToString() == "Fisico"); // Verifica si el item seleccionado en el ComboBox cmbFisico es "Fisico"

                // Crea el objeto VideojuegoEntidad
                VideojuegoEntidad nuevoVideojuego = new VideojuegoEntidad
                {
                    // Asumiendo que la columna Id es autoincremental en la base de datos
                    //Id = 0,
                    Nombre = nombre, // Asigna el valor del TextBox txtNombre a la propiedad Nombre del videojuego
                    Desarrollador = desarrollador, // Asigna el valor del TextBox txtDesarrollador a la propiedad Desarrollador del videojuego
                    Lanzamiento = lanzamiento, // Asigna el valor del TextBox txtLanzamiento a la propiedad Lanzamiento del videojuego
                    Fisico = fisico, // Asigna el valor del ComboBox cmbFisico a la propiedad Fisico del videojuego
                    Id_TipoVideojuego = tipo // Asigna el valor del ComboBox cmbTipoVideojuego a la propiedad Id_TipoVideojuego del videojuego
                };

                // Llama al metodo Crear de la clase de acceso a datos
                DatosVideojuego datos = new DatosVideojuego(); // Crea una instancia de DatosVideojuego
                string mensaje = datos.Crear(nuevoVideojuego); // Llama al metodo Crear de DatosVideojuego y almacena el mensaje
                MessageBox.Show(mensaje); // Muestra el mensaje en un MessageBox

                // Limpia los campos del formulario
                txtNombre.Clear(); // Limpia el TextBox txtNombre
                txtDesarrollador.Clear(); // Limpia el TextBox txtDesarrollador
                txtLanzamiento.Clear(); // Limpia el TextBox txtLanzamiento
                cmbTipoVideojuego.SelectedIndex = -1; // Restablece el indice seleccionado del ComboBox cmbTipoVideojuego
                cmbFisico.SelectedIndex = -1; // Restablece el indice seleccionado del ComboBox cmbFisico
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error: " + ex.Message); // Muestra un mensaje de error
            }
        }

        private void button1_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton para registrar un tipo de videojuego
        {
            FrmRegistroTipoVideojuego frmRegistroTipoVideojuego = new FrmRegistroTipoVideojuego(TipoVideoJuego); // Crea una nueva instancia de FrmRegistroTipoVideojuego
            frmRegistroTipoVideojuego.ShowDialog(); // Muestra el formulario FrmRegistroTipoVideojuego como un cuadro de dialogo
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)