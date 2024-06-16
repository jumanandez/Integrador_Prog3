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
using Microsoft.VisualBasic.ApplicationServices;

namespace WinForm
{
    public partial class FormUserDetails : KryptonForm
    {
        private readonly Usuario _loggedUser;
        bool comprascollapsed = true;
        bool ventascollapsed = true;
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

            var compralist = from compra in _loggedUser.Compras
                             select compra;

            var ventalist = from venta in _loggedUser.Venta
                            select venta;

            //dataGridViewCompras.DataSource = compralist.ToList();


            foreach (var user in compralist)
            {
                dataGridViewCompras.Rows.Add(user.Producto.Nombre, user.Cantidad, user.Fecha);
            }
            foreach (var user in ventalist)
            {
                VentasDataGridView.Rows.Add(user.Producto.Nombre, user.Cantidad, user.Fecha);
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comprastimer_Tick(object sender, EventArgs e)
        {
            if (comprascollapsed)
            {
                panelfilter.Height += 15;
                if (panelfilter.Height == panelfilter.MaximumSize.Height)
                {
                    comprascollapsed = false;
                    comprastimer.Stop();
                }
            }
            else if (!comprascollapsed)
            {
                panelfilter.Height -= 15;
                if (panelfilter.Height == panelfilter.MinimumSize.Height)
                {
                    comprascollapsed = true;
                    comprastimer.Stop();
                }
            }
        }

        private void panelfilter_Click(object sender, EventArgs e)
        {
            BtnCompras.Image = comprascollapsed ? Properties.Resources.big_button2 : Properties.Resources.big_buttonD;
            comprastimer.Start();
        }

        private void Btnventas_Click(object sender, EventArgs e)
        {
            Btnventas.Image = ventascollapsed ? Properties.Resources.big_buttonVU : Properties.Resources.big_buttonVD;
            ventastimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!ventascollapsed)
            {
                panelventas.Height -= 15;
                if (panelventas.Height == panelventas.MinimumSize.Height)
                {
                    ventascollapsed = true;
                    ventastimer.Stop();
                }
            }
            else
            {
                panelventas.Height += 15;
                if (panelventas.Height == panelventas.MaximumSize.Height)
                {
                    ventascollapsed = false;
                    ventastimer.Stop();
                }
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
