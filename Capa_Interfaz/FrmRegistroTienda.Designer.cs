namespace Capa_Interfaz
{
    partial class FrmRegistroTienda
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
            lblAdministrador = new Label();
            cmbAdministrador = new ComboBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            lblActiva = new Label();
            cmbActiva = new ComboBox();
            btnRegistrar = new Button();
            txtTelefono = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.Location = new Point(169, 115);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(86, 15);
            lblAdministrador.TabIndex = 2;
            lblAdministrador.Text = "Administrador:";
            // 
            // cmbAdministrador
            // 
            cmbAdministrador.FormattingEnabled = true;
            cmbAdministrador.Location = new Point(122, 151);
            cmbAdministrador.Name = "cmbAdministrador";
            cmbAdministrador.Size = new Size(169, 23);
            cmbAdministrador.TabIndex = 3;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(179, 217);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(122, 258);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(169, 23);
            txtDireccion.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(185, 322);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            // 
            // lblActiva
            // 
            lblActiva.AutoSize = true;
            lblActiva.Location = new Point(185, 423);
            lblActiva.Name = "lblActiva";
            lblActiva.Size = new Size(43, 15);
            lblActiva.TabIndex = 8;
            lblActiva.Text = "Activa:";
            // 
            // cmbActiva
            // 
            cmbActiva.FormattingEnabled = true;
            cmbActiva.Location = new Point(122, 460);
            cmbActiva.Name = "cmbActiva";
            cmbActiva.Size = new Size(169, 23);
            cmbActiva.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(157, 535);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(98, 38);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(122, 370);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(169, 23);
            txtTelefono.TabIndex = 11;
            // 
            // FrmRegistroTienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 617);
            Controls.Add(txtTelefono);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbActiva);
            Controls.Add(lblActiva);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(cmbAdministrador);
            Controls.Add(lblAdministrador);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmRegistroTienda";
            Text = "FrmRegistroTienda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label lblAdministrador;
        private ComboBox cmbAdministrador;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private Label lblActiva;
        private ComboBox cmbActiva;
        private Button btnRegistrar;
        private TextBox txtTelefono;
    }
}