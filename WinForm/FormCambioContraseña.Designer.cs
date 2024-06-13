namespace WinForm
{
	partial class FormCambioContraseña
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
			btnCambiarContraseña = new Button();
			pictureBox1 = new PictureBox();
			txtContraseñaActual = new TextBox();
			txtNombreUsuario = new TextBox();
			label2 = new Label();
			label1 = new Label();
			txtNuevaContraseña = new TextBox();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnCambiarContraseña
			// 
			btnCambiarContraseña.Location = new Point(127, 405);
			btnCambiarContraseña.Name = "btnCambiarContraseña";
			btnCambiarContraseña.Size = new Size(119, 33);
			btnCambiarContraseña.TabIndex = 35;
			btnCambiarContraseña.Text = "Cambiar";
			btnCambiarContraseña.UseVisualStyleBackColor = true;
			btnCambiarContraseña.Click += btnCambiarContraseña_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.LogoFashero;
			pictureBox1.Location = new Point(73, 57);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(225, 155);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 34;
			pictureBox1.TabStop = false;
			// 
			// txtContraseñaActual
			// 
			txtContraseñaActual.Location = new Point(62, 308);
			txtContraseñaActual.Name = "txtContraseñaActual";
			txtContraseñaActual.Size = new Size(249, 23);
			txtContraseñaActual.TabIndex = 33;
			// 
			// txtNombreUsuario
			// 
			txtNombreUsuario.Location = new Point(62, 258);
			txtNombreUsuario.Name = "txtNombreUsuario";
			txtNombreUsuario.Size = new Size(249, 23);
			txtNombreUsuario.TabIndex = 32;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(62, 284);
			label2.Name = "label2";
			label2.Size = new Size(136, 21);
			label2.TabIndex = 31;
			label2.Text = "Contraseña Actual";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(62, 234);
			label1.Name = "label1";
			label1.Size = new Size(147, 21);
			label1.TabIndex = 30;
			label1.Text = "Nombre de Usuario";
			// 
			// txtNuevaContraseña
			// 
			txtNuevaContraseña.Location = new Point(62, 363);
			txtNuevaContraseña.Name = "txtNuevaContraseña";
			txtNuevaContraseña.Size = new Size(249, 23);
			txtNuevaContraseña.TabIndex = 37;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(62, 339);
			label3.Name = "label3";
			label3.Size = new Size(138, 21);
			label3.TabIndex = 36;
			label3.Text = "Contraseña Nueva";
			// 
			// FormCambioContraseña
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(383, 481);
			Controls.Add(txtNuevaContraseña);
			Controls.Add(label3);
			Controls.Add(btnCambiarContraseña);
			Controls.Add(pictureBox1);
			Controls.Add(txtContraseñaActual);
			Controls.Add(txtNombreUsuario);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FormCambioContraseña";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cambio de Contraseña";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCambiarContraseña;
		private PictureBox pictureBox1;
		private TextBox txtContraseñaActual;
		private TextBox txtNombreUsuario;
		private Label label2;
		private Label label1;
		private TextBox txtNuevaContraseña;
		private Label label3;
	}
}