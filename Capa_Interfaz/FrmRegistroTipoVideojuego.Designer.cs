namespace Capa_Interfaz
{
	partial class FrmRegistroTipoVideojuego
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





		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			lblNombre = new Label();
			txtNombre = new TextBox();
			lblDescripcion = new Label();
			txtDescripcion = new TextBox();
			btnRegistrar = new Button();
			SuspendLayout();
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Location = new Point(297, 101);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(62, 19);
			lblNombre.TabIndex = 2;
			lblNombre.Text = "Nombre:";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(229, 127);
			txtNombre.Margin = new Padding(3, 4, 3, 4);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Ingrese nombre";
			txtNombre.Size = new Size(195, 26);
			txtNombre.TabIndex = 3;
			// 
			// lblDescripcion
			// 
			lblDescripcion.AutoSize = true;
			lblDescripcion.Location = new Point(297, 177);
			lblDescripcion.Name = "lblDescripcion";
			lblDescripcion.Size = new Size(82, 19);
			lblDescripcion.TabIndex = 4;
			lblDescripcion.Text = "Descripción:";
			// 
			// txtDescripcion
			// 
			txtDescripcion.Location = new Point(229, 203);
			txtDescripcion.Margin = new Padding(3, 4, 3, 4);
			txtDescripcion.Name = "txtDescripcion";
			txtDescripcion.PlaceholderText = "Ingrese descripción";
			txtDescripcion.Size = new Size(195, 26);
			txtDescripcion.TabIndex = 5;
			// 
			// btnRegistrar
			// 
			btnRegistrar.Location = new Point(263, 266);
			btnRegistrar.Margin = new Padding(3, 4, 3, 4);
			btnRegistrar.Name = "btnRegistrar";
			btnRegistrar.Size = new Size(126, 63);
			btnRegistrar.TabIndex = 6;
			btnRegistrar.Text = "Registrar";
			btnRegistrar.UseVisualStyleBackColor = true;
			btnRegistrar.Click += btnRegistrar_Click;
			// 
			// FrmRegistroTipoVideojuego
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(665, 380);
			Controls.Add(btnRegistrar);
			Controls.Add(txtDescripcion);
			Controls.Add(lblDescripcion);
			Controls.Add(txtNombre);
			Controls.Add(lblNombre);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FrmRegistroTipoVideojuego";
			Text = "Registro Tipo Videojuego";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblNombre;
private TextBox txtNombre;
private Label lblDescripcion;
private TextBox txtDescripcion;
private Button btnRegistrar;
}
}
