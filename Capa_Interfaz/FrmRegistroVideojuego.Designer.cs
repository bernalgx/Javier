using Capa_Entidades;


// Ensure that the Capa_Entidades project or assembly is referenced in your project
namespace Capa_Interfaz

{
	partial class FrmRegistroVideojuego
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
			nombre = new Label();
			txtNombre = new TextBox();
			tipo = new Label();
			desarrollador = new Label();
			cmbTipoVideojuego = new ComboBox();
			txtDesarrollador = new TextBox();
			lanzamiento = new Label();
			txtLanzamiento = new TextBox();
			formato = new Label();
			cmbFisico = new ComboBox();
			btnRegistrar = new Button();
			SuspendLayout();
			// 
			// nombre
			// 
			nombre.AutoSize = true;
			nombre.Location = new Point(261, 23);
			nombre.Name = "nombre";
			nombre.Size = new Size(54, 15);
			nombre.TabIndex = 0;
			nombre.Text = "Nombre:";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(199, 50);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Nombre del videojuego";
			txtNombre.Size = new Size(171, 23);
			txtNombre.TabIndex = 1;
			// 
			// tipo
			// 
			tipo.AutoSize = true;
			tipo.Location = new Point(270, 103);
			tipo.Name = "tipo";
			tipo.Size = new Size(33, 15);
			tipo.TabIndex = 2;
			tipo.Text = "Tipo:";
			// 
			// desarrollador
			// 
			desarrollador.AutoSize = true;
			desarrollador.Location = new Point(251, 191);
			desarrollador.Name = "desarrollador";
			desarrollador.Size = new Size(80, 15);
			desarrollador.TabIndex = 4;
			desarrollador.Text = "Desarrollador:";
			// 
			// cmbTipoVideojuego
			// 
			cmbTipoVideojuego.FormattingEnabled = true;
			cmbTipoVideojuego.Location = new Point(199, 136);
			cmbTipoVideojuego.Name = "cmbTipoVideojuego";
			cmbTipoVideojuego.Size = new Size(171, 23);
			cmbTipoVideojuego.TabIndex = 5;
			// 
			// txtDesarrollador
			// 
			txtDesarrollador.Location = new Point(199, 224);
			txtDesarrollador.Name = "txtDesarrollador";
			txtDesarrollador.PlaceholderText = "Nombre del desarrollador";
			txtDesarrollador.Size = new Size(171, 23);
			txtDesarrollador.TabIndex = 6;
			// 
			// lanzamiento
			// 
			lanzamiento.AutoSize = true;
			lanzamiento.Location = new Point(251, 281);
			lanzamiento.Name = "lanzamiento";
			lanzamiento.Size = new Size(78, 15);
			lanzamiento.TabIndex = 7;
			lanzamiento.Text = "Lanzamiento:";
			// 
			// txtLanzamiento
			// 
			txtLanzamiento.Location = new Point(199, 318);
			txtLanzamiento.Name = "txtLanzamiento";
			txtLanzamiento.PlaceholderText = "lanzamiento";
			txtLanzamiento.Size = new Size(171, 23);
			txtLanzamiento.TabIndex = 8;
			// 
			// formato
			// 
			formato.AutoSize = true;
			formato.Location = new Point(260, 377);
			formato.Name = "formato";
			formato.Size = new Size(55, 15);
			formato.TabIndex = 9;
			formato.Text = "Formato:";
			// 
			// cmbFisico
			// 
			cmbFisico.FormattingEnabled = true;
			cmbFisico.Items.AddRange(new object[] { "\"Físico\"", "", " \"Digital\"" });
			cmbFisico.Location = new Point(199, 421);
			cmbFisico.Name = "cmbFisico";
			cmbFisico.Size = new Size(171, 23);
			cmbFisico.TabIndex = 10;
			// 
			// btnRegistrar
			// 
			btnRegistrar.Location = new Point(236, 486);
			btnRegistrar.Name = "btnRegistrar";
			btnRegistrar.Size = new Size(110, 61);
			btnRegistrar.TabIndex = 11;
			btnRegistrar.Text = "Registrar";
			btnRegistrar.UseVisualStyleBackColor = true;
			btnRegistrar.Click += btnRegistrar_Click;
			// 
			// FrmRegistroVideojuego
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(582, 588);
			Controls.Add(btnRegistrar);
			Controls.Add(cmbFisico);
			Controls.Add(formato);
			Controls.Add(txtLanzamiento);
			Controls.Add(lanzamiento);
			Controls.Add(txtDesarrollador);
			Controls.Add(cmbTipoVideojuego);
			Controls.Add(desarrollador);
			Controls.Add(tipo);
			Controls.Add(txtNombre);
			Controls.Add(nombre);
			Name = "FrmRegistroVideojuego";
			Text = "FrmRegistroVideojuego";
			Load += FrmRegistroVideojuego_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label nombre;
		private TextBox txtNombre;
		private Label tipo;
		private Label desarrollador;
		private ComboBox cmbTipoVideojuego;
		private TextBox txtDesarrollador;
		private Label lanzamiento;
		private TextBox txtLanzamiento;
		private Label formato;
		private ComboBox cmbFisico;
		private Button btnRegistrar;
	}
}