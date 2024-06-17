using Proyecto.Core.Entities;
using System.Data;
using Krypton.Toolkit;

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

            var compralist = from compra in _loggedUser.Compras
                             select compra;

            var ventalist = from venta in _loggedUser.Venta
                            select venta;


            foreach (var user in compralist)
            {
                dataGridViewCompras.Rows.Add(user.Producto.Nombre, user.Cantidad, user.Fecha);
            }
            foreach (var user in ventalist)
            {
                VentasDataGridView.Rows.Add(user.Producto.Nombre, user.Cantidad, user.Fecha);
            }
        }

        private void comprastimer_Tick(object sender, EventArgs e)
        {
            if (comprascollapsed)
            {
                panelCompras.Height += 15;
                if (panelCompras.Height == panelCompras.MaximumSize.Height)
                {
                    comprascollapsed = false;
                    comprastimer.Stop();
                }
            }
            else if (!comprascollapsed)
            {
                panelCompras.Height -= 15;
                if (panelCompras.Height == panelCompras.MinimumSize.Height)
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
