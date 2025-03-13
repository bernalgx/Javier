using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Log_Negocio;
using Capa_Entidades;

namespace Capa_Interfaz
{
	public partial class FrmRegistroAdministrador : Form
	{
		//private LogAdministrador logica = new LogAdministrador();

		//public FrmRegistroAdministrador()
		//{
		//	InitializeComponent();
		//}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	int identificacion = int.Parse(txtIdentificacion.Text);
			//	string nombre = txtNombre.Text;
			//	string primerApellido = txtPrimerApellido.Text;
			//	string segundoApellido = txtSegundoApellido.Text;
			//	DateTime fechaNacimiento = dtpFechaNacimiento.Value;
			//	DateTime fechaContratacion = dtpFechaContratacion.Value;

			//	string mensaje = LogAdministrador.RegistroAdministrador(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento, fechaContratacion);
			//	MessageBox.Show(mensaje);

			//	txtIdentificacion.Clear();
			//	txtNombre.Clear();
			//	txtPrimerApellido.Clear();
			//	txtSegundoApellido.Clear();
			//	dtpFechaNacimiento.Value = DateTime.Today;
			//	dtpFechaContratacion.Value = DateTime.Today;
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show("Error: " + ex.Message);
			//}

		}
	}
}
