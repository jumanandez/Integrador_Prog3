using Krypton.Toolkit;

namespace WinForm
{
	partial class FormProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            dataGridViewProducto = new KryptonDataGridView();
            ColumnHabilitado = new DataGridViewCheckBoxColumn();
            ColumnNombreProducto = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnStock = new DataGridViewTextBoxColumn();
            ColumnCompras = new DataGridViewTextBoxColumn();
            ColumnVentas = new DataGridViewTextBoxColumn();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            BTNdelete = new KryptonButton();
            BTNmodif = new KryptonButton();
            btnNuevoProducto = new KryptonButton();
            textBox1 = new KryptonTextBox();
            cmbBoxCategorias = new KryptonComboBox();
            lblCategorias = new KryptonLabel();
            btnPrimerCarga = new KryptonButton();
            numericUpDown1 = new KryptonNumericUpDown();
            BtnCompra = new KryptonButton();
            LblBienvenido = new KryptonLabel();
            rdiobtnHabilitado = new KryptonRadioButton();
            rdiobtnDeshabilitado = new KryptonRadioButton();
            rdiobtnTodos = new KryptonRadioButton();
            BtnRfrs = new KryptonButton();
            kryptonPictureBox1 = new KryptonPictureBox();
            label1 = new KryptonLabel();
            sidebarpanel = new FlowLayoutPanel();
            panel1 = new Panel();
            kryptonLabel1 = new KryptonLabel();
            menubutton = new KryptonPictureBox();
            filtercontainer = new Panel();
            panel2 = new Panel();
            kryptonButton1 = new KryptonButton();
            panel4 = new Panel();
            panel3 = new Panel();
            kryptonPictureBox2 = new KryptonPictureBox();
            sidebartimer = new System.Windows.Forms.Timer(components);
            filtertimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbBoxCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            sidebarpanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).BeginInit();
            filtercontainer.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducto
            // 
            dataGridViewProducto.AllowUserToAddRows = false;
            dataGridViewProducto.AllowUserToDeleteRows = false;
            dataGridViewProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 70);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(24, 24, 32);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducto.BorderStyle = BorderStyle.None;
            dataGridViewProducto.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducto.Columns.AddRange(new DataGridViewColumn[] { ColumnHabilitado, ColumnNombreProducto, ColumnCategoria, ColumnStock, ColumnCompras, ColumnVentas });
            dataGridViewProducto.GridStyles.Style = DataGridViewStyle.Custom1;
            dataGridViewProducto.GridStyles.StyleBackground = PaletteBackStyle.GridBackgroundCustom1;
            dataGridViewProducto.GridStyles.StyleColumn = GridStyle.Custom1;
            dataGridViewProducto.GridStyles.StyleDataCells = GridStyle.Custom1;
            dataGridViewProducto.GridStyles.StyleRow = GridStyle.Custom1;
            dataGridViewProducto.Location = new Point(227, 164);
            dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewProducto.Palette = kryptonCustomPaletteBase1;
            dataGridViewProducto.PaletteMode = PaletteMode.Custom;
            dataGridViewProducto.ReadOnly = true;
            dataGridViewProducto.RowHeadersVisible = false;
            dataGridViewProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducto.Size = new Size(507, 257);
            dataGridViewProducto.StandardTab = true;
            dataGridViewProducto.TabIndex = 0;
            dataGridViewProducto.TabStop = false;
            dataGridViewProducto.ColumnHeaderMouseClick += dataGridViewProducto_ColumnHeaderMouseClick;
            // 
            // ColumnHabilitado
            // 
            ColumnHabilitado.DataPropertyName = "Habilitado";
            ColumnHabilitado.HeaderText = "Habilitado";
            ColumnHabilitado.Name = "ColumnHabilitado";
            ColumnHabilitado.ReadOnly = true;
            ColumnHabilitado.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnHabilitado.Width = 80;
            // 
            // ColumnNombreProducto
            // 
            ColumnNombreProducto.DataPropertyName = "Nombre";
            ColumnNombreProducto.HeaderText = "Nombre";
            ColumnNombreProducto.Name = "ColumnNombreProducto";
            ColumnNombreProducto.ReadOnly = true;
            ColumnNombreProducto.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnNombreProducto.Width = 130;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.DataPropertyName = "Categoria";
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            ColumnCategoria.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnCategoria.Width = 130;
            // 
            // ColumnStock
            // 
            ColumnStock.HeaderText = "Stock";
            ColumnStock.Name = "ColumnStock";
            ColumnStock.ReadOnly = true;
            ColumnStock.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnStock.Width = 50;
            // 
            // ColumnCompras
            // 
            ColumnCompras.HeaderText = "Compras";
            ColumnCompras.Name = "ColumnCompras";
            ColumnCompras.ReadOnly = true;
            ColumnCompras.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnCompras.Width = 60;
            // 
            // ColumnVentas
            // 
            ColumnVentas.HeaderText = "Ventas";
            ColumnVentas.Name = "ColumnVentas";
            ColumnVentas.ReadOnly = true;
            ColumnVentas.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnVentas.Width = 55;
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(48, 48, 56);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(64, 64, 64);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(46, 46, 56);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(56, 56, 56);
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Near;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.TextV = PaletteRelativeAlign.Center;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(192, 192, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderRow.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = Color.FromArgb(26, 26, 35);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = Color.FromArgb(26, 26, 35);
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
            // BTNdelete
            // 
            BTNdelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTNdelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNdelete.Location = new Point(638, 427);
            BTNdelete.MaximumSize = new Size(95, 35);
            BTNdelete.MinimumSize = new Size(95, 35);
            BTNdelete.Name = "BTNdelete";
            BTNdelete.Size = new Size(95, 35);
            BTNdelete.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.StateCommon.Back.Color2 = Color.FromArgb(60, 60, 175);
            BTNdelete.StateCommon.Back.ColorAngle = 45F;
            BTNdelete.StateCommon.Back.Image = Properties.Resources.Mini_borrar;
            BTNdelete.StateCommon.Back.ImageAlign = PaletteRectangleAlign.Local;
            BTNdelete.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterLeft;
            BTNdelete.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNdelete.StateCommon.Border.ColorAngle = 45F;
            BTNdelete.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNdelete.StateCommon.Border.Rounding = 8F;
            BTNdelete.StateCommon.Content.AdjacentGap = 1;
            BTNdelete.StateCommon.Content.Image.ImageColorTo = Color.White;
            BTNdelete.StateCommon.Content.Padding = new Padding(25, -1, 0, -1);
            BTNdelete.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            BTNdelete.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            BTNdelete.StateCommon.Content.ShortText.ColorAngle = 45F;
            BTNdelete.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Solid;
            BTNdelete.StateCommon.Content.ShortText.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNdelete.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNdelete.StateTracking.Border.Rounding = 8F;
            BTNdelete.TabIndex = 11;
            BTNdelete.TabStop = false;
            BTNdelete.Values.Text = "Eliminar";
            BTNdelete.Click += BTNdelete_Click;
            // 
            // BTNmodif
            // 
            BTNmodif.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTNmodif.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNmodif.Location = new Point(527, 427);
            BTNmodif.MaximumSize = new Size(95, 35);
            BTNmodif.MinimumSize = new Size(95, 35);
            BTNmodif.Name = "BTNmodif";
            BTNmodif.Size = new Size(95, 35);
            BTNmodif.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNmodif.StateCommon.Back.Color2 = Color.FromArgb(60, 60, 175);
            BTNmodif.StateCommon.Back.ColorAngle = 45F;
            BTNmodif.StateCommon.Back.Image = Properties.Resources.Mini_modif;
            BTNmodif.StateCommon.Back.ImageAlign = PaletteRectangleAlign.Local;
            BTNmodif.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterLeft;
            BTNmodif.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNmodif.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNmodif.StateCommon.Border.ColorAngle = 45F;
            BTNmodif.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNmodif.StateCommon.Border.ImageAlign = PaletteRectangleAlign.Local;
            BTNmodif.StateCommon.Border.Rounding = 8F;
            BTNmodif.StateCommon.Content.AdjacentGap = 1;
            BTNmodif.StateCommon.Content.Image.ImageColorTo = Color.White;
            BTNmodif.StateCommon.Content.Padding = new Padding(26, -1, 0, -1);
            BTNmodif.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            BTNmodif.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            BTNmodif.StateCommon.Content.ShortText.ColorAngle = 45F;
            BTNmodif.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Solid;
            BTNmodif.StateCommon.Content.ShortText.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNmodif.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNmodif.StateTracking.Border.Rounding = 8F;
            BTNmodif.TabIndex = 12;
            BTNmodif.TabStop = false;
            BTNmodif.Values.Text = "Modificar";
            BTNmodif.Click += btnModificar_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnNuevoProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoProducto.Location = new Point(414, 427);
            btnNuevoProducto.MaximumSize = new Size(95, 35);
            btnNuevoProducto.MinimumSize = new Size(95, 35);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(95, 35);
            btnNuevoProducto.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            btnNuevoProducto.StateCommon.Back.Color2 = Color.FromArgb(60, 60, 175);
            btnNuevoProducto.StateCommon.Back.ColorAngle = 45F;
            btnNuevoProducto.StateCommon.Back.Image = Properties.Resources.addmini;
            btnNuevoProducto.StateCommon.Back.ImageAlign = PaletteRectangleAlign.Local;
            btnNuevoProducto.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterLeft;
            btnNuevoProducto.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            btnNuevoProducto.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            btnNuevoProducto.StateCommon.Border.ColorAngle = 45F;
            btnNuevoProducto.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNuevoProducto.StateCommon.Border.Rounding = 8F;
            btnNuevoProducto.StateCommon.Content.AdjacentGap = 1;
            btnNuevoProducto.StateCommon.Content.Image.ImageColorTo = Color.White;
            btnNuevoProducto.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            btnNuevoProducto.StateCommon.Content.ShortText.Color1 = Color.Gainsboro;
            btnNuevoProducto.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            btnNuevoProducto.StateCommon.Content.ShortText.ColorAngle = 45F;
            btnNuevoProducto.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Solid;
            btnNuevoProducto.StateCommon.Content.ShortText.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoProducto.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNuevoProducto.StateTracking.Border.Rounding = 8F;
            btnNuevoProducto.TabIndex = 14;
            btnNuevoProducto.TabStop = false;
            btnNuevoProducto.ToolTipValues.Description = "Agregar elemento";
            btnNuevoProducto.Values.Text = "Agregar";
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(527, 131);
            textBox1.MaximumSize = new Size(171, 23);
            textBox1.MinimumSize = new Size(171, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.StateCommon.Back.Color1 = Color.FromArgb(48, 48, 56);
            textBox1.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            textBox1.StateCommon.Border.Color2 = Color.Gray;
            textBox1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            textBox1.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            textBox1.StateCommon.Border.Rounding = 18F;
            textBox1.StateCommon.Content.Color1 = Color.Gray;
            textBox1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cmbBoxCategorias
            // 
            cmbBoxCategorias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBoxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCategorias.DropDownWidth = 171;
            cmbBoxCategorias.FormattingEnabled = true;
            cmbBoxCategorias.InputControlStyle = InputControlStyle.Ribbon;
            cmbBoxCategorias.IntegralHeight = false;
            cmbBoxCategorias.Location = new Point(69, 33);
            cmbBoxCategorias.Name = "cmbBoxCategorias";
            cmbBoxCategorias.PaletteMode = PaletteMode.Office2010BlueDarkMode;
            cmbBoxCategorias.Size = new Size(117, 18);
            cmbBoxCategorias.StateActive.ComboBox.Border.DrawBorders = PaletteDrawBorders.None;
            cmbBoxCategorias.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(48, 48, 56);
            cmbBoxCategorias.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(48, 48, 56);
            cmbBoxCategorias.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(48, 48, 56);
            cmbBoxCategorias.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbBoxCategorias.StateCommon.ComboBox.Border.Rounding = 5F;
            cmbBoxCategorias.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(224, 224, 224);
            cmbBoxCategorias.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxCategorias.StateCommon.DropBack.Color1 = Color.FromArgb(48, 48, 56);
            cmbBoxCategorias.StateCommon.DropBack.Color2 = Color.FromArgb(48, 48, 56);
            cmbBoxCategorias.StateCommon.DropBack.ColorAngle = 45F;
            cmbBoxCategorias.StateCommon.Item.Border.Color1 = Color.FromArgb(64, 64, 64);
            cmbBoxCategorias.StateCommon.Item.Border.Color2 = Color.FromArgb(64, 64, 64);
            cmbBoxCategorias.StateCommon.Item.Border.ColorStyle = PaletteColorStyle.Solid;
            cmbBoxCategorias.StateCommon.Item.Border.DrawBorders = PaletteDrawBorders.None;
            cmbBoxCategorias.StateCommon.Item.Content.ShortText.Color1 = Color.White;
            cmbBoxCategorias.StateCommon.Item.Content.ShortText.Color2 = Color.White;
            cmbBoxCategorias.StateCommon.Item.Content.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxCategorias.StateTracking.Item.Back.Color1 = Color.FromArgb(64, 64, 64);
            cmbBoxCategorias.StateTracking.Item.Back.Color2 = Color.FromArgb(64, 64, 64);
            cmbBoxCategorias.StateTracking.Item.Border.Color1 = Color.FromArgb(48, 48, 56);
            cmbBoxCategorias.StateTracking.Item.Border.Color2 = Color.FromArgb(48, 48, 56);
            cmbBoxCategorias.StateTracking.Item.Border.ColorAngle = 45F;
            cmbBoxCategorias.StateTracking.Item.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            cmbBoxCategorias.StateTracking.Item.Border.Rounding = 5F;
            cmbBoxCategorias.TabIndex = 17;
            cmbBoxCategorias.TabStop = false;
            cmbBoxCategorias.SelectedIndexChanged += cmbBoxCategorias_SelectedIndexChanged;
            // 
            // lblCategorias
            // 
            lblCategorias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategorias.Location = new Point(97, 5);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(89, 26);
            lblCategorias.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblCategorias.StateCommon.ShortText.Color2 = Color.Gainsboro;
            lblCategorias.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategorias.StateCommon.ShortText.Image = (Image)resources.GetObject("lblCategorias.StateCommon.ShortText.Image");
            lblCategorias.StateCommon.ShortText.ImageAlign = PaletteRectangleAlign.Local;
            lblCategorias.StateCommon.ShortText.ImageStyle = PaletteImageStyle.CenterMiddle;
            lblCategorias.TabIndex = 18;
            lblCategorias.Values.Text = "Categorias";
            // 
            // btnPrimerCarga
            // 
            btnPrimerCarga.Enabled = false;
            btnPrimerCarga.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrimerCarga.Location = new Point(71, 347);
            btnPrimerCarga.Name = "btnPrimerCarga";
            btnPrimerCarga.Size = new Size(114, 81);
            btnPrimerCarga.TabIndex = 19;
            btnPrimerCarga.Values.Text = "Primera Carga de Productos ";
            btnPrimerCarga.Visible = false;
            btnPrimerCarga.Click += btnPrimerCarga_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 11F);
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Location = new Point(184, 434);
            numericUpDown1.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 22);
            numericUpDown1.TabIndex = 20;
            numericUpDown1.Value = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown1.Visible = false;
            numericUpDown1.Click += numericUpDown1_Click;
            // 
            // BtnCompra
            // 
            BtnCompra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnCompra.Enabled = false;
            BtnCompra.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCompra.Location = new Point(94, 433);
            BtnCompra.MaximumSize = new Size(84, 29);
            BtnCompra.MinimumSize = new Size(84, 29);
            BtnCompra.Name = "BtnCompra";
            BtnCompra.Size = new Size(84, 29);
            BtnCompra.TabIndex = 21;
            BtnCompra.Values.Text = "Comprar";
            BtnCompra.Visible = false;
            BtnCompra.Click += BtnCompra_Click;
            // 
            // LblBienvenido
            // 
            LblBienvenido.AutoSize = false;
            LblBienvenido.Font = new Font("Segoe UI", 20F);
            LblBienvenido.Location = new Point(227, 20);
            LblBienvenido.Name = "LblBienvenido";
            LblBienvenido.Size = new Size(282, 88);
            LblBienvenido.StateCommon.Draw = InheritBool.True;
            LblBienvenido.StateCommon.DrawFocus = InheritBool.False;
            LblBienvenido.StateCommon.ShortText.Color1 = Color.White;
            LblBienvenido.StateNormal.ShortText.Color1 = SystemColors.ControlLight;
            LblBienvenido.StateNormal.ShortText.Color2 = Color.White;
            LblBienvenido.StateNormal.ShortText.ColorAngle = 45F;
            LblBienvenido.StateNormal.ShortText.ColorStyle = PaletteColorStyle.Solid;
            LblBienvenido.StateNormal.ShortText.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBienvenido.StateNormal.ShortText.MultiLine = InheritBool.True;
            LblBienvenido.StateNormal.ShortText.MultiLineH = PaletteRelativeAlign.Near;
            LblBienvenido.StateNormal.ShortText.TextV = PaletteRelativeAlign.Near;
            LblBienvenido.TabIndex = 23;
            LblBienvenido.Values.Text = "Bienvenido \r\nThomas";
            // 
            // rdiobtnHabilitado
            // 
            rdiobtnHabilitado.Images.CheckedNormal = (Image)resources.GetObject("rdiobtnHabilitado.Images.CheckedNormal");
            rdiobtnHabilitado.Images.CheckedPressed = (Image)resources.GetObject("rdiobtnHabilitado.Images.CheckedPressed");
            rdiobtnHabilitado.Images.CheckedTracking = (Image)resources.GetObject("rdiobtnHabilitado.Images.CheckedTracking");
            rdiobtnHabilitado.Images.Common = (Image)resources.GetObject("rdiobtnHabilitado.Images.Common");
            rdiobtnHabilitado.Images.UncheckedDisabled = (Image)resources.GetObject("rdiobtnHabilitado.Images.UncheckedDisabled");
            rdiobtnHabilitado.Images.UncheckedNormal = (Image)resources.GetObject("rdiobtnHabilitado.Images.UncheckedNormal");
            rdiobtnHabilitado.Images.UncheckedPressed = (Image)resources.GetObject("rdiobtnHabilitado.Images.UncheckedPressed");
            rdiobtnHabilitado.Images.UncheckedTracking = (Image)resources.GetObject("rdiobtnHabilitado.Images.UncheckedTracking");
            rdiobtnHabilitado.Location = new Point(66, 6);
            rdiobtnHabilitado.Name = "rdiobtnHabilitado";
            rdiobtnHabilitado.PaletteMode = PaletteMode.Microsoft365BlackDarkMode;
            rdiobtnHabilitado.Size = new Size(116, 26);
            rdiobtnHabilitado.StateNormal.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdiobtnHabilitado.TabIndex = 24;
            rdiobtnHabilitado.Values.Text = "Habilitados";
            rdiobtnHabilitado.CheckedChanged += rdiobtnHabilitado_CheckedChanged;
            // 
            // rdiobtnDeshabilitado
            // 
            rdiobtnDeshabilitado.Images.CheckedDisabled = Properties.Resources.check_mini;
            rdiobtnDeshabilitado.Images.CheckedNormal = Properties.Resources.check_mini;
            rdiobtnDeshabilitado.Images.CheckedPressed = Properties.Resources.check_mini;
            rdiobtnDeshabilitado.Images.CheckedTracking = Properties.Resources.check_mini;
            rdiobtnDeshabilitado.Images.Common = Properties.Resources.unchecked_mini;
            rdiobtnDeshabilitado.Images.UncheckedDisabled = Properties.Resources.unchecked_mini;
            rdiobtnDeshabilitado.Images.UncheckedNormal = Properties.Resources.unchecked_mini;
            rdiobtnDeshabilitado.Images.UncheckedPressed = Properties.Resources.unchecked_mini;
            rdiobtnDeshabilitado.Images.UncheckedTracking = Properties.Resources.unchecked_mini;
            rdiobtnDeshabilitado.Location = new Point(66, 31);
            rdiobtnDeshabilitado.Name = "rdiobtnDeshabilitado";
            rdiobtnDeshabilitado.PaletteMode = PaletteMode.Microsoft365BlackDarkMode;
            rdiobtnDeshabilitado.Size = new Size(141, 26);
            rdiobtnDeshabilitado.StateNormal.ShortText.Font = new Font("Segoe UI", 12F);
            rdiobtnDeshabilitado.TabIndex = 25;
            rdiobtnDeshabilitado.Values.Text = "Deshabilitados";
            rdiobtnDeshabilitado.CheckedChanged += rdiobtnDeshabilitado_CheckedChanged;
            // 
            // rdiobtnTodos
            // 
            rdiobtnTodos.Checked = true;
            rdiobtnTodos.Images.CheckedDisabled = Properties.Resources.check_mini;
            rdiobtnTodos.Images.CheckedNormal = Properties.Resources.check_mini;
            rdiobtnTodos.Images.CheckedPressed = Properties.Resources.check_mini;
            rdiobtnTodos.Images.CheckedTracking = Properties.Resources.check_mini;
            rdiobtnTodos.Images.Common = Properties.Resources.unchecked_mini;
            rdiobtnTodos.Images.UncheckedDisabled = Properties.Resources.unchecked_mini;
            rdiobtnTodos.Images.UncheckedNormal = Properties.Resources.unchecked_mini;
            rdiobtnTodos.Images.UncheckedPressed = Properties.Resources.unchecked_mini;
            rdiobtnTodos.Images.UncheckedTracking = Properties.Resources.unchecked_mini;
            rdiobtnTodos.Location = new Point(66, 56);
            rdiobtnTodos.Name = "rdiobtnTodos";
            rdiobtnTodos.PaletteMode = PaletteMode.Microsoft365BlackDarkMode;
            rdiobtnTodos.Size = new Size(78, 26);
            rdiobtnTodos.StateCommon.ShortText.Font = new Font("Segoe UI", 12F);
            rdiobtnTodos.TabIndex = 26;
            rdiobtnTodos.Values.Text = "Todos";
            rdiobtnTodos.CheckedChanged += rdiobtnTodos_CheckedChanged;
            // 
            // BtnRfrs
            // 
            BtnRfrs.Font = new Font("Wingdings 3", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 2);
            BtnRfrs.Location = new Point(23, 384);
            BtnRfrs.Name = "BtnRfrs";
            BtnRfrs.Size = new Size(30, 30);
            BtnRfrs.TabIndex = 27;
            BtnRfrs.Values.Text = "Q";
            BtnRfrs.Visible = false;
            BtnRfrs.Click += button1_Click;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.mini_search;
            kryptonPictureBox1.Location = new Point(703, 131);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(30, 30);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox1.TabIndex = 28;
            kryptonPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.LabelStyle = LabelStyle.Custom1;
            label1.Location = new Point(222, 126);
            label1.Name = "label1";
            label1.Palette = kryptonCustomPaletteBase1;
            label1.PaletteMode = PaletteMode.Custom;
            label1.Size = new Size(127, 35);
            label1.StateCommon.ShortText.Color1 = Color.FromArgb(120, 140, 200);
            label1.StateCommon.ShortText.Color2 = Color.FromArgb(120, 140, 200);
            label1.StateCommon.ShortText.ColorAngle = 45F;
            label1.StateCommon.ShortText.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.TabIndex = 29;
            label1.Values.Text = "Productos";
            // 
            // sidebarpanel
            // 
            sidebarpanel.BackColor = Color.FromArgb(56, 56, 64);
            sidebarpanel.Controls.Add(panel1);
            sidebarpanel.Controls.Add(filtercontainer);
            sidebarpanel.Dock = DockStyle.Left;
            sidebarpanel.Location = new Point(0, 0);
            sidebarpanel.MaximumSize = new Size(221, 474);
            sidebarpanel.MinimumSize = new Size(75, 474);
            sidebarpanel.Name = "sidebarpanel";
            sidebarpanel.Size = new Size(75, 474);
            sidebarpanel.TabIndex = 30;
            sidebarpanel.Paint += sidebarpanel_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(kryptonLabel1);
            panel1.Controls.Add(menubutton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 78);
            panel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(77, 24);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(54, 26);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Menu";
            // 
            // menubutton
            // 
            menubutton.Cursor = Cursors.Hand;
            menubutton.Image = (Image)resources.GetObject("menubutton.Image");
            menubutton.Location = new Point(4, 9);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(53, 50);
            menubutton.TabIndex = 1;
            menubutton.TabStop = false;
            menubutton.Click += menubutton_Click;
            // 
            // filtercontainer
            // 
            filtercontainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filtercontainer.BackColor = Color.Transparent;
            filtercontainer.Controls.Add(panel2);
            filtercontainer.Controls.Add(panel4);
            filtercontainer.Controls.Add(panel3);
            filtercontainer.Location = new Point(3, 87);
            filtercontainer.MaximumSize = new Size(221, 230);
            filtercontainer.MinimumSize = new Size(221, 67);
            filtercontainer.Name = "filtercontainer";
            filtercontainer.Size = new Size(221, 67);
            filtercontainer.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.Controls.Add(kryptonButton1);
            panel2.Location = new Point(-34, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 78);
            panel2.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Enabled = false;
            kryptonButton1.Location = new Point(43, 5);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(56, 56, 64);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(56, 56, 64);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 53F;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.Gray;
            kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.ColorStyle = PaletteColorStyle.Solid;
            kryptonButton1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.Size = new Size(209, 65);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(56, 56, 64);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(56, 56, 64);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Back.Image = Properties.Resources.medium_filter;
            kryptonButton1.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterLeft;
            kryptonButton1.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateCommon.Content.ShortText.ColorAngle = 135F;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(66, 66, 74);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(70, 70, 82);
            kryptonButton1.StateTracking.Back.ColorAngle = 135F;
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(66, 66, 74);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(70, 70, 82);
            kryptonButton1.StateTracking.Border.ColorAngle = 42F;
            kryptonButton1.StateTracking.Border.DrawBorders = PaletteDrawBorders.None;
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.Text = "Filtrar";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 78);
            panel4.Controls.Add(rdiobtnHabilitado);
            panel4.Controls.Add(rdiobtnDeshabilitado);
            panel4.Controls.Add(rdiobtnTodos);
            panel4.Location = new Point(9, 140);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 86);
            panel4.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 78);
            panel3.Controls.Add(kryptonPictureBox2);
            panel3.Controls.Add(lblCategorias);
            panel3.Controls.Add(cmbBoxCategorias);
            panel3.Location = new Point(9, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 63);
            panel3.TabIndex = 32;
            // 
            // kryptonPictureBox2
            // 
            kryptonPictureBox2.Cursor = Cursors.Hand;
            kryptonPictureBox2.Image = Properties.Resources.micro_cate;
            kryptonPictureBox2.Location = new Point(69, 4);
            kryptonPictureBox2.Name = "kryptonPictureBox2";
            kryptonPictureBox2.Size = new Size(30, 24);
            kryptonPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox2.TabIndex = 3;
            kryptonPictureBox2.TabStop = false;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 12;
            sidebartimer.Tick += sidebartimer_Tick;
            // 
            // filtertimer
            // 
            filtertimer.Interval = 15;
            filtertimer.Tick += filtertimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(527, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(741, 474);
            Controls.Add(pictureBox1);
            Controls.Add(sidebarpanel);
            Controls.Add(label1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(BtnRfrs);
            Controls.Add(LblBienvenido);
            Controls.Add(BtnCompra);
            Controls.Add(numericUpDown1);
            Controls.Add(btnPrimerCarga);
            Controls.Add(textBox1);
            Controls.Add(btnNuevoProducto);
            Controls.Add(BTNmodif);
            Controls.Add(BTNdelete);
            Controls.Add(dataGridViewProducto);
            MaximizeBox = false;
            Name = "FormProducto";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sistema de control de stock";
            TitleStyle = KryptonFormTitleStyle.Classic;
            Activated += FormProducto_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbBoxCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            sidebarpanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).EndInit();
            filtercontainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private KryptonDataGridView dataGridViewProducto;
        private KryptonButton BTNdelete;
        private KryptonButton BTNmodif;
		private KryptonButton btnNuevoProducto;
        private KryptonTextBox textBox1;
		private KryptonComboBox cmbBoxCategorias;
		private KryptonLabel lblCategorias;
		private KryptonButton btnPrimerCarga;
        private KryptonNumericUpDown numericUpDown1;
        private KryptonButton BtnCompra;
        private KryptonLabel LblBienvenido;
		private KryptonRadioButton rdiobtnHabilitado;
		private KryptonRadioButton rdiobtnDeshabilitado;
		private KryptonRadioButton rdiobtnTodos;
        private KryptonButton BtnRfrs;
        private DataGridViewTextBoxColumn Column1;
        private KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private KryptonPictureBox kryptonPictureBox1;
        private KryptonLabel label1;
        private FlowLayoutPanel sidebarpanel;
        private Panel panel1;
        private Panel panel2;
        private KryptonButton kryptonButton1;
        private KryptonPictureBox menubutton;
        private KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Timer sidebartimer;
        private Panel filtercontainer;
        private System.Windows.Forms.Timer filtertimer;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private KryptonPictureBox kryptonPictureBox2;
        private DataGridViewCheckBoxColumn ColumnHabilitado;
        private DataGridViewTextBoxColumn ColumnNombreProducto;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnStock;
        private DataGridViewTextBoxColumn ColumnCompras;
        private DataGridViewTextBoxColumn ColumnVentas;
    }
}