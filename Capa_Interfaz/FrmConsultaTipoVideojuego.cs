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
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capa_Interfaz
{
    public partial class FrmConsultaTipoVideojuego : Form // Define la clase FrmConsultaTipoVideojuego que hereda de Form
    {
        // Instancia para gestionar la logica de tipos de videojuegos
        private LogTipoVideojuego logicaTipo = new LogTipoVideojuego(); // Declara una variable privada de tipo LogTipoVideojuego e inicializa una nueva instancia

        // Constructor sin parametros
        public FrmConsultaTipoVideojuego()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            logicaTipo = new LogTipoVideojuego(); // Inicializa la variable logicaTipo con una nueva instancia de LogTipoVideojuego
            CargarTiposVideojuego(); // Llama al metodo CargarTiposVideojuego
        }

        private void CargarTiposVideojuego() // Metodo para cargar los tipos de videojuegos en el DataGridView
        {
            try
            {
                List<TipoVideojuegoEntidad> lista = logicaTipo.ObtenerTiposVideojuego(); // Obtiene la lista de tipos de videojuegos desde la logica de negocio
                dgvTiposVideojuego.DataSource = lista; // Asigna la lista de tipos de videojuegos al DataSource del DataGridView

                if (lista.Count == 0) // Verifica si la lista esta vacia
                {
                    MessageBox.Show("No hay tipos de videojuegos registrados.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); // Muestra un mensaje informativo
                }

                ConfigurarDataGridView(); // Llama al metodo ConfigurarDataGridView
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al cargar tipos de videojuegos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Muestra un mensaje de error
            }
        }

        private void ConfigurarDataGridView() // Metodo para configurar el DataGridView
        {
            dgvTiposVideojuego.Columns["Id"].HeaderText = "ID"; // Configura el encabezado de la columna Id
            dgvTiposVideojuego.Columns["Nombre"].HeaderText = "Nombre"; // Configura el encabezado de la columna Nombre
            dgvTiposVideojuego.Columns["Descripcion"].HeaderText = "Descripcion"; // Configura el encabezado de la columna Descripcion
            dgvTiposVideojuego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Configura el modo de ajuste de columnas del DataGridView
        }

        private void btnEditar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Editar
        {
            if (dgvTiposVideojuego.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
            {
                TipoVideojuegoEntidad tipoVideojuego = new TipoVideojuegoEntidad // Crea una nueva instancia de TipoVideojuegoEntidad
                {
                    Id = Convert.ToDecimal(dgvTiposVideojuego.SelectedRows[0].Cells["Id"].Value), // Asigna el valor de la celda Id
                    Nombre = dgvTiposVideojuego.SelectedRows[0].Cells["Nombre"].Value.ToString(), // Asigna el valor de la celda Nombre
                    Descripcion = dgvTiposVideojuego.SelectedRows[0].Cells["Descripcion"].Value.ToString() // Asigna el valor de la celda Descripcion
                };

                FrmEditarTipoVideojuego frmEditar = new FrmEditarTipoVideojuego(tipoVideojuego); // Crea una nueva instancia de FrmEditarTipoVideojuego
                if (frmEditar.ShowDialog() == DialogResult.OK) // Muestra el formulario FrmEditarTipoVideojuego y verifica si el resultado es OK
                {
                    LogTipoVideojuego log = new LogTipoVideojuego(); // Crea una instancia de LogTipoVideojuego
                    string resultado = log.EditarTipoVideojuego(frmEditar.TipoVideojuego); // Llama al metodo EditarTipoVideojuego y almacena el resultado
                    MessageBox.Show(resultado); // Muestra el resultado en un MessageBox
                    CargarTiposVideojuego(); // Llama al metodo CargarTiposVideojuego
                }
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de videojuego para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje si no hay filas seleccionadas
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Eliminar
        {
            if (dgvTiposVideojuego.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
            {
                decimal id = Convert.ToDecimal(dgvTiposVideojuego.SelectedRows[0].Cells["Id"].Value); // Obtiene el valor de la celda Id

                if (MessageBox.Show("¿Estas seguro de eliminar este tipo de videojuego?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // Muestra un mensaje de confirmacion
                {
                    LogTipoVideojuego log = new LogTipoVideojuego(); // Crea una instancia de LogTipoVideojuego
                    string resultado = log.EliminarTipoVideojuego((int)id); // Llama al metodo EliminarTipoVideojuego y almacena el resultado
                    MessageBox.Show(resultado); // Muestra el resultado en un MessageBox
                    CargarTiposVideojuego(); // Llama al metodo CargarTiposVideojuego
                }
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de videojuego para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje si no hay filas seleccionadas
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)