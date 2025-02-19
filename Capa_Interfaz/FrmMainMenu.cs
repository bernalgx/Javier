using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Interfaz
{
    // Formulario principal de la aplicacion
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        // Evento para abrir el formulario de administradores
        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            FrmRegistrarAdministrador form = new FrmRegistrarAdministrador();
            form.ShowDialog();
        }

        // Evento para abrir el formulario de clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente form = new FrmRegistrarCliente();
            form.ShowDialog();
        }

        // Evento para abrir el formulario de tiendas
        private void btnTiendas_Click(object sender, EventArgs e)
        {
            FrmRegistrarTienda form = new FrmRegistrarTienda();
            form.ShowDialog();
        }

        // Evento para abrir el formulario de videojuegos
        private void btnVideojuegos_Click(object sender, EventArgs e)
        {
            FrmRegistrarVideojuego form = new FrmRegistrarVideojuego();
            form.ShowDialog();
        }

        // Evento para abrir el formulario de inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmConsultarInventario form = new FrmConsultarInventario();
            form.ShowDialog();
        }
    }
}
