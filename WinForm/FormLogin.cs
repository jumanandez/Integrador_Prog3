using Proyecto.Core.Business.Interfaces;
using System.Text;
using System.Security.Cryptography;
using Proyecto.Core.Entities;
using Proyecto.Core.Data;
using Proyecto.Core.Business;

namespace WinForm
{
	public partial class FormLogin : Form
	{
		private readonly IUsuarioBusiness _usuarioBusiness;
		private readonly ICategoriaBusiness _categoriaBusiness;
		private readonly IProductoBusiness _productoBusiness;
		public Usuario _loggedUser;
		public FormLogin(ICategoriaBusiness catbusi, IProductoBusiness produbusi, IUsuarioBusiness usuarioBusiness)
		{

			_usuarioBusiness = usuarioBusiness;
			_categoriaBusiness = catbusi;
			_productoBusiness = produbusi;
			InitializeComponent();
			textBox2.UseSystemPasswordChar = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool pass;
			if (_usuarioBusiness.CompareUserToDB(textBox1.Text))//obtener salt ya
			{
				var hashnew = CryptoHelper.HashPassword(textBox2.Text, _usuarioBusiness.GetUsuarioSalt(textBox1.Text));

				pass = hashnew.SequenceEqual(_usuarioBusiness.GetUsuarioHash(textBox1.Text));

				if (pass)
				{
					IngresarAlaAplicacion();
				}
				else
				{
					MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (textBox1.Text.Trim() == "")
			{
				MessageBox.Show("Usuario no puede estar vacio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (textBox2.Text.Trim() == "")
			{
				MessageBox.Show("Ingrese una contraseña!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show("Usuario y/o Contraseña Incorrecto!",
								"Pruebe otro Usuario y/o Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void linkCambioContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormCambioContraseña formCambioContraseña = new FormCambioContraseña(_usuarioBusiness);
			Hide();

			if (formCambioContraseña.ShowDialog() == DialogResult.OK)
			{
				_loggedUser = _usuarioBusiness.ObtainUsuario(textBox1.Text);
				MessageBox.Show("Contraseña Cambiada Con Exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				Show();
			}
			else
			{
				bool exit = false;
				while (!exit)
				{
					DialogResult operao = MessageBox.Show("Cancelar operacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (operao == DialogResult.Yes)
					{
						exit = true;
					}
					else
					{
						formCambioContraseña.ShowDialog();
					}
				}
				Show();
			}
		}

		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
			FormRegister registrarse = new FormRegister(_usuarioBusiness);
			Hide();

			if (registrarse.ShowDialog() == DialogResult.OK)
			{
				_loggedUser = _usuarioBusiness.ObtainUsuario(textBox1.Text);
				MessageBox.Show("Registrado Correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Show();
			}
			else
			{
				bool exit = false;
				while (!exit)
				{
					DialogResult operao = MessageBox.Show("Cancelar operacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (operao == DialogResult.Yes)
					{
						exit = true;
					}
					else
					{
						registrarse.ShowDialog();
					}
				}
				Show();
			}
		}
		private void IngresarAlaAplicacion()
		{
			_loggedUser = _usuarioBusiness.ObtainUsuario(textBox1.Text);
			Hide();
			FormProducto productosesion = new FormProducto(_categoriaBusiness, _productoBusiness, _usuarioBusiness, _loggedUser);
			if (productosesion.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("Rompiste todo!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				bool exit = false;
				while (!exit)
				{
					DialogResult operao = MessageBox.Show("Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (operao == DialogResult.Yes)
					{
						exit = true;
					}
					else
					{
						productosesion.ShowDialog();
					}
				}
			}

			DialogResult = DialogResult.OK;
		}
	}
}
