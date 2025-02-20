//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Capa_Interfaz
//{
    // Formulario para registrar administradores
//    public partial class FrmRegistroAdministrador : Form
//    {
//        private LogAdministrador logica = new LogicaAdministrador();

//        public FrmRegistroAdministrador()
 //       {
 //           InitializeComponent();
//        }

        // Evento del boton para registrar un administrador
//        private void btnRegistrar_Click(object sender, EventArgs e)
 //       {
 //           try
 //           {
//                int identificacion = int.Parse(txtIdentificacion.Text);
 //               string nombre = txtNombre.Text;
//                string primerApellido = txtPrimerApellido.Text;
//                string segundoApellido = txtSegundoApellido.Text;
//                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
//                DateTime fechaContratacion = dtpFechaContratacion.Value;

//                string mensaje = logica.RegistroAdministrador(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento, fechaContratacion);
//                MessageBox.Show(mensaje);

                // Limpiar los campos despues de registrar
 //               txtIdentificacion.Clear();
 //               txtNombre.Clear();
 //               txtPrimerApellido.Clear();
 //               txtSegundoApellido.Clear();
 //               dtpFechaNacimiento.Value = DateTime.Today;
 //               dtpFechaContratacion.Value = DateTime.Today;
 //           }
 //           catch (FormatException)
 //           {
 //               MessageBox.Show("Error: Ingrese valores numéricos en la identificación.");
 //           }
  //          catch (Exception ex)
 //           {
 //               MessageBox.Show("Error inesperado: " + ex.Message);
 //           }
 //       }
//    }
//}
