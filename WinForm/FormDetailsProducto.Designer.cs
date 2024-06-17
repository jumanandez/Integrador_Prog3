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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            crownDockPanel1 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            lblCategoria = new Label();
            lblCompra = new Label();
            datagridCompra = new Krypton.Toolkit.KryptonDataGridView();
            ColumnFecha = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ColumnCantidad = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            datagridVentas = new Krypton.Toolkit.KryptonDataGridView();
            ColumnFecha2 = new DataGridViewTextBoxColumn();
            ColumnCantidad2 = new DataGridViewTextBoxColumn();
            lblVentas = new Label();
            lblStock = new Label();
            btnAnterior = new Krypton.Toolkit.KryptonButton();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            btnSiguiente = new Krypton.Toolkit.KryptonButton();
            lblNombre = new Label();
            label1 = new Label();
            switchHabilitado = new ReaLTaiizor.Controls.ParrotSwitch();
            BTNmodif = new Krypton.Toolkit.KryptonButton();
            BTNdelete = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)datagridCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridVentas).BeginInit();
            SuspendLayout();
            // 
            // crownDockPanel1
            // 
            crownDockPanel1.BackColor = Color.FromArgb(60, 63, 65);
            crownDockPanel1.Location = new Point(-4, 174);
            crownDockPanel1.Name = "crownDockPanel1";
            crownDockPanel1.Size = new Size(452, 295);
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
            lblCompra.Location = new Point(68, 290);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(84, 26);
            lblCompra.TabIndex = 6;
            lblCompra.Text = "Compras";
            // 
            // datagridCompra
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Font = new Font("Poppins SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonFace;
            datagridCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridCompra.BorderStyle = BorderStyle.None;
            datagridCompra.ColumnHeadersHeight = 20;
            datagridCompra.Columns.AddRange(new DataGridViewColumn[] { ColumnFecha, ColumnCantidad });
            datagridCompra.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            datagridCompra.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            datagridCompra.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            datagridCompra.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            datagridCompra.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            datagridCompra.Location = new Point(-4, 322);
            datagridCompra.Name = "datagridCompra";
            datagridCompra.Palette = kryptonCustomPaletteBase1;
            datagridCompra.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            datagridCompra.RowHeadersVisible = false;
            datagridCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridCompra.ShowCellToolTips = false;
            datagridCompra.Size = new Size(226, 147);
            datagridCompra.StateCommon.Background.Color1 = Color.FromArgb(30, 30, 32);
            datagridCompra.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            datagridCompra.TabIndex = 7;
            datagridCompra.ToolTipShadow = false;
            datagridCompra.CellMouseEnter += datagridCompras_CellMouseEnter;
            // 
            // ColumnFecha
            // 
            ColumnFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace;
            ColumnFecha.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnFecha.HeaderText = "Fecha";
            iconSpec1.Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Left;
            iconSpec1.Icon = (Image)resources.GetObject("iconSpec1.Icon");
            ColumnFecha.IconSpecs.Add(iconSpec1);
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.ReadOnly = true;
            ColumnFecha.Resizable = DataGridViewTriState.True;
            ColumnFecha.Width = 125;
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Poppins SemiBold", 13F, FontStyle.Bold, GraphicsUnit.World);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ButtonFace;
            ColumnCantidad.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnCantidad.HeaderText = "Cantidad";
            iconSpec2.Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Left;
            iconSpec2.Icon = (Image)resources.GetObject("iconSpec2.Icon");
            ColumnCantidad.IconSpecs.Add(iconSpec2);
            ColumnCantidad.Name = "ColumnCantidad";
            ColumnCantidad.ReadOnly = true;
            ColumnCantidad.Width = 100;
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Font = new Font("Nirmala UI", 11F, FontStyle.Bold);
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
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            dataGridViewCellStyle4.Font = new Font("Poppins SemiBold", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ButtonFace;
            datagridVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            datagridVentas.BorderStyle = BorderStyle.None;
            datagridVentas.ColumnHeadersHeight = 20;
            datagridVentas.Columns.AddRange(new DataGridViewColumn[] { ColumnFecha2, ColumnCantidad2 });
            datagridVentas.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Custom1;
            datagridVentas.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            datagridVentas.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Custom1;
            datagridVentas.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Custom1;
            datagridVentas.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Custom1;
            datagridVentas.Location = new Point(221, 322);
            datagridVentas.Name = "datagridVentas";
            datagridVentas.Palette = kryptonCustomPaletteBase1;
            datagridVentas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            datagridVentas.RowHeadersVisible = false;
            datagridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridVentas.ShowCellToolTips = false;
            datagridVentas.Size = new Size(226, 147);
            datagridVentas.StateCommon.Background.Color1 = Color.FromArgb(30, 30, 32);
            datagridVentas.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            datagridVentas.TabIndex = 8;
            datagridVentas.ToolTipShadow = false;
            datagridVentas.CellContentClick += kryptonDataGridView2_CellContentClick;
            datagridVentas.CellMouseEnter += datagridVentas_CellMouseEnter;
            // 
            // ColumnFecha2
            // 
            ColumnFecha2.DataPropertyName = "Fecha";
            dataGridViewCellStyle5.Font = new Font("Poppins SemiBold", 13F, FontStyle.Bold, GraphicsUnit.World, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ButtonFace;
            ColumnFecha2.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnFecha2.HeaderText = "Fecha";
            ColumnFecha2.Name = "ColumnFecha2";
            ColumnFecha2.ReadOnly = true;
            ColumnFecha2.ToolTipText = "null";
            ColumnFecha2.Width = 125;
            // 
            // ColumnCantidad2
            // 
            ColumnCantidad2.DataPropertyName = "Cantidad";
            ColumnCantidad2.HeaderText = "Cantidad";
            ColumnCantidad2.Name = "ColumnCantidad2";
            ColumnCantidad2.ReadOnly = true;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.BackColor = Color.FromArgb(60, 63, 65);
            lblVentas.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = SystemColors.ButtonFace;
            lblVentas.Location = new Point(301, 290);
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
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAnterior.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(11, 34);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.OverrideDefault.Back.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.OverrideDefault.Back.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.OverrideDefault.Back.ColorAngle = 45F;
            btnAnterior.OverrideDefault.Back.Image = Properties.Resources.Arrow_back;
            btnAnterior.OverrideDefault.Border.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.OverrideDefault.Border.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.OverrideDefault.Border.ColorAngle = 45F;
            btnAnterior.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAnterior.OverrideDefault.Border.Rounding = 8F;
            btnAnterior.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnAnterior.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.Size = new Size(58, 108);
            btnAnterior.StateCommon.Back.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateCommon.Back.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateCommon.Back.ColorAngle = 45F;
            btnAnterior.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            btnAnterior.StateCommon.Back.Image = Properties.Resources.Arrow_back;
            btnAnterior.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnAnterior.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterRight;
            btnAnterior.StateCommon.Border.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateCommon.Border.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateCommon.Border.ColorAngle = 45F;
            btnAnterior.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAnterior.StateCommon.Border.Rounding = 8F;
            btnAnterior.StateCommon.Content.AdjacentGap = 1;
            btnAnterior.StateCommon.Content.Image.ImageColorTo = Color.White;
            btnAnterior.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            btnAnterior.StateCommon.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateCommon.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateCommon.Content.ShortText.ColorAngle = 45F;
            btnAnterior.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnAnterior.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnAnterior.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAnterior.StatePressed.Back.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.StatePressed.Back.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.StatePressed.Back.Image = Properties.Resources.Arrow_backP;
            btnAnterior.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnAnterior.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            btnAnterior.StatePressed.Border.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.StatePressed.Border.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAnterior.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnAnterior.StatePressed.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.StatePressed.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateTracking.Back.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateTracking.Back.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateTracking.Back.ColorAngle = 135F;
            btnAnterior.StateTracking.Back.Image = Properties.Resources.Arrow_backS;
            btnAnterior.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterRight;
            btnAnterior.StateTracking.Border.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateTracking.Border.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAnterior.StateTracking.Border.Rounding = 8F;
            btnAnterior.StateTracking.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateTracking.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            btnAnterior.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnAnterior.TabIndex = 12;
            btnAnterior.ToolTipValues.Description = "Anterior";
            btnAnterior.ToolTipValues.EnableToolTips = true;
            btnAnterior.ToolTipValues.Heading = "";
            btnAnterior.Values.Text = "";
            btnAnterior.Click += btnAnterior_Click;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(221, 322);
            kryptonBorderEdge1.Margin = new Padding(0);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Orientation = Orientation.Vertical;
            kryptonBorderEdge1.Size = new Size(1, 153);
            kryptonBorderEdge1.StateCommon.Color1 = Color.FromArgb(60, 65, 190);
            kryptonBorderEdge1.StateCommon.Color2 = Color.FromArgb(60, 65, 190);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSiguiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(375, 34);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.OverrideDefault.Back.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.OverrideDefault.Back.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.OverrideDefault.Back.ColorAngle = 45F;
            btnSiguiente.OverrideDefault.Back.Image = Properties.Resources.arrow_forward;
            btnSiguiente.OverrideDefault.Border.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.OverrideDefault.Border.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.OverrideDefault.Border.ColorAngle = 45F;
            btnSiguiente.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSiguiente.OverrideDefault.Border.Rounding = 8F;
            btnSiguiente.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnSiguiente.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.Size = new Size(58, 108);
            btnSiguiente.StateCommon.Back.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateCommon.Back.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateCommon.Back.ColorAngle = 45F;
            btnSiguiente.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            btnSiguiente.StateCommon.Back.Image = Properties.Resources.arrow_forward1;
            btnSiguiente.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnSiguiente.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            btnSiguiente.StateCommon.Border.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateCommon.Border.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateCommon.Border.ColorAngle = 45F;
            btnSiguiente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSiguiente.StateCommon.Border.Rounding = 8F;
            btnSiguiente.StateCommon.Content.AdjacentGap = 1;
            btnSiguiente.StateCommon.Content.Image.ImageColorTo = Color.White;
            btnSiguiente.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            btnSiguiente.StateCommon.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateCommon.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateCommon.Content.ShortText.ColorAngle = 45F;
            btnSiguiente.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSiguiente.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnSiguiente.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnSiguiente.StatePressed.Back.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StatePressed.Back.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StatePressed.Back.Image = Properties.Resources.arrow_forwardP;
            btnSiguiente.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnSiguiente.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterRight;
            btnSiguiente.StatePressed.Border.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StatePressed.Border.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSiguiente.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnSiguiente.StatePressed.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StatePressed.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateTracking.Back.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateTracking.Back.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateTracking.Back.ColorAngle = 135F;
            btnSiguiente.StateTracking.Back.Image = Properties.Resources.arrow_forwardS;
            btnSiguiente.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            btnSiguiente.StateTracking.Border.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateTracking.Border.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSiguiente.StateTracking.Border.Rounding = 8F;
            btnSiguiente.StateTracking.Content.ShortText.Color1 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateTracking.Content.ShortText.Color2 = Color.FromArgb(30, 30, 30);
            btnSiguiente.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnSiguiente.TabIndex = 14;
            btnSiguiente.ToolTipValues.Description = "";
            btnSiguiente.ToolTipValues.EnableToolTips = true;
            btnSiguiente.ToolTipValues.Heading = "Siguiente";
            btnSiguiente.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.ToolTip;
            btnSiguiente.Values.Text = "";
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoEllipsis = true;
            lblNombre.Font = new Font("Montserrat SemiBold", 22F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblNombre.ForeColor = SystemColors.ButtonFace;
            lblNombre.Location = new Point(85, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(269, 108);
            lblNombre.TabIndex = 16;
            lblNombre.Text = " ";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(60, 63, 65);
            label1.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(11, 216);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 19;
            label1.Text = "Habilitado";
            // 
            // switchHabilitado
            // 
            switchHabilitado.BackColor = Color.FromArgb(60, 63, 65);
            switchHabilitado.HandleOffColor = Color.FromArgb(255, 255, 255);
            switchHabilitado.HandleOnColor = Color.FromArgb(255, 255, 255);
            switchHabilitado.Location = new Point(103, 214);
            switchHabilitado.Name = "switchHabilitado";
            switchHabilitado.OffColor = Color.FromArgb(75, 75, 75);
            switchHabilitado.OnColor = Color.FromArgb(40, 40, 40);
            switchHabilitado.Size = new Size(61, 30);
            switchHabilitado.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.On;
            switchHabilitado.SwitchStyle = ReaLTaiizor.Controls.ParrotSwitch.Style.Dark;
            switchHabilitado.TabIndex = 21;
            switchHabilitado.Text = "parrotSwitch1";
            // 
            // BTNmodif
            // 
            BTNmodif.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTNmodif.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNmodif.Location = new Point(396, 186);
            BTNmodif.MaximumSize = new Size(95, 35);
            BTNmodif.MinimumSize = new Size(1, 1);
            BTNmodif.Name = "BTNmodif";
            BTNmodif.OverrideDefault.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNmodif.OverrideDefault.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNmodif.OverrideDefault.Back.ColorAngle = 45F;
            BTNmodif.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            BTNmodif.OverrideDefault.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNmodif.OverrideDefault.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNmodif.OverrideDefault.Border.ColorAngle = 45F;
            BTNmodif.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNmodif.OverrideDefault.Border.Rounding = 8F;
            BTNmodif.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            BTNmodif.Size = new Size(37, 35);
            BTNmodif.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNmodif.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNmodif.StateCommon.Back.ColorAngle = 45F;
            BTNmodif.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            BTNmodif.StateCommon.Back.Image = Properties.Resources.Mini_modif;
            BTNmodif.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            BTNmodif.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            BTNmodif.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 90);
            BTNmodif.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 90);
            BTNmodif.StateCommon.Border.ColorAngle = 45F;
            BTNmodif.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNmodif.StateCommon.Border.Rounding = 0F;
            BTNmodif.StateCommon.Content.AdjacentGap = 1;
            BTNmodif.StateCommon.Content.Image.ImageColorTo = Color.White;
            BTNmodif.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            BTNmodif.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            BTNmodif.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            BTNmodif.StateCommon.Content.ShortText.ColorAngle = 45F;
            BTNmodif.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            BTNmodif.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNmodif.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            BTNmodif.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            BTNmodif.StateTracking.Back.Color1 = Color.FromArgb(110, 100, 190);
            BTNmodif.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            BTNmodif.StateTracking.Back.ColorAngle = 135F;
            BTNmodif.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNmodif.StateTracking.Border.Rounding = 0F;
            BTNmodif.StateTracking.Content.ShortText.Color1 = Color.White;
            BTNmodif.StateTracking.Content.ShortText.Color2 = Color.White;
            BTNmodif.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            BTNmodif.TabIndex = 23;
            BTNmodif.Values.Text = "";
            BTNmodif.Click += BTNmodif_Click;
            // 
            // BTNdelete
            // 
            BTNdelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTNdelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNdelete.Location = new Point(356, 186);
            BTNdelete.MaximumSize = new Size(95, 35);
            BTNdelete.MinimumSize = new Size(1, 1);
            BTNdelete.Name = "BTNdelete";
            BTNdelete.OverrideDefault.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.OverrideDefault.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNdelete.OverrideDefault.Back.ColorAngle = 45F;
            BTNdelete.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            BTNdelete.OverrideDefault.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.OverrideDefault.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNdelete.OverrideDefault.Border.ColorAngle = 45F;
            BTNdelete.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNdelete.OverrideDefault.Border.Rounding = 8F;
            BTNdelete.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            BTNdelete.Size = new Size(34, 35);
            BTNdelete.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNdelete.StateCommon.Back.ColorAngle = 45F;
            BTNdelete.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            BTNdelete.StateCommon.Back.Image = Properties.Resources.Mini_borrar;
            BTNdelete.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            BTNdelete.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            BTNdelete.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNdelete.StateCommon.Border.ColorAngle = 45F;
            BTNdelete.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNdelete.StateCommon.Border.Rounding = 0F;
            BTNdelete.StateCommon.Content.AdjacentGap = 1;
            BTNdelete.StateCommon.Content.Image.ImageColorTo = Color.White;
            BTNdelete.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            BTNdelete.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            BTNdelete.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            BTNdelete.StateCommon.Content.ShortText.ColorAngle = 45F;
            BTNdelete.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            BTNdelete.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNdelete.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            BTNdelete.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            BTNdelete.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNdelete.StatePressed.Border.Rounding = 0F;
            BTNdelete.StateTracking.Back.Color1 = Color.FromArgb(110, 100, 190);
            BTNdelete.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            BTNdelete.StateTracking.Back.ColorAngle = 135F;
            BTNdelete.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNdelete.StateTracking.Border.Rounding = 0F;
            BTNdelete.StateTracking.Content.ShortText.Color1 = Color.White;
            BTNdelete.StateTracking.Content.ShortText.Color2 = Color.White;
            BTNdelete.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            BTNdelete.TabIndex = 24;
            BTNdelete.Values.Text = "";
            BTNdelete.Click += BTNdelete_Click;
            // 
            // FormDetailsProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(445, 466);
            Controls.Add(BTNdelete);
            Controls.Add(BTNmodif);
            Controls.Add(switchHabilitado);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(btnSiguiente);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(btnAnterior);
            Controls.Add(lblStock);
            Controls.Add(lblVentas);
            Controls.Add(datagridVentas);
            Controls.Add(datagridCompra);
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
            ((System.ComponentModel.ISupportInitialize)datagridCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel1;
        private Label lblCategoria;
        private Label lblCompra;
        private Krypton.Toolkit.KryptonDataGridView datagridCompra;
        private Krypton.Toolkit.KryptonDataGridView datagridVentas;
        private Label lblVentas;
        private Label lblStock;
        private Krypton.Toolkit.KryptonButton btnAnterior;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonButton btnSiguiente;
        private Label lblNombre;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn ColumnFecha;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn ColumnCantidad;
        private DataGridViewTextBoxColumn ColumnFecha2;
        private DataGridViewTextBoxColumn ColumnCantidad2;
        private Label label1;
        private ReaLTaiizor.Controls.ParrotSwitch switchHabilitado;
        private Krypton.Toolkit.KryptonButton BTNmodif;
        private Krypton.Toolkit.KryptonButton BTNdelete;
    }
}