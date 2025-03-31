namespace Capa_Interfaz
{
    partial class FrmEditarCliente
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
            label1 = new Label();
            txtIdentificacion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtPrimerApellido = new TextBox();
            label4 = new Label();
            txtSegundoApellido = new TextBox();
            label5 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label6 = new Label();
            cmbJugadorEnLinea = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 37);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Identificacion:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(101, 78);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(156, 23);
            txtIdentificacion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 130);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 159);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 233);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 4;
            label3.Text = "Primer Apellido:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(101, 271);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(156, 23);
            txtPrimerApellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 324);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 6;
            label4.Text = "Segundo Apellido:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(101, 364);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(156, 23);
            txtSegundoApellido.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 425);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(84, 462);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 523);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 10;
            label6.Text = "Jugador en Linea:";
            // 
            // cmbJugadorEnLinea
            // 
            cmbJugadorEnLinea.FormattingEnabled = true;
            cmbJugadorEnLinea.Location = new Point(101, 558);
            cmbJugadorEnLinea.Name = "cmbJugadorEnLinea";
            cmbJugadorEnLinea.Size = new Size(156, 23);
            cmbJugadorEnLinea.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(28, 612);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(87, 36);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(263, 612);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 36);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 674);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbJugadorEnLinea);
            Controls.Add(label6);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label5);
            Controls.Add(txtSegundoApellido);
            Controls.Add(label4);
            Controls.Add(txtPrimerApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtIdentificacion);
            Controls.Add(label1);
            Name = "FrmEditarCliente";
            Text = "FrmEditarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdentificacion;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtPrimerApellido;
        private Label label4;
        private TextBox txtSegundoApellido;
        private Label label5;
        private DateTimePicker dtpFechaNacimiento;
        private Label label6;
        private ComboBox cmbJugadorEnLinea;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}