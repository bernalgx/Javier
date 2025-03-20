using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
	public partial class MenuPrincipal : Form
	{
		public MenuPrincipal()
		{
			InitializeComponent();
		}

		//private void Administradores_Click(object sender, EventArgs e)
		//{
		//	FrmRegistroAdministrador form = new FrmRegistroAdministrador();
		//	form.ShowDialog();
		//}

		//private void Clientes_Click(object sender, EventArgs e)
		//{
		//	FrmRegistroCliente form = new FrmRegistroCliente();
		//	form.ShowDialog();
		//}

		//private void Tienda_Click(object sender, EventArgs e)
		//{
		//	FrmRegistroTienda form = new FrmRegistroTienda();
		//	form.ShowDialog();

		//}


		// Instancia compartida de LogTipoVideojuego
		private LogTipoVideojuego logicaTipo = new LogTipoVideojuego();


		private void VideoJuego_Click(object sender, EventArgs e)
		{
			FrmRegistroVideojuego form = new FrmRegistroVideojuego(logicaTipo);
			form.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			FrmConsultaVideoJuegos form = new FrmConsultaVideoJuegos();
			form.ShowDialog();
		}

	}


	//private void Inventario_Click(object sender, EventArgs e)
	//{
	//	FrmConsultaInventario form = new FrmConsultaInventario();
	//	form.ShowDialog();
	//}
}
