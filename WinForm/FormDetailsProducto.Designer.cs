namespace WinForm
{
    partial class FormDetailsProducto
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Krypton.Toolkit.IconSpec iconSpec1 = new Krypton.Toolkit.IconSpec();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailsProducto));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Krypton.Toolkit.IconSpec iconSpec2 = new Krypton.Toolkit.IconSpec();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            crownDockPanel1 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            lblCategoria = new Label();
            lblCompra = new Label();
            datagridCompras = new Krypton.Toolkit.KryptonDataGridView();
            ColumnFecha = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ColumnCantidad = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            datagridVentas = new Krypton.Toolkit.KryptonDataGridView();
            ColumnFecha2 = new DataGridViewTextBoxColumn();
            ColumnCantidad2 = new DataGridViewTextBoxColumn();
            lblVentas = new Label();
            lblStock = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            chkHabilitado = new ReaLTaiizor.Controls.CrownCheckBox();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridVentas).BeginInit();
            SuspendLayout();
            // 
            // crownDockPanel1
            // 
            crownDockPanel1.BackColor = Color.FromArgb(60, 63, 65);
            crownDockPanel1.Location = new Point(-4, 174);
            crownDockPanel1.Name = "crownDockPanel1";
            crownDockPanel1.Size = new Size(385, 295);
            crownDockPanel1.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(60, 63, 65);
            lblCategoria.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            lblCategoria.ForeColor = SystemColors.ButtonFace;
            lblCategoria.Location = new Point(10, 186);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(101, 28);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria: ";
            // 
            // lblCompra
            // 
            lblCompra.AutoSize = true;
            lblCompra.BackColor = Color.FromArgb(60, 63, 65);
            lblCompra.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompra.ForeColor = SystemColors.ButtonFace;
            lblCompra.Location = new Point(47, 290);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(84, 26);
            lblCompra.TabIndex = 6;
            lblCompra.Text = "Compras";
            // 
            // datagridCompras
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Font = new Font("Wingdings", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonFace;
            datagridCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridCompras.BorderStyle = BorderStyle.None;
            datagridCompras.ColumnHeadersHeight = 20;
            datagridCompras.Columns.AddRange(new DataGridViewColumn[] { ColumnFecha, ColumnCantidad });
            datagridCompras.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            datagridCompras.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            datagridCompras.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            datagridCompras.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            datagridCompras.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            datagridCompras.Location = new Point(-4, 322);
            datagridCompras.Name = "datagridCompras";
            datagridCompras.Palette = kryptonCustomPaletteBase1;
            datagridCompras.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            datagridCompras.RowHeadersVisible = false;
            datagridCompras.Size = new Size(192, 147);
            datagridCompras.TabIndex = 7;
            // 
            // ColumnFecha
            // 
            ColumnFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Poppins SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace;
            ColumnFecha.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnFecha.HeaderText = "Fecha";
            iconSpec1.Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Left;
            iconSpec1.Icon = (Image)resources.GetObject("iconSpec1.Icon");
            ColumnFecha.IconSpecs.Add(iconSpec1);
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.Resizable = DataGridViewTriState.True;
            ColumnFecha.Width = 110;
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Wingdings", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ButtonFace;
            ColumnCantidad.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnCantidad.HeaderText = "Cantidad";
            iconSpec2.Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Left;
            iconSpec2.Icon = (Image)resources.GetObject("iconSpec2.Icon");
            ColumnCantidad.IconSpecs.Add(iconSpec2);
            ColumnCantidad.Name = "ColumnCantidad";
            ColumnCantidad.Resizable = DataGridViewTriState.True;
            ColumnCantidad.Width = 80;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedPressed.Back.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedPressed.Back.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedPressed.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedPressed.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Back.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Back.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Border.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Border.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCheckedTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Hide;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.ColorAngle = 45F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Border.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Border.Rounding = 3F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Content.ShortText.Color1 = Color.DarkGray;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateCommon.Content.ShortText.Color2 = Color.DarkGray;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Back.ColorAngle = 135F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Border.Color1 = Color.FromArgb(35, 45, 150);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Back.Color1 = Color.FromArgb(85, 90, 220);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Border.Color1 = Color.FromArgb(60, 65, 190);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Border.Color2 = Color.FromArgb(55, 55, 170);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonInputControl.StateTracking.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Switch50;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Content.ShortText.Color1 = Color.Silver;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateCommon.Content.ShortText.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Back.Color1 = Color.FromArgb(0, 0, 192);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Back.Color2 = Color.Navy;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Border.Color2 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonListItem.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ControlInner.Back.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ControlInner.Back.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ItemHighlight.Back.Color1 = Color.Lime;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ItemHighlight.Back.Color2 = Color.FromArgb(0, 192, 0);
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemHighlight.Back.Color1 = Color.Blue;
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemHighlight.Back.Color2 = Color.FromArgb(128, 128, 255);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.Color2 = Color.FromArgb(42, 42, 42);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.ColorAngle = 45F;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.ControlStyles.ControlCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.CueHintText.Color1 = Color.White;
            kryptonCustomPaletteBase1.CueHintText.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.DimGray;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Rounding = 25F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(48, 48, 56);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(51, 51, 60);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.ColorAngle = 135F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(46, 46, 56);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(56, 56, 56);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.ColorAngle = 45F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color1 = Color.DarkGray;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color2 = Color.DarkGray;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.ColorAngle = 45F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(60, 65, 190);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(65, 60, 195);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.ColorAngle = 135F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(60, 65, 195);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(70, 70, 195);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Rounding = 0F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Width = 1;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color2 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.ColorAngle = 135F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(192, 192, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderRow.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = Color.FromArgb(26, 26, 35);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = Color.FromArgb(26, 26, 35);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(50, 55, 150);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color2 = Color.FromArgb(45, 50, 140);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.ColorAngle = 135F;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(65, 75, 220);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(65, 75, 220);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = Color.FromArgb(65, 75, 220);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = Color.FromArgb(65, 75, 220);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 0F;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 0;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(14, 10, -1, -1);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = Color.FromArgb(180, 190, 200);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = Color.FromArgb(210, 220, 255);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.ColorAngle = 160F;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Poppins", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Back.Color1 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Back.Color2 = Color.FromArgb(36, 36, 36);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 66);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.Color2 = Color.FromArgb(50, 50, 56);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.GlassCenter;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Border.Rounding = 13F;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Color1 = Color.Silver;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.ColorAngle = 45F;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.SystemDefault;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Back.Color1 = Color.FromArgb(48, 48, 48);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Border.Color1 = Color.FromArgb(48, 48, 48);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Border.Color2 = Color.FromArgb(48, 48, 48);
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateContextTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = Color.FromArgb(0, 0, 64);
            kryptonCustomPaletteBase1.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color1 = Color.FromArgb(56, 56, 64);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.Color2 = Color.FromArgb(50, 50, 56);
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorAngle = 45F;
            kryptonCustomPaletteBase1.PanelStyles.PanelCustom1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // datagridVentas
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle4.Font = new Font("Wingdings", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ButtonFace;
            datagridVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            datagridVentas.BorderStyle = BorderStyle.None;
            datagridVentas.Columns.AddRange(new DataGridViewColumn[] { ColumnFecha2, ColumnCantidad2 });
            datagridVentas.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            datagridVentas.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            datagridVentas.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            datagridVentas.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            datagridVentas.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            datagridVentas.Location = new Point(188, 322);
            datagridVentas.Name = "datagridVentas";
            datagridVentas.Palette = kryptonCustomPaletteBase1;
            datagridVentas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            datagridVentas.RowHeadersVisible = false;
            datagridVentas.Size = new Size(192, 147);
            datagridVentas.TabIndex = 8;
            datagridVentas.CellContentClick += kryptonDataGridView2_CellContentClick;
            // 
            // ColumnFecha2
            // 
            ColumnFecha2.DataPropertyName = "Fecha";
            ColumnFecha2.HeaderText = "Fecha";
            ColumnFecha2.Name = "ColumnFecha2";
            ColumnFecha2.Width = 77;
            // 
            // ColumnCantidad2
            // 
            ColumnCantidad2.DataPropertyName = "Cantidad";
            ColumnCantidad2.HeaderText = "Cantidad";
            ColumnCantidad2.Name = "ColumnCantidad2";
            ColumnCantidad2.Width = 74;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.BackColor = Color.FromArgb(60, 63, 65);
            lblVentas.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = SystemColors.ButtonFace;
            lblVentas.Location = new Point(253, 290);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(66, 26);
            lblVentas.TabIndex = 9;
            lblVentas.Text = "Ventas";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.FromArgb(60, 63, 65);
            lblStock.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            lblStock.ForeColor = SystemColors.ButtonFace;
            lblStock.Location = new Point(10, 250);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(61, 28);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock:";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.Location = new Point(11, 34);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Back.Image = Properties.Resources.Arrow_back;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.Rounding = 8F;
            kryptonButton1.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.Size = new Size(58, 108);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonButton1.StateCommon.Back.Image = Properties.Resources.Arrow_back;
            kryptonButton1.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterRight;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 8F;
            kryptonButton1.StateCommon.Content.AdjacentGap = 1;
            kryptonButton1.StateCommon.Content.Image.ImageColorTo = Color.White;
            kryptonButton1.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateCommon.Content.ShortText.ColorAngle = 45F;
            kryptonButton1.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton1.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StatePressed.Back.Image = Properties.Resources.Arrow_backP;
            kryptonButton1.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton1.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            kryptonButton1.StatePressed.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StatePressed.Border.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StatePressed.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateTracking.Back.ColorAngle = 135F;
            kryptonButton1.StateTracking.Back.Image = Properties.Resources.Arrow_backS;
            kryptonButton1.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterRight;
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Border.Rounding = 8F;
            kryptonButton1.StateTracking.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateTracking.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton1.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            kryptonButton1.TabIndex = 12;
            kryptonButton1.ToolTipValues.Description = "";
            kryptonButton1.ToolTipValues.EnableToolTips = true;
            kryptonButton1.ToolTipValues.Heading = "Anterior";
            kryptonButton1.Values.Text = "";
            // 
            // chkHabilitado
            // 
            chkHabilitado.AutoSize = true;
            chkHabilitado.CheckAlign = ContentAlignment.MiddleRight;
            chkHabilitado.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            chkHabilitado.Location = new Point(10, 215);
            chkHabilitado.Name = "chkHabilitado";
            chkHabilitado.Size = new Size(114, 32);
            chkHabilitado.TabIndex = 13;
            chkHabilitado.Text = "Habilitado";
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(186, 322);
            kryptonBorderEdge1.Margin = new Padding(0);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Orientation = Orientation.Vertical;
            kryptonBorderEdge1.Size = new Size(1, 153);
            kryptonBorderEdge1.StateCommon.Color1 = Color.FromArgb(60, 65, 190);
            kryptonBorderEdge1.StateCommon.Color2 = Color.FromArgb(60, 65, 190);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton2.Location = new Point(317, 34);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.OverrideDefault.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton2.OverrideDefault.Back.Image = Properties.Resources.arrow_forward;
            kryptonButton2.OverrideDefault.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.OverrideDefault.Border.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton2.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.OverrideDefault.Border.Rounding = 8F;
            kryptonButton2.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton2.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.Size = new Size(58, 108);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            kryptonButton2.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonButton2.StateCommon.Back.Image = Properties.Resources.arrow_forward1;
            kryptonButton2.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton2.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            kryptonButton2.StateCommon.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateCommon.Border.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 8F;
            kryptonButton2.StateCommon.Content.AdjacentGap = 1;
            kryptonButton2.StateCommon.Content.Image.ImageColorTo = Color.White;
            kryptonButton2.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateCommon.Content.ShortText.ColorAngle = 45F;
            kryptonButton2.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton2.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonButton2.StatePressed.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StatePressed.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StatePressed.Back.Image = Properties.Resources.arrow_forwardP;
            kryptonButton2.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton2.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterRight;
            kryptonButton2.StatePressed.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StatePressed.Border.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton2.StatePressed.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StatePressed.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateTracking.Back.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateTracking.Back.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateTracking.Back.ColorAngle = 135F;
            kryptonButton2.StateTracking.Back.Image = Properties.Resources.arrow_forwardS;
            kryptonButton2.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            kryptonButton2.StateTracking.Border.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateTracking.Border.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateTracking.Border.Rounding = 8F;
            kryptonButton2.StateTracking.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateTracking.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            kryptonButton2.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            kryptonButton2.TabIndex = 14;
            kryptonButton2.ToolTipValues.Description = "";
            kryptonButton2.ToolTipValues.EnableToolTips = true;
            kryptonButton2.ToolTipValues.Heading = "Siguiente";
            kryptonButton2.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.ToolTip;
            kryptonButton2.Values.Text = "";
            // 
            // lblNombre
            // 
            lblNombre.AutoEllipsis = true;
            lblNombre.Font = new Font("Montserrat SemiBold", 22F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblNombre.ForeColor = SystemColors.ButtonFace;
            lblNombre.Location = new Point(54, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(269, 108);
            lblNombre.TabIndex = 16;
            lblNombre.Text = " ";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDetailsProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(383, 466);
            Controls.Add(lblNombre);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(chkHabilitado);
            Controls.Add(kryptonButton1);
            Controls.Add(lblStock);
            Controls.Add(lblVentas);
            Controls.Add(datagridVentas);
            Controls.Add(datagridCompras);
            Controls.Add(lblCompra);
            Controls.Add(lblCategoria);
            Controls.Add(crownDockPanel1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Name = "FormDetailsProducto";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalles del producto";
            TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Activated += FormDetailsProducto_Activated;
            ((System.ComponentModel.ISupportInitialize)datagridCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel1;
        private Label lblCategoria;
        private Label lblCompra;
        private Krypton.Toolkit.KryptonDataGridView datagridCompras;
        private Krypton.Toolkit.KryptonDataGridView datagridVentas;
        private Label lblVentas;
        private Label lblStock;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private ReaLTaiizor.Controls.CrownCheckBox chkHabilitado;
        private DataGridViewTextBoxColumn ColumnFecha2;
        private DataGridViewTextBoxColumn ColumnCantidad2;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn ColumnFecha;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn ColumnCantidad;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Label lblNombre;
    }
}