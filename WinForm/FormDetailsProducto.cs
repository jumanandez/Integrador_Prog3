using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
using System.Data;
using Krypton.Toolkit;

namespace WinForm
{
    public partial class FormDetailsProducto : KryptonForm
    {
        public Producto _producto;
        private readonly IProductoBusiness _productoBusiness;
        public List<Producto> _listaProductos;
        public int _currentPage = 1;
        private int _totalPages = 0;
        public FormDetailsProducto(Producto producto, IProductoBusiness productoBusiness)
        {
            _productoBusiness = productoBusiness;
            _producto = producto;
            _listaProductos = _productoBusiness.GetAll();
            _totalPages = _listaProductos.Count();
            _currentPage = _listaProductos.FindIndex(p => p.ProductoId == _producto.ProductoId) + 1;
            InitializeComponent();
            lblcustomcategoria.Text = _producto.Categoria.Nombre;
            datagridVentas.AutoGenerateColumns = false;
            datagridCompra.AutoGenerateColumns = false;

        }

        //Activacion de Form
        private void FormDetailsProducto_Activated(object sender, EventArgs e)
        {
            lblNombre.Text = _producto.Nombre;
            lblPagina.Text = $"{_currentPage} de {_totalPages}";
            if (_producto.Habilitado) switchHabilitado.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.On;
            else switchHabilitado.SwitchState = ReaLTaiizor.Controls.ParrotSwitch.State.Off;

            datagridCompra.DataSource = _producto.Compras.ToList();
            datagridVentas.DataSource = _producto.Venta.ToList();
            //Calcula stock
            var stock = _producto.Compras.Select(c => c.Cantidad).Sum() - _producto.Venta.Select(c => c.Cantidad).Sum();
            lblnumerostock.Text = stock < 2 ? $"{stock} Unidad" : $"{stock} Unidades";
            lblProductoid.Text = $"id: {_producto.ProductoId}";
        }

        #region Boton Modificar y Eliminar
        //PARA ESTA PARTE DE CODIGO MANEJAREMOS UN POCO DE LÓGICA
        //CON LOS RESULTADOS DEL DIALOGO ENTRE FORMULARIOS
        //  none   EL FORMULARIO SE CERRÓ POR EL BOTON CERRAR
        //  No EL FORMULARIO SE CIERRA Y LLAMA AL EVENTO CLICK DEL BOTON ELIMINAR PRODUCTO
        //  Yes EL FORMULARIO SE CIERRA Y LLAMA AL EVENTO CLICK DEL BOTON MODIFICAR PRODUCTO

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
            var anteriorProducto = Paginado(_currentPage - 1);

            if (anteriorProducto != null)
            {
                _producto = anteriorProducto;

                FormDetailsProducto_Activated(sender, e);
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            var siguienteProducto = Paginado(_currentPage + 1);

            if (siguienteProducto != null)
            {
                _producto = siguienteProducto;

                FormDetailsProducto_Activated(sender, e);
            }

        }
        private Producto? Paginado(int pagina)
        {
            if (pagina < 1) return null;

            var paginado = _productoBusiness.GetProductosPaginados(pagina, 1, null);

            var productoPaginado = paginado.Items.FirstOrDefault();


            if (productoPaginado != null)
            {
                _currentPage = pagina;
                _totalPages = paginado.TotalPaginas;
                lblPagina.Text = $"{_currentPage} de {_totalPages}";
            }
            return productoPaginado;
        }
        private void datagridCompra_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)//ignora los headers
            {
                var compra = (Compra)datagridCompra.Rows[e.RowIndex].DataBoundItem;//obtiene el objeto que necesita tooltip
                e.ToolTipText = $"Usuario: {compra.Usuario.Nombre}";//asigna a la fila el nombre de usuario como tooltip
            }
        }
        private void datagridVentas_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var ventas = (Venta)datagridVentas.Rows[e.RowIndex].DataBoundItem;
                e.ToolTipText = $"Usuario: {ventas.Usuario.Nombre}";
            }
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void switchHabilitado_MouseDown(object sender, MouseEventArgs e)
        {
            var tooltip = new ToolTip();

            if (switchHabilitado.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.On)
            {
                tooltip.SetToolTip(switchHabilitado, "Habilitado");
            }
            else if (switchHabilitado.SwitchState == ReaLTaiizor.Controls.ParrotSwitch.State.Off)
            {
                tooltip.SetToolTip(switchHabilitado, "Dehabilitado");
            }
        }
    }
}
