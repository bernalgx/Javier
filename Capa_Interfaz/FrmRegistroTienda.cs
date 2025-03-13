//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Capa_Interfaz;
//using Capa_Log_Negocio;
//using Capa_Entidades;


//namespace Capa_Interfaz
//{
//    public partial class FrmRegistroTienda : Form
//    {
//        private LogTienda logica = new LogTienda();
//        public FrmRegistroTienda()
//        {
//            InitializeComponent();
//        }

//        private void btnRegistrar_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                int id = int.Parse(txtId.Text);
//                string nombre = txtNombre.Text;
//                var administrador = (AdministradorEntidad)cmbAdministrador.SelectedItem;
//                string direccion = txtDireccion.Text;
//                string telefono = txtTelefono.Text;
//                bool activa = cmbActiva.SelectedItem.ToString() == "Si";

//                string mensaje = logica.RegistrarTienda(id, nombre, administrador, direccion, telefono, activa);
//                MessageBox.Show(mensaje);

//                txtId.Clear();
//                txtNombre.Clear();
//                txtDireccion.Clear();
//                txtTelefono.Clear();
//                cmbAdministrador.SelectedIndex = -1;
//                cmbActiva.SelectedIndex = -1;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex.Message);
//            }

//        }
//    }
//}
