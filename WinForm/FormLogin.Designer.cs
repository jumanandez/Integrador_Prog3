using Krypton.Toolkit;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new KryptonLabel();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            label2 = new KryptonLabel();
            textBox1 = new KryptonTextBox();
            textBox2 = new KryptonTextBox();
            button1 = new KryptonButton();
            pictureBox1 = new PictureBox();
            linkRegistrarse = new LinkLabel();
            kryptonButton1 = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.LabelStyle = LabelStyle.Custom1;
            label1.Location = new Point(82, 179);
            label1.Name = "label1";
            label1.Palette = kryptonCustomPaletteBase1;
            label1.PaletteMode = PaletteMode.Custom;
            label1.Size = new Size(61, 22);
            label1.TabIndex = 0;
            label1.Values.Text = "Usuario";
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
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.LabelStyle = LabelStyle.Custom1;
            label2.Location = new Point(82, 263);
            label2.Name = "label2";
            label2.Palette = kryptonCustomPaletteBase1;
            label2.PaletteMode = PaletteMode.Custom;
            label2.Size = new Size(90, 22);
            label2.TabIndex = 1;
            label2.Values.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.AlwaysActive = false;
            textBox1.Location = new Point(74, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 32);
            textBox1.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            textBox1.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            textBox1.StateCommon.Border.Color2 = Color.Gray;
            textBox1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            textBox1.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            textBox1.StateCommon.Border.Rounding = 18F;
            textBox1.StateCommon.Content.Color1 = Color.Gray;
            textBox1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            textBox1.TabIndex = 2;
            textBox1.TabStop = false;
            textBox1.Text = "Ingrese su usuario";
            textBox1.Click += textBox1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(74, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 32);
            textBox2.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            textBox2.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            textBox2.StateCommon.Border.Color2 = Color.Gray;
            textBox2.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            textBox2.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            textBox2.StateCommon.Border.Rounding = 16F;
            textBox2.StateCommon.Border.Width = 2;
            textBox2.StateCommon.Content.Color1 = Color.Gray;
            textBox2.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            textBox2.TabIndex = 3;
            textBox2.TabStop = false;
            textBox2.Text = "Ingrese una contraseña";
            textBox2.Click += textBox2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(77, 350);
            button1.Name = "button1";
            button1.OverrideDefault.Back.Color1 = Color.FromArgb(0, 0, 192);
            button1.OverrideDefault.Back.Color2 = Color.Navy;
            button1.OverrideDefault.Back.ColorAngle = 45F;
            button1.OverrideDefault.Border.Color1 = Color.Navy;
            button1.OverrideDefault.Border.Color2 = Color.Gray;
            button1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            button1.OverrideDefault.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            button1.OverrideDefault.Border.ImageAlign = PaletteRectangleAlign.Local;
            button1.OverrideDefault.Border.Rounding = 18F;
            button1.Size = new Size(120, 42);
            button1.StateCommon.Back.Color1 = Color.FromArgb(0, 0, 192);
            button1.StateCommon.Back.Color2 = Color.Navy;
            button1.StateCommon.Back.ColorAngle = 45F;
            button1.StateCommon.Border.Color1 = Color.Navy;
            button1.StateCommon.Border.Color2 = Color.Gray;
            button1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            button1.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            button1.StateCommon.Border.ImageAlign = PaletteRectangleAlign.Local;
            button1.StateCommon.Border.Rounding = 18F;
            button1.StateCommon.Content.ShortText.Color1 = Color.White;
            button1.StateCommon.Content.ShortText.Color2 = Color.White;
            button1.StateCommon.Content.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Bold);
            button1.StatePressed.Back.Color1 = Color.FromArgb(0, 0, 64);
            button1.StatePressed.Back.Color2 = Color.FromArgb(24, 24, 92);
            button1.StatePressed.Back.ColorAngle = 45F;
            button1.StatePressed.Border.Color1 = Color.FromArgb(224, 224, 224);
            button1.StatePressed.Border.Color2 = Color.Gray;
            button1.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            button1.StateTracking.Back.Color1 = Color.FromArgb(0, 0, 192);
            button1.StateTracking.Back.Color2 = Color.Navy;
            button1.StateTracking.Back.ColorAngle = 135F;
            button1.StateTracking.Border.Color1 = Color.White;
            button1.StateTracking.Border.Color2 = Color.FromArgb(224, 224, 224);
            button1.StateTracking.Border.ColorAngle = 45F;
            button1.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            button1.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            button1.StateTracking.Border.Rounding = 18F;
            button1.StateTracking.Content.ShortText.Color1 = Color.Gainsboro;
            button1.StateTracking.Content.ShortText.Color2 = Color.Gainsboro;
            button1.StateTracking.Content.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.TabIndex = 4;
            button1.Values.Text = "Iniciar Sesion";
            button1.Click += button1_Click;
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
            // linkRegistrarse
            // 
            linkRegistrarse.AutoSize = true;
            linkRegistrarse.LinkColor = Color.RoyalBlue;
            linkRegistrarse.Location = new Point(79, 411);
            linkRegistrarse.Name = "linkRegistrarse";
            linkRegistrarse.Size = new Size(113, 15);
            linkRegistrarse.TabIndex = 24;
            linkRegistrarse.TabStop = true;
            linkRegistrarse.Text = "Cambiar contraseña";
            linkRegistrarse.LinkClicked += linkRegistrarse_LinkClicked;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(203, 350);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(32, 32, 32);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(32, 32, 32);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.RoyalBlue;
            kryptonButton1.OverrideDefault.Border.Color2 = Color.CornflowerBlue;
            kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.OverrideDefault.Border.Rounding = 18F;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.OverrideDefault.Content.ShortText.Color1 = Color.Gainsboro;
            kryptonButton1.OverrideDefault.Content.ShortText.Color2 = Color.Gainsboro;
            kryptonButton1.OverrideDefault.Content.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.PaletteMode = PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(120, 42);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(32, 32, 32);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(32, 32, 32);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.Color1 = Color.RoyalBlue;
            kryptonButton1.StateCommon.Border.Color2 = Color.CornflowerBlue;
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 18F;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(24, 24, 24);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(24, 24, 24);
            kryptonButton1.StatePressed.Back.ColorAngle = 130F;
            kryptonButton1.StatePressed.Border.Color1 = Color.SteelBlue;
            kryptonButton1.StatePressed.Border.Color2 = Color.LightSkyBlue;
            kryptonButton1.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(0, 0, 192);
            kryptonButton1.StateTracking.Back.Color2 = Color.Navy;
            kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateTracking.Border.Color2 = Color.Silver;
            kryptonButton1.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateTracking.Content.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Bold);
            kryptonButton1.TabIndex = 26;
            kryptonButton1.Values.Text = "Registrarse";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(384, 461);
            Controls.Add(kryptonButton1);
            Controls.Add(linkRegistrarse);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "FormLogin";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            TitleStyle = KryptonFormTitleStyle.Classic;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonLabel label1;
        private KryptonLabel label2;
        private KryptonTextBox textBox1;
        private KryptonTextBox textBox2;
        private KryptonButton button1;
		private PictureBox pictureBox1;
		private LinkLabel linkRegistrarse;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private KryptonButton kryptonButton1;
    }
}