using Krypton.Toolkit;

namespace WinForm
{
    partial class FormUserDetails
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
            IconSpec iconSpec1 = new IconSpec();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserDetails));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            IconSpec iconSpec2 = new IconSpec();
            IconSpec iconSpec3 = new IconSpec();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            IconSpec iconSpec4 = new IconSpec();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            IconSpec iconSpec5 = new IconSpec();
            IconSpec iconSpec6 = new IconSpec();
            lblCategoria = new Label();
            lblNombreProducto = new Label();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelfilter = new FlowLayoutPanel();
            BtnCompras = new Button();
            panelcategoria = new Panel();
            dataGridViewCompras = new KryptonDataGridView();
            ColumnProducto = new KryptonDataGridViewTextBoxColumn();
            ColumnCantidad = new KryptonDataGridViewTextBoxColumn();
            ColumnFecha = new KryptonDataGridViewDateTimePickerColumn();
            panelventas = new FlowLayoutPanel();
            Btnventas = new Button();
            panel1 = new Panel();
            VentasDataGridView = new KryptonDataGridView();
            ColumnVProducto = new KryptonDataGridViewTextBoxColumn();
            ColumnVCantidad = new KryptonDataGridViewTextBoxColumn();
            ColumnVFecha = new KryptonDataGridViewDateTimePickerColumn();
            comprastimer = new System.Windows.Forms.Timer(components);
            ventastimer = new System.Windows.Forms.Timer(components);
            btnlogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panelfilter.SuspendLayout();
            panelcategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            panelventas.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VentasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Poppins Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.FromArgb(128, 159, 234);
            lblCategoria.Location = new Point(2, 125);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(220, 37);
            lblCategoria.TabIndex = 11;
            lblCategoria.Text = "Nombre de usuario:";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold);
            lblNombreProducto.Location = new Point(59, 181);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(96, 27);
            lblNombreProducto.TabIndex = 10;
            lblNombreProducto.Text = "Nombre";
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
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(30, 30, 32);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(30, 30, 32);
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(50, 50, 56);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(50, 50, 56);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.ColorAngle = 135F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.ColorStyle = PaletteColorStyle.Dashed;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(70, 70, 80);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(70, 70, 80);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.ColorAngle = 45F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color1 = Color.DarkGray;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color2 = Color.DarkGray;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.ColorAngle = 45F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Content.Hint = PaletteTextHint.ClearTypeGridFit;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(60, 65, 190);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(65, 60, 195);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.ColorAngle = 135F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(60, 65, 195);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(70, 70, 195);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Rounding = 0F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Width = 1;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color2 = Color.White;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.ColorAngle = 135F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Near;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.TextV = PaletteRelativeAlign.Center;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(192, 192, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderRow.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color1 = Color.FromArgb(60, 65, 190);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color2 = Color.FromArgb(55, 55, 200);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.ColorAngle = 45F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color1 = Color.FromArgb(60, 65, 195);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color2 = Color.FromArgb(70, 70, 195);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = Color.FromArgb(26, 26, 35);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = Color.FromArgb(26, 26, 35);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(50, 55, 150);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color2 = Color.FromArgb(45, 50, 140);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.ColorAngle = 135F;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderCustom1.StateCommon.Back.Color1 = Color.FromArgb(192, 0, 192);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account_box_24dp_FILL0_wght400_GRAD0_opsz24;
            pictureBox1.Location = new Point(59, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panelfilter);
            flowLayoutPanel1.Controls.Add(panelventas);
            flowLayoutPanel1.Location = new Point(230, 12);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(430, 500);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // panelfilter
            // 
            panelfilter.BackColor = Color.FromArgb(70, 70, 80);
            panelfilter.Controls.Add(BtnCompras);
            panelfilter.Controls.Add(panelcategoria);
            panelfilter.Location = new Point(0, 0);
            panelfilter.Margin = new Padding(0);
            panelfilter.MaximumSize = new Size(425, 250);
            panelfilter.MinimumSize = new Size(425, 65);
            panelfilter.Name = "panelfilter";
            panelfilter.Size = new Size(425, 65);
            panelfilter.TabIndex = 1;
            // 
            // BtnCompras
            // 
            BtnCompras.BackColor = Color.FromArgb(56, 56, 68);
            BtnCompras.Cursor = Cursors.Hand;
            BtnCompras.FlatAppearance.BorderSize = 0;
            BtnCompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 72);
            BtnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 48);
            BtnCompras.FlatStyle = FlatStyle.Flat;
            BtnCompras.Font = new Font("Segoe UI", 12F);
            BtnCompras.ForeColor = Color.Silver;
            BtnCompras.Image = Properties.Resources.big_buttonD;
            BtnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCompras.Location = new Point(0, 0);
            BtnCompras.Margin = new Padding(0);
            BtnCompras.Name = "BtnCompras";
            BtnCompras.Size = new Size(430, 68);
            BtnCompras.TabIndex = 5;
            BtnCompras.Text = "Compras";
            BtnCompras.UseVisualStyleBackColor = false;
            BtnCompras.Click += panelfilter_Click;
            // 
            // panelcategoria
            // 
            panelcategoria.BackColor = Color.FromArgb(50, 50, 56);
            panelcategoria.Controls.Add(dataGridViewCompras);
            panelcategoria.Location = new Point(0, 68);
            panelcategoria.Margin = new Padding(0);
            panelcategoria.Name = "panelcategoria";
            panelcategoria.Size = new Size(430, 182);
            panelcategoria.TabIndex = 0;
            // 
            // dataGridViewCompras
            // 
            dataGridViewCompras.AllowUserToAddRows = false;
            dataGridViewCompras.AllowUserToDeleteRows = false;
            dataGridViewCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 70);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(24, 24, 32);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCompras.BorderStyle = BorderStyle.None;
            dataGridViewCompras.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompras.Columns.AddRange(new DataGridViewColumn[] { ColumnProducto, ColumnCantidad, ColumnFecha });
            dataGridViewCompras.GridStyles.Style = DataGridViewStyle.Custom1;
            dataGridViewCompras.GridStyles.StyleBackground = PaletteBackStyle.GridBackgroundCustom1;
            dataGridViewCompras.GridStyles.StyleColumn = GridStyle.Custom1;
            dataGridViewCompras.GridStyles.StyleDataCells = GridStyle.Custom1;
            dataGridViewCompras.GridStyles.StyleRow = GridStyle.Custom1;
            dataGridViewCompras.Location = new Point(-1, 0);
            dataGridViewCompras.MaximumSize = new Size(430, 180);
            dataGridViewCompras.MinimumSize = new Size(430, 180);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.Palette = kryptonCustomPaletteBase1;
            dataGridViewCompras.PaletteMode = PaletteMode.Custom;
            dataGridViewCompras.ReadOnly = true;
            dataGridViewCompras.RowHeadersVisible = false;
            dataGridViewCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCompras.Size = new Size(430, 180);
            dataGridViewCompras.StandardTab = true;
            dataGridViewCompras.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundCustom1;
            dataGridViewCompras.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(60, 65, 190);
            dataGridViewCompras.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(60, 65, 195);
            dataGridViewCompras.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(50, 55, 150);
            dataGridViewCompras.StateTracking.HeaderColumn.Back.Color2 = Color.FromArgb(45, 50, 140);
            dataGridViewCompras.TabIndex = 1;
            dataGridViewCompras.TabStop = false;
            // 
            // ColumnProducto
            // 
            ColumnProducto.DataPropertyName = "ProductoId";
            ColumnProducto.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnProducto.HeaderText = "Producto";
            iconSpec1.Alignment = IconSpec.IconAlignment.Left;
            iconSpec1.Icon = (Image)resources.GetObject("iconSpec1.Icon");
            ColumnProducto.IconSpecs.Add(iconSpec1);
            ColumnProducto.Name = "ColumnProducto";
            ColumnProducto.ReadOnly = true;
            ColumnProducto.Width = 165;
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.DataPropertyName = "Cantidad";
            ColumnCantidad.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnCantidad.HeaderText = "Cantidad";
            iconSpec2.Alignment = IconSpec.IconAlignment.Left;
            iconSpec2.Icon = (Image)resources.GetObject("iconSpec2.Icon");
            ColumnCantidad.IconSpecs.Add(iconSpec2);
            ColumnCantidad.Name = "ColumnCantidad";
            ColumnCantidad.ReadOnly = true;
            ColumnCantidad.Width = 130;
            // 
            // ColumnFecha
            // 
            ColumnFecha.CalendarTodayDate = new DateTime(2024, 6, 15, 0, 0, 0, 0);
            ColumnFecha.Checked = false;
            ColumnFecha.CustomFormat = "dd/MM/yyyy, HH:mm";
            ColumnFecha.DataPropertyName = "Fecha";
            ColumnFecha.Format = DateTimePickerFormat.Custom;
            ColumnFecha.HeaderText = "Fecha";
            iconSpec3.Alignment = IconSpec.IconAlignment.Left;
            iconSpec3.Icon = (Image)resources.GetObject("iconSpec3.Icon");
            ColumnFecha.IconSpecs.Add(iconSpec3);
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.ReadOnly = true;
            ColumnFecha.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnFecha.Width = 130;
            // 
            // panelventas
            // 
            panelventas.BackColor = Color.FromArgb(70, 70, 80);
            panelventas.Controls.Add(Btnventas);
            panelventas.Controls.Add(panel1);
            panelventas.Location = new Point(0, 65);
            panelventas.Margin = new Padding(0);
            panelventas.MaximumSize = new Size(425, 250);
            panelventas.MinimumSize = new Size(425, 65);
            panelventas.Name = "panelventas";
            panelventas.Size = new Size(425, 65);
            panelventas.TabIndex = 6;
            // 
            // Btnventas
            // 
            Btnventas.BackColor = Color.FromArgb(56, 56, 68);
            Btnventas.Cursor = Cursors.Hand;
            Btnventas.FlatAppearance.BorderColor = Color.FromArgb(56, 56, 64);
            Btnventas.FlatAppearance.BorderSize = 0;
            Btnventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 72);
            Btnventas.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 48);
            Btnventas.FlatStyle = FlatStyle.Flat;
            Btnventas.Font = new Font("Segoe UI", 12F);
            Btnventas.ForeColor = Color.Silver;
            Btnventas.Image = Properties.Resources.big_buttonVD;
            Btnventas.ImageAlign = ContentAlignment.MiddleLeft;
            Btnventas.Location = new Point(0, 0);
            Btnventas.Margin = new Padding(0);
            Btnventas.Name = "Btnventas";
            Btnventas.Size = new Size(430, 68);
            Btnventas.TabIndex = 5;
            Btnventas.Text = "Ventas";
            Btnventas.UseVisualStyleBackColor = false;
            Btnventas.Click += Btnventas_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 56);
            panel1.Controls.Add(VentasDataGridView);
            panel1.Location = new Point(0, 68);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 182);
            panel1.TabIndex = 0;
            // 
            // VentasDataGridView
            // 
            VentasDataGridView.AllowUserToAddRows = false;
            VentasDataGridView.AllowUserToDeleteRows = false;
            VentasDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(60, 60, 70);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(24, 24, 32);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(224, 224, 224);
            VentasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            VentasDataGridView.BorderStyle = BorderStyle.None;
            VentasDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            VentasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VentasDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnVProducto, ColumnVCantidad, ColumnVFecha });
            VentasDataGridView.GridStyles.Style = DataGridViewStyle.Custom1;
            VentasDataGridView.GridStyles.StyleBackground = PaletteBackStyle.GridBackgroundCustom1;
            VentasDataGridView.GridStyles.StyleColumn = GridStyle.Custom1;
            VentasDataGridView.GridStyles.StyleDataCells = GridStyle.Custom1;
            VentasDataGridView.GridStyles.StyleRow = GridStyle.Custom1;
            VentasDataGridView.Location = new Point(-1, 0);
            VentasDataGridView.MaximumSize = new Size(430, 180);
            VentasDataGridView.MinimumSize = new Size(430, 180);
            VentasDataGridView.Name = "VentasDataGridView";
            VentasDataGridView.Palette = kryptonCustomPaletteBase1;
            VentasDataGridView.PaletteMode = PaletteMode.Custom;
            VentasDataGridView.ReadOnly = true;
            VentasDataGridView.RowHeadersVisible = false;
            VentasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VentasDataGridView.Size = new Size(430, 180);
            VentasDataGridView.StandardTab = true;
            VentasDataGridView.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundCustom1;
            VentasDataGridView.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(60, 65, 190);
            VentasDataGridView.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(60, 65, 195);
            VentasDataGridView.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(50, 55, 150);
            VentasDataGridView.StateTracking.HeaderColumn.Back.Color2 = Color.FromArgb(45, 50, 140);
            VentasDataGridView.TabIndex = 1;
            VentasDataGridView.TabStop = false;
            // 
            // ColumnVProducto
            // 
            ColumnVProducto.DataPropertyName = "Nombre";
            ColumnVProducto.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnVProducto.HeaderText = "Producto";
            iconSpec4.Alignment = IconSpec.IconAlignment.Left;
            iconSpec4.Icon = (Image)resources.GetObject("iconSpec4.Icon");
            ColumnVProducto.IconSpecs.Add(iconSpec4);
            ColumnVProducto.Name = "ColumnVProducto";
            ColumnVProducto.ReadOnly = true;
            ColumnVProducto.Width = 165;
            // 
            // ColumnVCantidad
            // 
            ColumnVCantidad.DataPropertyName = "Cantidad";
            ColumnVCantidad.DefaultCellStyle = dataGridViewCellStyle6;
            ColumnVCantidad.HeaderText = "Cantidad";
            iconSpec5.Alignment = IconSpec.IconAlignment.Left;
            iconSpec5.Icon = (Image)resources.GetObject("iconSpec5.Icon");
            ColumnVCantidad.IconSpecs.Add(iconSpec5);
            ColumnVCantidad.Name = "ColumnVCantidad";
            ColumnVCantidad.ReadOnly = true;
            ColumnVCantidad.Width = 130;
            // 
            // ColumnVFecha
            // 
            ColumnVFecha.Checked = false;
            ColumnVFecha.CustomFormat = "dd/MM/yyyy, HH:mm";
            ColumnVFecha.DataPropertyName = "Fecha";
            ColumnVFecha.Format = DateTimePickerFormat.Custom;
            ColumnVFecha.HeaderText = "Fecha";
            iconSpec6.Alignment = IconSpec.IconAlignment.Left;
            iconSpec6.Icon = (Image)resources.GetObject("iconSpec6.Icon");
            ColumnVFecha.IconSpecs.Add(iconSpec6);
            ColumnVFecha.Name = "ColumnVFecha";
            ColumnVFecha.ReadOnly = true;
            ColumnVFecha.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnVFecha.Width = 130;
            // 
            // comprastimer
            // 
            comprastimer.Interval = 10;
            comprastimer.Tick += comprastimer_Tick;
            // 
            // ventastimer
            // 
            ventastimer.Interval = 10;
            ventastimer.Tick += timer1_Tick;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(32, 32, 32);
            btnlogout.Cursor = Cursors.Hand;
            btnlogout.FlatAppearance.BorderColor = Color.FromArgb(56, 56, 64);
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 72);
            btnlogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 48);
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 12F);
            btnlogout.ForeColor = Color.Silver;
            btnlogout.Image = Properties.Resources.medium_logout;
            btnlogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnlogout.Location = new Point(-3, 439);
            btnlogout.Margin = new Padding(0);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(233, 68);
            btnlogout.TabIndex = 18;
            btnlogout.Text = "Volver";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // FormUserDetails
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(670, 515);
            Controls.Add(btnlogout);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombreProducto);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            FormTitleAlign = PaletteRelativeAlign.Center;
            Name = "FormUserDetails";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Informacion de usuario";
            TitleStyle = KryptonFormTitleStyle.Modern;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panelfilter.ResumeLayout(false);
            panelcategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            panelventas.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VentasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCategoria;
        private Label lblNombreProducto;
        private KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel panelfilter;
        private Button BtnCompras;
        private Panel panelcategoria;
        private KryptonDataGridView dataGridViewCompras;
        private KryptonDataGridViewTextBoxColumn ColumnProducto;
        private KryptonDataGridViewTextBoxColumn ColumnCantidad;
        private KryptonDataGridViewDateTimePickerColumn ColumnFecha;
        private System.Windows.Forms.Timer comprastimer;
        private FlowLayoutPanel panelventas;
        private Button Btnventas;
        private Panel panel1;
        private KryptonDataGridView VentasDataGridView;
        private KryptonDataGridViewTextBoxColumn ColumnVProducto;
        private KryptonDataGridViewTextBoxColumn ColumnVCantidad;
        private KryptonDataGridViewDateTimePickerColumn ColumnVFecha;
        private System.Windows.Forms.Timer ventastimer;
        private Button btnlogout;
    }
}