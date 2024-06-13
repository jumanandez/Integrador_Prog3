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
			dataGridViewProducto = new DataGridView();
			ColumnNombreProducto = new DataGridViewTextBoxColumn();
			ColumnCategoria = new DataGridViewTextBoxColumn();
			ColumnStock = new DataGridViewTextBoxColumn();
			ColumnCompras = new DataGridViewTextBoxColumn();
			ColumnVentas = new DataGridViewTextBoxColumn();
			ColumnHabilitado = new DataGridViewCheckBoxColumn();
			lblTitulo = new Label();
			lblProductos = new Label();
			BTNdelete = new Button();
			BTNmodif = new Button();
			btnNuevoProducto = new Button();
			textBox1 = new TextBox();
			LblBuscar = new Label();
			cmbBoxCategorias = new ComboBox();
			lblCategorias = new Label();
			btnPrimerCarga = new Button();
			numericUpDown1 = new NumericUpDown();
			BtnCompra = new Button();
			pictureBox1 = new PictureBox();
			LblBienvenido = new Label();
			rdiobtnHabilitado = new RadioButton();
			rdiobtnDeshabilitado = new RadioButton();
			rdiobtnTodos = new RadioButton();
			BtnRfrs = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewProducto
			// 
			dataGridViewProducto.AllowUserToAddRows = false;
			dataGridViewProducto.AllowUserToDeleteRows = false;
			dataGridViewProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			dataGridViewProducto.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewProducto.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
			dataGridViewProducto.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewProducto.Columns.AddRange(new DataGridViewColumn[] { ColumnNombreProducto, ColumnCategoria, ColumnStock, ColumnCompras, ColumnVentas, ColumnHabilitado });
			dataGridViewProducto.Location = new Point(243, 164);
			dataGridViewProducto.MinimumSize = new Size(538, 257);
			dataGridViewProducto.Name = "dataGridViewProducto";
			dataGridViewProducto.ReadOnly = true;
			dataGridViewProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewProducto.Size = new Size(564, 257);
			dataGridViewProducto.TabIndex = 0;
			dataGridViewProducto.ColumnHeaderMouseClick += dataGridViewProducto_ColumnHeaderMouseClick;
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
			ColumnCategoria.Width = 130;
			// 
			// ColumnStock
			// 
			ColumnStock.HeaderText = "Stock";
			ColumnStock.Name = "ColumnStock";
			ColumnStock.ReadOnly = true;
			ColumnStock.Width = 50;
			// 
			// ColumnCompras
			// 
			ColumnCompras.HeaderText = "Compras";
			ColumnCompras.Name = "ColumnCompras";
			ColumnCompras.ReadOnly = true;
			ColumnCompras.Width = 60;
			// 
			// ColumnVentas
			// 
			ColumnVentas.HeaderText = "Ventas";
			ColumnVentas.Name = "ColumnVentas";
			ColumnVentas.ReadOnly = true;
			ColumnVentas.Width = 55;
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
			// lblTitulo
			// 
			lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			lblTitulo.AutoSize = true;
			lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitulo.Location = new Point(12, 9);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(289, 30);
			lblTitulo.TabIndex = 3;
			lblTitulo.Text = "Sistema de Control de Stock";
			// 
			// lblProductos
			// 
			lblProductos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			lblProductos.AutoSize = true;
			lblProductos.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblProductos.Location = new Point(246, 131);
			lblProductos.Name = "lblProductos";
			lblProductos.Size = new Size(111, 30);
			lblProductos.TabIndex = 9;
			lblProductos.Text = "Productos";
			// 
			// BTNdelete
			// 
			BTNdelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			BTNdelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BTNdelete.Location = new Point(701, 427);
			BTNdelete.MaximumSize = new Size(84, 29);
			BTNdelete.MinimumSize = new Size(84, 29);
			BTNdelete.Name = "BTNdelete";
			BTNdelete.Size = new Size(84, 29);
			BTNdelete.TabIndex = 11;
			BTNdelete.Text = "Eliminar";
			BTNdelete.UseVisualStyleBackColor = true;
			BTNdelete.Click += BTNdelete_Click;
			// 
			// BTNmodif
			// 
			BTNmodif.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			BTNmodif.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BTNmodif.Location = new Point(611, 427);
			BTNmodif.MaximumSize = new Size(84, 29);
			BTNmodif.MinimumSize = new Size(84, 29);
			BTNmodif.Name = "BTNmodif";
			BTNmodif.Size = new Size(84, 29);
			BTNmodif.TabIndex = 12;
			BTNmodif.Text = "Modificar";
			BTNmodif.UseVisualStyleBackColor = true;
			BTNmodif.Click += btnModificar_Click;
			// 
			// btnNuevoProducto
			// 
			btnNuevoProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			btnNuevoProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnNuevoProducto.Location = new Point(521, 427);
			btnNuevoProducto.MaximumSize = new Size(84, 29);
			btnNuevoProducto.MinimumSize = new Size(84, 29);
			btnNuevoProducto.Name = "btnNuevoProducto";
			btnNuevoProducto.Size = new Size(84, 29);
			btnNuevoProducto.TabIndex = 14;
			btnNuevoProducto.Text = "Nuevo";
			btnNuevoProducto.UseVisualStyleBackColor = true;
			btnNuevoProducto.Click += btnNuevoProducto_Click;
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Location = new Point(12, 187);
			textBox1.MaximumSize = new Size(171, 23);
			textBox1.MinimumSize = new Size(171, 23);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(171, 23);
			textBox1.TabIndex = 15;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// LblBuscar
			// 
			LblBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			LblBuscar.AutoSize = true;
			LblBuscar.Font = new Font("Segoe UI", 11F);
			LblBuscar.Location = new Point(12, 164);
			LblBuscar.Name = "LblBuscar";
			LblBuscar.Size = new Size(52, 20);
			LblBuscar.TabIndex = 16;
			LblBuscar.Text = "Buscar";
			// 
			// cmbBoxCategorias
			// 
			cmbBoxCategorias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			cmbBoxCategorias.FormattingEnabled = true;
			cmbBoxCategorias.Location = new Point(12, 244);
			cmbBoxCategorias.MaximumSize = new Size(171, 0);
			cmbBoxCategorias.MinimumSize = new Size(171, 0);
			cmbBoxCategorias.Name = "cmbBoxCategorias";
			cmbBoxCategorias.Size = new Size(171, 23);
			cmbBoxCategorias.TabIndex = 17;
			cmbBoxCategorias.SelectedIndexChanged += cmbBoxCategorias_SelectedIndexChanged;
			// 
			// lblCategorias
			// 
			lblCategorias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			lblCategorias.AutoSize = true;
			lblCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblCategorias.Location = new Point(12, 221);
			lblCategorias.Name = "lblCategorias";
			lblCategorias.Size = new Size(80, 20);
			lblCategorias.TabIndex = 18;
			lblCategorias.Text = "Categorias";
			// 
			// btnPrimerCarga
			// 
			btnPrimerCarga.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnPrimerCarga.Location = new Point(667, 41);
			btnPrimerCarga.Name = "btnPrimerCarga";
			btnPrimerCarga.Size = new Size(114, 81);
			btnPrimerCarga.TabIndex = 19;
			btnPrimerCarga.Text = "Primera Carga de Productos ";
			btnPrimerCarga.UseVisualStyleBackColor = true;
			btnPrimerCarga.Click += btnPrimerCarga_Click;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Font = new Font("Segoe UI", 11F);
			numericUpDown1.Location = new Point(333, 430);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(120, 27);
			numericUpDown1.TabIndex = 20;
			numericUpDown1.Click += numericUpDown1_Click;
			// 
			// BtnCompra
			// 
			BtnCompra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			BtnCompra.Enabled = false;
			BtnCompra.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnCompra.Location = new Point(243, 429);
			BtnCompra.MaximumSize = new Size(84, 29);
			BtnCompra.MinimumSize = new Size(84, 29);
			BtnCompra.Name = "BtnCompra";
			BtnCompra.Size = new Size(84, 29);
			BtnCompra.TabIndex = 21;
			BtnCompra.Text = "Comprar";
			BtnCompra.UseVisualStyleBackColor = true;
			BtnCompra.Click += BtnCompra_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.LogoFashero;
			pictureBox1.Location = new Point(19, 44);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(173, 110);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 22;
			pictureBox1.TabStop = false;
			// 
			// LblBienvenido
			// 
			LblBienvenido.AutoSize = true;
			LblBienvenido.Font = new Font("Segoe UI", 20F);
			LblBienvenido.Location = new Point(333, 9);
			LblBienvenido.Name = "LblBienvenido";
			LblBienvenido.Size = new Size(90, 37);
			LblBienvenido.TabIndex = 23;
			LblBienvenido.Text = "label1";
			// 
			// rdiobtnHabilitado
			// 
			rdiobtnHabilitado.AutoSize = true;
			rdiobtnHabilitado.Location = new Point(12, 273);
			rdiobtnHabilitado.Name = "rdiobtnHabilitado";
			rdiobtnHabilitado.Size = new Size(85, 19);
			rdiobtnHabilitado.TabIndex = 24;
			rdiobtnHabilitado.Text = "Habilitados";
			rdiobtnHabilitado.UseVisualStyleBackColor = true;
			rdiobtnHabilitado.CheckedChanged += rdiobtnHabilitado_CheckedChanged;
			// 
			// rdiobtnDeshabilitado
			// 
			rdiobtnDeshabilitado.AutoSize = true;
			rdiobtnDeshabilitado.Location = new Point(12, 298);
			rdiobtnDeshabilitado.Name = "rdiobtnDeshabilitado";
			rdiobtnDeshabilitado.Size = new Size(102, 19);
			rdiobtnDeshabilitado.TabIndex = 25;
			rdiobtnDeshabilitado.Text = "Deshabilitados";
			rdiobtnDeshabilitado.UseVisualStyleBackColor = true;
			rdiobtnDeshabilitado.CheckedChanged += rdiobtnDeshabilitado_CheckedChanged;
			// 
			// rdiobtnTodos
			// 
			rdiobtnTodos.AutoSize = true;
			rdiobtnTodos.Checked = true;
			rdiobtnTodos.Location = new Point(12, 323);
			rdiobtnTodos.Name = "rdiobtnTodos";
			rdiobtnTodos.Size = new Size(56, 19);
			rdiobtnTodos.TabIndex = 26;
			rdiobtnTodos.TabStop = true;
			rdiobtnTodos.Text = "Todos";
			rdiobtnTodos.UseVisualStyleBackColor = true;
			rdiobtnTodos.CheckedChanged += rdiobtnTodos_CheckedChanged;
			// 
			// BtnRfrs
			// 
			BtnRfrs.Font = new Font("Wingdings 3", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 2);
			BtnRfrs.Location = new Point(777, 131);
			BtnRfrs.Name = "BtnRfrs";
			BtnRfrs.Size = new Size(30, 30);
			BtnRfrs.TabIndex = 27;
			BtnRfrs.Text = "Q";
			BtnRfrs.UseVisualStyleBackColor = true;
			BtnRfrs.Click += button1_Click;
			// 
			// FormProducto
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(814, 474);
			Controls.Add(BtnRfrs);
			Controls.Add(rdiobtnTodos);
			Controls.Add(rdiobtnDeshabilitado);
			Controls.Add(rdiobtnHabilitado);
			Controls.Add(LblBienvenido);
			Controls.Add(pictureBox1);
			Controls.Add(BtnCompra);
			Controls.Add(numericUpDown1);
			Controls.Add(btnPrimerCarga);
			Controls.Add(lblCategorias);
			Controls.Add(cmbBoxCategorias);
			Controls.Add(LblBuscar);
			Controls.Add(textBox1);
			Controls.Add(btnNuevoProducto);
			Controls.Add(BTNmodif);
			Controls.Add(BTNdelete);
			Controls.Add(lblProductos);
			Controls.Add(lblTitulo);
			Controls.Add(dataGridViewProducto);
			MaximizeBox = false;
			Name = "FormProducto";
			StartPosition = FormStartPosition.CenterParent;
			Text = "FormProducto";
			Activated += FormProducto_Activated;
			((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
		#endregion

        private DataGridView dataGridViewProducto;
		private Label lblTitulo;
		private Label lblProductos;
        private Button BTNdelete;
        private Button BTNmodif;
		private Button btnNuevoProducto;
        private TextBox textBox1;
        private Label LblBuscar;
		private ComboBox cmbBoxCategorias;
		private Label lblCategorias;
		private Button btnPrimerCarga;
        private NumericUpDown numericUpDown1;
        private Button BtnCompra;
        private PictureBox pictureBox1;
        private Label LblBienvenido;
		private RadioButton rdiobtnHabilitado;
		private RadioButton rdiobtnDeshabilitado;
		private RadioButton rdiobtnTodos;
        private Button BtnRfrs;
		private DataGridViewTextBoxColumn ColumnNombreProducto;
		private DataGridViewTextBoxColumn ColumnCategoria;
		private DataGridViewTextBoxColumn ColumnStock;
		private DataGridViewTextBoxColumn ColumnCompras;
		private DataGridViewTextBoxColumn ColumnVentas;
		private DataGridViewCheckBoxColumn ColumnHabilitado;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private DataGridViewTextBoxColumn Column1;
    }
}