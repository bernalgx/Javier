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
			btnAdministradores = new Button();
			btnClientes = new Button();
			btnTiendas = new Button();
			btnVideojuegos = new Button();
			btnInventario = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// btnAdministradores
			// 
			btnAdministradores.BackColor = SystemColors.ButtonShadow;
			btnAdministradores.Location = new Point(162, 37);
			btnAdministradores.Name = "btnAdministradores";
			btnAdministradores.Size = new Size(149, 38);
			btnAdministradores.TabIndex = 0;
			btnAdministradores.Text = "Administradores";
			btnAdministradores.UseVisualStyleBackColor = false;
			// 
			// btnClientes
			// 
			btnClientes.BackColor = SystemColors.ButtonShadow;
			btnClientes.Location = new Point(162, 124);
			btnClientes.Name = "btnClientes";
			btnClientes.Size = new Size(149, 33);
			btnClientes.TabIndex = 1;
			btnClientes.Text = "Clientes";
			btnClientes.UseVisualStyleBackColor = false;
			// 
			// btnTiendas
			// 
			btnTiendas.BackColor = SystemColors.ControlDark;
			btnTiendas.Location = new Point(162, 209);
			btnTiendas.Name = "btnTiendas";
			btnTiendas.Size = new Size(149, 29);
			btnTiendas.TabIndex = 2;
			btnTiendas.Text = "Tienda";
			btnTiendas.UseVisualStyleBackColor = false;
			// 
			// btnVideojuegos
			// 
			btnVideojuegos.BackColor = SystemColors.ControlDark;
			btnVideojuegos.Location = new Point(68, 286);
			btnVideojuegos.Name = "btnVideojuegos";
			btnVideojuegos.Size = new Size(149, 28);
			btnVideojuegos.TabIndex = 3;
			btnVideojuegos.Text = "Registrar Video Juego";
			btnVideojuegos.UseVisualStyleBackColor = false;
			btnVideojuegos.Click += VideoJuego_Click;
			// 
			// btnInventario
			// 
			btnInventario.BackColor = SystemColors.ControlDark;
			btnInventario.Location = new Point(162, 384);
			btnInventario.Name = "btnInventario";
			btnInventario.Size = new Size(149, 29);
			btnInventario.TabIndex = 4;
			btnInventario.Text = "Inventario";
			btnInventario.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ControlDark;
			button1.Location = new Point(265, 286);
			button1.Name = "button1";
			button1.Size = new Size(149, 28);
			button1.TabIndex = 5;
			button1.Text = "Consultar Video Juegos";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// MenuPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(458, 450);
			Controls.Add(button1);
			Controls.Add(btnInventario);
			Controls.Add(btnVideojuegos);
			Controls.Add(btnTiendas);
			Controls.Add(btnClientes);
			Controls.Add(btnAdministradores);
			Name = "MenuPrincipal";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button btnAdministradores;
		private Button btnClientes;
		private Button btnTiendas;
		private Button btnVideojuegos;
		private Button btnInventario;
		private Button button1;
	}
}