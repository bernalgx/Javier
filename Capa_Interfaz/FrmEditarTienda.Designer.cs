namespace Capa_Interfaz
{
    partial class FrmEditarTienda
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
            txtNombre = new TextBox();
            label2 = new Label();
            cmbAdministrador = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDireccion = new TextBox();
            cmbActiva = new ComboBox();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 31);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 115);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Administrador";
            // 
            // cmbAdministrador
            // 
            cmbAdministrador.FormattingEnabled = true;
            cmbAdministrador.Location = new Point(90, 153);
            cmbAdministrador.Name = "cmbAdministrador";
            cmbAdministrador.Size = new Size(157, 23);
            cmbAdministrador.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 221);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 322);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 5;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 405);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 6;
            label5.Text = "Activa";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(90, 263);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(157, 23);
            txtDireccion.TabIndex = 7;
            // 
            // cmbActiva
            // 
            cmbActiva.FormattingEnabled = true;
            cmbActiva.Location = new Point(90, 449);
            cmbActiva.Name = "cmbActiva";
            cmbActiva.Size = new Size(157, 23);
            cmbActiva.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(90, 356);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(157, 23);
            txtTelefono.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(28, 504);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 34);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(215, 504);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 34);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // FrmEditarTienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 569);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(cmbActiva);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbAdministrador);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmEditarTienda";
            Text = "FrmEditarTienda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private ComboBox cmbAdministrador;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDireccion;
        private ComboBox cmbActiva;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}