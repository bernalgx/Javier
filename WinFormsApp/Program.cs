
using System;
using System.Windows.Forms;
using Capa_Acceso_Datos;
using Capa_Entidades;


//Github test  

namespace WinFormsApp
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            CrearMenu(); // Genera el menu dinamicamente
        }

        private void CrearMenu()
        {
            // Crear el menu principal
            MenuStrip menuStrip = new MenuStrip();
            
            // Secciones del menu
            ToolStripMenuItem menuRegistro = new ToolStripMenuItem("Registrar");
            ToolStripMenuItem menuConsulta = new ToolStripMenuItem("Consultar");
            ToolStripMenuItem menuSalir = new ToolStripMenuItem("Salir", null, Salir_Click);

            // Opciones de Registro
            menuRegistro.DropDownItems.Add("Tipos de Videojuegos", null, AbrirRegistroTipos);
            menuRegistro.DropDownItems.Add("Videojuegos", null, AbrirRegistroVideojuegos);
            menuRegistro.DropDownItems.Add("Administradores", null, AbrirRegistroAdministradores);
            menuRegistro.DropDownItems.Add("Tiendas", null, AbrirRegistroTiendas);
            menuRegistro.DropDownItems.Add("Clientes", null, AbrirRegistroClientes);
            menuRegistro.DropDownItems.Add("Inventario", null, AbrirRegistroInventario);

            // Opciones de Consulta
            menuConsulta.DropDownItems.Add("Tipos de Videojuegos", null, AbrirConsultaTipos);
            menuConsulta.DropDownItems.Add("Videojuegos", null, AbrirConsultaVideojuegos);
            menuConsulta.DropDownItems.Add("Administradores", null, AbrirConsultaAdministradores);
            menuConsulta.DropDownItems.Add("Tiendas", null, AbrirConsultaTiendas);
            menuConsulta.DropDownItems.Add("Clientes", null, AbrirConsultaClientes);
            menuConsulta.DropDownItems.Add("Inventario", null, AbrirConsultaInventario);

            // Agrega los menus al MenuStrip
            menuStrip.Items.Add(menuRegistro);
            menuStrip.Items.Add(menuConsulta);
            menuStrip.Items.Add(menuSalir);

            // Agrega el menu al formulario
            this.MainMenuStrip = menuStrip;
            Controls.Add(menuStrip);
        }

        // Metodos para abrir los formularios de registro
        private void AbrirRegistroTipos(object sender, EventArgs e) => new FormRegistroTipoVideojuego().ShowDialog();
        private void AbrirRegistroVideojuegos(object sender, EventArgs e) => new FormRegistroVideojuego().ShowDialog();
        private void AbrirRegistroAdministradores(object sender, EventArgs e) => new FormRegistroAdministrador().ShowDialog();
        private void AbrirRegistroTiendas(object sender, EventArgs e) => new FormRegistroTienda().ShowDialog();
        private void AbrirRegistroClientes(object sender, EventArgs e) => new FormRegistroCliente().ShowDialog();
        private void AbrirRegistroInventario(object sender, EventArgs e) => new FormRegistroInventario().ShowDialog();

        // Metodos para abrir los formularios de consulta
        private void AbrirConsultaTipos(object sender, EventArgs e) => new FormConsultaTipoVideojuego().ShowDialog();
        private void AbrirConsultaVideojuegos(object sender, EventArgs e) => new FormConsultaVideojuego().ShowDialog();
        private void AbrirConsultaAdministradores(object sender, EventArgs e) => new FormConsultaAdministrador().ShowDialog();
        private void AbrirConsultaTiendas(object sender, EventArgs e) => new FormConsultaTienda().ShowDialog();
        private void AbrirConsultaClientes(object sender, EventArgs e) => new FormConsultaCliente().ShowDialog();
        private void AbrirConsultaInventario(object sender, EventArgs e) => new FormConsultaInventario().ShowDialog();

        // Metodo para salir de la aplicacion
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
