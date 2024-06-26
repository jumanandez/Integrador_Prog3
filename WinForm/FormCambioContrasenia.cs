﻿using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
using Krypton.Toolkit;
using WinForm.CustomMessageBox;

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

            if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
            {
                RJMessageBox.Show("La nueva contraseña y la confirmacion no coinciden!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNombreUsuario.Text.Trim() == "")
            {
                RJMessageBox.Show("Usuario no puede estar vacio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContrasenaActual.Text.Trim() == "")
            {
                RJMessageBox.Show("Contraseña Actual Vacia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNuevaContrasena.Text.Trim() == "")
            {
                RJMessageBox.Show("Contraseña Nueva Vacia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    RJMessageBox.Show("La Contraseña Actual NO coincide!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (result == null)
                {
                    RJMessageBox.Show("Usuario No Encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                RJMessageBox.Show("La Contraseña Nueva NO puede coincidir con la Actual!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                this.AcceptButton = btnconfirmar;//aceptar enter como click
                Point screenCoordinates = btnconfirmar.PointToScreen(Point.Empty);//manda al puntero al centro del boton

                Cursor.Position = new Point(screenCoordinates.X + btnconfirmar.Width / 2, screenCoordinates.Y + btnconfirmar.Height / 2);
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
