namespace WinForm
{
    partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			label1 = new Label();
			label2 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			pictureBox1 = new PictureBox();
			linkCambioContraseña = new LinkLabel();
			label3 = new Label();
			btnRegistrarse = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(60, 236);
			label1.Name = "label1";
			label1.Size = new Size(64, 21);
			label1.TabIndex = 0;
			label1.Text = "Usuario";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(60, 305);
			label2.Name = "label2";
			label2.Size = new Size(89, 21);
			label2.TabIndex = 1;
			label2.Text = "Contraseña";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(60, 260);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Pone Nombre Fachero Facherito";
			textBox1.Size = new Size(249, 23);
			textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(60, 329);
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "Aca tu contra mostro";
			textBox2.Size = new Size(249, 23);
			textBox2.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(86, 374);
			button1.Name = "button1";
			button1.Size = new Size(89, 30);
			button1.TabIndex = 4;
			button1.Text = "Iniciar Sesion";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.LogoFashero;
			pictureBox1.Location = new Point(76, 60);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(225, 155);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 23;
			pictureBox1.TabStop = false;
			// 
			// linkCambioContraseña
			// 
			linkCambioContraseña.AutoSize = true;
			linkCambioContraseña.Location = new Point(60, 433);
			linkCambioContraseña.Name = "linkCambioContraseña";
			linkCambioContraseña.Size = new Size(115, 15);
			linkCambioContraseña.TabIndex = 24;
			linkCambioContraseña.TabStop = true;
			linkCambioContraseña.Text = "Cambiar Contraseña";
			linkCambioContraseña.LinkClicked += linkCambioContraseña_LinkClicked;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(60, 420);
			label3.Name = "label3";
			label3.Size = new Size(161, 13);
			label3.TabIndex = 25;
			label3.Text = "Desea cambiar su contraseña?";
			// 
			// btnRegistrarse
			// 
			btnRegistrarse.Location = new Point(200, 374);
			btnRegistrarse.Name = "btnRegistrarse";
			btnRegistrarse.Size = new Size(89, 30);
			btnRegistrarse.TabIndex = 26;
			btnRegistrarse.Text = "Registrarse";
			btnRegistrarse.UseVisualStyleBackColor = true;
			btnRegistrarse.Click += btnRegistrarse_Click;
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(383, 481);
			Controls.Add(btnRegistrarse);
			Controls.Add(label3);
			Controls.Add(linkCambioContraseña);
			Controls.Add(pictureBox1);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Inicio";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
		private PictureBox pictureBox1;
		private LinkLabel linkCambioContraseña;
		private Label label3;
		private Button btnRegistrarse;
	}
}