namespace WinForm
{
    partial class Form2
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
            btnCargarProducto = new Button();
            lblCategoria = new Label();
            lblNombreProducto = new Label();
            txtNombreProducto = new TextBox();
            cmbBoxCategorias = new ComboBox();
            BTNCancelar = new Button();
            SuspendLayout();
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarProducto.Location = new Point(12, 133);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(80, 29);
            btnCargarProducto.TabIndex = 12;
            btnCargarProducto.Text = "Guardar";
            btnCargarProducto.UseVisualStyleBackColor = true;
            btnCargarProducto.Click += btnCargarProducto_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 11;
            lblCategoria.Text = "Categoria";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(12, 77);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(51, 15);
            lblNombreProducto.TabIndex = 10;
            lblNombreProducto.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(12, 95);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(171, 23);
            txtNombreProducto.TabIndex = 9;
            // 
            // cmbBoxCategorias
            // 
            cmbBoxCategorias.FormattingEnabled = true;
            cmbBoxCategorias.Location = new Point(12, 27);
            cmbBoxCategorias.Name = "cmbBoxCategorias";
            cmbBoxCategorias.Size = new Size(171, 23);
            cmbBoxCategorias.TabIndex = 8;
            // 
            // BTNCancelar
            // 
            BTNCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNCancelar.Location = new Point(98, 133);
            BTNCancelar.Name = "BTNCancelar";
            BTNCancelar.Size = new Size(85, 29);
            BTNCancelar.TabIndex = 13;
            BTNCancelar.Text = "Cancelar";
            BTNCancelar.UseVisualStyleBackColor = true;
            BTNCancelar.Click += BTNCancelar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNCancelar);
            Controls.Add(btnCargarProducto);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(cmbBoxCategorias);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargarProducto;
        private Label lblCategoria;
        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
        private ComboBox cmbBoxCategorias;
        private Button BTNCancelar;
    }
}