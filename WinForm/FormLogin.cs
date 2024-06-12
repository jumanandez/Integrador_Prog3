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
		public Usuario User;
		public FormLogin(IUsuarioBusiness usuarioBusiness)
		{
			_usuarioBusiness = usuarioBusiness;
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
					MessageBox.Show("Contraseña Incorrecta");
				}
			}
			else if (textBox1.Text.Trim() == "")
			{
				MessageBox.Show("Usuario no puede estar vacio!");
			}
			else if (textBox2.Text.Trim() == "")
			{
				MessageBox.Show("Ingrese una contraseña!");
			}
			else
			{
				MessageBox.Show("Usuario y/o Contraseña Incorrecto!",
								"Pruebe otro Usuario y/o Contraseña");
			}
		}
		private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormRegister registrarse = new FormRegister(_usuarioBusiness);
			this.Hide();
			
			if (registrarse.ShowDialog() == DialogResult.OK)
			{
				this.User = _usuarioBusiness.ObtainUsuario(textBox1.Text);
                MessageBox.Show("Registrado Correctamente!");
                this.Show();
			}
			else
			{
                MessageBox.Show("Operacion cancelada!");
                this.Show();
			}
		}
		private void IngresarAlaAplicacion()
		{
			User = _usuarioBusiness.ObtainUsuario(textBox1.Text);
			this.DialogResult = DialogResult.OK;
			MessageBox.Show("Bienvenido");
			this.Close();
		}

		
	}
}
