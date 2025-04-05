namespace ServidorApp
{
	partial class FrmServidor
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
			richTextBoxBitacora = new RichTextBox();
			labelClientesConectados = new Label();
			SuspendLayout();
			// 
			// richTextBoxBitacora
			// 
			richTextBoxBitacora.Location = new Point(82, 12);
			richTextBoxBitacora.Name = "richTextBoxBitacora";
			richTextBoxBitacora.Size = new Size(260, 347);
			richTextBoxBitacora.TabIndex = 0;
			richTextBoxBitacora.Text = "";
			// 
			// labelClientesConectados
			// 
			labelClientesConectados.AutoSize = true;
			labelClientesConectados.Location = new Point(376, 39);
			labelClientesConectados.Name = "labelClientesConectados";
			labelClientesConectados.Size = new Size(125, 15);
			labelClientesConectados.TabIndex = 1;
			labelClientesConectados.Text = "Clientes conectados: 0";
			// 
			// FrmServidor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(labelClientesConectados);
			Controls.Add(richTextBoxBitacora);
			Name = "FrmServidor";
			Text = "FrmServidor";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox richTextBoxBitacora;
		private Label labelClientesConectados;
	}
}