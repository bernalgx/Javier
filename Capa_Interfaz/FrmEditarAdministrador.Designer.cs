namespace Capa_Interfaz
{
    partial class FrmEditarAdministrador
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
            lblIdentificacion = new Label();
            txtIdentificacion = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPrimerApellido = new Label();
            txtPrimerApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtSegundoApellido = new TextBox();
            lblNacimiento = new Label();
            lblContratacion = new Label();
            dtpNacimiento = new DateTimePicker();
            dtpContratacion = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(122, 32);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(82, 15);
            lblIdentificacion.TabIndex = 0;
            lblIdentificacion.Text = "Identificacion:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(77, 71);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(175, 23);
            txtIdentificacion.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(130, 131);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(77, 175);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(122, 231);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(92, 15);
            lblPrimerApellido.TabIndex = 4;
            lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(77, 277);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(175, 23);
            txtPrimerApellido.TabIndex = 5;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(122, 333);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(104, 15);
            lblSegundoApellido.TabIndex = 6;
            lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(77, 373);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(175, 23);
            txtSegundoApellido.TabIndex = 7;
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Location = new Point(120, 423);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(106, 15);
            lblNacimiento.TabIndex = 8;
            lblNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblContratacion
            // 
            lblContratacion.AutoSize = true;
            lblContratacion.Location = new Point(113, 519);
            lblContratacion.Name = "lblContratacion";
            lblContratacion.Size = new Size(113, 15);
            lblContratacion.TabIndex = 10;
            lblContratacion.Text = "Fecha Contratacion:";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(65, 454);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(200, 23);
            dtpNacimiento.TabIndex = 11;
            // 
            // dtpContratacion
            // 
            dtpContratacion.Location = new Point(65, 564);
            dtpContratacion.Name = "dtpContratacion";
            dtpContratacion.Size = new Size(200, 23);
            dtpContratacion.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(33, 616);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(220, 616);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmEditarAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 663);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpContratacion);
            Controls.Add(dtpNacimiento);
            Controls.Add(lblContratacion);
            Controls.Add(lblNacimiento);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblIdentificacion);
            Name = "FrmEditarAdministrador";
            Text = "FrmEditarAdministrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdentificacion;
        private TextBox txtIdentificacion;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblPrimerApellido;
        private TextBox txtPrimerApellido;
        private Label lblSegundoApellido;
        private TextBox txtSegundoApellido;
        private Label lblNacimiento;
        private Label lblContratacion;
        private DateTimePicker dtpNacimiento;
        private DateTimePicker dtpContratacion;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}