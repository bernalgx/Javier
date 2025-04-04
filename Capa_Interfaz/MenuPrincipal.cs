using Capa_Log_Negocio;

namespace Capa_Interfaz
{
	public partial class MenuPrincipal : Form
	{
		public MenuPrincipal()
		{
			InitializeComponent();
		}

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


		private void btnRegistroAdministradores_Click(object sender, EventArgs e)
		{
			FrmRegistroAdministrador form = new FrmRegistroAdministrador();
			form.ShowDialog();
		}

		private void btnConsultaAdministradores_Click(object sender, EventArgs e)
		{
			FrmConsultaAdministrador form = new FrmConsultaAdministrador();
			form.ShowDialog();
		}


		private void btnRegistroTiendas_Click(object sender, EventArgs e)
		{
			FrmRegistroTienda form = new FrmRegistroTienda();
			form.ShowDialog();
		}

		private void btnConsultaTienda_Click(object sender, EventArgs e)
		{
			FrmConsultaTiendas form = new FrmConsultaTiendas();
			form.ShowDialog();
		}

		private void btnRegistroClientes_Click(object sender, EventArgs e)
		{
			FrmRegistroCliente form = new FrmRegistroCliente();
			form.ShowDialog();
		}

		private void btnConsultaClientes_Click(object sender, EventArgs e)
		{
			FrmConsultaClientes form = new FrmConsultaClientes();
			form.ShowDialog();
		}

		private void btnRegistroTipoVideojuego_Click(object sender, EventArgs e)
		{
			FrmRegistroTipoVideojuego form = new FrmRegistroTipoVideojuego();
			form.ShowDialog();
		}

		private void btnConsultaTipoVideojuego_Click(object sender, EventArgs e)
		{
			FrmConsultaVideoJuegos form = new FrmConsultaVideoJuegos();
			form.ShowDialog();
		}

		private void btnCosultaInventario(object sender, EventArgs e)
		{
			FrmConsultaVideoJuegos form = new FrmConsultaVideoJuegos();
			form.ShowDialog();
		}

		private void btnConsultaInventario_Click(object sender, EventArgs e)
		{
			FrmConsultaInventario form = new FrmConsultaInventario();
			form.ShowDialog();

		}

		private void btnRegistroInventario_Click(object sender, EventArgs e)
		{
			FrmRegistroInventario form = new FrmRegistroInventario();
			form.ShowDialog();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			FrmRegistroReserva form = new FrmRegistroReserva();
			form.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FrmConsultarReserva form = new FrmConsultarReserva();
			form.ShowDialog();
		}
	}

}

