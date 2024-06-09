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
			lblTitulo = new Label();
			lblProductos = new Label();
			BTNdelete = new Button();
			BTNmodif = new Button();
			btnNuevoProducto = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
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
			Controls.Add(btnNuevoProducto);
			Controls.Add(BTNmodif);
			Controls.Add(BTNdelete);
			Controls.Add(lblProductos);
			Controls.Add(lblTitulo);
			Controls.Add(dataGridViewProducto);
			Name = "FormProducto";
			Text = "FormProducto";
			Activated += FormProducto_Activated;
			Load += FormProducto_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewProducto;
		private Label lblTitulo;
		private Label lblProductos;
        private Button BTNdelete;
        private Button BTNmodif;
		private DataGridViewTextBoxColumn ColumnProductoId;
		private DataGridViewTextBoxColumn ColumnNombreProducto;
		private DataGridViewTextBoxColumn ColumnCategoria;
		private DataGridViewCheckBoxColumn ColumnHabilitado;
		private Button btnNuevoProducto;
	}
}