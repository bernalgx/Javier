namespace Capa_Interfaz
{
	partial class FrmConsultarReserva
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
			lblConsultarReservas = new Label();
			txtIdReserva = new TextBox();
			btnBuscarPorId = new Button();
			btnVerTodas = new Button();
			dgvReservas = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
			SuspendLayout();
			// 
			// lblConsultarReservas
			// 
			lblConsultarReservas.AutoSize = true;
			lblConsultarReservas.Location = new Point(330, 46);
			lblConsultarReservas.Name = "lblConsultarReservas";
			lblConsultarReservas.Size = new Size(109, 15);
			lblConsultarReservas.TabIndex = 0;
			lblConsultarReservas.Text = "Consultar Reservas:";
			// 
			// txtIdReserva
			// 
			txtIdReserva.Location = new Point(296, 83);
			txtIdReserva.Name = "txtIdReserva";
			txtIdReserva.Size = new Size(179, 23);
			txtIdReserva.TabIndex = 1;
			// 
			// btnBuscarPorId
			// 
			btnBuscarPorId.Location = new Point(37, 132);
			btnBuscarPorId.Name = "btnBuscarPorId";
			btnBuscarPorId.Size = new Size(115, 43);
			btnBuscarPorId.TabIndex = 2;
			btnBuscarPorId.Text = "Buscar una reserva por ID";
			btnBuscarPorId.UseVisualStyleBackColor = true;
			btnBuscarPorId.Click += btnBuscarPorId_Click;
			// 
			// btnVerTodas
			// 
			btnVerTodas.Location = new Point(645, 132);
			btnVerTodas.Name = "btnVerTodas";
			btnVerTodas.Size = new Size(115, 43);
			btnVerTodas.TabIndex = 3;
			btnVerTodas.Text = "Ver todas las reservas";
			btnVerTodas.UseVisualStyleBackColor = true;
			btnVerTodas.Click += btnVerTodas_Click;
			// 
			// dgvReservas
			// 
			dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvReservas.Location = new Point(12, 203);
			dgvReservas.Name = "dgvReservas";
			dgvReservas.Size = new Size(776, 311);
			dgvReservas.TabIndex = 4;
			// 
			// FrmConsultarReserva
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 526);
			Controls.Add(dgvReservas);
			Controls.Add(btnVerTodas);
			Controls.Add(btnBuscarPorId);
			Controls.Add(txtIdReserva);
			Controls.Add(lblConsultarReservas);
			Name = "FrmConsultarReserva";
			Text = "FrmConsultarReserva";
			((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblConsultarReservas;
		private TextBox txtIdReserva;
		private Button btnBuscarPorId;
		private Button btnVerTodas;
		private DataGridView dgvReservas;
	}
}