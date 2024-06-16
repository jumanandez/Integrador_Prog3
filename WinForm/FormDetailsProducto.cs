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
        public FormDetailsProducto(Producto producto, IProductoBusiness productoBusiness)
        {
            _productoBusiness = productoBusiness;
            _producto = producto;
            listaProductos = _productoBusiness.GetAll();
            InitializeComponent();
        }

        private void FormDetailsProducto_Activated(object sender, EventArgs e)
        {
            lblNombre.Text = _producto.Nombre;
            lblCategoria.Text = $"Categoria: {_producto.Categoria}";
            chkHabilitado.Checked = _producto.Habilitado;
            datagridCompras.DataSource = _producto.Compras.ToList();
            datagridVentas.DataSource = _producto.Venta.ToList();
            //Calcula stock
            var stock = _producto.Compras.Select(c => c.Cantidad).Sum() - _producto.Venta.Select(c => c.Cantidad).Sum();
            lblStock.Text = $"Stock: {stock}";
        }
        private void kryptonDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
