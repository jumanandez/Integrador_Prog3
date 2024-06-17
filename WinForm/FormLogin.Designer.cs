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
            lblusername = new KryptonLabel();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            lblpassword = new KryptonLabel();
            txtboxuser = new KryptonTextBox();
            txtboxpassw = new KryptonTextBox();
            btnlogin = new KryptonButton();
            logopictureBox = new PictureBox();
            linkRegistrarse = new LinkLabel();
            btnregister = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)logopictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusername.LabelStyle = LabelStyle.Custom1;
            lblusername.Location = new Point(82, 177);
            lblusername.Name = "lblusername";
            lblusername.Palette = kryptonCustomPaletteBase1;
            lblusername.PaletteMode = PaletteMode.Custom;
            lblusername.Size = new Size(69, 23);
            lblusername.TabIndex = 6;
            lblusername.TabStop = false;
            lblusername.Values.Text = "Usuario";
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
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.DrawFocus = InheritBool.False;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = Color.LightGray;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // lblpassword
            // 
            lblpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpassword.LabelStyle = LabelStyle.Custom1;
            lblpassword.Location = new Point(82, 261);
            lblpassword.Name = "lblpassword";
            lblpassword.Palette = kryptonCustomPaletteBase1;
            lblpassword.PaletteMode = PaletteMode.Custom;
            lblpassword.Size = new Size(97, 23);
            lblpassword.TabIndex = 7;
            lblpassword.TabStop = false;
            lblpassword.Values.Text = "Contraseña";
            // 
            // txtboxuser
            // 
            txtboxuser.AlwaysActive = false;
            txtboxuser.CueHint.Color1 = Color.Gray;
            txtboxuser.CueHint.CueHintText = "Ingrese su usuario";
            txtboxuser.CueHint.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtboxuser.Location = new Point(74, 207);
            txtboxuser.Name = "txtboxuser";
            txtboxuser.Size = new Size(249, 31);
            txtboxuser.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            txtboxuser.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            txtboxuser.StateCommon.Border.Color2 = Color.Gray;
            txtboxuser.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtboxuser.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtboxuser.StateCommon.Border.Rounding = 18F;
            txtboxuser.StateCommon.Content.Color1 = Color.Gainsboro;
            txtboxuser.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxuser.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtboxuser.TabIndex = 0;
            txtboxuser.TextChanged += textBox1_TextChanged;
            txtboxuser.Click += textBox1_Click;
            txtboxuser.KeyPress += textBox1_KeyPress;
            // 
            // txtboxpassw
            // 
            txtboxpassw.CueHint.Color1 = Color.Gray;
            txtboxpassw.CueHint.CueHintText = "Ingrese una contraseña";
            txtboxpassw.CueHint.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtboxpassw.Location = new Point(74, 291);
            txtboxpassw.Name = "txtboxpassw";
            txtboxpassw.Size = new Size(249, 31);
            txtboxpassw.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            txtboxpassw.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            txtboxpassw.StateCommon.Border.Color2 = Color.Gray;
            txtboxpassw.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtboxpassw.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtboxpassw.StateCommon.Border.Rounding = 16F;
            txtboxpassw.StateCommon.Border.Width = 2;
            txtboxpassw.StateCommon.Content.Color1 = Color.Gainsboro;
            txtboxpassw.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxpassw.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtboxpassw.TabIndex = 1;
            txtboxpassw.Click += textBox2_Click;
            txtboxpassw.KeyPress += textBox2_KeyPress;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(77, 350);
            btnlogin.Name = "btnlogin";
            btnlogin.OverrideDefault.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnlogin.OverrideDefault.Back.Color2 = Color.Navy;
            btnlogin.OverrideDefault.Back.ColorAngle = 45F;
            btnlogin.OverrideDefault.Border.Color1 = Color.Navy;
            btnlogin.OverrideDefault.Border.Color2 = Color.Gray;
            btnlogin.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnlogin.OverrideDefault.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnlogin.OverrideDefault.Border.ImageAlign = PaletteRectangleAlign.Local;
            btnlogin.OverrideDefault.Border.Rounding = 18F;
            btnlogin.Size = new Size(120, 42);
            btnlogin.StateCommon.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnlogin.StateCommon.Back.Color2 = Color.Navy;
            btnlogin.StateCommon.Back.ColorAngle = 45F;
            btnlogin.StateCommon.Border.Color1 = Color.Navy;
            btnlogin.StateCommon.Border.Color2 = Color.Gray;
            btnlogin.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnlogin.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnlogin.StateCommon.Border.ImageAlign = PaletteRectangleAlign.Local;
            btnlogin.StateCommon.Border.Rounding = 18F;
            btnlogin.StateCommon.Content.ShortText.Color1 = Color.White;
            btnlogin.StateCommon.Content.ShortText.Color2 = Color.White;
            btnlogin.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnlogin.StateDisabled.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnlogin.StateDisabled.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnlogin.StateDisabled.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnlogin.StateDisabled.Border.Color2 = Color.Gray;
            btnlogin.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnlogin.StateDisabled.Content.ShortText.Color1 = Color.Silver;
            btnlogin.StateDisabled.Content.ShortText.Color2 = Color.Silver;
            btnlogin.StatePressed.Back.Color1 = Color.FromArgb(0, 0, 64);
            btnlogin.StatePressed.Back.Color2 = Color.FromArgb(24, 24, 92);
            btnlogin.StatePressed.Back.ColorAngle = 45F;
            btnlogin.StatePressed.Border.Color1 = Color.FromArgb(224, 224, 224);
            btnlogin.StatePressed.Border.Color2 = Color.Gray;
            btnlogin.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnlogin.StateTracking.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnlogin.StateTracking.Back.Color2 = Color.Navy;
            btnlogin.StateTracking.Back.ColorAngle = 135F;
            btnlogin.StateTracking.Border.Color1 = Color.White;
            btnlogin.StateTracking.Border.Color2 = Color.FromArgb(224, 224, 224);
            btnlogin.StateTracking.Border.ColorAngle = 45F;
            btnlogin.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnlogin.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnlogin.StateTracking.Border.Rounding = 18F;
            btnlogin.StateTracking.Content.ShortText.Color1 = Color.Gainsboro;
            btnlogin.StateTracking.Content.ShortText.Color2 = Color.Gainsboro;
            btnlogin.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.TabIndex = 3;
            btnlogin.Values.Text = "Iniciar Sesion";
            btnlogin.Click += button1_Click;
            // 
            // logopictureBox
            // 
            logopictureBox.Image = Properties.Resources.logo;
            logopictureBox.Location = new Point(107, 50);
            logopictureBox.Name = "logopictureBox";
            logopictureBox.Size = new Size(173, 110);
            logopictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            logopictureBox.TabIndex = 23;
            logopictureBox.TabStop = false;
            // 
            // linkRegistrarse
            // 
            linkRegistrarse.AutoSize = true;
            linkRegistrarse.LinkColor = Color.RoyalBlue;
            linkRegistrarse.Location = new Point(79, 411);
            linkRegistrarse.Name = "linkRegistrarse";
            linkRegistrarse.Size = new Size(113, 15);
            linkRegistrarse.TabIndex = 5;
            linkRegistrarse.TabStop = true;
            linkRegistrarse.Text = "Cambiar contraseña";
            linkRegistrarse.LinkClicked += linkCambioContraseña_LinkClicked;
            // 
            // btnregister
            // 
            btnregister.Location = new Point(203, 350);
            btnregister.Name = "btnregister";
            btnregister.OverrideDefault.Back.Color1 = Color.FromArgb(32, 32, 32);
            btnregister.OverrideDefault.Back.Color2 = Color.FromArgb(32, 32, 32);
            btnregister.OverrideDefault.Back.ColorAngle = 45F;
            btnregister.OverrideDefault.Border.Color1 = Color.RoyalBlue;
            btnregister.OverrideDefault.Border.Color2 = Color.CornflowerBlue;
            btnregister.OverrideDefault.Border.ColorAngle = 45F;
            btnregister.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnregister.OverrideDefault.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnregister.OverrideDefault.Border.Rounding = 18F;
            btnregister.OverrideDefault.Border.Width = 1;
            btnregister.OverrideDefault.Content.ShortText.Color1 = Color.Gainsboro;
            btnregister.OverrideDefault.Content.ShortText.Color2 = Color.Gainsboro;
            btnregister.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregister.PaletteMode = PaletteMode.ProfessionalSystem;
            btnregister.Size = new Size(120, 42);
            btnregister.StateCommon.Back.Color1 = Color.FromArgb(32, 32, 32);
            btnregister.StateCommon.Back.Color2 = Color.FromArgb(32, 32, 32);
            btnregister.StateCommon.Back.ColorAngle = 45F;
            btnregister.StateCommon.Border.Color1 = Color.RoyalBlue;
            btnregister.StateCommon.Border.Color2 = Color.CornflowerBlue;
            btnregister.StateCommon.Border.ColorAngle = 45F;
            btnregister.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnregister.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            btnregister.StateCommon.Border.Rounding = 18F;
            btnregister.StateCommon.Border.Width = 1;
            btnregister.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            btnregister.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            btnregister.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregister.StatePressed.Back.Color1 = Color.FromArgb(24, 24, 24);
            btnregister.StatePressed.Back.Color2 = Color.FromArgb(24, 24, 24);
            btnregister.StatePressed.Back.ColorAngle = 130F;
            btnregister.StatePressed.Border.Color1 = Color.SteelBlue;
            btnregister.StatePressed.Border.Color2 = Color.LightSkyBlue;
            btnregister.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnregister.StateTracking.Back.Color1 = Color.FromArgb(0, 0, 192);
            btnregister.StateTracking.Back.Color2 = Color.Navy;
            btnregister.StateTracking.Back.ColorAngle = 45F;
            btnregister.StateTracking.Border.Color1 = Color.FromArgb(224, 224, 224);
            btnregister.StateTracking.Border.Color2 = Color.Silver;
            btnregister.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnregister.StateTracking.Content.ShortText.Color1 = Color.White;
            btnregister.StateTracking.Content.ShortText.Color2 = Color.White;
            btnregister.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnregister.TabIndex = 4;
            btnregister.Values.Text = "Registrarse";
            btnregister.Click += btnRegistrarse_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(384, 461);
            Controls.Add(btnregister);
            Controls.Add(linkRegistrarse);
            Controls.Add(logopictureBox);
            Controls.Add(btnlogin);
            Controls.Add(txtboxpassw);
            Controls.Add(txtboxuser);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "FormLogin";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            TitleStyle = KryptonFormTitleStyle.Classic;
            ((System.ComponentModel.ISupportInitialize)logopictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonLabel lblusername;
        private KryptonLabel lblpassword;
        private KryptonTextBox txtboxuser;
        private KryptonTextBox txtboxpassw;
        private KryptonButton btnlogin;
		    private PictureBox logopictureBox;
		    private LinkLabel linkRegistrarse;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private KryptonButton btnregister;
    }
}