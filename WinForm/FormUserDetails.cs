using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Proyecto.Core.Business;
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
    public partial class FormUserDetails : KryptonForm
    {
        private readonly Usuario _loggedUser;
        public FormUserDetails(Usuario loggerUser)
        {
            InitializeComponent();
            _loggedUser = loggerUser;
            lblNombreProducto.Text = _loggedUser.Nombre;
            ListViewGroup compras = new ListViewGroup("Compras", HorizontalAlignment.Left);
            compras.CollapsedState = ListViewGroupCollapsedState.Collapsed;
            listView1.Groups.Add(compras);
            ListViewGroup ventas = new ListViewGroup("ventas", HorizontalAlignment.Right);
            ventas.CollapsedState = ListViewGroupCollapsedState.Collapsed;
            listView1.Groups.Add(ventas);
            var compralist = from compra in _loggedUser.Compras
                             select compra;
            var i = 0;

            foreach (var user in compralist)
            {
                ListViewItem Producto = new ListViewItem(user.Producto.Nombre, compras);
                Producto.SubItems.Add(user.Fecha.ToString("d/M/Y"));
                Producto.SubItems.Add(user.Cantidad.ToString());
                listView1.Items.Add(Producto);
                i++;
            }

        }
        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
