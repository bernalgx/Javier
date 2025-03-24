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
			button2 = new Button();
			button3 = new Button();
			SuspendLayout();
			// 
			// btnAdministradores
			// 
			btnAdministradores.BackColor = SystemColors.ButtonShadow;
			btnAdministradores.Location = new Point(185, 47);
			btnAdministradores.Margin = new Padding(3, 4, 3, 4);
			btnAdministradores.Name = "btnAdministradores";
			btnAdministradores.Size = new Size(170, 48);
			btnAdministradores.TabIndex = 0;
			btnAdministradores.Text = "Administradores";
			btnAdministradores.UseVisualStyleBackColor = false;
			// 
			// btnClientes
			// 
			btnClientes.BackColor = SystemColors.ButtonShadow;
			btnClientes.Location = new Point(185, 157);
			btnClientes.Margin = new Padding(3, 4, 3, 4);
			btnClientes.Name = "btnClientes";
			btnClientes.Size = new Size(170, 42);
			btnClientes.TabIndex = 1;
			btnClientes.Text = "Clientes";
			btnClientes.UseVisualStyleBackColor = false;
			// 
			// btnTiendas
			// 
			btnTiendas.BackColor = SystemColors.ControlDark;
			btnTiendas.Location = new Point(185, 265);
			btnTiendas.Margin = new Padding(3, 4, 3, 4);
			btnTiendas.Name = "btnTiendas";
			btnTiendas.Size = new Size(170, 37);
			btnTiendas.TabIndex = 2;
			btnTiendas.Text = "Tienda";
			btnTiendas.UseVisualStyleBackColor = false;
			// 
			// btnVideojuegos
			// 
			btnVideojuegos.BackColor = SystemColors.ControlDark;
			btnVideojuegos.Location = new Point(78, 362);
			btnVideojuegos.Margin = new Padding(3, 4, 3, 4);
			btnVideojuegos.Name = "btnVideojuegos";
			btnVideojuegos.Size = new Size(170, 35);
			btnVideojuegos.TabIndex = 3;
			btnVideojuegos.Text = "Registrar Video Juego";
			btnVideojuegos.UseVisualStyleBackColor = false;
			btnVideojuegos.Click += VideoJuego_Click;
			// 
			// btnInventario
			// 
			btnInventario.BackColor = SystemColors.ControlDark;
			btnInventario.Location = new Point(185, 486);
			btnInventario.Margin = new Padding(3, 4, 3, 4);
			btnInventario.Name = "btnInventario";
			btnInventario.Size = new Size(170, 37);
			btnInventario.TabIndex = 4;
			btnInventario.Text = "Inventario";
			btnInventario.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ControlDark;
			button1.Location = new Point(303, 362);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(170, 35);
			button1.TabIndex = 5;
			button1.Text = "Consultar Video Juegos";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(303, 404);
			button2.Name = "button2";
			button2.Size = new Size(170, 35);
			button2.TabIndex = 6;
			button2.Text = "Consultar Tipo de Video Juego";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(78, 405);
			button3.Name = "button3";
			button3.Size = new Size(170, 34);
			button3.TabIndex = 7;
			button3.Text = "Registrar Tipo de Video Juego";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// MenuPrincipal
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(523, 570);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(btnInventario);
			Controls.Add(btnVideojuegos);
			Controls.Add(btnTiendas);
			Controls.Add(btnClientes);
			Controls.Add(btnAdministradores);
			Margin = new Padding(3, 4, 3, 4);
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
		private Button button2;
		private Button button3;
	}
}