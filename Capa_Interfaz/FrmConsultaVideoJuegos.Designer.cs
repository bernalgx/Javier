using Capa_Entidades;
using Capa_Log_Negocio;
using System.Windows.Forms;
using System.Linq;


namespace Capa_Interfaz
{
	partial class FrmConsultaVideoJuegos
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

		private void FrmConsultaVideoJuegos_Load(object sender, EventArgs e)
		{
			CargarVideojuegos();
		}

		private void CargarVideojuegos()
		{
			try
			{
				LogVideojuego log = new LogVideojuego();
				// Usamos el método que consulta la BD
				dataGridView1.DataSource = log.ObtenerVideojuegosDesdeBD();
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
			dataGridView1 = new DataGridView();
			button1 = new Button();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(14, 15);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(1077, 382);
			dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(198, 458);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Editar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(342, 458);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 2;
			button2.Text = "Eliminar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// FrmConsultaVideoJuegos
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1113, 532);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FrmConsultaVideoJuegos";
			Text = "Consulta de Video Juegos";
			Load += FrmConsultaVideoJuegos_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}


		#endregion

		private DataGridView dataGridView1;
		private Button button1;
		private Button button2;
	}
}