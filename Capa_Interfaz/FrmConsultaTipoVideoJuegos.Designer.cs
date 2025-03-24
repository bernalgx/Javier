using Capa_Log_Negocio;

namespace Capa_Interfaz
{
	partial class FrmConsultaTipoVideoJuegos
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

		private void FrmConsultaTipoVideoJuegos_Load(object sender, EventArgs e)
		{
			CargarTipoVideojuegos();
		}

		private void CargarTipoVideojuegos()
		{
			try
			{
				LogTipoVideojuego log = new LogTipoVideojuego();
				// Usamos el método que consulta la BD
				dataGridView1.DataSource = log.ObtenerTipos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar videojuegos: " + ex.Message);
			}
		}



		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			button2 = new Button();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(85, 350);
			button1.Name = "button1";
			button1.Size = new Size(98, 41);
			button1.TabIndex = 0;
			button1.Text = "Actualizar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(527, 368);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 1;
			button2.Text = "Eliminar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(776, 289);
			dataGridView1.TabIndex = 2;
			// 
			// FrmConsultaTipoVideoJuegos
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridView1);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "FrmConsultaTipoVideoJuegos";
			Text = "Form1";
			Load += FrmConsultaTipoVideoJuegos_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private Button button2;
		private DataGridView dataGridView1;
	}
}