namespace Capa_Interfaz
{
	partial class MenuPrincipal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnRegistroAdministradores = new Button();
			btnRegistroClientes = new Button();
			btnRegistroTienda = new Button();
			btnRegistroVideojuegos = new Button();
			btnRegistroInventario = new Button();
			btnConsultaVideoJuegos = new Button();
			btnRegistroTipoVideojuego = new Button();
			btnConsultaTipoVideojuego = new Button();
			btnConsultaAdministradores = new Button();
			btnConsultaTiendas = new Button();
			btnConsultaInventario = new Button();
			btnConsultaClientes = new Button();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// btnRegistroAdministradores
			// 
			btnRegistroAdministradores.BackColor = SystemColors.ButtonHighlight;
			btnRegistroAdministradores.Location = new Point(47, 191);
			btnRegistroAdministradores.Name = "btnRegistroAdministradores";
			btnRegistroAdministradores.Size = new Size(149, 38);
			btnRegistroAdministradores.TabIndex = 0;
			btnRegistroAdministradores.Text = "Registrar Administradores";
			btnRegistroAdministradores.UseVisualStyleBackColor = false;
			btnRegistroAdministradores.Click += btnRegistroAdministradores_Click;
			// 
			// btnRegistroClientes
			// 
			btnRegistroClientes.BackColor = SystemColors.ButtonHighlight;
			btnRegistroClientes.Location = new Point(47, 556);
			btnRegistroClientes.Name = "btnRegistroClientes";
			btnRegistroClientes.Size = new Size(149, 33);
			btnRegistroClientes.TabIndex = 1;
			btnRegistroClientes.Text = "Registrar Clientes";
			btnRegistroClientes.UseVisualStyleBackColor = false;
			btnRegistroClientes.Click += btnRegistroClientes_Click;
			// 
			// btnRegistroTienda
			// 
			btnRegistroTienda.BackColor = SystemColors.ButtonHighlight;
			btnRegistroTienda.Location = new Point(47, 324);
			btnRegistroTienda.Name = "btnRegistroTienda";
			btnRegistroTienda.Size = new Size(149, 29);
			btnRegistroTienda.TabIndex = 2;
			btnRegistroTienda.Text = "Registrar Tienda";
			btnRegistroTienda.UseVisualStyleBackColor = false;
			btnRegistroTienda.Click += btnRegistroTiendas_Click;
			// 
			// btnRegistroVideojuegos
			// 
			btnRegistroVideojuegos.BackColor = SystemColors.ButtonHighlight;
			btnRegistroVideojuegos.Location = new Point(50, 116);
			btnRegistroVideojuegos.Name = "btnRegistroVideojuegos";
			btnRegistroVideojuegos.Size = new Size(146, 28);
			btnRegistroVideojuegos.TabIndex = 3;
			btnRegistroVideojuegos.Text = "Registrar VideoJuego";
			btnRegistroVideojuegos.UseVisualStyleBackColor = false;
			btnRegistroVideojuegos.Click += VideoJuego_Click;
			// 
			// btnRegistroInventario
			// 
			btnRegistroInventario.BackColor = SystemColors.ButtonHighlight;
			btnRegistroInventario.Location = new Point(47, 438);
			btnRegistroInventario.Name = "btnRegistroInventario";
			btnRegistroInventario.Size = new Size(149, 29);
			btnRegistroInventario.TabIndex = 4;
			btnRegistroInventario.Text = "Registrar Inventario";
			btnRegistroInventario.UseVisualStyleBackColor = false;
			btnRegistroInventario.Click += btnRegistroInventario_Click;
			// 
			// btnConsultaVideoJuegos
			// 
			btnConsultaVideoJuegos.BackColor = SystemColors.ButtonFace;
			btnConsultaVideoJuegos.Location = new Point(264, 116);
			btnConsultaVideoJuegos.Name = "btnConsultaVideoJuegos";
			btnConsultaVideoJuegos.Size = new Size(149, 28);
			btnConsultaVideoJuegos.TabIndex = 5;
			btnConsultaVideoJuegos.Text = "Consultar VideoJuego";
			btnConsultaVideoJuegos.UseVisualStyleBackColor = false;
			btnConsultaVideoJuegos.Click += button1_Click;
			// 
			// btnRegistroTipoVideojuego
			// 
			btnRegistroTipoVideojuego.Location = new Point(47, 41);
			btnRegistroTipoVideojuego.Name = "btnRegistroTipoVideojuego";
			btnRegistroTipoVideojuego.Size = new Size(149, 42);
			btnRegistroTipoVideojuego.TabIndex = 13;
			btnRegistroTipoVideojuego.Text = "Registrar Tipo Videojuego:";
			btnRegistroTipoVideojuego.Click += btnRegistroTipoVideojuego_Click;
			// 
			// btnConsultaTipoVideojuego
			// 
			btnConsultaTipoVideojuego.Location = new Point(264, 41);
			btnConsultaTipoVideojuego.Name = "btnConsultaTipoVideojuego";
			btnConsultaTipoVideojuego.Size = new Size(149, 42);
			btnConsultaTipoVideojuego.TabIndex = 12;
			btnConsultaTipoVideojuego.Text = "Consultar Tipo Videojuego:";
			btnConsultaTipoVideojuego.Click += btnConsultaTipoVideojuego_Click;
			// 
			// btnConsultaAdministradores
			// 
			btnConsultaAdministradores.Location = new Point(264, 191);
			btnConsultaAdministradores.Name = "btnConsultaAdministradores";
			btnConsultaAdministradores.Size = new Size(149, 38);
			btnConsultaAdministradores.TabIndex = 8;
			btnConsultaAdministradores.Text = "Consultar Administradores";
			btnConsultaAdministradores.UseVisualStyleBackColor = true;
			btnConsultaAdministradores.Click += btnConsultaAdministradores_Click;
			// 
			// btnConsultaTiendas
			// 
			btnConsultaTiendas.Location = new Point(264, 324);
			btnConsultaTiendas.Name = "btnConsultaTiendas";
			btnConsultaTiendas.Size = new Size(149, 29);
			btnConsultaTiendas.TabIndex = 9;
			btnConsultaTiendas.Text = "Consultar Tienda";
			btnConsultaTiendas.UseVisualStyleBackColor = true;
			btnConsultaTiendas.Click += btnConsultaTienda_Click;
			// 
			// btnConsultaInventario
			// 
			btnConsultaInventario.Location = new Point(264, 438);
			btnConsultaInventario.Name = "btnConsultaInventario";
			btnConsultaInventario.Size = new Size(149, 29);
			btnConsultaInventario.TabIndex = 10;
			btnConsultaInventario.Text = "Consultar Inventario";
			btnConsultaInventario.UseVisualStyleBackColor = true;
			btnConsultaInventario.Click += btnConsultaInventario_Click;
			// 
			// btnConsultaClientes
			// 
			btnConsultaClientes.Location = new Point(264, 556);
			btnConsultaClientes.Name = "btnConsultaClientes";
			btnConsultaClientes.Size = new Size(149, 33);
			btnConsultaClientes.TabIndex = 11;
			btnConsultaClientes.Text = "Consultar Clientes";
			btnConsultaClientes.UseVisualStyleBackColor = true;
			btnConsultaClientes.Click += btnConsultaClientes_Click;
			// 
			// button1
			// 
			button1.Location = new Point(50, 641);
			button1.Name = "button1";
			button1.Size = new Size(146, 33);
			button1.TabIndex = 14;
			button1.Text = "Registrar Reserva";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// button2
			// 
			button2.Location = new Point(264, 641);
			button2.Name = "button2";
			button2.Size = new Size(149, 33);
			button2.TabIndex = 15;
			button2.Text = "Consultar Reservas";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// MenuPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(458, 734);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(btnConsultaClientes);
			Controls.Add(btnConsultaInventario);
			Controls.Add(btnConsultaTiendas);
			Controls.Add(btnConsultaAdministradores);
			Controls.Add(btnConsultaTipoVideojuego);
			Controls.Add(btnRegistroTipoVideojuego);
			Controls.Add(btnConsultaVideoJuegos);
			Controls.Add(btnRegistroInventario);
			Controls.Add(btnRegistroVideojuegos);
			Controls.Add(btnRegistroTienda);
			Controls.Add(btnRegistroClientes);
			Controls.Add(btnRegistroAdministradores);
			Name = "MenuPrincipal";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button btnRegistroAdministradores;
		private Button btnRegistroClientes;
		private Button btnRegistroTienda;
		private Button btnRegistroVideojuegos;
		private Button btnRegistroInventario;
		private Button btnConsultaVideoJuegos;
		private Button btnRegistroTipoVideojuego;
		private Button btnConsultaTipoVideojuego;
		private Button btnConsultaAdministradores;
		private Button btnConsultaTiendas;
		private Button btnConsultaInventario;
		private Button btnConsultaClientes;
		private Button button1;
		private Button button2;
	}
}