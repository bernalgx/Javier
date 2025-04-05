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
    public partial class FrmConsultaVideoJuegos : Form // Define la clase FrmConsultaVideoJuegos que hereda de Form
    {
        // Instancia compartida para gestionar los tipos de videojuegos
        private LogTipoVideojuego logicaTipo = new LogTipoVideojuego(); // Declara una variable privada de tipo LogTipoVideojuego e inicializa una nueva instancia

        // Constructor sin parametros
        public FrmConsultaVideoJuegos()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void button1_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Editar
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
            {
                // Obtener el videojuego seleccionado
                VideojuegoEntidad videojuego = new VideojuegoEntidad
                {
                    Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value), // Asigna el valor de la celda Id
                    Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString(), // Asigna el valor de la celda Nombre
                    Desarrollador = dataGridView1.SelectedRows[0].Cells["Desarrollador"].Value.ToString(), // Asigna el valor de la celda Desarrollador
                    Lanzamiento = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Lanzamiento"].Value), // Asigna el valor de la celda Lanzamiento
                    Fisico = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Fisico"].Value), // Asigna el valor de la celda Fisico
                    Id_TipoVideojuego = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id_TipoVideojuego"].Value) // Asigna el valor de la celda Id_TipoVideojuego
                };

                // Abrir un formulario de edicion, pasandole el objeto
                FrmEditarVideojuego frmEditar = new FrmEditarVideojuego(videojuego); // Crea una nueva instancia de FrmEditarVideojuego
                if (frmEditar.ShowDialog() == DialogResult.OK) // Muestra el formulario FrmEditarVideojuego y verifica si el resultado es OK
                {
                    // Despues de la edicion, se obtiene el objeto modificado del formulario
                    VideojuegoEntidad videojuegoEditado = frmEditar.Videojuego; // Obtiene el videojuego editado del formulario
                    LogVideojuego log = new LogVideojuego(); // Crea una instancia de LogVideojuego
                    string resultado = log.EditarVideojuego(videojuegoEditado); // Llama al metodo EditarVideojuego y almacena el resultado
                    MessageBox.Show(resultado); // Muestra el resultado en un MessageBox
                    CargarVideojuegos(); // Llama al metodo CargarVideojuegos
                }
            }
            else
            {
                MessageBox.Show("Selecciona un videojuego para editar."); // Muestra un mensaje si no hay filas seleccionadas
            }
        }

        private void button2_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Eliminar
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas en el DataGridView
            {
                // Supongamos que la columna "Id" es la primera columna del DataGridView
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value); // Obtiene el valor de la celda Id

                LogVideojuego log = new LogVideojuego(); // Crea una instancia de LogVideojuego
                string resultado = log.EliminarVideojuego(id); // Llama al metodo EliminarVideojuego y almacena el resultado
                MessageBox.Show(resultado); // Muestra el resultado en un MessageBox
                                            // Recargar la grilla
                CargarVideojuegos(); // Llama al metodo CargarVideojuegos
            }
            else
            {
                MessageBox.Show("Selecciona un videojuego para eliminar."); // Muestra un mensaje si no hay filas seleccionadas
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)