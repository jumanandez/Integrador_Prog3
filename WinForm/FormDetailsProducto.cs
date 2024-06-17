using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace WinForm
{
    public partial class FormDetailsProducto : KryptonForm
    {
        private readonly Producto _producto;
        private readonly IProductoBusiness _productoBusiness;
        public List<Producto> listaProductos;
        //Variables auxiliares para manejo del tooltip 
        private int lastRowIndex = -1;
        private int lastColumnIndex = -1;//Grid Compra
        private int lastRowIndex2 = -1;
        private int lastColumnIndex2 = -1;//Grid Venta
        public FormDetailsProducto(Producto producto, IProductoBusiness productoBusiness)
        {
            _productoBusiness = productoBusiness;
            _producto = producto;
            listaProductos = _productoBusiness.GetAll();
            InitializeComponent();
            datagridVentas.AutoGenerateColumns = false;
            datagridCompra.AutoGenerateColumns = false;
        }

        //Activacion de Form
        private void FormDetailsProducto_Activated(object sender, EventArgs e)
        {
            lblNombre.Text = _producto.Nombre;
            lblCategoria.Text = $"Categoria: {_producto.Categoria}";

            if (_producto.Habilitado) switchHabilitado.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.On;
            else switchHabilitado.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;

            datagridCompra.DataSource = _producto.Compras.ToList();
            datagridVentas.DataSource = _producto.Venta.ToList();
            //Calcula stock
            var stock = _producto.Compras.Select(c => c.Cantidad).Sum() - _producto.Venta.Select(c => c.Cantidad).Sum();
            lblStock.Text = $"Stock: {stock} Unidades";
        }

        private void kryptonDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nose si use este, lo toque sin querer
        }

        private void datagridCompras_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.RowIndex != lastRowIndex || e.ColumnIndex != lastColumnIndex)
                {
                    // Actualiza los índices de la última fila y columna
                    lastRowIndex = e.RowIndex;
                    lastColumnIndex = e.ColumnIndex;

                    //var cell = datagridCompra.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    var compra = (Compra)datagridCompra.Rows[e.RowIndex].DataBoundItem;

                    var toolTip = new ToolTip();
                    toolTip.SetToolTip(datagridCompra, $"Usuario: {compra.Usuario.Nombre}");

                }
            }

        }

        private void datagridVentas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.RowIndex != lastRowIndex2 || e.ColumnIndex != lastColumnIndex2)
                {
                    // Actualiza los índices de la última fila y columna
                    lastRowIndex2 = e.RowIndex;
                    lastColumnIndex2 = e.ColumnIndex;

                    //var cell = datagridCompra.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    var venta = (Venta)datagridVentas.Rows[e.RowIndex].DataBoundItem;

                    var toolTip = new ToolTip();

                    toolTip.SetToolTip(datagridVentas, $"Usuario: {venta.Usuario.Nombre}");

                }
            }
        }
        #region Boton Modificar y Eliminar
        //PARA ESTA PARTE DE CODIGO MANEJAREMOS UN POCO DE LÓGICA
        //CON LOS RESULTADOS DEL DIALOGO ENTRE FORMULARIOS 
        //  none   EL FORMULARIO SE CERRÓ POR EL BOTON CERRAR
        //  No     EL FORMULARIO SE CIERRA Y LLAMA AL EVENTO CLICK DEL BOTON ELIMINAR PRODUCTO
        //  Yes    EL FORMULARIO SE CIERRA Y LLAMA AL EVENTO CLICK DEL BOTON MODIFICAR PRODUCTO

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void BTNmodif_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
        #endregion

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
