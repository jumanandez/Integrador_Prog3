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
			cmbBoxCategorias = new ComboBox();
			txtNombreProducto = new TextBox();
			lblTitulo = new Label();
			lblNombreProducto = new Label();
			lblCategoria = new Label();
			lblNuevoProducto = new Label();
			btnCargarProducto = new Button();
			btnRefrescar = new Button();
			lblProductos = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewProducto
			// 
			dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewProducto.Location = new Point(333, 164);
			dataGridViewProducto.Name = "dataGridViewProducto";
			dataGridViewProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewProducto.Size = new Size(455, 257);
			dataGridViewProducto.TabIndex = 0;
			// 
			// cmbBoxCategorias
			// 
			cmbBoxCategorias.FormattingEnabled = true;
			cmbBoxCategorias.Location = new Point(12, 207);
			cmbBoxCategorias.Name = "cmbBoxCategorias";
			cmbBoxCategorias.Size = new Size(171, 23);
			cmbBoxCategorias.TabIndex = 1;
			cmbBoxCategorias.SelectedIndexChanged += cmbBoxCategorias_SelectedIndexChanged;
			// 
			// txtNombreProducto
			// 
			txtNombreProducto.Location = new Point(12, 275);
			txtNombreProducto.Name = "txtNombreProducto";
			txtNombreProducto.Size = new Size(171, 23);
			txtNombreProducto.TabIndex = 2;
			// 
			// lblTitulo
			// 
			lblTitulo.AutoSize = true;
			lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitulo.Location = new Point(12, 9);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(289, 30);
			lblTitulo.TabIndex = 3;
			lblTitulo.Text = "Sistema de Control de Stock";
			// 
			// lblNombreProducto
			// 
			lblNombreProducto.AutoSize = true;
			lblNombreProducto.Location = new Point(12, 257);
			lblNombreProducto.Name = "lblNombreProducto";
			lblNombreProducto.Size = new Size(51, 15);
			lblNombreProducto.TabIndex = 4;
			lblNombreProducto.Text = "Nombre";
			// 
			// lblCategoria
			// 
			lblCategoria.AutoSize = true;
			lblCategoria.Location = new Point(12, 189);
			lblCategoria.Name = "lblCategoria";
			lblCategoria.Size = new Size(58, 15);
			lblCategoria.TabIndex = 5;
			lblCategoria.Text = "Categoria";
			// 
			// lblNuevoProducto
			// 
			lblNuevoProducto.AutoSize = true;
			lblNuevoProducto.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNuevoProducto.Location = new Point(12, 148);
			lblNuevoProducto.Name = "lblNuevoProducto";
			lblNuevoProducto.Size = new Size(171, 30);
			lblNuevoProducto.TabIndex = 6;
			lblNuevoProducto.Text = "Nuevo Producto";
			// 
			// btnCargarProducto
			// 
			btnCargarProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCargarProducto.Location = new Point(12, 313);
			btnCargarProducto.Name = "btnCargarProducto";
			btnCargarProducto.Size = new Size(80, 29);
			btnCargarProducto.TabIndex = 7;
			btnCargarProducto.Text = "Cargar";
			btnCargarProducto.UseVisualStyleBackColor = true;
			btnCargarProducto.Click += btnCargarProducto_Click;
			// 
			// btnRefrescar
			// 
			btnRefrescar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnRefrescar.Location = new Point(708, 129);
			btnRefrescar.Name = "btnRefrescar";
			btnRefrescar.Size = new Size(80, 29);
			btnRefrescar.TabIndex = 8;
			btnRefrescar.Text = "Refrescar";
			btnRefrescar.UseVisualStyleBackColor = true;
			btnRefrescar.Click += btnRefrescar_Click;
			// 
			// lblProductos
			// 
			lblProductos.AutoSize = true;
			lblProductos.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblProductos.Location = new Point(333, 131);
			lblProductos.Name = "lblProductos";
			lblProductos.Size = new Size(111, 30);
			lblProductos.TabIndex = 9;
			lblProductos.Text = "Productos";
			// 
			// FormProducto
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblProductos);
			Controls.Add(btnRefrescar);
			Controls.Add(btnCargarProducto);
			Controls.Add(lblNuevoProducto);
			Controls.Add(lblCategoria);
			Controls.Add(lblNombreProducto);
			Controls.Add(lblTitulo);
			Controls.Add(txtNombreProducto);
			Controls.Add(cmbBoxCategorias);
			Controls.Add(dataGridViewProducto);
			Name = "FormProducto";
			Text = "FormProducto";
			Load += FormProducto_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewProducto;
		private ComboBox cmbBoxCategorias;
		private TextBox txtNombreProducto;
		private Label lblTitulo;
		private Label lblNombreProducto;
		private Label lblCategoria;
		private Label lblNuevoProducto;
		private Button btnCargarProducto;
		private Button btnRefrescar;
		private Label lblProductos;
	}
}