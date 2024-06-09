﻿namespace WinForm
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
			ColumnProductoId = new DataGridViewTextBoxColumn();
			ColumnNombreProducto = new DataGridViewTextBoxColumn();
			ColumnCategoria = new DataGridViewTextBoxColumn();
			ColumnHabilitado = new DataGridViewCheckBoxColumn();
			cmbBoxCategorias = new ComboBox();
			txtNombreProducto = new TextBox();
			lblTitulo = new Label();
			lblNombreProducto = new Label();
			lblCategoria = new Label();
			lblNuevoProducto = new Label();
			btnCargarProducto = new Button();
			btnRefrescar = new Button();
			lblProductos = new Label();
			BTNdelete = new Button();
			BTNmodif = new Button();
			panel1 = new Panel();
			btnNuevoProducto = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridViewProducto
			// 
			dataGridViewProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewProducto.Columns.AddRange(new DataGridViewColumn[] { ColumnProductoId, ColumnNombreProducto, ColumnCategoria, ColumnHabilitado });
			dataGridViewProducto.Location = new Point(333, 164);
			dataGridViewProducto.Name = "dataGridViewProducto";
			dataGridViewProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewProducto.Size = new Size(455, 257);
			dataGridViewProducto.TabIndex = 0;
			// 
			// ColumnProductoId
			// 
			ColumnProductoId.DataPropertyName = "ProductoId";
			ColumnProductoId.HeaderText = "ID Producto";
			ColumnProductoId.Name = "ColumnProductoId";
			ColumnProductoId.ReadOnly = true;
			// 
			// ColumnNombreProducto
			// 
			ColumnNombreProducto.DataPropertyName = "Nombre";
			ColumnNombreProducto.HeaderText = "Nombre";
			ColumnNombreProducto.Name = "ColumnNombreProducto";
			ColumnNombreProducto.ReadOnly = true;
			// 
			// ColumnCategoria
			// 
			ColumnCategoria.DataPropertyName = "Categoria";
			ColumnCategoria.HeaderText = "Categoria";
			ColumnCategoria.Name = "ColumnCategoria";
			ColumnCategoria.ReadOnly = true;
			// 
			// ColumnHabilitado
			// 
			ColumnHabilitado.HeaderText = "Habilitado";
			ColumnHabilitado.Name = "ColumnHabilitado";
			// 
			// cmbBoxCategorias
			// 
			cmbBoxCategorias.FormattingEnabled = true;
			cmbBoxCategorias.Location = new Point(18, 77);
			cmbBoxCategorias.Name = "cmbBoxCategorias";
			cmbBoxCategorias.Size = new Size(171, 23);
			cmbBoxCategorias.TabIndex = 1;
			cmbBoxCategorias.SelectedIndexChanged += cmbBoxCategorias_SelectedIndexChanged;
			// 
			// txtNombreProducto
			// 
			txtNombreProducto.Location = new Point(18, 148);
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
			lblNombreProducto.Location = new Point(18, 130);
			lblNombreProducto.Name = "lblNombreProducto";
			lblNombreProducto.Size = new Size(51, 15);
			lblNombreProducto.TabIndex = 4;
			lblNombreProducto.Text = "Nombre";
			// 
			// lblCategoria
			// 
			lblCategoria.AutoSize = true;
			lblCategoria.Location = new Point(18, 59);
			lblCategoria.Name = "lblCategoria";
			lblCategoria.Size = new Size(58, 15);
			lblCategoria.TabIndex = 5;
			lblCategoria.Text = "Categoria";
			// 
			// lblNuevoProducto
			// 
			lblNuevoProducto.AutoSize = true;
			lblNuevoProducto.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNuevoProducto.Location = new Point(18, 20);
			lblNuevoProducto.Name = "lblNuevoProducto";
			lblNuevoProducto.Size = new Size(171, 30);
			lblNuevoProducto.TabIndex = 6;
			lblNuevoProducto.Text = "Nuevo Producto";
			// 
			// btnCargarProducto
			// 
			btnCargarProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCargarProducto.Location = new Point(18, 186);
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
			// BTNdelete
			// 
			BTNdelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BTNdelete.Location = new Point(708, 427);
			BTNdelete.Name = "BTNdelete";
			BTNdelete.Size = new Size(80, 29);
			BTNdelete.TabIndex = 11;
			BTNdelete.Text = "Eliminar";
			BTNdelete.UseVisualStyleBackColor = true;
			BTNdelete.Click += BTNdelete_Click;
			// 
			// BTNmodif
			// 
			BTNmodif.Anchor = AnchorStyles.None;
			BTNmodif.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BTNmodif.Location = new Point(618, 427);
			BTNmodif.MaximumSize = new Size(84, 29);
			BTNmodif.MinimumSize = new Size(84, 29);
			BTNmodif.Name = "BTNmodif";
			BTNmodif.Size = new Size(84, 29);
			BTNmodif.TabIndex = 12;
			BTNmodif.Text = "Modificar";
			BTNmodif.UseVisualStyleBackColor = true;
			BTNmodif.Click += btnModificar_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(cmbBoxCategorias);
			panel1.Controls.Add(lblNuevoProducto);
			panel1.Controls.Add(lblCategoria);
			panel1.Controls.Add(txtNombreProducto);
			panel1.Controls.Add(lblNombreProducto);
			panel1.Controls.Add(btnCargarProducto);
			panel1.Location = new Point(12, 112);
			panel1.Name = "panel1";
			panel1.Size = new Size(296, 322);
			panel1.TabIndex = 13;
			// 
			// btnNuevoProducto
			// 
			btnNuevoProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnNuevoProducto.Location = new Point(532, 427);
			btnNuevoProducto.Name = "btnNuevoProducto";
			btnNuevoProducto.Size = new Size(80, 29);
			btnNuevoProducto.TabIndex = 14;
			btnNuevoProducto.Text = "Nuevo";
			btnNuevoProducto.UseVisualStyleBackColor = true;
			btnNuevoProducto.Click += btnNuevoProducto_Click;
			// 
			// FormProducto
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 474);
			Controls.Add(panel1);
			Controls.Add(btnNuevoProducto);
			Controls.Add(BTNmodif);
			Controls.Add(BTNdelete);
			Controls.Add(lblProductos);
			Controls.Add(btnRefrescar);
			Controls.Add(lblTitulo);
			Controls.Add(dataGridViewProducto);
			Name = "FormProducto";
			Text = "FormProducto";
			Activated += FormProducto_Activated;
			Load += FormProducto_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
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
        private Button BTNdelete;
        private Button BTNmodif;
		private DataGridViewTextBoxColumn ColumnProductoId;
		private DataGridViewTextBoxColumn ColumnNombreProducto;
		private DataGridViewTextBoxColumn ColumnCategoria;
		private DataGridViewCheckBoxColumn ColumnHabilitado;
		private Panel panel1;
		private Button btnNuevoProducto;
	}
}