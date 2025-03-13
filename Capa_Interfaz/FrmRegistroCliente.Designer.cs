//namespace Capa_Interfaz
//{
//    partial class FrmRegistroCliente
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            identificacion = new Label();
//            txtIdentificacion = new TextBox();
//            nombre = new Label();
//            txtNombre = new TextBox();
//            primerApellido = new Label();
//            txtPrimerApellido = new TextBox();
//            segundoApellido = new Label();
//            txtSegundoApellido = new TextBox();
//            fechaNacimiento = new Label();
//            dtpFechaNacimiento = new DateTimePicker();
//            jugadorEnLinea = new Label();
//            cmbJugadorEnLinea = new ComboBox();
//            btnRegistrar = new Button();
//            SuspendLayout();
//            // 
//            // identificacion
//            // 
//            identificacion.AutoSize = true;
//            identificacion.Location = new Point(302, 21);
//            identificacion.Name = "identificacion";
//            identificacion.Size = new Size(82, 15);
//            identificacion.TabIndex = 0;
//            identificacion.Text = "Identificación:";
//            // 
//            // txtIdentificacion
//            // 
//            txtIdentificacion.Location = new Point(245, 52);
//            txtIdentificacion.Name = "txtIdentificacion";
//            txtIdentificacion.Size = new Size(198, 23);
//            txtIdentificacion.TabIndex = 1;
//            // 
//            // nombre
//            // 
//            nombre.AutoSize = true;
//            nombre.Location = new Point(316, 98);
//            nombre.Name = "nombre";
//            nombre.Size = new Size(54, 15);
//            nombre.TabIndex = 2;
//            nombre.Text = "Nombre:";
//            // 
//            // txtNombre
//            // 
//            txtNombre.Location = new Point(245, 129);
//            txtNombre.Name = "txtNombre";
//            txtNombre.Size = new Size(198, 23);
//            txtNombre.TabIndex = 3;
//            // 
//            // primerApellido
//            // 
//            primerApellido.AutoSize = true;
//            primerApellido.Location = new Point(302, 186);
//            primerApellido.Name = "primerApellido";
//            primerApellido.Size = new Size(92, 15);
//            primerApellido.TabIndex = 4;
//            primerApellido.Text = "Primer Apellido:";
//            // 
//            // txtPrimerApellido
//            // 
//            txtPrimerApellido.Location = new Point(245, 224);
//            txtPrimerApellido.Name = "txtPrimerApellido";
//            txtPrimerApellido.Size = new Size(198, 23);
//            txtPrimerApellido.TabIndex = 5;
//            // 
//            // segundoApellido
//            // 
//            segundoApellido.AutoSize = true;
//            segundoApellido.Location = new Point(290, 288);
//            segundoApellido.Name = "segundoApellido";
//            segundoApellido.Size = new Size(104, 15);
//            segundoApellido.TabIndex = 6;
//            segundoApellido.Text = "Segundo Apellido:";
//            // 
//            // txtSegundoApellido
//            // 
//            txtSegundoApellido.Location = new Point(245, 325);
//            txtSegundoApellido.Name = "txtSegundoApellido";
//            txtSegundoApellido.Size = new Size(198, 23);
//            txtSegundoApellido.TabIndex = 7;
//            // 
//            // fechaNacimiento
//            // 
//            fechaNacimiento.AutoSize = true;
//            fechaNacimiento.Location = new Point(290, 386);
//            fechaNacimiento.Name = "fechaNacimiento";
//            fechaNacimiento.Size = new Size(122, 15);
//            fechaNacimiento.TabIndex = 8;
//            fechaNacimiento.Text = "Fecha de Nacimiento:";
//            // 
//            // dtpFechaNacimiento
//            // 
//            dtpFechaNacimiento.Location = new Point(245, 426);
//            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
//            dtpFechaNacimiento.Size = new Size(200, 23);
//            dtpFechaNacimiento.TabIndex = 9;
//            // 
//            // jugadorEnLinea
//            // 
//            jugadorEnLinea.AutoSize = true;
//            jugadorEnLinea.Location = new Point(295, 484);
//            jugadorEnLinea.Name = "jugadorEnLinea";
//            jugadorEnLinea.Size = new Size(99, 15);
//            jugadorEnLinea.TabIndex = 10;
//            jugadorEnLinea.Text = "Jugador en Línea:";
//            // 
//            // cmbJugadorEnLinea
//            // 
//            cmbJugadorEnLinea.FormattingEnabled = true;
//            cmbJugadorEnLinea.Items.AddRange(new object[] { "\"Si\"", "", "\"No\"" });
//            cmbJugadorEnLinea.Location = new Point(245, 519);
//            cmbJugadorEnLinea.Name = "cmbJugadorEnLinea";
//            cmbJugadorEnLinea.Size = new Size(198, 23);
//            cmbJugadorEnLinea.TabIndex = 11;
//            // 
//            // btnRegistrar
//            // 
//            btnRegistrar.Location = new Point(281, 592);
//            btnRegistrar.Name = "btnRegistrar";
//            btnRegistrar.Size = new Size(131, 63);
//            btnRegistrar.TabIndex = 12;
//            btnRegistrar.Text = "Registrar";
//            btnRegistrar.UseVisualStyleBackColor = true;
//            btnRegistrar.Click += btnRegistrar_Click;
//            // 
//            // FrmRegistroCliente
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(684, 707);
//            Controls.Add(btnRegistrar);
//            Controls.Add(cmbJugadorEnLinea);
//            Controls.Add(jugadorEnLinea);
//            Controls.Add(dtpFechaNacimiento);
//            Controls.Add(fechaNacimiento);
//            Controls.Add(txtSegundoApellido);
//            Controls.Add(segundoApellido);
//            Controls.Add(txtPrimerApellido);
//            Controls.Add(primerApellido);
//            Controls.Add(txtNombre);
//            Controls.Add(nombre);
//            Controls.Add(txtIdentificacion);
//            Controls.Add(identificacion);
//            Name = "FrmRegistroCliente";
//            Text = "FrmRegistrarCliente";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Label identificacion;
//        private TextBox txtIdentificacion;
//        private Label nombre;
//        private TextBox txtNombre;
//        private Label primerApellido;
//        private TextBox txtPrimerApellido;
//        private Label segundoApellido;
//        private TextBox txtSegundoApellido;
//        private Label fechaNacimiento;
//        private DateTimePicker dtpFechaNacimiento;
//        private Label jugadorEnLinea;
//        private ComboBox cmbJugadorEnLinea;
//        private Button btnRegistrar;
//    }
//}