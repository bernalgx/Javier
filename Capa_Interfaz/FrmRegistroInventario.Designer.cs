//namespace Capa_Interfaz
//{
//	partial class FrmRegistroInventario
//	{
//		/// <summary>
//		/// Required designer variable.
//		/// </summary>
//		private System.ComponentModel.IContainer components = null;

//		/// <summary>
//		/// Clean up any resources being used.
//		/// </summary>
//		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//		protected override void Dispose(bool disposing)
//		{
//			if (disposing && (components != null))
//			{
//				components.Dispose();
//			}
//			base.Dispose(disposing);
//		}

//		#region Windows Form Designer generated code

//		/// <summary>
//		/// Required method for Designer support - do not modify
//		/// the contents of this method with the code editor.
//		/// </summary>
//		private void InitializeComponent()
//		{
//			SuspendLayout();
//			// 
//			// FrmRegistroInventario
//			// 
//			AutoScaleDimensions = new SizeF(7F, 15F);
//			AutoScaleMode = AutoScaleMode.Font;
//			ClientSize = new Size(800, 450);
//			Name = "FrmRegistroInventario";
//			Text = "Registrar Inventario";
//			ResumeLayout(false);
//		}

//		#endregion
//	}
//}

namespace Capa_Interfaz
{
	partial class FrmRegistroInventario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		// Declaración de controles
		private System.Windows.Forms.ComboBox cmbTiendas;
		private System.Windows.Forms.ComboBox cmbVideojuegos;
		private System.Windows.Forms.TextBox txtExistencias;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Label lblTienda;
		private System.Windows.Forms.Label lblVideojuego;
		private System.Windows.Forms.Label lblExistencias;

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
		/// Método requerido para el Diseñador - no modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			cmbTiendas = new ComboBox();
			cmbVideojuegos = new ComboBox();
			txtExistencias = new TextBox();
			btnRegistrar = new Button();
			lblTienda = new Label();
			lblVideojuego = new Label();
			lblExistencias = new Label();
			SuspendLayout();
			// 
			// cmbTiendas
			// 
			cmbTiendas.FormattingEnabled = true;
			cmbTiendas.Location = new Point(150, 27);
			cmbTiendas.Name = "cmbTiendas";
			cmbTiendas.Size = new Size(200, 23);
			cmbTiendas.TabIndex = 1;
			// 
			// cmbVideojuegos
			// 
			cmbVideojuegos.FormattingEnabled = true;
			cmbVideojuegos.Location = new Point(150, 67);
			cmbVideojuegos.Name = "cmbVideojuegos";
			cmbVideojuegos.Size = new Size(200, 23);
			cmbVideojuegos.TabIndex = 3;
			// 
			// txtExistencias
			// 
			txtExistencias.Location = new Point(150, 107);
			txtExistencias.Name = "txtExistencias";
			txtExistencias.Size = new Size(200, 23);
			txtExistencias.TabIndex = 5;
			// 
			// btnRegistrar
			// 
			btnRegistrar.Location = new Point(150, 150);
			btnRegistrar.Name = "btnRegistrar";
			btnRegistrar.Size = new Size(200, 30);
			btnRegistrar.TabIndex = 6;
			btnRegistrar.Text = "Registrar Inventario";
			btnRegistrar.UseVisualStyleBackColor = true;
			btnRegistrar.Click += btnRegistrar_Click;
			// 
			// lblTienda
			// 
			lblTienda.AutoSize = true;
			lblTienda.Location = new Point(50, 30);
			lblTienda.Name = "lblTienda";
			lblTienda.Size = new Size(45, 15);
			lblTienda.TabIndex = 0;
			lblTienda.Text = "Tienda:";
			// 
			// lblVideojuego
			// 
			lblVideojuego.AutoSize = true;
			lblVideojuego.Location = new Point(50, 70);
			lblVideojuego.Name = "lblVideojuego";
			lblVideojuego.Size = new Size(70, 15);
			lblVideojuego.TabIndex = 2;
			lblVideojuego.Text = "Videojuego:";
			// 
			// lblExistencias
			// 
			lblExistencias.AutoSize = true;
			lblExistencias.Location = new Point(50, 110);
			lblExistencias.Name = "lblExistencias";
			lblExistencias.Size = new Size(67, 15);
			lblExistencias.TabIndex = 4;
			lblExistencias.Text = "Existencias:";
			// 
			// FrmRegistroInventario
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(420, 220);
			Controls.Add(btnRegistrar);
			Controls.Add(txtExistencias);
			Controls.Add(lblExistencias);
			Controls.Add(cmbVideojuegos);
			Controls.Add(lblVideojuego);
			Controls.Add(cmbTiendas);
			Controls.Add(lblTienda);
			Name = "FrmRegistroInventario";
			Text = "Registrar Inventario";
			Load += FrmRegistroInventario_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
	}
}
