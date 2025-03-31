namespace Capa_Interfaz
{
    partial class FrmRegistroCliente
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
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblJugadorEnLinea = new Label();
            cmbJugadorEnLinea = new ComboBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(151, 41);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(82, 15);
            lblIdentificacion.TabIndex = 0;
            lblIdentificacion.Text = "Identificacion:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(112, 71);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(158, 23);
            txtIdentificacion.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(161, 128);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 170);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(141, 241);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(92, 15);
            lblPrimerApellido.TabIndex = 4;
            lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(112, 276);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(158, 23);
            txtPrimerApellido.TabIndex = 5;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(141, 338);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(101, 15);
            lblSegundoApellido.TabIndex = 6;
            lblSegundoApellido.Text = "SegundoApellido:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(112, 376);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(158, 23);
            txtSegundoApellido.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(131, 427);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(122, 15);
            lblFechaNacimiento.TabIndex = 8;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(100, 460);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblJugadorEnLinea
            // 
            lblJugadorEnLinea.AutoSize = true;
            lblJugadorEnLinea.Location = new Point(141, 516);
            lblJugadorEnLinea.Name = "lblJugadorEnLinea";
            lblJugadorEnLinea.Size = new Size(99, 15);
            lblJugadorEnLinea.TabIndex = 10;
            lblJugadorEnLinea.Text = "Jugador en Linea:";
            // 
            // cmbJugadorEnLinea
            // 
            cmbJugadorEnLinea.FormattingEnabled = true;
            cmbJugadorEnLinea.Location = new Point(131, 560);
            cmbJugadorEnLinea.Name = "cmbJugadorEnLinea";
            cmbJugadorEnLinea.Size = new Size(121, 23);
            cmbJugadorEnLinea.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(149, 626);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(91, 44);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FrmRegistroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 704);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbJugadorEnLinea);
            Controls.Add(lblJugadorEnLinea);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblIdentificacion);
            Name = "FrmRegistroCliente";
            Text = "FrmRegistroCliente";
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
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblJugadorEnLinea;
        private ComboBox cmbJugadorEnLinea;
        private Button btnRegistrar;
    }
}