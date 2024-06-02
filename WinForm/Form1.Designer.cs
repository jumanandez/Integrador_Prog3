namespace WinForm
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dataGridView1 = new DataGridView();
			lblProductos = new Label();
			lblTitulo = new Label();
			ColumnProductoId = new DataGridViewTextBoxColumn();
			ColumnNombreProducto = new DataGridViewTextBoxColumn();
			ColumnCategoria = new DataGridViewTextBoxColumn();
			ColumnHabilitado = new DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnProductoId, ColumnNombreProducto, ColumnCategoria, ColumnHabilitado });
			dataGridView1.Location = new Point(12, 139);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(425, 284);
			dataGridView1.TabIndex = 0;
			// 
			// lblProductos
			// 
			lblProductos.AutoSize = true;
			lblProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblProductos.Location = new Point(12, 111);
			lblProductos.Name = "lblProductos";
			lblProductos.Size = new Size(97, 25);
			lblProductos.TabIndex = 1;
			lblProductos.Text = "Productos";
			// 
			// lblTitulo
			// 
			lblTitulo.AutoSize = true;
			lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitulo.Location = new Point(12, 9);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(289, 30);
			lblTitulo.TabIndex = 2;
			lblTitulo.Text = "Sistema de Control de Stock";
			// 
			// ColumnProductoId
			// 
			ColumnProductoId.HeaderText = "ID";
			ColumnProductoId.Name = "ColumnProductoId";
			ColumnProductoId.ReadOnly = true;
			// 
			// ColumnNombreProducto
			// 
			ColumnNombreProducto.HeaderText = "Nombre";
			ColumnNombreProducto.Name = "ColumnNombreProducto";
			// 
			// ColumnCategoria
			// 
			ColumnCategoria.HeaderText = "Categoria";
			ColumnCategoria.Name = "ColumnCategoria";
			// 
			// ColumnHabilitado
			// 
			ColumnHabilitado.HeaderText = "Habilitado";
			ColumnHabilitado.Name = "ColumnHabilitado";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblTitulo);
			Controls.Add(lblProductos);
			Controls.Add(dataGridView1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Label lblProductos;
		private DataGridViewTextBoxColumn ColumnProductoId;
		private DataGridViewTextBoxColumn ColumnNombreProducto;
		private DataGridViewTextBoxColumn ColumnCategoria;
		private DataGridViewCheckBoxColumn ColumnHabilitado;
		private Label lblTitulo;
	}
}
