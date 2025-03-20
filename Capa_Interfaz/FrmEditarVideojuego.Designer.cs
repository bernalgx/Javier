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
			cmbFisico.Location = new Point(303, 464);
			cmbFisico.Margin = new Padding(3, 4, 3, 4);
			cmbFisico.Name = "cmbFisico";
			cmbFisico.Size = new Size(195, 27);
			cmbFisico.TabIndex = 20;
			// 
			// formato
			// 
			formato.AutoSize = true;
			formato.Location = new Point(373, 409);
			formato.Name = "formato";
			formato.Size = new Size(64, 19);
			formato.TabIndex = 19;
			formato.Text = "Formato:";
			// 
			// txtLanzamiento
			// 
			txtLanzamiento.Location = new Point(303, 334);
			txtLanzamiento.Margin = new Padding(3, 4, 3, 4);
			txtLanzamiento.Name = "txtLanzamiento";
			txtLanzamiento.PlaceholderText = "lanzamiento";
			txtLanzamiento.Size = new Size(195, 26);
			txtLanzamiento.TabIndex = 18;
			// 
			// lanzamiento
			// 
			lanzamiento.AutoSize = true;
			lanzamiento.Location = new Point(363, 287);
			lanzamiento.Name = "lanzamiento";
			lanzamiento.Size = new Size(90, 19);
			lanzamiento.TabIndex = 17;
			lanzamiento.Text = "Lanzamiento:";
			// 
			// txtDesarrollador
			// 
			txtDesarrollador.Location = new Point(303, 215);
			txtDesarrollador.Margin = new Padding(3, 4, 3, 4);
			txtDesarrollador.Name = "txtDesarrollador";
			txtDesarrollador.PlaceholderText = "Nombre del desarrollador";
			txtDesarrollador.Size = new Size(195, 26);
			txtDesarrollador.TabIndex = 16;
			// 
			// cmbTipoVideojuego
			// 
			cmbTipoVideojuego.FormattingEnabled = true;
			cmbTipoVideojuego.Location = new Point(303, 103);
			cmbTipoVideojuego.Margin = new Padding(3, 4, 3, 4);
			cmbTipoVideojuego.Name = "cmbTipoVideojuego";
			cmbTipoVideojuego.Size = new Size(195, 27);
			cmbTipoVideojuego.TabIndex = 15;
			// 
			// desarrollador
			// 
			desarrollador.AutoSize = true;
			desarrollador.Location = new Point(363, 173);
			desarrollador.Name = "desarrollador";
			desarrollador.Size = new Size(94, 19);
			desarrollador.TabIndex = 14;
			desarrollador.Text = "Desarrollador:";
			// 
			// tipo
			// 
			tipo.AutoSize = true;
			tipo.Location = new Point(385, 61);
			tipo.Name = "tipo";
			tipo.Size = new Size(38, 19);
			tipo.TabIndex = 13;
			tipo.Text = "Tipo:";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(303, -6);
			txtNombre.Margin = new Padding(3, 4, 3, 4);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Nombre del videojuego";
			txtNombre.Size = new Size(195, 26);
			txtNombre.TabIndex = 12;
			// 
			// nombre
			// 
			nombre.AutoSize = true;
			nombre.Location = new Point(374, -40);
			nombre.Name = "nombre";
			nombre.Size = new Size(62, 19);
			nombre.TabIndex = 11;
			nombre.Text = "Nombre:";
			// 
			// button1
			// 
			button1.Location = new Point(303, 531);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 21;
			button1.Text = "Guardar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(423, 531);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 22;
			button2.Text = "Cancelar";
			button2.TextAlign = ContentAlignment.MiddleRight;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// FrmEditarVideojuego
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(839, 566);
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
			Name = "FrmEditarVideojuego";
			Text = "EditarVideojuego";
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