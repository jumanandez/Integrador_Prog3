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
            ColumnNombreProducto = new DataGridViewTextBoxColumn();
            contextMenuRow = new ContextMenuStrip(components);
            nuevoToolStrip = new ToolStripMenuItem();
            ordenarToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            detallesToolStripMenuItem = new ToolStripMenuItem();
            refrescarToolStripMenuItem1 = new ToolStripMenuItem();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnStock = new DataGridViewTextBoxColumn();
            ColumnCompras = new DataGridViewTextBoxColumn();
            ColumnVentas = new DataGridViewTextBoxColumn();
            ColumnHabilitado = new DataGridViewCheckBoxColumn();
            contextMenuStrip2 = new ContextMenuStrip(components);
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            ordenarToolStripMenuItem = new ToolStripMenuItem();
            refrescarToolStripMenuItem = new ToolStripMenuItem();
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
            menubutton = new KryptonPictureBox();
            panelhabilitados = new Panel();
            panelcategoria = new Panel();
            kryptonPictureBox2 = new KryptonPictureBox();
            sidebartimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label2 = new Label();
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            menupanel = new FlowLayoutPanel();
            panelfilter = new FlowLayoutPanel();
            kryptonButton1 = new Button();
            panelUsuario1 = new FlowLayoutPanel();
            button1 = new Button();
            btninformacion = new Button();
            btnchangepass = new Button();
            panel2 = new Panel();
            btnlogout = new Button();
            nuevoToolStripMenuItem1 = new ToolStripMenuItem();
            Usertimer = new System.Windows.Forms.Timer(components);
            filtertimer = new System.Windows.Forms.Timer(components);
            datagridroudergropu = new ReaLTaiizor.Controls.CyberGroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
            contextMenuRow.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbBoxCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menubutton).BeginInit();
            panelhabilitados.SuspendLayout();
            panelcategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            menupanel.SuspendLayout();
            panelfilter.SuspendLayout();
            panelUsuario1.SuspendLayout();
            panel2.SuspendLayout();
            datagridroudergropu.SuspendLayout();
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
            dataGridViewProducto.Columns.AddRange(new DataGridViewColumn[] { ColumnNombreProducto, ColumnCategoria, ColumnStock, ColumnCompras, ColumnVentas, ColumnHabilitado });
            dataGridViewProducto.ContextMenuStrip = contextMenuStrip2;
            dataGridViewProducto.GridStyles.Style = DataGridViewStyle.Custom1;
            dataGridViewProducto.GridStyles.StyleBackground = PaletteBackStyle.GridBackgroundCustom1;
            dataGridViewProducto.GridStyles.StyleColumn = GridStyle.Custom1;
            dataGridViewProducto.GridStyles.StyleDataCells = GridStyle.Custom1;
            dataGridViewProducto.GridStyles.StyleRow = GridStyle.Custom1;
            dataGridViewProducto.Location = new Point(26, 0);
            dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewProducto.Palette = kryptonCustomPaletteBase1;
            dataGridViewProducto.PaletteMode = PaletteMode.Custom;
            dataGridViewProducto.ReadOnly = true;
            dataGridViewProducto.RowHeadersVisible = false;
            dataGridViewProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducto.Size = new Size(615, 356);
            dataGridViewProducto.StandardTab = true;
            dataGridViewProducto.TabIndex = 0;
            dataGridViewProducto.TabStop = false;
            dataGridViewProducto.ColumnHeaderMouseClick += dataGridViewProducto_ColumnHeaderMouseClick;
            dataGridViewProducto.MouseDown += dataGridViewProducto_MouseDown;
            // 
            // ColumnNombreProducto
            // 
            ColumnNombreProducto.ContextMenuStrip = contextMenuRow;
            ColumnNombreProducto.DataPropertyName = "Nombre";
            ColumnNombreProducto.HeaderText = "Nombre";
            ColumnNombreProducto.Name = "ColumnNombreProducto";
            ColumnNombreProducto.ReadOnly = true;
            ColumnNombreProducto.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnNombreProducto.Width = 140;
            // 
            // contextMenuRow
            // 
            contextMenuRow.BackColor = Color.FromArgb(30, 30, 32);
            contextMenuRow.Font = new Font("Segoe UI", 9F);
            contextMenuRow.Items.AddRange(new ToolStripItem[] { nuevoToolStrip, ordenarToolStripMenuItem1, modificarToolStripMenuItem, eliminarToolStripMenuItem, detallesToolStripMenuItem, refrescarToolStripMenuItem1 });
            contextMenuRow.Name = "contextMenuStrip1";
            contextMenuRow.RenderMode = ToolStripRenderMode.System;
            contextMenuRow.Size = new Size(126, 136);
            // 
            // nuevoToolStrip
            // 
            nuevoToolStrip.BackColor = Color.FromArgb(30, 30, 32);
            nuevoToolStrip.ForeColor = SystemColors.ButtonFace;
            nuevoToolStrip.Image = Properties.Resources.addmini;
            nuevoToolStrip.Name = "nuevoToolStrip";
            nuevoToolStrip.Size = new Size(125, 22);
            nuevoToolStrip.Text = "Nuevo";
            nuevoToolStrip.Click += nuevoProductoToolStripMenuItem_Click;
            // 
            // ordenarToolStripMenuItem1
            // 
            ordenarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            ordenarToolStripMenuItem1.ForeColor = SystemColors.ButtonFace;
            ordenarToolStripMenuItem1.Image = Properties.Resources.sort_mini;
            ordenarToolStripMenuItem1.Name = "ordenarToolStripMenuItem1";
            ordenarToolStripMenuItem1.Size = new Size(125, 22);
            ordenarToolStripMenuItem1.Text = "Ordenar";
            ordenarToolStripMenuItem1.Click += ordenarToolStripMenuItem1_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.BackColor = Color.FromArgb(30, 30, 32);
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.FlatStyle = FlatStyle.Flat;
            toolStripComboBox1.ForeColor = SystemColors.ButtonFace;
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            modificarToolStripMenuItem.Image = Properties.Resources.Mini_modif;
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(125, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            eliminarToolStripMenuItem.Image = Properties.Resources.Mini_borrar;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(125, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // detallesToolStripMenuItem
            // 
            detallesToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            detallesToolStripMenuItem.Image = Properties.Resources.read_more_24dp_FILL0_wght400_GRAD0_opsz24;
            detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            detallesToolStripMenuItem.Size = new Size(125, 22);
            detallesToolStripMenuItem.Text = "Detalles";
            detallesToolStripMenuItem.Click += detallesToolStripMenuItem_Click;
            // 
            // refrescarToolStripMenuItem1
            // 
            refrescarToolStripMenuItem1.ForeColor = SystemColors.ButtonFace;
            refrescarToolStripMenuItem1.Image = Properties.Resources.Mini_refresh;
            refrescarToolStripMenuItem1.Name = "refrescarToolStripMenuItem1";
            refrescarToolStripMenuItem1.Size = new Size(125, 22);
            refrescarToolStripMenuItem1.Text = "Refrescar";
            refrescarToolStripMenuItem1.Click += refrescarToolStripMenuItem_Click;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.ContextMenuStrip = contextMenuRow;
            ColumnCategoria.DataPropertyName = "Categoria";
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            ColumnCategoria.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnCategoria.Width = 140;
            // 
            // ColumnStock
            // 
            ColumnStock.ContextMenuStrip = contextMenuRow;
            ColumnStock.HeaderText = "Stock";
            ColumnStock.Name = "ColumnStock";
            ColumnStock.ReadOnly = true;
            ColumnStock.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnStock.Width = 60;
            // 
            // ColumnCompras
            // 
            ColumnCompras.ContextMenuStrip = contextMenuRow;
            ColumnCompras.HeaderText = "Compras";
            ColumnCompras.Name = "ColumnCompras";
            ColumnCompras.ReadOnly = true;
            ColumnCompras.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnCompras.Width = 80;
            // 
            // ColumnVentas
            // 
            ColumnVentas.ContextMenuStrip = contextMenuRow;
            ColumnVentas.HeaderText = "Ventas";
            ColumnVentas.Name = "ColumnVentas";
            ColumnVentas.ReadOnly = true;
            ColumnVentas.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnVentas.Width = 80;
            // 
            // ColumnHabilitado
            // 
            ColumnHabilitado.ContextMenuStrip = contextMenuRow;
            ColumnHabilitado.DataPropertyName = "Habilitado";
            ColumnHabilitado.HeaderText = "Habilitado";
            ColumnHabilitado.Name = "ColumnHabilitado";
            ColumnHabilitado.ReadOnly = true;
            ColumnHabilitado.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.BackColor = Color.FromArgb(30, 30, 32);
            contextMenuStrip2.Font = new Font("Segoe UI", 9F);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, ordenarToolStripMenuItem, refrescarToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(123, 70);
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 32);
            nuevoToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            nuevoToolStripMenuItem.Image = Properties.Resources.addmini;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(122, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoProductoToolStripMenuItem_Click;
            // 
            // ordenarToolStripMenuItem
            // 
            ordenarToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 32);
            ordenarToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            ordenarToolStripMenuItem.Image = Properties.Resources.sort_mini;
            ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            ordenarToolStripMenuItem.Size = new Size(122, 22);
            ordenarToolStripMenuItem.Text = "Ordenar";
            // 
            // refrescarToolStripMenuItem
            // 
            refrescarToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 32);
            refrescarToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            refrescarToolStripMenuItem.Image = Properties.Resources.Mini_refresh;
            refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            refrescarToolStripMenuItem.Size = new Size(122, 22);
            refrescarToolStripMenuItem.Text = "Refrescar";
            refrescarToolStripMenuItem.Click += refrescarToolStripMenuItem_Click;
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
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ControlInner.Back.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ControlInner.Back.Color2 = Color.Silver;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ItemHighlight.Back.Color1 = Color.Lime;
            kryptonCustomPaletteBase1.ContextMenu.StateCommon.ItemHighlight.Back.Color2 = Color.FromArgb(0, 192, 0);
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemHighlight.Back.Color1 = Color.Blue;
            kryptonCustomPaletteBase1.ContextMenu.StateHighlight.ItemHighlight.Back.Color2 = Color.FromArgb(128, 128, 255);
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
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.Gray;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.Gray;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.ColorAngle = 45F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.ColorStyle = PaletteColorStyle.Solid;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Draw = InheritBool.True;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.HighQuality;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Rounding = 25F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Width = 0;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color1 = Color.FromArgb(48, 48, 56);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.Color2 = Color.FromArgb(51, 51, 60);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.ColorAngle = 135F;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.Background.ColorStyle = PaletteColorStyle.Dashed;
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
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Near;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.TextV = PaletteRelativeAlign.Center;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(192, 192, 0);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateCommon.HeaderRow.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = Color.FromArgb(26, 26, 35);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = Color.FromArgb(26, 26, 35);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color1 = Color.FromArgb(50, 55, 150);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color2 = Color.FromArgb(45, 50, 140);
            kryptonCustomPaletteBase1.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.ColorAngle = 135F;
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
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // BTNdelete
            // 
            BTNdelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTNdelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNdelete.Location = new Point(685, 584);
            BTNdelete.MaximumSize = new Size(95, 35);
            BTNdelete.MinimumSize = new Size(95, 35);
            BTNdelete.Name = "BTNdelete";
            BTNdelete.OverrideDefault.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.OverrideDefault.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNdelete.OverrideDefault.Back.ColorAngle = 45F;
            BTNdelete.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Dashed;
            BTNdelete.OverrideDefault.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.OverrideDefault.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNdelete.OverrideDefault.Border.ColorAngle = 45F;
            BTNdelete.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNdelete.OverrideDefault.Border.Rounding = 8F;
            BTNdelete.OverrideDefault.Content.DrawFocus = InheritBool.False;
            BTNdelete.Size = new Size(95, 35);
            BTNdelete.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNdelete.StateCommon.Back.ColorAngle = 45F;
            BTNdelete.StateCommon.Back.ColorStyle = PaletteColorStyle.Dashed;
            BTNdelete.StateCommon.Back.Image = Properties.Resources.addmini;
            BTNdelete.StateCommon.Back.ImageAlign = PaletteRectangleAlign.Local;
            BTNdelete.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterLeft;
            BTNdelete.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNdelete.StateCommon.Border.ColorAngle = 45F;
            BTNdelete.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNdelete.StateCommon.Border.Rounding = 8F;
            BTNdelete.StateCommon.Content.AdjacentGap = 1;
            BTNdelete.StateCommon.Content.Image.ImageColorTo = Color.White;
            BTNdelete.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            BTNdelete.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            BTNdelete.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            BTNdelete.StateCommon.Content.ShortText.ColorAngle = 45F;
            BTNdelete.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Solid;
            BTNdelete.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNdelete.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            BTNdelete.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            BTNdelete.StateTracking.Back.Color1 = Color.FromArgb(85, 90, 220);
            BTNdelete.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            BTNdelete.StateTracking.Back.ColorAngle = 135F;
            BTNdelete.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNdelete.StateTracking.Border.Rounding = 8F;
            BTNdelete.StateTracking.Content.ShortText.Color1 = Color.White;
            BTNdelete.StateTracking.Content.ShortText.Color2 = Color.White;
            BTNdelete.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            BTNdelete.TabIndex = 2;
            BTNdelete.Values.Text = "Eliminar";
            BTNdelete.Click += BTNdelete_Click;
            // 
            // BTNmodif
            // 
            BTNmodif.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTNmodif.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNmodif.Location = new Point(578, 584);
            BTNmodif.MaximumSize = new Size(95, 35);
            BTNmodif.MinimumSize = new Size(95, 35);
            BTNmodif.Name = "BTNmodif";
            BTNmodif.OverrideDefault.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNmodif.OverrideDefault.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNmodif.OverrideDefault.Back.ColorAngle = 45F;
            BTNmodif.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Dashed;
            BTNmodif.OverrideDefault.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNmodif.OverrideDefault.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNmodif.OverrideDefault.Border.ColorAngle = 45F;
            BTNmodif.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNmodif.OverrideDefault.Border.Rounding = 8F;
            BTNmodif.OverrideDefault.Content.DrawFocus = InheritBool.False;
            BTNmodif.Size = new Size(95, 35);
            BTNmodif.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNmodif.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNmodif.StateCommon.Back.ColorAngle = 45F;
            BTNmodif.StateCommon.Back.ColorStyle = PaletteColorStyle.Dashed;
            BTNmodif.StateCommon.Back.Image = Properties.Resources.addmini;
            BTNmodif.StateCommon.Back.ImageAlign = PaletteRectangleAlign.Local;
            BTNmodif.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterLeft;
            BTNmodif.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNmodif.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNmodif.StateCommon.Border.ColorAngle = 45F;
            BTNmodif.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNmodif.StateCommon.Border.Rounding = 8F;
            BTNmodif.StateCommon.Content.AdjacentGap = 1;
            BTNmodif.StateCommon.Content.Image.ImageColorTo = Color.White;
            BTNmodif.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            BTNmodif.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            BTNmodif.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            BTNmodif.StateCommon.Content.ShortText.ColorAngle = 45F;
            BTNmodif.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Solid;
            BTNmodif.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNmodif.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            BTNmodif.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            BTNmodif.StateTracking.Back.Color1 = Color.FromArgb(85, 90, 220);
            BTNmodif.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            BTNmodif.StateTracking.Back.ColorAngle = 135F;
            BTNmodif.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            BTNmodif.StateTracking.Border.Rounding = 8F;
            BTNmodif.StateTracking.Content.ShortText.Color1 = Color.White;
            BTNmodif.StateTracking.Content.ShortText.Color2 = Color.White;
            BTNmodif.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            BTNmodif.TabIndex = 2;
            BTNmodif.Values.Text = "Modificar";
            BTNmodif.Click += btnModificar_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnNuevoProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoProducto.Location = new Point(470, 584);
            btnNuevoProducto.MaximumSize = new Size(95, 35);
            btnNuevoProducto.MinimumSize = new Size(95, 35);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.OverrideDefault.Back.Color1 = Color.FromArgb(60, 65, 190);
            btnNuevoProducto.OverrideDefault.Back.Color2 = Color.FromArgb(55, 55, 170);
            btnNuevoProducto.OverrideDefault.Back.ColorAngle = 45F;
            btnNuevoProducto.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Dashed;
            btnNuevoProducto.OverrideDefault.Border.Color1 = Color.FromArgb(60, 65, 190);
            btnNuevoProducto.OverrideDefault.Border.Color2 = Color.FromArgb(60, 60, 175);
            btnNuevoProducto.OverrideDefault.Border.ColorAngle = 45F;
            btnNuevoProducto.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNuevoProducto.OverrideDefault.Border.Rounding = 8F;
            btnNuevoProducto.OverrideDefault.Content.DrawFocus = InheritBool.False;
            btnNuevoProducto.Size = new Size(95, 35);
            btnNuevoProducto.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            btnNuevoProducto.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            btnNuevoProducto.StateCommon.Back.ColorAngle = 45F;
            btnNuevoProducto.StateCommon.Back.ColorStyle = PaletteColorStyle.Dashed;
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
            btnNuevoProducto.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            btnNuevoProducto.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            btnNuevoProducto.StateCommon.Content.ShortText.ColorAngle = 45F;
            btnNuevoProducto.StateCommon.Content.ShortText.ColorStyle = PaletteColorStyle.Solid;
            btnNuevoProducto.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoProducto.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            btnNuevoProducto.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            btnNuevoProducto.StateTracking.Back.Color1 = Color.FromArgb(85, 90, 220);
            btnNuevoProducto.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            btnNuevoProducto.StateTracking.Back.ColorAngle = 135F;
            btnNuevoProducto.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNuevoProducto.StateTracking.Border.Rounding = 8F;
            btnNuevoProducto.StateTracking.Content.ShortText.Color1 = Color.White;
            btnNuevoProducto.StateTracking.Content.ShortText.Color2 = Color.White;
            btnNuevoProducto.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnNuevoProducto.TabIndex = 2;
            btnNuevoProducto.ToolTipValues.Description = "Agregar elemento";
            btnNuevoProducto.Values.Text = "Agregar";
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(517, 175);
            textBox1.MinimumSize = new Size(171, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 31);
            textBox1.StateCommon.Back.Color1 = Color.FromArgb(48, 48, 56);
            textBox1.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            textBox1.StateCommon.Border.Color2 = Color.Gray;
            textBox1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            textBox1.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            textBox1.StateCommon.Border.Rounding = 18F;
            textBox1.StateCommon.Content.Color1 = Color.Gray;
            textBox1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cmbBoxCategorias
            // 
            cmbBoxCategorias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBoxCategorias.DropBackStyle = PaletteBackStyle.ControlCustom1;
            cmbBoxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCategorias.DropDownWidth = 171;
            cmbBoxCategorias.FormattingEnabled = true;
            cmbBoxCategorias.IntegralHeight = false;
            cmbBoxCategorias.Location = new Point(71, 33);
            cmbBoxCategorias.Name = "cmbBoxCategorias";
            cmbBoxCategorias.Palette = kryptonCustomPaletteBase1;
            cmbBoxCategorias.PaletteMode = PaletteMode.Custom;
            cmbBoxCategorias.Size = new Size(127, 22);
            cmbBoxCategorias.StateActive.ComboBox.Border.DrawBorders = PaletteDrawBorders.None;
            cmbBoxCategorias.TabIndex = 17;
            cmbBoxCategorias.TabStop = false;
            cmbBoxCategorias.SelectedIndexChanged += cmbBoxCategorias_SelectedIndexChanged;
            // 
            // lblCategorias
            // 
            lblCategorias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategorias.Location = new Point(99, 6);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(89, 26);
            lblCategorias.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblCategorias.StateCommon.ShortText.Color2 = Color.Gainsboro;
            lblCategorias.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategorias.StateCommon.ShortText.Image = (Image)resources.GetObject("lblCategorias.StateCommon.ShortText.Image");
            lblCategorias.StateCommon.ShortText.ImageAlign = PaletteRectangleAlign.Local;
            lblCategorias.StateCommon.ShortText.ImageStyle = PaletteImageStyle.CenterMiddle;
            lblCategorias.TabIndex = 18;
            lblCategorias.TabStop = false;
            lblCategorias.Values.Text = "Categorias";
            // 
            // btnPrimerCarga
            // 
            btnPrimerCarga.Enabled = false;
            btnPrimerCarga.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrimerCarga.Location = new Point(602, 335);
            btnPrimerCarga.Name = "btnPrimerCarga";
            btnPrimerCarga.Size = new Size(114, 81);
            btnPrimerCarga.TabIndex = 19;
            btnPrimerCarga.TabStop = false;
            btnPrimerCarga.Values.Text = "Primera Carga de Productos ";
            btnPrimerCarga.Visible = false;
            btnPrimerCarga.Click += btnPrimerCarga_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 11F);
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Location = new Point(224, 587);
            numericUpDown1.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 22);
            numericUpDown1.TabIndex = 20;
            numericUpDown1.TabStop = false;
            numericUpDown1.Value = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown1.Click += numericUpDown1_Click;
            // 
            // BtnCompra
            // 
            BtnCompra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnCompra.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCompra.Location = new Point(359, 584);
            BtnCompra.MaximumSize = new Size(84, 29);
            BtnCompra.MinimumSize = new Size(84, 29);
            BtnCompra.Name = "BtnCompra";
            BtnCompra.Size = new Size(84, 29);
            BtnCompra.TabIndex = 21;
            BtnCompra.TabStop = false;
            BtnCompra.Values.Text = "Comprar";
            BtnCompra.Click += BtnCompra_Click;
            // 
            // LblBienvenido
            // 
            LblBienvenido.AutoSize = false;
            LblBienvenido.Font = new Font("Segoe UI", 20F);
            LblBienvenido.Location = new Point(273, 63);
            LblBienvenido.Name = "LblBienvenido";
            LblBienvenido.Size = new Size(218, 88);
            LblBienvenido.StateCommon.Draw = InheritBool.True;
            LblBienvenido.StateCommon.DrawFocus = InheritBool.False;
            LblBienvenido.StateCommon.LongText.Color1 = Color.FromArgb(0, 0, 64);
            LblBienvenido.StateCommon.LongText.Color2 = Color.Navy;
            LblBienvenido.StateCommon.ShortText.Color1 = Color.FromArgb(0, 0, 64);
            LblBienvenido.StateCommon.ShortText.Color2 = Color.Navy;
            LblBienvenido.StateNormal.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            LblBienvenido.StateNormal.ShortText.Color2 = Color.LightGray;
            LblBienvenido.StateNormal.ShortText.ColorAngle = 45F;
            LblBienvenido.StateNormal.ShortText.ColorStyle = PaletteColorStyle.Dashed;
            LblBienvenido.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBienvenido.StateNormal.ShortText.MultiLine = InheritBool.True;
            LblBienvenido.StateNormal.ShortText.MultiLineH = PaletteRelativeAlign.Near;
            LblBienvenido.TabIndex = 0;
            LblBienvenido.TabStop = false;
            LblBienvenido.Values.Text = "Bienvenido \r\n              Thomas";
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
            rdiobtnHabilitado.Location = new Point(64, 6);
            rdiobtnHabilitado.Name = "rdiobtnHabilitado";
            rdiobtnHabilitado.PaletteMode = PaletteMode.Microsoft365BlackDarkMode;
            rdiobtnHabilitado.Size = new Size(116, 26);
            rdiobtnHabilitado.StateNormal.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdiobtnHabilitado.TabIndex = 0;
            rdiobtnHabilitado.TabStop = false;
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
            rdiobtnDeshabilitado.Location = new Point(64, 31);
            rdiobtnDeshabilitado.Name = "rdiobtnDeshabilitado";
            rdiobtnDeshabilitado.PaletteMode = PaletteMode.Microsoft365BlackDarkMode;
            rdiobtnDeshabilitado.Size = new Size(141, 26);
            rdiobtnDeshabilitado.StateNormal.ShortText.Font = new Font("Segoe UI", 12F);
            rdiobtnDeshabilitado.TabIndex = 0;
            rdiobtnDeshabilitado.TabStop = false;
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
            rdiobtnTodos.Location = new Point(64, 56);
            rdiobtnTodos.Name = "rdiobtnTodos";
            rdiobtnTodos.PaletteMode = PaletteMode.Microsoft365BlackDarkMode;
            rdiobtnTodos.Size = new Size(78, 26);
            rdiobtnTodos.StateCommon.ShortText.Font = new Font("Segoe UI", 12F);
            rdiobtnTodos.TabIndex = 0;
            rdiobtnTodos.TabStop = false;
            rdiobtnTodos.Values.Text = "Todos";
            rdiobtnTodos.CheckedChanged += rdiobtnTodos_CheckedChanged;
            // 
            // BtnRfrs
            // 
            BtnRfrs.Font = new Font("Wingdings 3", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 2);
            BtnRfrs.Location = new Point(512, 351);
            BtnRfrs.Name = "BtnRfrs";
            BtnRfrs.Size = new Size(30, 30);
            BtnRfrs.TabIndex = 27;
            BtnRfrs.TabStop = false;
            BtnRfrs.Values.Text = "Q";
            BtnRfrs.Visible = false;
            BtnRfrs.Click += button1_Click;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.mini_search;
            kryptonPictureBox1.Location = new Point(748, 177);
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
            label1.Location = new Point(162, 176);
            label1.Name = "label1";
            label1.Palette = kryptonCustomPaletteBase1;
            label1.PaletteMode = PaletteMode.Custom;
            label1.Size = new Size(115, 29);
            label1.StateCommon.ShortText.Color1 = Color.FromArgb(120, 140, 200);
            label1.StateCommon.ShortText.Color2 = Color.FromArgb(120, 140, 200);
            label1.StateCommon.ShortText.ColorAngle = 45F;
            label1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.TabIndex = 0;
            label1.TabStop = false;
            label1.Values.Text = "Productos";
            // 
            // menubutton
            // 
            menubutton.Cursor = Cursors.Hand;
            menubutton.Location = new Point(3, 3);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(52, 49);
            menubutton.TabIndex = 1;
            menubutton.TabStop = false;
            menubutton.Click += menubutton_Click;
            menubutton.MouseLeave += menubutton_MouseLeave;
            menubutton.MouseHover += FormProducto_MouseHover;
            // 
            // panelhabilitados
            // 
            panelhabilitados.BackColor = Color.FromArgb(50, 50, 56);
            panelhabilitados.Controls.Add(rdiobtnTodos);
            panelhabilitados.Controls.Add(rdiobtnDeshabilitado);
            panelhabilitados.Controls.Add(rdiobtnHabilitado);
            panelhabilitados.Location = new Point(0, 132);
            panelhabilitados.Margin = new Padding(0);
            panelhabilitados.Name = "panelhabilitados";
            panelhabilitados.Size = new Size(223, 86);
            panelhabilitados.TabIndex = 33;
            // 
            // panelcategoria
            // 
            panelcategoria.BackColor = Color.FromArgb(50, 50, 56);
            panelcategoria.Controls.Add(kryptonPictureBox2);
            panelcategoria.Controls.Add(lblCategorias);
            panelcategoria.Controls.Add(cmbBoxCategorias);
            panelcategoria.Location = new Point(0, 68);
            panelcategoria.Margin = new Padding(0);
            panelcategoria.Name = "panelcategoria";
            panelcategoria.Size = new Size(219, 64);
            panelcategoria.TabIndex = 0;
            // 
            // kryptonPictureBox2
            // 
            kryptonPictureBox2.Cursor = Cursors.Hand;
            kryptonPictureBox2.Image = Properties.Resources.micro_cate;
            kryptonPictureBox2.Location = new Point(71, 6);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(537, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(56, 56, 68);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(controlBox1);
            panel5.Controls.Add(menubutton);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(825, 54);
            panel5.TabIndex = 0;
            panel5.MouseDown += FormProducto_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 16F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(59, 9);
            label2.Name = "label2";
            label2.Size = new Size(333, 39);
            label2.TabIndex = 0;
            label2.Text = "Sistema de Control de Stock";
            label2.MouseDown += FormProducto_MouseDown;
            // 
            // controlBox1
            // 
            controlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBox1.BackColor = Color.FromArgb(56, 56, 64);
            controlBox1.CloseHoverColor = Color.FromArgb(230, 17, 35);
            controlBox1.DefaultLocation = false;
            controlBox1.EnableHoverHighlight = true;
            controlBox1.EnableMaximizeButton = false;
            controlBox1.EnableMinimizeButton = true;
            controlBox1.ForeColor = Color.FromArgb(155, 155, 155);
            controlBox1.Location = new Point(723, 15);
            controlBox1.MaximizeHoverColor = Color.FromArgb(74, 74, 74);
            controlBox1.MinimizeHoverColor = Color.FromArgb(63, 63, 65);
            controlBox1.Name = "controlBox1";
            controlBox1.RightToLeft = RightToLeft.No;
            controlBox1.Size = new Size(90, 25);
            controlBox1.TabIndex = 0;
            controlBox1.TabStop = false;
            controlBox1.Text = "controlBox1";
            // 
            // menupanel
            // 
            menupanel.BackColor = Color.FromArgb(56, 56, 68);
            menupanel.Controls.Add(panelfilter);
            menupanel.Controls.Add(panelUsuario1);
            menupanel.Controls.Add(panel2);
            menupanel.Dock = DockStyle.Left;
            menupanel.Location = new Point(0, 54);
            menupanel.Margin = new Padding(0);
            menupanel.MaximumSize = new Size(221, 581);
            menupanel.MinimumSize = new Size(53, 581);
            menupanel.Name = "menupanel";
            menupanel.Size = new Size(221, 581);
            menupanel.TabIndex = 0;
            // 
            // panelfilter
            // 
            panelfilter.BackColor = Color.FromArgb(70, 70, 80);
            panelfilter.Controls.Add(kryptonButton1);
            panelfilter.Controls.Add(panelcategoria);
            panelfilter.Controls.Add(panelhabilitados);
            panelfilter.Location = new Point(0, 0);
            panelfilter.Margin = new Padding(0);
            panelfilter.MaximumSize = new Size(221, 216);
            panelfilter.MinimumSize = new Size(221, 63);
            panelfilter.Name = "panelfilter";
            panelfilter.Size = new Size(221, 63);
            panelfilter.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            kryptonButton1.BackColor = Color.FromArgb(56, 56, 68);
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.FlatAppearance.BorderColor = Color.FromArgb(56, 56, 64);
            kryptonButton1.FlatAppearance.BorderSize = 0;
            kryptonButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 72);
            kryptonButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 48);
            kryptonButton1.FlatStyle = FlatStyle.Flat;
            kryptonButton1.Font = new Font("Segoe UI", 12F);
            kryptonButton1.ForeColor = Color.Silver;
            kryptonButton1.Image = Properties.Resources.medium_filter;
            kryptonButton1.ImageAlign = ContentAlignment.MiddleLeft;
            kryptonButton1.Location = new Point(0, 0);
            kryptonButton1.Margin = new Padding(0);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(224, 68);
            kryptonButton1.TabIndex = 5;
            kryptonButton1.Text = "Filtrar";
            kryptonButton1.UseVisualStyleBackColor = false;
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // panelUsuario1
            // 
            panelUsuario1.Controls.Add(button1);
            panelUsuario1.Controls.Add(btninformacion);
            panelUsuario1.Controls.Add(btnchangepass);
            panelUsuario1.Location = new Point(0, 63);
            panelUsuario1.Margin = new Padding(0);
            panelUsuario1.MaximumSize = new Size(221, 196);
            panelUsuario1.MinimumSize = new Size(221, 63);
            panelUsuario1.Name = "panelUsuario1";
            panelUsuario1.Size = new Size(221, 63);
            panelUsuario1.TabIndex = 32;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(56, 56, 68);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(56, 56, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 72);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 48);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.Silver;
            button1.Image = Properties.Resources.user;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(224, 65);
            button1.TabIndex = 6;
            button1.Text = "Usuario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btninformacion
            // 
            btninformacion.BackColor = Color.FromArgb(50, 50, 56);
            btninformacion.Cursor = Cursors.Hand;
            btninformacion.FlatAppearance.BorderColor = Color.FromArgb(56, 56, 64);
            btninformacion.FlatAppearance.BorderSize = 0;
            btninformacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 72);
            btninformacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 48);
            btninformacion.FlatStyle = FlatStyle.Flat;
            btninformacion.Font = new Font("Segoe UI", 10F);
            btninformacion.ForeColor = Color.Silver;
            btninformacion.Image = Properties.Resources.mini_infouser;
            btninformacion.ImageAlign = ContentAlignment.MiddleLeft;
            btninformacion.Location = new Point(0, 65);
            btninformacion.Margin = new Padding(0);
            btninformacion.Name = "btninformacion";
            btninformacion.Size = new Size(224, 65);
            btninformacion.TabIndex = 8;
            btninformacion.Text = "Info. de usuario";
            btninformacion.UseVisualStyleBackColor = false;
            btninformacion.Click += btninformacion_Click;
            // 
            // btnchangepass
            // 
            btnchangepass.BackColor = Color.FromArgb(50, 50, 56);
            btnchangepass.Cursor = Cursors.Hand;
            btnchangepass.FlatAppearance.BorderColor = Color.FromArgb(56, 56, 64);
            btnchangepass.FlatAppearance.BorderSize = 0;
            btnchangepass.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 72);
            btnchangepass.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 48);
            btnchangepass.FlatStyle = FlatStyle.Flat;
            btnchangepass.Font = new Font("Segoe UI", 10F);
            btnchangepass.ForeColor = Color.Silver;
            btnchangepass.Image = Properties.Resources.mini_changepass;
            btnchangepass.ImageAlign = ContentAlignment.MiddleLeft;
            btnchangepass.Location = new Point(0, 130);
            btnchangepass.Margin = new Padding(0);
            btnchangepass.Name = "btnchangepass";
            btnchangepass.Size = new Size(224, 65);
            btnchangepass.TabIndex = 36;
            btnchangepass.Text = "Cambiar contraseña";
            btnchangepass.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnlogout);
            panel2.Location = new Point(0, 126);
            panel2.Margin = new Padding(0);
            panel2.MaximumSize = new Size(221, 63);
            panel2.MinimumSize = new Size(221, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 63);
            panel2.TabIndex = 35;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(56, 56, 68);
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
            btnlogout.Location = new Point(0, 0);
            btnlogout.Margin = new Padding(0);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(224, 68);
            btnlogout.TabIndex = 10;
            btnlogout.Text = "Cerrar sesión";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // nuevoToolStripMenuItem1
            // 
            nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            nuevoToolStripMenuItem1.Size = new Size(180, 22);
            nuevoToolStripMenuItem1.Text = "Nuevo";
            // 
            // Usertimer
            // 
            Usertimer.Interval = 15;
            Usertimer.Tick += Usertimer_Tick;
            // 
            // filtertimer
            // 
            filtertimer.Interval = 15;
            filtertimer.Tick += filtertimer_Tick;
            // 
            // datagridroudergropu
            // 
            datagridroudergropu.Alpha = 20;
            datagridroudergropu.BackColor = Color.Transparent;
            datagridroudergropu.Background = true;
            datagridroudergropu.Background_WidthPen = 3F;
            datagridroudergropu.BackgroundPen = true;
            datagridroudergropu.ColorBackground = Color.FromArgb(48, 48, 56);
            datagridroudergropu.ColorBackground_1 = Color.FromArgb(48, 48, 56);
            datagridroudergropu.ColorBackground_2 = Color.FromArgb(48, 48, 56);
            datagridroudergropu.ColorBackground_Pen = Color.FromArgb(56, 56, 56);
            datagridroudergropu.ColorLighting = Color.FromArgb(56, 56, 56);
            datagridroudergropu.ColorPen_1 = Color.FromArgb(56, 56, 56);
            datagridroudergropu.ColorPen_2 = Color.FromArgb(255, 192, 192);
            datagridroudergropu.Controls.Add(dataGridViewProducto);
            datagridroudergropu.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            datagridroudergropu.ForeColor = Color.FromArgb(245, 245, 245);
            datagridroudergropu.Lighting = false;
            datagridroudergropu.LinearGradient_Background = false;
            datagridroudergropu.LinearGradientPen = false;
            datagridroudergropu.Location = new Point(160, 211);
            datagridroudergropu.Name = "datagridroudergropu";
            datagridroudergropu.PenWidth = 15;
            datagridroudergropu.RGB = false;
            datagridroudergropu.Rounding = true;
            datagridroudergropu.RoundingInt = 10;
            datagridroudergropu.Size = new Size(617, 359);
            datagridroudergropu.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            datagridroudergropu.TabIndex = 32;
            datagridroudergropu.Tag = "Cyber";
            datagridroudergropu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            datagridroudergropu.Timer_RGB = 300;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(30, 30, 32);
            ClientSize = new Size(825, 635);
            ControlBox = false;
            Controls.Add(menupanel);
            Controls.Add(btnPrimerCarga);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(BtnRfrs);
            Controls.Add(LblBienvenido);
            Controls.Add(BtnCompra);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(btnNuevoProducto);
            Controls.Add(BTNmodif);
            Controls.Add(BTNdelete);
            Controls.Add(panel5);
            Controls.Add(datagridroudergropu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormProducto";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            TitleStyle = KryptonFormTitleStyle.Classic;
            Activated += FormProducto_Activated;
            MouseDown += FormProducto_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
            contextMenuRow.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbBoxCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)menubutton).EndInit();
            panelhabilitados.ResumeLayout(false);
            panelhabilitados.PerformLayout();
            panelcategoria.ResumeLayout(false);
            panelcategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            menupanel.ResumeLayout(false);
            panelfilter.ResumeLayout(false);
            panelUsuario1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            datagridroudergropu.ResumeLayout(false);
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
        private KryptonPictureBox menubutton;
        private System.Windows.Forms.Timer sidebartimer;
        private Panel panelcategoria;
        private PictureBox pictureBox1;
        private Panel panelhabilitados;
        private KryptonPictureBox kryptonPictureBox2;
        private Panel panel5;
        private FlowLayoutPanel menupanel;
        private FlowLayoutPanel panelfilter;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ContextMenuStrip contextMenuRow;
        private ToolStripMenuItem OrdenarToolStipMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private Button kryptonButton1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem detallesToolStripMenuItem;
        private ToolStripMenuItem refrescarToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem ordenarToolStripMenuItem;
        private DataGridViewTextBoxColumn ColumnNombreProducto;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnStock;
        private DataGridViewTextBoxColumn ColumnCompras;
        private DataGridViewTextBoxColumn ColumnVentas;
        private DataGridViewCheckBoxColumn ColumnHabilitado;
        private ToolStripMenuItem nuevoToolStripMenuItem1;
        private ToolStripMenuItem ordenarToolStripMenuItem1;
        private ToolStripMenuItem nuevoToolStrip;
        private ToolStripMenuItem refrescarToolStripMenuItem1;
        private ToolStripComboBox toolStripComboBox1;
        private Label label2;
        private Button btnchangepass;
        private Button btninformacion;
        private Button button1;
        private FlowLayoutPanel panelUsuario1;
        private System.Windows.Forms.Timer Usertimer;
        private System.Windows.Forms.Timer filtertimer;
        private Button btnlogout;
        private Panel panel2;
        private ReaLTaiizor.Controls.CyberGroupBox datagridroudergropu;
    }
}