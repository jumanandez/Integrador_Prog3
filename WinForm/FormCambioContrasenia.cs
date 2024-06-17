using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
using Krypton.Toolkit;

namespace WinForm
{
    public partial class FormCambioContrasena : KryptonForm
    {
        private readonly IUsuarioBusiness _usuarioBusiness;
        private readonly Usuario _loggerUser = null!;
        public FormCambioContrasena(IUsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
            InitializeComponent();
        }
        public FormCambioContrasena(IUsuarioBusiness usuarioBusiness, Usuario loggeduser)
        {
            _usuarioBusiness = usuarioBusiness;
            _loggerUser = loggeduser;
            InitializeComponent();
            txtNombreUsuario.Text = _loggerUser.Nombre;
            txtNombreUsuario.Enabled = false;
            txtContrasenaActual.Focus();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            string username = txtNombreUsuario.Text;
            string passActual = txtContrasenaActual.Text.Trim();
            string passNueva = txtNuevaContrasena.Text.Trim();

            bool coincideContraActual;
            if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("La nueva contraseña y la confirmacion no coinciden!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNombreUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Usuario no puede estar vacio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContrasenaActual.Text.Trim() == "")
            {
                MessageBox.Show("Contraseña Actual Vacia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNuevaContrasena.Text.Trim() == "")
            {
                MessageBox.Show("Contraseña Nueva Vacia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContrasenaActual.Text != txtNuevaContrasena.Text)
            {
                bool? result = _usuarioBusiness.ChangePass(username, passActual, passNueva);

                if (result == true)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (result == false)
                {
                    MessageBox.Show("La Contraseña Actual NO coincide!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (result == null)
                {
                    MessageBox.Show("Usuario No Encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("La Contraseña Nueva NO puede coincidir con la Actual!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtContraseñaActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtConfirmarContrasena.Focus();
            }
        }
        private void txtContrasenaActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNuevaContrasena.Focus();
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        private void txtContraseñaActual_KeyPress2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtConfirmarContrasena.Focus();
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        private void txtContraseñaActual_KeyPress3(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.AcceptButton = button1;//aceptar enter como click
                Point screenCoordinates = button1.PointToScreen(Point.Empty);//manda al puntero al centro del boton

                Cursor.Position = new Point(screenCoordinates.X + button1.Width / 2, screenCoordinates.Y + button1.Height / 2);
                btnCambiarContraseña_Click(this, new EventArgs());
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNuevaContrasena.UseSystemPasswordChar == true)
            {
                txtNuevaContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtNuevaContrasena.UseSystemPasswordChar = true;
            }
        }
    }
}
