//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Capa_Interfaz;
//using Capa_Entidades;


//namespace Capa_Interfaz
//{
//    public partial class FrmConsultaClientes : Form
//    {
//        private ClienteEntidad[] clientes;
//        public FrmConsultaClientes()
//        {
//            InitializeComponent();
//            this.clientes = clientes;
//        }

//        private void btnCargarDatos_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                dgvClientes.DataSource = clientes.Where(c => c != null).ToList();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error al cargar los datos: " + ex.Message);
//            }

//        }
//    }
//}
