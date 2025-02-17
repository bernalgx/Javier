using System; // Importa funcionalidades básicas del sistema
using System.Linq; // Permite el uso de consultas LINQ
using System.Windows.Forms; // Importa componentes de Windows Forms
using Capa_Entidades; // Importa las entidades del sistema


namespace Capa_Interfaz // Espacio de nombres para la capa de interfaz
{
    public partial class FrmConsultaInventario : Form  // Define un formulario para consultar el inventario
    {
        public VideojuegosXTiendaEntidad[] inventario; // Arreglo que almacena los videojuegos en inventario

        public FrmConsultaInventario(VideojuegosXTiendaEntidad[] inventario) // Constructor que recibe el inventario
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
            this.Inventario1 = inventario; // Asigna el inventario recibido a la propiedad
            CargarDatos(); // Llama al metodo para cargar los datos en la interfaz
        }

        public VideojuegosXTiendaEntidad[] Inventario1 { get => inventario; set => inventario = value; } // Propiedad para acceder al inventario

        private void CargarDatos() // Metodo para cargar los datos en la tabla
        {
            try
            {
                dgvDatos.DataSource = Inventario1.Where(i => i != null).Select(i => new // Filtra elementos no nulos
                {
                    TiendaID = i.Tienda.Id, // ID de la tienda
                    TiendaNombre = i.Tienda.Nombre, // Nombre de la tienda
                    TiendaDireccion = i.Tienda.Direccion, // Direccion de la tienda
                    VideojuegoID = i.Videojuego.Id,  // ID del videojuego
                    VideojuegoNombre = i.Videojuego.Nombre, // Nombre del videojuego
                    TipoVideojuego = i.Videojuego.TipoVideojuego.Nombre,// Tipo de videojuego
                    Existencias = i.Existencias // Cantidad disponible en inventario
                }).ToList(); // Convierte el resultado en una lista para asignarlo al DataGridView
            }
            catch (Exception ex) // Captura errores en la carga de datos
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message); // Muestra un mensaje en caso de error
            }
        }
    }
}