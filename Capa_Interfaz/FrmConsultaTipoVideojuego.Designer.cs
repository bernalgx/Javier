namespace Capa_Interfaz
{
    partial class FrmConsultaTipoVideojuego
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
            dgvTiposVideojuego = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTiposVideojuego).BeginInit();
            SuspendLayout();
            // 
            // dgvTiposVideojuego
            // 
            dgvTiposVideojuego.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiposVideojuego.Location = new Point(12, 12);
            dgvTiposVideojuego.Name = "dgvTiposVideojuego";
            dgvTiposVideojuego.Size = new Size(510, 229);
            dgvTiposVideojuego.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(26, 289);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 35);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(431, 295);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmConsultaTipoVideojuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 368);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvTiposVideojuego);
            Name = "FrmConsultaTipoVideojuego";
            Text = "FrmConsultaTipoVideojuego";
            ((System.ComponentModel.ISupportInitialize)dgvTiposVideojuego).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTiposVideojuego;
        private Button btnEditar;
        private Button btnEliminar;
    }
}