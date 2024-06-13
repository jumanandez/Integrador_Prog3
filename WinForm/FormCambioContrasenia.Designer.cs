namespace WinForm
{
	partial class FormCambioContrasena
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
			txtContrasenaActual = new TextBox();
			txtNombreUsuario = new TextBox();
			label2 = new Label();
			label1 = new Label();
			txtNuevaContrasena = new TextBox();
			lblnvcontr = new Label();
			txtConfirmarContrasena = new TextBox();
			lblconfrcontr = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnCambiarContraseña
			// 
			btnCambiarContraseña.Location = new Point(125, 436);
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
			pictureBox1.Location = new Point(76, 24);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(225, 155);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 34;
			pictureBox1.TabStop = false;
			// 
			// txtContrasenaActual
			// 
			txtContrasenaActual.Location = new Point(62, 282);
			txtContrasenaActual.Name = "txtContrasenaActual";
			txtContrasenaActual.Size = new Size(249, 23);
			txtContrasenaActual.TabIndex = 33;
			txtContrasenaActual.UseSystemPasswordChar = true;
			txtContrasenaActual.KeyPress += txtContraseñaActual_KeyPress;
			// 
			// txtNombreUsuario
			// 
			txtNombreUsuario.Location = new Point(62, 225);
			txtNombreUsuario.Name = "txtNombreUsuario";
			txtNombreUsuario.Size = new Size(249, 23);
			txtNombreUsuario.TabIndex = 32;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(62, 258);
			label2.Name = "label2";
			label2.Size = new Size(134, 21);
			label2.TabIndex = 31;
			label2.Text = "Contraseña actual";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(62, 201);
			label1.Name = "label1";
			label1.Size = new Size(145, 21);
			label1.TabIndex = 30;
			label1.Text = "Nombre de usuario";
			// 
			// txtNuevaContrasena
			// 
			txtNuevaContrasena.Location = new Point(62, 343);
			txtNuevaContrasena.Name = "txtNuevaContrasena";
			txtNuevaContrasena.Size = new Size(249, 23);
			txtNuevaContrasena.TabIndex = 37;
			txtNuevaContrasena.UseSystemPasswordChar = true;
			txtNuevaContrasena.KeyPress += txtContraseñaActual_KeyPress;
			// 
			// lblnvcontr
			// 
			lblnvcontr.AutoSize = true;
			lblnvcontr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblnvcontr.Location = new Point(62, 319);
			lblnvcontr.Name = "lblnvcontr";
			lblnvcontr.Size = new Size(135, 21);
			lblnvcontr.TabIndex = 36;
			lblnvcontr.Text = "Contraseña nueva";
			// 
			// txtConfirmarContrasena
			// 
			txtConfirmarContrasena.Location = new Point(62, 403);
			txtConfirmarContrasena.Name = "txtConfirmarContrasena";
			txtConfirmarContrasena.Size = new Size(249, 23);
			txtConfirmarContrasena.TabIndex = 39;
			txtConfirmarContrasena.UseSystemPasswordChar = true;
			txtConfirmarContrasena.KeyPress += txtContraseñaActual_KeyPress;
			// 
			// lblconfrcontr
			// 
			lblconfrcontr.AutoSize = true;
			lblconfrcontr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblconfrcontr.Location = new Point(62, 379);
			lblconfrcontr.Name = "lblconfrcontr";
			lblconfrcontr.Size = new Size(223, 21);
			lblconfrcontr.TabIndex = 38;
			lblconfrcontr.Text = "Confirmar la nueva contraseña";
			// 
			// FormCambioContrasena
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(383, 481);
			Controls.Add(txtConfirmarContrasena);
			Controls.Add(lblconfrcontr);
			Controls.Add(txtNuevaContrasena);
			Controls.Add(lblnvcontr);
			Controls.Add(btnCambiarContraseña);
			Controls.Add(pictureBox1);
			Controls.Add(txtContrasenaActual);
			Controls.Add(txtNombreUsuario);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FormCambioContrasena";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cambio de Contraseña";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCambiarContraseña;
		private PictureBox pictureBox1;
		private TextBox txtContrasenaActual;
		private TextBox txtNombreUsuario;
		private Label label2;
		private Label label1;
		private TextBox txtNuevaContrasena;
		private Label lblnvcontr;
        private TextBox txtConfirmarContrasena;
        private Label lblconfrcontr;
    }
}