using Proyecto.Core.Entities;
using System.Data;
using Krypton.Toolkit;
using Proyecto.Core.Business.Interfaces;

namespace WinForm
{
    public partial class FormUserDetails : KryptonForm
    {
        private readonly IUsuarioBusiness _usuarioBusiness;
        bool comprascollapsed = true;
        bool ventascollapsed = true;
        public FormUserDetails(IUsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
            InitializeComponent();
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

        private void FormUserDetails_Activated(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = _usuarioBusiness.GetAllUsuarios();
            cmbUsuarios.DisplayMember = "Nombre";
            VentasDataGridView.AutoGenerateColumns = false;
            dataGridViewCompras.AutoGenerateColumns = false;
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var UserDetails = (Usuario)cmbUsuarios.SelectedItem;

            lblNombreProducto.Text = UserDetails.Nombre;

            var compralist = from compra in UserDetails.Compras
                             select compra;

            var ventalist = from venta in UserDetails.Venta
                            select venta;

            dataGridViewCompras.Rows.Clear();
            VentasDataGridView.Rows.Clear();

            foreach (var compra in compralist)
            {
                dataGridViewCompras.Rows.Add(compra.Producto.Nombre, compra.Cantidad, compra.Fecha);
            }
            
            foreach (var venta in ventalist)
            {
                VentasDataGridView.Rows.Add(venta.Producto.Nombre, venta.Cantidad, venta.Fecha);
            }
        }
    }
}
