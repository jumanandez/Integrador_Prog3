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
			lblCategorias = new Label();
			lblTitulo = new Label();
			txtNombreCategoria = new TextBox();
			lblNombreCategoria = new Label();
			btnCargarCategoria = new Button();
			btnRefresh = new Button();
			lblResultado = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 139);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(425, 284);
			dataGridView1.TabIndex = 0;
			// 
			// lblCategorias
			// 
			lblCategorias.AutoSize = true;
			lblCategorias.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblCategorias.Location = new Point(12, 111);
			lblCategorias.Name = "lblCategorias";
			lblCategorias.Size = new Size(102, 25);
			lblCategorias.TabIndex = 1;
			lblCategorias.Text = "Categorias";
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
			// txtNombreCategoria
			// 
			txtNombreCategoria.Location = new Point(443, 167);
			txtNombreCategoria.Name = "txtNombreCategoria";
			txtNombreCategoria.Size = new Size(145, 23);
			txtNombreCategoria.TabIndex = 3;
			// 
			// lblNombreCategoria
			// 
			lblNombreCategoria.AutoSize = true;
			lblNombreCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblNombreCategoria.Location = new Point(443, 139);
			lblNombreCategoria.Name = "lblNombreCategoria";
			lblNombreCategoria.Size = new Size(81, 25);
			lblNombreCategoria.TabIndex = 4;
			lblNombreCategoria.Text = "Nombre";
			// 
			// btnCargarCategoria
			// 
			btnCargarCategoria.Location = new Point(443, 196);
			btnCargarCategoria.Name = "btnCargarCategoria";
			btnCargarCategoria.Size = new Size(75, 23);
			btnCargarCategoria.TabIndex = 5;
			btnCargarCategoria.Text = "Cargar";
			btnCargarCategoria.UseVisualStyleBackColor = true;
			btnCargarCategoria.Click += button1_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(120, 113);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(75, 23);
			btnRefresh.TabIndex = 6;
			btnRefresh.Text = "Refrescar";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// lblResultado
			// 
			lblResultado.AutoSize = true;
			lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblResultado.Location = new Point(524, 200);
			lblResultado.Name = "lblResultado";
			lblResultado.Size = new Size(68, 15);
			lblResultado.TabIndex = 7;
			lblResultado.Text = "Resultado...";
			lblResultado.Click += lblResultado_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblResultado);
			Controls.Add(btnRefresh);
			Controls.Add(btnCargarCategoria);
			Controls.Add(lblNombreCategoria);
			Controls.Add(txtNombreCategoria);
			Controls.Add(lblTitulo);
			Controls.Add(lblCategorias);
			Controls.Add(dataGridView1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Label lblCategorias;
		private Label lblTitulo;
		private TextBox txtNombreCategoria;
		private Label lblNombreCategoria;
		private Button btnCargarCategoria;
		private Button btnRefresh;
		private Label lblResultado;
	}
}
