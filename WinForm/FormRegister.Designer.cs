namespace WinForm
{
	partial class FormRegister
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
			pictureBox1 = new PictureBox();
			txtContraseña = new TextBox();
			txtNombreUsuario = new TextBox();
			label2 = new Label();
			label1 = new Label();
			btnRegistrarse = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.LogoFashero;
			pictureBox1.Location = new Point(73, 86);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(225, 155);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 28;
			pictureBox1.TabStop = false;
			// 
			// txtContraseña
			// 
			txtContraseña.Location = new Point(57, 355);
			txtContraseña.Name = "txtContraseña";
			txtContraseña.Size = new Size(249, 23);
			txtContraseña.TabIndex = 27;
			// 
			// txtNombreUsuario
			// 
			txtNombreUsuario.Location = new Point(57, 286);
			txtNombreUsuario.Name = "txtNombreUsuario";
			txtNombreUsuario.Size = new Size(249, 23);
			txtNombreUsuario.TabIndex = 26;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(57, 331);
			label2.Name = "label2";
			label2.Size = new Size(89, 21);
			label2.TabIndex = 25;
			label2.Text = "Contraseña";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(57, 262);
			label1.Name = "label1";
			label1.Size = new Size(147, 21);
			label1.TabIndex = 24;
			label1.Text = "Nombre de Usuario";
			// 
			// btnRegistrarse
			// 
			btnRegistrarse.Location = new Point(118, 397);
			btnRegistrarse.Name = "btnRegistrarse";
			btnRegistrarse.Size = new Size(119, 33);
			btnRegistrarse.TabIndex = 29;
			btnRegistrarse.Text = "Registrarse";
			btnRegistrarse.UseVisualStyleBackColor = true;
			btnRegistrarse.Click += btnRegistrarse_Click;
			// 
			// FormRegister
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(383, 481);
			Controls.Add(btnRegistrarse);
			Controls.Add(pictureBox1);
			Controls.Add(txtContraseña);
			Controls.Add(txtNombreUsuario);
			Controls.Add(label2);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormRegister";
			Text = "Registrarse";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private TextBox txtContraseña;
		private TextBox txtNombreUsuario;
		private Label label2;
		private Label label1;
		private Button btnRegistrarse;
	}
}