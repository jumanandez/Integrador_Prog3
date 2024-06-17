﻿using Krypton.Toolkit;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            pictureBox1 = new KryptonPictureBox();
            txtContraseña = new KryptonTextBox();
            txtNombreUsuario = new KryptonTextBox();
            label2 = new KryptonLabel();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            label1 = new KryptonLabel();
            btnRegistrarse = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(107, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // txtContraseña
            // 
            txtContraseña.CueHint.Color1 = SystemColors.ControlDark;
            txtContraseña.CueHint.CueHintText = "Ingrese una contraseña";
            txtContraseña.CueHint.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
            txtContraseña.Location = new Point(74, 291);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(249, 31);
            txtContraseña.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            txtContraseña.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            txtContraseña.StateCommon.Border.Color2 = Color.Gray;
            txtContraseña.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtContraseña.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtContraseña.StateCommon.Border.Rounding = 16F;
            txtContraseña.StateCommon.Border.Width = 2;
            txtContraseña.StateCommon.Content.Color1 = Color.Gray;
            txtContraseña.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtContraseña.TabIndex = 1;
            txtContraseña.TabStop = false;
            txtContraseña.Click += textBox2_Click;
            txtContraseña.KeyPress += txtContraseña_KeyPress;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.CueHint.Color1 = SystemColors.ControlDark;
            txtNombreUsuario.CueHint.CueHintText = "Ingrese un nombre de usuario";
            txtNombreUsuario.CueHint.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
            txtNombreUsuario.Location = new Point(74, 207);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(249, 31);
            txtNombreUsuario.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            txtNombreUsuario.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            txtNombreUsuario.StateCommon.Border.Color2 = Color.Gray;
            txtNombreUsuario.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtNombreUsuario.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtNombreUsuario.StateCommon.Border.Rounding = 18F;
            txtNombreUsuario.StateCommon.Content.Color1 = Color.Gray;
            txtNombreUsuario.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNombreUsuario.TabIndex = 1;
            txtNombreUsuario.Click += textBox1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.LabelStyle = LabelStyle.Custom1;
            label2.Location = new Point(82, 263);
            label2.Name = "label2";
            label2.Palette = kryptonCustomPaletteBase1;
            label2.PaletteMode = PaletteMode.Custom;
            label2.Size = new Size(80, 19);
            label2.TabIndex = 1;
            label2.Values.Text = "Contraseña";
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteMode = PaletteMode.Office2010Blue;
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
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(32, 30, 30);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(32, 30, 30);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(32, 30, 30);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(32, 30, 30);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.DrawFocus = InheritBool.False;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = Color.LightGray;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.LabelStyle = LabelStyle.Custom1;
            label1.Location = new Point(82, 179);
            label1.Name = "label1";
            label1.Palette = kryptonCustomPaletteBase1;
            label1.PaletteMode = PaletteMode.Custom;
            label1.Size = new Size(124, 19);
            label1.TabIndex = 0;
            label1.Values.Text = "Nombre de usuario";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Enabled = false;
            btnRegistrarse.Location = new Point(116, 355);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.OverrideDefault.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnRegistrarse.OverrideDefault.Back.Color2 = Color.Navy;
            btnRegistrarse.OverrideDefault.Back.ColorAngle = 45F;
            btnRegistrarse.OverrideDefault.Border.Color1 = Color.Navy;
            btnRegistrarse.OverrideDefault.Border.Color2 = Color.Gray;
            btnRegistrarse.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnRegistrarse.OverrideDefault.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnRegistrarse.OverrideDefault.Border.ImageAlign = PaletteRectangleAlign.Local;
            btnRegistrarse.OverrideDefault.Border.Rounding = 18F;
            btnRegistrarse.Size = new Size(150, 46);
            btnRegistrarse.StateCommon.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnRegistrarse.StateCommon.Back.Color2 = Color.Navy;
            btnRegistrarse.StateCommon.Back.ColorAngle = 45F;
            btnRegistrarse.StateCommon.Border.Color1 = Color.Navy;
            btnRegistrarse.StateCommon.Border.Color2 = Color.Gray;
            btnRegistrarse.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnRegistrarse.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnRegistrarse.StateCommon.Border.ImageAlign = PaletteRectangleAlign.Local;
            btnRegistrarse.StateCommon.Border.Rounding = 18F;
            btnRegistrarse.StateCommon.Content.ShortText.Color1 = Color.White;
            btnRegistrarse.StateCommon.Content.ShortText.Color2 = Color.White;
            btnRegistrarse.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRegistrarse.StateDisabled.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnRegistrarse.StateDisabled.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnRegistrarse.StateDisabled.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnRegistrarse.StateDisabled.Border.Color2 = Color.Gray;
            btnRegistrarse.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnRegistrarse.StateDisabled.Content.ShortText.Color1 = Color.Silver;
            btnRegistrarse.StateDisabled.Content.ShortText.Color2 = Color.Silver;
            btnRegistrarse.StatePressed.Back.Color1 = Color.FromArgb(0, 0, 64);
            btnRegistrarse.StatePressed.Back.Color2 = Color.FromArgb(24, 24, 84);
            btnRegistrarse.StatePressed.Back.ColorAngle = 45F;
            btnRegistrarse.StatePressed.Border.Color1 = Color.FromArgb(224, 224, 224);
            btnRegistrarse.StatePressed.Border.Color2 = Color.Gray;
            btnRegistrarse.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnRegistrarse.StateTracking.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnRegistrarse.StateTracking.Back.Color2 = Color.Navy;
            btnRegistrarse.StateTracking.Back.ColorAngle = 135F;
            btnRegistrarse.StateTracking.Border.Color1 = Color.White;
            btnRegistrarse.StateTracking.Border.Color2 = Color.FromArgb(224, 224, 224);
            btnRegistrarse.StateTracking.Border.ColorAngle = 45F;
            btnRegistrarse.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnRegistrarse.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnRegistrarse.StateTracking.Border.Rounding = 18F;
            btnRegistrarse.StateTracking.Content.ShortText.Color1 = Color.Gainsboro;
            btnRegistrarse.StateTracking.Content.ShortText.Color2 = Color.Gainsboro;
            btnRegistrarse.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.TabIndex = 29;
            btnRegistrarse.Values.Text = "Registrarse";
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(384, 431);
            Controls.Add(btnRegistrarse);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 470);
            Name = "FormRegister";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrarse";
            TitleStyle = KryptonFormTitleStyle.Classic;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonPictureBox pictureBox1;
		private KryptonTextBox txtContraseña;
		private KryptonTextBox txtNombreUsuario;
		private KryptonLabel label2;
		private KryptonLabel label1;
		private KryptonButton btnRegistrarse;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}