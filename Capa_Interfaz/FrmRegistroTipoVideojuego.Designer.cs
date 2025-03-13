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
			lblId = new Label();
			txtId = new TextBox();
			lblNombre = new Label();
			txtNombre = new TextBox();
			lblDescripcion = new Label();
			txtDescripcion = new TextBox();
			btnRegistrar = new Button();
			SuspendLayout();
			// 
			// lblId
			// 
			lblId.AutoSize = true;
			lblId.Location = new Point(260, 20);
			lblId.Name = "lblId";
			lblId.Size = new Size(20, 15);
			lblId.TabIndex = 0;
			lblId.Text = "Id:";
			// 
			// txtId
			// 
			txtId.Location = new Point(200, 40);
			txtId.Name = "txtId";
			txtId.PlaceholderText = "Ingrese Id";
			txtId.Size = new Size(171, 23);
			txtId.TabIndex = 1;
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Location = new Point(260, 80);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(54, 15);
			lblNombre.TabIndex = 2;
			lblNombre.Text = "Nombre:";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(200, 100);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Ingrese nombre";
			txtNombre.Size = new Size(171, 23);
			txtNombre.TabIndex = 3;
			// 
			// lblDescripcion
			// 
			lblDescripcion.AutoSize = true;
			lblDescripcion.Location = new Point(260, 140);
			lblDescripcion.Name = "lblDescripcion";
			lblDescripcion.Size = new Size(72, 15);
			lblDescripcion.TabIndex = 4;
			lblDescripcion.Text = "Descripción:";
			// 
			// txtDescripcion
			// 
			txtDescripcion.Location = new Point(200, 160);
			txtDescripcion.Name = "txtDescripcion";
			txtDescripcion.PlaceholderText = "Ingrese descripción";
			txtDescripcion.Size = new Size(171, 23);
			txtDescripcion.TabIndex = 5;
			// 
			// btnRegistrar
			// 
			btnRegistrar.Location = new Point(230, 210);
			btnRegistrar.Name = "btnRegistrar";
			btnRegistrar.Size = new Size(110, 50);
			btnRegistrar.TabIndex = 6;
			btnRegistrar.Text = "Registrar";
			btnRegistrar.UseVisualStyleBackColor = true;
			btnRegistrar.Click += btnRegistrar_Click;
			// 
			// FrmRegistroTipoVideojuego
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(582, 300);
			Controls.Add(btnRegistrar);
			Controls.Add(txtDescripcion);
			Controls.Add(lblDescripcion);
			Controls.Add(txtNombre);
			Controls.Add(lblNombre);
			Controls.Add(txtId);
			Controls.Add(lblId);
			Name = "FrmRegistroTipoVideojuego";
			Text = "Registro Tipo Videojuego";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblId;
private TextBox txtId;
private Label lblNombre;
private TextBox txtNombre;
private Label lblDescripcion;
private TextBox txtDescripcion;
private Button btnRegistrar;
}
}
