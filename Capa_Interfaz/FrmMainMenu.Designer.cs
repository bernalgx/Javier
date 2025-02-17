namespace Capa_Interfaz // Espacio de nombres para la capa de interfaz
{
    public partial class FrmMenuPrincipal : Form // Formulario principal del menu
    {
        public FrmMenuPrincipal() // Constructor del formulario
        {
            InitializeComponent(); // Inicializa los componentes visuales
        }

        private void btnAdministradores_Click(object sender, EventArgs e) // Evento al hacer clic en "Administradores"
        {
            FrmRegistroAdministrador form = new FrmRegistroAdministrador(); // Crea instancia del formulario
            form.ShowDialog(); // Muestra el formulario como modal
        }

        private void btnClientes_Click(object sender, EventArgs e) // Evento al hacer clic en "Clientes"
        {
            FrmRegistroCliente form = new FrmRegistroCliente(); // Crea instancia del formulario
            form.ShowDialog(); // Muestra el formulario como modal
        }

        private void btnTiendas_Click(object sender, EventArgs e) // Evento al hacer clic en "Tiendas"
        {
            FrmRegistroTienda form = new FrmRegistroTienda(); // Crea instancia del formulario
            form.ShowDialog(); // Muestra el formulario como modal
        }

        private void btnVideojuegos_Click(object sender, EventArgs e) // Evento al hacer clic en "Videojuegos"
        {
            FrmRegistroVideojuego form = new FrmRegistroVideojuego(); // Crea instancia del formulario
            form.ShowDialog(); // Muestra el formulario como modal
        }

        private void btnInventario_Click(object sender, EventArgs e) // Evento al hacer clic en "Inventario"
        {
            // Se debe proporcionar el inventario como argumento
            VideojuegosXTiendaEntidad[] inventario = ObtenerInventario(); // Metodo ficticio para obtener inventario
            FrmConsultaInventario form = new FrmConsultaInventario(inventario); // Pasa el inventario al formulario
            form.ShowDialog(); // Muestra el formulario como modal
        }

        private VideojuegosXTiendaEntidad[] ObtenerInventario() // Metodo ficticio para obtener el inventario
        {
            return new VideojuegosXTiendaEntidad[0]; // Retorna un array vacio (se debe reemplazar con la logica real)
        }
    }
}