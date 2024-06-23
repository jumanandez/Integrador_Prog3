using Krypton.Toolkit;
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            txtContrasenaActual = new KryptonTextBox();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            txtNombreUsuario = new KryptonTextBox();
            lblcontraseniaA = new Label();
            lblnombreusuario = new Label();
            txtNuevaContrasena = new KryptonTextBox();
            lblnvcontr = new Label();
            txtConfirmarContrasena = new KryptonTextBox();
            lblconfrcontr = new Label();
            btnconfirmar = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(76, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // txtContrasenaActual
            // 
            txtContrasenaActual.CueHint.Color1 = SystemColors.ControlDarkDark;
            txtContrasenaActual.CueHint.CueHintText = "Ingrese su contraseña actual";
            txtContrasenaActual.CueHint.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
            txtContrasenaActual.CueHint.Padding = new Padding(-1, 0, -1, -1);
            txtContrasenaActual.Cursor = Cursors.IBeam;
            txtContrasenaActual.Location = new Point(62, 285);
            txtContrasenaActual.Margin = new Padding(0);
            txtContrasenaActual.Name = "txtContrasenaActual";
            txtContrasenaActual.Palette = kryptonCustomPaletteBase1;
            txtContrasenaActual.PaletteMode = PaletteMode.Custom;
            txtContrasenaActual.PasswordChar = '●';
            txtContrasenaActual.Size = new Size(249, 36);
            txtContrasenaActual.TabIndex = 2;
            txtContrasenaActual.UseSystemPasswordChar = true;
            txtContrasenaActual.KeyPress += txtContrasenaActual_KeyPress;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonCustomPaletteBase1.Common.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.Common.StateCommon.Back.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.Common.StateCommon.Back.ColorAlign = PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.Common.StateCommon.Back.ColorAngle = 45F;
            kryptonCustomPaletteBase1.Common.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.Common.StateCommon.Border.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.Common.StateCommon.Border.ColorAlign = PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.Common.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.Common.StateCommon.Border.ColorStyle = PaletteColorStyle.Switch90;
            kryptonCustomPaletteBase1.Common.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.Common.StateCommon.Border.Rounding = 18F;
            kryptonCustomPaletteBase1.Common.StateCommon.Content.ShortText.Color1 = Color.Silver;
            kryptonCustomPaletteBase1.Common.StateCommon.Content.ShortText.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.Common.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F);
            kryptonCustomPaletteBase1.Common.StateDisabled.Back.Color1 = Color.DimGray;
            kryptonCustomPaletteBase1.Common.StateDisabled.Back.Color2 = Color.DimGray;
            kryptonCustomPaletteBase1.Common.StateDisabled.Border.Color1 = Color.Silver;
            kryptonCustomPaletteBase1.Common.StateDisabled.Border.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.Common.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.Common.StateDisabled.Content.ShortText.Color1 = Color.DarkGray;
            kryptonCustomPaletteBase1.Common.StateDisabled.Content.ShortText.Color2 = Color.DarkGray;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(26, 26, 28);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(26, 26, 28);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(32, 30, 30);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(32, 30, 30);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.DrawFocus = InheritBool.False;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = Color.LightGray;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.CueHint.Color1 = SystemColors.ControlDarkDark;
            txtNombreUsuario.CueHint.CueHintText = "Ingrese un nombre";
            txtNombreUsuario.CueHint.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
            txtNombreUsuario.CueHint.Padding = new Padding(-1, 0, -1, -1);
            txtNombreUsuario.Cursor = Cursors.IBeam;
            txtNombreUsuario.Location = new Point(62, 219);
            txtNombreUsuario.Margin = new Padding(0);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Palette = kryptonCustomPaletteBase1;
            txtNombreUsuario.PaletteMode = PaletteMode.Custom;
            txtNombreUsuario.Size = new Size(249, 36);
            txtNombreUsuario.TabIndex = 1;
            txtNombreUsuario.KeyPress += txtContraseñaActual_KeyPress;
            // 
            // lblcontraseniaA
            // 
            lblcontraseniaA.AutoSize = true;
            lblcontraseniaA.Font = new Font("Microsoft Sans Serif", 12F);
            lblcontraseniaA.ForeColor = Color.LightGray;
            lblcontraseniaA.Location = new Point(62, 261);
            lblcontraseniaA.Name = "lblcontraseniaA";
            lblcontraseniaA.Size = new Size(139, 20);
            lblcontraseniaA.TabIndex = 7;
            lblcontraseniaA.Text = "Contraseña actual";
            // 
            // lblnombreusuario
            // 
            lblnombreusuario.AutoSize = true;
            lblnombreusuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombreusuario.ForeColor = Color.LightGray;
            lblnombreusuario.Location = new Point(62, 195);
            lblnombreusuario.Name = "lblnombreusuario";
            lblnombreusuario.Size = new Size(143, 20);
            lblnombreusuario.TabIndex = 6;
            lblnombreusuario.Text = "Nombre de usuario";
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.CueHint.Color1 = SystemColors.ControlDarkDark;
            txtNuevaContrasena.CueHint.CueHintText = "Ingrese la nueva contraseña";
            txtNuevaContrasena.CueHint.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
            txtNuevaContrasena.CueHint.Padding = new Padding(-1, 0, -1, -1);
            txtNuevaContrasena.Cursor = Cursors.IBeam;
            txtNuevaContrasena.Location = new Point(62, 354);
            txtNuevaContrasena.Margin = new Padding(0);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.Palette = kryptonCustomPaletteBase1;
            txtNuevaContrasena.PaletteMode = PaletteMode.Custom;
            txtNuevaContrasena.PasswordChar = '●';
            txtNuevaContrasena.Size = new Size(249, 36);
            txtNuevaContrasena.TabIndex = 3;
            txtNuevaContrasena.UseSystemPasswordChar = true;
            txtNuevaContrasena.KeyPress += txtContraseñaActual_KeyPress2;
            // 
            // lblnvcontr
            // 
            lblnvcontr.AutoSize = true;
            lblnvcontr.Font = new Font("Microsoft Sans Serif", 12F);
            lblnvcontr.ForeColor = Color.LightGray;
            lblnvcontr.Location = new Point(62, 328);
            lblnvcontr.Name = "lblnvcontr";
            lblnvcontr.Size = new Size(139, 20);
            lblnvcontr.TabIndex = 8;
            lblnvcontr.Text = "Contraseña nueva";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.CueHint.Color1 = SystemColors.ControlDarkDark;
            txtConfirmarContrasena.CueHint.CueHintText = "Vuelva a ingresar la contraseña";
            txtConfirmarContrasena.CueHint.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
            txtConfirmarContrasena.CueHint.Padding = new Padding(-1, 0, -1, -1);
            txtConfirmarContrasena.Cursor = Cursors.IBeam;
            txtConfirmarContrasena.Location = new Point(62, 426);
            txtConfirmarContrasena.Margin = new Padding(0);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Palette = kryptonCustomPaletteBase1;
            txtConfirmarContrasena.PaletteMode = PaletteMode.Custom;
            txtConfirmarContrasena.PasswordChar = '●';
            txtConfirmarContrasena.Size = new Size(249, 36);
            txtConfirmarContrasena.TabIndex = 4;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            txtConfirmarContrasena.KeyPress += txtContraseñaActual_KeyPress3;
            // 
            // lblconfrcontr
            // 
            lblconfrcontr.AutoSize = true;
            lblconfrcontr.Font = new Font("Microsoft Sans Serif", 12F);
            lblconfrcontr.ForeColor = Color.LightGray;
            lblconfrcontr.Location = new Point(62, 400);
            lblconfrcontr.Name = "lblconfrcontr";
            lblconfrcontr.Size = new Size(225, 20);
            lblconfrcontr.TabIndex = 9;
            lblconfrcontr.Text = "Confirmar la nueva contraseña";
            // 
            // btnconfirmar
            // 
            btnconfirmar.Location = new Point(127, 475);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.OverrideDefault.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnconfirmar.OverrideDefault.Back.Color2 = Color.Navy;
            btnconfirmar.OverrideDefault.Back.ColorAngle = 45F;
            btnconfirmar.OverrideDefault.Border.Color1 = Color.Navy;
            btnconfirmar.OverrideDefault.Border.Color2 = Color.Gray;
            btnconfirmar.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnconfirmar.OverrideDefault.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnconfirmar.OverrideDefault.Border.ImageAlign = PaletteRectangleAlign.Local;
            btnconfirmar.OverrideDefault.Border.Rounding = 18F;
            btnconfirmar.Size = new Size(120, 42);
            btnconfirmar.StateCommon.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnconfirmar.StateCommon.Back.Color2 = Color.Navy;
            btnconfirmar.StateCommon.Back.ColorAngle = 45F;
            btnconfirmar.StateCommon.Border.Color1 = Color.Navy;
            btnconfirmar.StateCommon.Border.Color2 = Color.Gray;
            btnconfirmar.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnconfirmar.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnconfirmar.StateCommon.Border.ImageAlign = PaletteRectangleAlign.Local;
            btnconfirmar.StateCommon.Border.Rounding = 18F;
            btnconfirmar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnconfirmar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnconfirmar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnconfirmar.StateDisabled.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnconfirmar.StateDisabled.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnconfirmar.StateDisabled.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnconfirmar.StateDisabled.Border.Color2 = Color.Gray;
            btnconfirmar.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnconfirmar.StateDisabled.Content.ShortText.Color1 = Color.Silver;
            btnconfirmar.StateDisabled.Content.ShortText.Color2 = Color.Silver;
            btnconfirmar.StatePressed.Back.Color1 = Color.FromArgb(0, 0, 64);
            btnconfirmar.StatePressed.Back.Color2 = Color.FromArgb(24, 24, 92);
            btnconfirmar.StatePressed.Back.ColorAngle = 45F;
            btnconfirmar.StatePressed.Border.Color1 = Color.FromArgb(224, 224, 224);
            btnconfirmar.StatePressed.Border.Color2 = Color.Gray;
            btnconfirmar.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnconfirmar.StateTracking.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnconfirmar.StateTracking.Back.Color2 = Color.Navy;
            btnconfirmar.StateTracking.Back.ColorAngle = 135F;
            btnconfirmar.StateTracking.Border.Color1 = Color.White;
            btnconfirmar.StateTracking.Border.Color2 = Color.FromArgb(224, 224, 224);
            btnconfirmar.StateTracking.Border.ColorAngle = 45F;
            btnconfirmar.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnconfirmar.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnconfirmar.StateTracking.Border.Rounding = 18F;
            btnconfirmar.StateTracking.Content.ShortText.Color1 = Color.Gainsboro;
            btnconfirmar.StateTracking.Content.ShortText.Color2 = Color.Gainsboro;
            btnconfirmar.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconfirmar.TabIndex = 5;
            btnconfirmar.Values.Text = "Cambiar";
            btnconfirmar.Click += btnCambiarContraseña_Click;
            // 
            // FormCambioContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(383, 529);
            Controls.Add(btnconfirmar);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(lblconfrcontr);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(lblnvcontr);
            Controls.Add(pictureBox1);
            Controls.Add(txtContrasenaActual);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblcontraseniaA);
            Controls.Add(lblnombreusuario);
            FormTitleAlign = PaletteRelativeAlign.Inherit;
            Name = "FormCambioContrasena";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            StateCommon.Header.Back.Color1 = Color.FromArgb(32, 30, 30);
            StateCommon.Header.Back.Color2 = Color.FromArgb(32, 30, 30);
            StateCommon.Header.Border.Color1 = Color.FromArgb(36, 36, 36);
            StateCommon.Header.Border.Color2 = Color.FromArgb(36, 36, 36);
            StateCommon.Header.Border.DrawBorders = PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            StateCommon.Header.Border.Rounding = 0F;
            StateCommon.Header.ButtonEdgeInset = 12;
            StateCommon.Header.Content.ShortText.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text = "Cambio de Contraseña";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
		private KryptonTextBox txtContrasenaActual;
		private KryptonTextBox txtNombreUsuario;
		private Label lblcontraseniaA;
		private Label lblnombreusuario;
		private KryptonTextBox txtNuevaContrasena;
		private Label lblnvcontr;
        private KryptonTextBox txtConfirmarContrasena;
        private Label lblconfrcontr;
        private KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private KryptonButton btnconfirmar;
    }
}