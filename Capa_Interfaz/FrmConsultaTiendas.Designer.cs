namespace Capa_Interfaz
{
    partial class FrmConsultaTiendas
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
			dataGridView1 = new DataGridView();
			btnEditar = new Button();
			btnEliminar = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(740, 285);
			dataGridView1.TabIndex = 0;
			// 
			// btnEditar
			// 
			btnEditar.Location = new Point(12, 332);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(96, 32);
			btnEditar.TabIndex = 1;
			btnEditar.Text = "Editar";
			btnEditar.UseVisualStyleBackColor = true;
			btnEditar.Click += btnEditar_Click;
			// 
			// btnEliminar
			// 
			btnEliminar.Location = new Point(672, 332);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(80, 32);
			btnEliminar.TabIndex = 2;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = true;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// FrmConsultaTiendas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(764, 407);
			Controls.Add(btnEliminar);
			Controls.Add(btnEditar);
			Controls.Add(dataGridView1);
			Name = "FrmConsultaTiendas";
			Text = "FrmConsultaTiendas";
			Load += FrmConsultaTiendas_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnEliminar;
    }
}