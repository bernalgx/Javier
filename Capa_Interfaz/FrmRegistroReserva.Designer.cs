namespace Capa_Interfaz
{
	partial class FrmRegistroReserva
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
			comboBoxTiendas = new ComboBox();
			dataGridViewVideojuegos = new DataGridView();
			dateTimePickerReserva = new DateTimePicker();
			textBoxCantidad = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewVideojuegos).BeginInit();
			SuspendLayout();
			// 
			// comboBoxTiendas
			// 
			comboBoxTiendas.FormattingEnabled = true;
			comboBoxTiendas.Location = new Point(12, 38);
			comboBoxTiendas.Name = "comboBoxTiendas";
			comboBoxTiendas.Size = new Size(121, 23);
			comboBoxTiendas.TabIndex = 0;
			comboBoxTiendas.SelectedValueChanged += comboBoxTiendas_SelectedValueChanged;
			// 
			// dataGridViewVideojuegos
			// 
			dataGridViewVideojuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewVideojuegos.Location = new Point(264, 69);
			dataGridViewVideojuegos.Name = "dataGridViewVideojuegos";
			dataGridViewVideojuegos.Size = new Size(535, 384);
			dataGridViewVideojuegos.TabIndex = 1;
			//dataGridViewVideojuegos.CellContentClick += this.dataGridViewVideojuegos_CellContentClick;
			// 
			// dateTimePickerReserva
			// 
			dateTimePickerReserva.Location = new Point(12, 108);
			dateTimePickerReserva.Name = "dateTimePickerReserva";
			dateTimePickerReserva.Size = new Size(200, 23);
			dateTimePickerReserva.TabIndex = 2;
			// 
			// textBoxCantidad
			// 
			textBoxCantidad.Location = new Point(12, 220);
			textBoxCantidad.Name = "textBoxCantidad";
			textBoxCantidad.Size = new Size(100, 23);
			textBoxCantidad.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 20);
			label1.Name = "label1";
			label1.Size = new Size(42, 15);
			label1.TabIndex = 4;
			label1.Text = "Tienda";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 79);
			label2.Name = "label2";
			label2.Size = new Size(38, 15);
			label2.TabIndex = 5;
			label2.Text = "Fecha";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 188);
			label3.Name = "label3";
			label3.Size = new Size(55, 15);
			label3.TabIndex = 6;
			label3.Text = "Cantidad";
			// 
			// button1
			// 
			button1.Location = new Point(21, 288);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 7;
			button1.Text = "Reservar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// FrmRegistroReserva
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBoxCantidad);
			Controls.Add(dateTimePickerReserva);
			Controls.Add(dataGridViewVideojuegos);
			Controls.Add(comboBoxTiendas);
			Name = "FrmRegistroReserva";
			Text = "FrmReserva";
			Load += FrmReserva_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewVideojuegos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox comboBoxTiendas;
		private DataGridView dataGridViewVideojuegos;
		private DateTimePicker dateTimePickerReserva;
		private TextBox textBoxCantidad;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
	}
}