//namespace Capa_Interfaz
//{
//    partial class FrmRegistroTienda
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
//            id = new Label();
//            txtId = new TextBox();
//            nombre = new Label();
//            txtNombre = new TextBox();
//            administrador = new Label();
//            cmbAdministrador = new ComboBox();
//            direccion = new Label();
//            txtDireccion = new TextBox();
//            telefono = new Label();
//            txtTelefono = new TextBox();
//            activa = new Label();
//            cmbActiva = new ComboBox();
//            btnRegistrar = new Button();
//            SuspendLayout();
//            // 
//            // id
//            // 
//            id.AutoSize = true;
//            id.Location = new Point(300, 29);
//            id.Name = "id";
//            id.Size = new Size(21, 15);
//            id.TabIndex = 0;
//            id.Text = "ID:";
//            // 
//            // txtId
//            // 
//            txtId.Location = new Point(231, 56);
//            txtId.Name = "txtId";
//            txtId.Size = new Size(177, 23);
//            txtId.TabIndex = 1;
//            // 
//            // nombre
//            // 
//            nombre.AutoSize = true;
//            nombre.Location = new Point(290, 104);
//            nombre.Name = "nombre";
//            nombre.Size = new Size(54, 15);
//            nombre.TabIndex = 2;
//            nombre.Text = "Nombre:";
//            // 
//            // txtNombre
//            // 
//            txtNombre.Location = new Point(231, 136);
//            txtNombre.Name = "txtNombre";
//            txtNombre.Size = new Size(177, 23);
//            txtNombre.TabIndex = 3;
//            // 
//            // administrador
//            // 
//            administrador.AutoSize = true;
//            administrador.Location = new Point(274, 188);
//            administrador.Name = "administrador";
//            administrador.Size = new Size(86, 15);
//            administrador.TabIndex = 4;
//            administrador.Text = "Administrador:";
//            // 
//            // cmbAdministrador
//            // 
//            cmbAdministrador.FormattingEnabled = true;
//            cmbAdministrador.Location = new Point(231, 228);
//            cmbAdministrador.Name = "cmbAdministrador";
//            cmbAdministrador.Size = new Size(177, 23);
//            cmbAdministrador.TabIndex = 5;
//            // 
//            // direccion
//            // 
//            direccion.AutoSize = true;
//            direccion.Location = new Point(290, 280);
//            direccion.Name = "direccion";
//            direccion.Size = new Size(60, 15);
//            direccion.TabIndex = 6;
//            direccion.Text = "Dirección:";
//            // 
//            // txtDireccion
//            // 
//            txtDireccion.Location = new Point(231, 323);
//            txtDireccion.Name = "txtDireccion";
//            txtDireccion.Size = new Size(177, 23);
//            txtDireccion.TabIndex = 7;
//            // 
//            // telefono
//            // 
//            telefono.AutoSize = true;
//            telefono.Location = new Point(294, 384);
//            telefono.Name = "telefono";
//            telefono.Size = new Size(56, 15);
//            telefono.TabIndex = 8;
//            telefono.Text = "Teléfono:";
//            // 
//            // txtTelefono
//            // 
//            txtTelefono.Location = new Point(231, 420);
//            txtTelefono.Name = "txtTelefono";
//            txtTelefono.Size = new Size(177, 23);
//            txtTelefono.TabIndex = 9;
//            // 
//            // activa
//            // 
//            activa.AutoSize = true;
//            activa.Location = new Point(299, 478);
//            activa.Name = "activa";
//            activa.Size = new Size(43, 15);
//            activa.TabIndex = 10;
//            activa.Text = "Activa:";
//            // 
//            // cmbActiva
//            // 
//            cmbActiva.FormattingEnabled = true;
//            cmbActiva.Items.AddRange(new object[] { "\"Si\"", "", "\"No\"" });
//            cmbActiva.Location = new Point(231, 519);
//            cmbActiva.Name = "cmbActiva";
//            cmbActiva.Size = new Size(177, 23);
//            cmbActiva.TabIndex = 11;
//            // 
//            // btnRegistrar
//            // 
//            btnRegistrar.Location = new Point(274, 611);
//            btnRegistrar.Name = "btnRegistrar";
//            btnRegistrar.Size = new Size(98, 50);
//            btnRegistrar.TabIndex = 12;
//            btnRegistrar.Text = "Registrar";
//            btnRegistrar.UseVisualStyleBackColor = true;
//            btnRegistrar.Click += btnRegistrar_Click;
//            // 
//            // FrmRegistroTienda
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(640, 770);
//            Controls.Add(btnRegistrar);
//            Controls.Add(cmbActiva);
//            Controls.Add(activa);
//            Controls.Add(txtTelefono);
//            Controls.Add(telefono);
//            Controls.Add(txtDireccion);
//            Controls.Add(direccion);
//            Controls.Add(cmbAdministrador);
//            Controls.Add(administrador);
//            Controls.Add(txtNombre);
//            Controls.Add(nombre);
//            Controls.Add(txtId);
//            Controls.Add(id);
//            Name = "FrmRegistroTienda";
//            Text = "FrmRegistroTienda";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Label id;
//        private TextBox txtId;
//        private Label nombre;
//        private TextBox txtNombre;
//        private Label administrador;
//        private ComboBox cmbAdministrador;
//        private Label direccion;
//        private TextBox txtDireccion;
//        private Label telefono;
//        private TextBox txtTelefono;
//        private Label activa;
//        private ComboBox cmbActiva;
//        private Button btnRegistrar;
//    }
//}