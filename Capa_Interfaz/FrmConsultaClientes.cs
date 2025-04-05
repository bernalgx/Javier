// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
    public partial class FrmConsultaClientes : Form // Define la clase FrmConsultaClientes que hereda de Form
    {
        private LogCliente logicaCliente = new LogCliente(); // Declara una variable privada de tipo LogCliente e inicializa una nueva instancia

        public FrmConsultaClientes() // Constructor de la clase FrmConsultaClientes
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            CargarClientes(); // Llama al metodo CargarClientes
            ConfigurarDataGridView(); // Llama al metodo ConfigurarDataGridView
        }

        private void CargarClientes() // Metodo para cargar los clientes en el DataGridView
        {
            try
            {
                var clientes = logicaCliente.ObtenerClientesDesdeBD(); // Obtiene la lista de clientes desde la base de datos
                dgvClientes.DataSource = clientes; // Asigna la lista de clientes al DataSource del DataGridView
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Muestra un mensaje de error
            }
        }

        private void ConfigurarDataGridView() // Metodo para configurar el DataGridView
        {
            // Configurar columnas
            dgvClientes.Columns["Identificacion"].HeaderText = "Identificacion"; // Configura el encabezado de la columna Identificacion
            dgvClientes.Columns["Nombre"].HeaderText = "Nombre"; // Configura el encabezado de la columna Nombre
            dgvClientes.Columns["PrimerApellido"].HeaderText = "Primer Apellido"; // Configura el encabezado de la columna PrimerApellido
            dgvClientes.Columns["SegundoApellido"].HeaderText = "Segundo Apellido"; // Configura el encabezado de la columna SegundoApellido
            dgvClientes.Columns["FechaNacimiento"].HeaderText = "Fecha Nacimiento"; // Configura el encabezado de la columna FechaNacimiento
            dgvClientes.Columns["JugadorEnLinea"].HeaderText = "Jugador en Linea"; // Configura el encabezado de la columna JugadorEnLinea

            // Formato de columnas
            dgvClientes.Columns["FechaNacimiento"].DefaultCellStyle.Format = "d"; // Formato corto de fecha para la columna FechaNacimiento
            dgvClientes.Columns["JugadorEnLinea"].DefaultCellStyle.Format = "Si;No"; // Mostrar Si/No para booleanos en la columna JugadorEnLinea

            // Hacer que el DataGridView sea de solo lectura
            dgvClientes.ReadOnly = true; // Configura el DataGridView como solo lectura
            dgvClientes.AllowUserToAddRows = false; // Deshabilita la adicion de filas por el usuario
            dgvClientes.AllowUserToDeleteRows = false; // Deshabilita la eliminacion de filas por el usuario

            // Seleccion de fila completa
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Configura el modo de seleccion de fila completa
        }

        private void btnEditar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Editar
        {
            if (dgvClientes.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
            {
                var clienteSeleccionado = ObtenerClienteSeleccionado(); // Obtiene el cliente seleccionado
                var frmEditar = new FrmEditarCliente(clienteSeleccionado); // Crea una nueva instancia de FrmEditarCliente

                if (frmEditar.ShowDialog() == DialogResult.OK) // Muestra el formulario FrmEditarCliente y verifica si el resultado es OK
                {
                    string resultado = logicaCliente.EditarCliente(frmEditar.Cliente); // Llama al metodo EditarCliente y almacena el resultado
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information); // Muestra el resultado en un MessageBox
                    CargarClientes(); // Llama al metodo CargarClientes
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje si no hay filas seleccionadas
            }
        }

        private ClienteEntidad ObtenerClienteSeleccionado() // Metodo para obtener el cliente seleccionado
        {
            DataGridViewRow fila = dgvClientes.SelectedRows[0]; // Obtiene la fila seleccionada
            return new ClienteEntidad // Crea una nueva instancia de ClienteEntidad
            {
                Identificacion = Convert.ToInt32(fila.Cells["Identificacion"].Value), // Asigna el valor de la celda Identificacion
                Nombre = fila.Cells["Nombre"].Value.ToString(), // Asigna el valor de la celda Nombre
                PrimerApellido = fila.Cells["PrimerApellido"].Value.ToString(), // Asigna el valor de la celda PrimerApellido
                SegundoApellido = fila.Cells["SegundoApellido"].Value.ToString(), // Asigna el valor de la celda SegundoApellido
                FechaNacimiento = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value), // Asigna el valor de la celda FechaNacimiento
                JugadorEnLinea = Convert.ToBoolean(fila.Cells["JugadorEnLinea"].Value) // Asigna el valor de la celda JugadorEnLinea
            };
        }

        private void btnEliminar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Eliminar
        {
            if (dgvClientes.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar este cliente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // Muestra un mensaje de confirmacion
                {
                    int identificacion = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Identificacion"].Value); // Obtiene el valor de la celda Identificacion
                    string resultado = logicaCliente.EliminarCliente(identificacion); // Llama al metodo EliminarCliente y almacena el resultado
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information); // Muestra el resultado en un MessageBox
                    CargarClientes(); // Llama al metodo CargarClientes
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje si no hay filas seleccionadas
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
