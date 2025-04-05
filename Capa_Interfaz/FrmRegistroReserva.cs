// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Acceso_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Interfaz
{
    public partial class FrmRegistroReserva : Form // Define la clase FrmRegistroReserva que hereda de Form
    {
        // Variable para guardar la lista original de VideojuegosXTiendaEntidad.
        private List<VideojuegosXTiendaEntidad> listaOriginal; // Declara una variable privada para almacenar la lista original de videojuegos por tienda

        public FrmRegistroReserva() // Constructor de la clase FrmRegistroReserva
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void FrmReserva_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
        {
            try
            {
                DatosTienda datosTienda = new DatosTienda(); // Crea una instancia de DatosTienda
                                                             // Obtiene todas las tiendas y filtra solo las activas.
                List<TiendaEntidad> tiendas = datosTienda.ObtenerTiendas(); // Obtiene la lista de tiendas desde la base de datos
                var tiendasActivas = tiendas.Where(t => t.Activa).ToList(); // Filtra las tiendas activas

                if (tiendasActivas.Count == 0) // Verifica si no hay tiendas activas
                {
                    MessageBox.Show("No hay tiendas activas disponibles."); // Muestra un mensaje de advertencia
                    return; // Sale del metodo
                }

                // Configuramos el ComboBox. Puedes usar la lista filtrada si lo deseas.
                comboBoxTiendas.DisplayMember = "Nombre"; // Establece la propiedad DisplayMember del ComboBox comboBoxTiendas
                comboBoxTiendas.ValueMember = "Id"; // Establece la propiedad ValueMember del ComboBox comboBoxTiendas
                comboBoxTiendas.DataSource = tiendasActivas; // Asigna la lista de tiendas activas al DataSource del ComboBox comboBoxTiendas
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al cargar las tiendas: " + ex.Message); // Muestra un mensaje de error
            }
        }

        private void comboBoxTiendas_SelectedValueChanged(object sender, EventArgs e) // Evento que se ejecuta al cambiar el valor seleccionado en el ComboBox comboBoxTiendas
        {
            try
            {
                if (comboBoxTiendas.SelectedValue == null) // Verifica si no hay un valor seleccionado en el ComboBox comboBoxTiendas
                    return; // Sale del metodo

                int tiendaId = 0; // Declara una variable para almacenar el ID de la tienda
                if (comboBoxTiendas.SelectedValue is int) // Verifica si el valor seleccionado es un entero
                    tiendaId = (int)comboBoxTiendas.SelectedValue; // Asigna el valor seleccionado a la variable tiendaId
                else if (comboBoxTiendas.SelectedValue is TiendaEntidad tienda) // Verifica si el valor seleccionado es una instancia de TiendaEntidad
                    tiendaId = tienda.Id; // Asigna el ID de la tienda a la variable tiendaId
                else
                    tiendaId = Convert.ToInt32(comboBoxTiendas.SelectedValue); // Convierte el valor seleccionado a entero y lo asigna a la variable tiendaId

                DatosVideojuego datosVideojuego = new DatosVideojuego(); // Crea una instancia de DatosVideojuego
                List<VideojuegosXTiendaEntidad> listaVideojuegos = datosVideojuego.ObtenerVideojuegosPorTienda(tiendaId); // Obtiene la lista de videojuegos por tienda desde la base de datos

                if (listaVideojuegos == null || listaVideojuegos.Count == 0) // Verifica si no hay videojuegos disponibles en la tienda
                {
                    MessageBox.Show("No hay videojuegos disponibles en esta tienda."); // Muestra un mensaje de advertencia
                    dataGridViewVideojuegos.DataSource = null; // Limpia el DataGridView dataGridViewVideojuegos
                }
                else
                {
                    // Guardamos la lista original para poder acceder a ella luego.
                    listaOriginal = listaVideojuegos; // Asigna la lista de videojuegos a la variable listaOriginal

                    // Creamos una lista de objetos anonimos para mostrar solo las columnas deseadas.
                    var listaMostrar = listaVideojuegos.Select(v => new
                    {
                        Tienda = v.Tienda.Nombre,
                        Videojuego = v.Videojuego.Nombre,
                        Existencias = v.Existencias
                    }).ToList(); // Crea una lista de objetos anonimos con las columnas deseadas

                    dataGridViewVideojuegos.DataSource = listaMostrar; // Asigna la lista de objetos anonimos al DataSource del DataGridView dataGridViewVideojuegos
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al cargar los videojuegos: " + ex.Message); // Muestra un mensaje de error
            }
        }

        private void button1_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Registrar
        {
            try
            {
                // Validar que se haya seleccionado un videojuego.
                if (dataGridViewVideojuegos.SelectedRows.Count == 0) // Verifica si no hay filas seleccionadas en el DataGridView dataGridViewVideojuegos
                {
                    MessageBox.Show("Por favor, seleccione un videojuego."); // Muestra un mensaje de advertencia
                    return; // Sale del metodo
                }

                // Validar que la cantidad digitada sea un numero mayor a 0.
                if (!int.TryParse(textBoxCantidad.Text, out int cantidad) || cantidad <= 0) // Verifica si el valor del campo cantidad es un numero entero mayor que cero
                {
                    MessageBox.Show("La cantidad debe ser un numero mayor a 0."); // Muestra un mensaje de advertencia
                    return; // Sale del metodo
                }

                // Obtenemos el indice de la fila seleccionada.
                int indiceSeleccionado = dataGridViewVideojuegos.SelectedRows[0].Index; // Obtiene el indice de la fila seleccionada
                VideojuegosXTiendaEntidad videojuegoSeleccionado = listaOriginal[indiceSeleccionado]; // Obtiene el videojuego seleccionado de la lista original

                // Validar que existan suficientes existencias.
                if (videojuegoSeleccionado.Existencias < cantidad) // Verifica si no hay suficientes existencias para realizar la reserva
                {
                    MessageBox.Show("No hay suficientes existencias para realizar la reserva."); // Muestra un mensaje de advertencia
                    return; // Sale del metodo
                }

                // Crear el objeto de reserva.
                ReservaEntidad reserva = new ReservaEntidad(
                    0, // IdReserva se asigna automaticamente en la base de datos.
                    videojuegoSeleccionado,
                    Program.ClienteActual, // Asegurate de tener definido y asignado ClienteActual.
                    dateTimePickerReserva.Value,
                    cantidad
                ); // Crea una nueva instancia de ReservaEntidad

                // Usamos la logica de negocios para crear la reserva.
                LogicaReserva logicaReserva = new LogicaReserva(); // Crea una instancia de LogicaReserva
                string resultado = logicaReserva.CrearReserva(reserva); // Llama al metodo CrearReserva y almacena el resultado
                MessageBox.Show(resultado); // Muestra el resultado en un MessageBox

                if (resultado.Contains("exitosamente")) // Verifica si el resultado contiene la palabra "exitosamente"
                {
                    // Refrescar el DataGridView para mostrar los videojuegos con las existencias actualizadas.
                    RefrescarVideojuegos(); // Llama al metodo RefrescarVideojuegos
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error: " + ex.Message); // Muestra un mensaje de error
            }
        }

        private void RefrescarVideojuegos() // Metodo para refrescar la lista de videojuegos en el DataGridView
        {
            try
            {
                if (comboBoxTiendas.SelectedValue == null) // Verifica si no hay un valor seleccionado en el ComboBox comboBoxTiendas
                    return; // Sale del metodo

                int tiendaId = 0; // Declara una variable para almacenar el ID de la tienda
                if (comboBoxTiendas.SelectedValue is int) // Verifica si el valor seleccionado es un entero
                    tiendaId = (int)comboBoxTiendas.SelectedValue; // Asigna el valor seleccionado a la variable tiendaId
                else if (comboBoxTiendas.SelectedValue is TiendaEntidad tienda) // Verifica si el valor seleccionado es una instancia de TiendaEntidad
                    tiendaId = tienda.Id; // Asigna el ID de la tienda a la variable tiendaId
                else
                    tiendaId = Convert.ToInt32(comboBoxTiendas.SelectedValue); // Convierte el valor seleccionado a entero y lo asigna a la variable tiendaId

                DatosVideojuego datosVideojuego = new DatosVideojuego(); // Crea una instancia de DatosVideojuego
                List<VideojuegosXTiendaEntidad> listaVideojuegos = datosVideojuego.ObtenerVideojuegosPorTienda(tiendaId); // Obtiene la lista de videojuegos por tienda desde la base de datos

                if (listaVideojuegos == null || listaVideojuegos.Count == 0) // Verifica si no hay videojuegos disponibles en la tienda
                {
                    MessageBox.Show("No hay videojuegos disponibles en esta tienda."); // Muestra un mensaje de advertencia
                    dataGridViewVideojuegos.DataSource = null; // Limpia el DataGridView dataGridViewVideojuegos
                }
                else
                {
                    // Actualizamos la lista original.
                    listaOriginal = listaVideojuegos; // Asigna la lista de videojuegos a la variable listaOriginal

                    // Preparamos la proyeccion para el DataGridView.
                    var listaMostrar = listaVideojuegos.Select(v => new
                    {
                        Tienda = v.Tienda.Nombre,
                        Videojuego = v.Videojuego.Nombre,
                        Existencias = v.Existencias
                    }).ToList(); // Crea una lista de objetos anonimos con las columnas deseadas

                    dataGridViewVideojuegos.DataSource = listaMostrar; // Asigna la lista de objetos anonimos al DataSource del DataGridView dataGridViewVideojuegos
                }
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al refrescar la lista de videojuegos: " + ex.Message); // Muestra un mensaje de error
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)