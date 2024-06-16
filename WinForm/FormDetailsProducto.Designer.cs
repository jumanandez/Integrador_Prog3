namespace WinForm
{
    partial class FormDetailsProducto
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            klblNombre = new Krypton.Toolkit.KryptonLabel();
            crownDockPanel1 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            lblCategoria = new Label();
            lblCompra = new Label();
            datagridCompras = new Krypton.Toolkit.KryptonDataGridView();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnCantidad = new DataGridViewTextBoxColumn();
            datagridVentas = new Krypton.Toolkit.KryptonDataGridView();
            ColumnFecha2 = new DataGridViewTextBoxColumn();
            ColumnCantidad2 = new DataGridViewTextBoxColumn();
            lblVentas = new Label();
            lblStock = new Label();
            BTNdelete = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            chkHabilitado = new ReaLTaiizor.Controls.CrownCheckBox();
            ((System.ComponentModel.ISupportInitialize)datagridCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridVentas).BeginInit();
            SuspendLayout();
            // 
            // controlBox1
            // 
            controlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBox1.BackColor = Color.FromArgb(30, 30, 30);
            controlBox1.CloseHoverColor = Color.FromArgb(230, 17, 35);
            controlBox1.DefaultLocation = false;
            controlBox1.EnableHoverHighlight = true;
            controlBox1.EnableMaximizeButton = false;
            controlBox1.EnableMinimizeButton = true;
            controlBox1.ForeColor = Color.FromArgb(155, 155, 155);
            controlBox1.Location = new Point(291, 3);
            controlBox1.MaximizeHoverColor = Color.FromArgb(30, 30, 30);
            controlBox1.MinimizeHoverColor = Color.FromArgb(30, 30, 30);
            controlBox1.Name = "controlBox1";
            controlBox1.RightToLeft = RightToLeft.No;
            controlBox1.Size = new Size(90, 25);
            controlBox1.TabIndex = 1;
            controlBox1.TabStop = false;
            controlBox1.Text = "controlBox1";
            // 
            // klblNombre
            // 
            klblNombre.Location = new Point(102, 105);
            klblNombre.Name = "klblNombre";
            klblNombre.Size = new Size(217, 31);
            klblNombre.StateCommon.ShortText.Color1 = SystemColors.ButtonFace;
            klblNombre.StateCommon.ShortText.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            klblNombre.TabIndex = 2;
            klblNombre.Values.Text = "Nombre Producto";
            // 
            // crownDockPanel1
            // 
            crownDockPanel1.BackColor = Color.FromArgb(60, 63, 65);
            crownDockPanel1.Location = new Point(-4, 174);
            crownDockPanel1.Name = "crownDockPanel1";
            crownDockPanel1.Size = new Size(385, 295);
            crownDockPanel1.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(60, 63, 65);
            lblCategoria.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            lblCategoria.ForeColor = SystemColors.ButtonFace;
            lblCategoria.Location = new Point(10, 186);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(101, 28);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria: ";
            // 
            // lblCompra
            // 
            lblCompra.AutoSize = true;
            lblCompra.BackColor = Color.FromArgb(60, 63, 65);
            lblCompra.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompra.ForeColor = SystemColors.ButtonFace;
            lblCompra.Location = new Point(47, 290);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(84, 26);
            lblCompra.TabIndex = 6;
            lblCompra.Text = "Compras";
            // 
            // datagridCompras
            // 
            dataGridViewCellStyle13.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle13.Font = new Font("Wingdings", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            dataGridViewCellStyle13.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.ButtonFace;
            datagridCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            datagridCompras.BorderStyle = BorderStyle.None;
            datagridCompras.ColumnHeadersHeight = 20;
            datagridCompras.Columns.AddRange(new DataGridViewColumn[] { ColumnFecha, ColumnCantidad });
            datagridCompras.Location = new Point(-4, 322);
            datagridCompras.Name = "datagridCompras";
            datagridCompras.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            datagridCompras.Size = new Size(192, 147);
            datagridCompras.TabIndex = 7;
            // 
            // ColumnFecha
            // 
            ColumnFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle14.Font = new Font("Poppins SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.ButtonFace;
            ColumnFecha.DefaultCellStyle = dataGridViewCellStyle14;
            ColumnFecha.HeaderText = "Fecha";
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.Width = 76;
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle15.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle15.Font = new Font("Wingdings", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            dataGridViewCellStyle15.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.ButtonFace;
            ColumnCantidad.DefaultCellStyle = dataGridViewCellStyle15;
            ColumnCantidad.HeaderText = "Cantidad";
            ColumnCantidad.Name = "ColumnCantidad";
            ColumnCantidad.Width = 75;
            // 
            // datagridVentas
            // 
            dataGridViewCellStyle16.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle16.Font = new Font("Wingdings", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            dataGridViewCellStyle16.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(35, 45, 150);
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.ButtonFace;
            datagridVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            datagridVentas.BorderStyle = BorderStyle.None;
            datagridVentas.Columns.AddRange(new DataGridViewColumn[] { ColumnFecha2, ColumnCantidad2 });
            datagridVentas.Location = new Point(189, 322);
            datagridVentas.Name = "datagridVentas";
            datagridVentas.Size = new Size(192, 147);
            datagridVentas.TabIndex = 8;
            datagridVentas.CellContentClick += kryptonDataGridView2_CellContentClick;
            // 
            // ColumnFecha2
            // 
            ColumnFecha2.DataPropertyName = "Fecha";
            ColumnFecha2.HeaderText = "Fecha";
            ColumnFecha2.Name = "ColumnFecha2";
            ColumnFecha2.Width = 77;
            // 
            // ColumnCantidad2
            // 
            ColumnCantidad2.DataPropertyName = "Cantidad";
            ColumnCantidad2.HeaderText = "Cantidad";
            ColumnCantidad2.Name = "ColumnCantidad2";
            ColumnCantidad2.Width = 74;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.BackColor = Color.FromArgb(60, 63, 65);
            lblVentas.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = SystemColors.ButtonFace;
            lblVentas.Location = new Point(253, 290);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(66, 26);
            lblVentas.TabIndex = 9;
            lblVentas.Text = "Ventas";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.FromArgb(60, 63, 65);
            lblStock.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            lblStock.ForeColor = SystemColors.ButtonFace;
            lblStock.Location = new Point(10, 250);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(61, 28);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock:";
            // 
            // BTNdelete
            // 
            BTNdelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BTNdelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNdelete.Location = new Point(276, 45);
            BTNdelete.MaximumSize = new Size(95, 35);
            BTNdelete.MinimumSize = new Size(95, 35);
            BTNdelete.Name = "BTNdelete";
            BTNdelete.OverrideDefault.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.OverrideDefault.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNdelete.OverrideDefault.Back.ColorAngle = 45F;
            BTNdelete.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            BTNdelete.OverrideDefault.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.OverrideDefault.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNdelete.OverrideDefault.Border.ColorAngle = 45F;
            BTNdelete.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNdelete.OverrideDefault.Border.Rounding = 8F;
            BTNdelete.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            BTNdelete.Size = new Size(95, 35);
            BTNdelete.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            BTNdelete.StateCommon.Back.ColorAngle = 45F;
            BTNdelete.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            BTNdelete.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            BTNdelete.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            BTNdelete.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            BTNdelete.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            BTNdelete.StateCommon.Border.ColorAngle = 45F;
            BTNdelete.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNdelete.StateCommon.Border.Rounding = 8F;
            BTNdelete.StateCommon.Content.AdjacentGap = 1;
            BTNdelete.StateCommon.Content.Image.ImageColorTo = Color.White;
            BTNdelete.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            BTNdelete.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            BTNdelete.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            BTNdelete.StateCommon.Content.ShortText.ColorAngle = 45F;
            BTNdelete.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            BTNdelete.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNdelete.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            BTNdelete.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            BTNdelete.StateTracking.Back.Color1 = Color.FromArgb(85, 90, 220);
            BTNdelete.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            BTNdelete.StateTracking.Back.ColorAngle = 135F;
            BTNdelete.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BTNdelete.StateTracking.Border.Rounding = 8F;
            BTNdelete.StateTracking.Content.ShortText.Color1 = Color.White;
            BTNdelete.StateTracking.Content.ShortText.Color2 = Color.White;
            BTNdelete.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            BTNdelete.TabIndex = 11;
            BTNdelete.Values.Text = "siguiente";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.Location = new Point(13, 45);
            kryptonButton1.MaximumSize = new Size(95, 35);
            kryptonButton1.MinimumSize = new Size(95, 35);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(60, 65, 190);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(55, 55, 170);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(60, 65, 190);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(60, 60, 175);
            kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.Rounding = 8F;
            kryptonButton1.OverrideDefault.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.Size = new Size(95, 35);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(60, 65, 190);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(55, 55, 170);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonButton1.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(60, 65, 190);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(60, 60, 175);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 8F;
            kryptonButton1.StateCommon.Content.AdjacentGap = 1;
            kryptonButton1.StateCommon.Content.Image.ImageColorTo = Color.White;
            kryptonButton1.StateCommon.Content.Padding = new Padding(30, -1, 0, -1);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.LightGray;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            kryptonButton1.StateCommon.Content.ShortText.ColorAngle = 45F;
            kryptonButton1.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(35, 45, 150);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(40, 45, 130);
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(85, 90, 220);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(70, 75, 195);
            kryptonButton1.StateTracking.Back.ColorAngle = 135F;
            kryptonButton1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Border.Rounding = 8F;
            kryptonButton1.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            kryptonButton1.TabIndex = 12;
            kryptonButton1.Values.Text = "anterior";
            // 
            // chkHabilitado
            // 
            chkHabilitado.AutoSize = true;
            chkHabilitado.CheckAlign = ContentAlignment.MiddleRight;
            chkHabilitado.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            chkHabilitado.Location = new Point(10, 215);
            chkHabilitado.Name = "chkHabilitado";
            chkHabilitado.Size = new Size(114, 32);
            chkHabilitado.TabIndex = 13;
            chkHabilitado.Text = "Habilitado";
            // 
            // FormDetailsProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(383, 466);
            Controls.Add(chkHabilitado);
            Controls.Add(kryptonButton1);
            Controls.Add(BTNdelete);
            Controls.Add(lblStock);
            Controls.Add(lblVentas);
            Controls.Add(datagridVentas);
            Controls.Add(datagridCompras);
            Controls.Add(lblCompra);
            Controls.Add(lblCategoria);
            Controls.Add(klblNombre);
            Controls.Add(controlBox1);
            Controls.Add(crownDockPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDetailsProducto";
            Text = "FormDetailsProducto";
            TransparencyKey = Color.Fuchsia;
            Activated += FormDetailsProducto_Activated;
            ((System.ComponentModel.ISupportInitialize)datagridCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private Krypton.Toolkit.KryptonLabel klblNombre;
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel1;
        private Label lblCategoria;
        private Label lblCompra;
        private Krypton.Toolkit.KryptonDataGridView datagridCompras;
        private Krypton.Toolkit.KryptonDataGridView datagridVentas;
        private Label lblVentas;
        private Label lblStock;
        private Krypton.Toolkit.KryptonButton BTNdelete;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private ReaLTaiizor.Controls.CrownCheckBox chkHabilitado;
        private DataGridViewTextBoxColumn ColumnFecha2;
        private DataGridViewTextBoxColumn ColumnCantidad2;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnCantidad;
    }
}