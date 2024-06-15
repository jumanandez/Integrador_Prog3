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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            //listView1.Columns.Add("Producto", 200, HorizontalAlignment.Left);
            //listView1.Columns.Add("Cantidad", 100, HorizontalAlignment.Left);
            //listView1.Columns.Add("Fecha", 150, HorizontalAlignment.Left);

            //var comprasGroup = new ListViewGroup("Compras", HorizontalAlignment.Left);
            //var ventasGroup = new ListViewGroup("Ventas", HorizontalAlignment.Left);

            //listView1.Groups.Add(comprasGroup);
            //listView1.Groups.Add(ventasGroup);

            //var compralist = from compra in _loggedUser.Compras
            //                 select compra;

            //var ventalist = from venta in _loggedUser.Venta
            //                select venta;

            //foreach (var user in compralist)
            //{
            //    listView1.Items.Add(new ListViewItem(new[] { user.Producto.Nombre, user.Cantidad.ToString(), user.Fecha.ToString("d/M/Y") }) { Group = comprasGroup });
            //}
            //foreach (var user in ventalist)
            //{
            //    listView1.Items.Add(new ListViewItem(new[] { user.Producto.Nombre, user.Cantidad.ToString(), user.Fecha.ToString("d/M/Y") }) { Group = ventasGroup });
            //}

        }
        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
