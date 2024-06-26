﻿using Krypton.Toolkit;

namespace WinForm
{
    partial class FormAddModif
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
            btnCargarProducto = new KryptonButton();
            lblCategoria = new Label();
            lblNombreProducto = new Label();
            txtNombreProducto = new KryptonTextBox();
            cmbBoxCategorias = new KryptonComboBox();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            BTNCancelar = new KryptonButton();
            checkHabilitado = new KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)cmbBoxCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Anchor = AnchorStyles.Bottom;
            btnCargarProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarProducto.Location = new Point(12, 265);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.OverrideDefault.Back.Color1 = Color.FromArgb(60, 65, 190);
            btnCargarProducto.OverrideDefault.Back.Color2 = Color.FromArgb(55, 55, 170);
            btnCargarProducto.OverrideDefault.Back.ColorAngle = 45F;
            btnCargarProducto.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Dashed;
            btnCargarProducto.OverrideDefault.Border.Color1 = Color.FromArgb(60, 65, 190);
            btnCargarProducto.OverrideDefault.Border.Color2 = Color.FromArgb(60, 60, 175);
            btnCargarProducto.OverrideDefault.Border.ColorAngle = 45F;
            btnCargarProducto.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnCargarProducto.OverrideDefault.Border.Rounding = 8F;
            btnCargarProducto.OverrideDefault.Content.DrawFocus = InheritBool.False;
            btnCargarProducto.Size = new Size(108, 29);
            btnCargarProducto.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            btnCargarProducto.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            btnCargarProducto.StateCommon.Back.ColorAngle = 45F;
            btnCargarProducto.StateCommon.Back.ColorStyle = PaletteColorStyle.Dashed;
            btnCargarProducto.StateCommon.Back.Image = Properties.Resources.guardar1;
            btnCargarProducto.StateCommon.Back.ImageAlign = PaletteRectangleAlign.Local;
            btnCargarProducto.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterLeft;
            btnCargarProducto.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            btnCargarProducto.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            btnCargarProducto.StateCommon.Border.ColorAngle = 45F;
            btnCargarProducto.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnCargarProducto.StateCommon.Border.Rounding = 8F;
            btnCargarProducto.StateCommon.Content.AdjacentGap = 1;
            btnCargarProducto.StateCommon.Content.Image.ImageColorTo = Color.White;
            btnCargarProducto.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            btnCargarProducto.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            btnCargarProducto.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            btnCargarProducto.StateCommon.Content.ShortText.ColorAngle = 45F;
            btnCargarProducto.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Solid;
            btnCargarProducto.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarProducto.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            btnCargarProducto.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            btnCargarProducto.StateTracking.Back.Color1 = Color.FromArgb(85, 90, 220);
            btnCargarProducto.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            btnCargarProducto.StateTracking.Back.ColorAngle = 135F;
            btnCargarProducto.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnCargarProducto.StateTracking.Border.Rounding = 8F;
            btnCargarProducto.StateTracking.Content.ShortText.Color1 = Color.White;
            btnCargarProducto.StateTracking.Content.ShortText.Color2 = Color.White;
            btnCargarProducto.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnCargarProducto.TabIndex = 4;
            btnCargarProducto.Values.Text = "Guardar";
            btnCargarProducto.Click += btnCargarProducto_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 11F);
            lblCategoria.Location = new Point(15, 54);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 11F);
            lblNombreProducto.Location = new Point(15, 132);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(64, 20);
            lblNombreProducto.TabIndex = 7;
            lblNombreProducto.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreProducto.Location = new Point(14, 156);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(222, 31);
            txtNombreProducto.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            txtNombreProducto.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            txtNombreProducto.StateCommon.Border.Color2 = Color.Gray;
            txtNombreProducto.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtNombreProducto.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            txtNombreProducto.StateCommon.Border.Rounding = 18F;
            txtNombreProducto.StateCommon.Content.Color1 = Color.Silver;
            txtNombreProducto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProducto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNombreProducto.TabIndex = 2;
            // 
            // cmbBoxCategorias
            // 
            cmbBoxCategorias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBoxCategorias.DropBackStyle = PaletteBackStyle.ControlCustom1;
            cmbBoxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCategorias.DropDownWidth = 222;
            cmbBoxCategorias.FormattingEnabled = true;
            cmbBoxCategorias.IntegralHeight = false;
            cmbBoxCategorias.Location = new Point(14, 78);
            cmbBoxCategorias.Name = "cmbBoxCategorias";
            cmbBoxCategorias.Palette = kryptonCustomPaletteBase1;
            cmbBoxCategorias.PaletteMode = PaletteMode.Custom;
            cmbBoxCategorias.Size = new Size(222, 32);
            cmbBoxCategorias.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbBoxCategorias.StateCommon.Item.Border.Color1 = Color.Navy;
            cmbBoxCategorias.StateCommon.Item.Border.Color2 = Color.FromArgb(0, 0, 64);
            cmbBoxCategorias.StateCommon.Item.Border.ColorAngle = 135F;
            cmbBoxCategorias.StateCommon.Item.Border.ColorStyle = PaletteColorStyle.LinearShadow;
            cmbBoxCategorias.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbBoxCategorias.StateCommon.Item.Content.DrawFocus = InheritBool.False;
            cmbBoxCategorias.TabIndex = 1;
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
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedPressed.Back.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedPressed.Back.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedPressed.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedPressed.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Back.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Back.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Border.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Border.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Content.DrawFocus = InheritBool.False;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Content.ShortText.Prefix = PaletteTextHotkeyPrefix.Hide;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.ColorAlign = PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.ColorAngle = 45F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.ColorStyle = PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Border.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Border.Rounding = 3F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Content.ShortText.Color1 = Color.DarkGray;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Content.ShortText.Color2 = Color.DarkGray;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Back.ColorAngle = 135F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Back.ColorStyle = PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Border.Color1 = Color.FromArgb(35, 45, 150);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Back.Color1 = Color.FromArgb(85, 90, 220);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Border.Color1 = Color.FromArgb(60, 65, 190);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Border.Color2 = Color.FromArgb(55, 55, 170);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.ColorStyle = PaletteColorStyle.Switch50;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Content.ShortText.Color1 = Color.Silver;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Content.ShortText.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Back.Color1 = Color.FromArgb(0, 0, 192);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Back.Color2 = Color.Navy;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Border.Color2 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Content.DrawFocus = InheritBool.False;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.Common.StateCommon.Border.Color1 = Color.FromArgb(128, 64, 0);
            kryptonCustomPaletteBase1.Common.StateCommon.Border.Color2 = Color.FromArgb(128, 64, 64);
            kryptonCustomPaletteBase1.Common.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ControlInner.Back.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ControlInner.Back.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ItemHighlight.Back.Color1 = Color.Lime;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ItemHighlight.Back.Color2 = Color.FromArgb(0, 192, 0);
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemHighlight.Back.Color1 = Color.Fuchsia;
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemHighlight.Back.Color2 = Color.FromArgb(192, 0, 192);
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemHighlight.Border.Color1 = Color.FromArgb(255, 255, 192);
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemHighlight.Border.Color2 = Color.FromArgb(255, 255, 192);
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemHighlight.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemSplit.Back.Color1 = Color.Green;
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemSplit.Back.Color2 = Color.Green;
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemSplit.Border.Color1 = Color.FromArgb(255, 255, 192);
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemSplit.Border.Color2 = Color.FromArgb(255, 255, 192);
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemSplit.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.Color2 = Color.FromArgb(42, 42, 42);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.ColorAngle = 45F;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.ColorStyle = PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(26, 26, 28);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(26, 26, 28);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Draw = InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Draw = InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.HighQuality;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(65, 75, 220);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(65, 75, 220);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Draw = InheritBool.False;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = Color.FromArgb(65, 75, 220);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = Color.FromArgb(65, 75, 220);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Draw = InheritBool.False;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 0F;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 0;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(35, 15, -1, -1);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = Color.Silver;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Hint = PaletteTextHint.AntiAlias;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Back.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 66);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.Color2 = Color.FromArgb(50, 50, 56);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.ColorAlign = PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.ColorStyle = PaletteColorStyle.GlassCenter;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.Rounding = 13F;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Color1 = Color.Silver;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.ColorAlign = PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.ColorAngle = 45F;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Hint = PaletteTextHint.SystemDefault;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Back.Color1 = Color.FromArgb(48, 48, 48);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Border.Color1 = Color.FromArgb(48, 48, 48);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Border.Color2 = Color.FromArgb(48, 48, 48);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.DrawFocus = InheritBool.False;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = Color.FromArgb(0, 0, 64);
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color1 = Color.FromArgb(56, 56, 64);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color2 = Color.FromArgb(50, 50, 56);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorAlign = PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorAngle = 45F;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorStyle = PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // BTNCancelar
            // 
            BTNCancelar.Anchor = AnchorStyles.Bottom;
            BTNCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNCancelar.Location = new Point(130, 265);
            BTNCancelar.Name = "BTNCancelar";
            BTNCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNCancelar.OverrideDefault.Back.ColorAngle = 45F;
            BTNCancelar.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Dashed;
            BTNCancelar.OverrideDefault.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNCancelar.OverrideDefault.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNCancelar.OverrideDefault.Border.ColorAngle = 45F;
            BTNCancelar.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNCancelar.OverrideDefault.Border.Rounding = 8F;
            BTNCancelar.OverrideDefault.Content.DrawFocus = InheritBool.False;
            BTNCancelar.Size = new Size(108, 29);
            BTNCancelar.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNCancelar.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNCancelar.StateCommon.Back.ColorAngle = 45F;
            BTNCancelar.StateCommon.Back.ColorStyle = PaletteColorStyle.Dashed;
            BTNCancelar.StateCommon.Back.Image = Properties.Resources.close_24dp_FILL0_wght400_GRAD0_opsz24;
            BTNCancelar.StateCommon.Back.ImageAlign = PaletteRectangleAlign.Local;
            BTNCancelar.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterLeft;
            BTNCancelar.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNCancelar.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNCancelar.StateCommon.Border.ColorAngle = 45F;
            BTNCancelar.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNCancelar.StateCommon.Border.Rounding = 8F;
            BTNCancelar.StateCommon.Content.AdjacentGap = 1;
            BTNCancelar.StateCommon.Content.Image.ImageColorTo = Color.White;
            BTNCancelar.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            BTNCancelar.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            BTNCancelar.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            BTNCancelar.StateCommon.Content.ShortText.ColorAngle = 45F;
            BTNCancelar.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Solid;
            BTNCancelar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNCancelar.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            BTNCancelar.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            BTNCancelar.StateTracking.Back.Color1 = Color.FromArgb(85, 90, 220);
            BTNCancelar.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            BTNCancelar.StateTracking.Back.ColorAngle = 135F;
            BTNCancelar.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNCancelar.StateTracking.Border.Rounding = 8F;
            BTNCancelar.StateTracking.Content.ShortText.Color1 = Color.White;
            BTNCancelar.StateTracking.Content.ShortText.Color2 = Color.White;
            BTNCancelar.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            BTNCancelar.TabIndex = 5;
            BTNCancelar.Values.Text = "Cancelar";
            BTNCancelar.Click += BTNCancelar_Click;
            // 
            // checkHabilitado
            // 
            checkHabilitado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkHabilitado.Images.CheckedDisabled = Properties.Resources.disabled_checked;
            checkHabilitado.Images.CheckedNormal = Properties.Resources.check_box_24dp_FILL0_wght400_GRAD0_opsz24;
            checkHabilitado.Images.CheckedPressed = Properties.Resources.check_box_24dp_FILL0_wght400_GRAD0_opsz24;
            checkHabilitado.Images.CheckedTracking = Properties.Resources.checked_Traced;
            checkHabilitado.Images.Common = Properties.Resources.check_box_outline_blank_24dp_FILL0_wght400_GRAD0_opsz24;
            checkHabilitado.Images.IndeterminateDisabled = Properties.Resources.disabled_unchecked;
            checkHabilitado.Images.IndeterminateNormal = Properties.Resources.check_box_outline_blank_24dp_FILL0_wght400_GRAD0_opsz24;
            checkHabilitado.Images.IndeterminatePressed = Properties.Resources.check_box_outline_blank_24dp_FILL0_wght400_GRAD0_opsz24;
            checkHabilitado.Images.IndeterminateTracking = Properties.Resources.unchecked_trace;
            checkHabilitado.Images.UncheckedDisabled = Properties.Resources.disabled_unchecked;
            checkHabilitado.Images.UncheckedNormal = Properties.Resources.check_box_outline_blank_24dp_FILL0_wght400_GRAD0_opsz24;
            checkHabilitado.Images.UncheckedPressed = Properties.Resources.check_box_outline_blank_24dp_FILL0_wght400_GRAD0_opsz24;
            checkHabilitado.Images.UncheckedTracking = Properties.Resources.unchecked_trace;
            checkHabilitado.Location = new Point(77, 219);
            checkHabilitado.Name = "checkHabilitado";
            checkHabilitado.Size = new Size(100, 24);
            checkHabilitado.StateCommon.ShortText.Color1 = Color.Silver;
            checkHabilitado.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            checkHabilitado.StateCommon.ShortText.ColorAngle = 45F;
            checkHabilitado.StateCommon.ShortText.ColorStyle = PaletteColorStyle.HalfCut;
            checkHabilitado.StateCommon.ShortText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkHabilitado.StateDisabled.ShortText.Color1 = Color.Gray;
            checkHabilitado.StateDisabled.ShortText.Color2 = Color.Gray;
            checkHabilitado.TabIndex = 3;
            checkHabilitado.Values.Text = "Habilitado";
            // 
            // FormAddModif
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(260, 306);
            Controls.Add(checkHabilitado);
            Controls.Add(BTNCancelar);
            Controls.Add(btnCargarProducto);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(cmbBoxCategorias);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            FormTitleAlign = PaletteRelativeAlign.Inherit;
            Name = "FormAddModif";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)cmbBoxCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonButton btnCargarProducto;
        private Label lblCategoria;
        private Label lblNombreProducto;
        private KryptonTextBox txtNombreProducto;
        private KryptonComboBox cmbBoxCategorias;
        private KryptonButton BTNCancelar;
        private KryptonCheckBox checkHabilitado;
        private KryptonCustomPaletteBase kryptonCustomPaletteBase1;
    }
}