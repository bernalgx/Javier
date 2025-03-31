namespace Capa_Interfaz
{
	partial class FrmEditarVideojuego
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
			cmbFisico = new ComboBox();
			formato = new Label();
			txtLanzamiento = new TextBox();
			lanzamiento = new Label();
			txtDesarrollador = new TextBox();
			cmbTipoVideojuego = new ComboBox();
			desarrollador = new Label();
			tipo = new Label();
			txtNombre = new TextBox();
			nombre = new Label();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// cmbFisico
			// 
			cmbFisico.FormattingEnabled = true;
			cmbFisico.Items.AddRange(new object[] { "\"Físico\"", "", " \"Digital\"" });
			cmbFisico.Location = new Point(265, 366);
			cmbFisico.Name = "cmbFisico";
			cmbFisico.Size = new Size(171, 23);
			cmbFisico.TabIndex = 20;
			// 
			// formato
			// 
			formato.AutoSize = true;
			formato.Location = new Point(326, 323);
			formato.Name = "formato";
			formato.Size = new Size(55, 15);
			formato.TabIndex = 19;
			formato.Text = "Formato:";
			// 
			// txtLanzamiento
			// 
			txtLanzamiento.Location = new Point(265, 264);
			txtLanzamiento.Name = "txtLanzamiento";
			txtLanzamiento.PlaceholderText = "lanzamiento";
			txtLanzamiento.Size = new Size(171, 23);
			txtLanzamiento.TabIndex = 18;
			// 
			// lanzamiento
			// 
			lanzamiento.AutoSize = true;
			lanzamiento.Location = new Point(318, 227);
			lanzamiento.Name = "lanzamiento";
			lanzamiento.Size = new Size(78, 15);
			lanzamiento.TabIndex = 17;
			lanzamiento.Text = "Lanzamiento:";
			// 
			// txtDesarrollador
			// 
			txtDesarrollador.Location = new Point(265, 170);
			txtDesarrollador.Name = "txtDesarrollador";
			txtDesarrollador.PlaceholderText = "Nombre del desarrollador";
			txtDesarrollador.Size = new Size(171, 23);
			txtDesarrollador.TabIndex = 16;
			// 
			// cmbTipoVideojuego
			// 
			cmbTipoVideojuego.FormattingEnabled = true;
			cmbTipoVideojuego.Location = new Point(265, 81);
			cmbTipoVideojuego.Name = "cmbTipoVideojuego";
			cmbTipoVideojuego.Size = new Size(171, 23);
			cmbTipoVideojuego.TabIndex = 15;
			// 
			// desarrollador
			// 
			desarrollador.AutoSize = true;
			desarrollador.Location = new Point(318, 137);
			desarrollador.Name = "desarrollador";
			desarrollador.Size = new Size(80, 15);
			desarrollador.TabIndex = 14;
			desarrollador.Text = "Desarrollador:";
			// 
			// tipo
			// 
			tipo.AutoSize = true;
			tipo.Location = new Point(337, 48);
			tipo.Name = "tipo";
			tipo.Size = new Size(33, 15);
			tipo.TabIndex = 13;
			tipo.Text = "Tipo:";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(265, 12);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Nombre del videojuego";
			txtNombre.Size = new Size(171, 23);
			txtNombre.TabIndex = 12;
			// 
			// nombre
			// 
			nombre.AutoSize = true;
			nombre.Location = new Point(327, -32);
			nombre.Name = "nombre";
			nombre.Size = new Size(54, 15);
			nombre.TabIndex = 11;
			nombre.Text = "Nombre:";
			// 
			// button1
			// 
			button1.Location = new Point(265, 419);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(66, 30);
			button1.TabIndex = 21;
			button1.Text = "Guardar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(370, 419);
			button2.Margin = new Padding(3, 2, 3, 2);
			button2.Name = "button2";
			button2.Size = new Size(66, 30);
			button2.TabIndex = 22;
			button2.Text = "Cancelar";
			button2.TextAlign = ContentAlignment.MiddleRight;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// FrmEditarVideojuego
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(734, 494);
			Controls.Add(button2);
			Controls.Add(button1);
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
			Margin = new Padding(3, 2, 3, 2);
			Name = "FrmEditarVideojuego";
			Text = "EditarVideojuego";
			Load += FrmEditarVideojuego_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cmbFisico;
		private Label formato;
		private TextBox txtLanzamiento;
		private Label lanzamiento;
		private TextBox txtDesarrollador;
		private ComboBox cmbTipoVideojuego;
		private Label desarrollador;
		private Label tipo;
		private TextBox txtNombre;
		private Label nombre;
		private Button button1;
		private Button button2;
	}
}