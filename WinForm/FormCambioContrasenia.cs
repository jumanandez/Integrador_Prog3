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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForm
{
	public partial class FormCambioContrasena : Form
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
			txtNombreUsuario.Text = _loggerUser.Nombre;
			txtContrasenaActual.Focus();
            InitializeComponent();
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
